using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormCobroCuotas : Form
    {
        private ControladoraSocios controladoraSocios;
        private ControladoraCuotas controladoraCuotas;
        private CarritoCuotasPendientes carritoCuotasPendientes;

        public FormCobroCuotas()
        {
            InitializeComponent();
            controladoraSocios = new ControladoraSocios();
            controladoraCuotas = new ControladoraCuotas();
            carritoCuotasPendientes = new CarritoCuotasPendientes
            {
                CuotasSeleccionadas = new List<CuotaMensual>()
            };

            dgvSocios.SelectionChanged += dgvSocios_SelectionChanged;
            dgvCuotasMensuales.SelectionChanged += dgvCuotasMensuales_SelectionChanged;
            this.StartPosition = FormStartPosition.Manual;

            // Establecer la ubicación del formulario en la pantalla (por ejemplo, en las coordenadas 100, 100)
            this.Location = new Point(100, 100);
            ConfigurarEventosMouseBotones(this);
        }
        private void ConfigurarEventosMouseBotones(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    // Asociar eventos MouseEnter y MouseLeave al botón
                    button.MouseEnter += (sender, e) => CambiarColorBoton(button, Color.MediumVioletRed);
                    button.MouseLeave += (sender, e) => CambiarColorBoton(button, Color.Black);
                }
            }
        }

        // Método para cambiar el color de fondo del botón
        private void CambiarColorBoton(Button button, Color color)
        {
            button.BackColor = color;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDatosSocio_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxDatosSocio.Text;

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                List<Socio> sociosFiltrados = controladoraSocios.ObtenerSociosPorCoincidencia(textoBusqueda);
                dgvSocios.DataSource = sociosFiltrados;
            }
            else
            {
                CargarDatosDataGridView();
            }
        }

        private void FormCobroCuotas_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            var socios = controladoraSocios.ObtenerTodosLosSocios();
            dgvSocios.DataSource = socios;

            var cuotas = controladoraCuotas.ObtenerTodasLasCuotas();
            dgvCuotasMensuales.DataSource = cuotas;
        }

        private void dgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count > 0)
            {
                int socioId = (int)dgvSocios.SelectedRows[0].Cells["SocioId"].Value;
                Socio socioSeleccionado = controladoraSocios.ObtenerSocioPorId(socioId);

                if (socioSeleccionado != null)
                {
                    carritoCuotasPendientes.SocioId = socioId;
                    carritoCuotasPendientes.SocioSeleccionado = socioSeleccionado;
                    carritoCuotasPendientes.CuotasSeleccionadas.Clear();
                    listBoxCarritoCuotas.Items.Clear();
                    listBoxCarritoCuotas.Items.Add($"Socio: {socioSeleccionado.Nombre} {socioSeleccionado.Apellido} (DNI: {socioSeleccionado.Dni})");
                    listBoxCarritoCuotas.Items.Add("------------------------------------------");
                    CargarCuotasPendientes(socioId);
                }
                else
                {
                    MessageBox.Show("El socio seleccionado no se encontró.");
                }
            }
        }

        private void CargarCuotasPendientes(int socioId)
        {
            var cuotasPendientes = controladoraCuotas.ObtenerCuotasPendientes(socioId);
            dgvCuotasMensuales.DataSource = cuotasPendientes;
        }

        private void dgvCuotasMensuales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCuotasMensuales.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCuotasMensuales.SelectedRows)
                {
                    CuotaMensual cuotaSeleccionada = row.DataBoundItem as CuotaMensual;
                    if (cuotaSeleccionada != null && !carritoCuotasPendientes.CuotasSeleccionadas.Contains(cuotaSeleccionada))
                    {
                        carritoCuotasPendientes.CuotasSeleccionadas.Add(cuotaSeleccionada);
                        listBoxCarritoCuotas.Items.Add($"Cuota: Año {cuotaSeleccionada.Año}, Mes {cuotaSeleccionada.Mes}, Valor: {cuotaSeleccionada.Valor}");
                    }
                }
            }
        }

        private void buttonGenerarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar las selecciones antes de proceder
                if (!ValidarSeleccionSocioCuota())
                {
                    return; // Si no se cumplen las validaciones, salir del método
                }

                // Mostrar los detalles del carrito de cuotas pendientes
                MostrarDetallesCarritoCuotasPendientes(carritoCuotasPendientes);

                // Verificar si alguna cuota está vencida y calcular el recargo
                List<CuotaMensual> cuotasVencidas = new List<CuotaMensual>();
                decimal totalRecargo = 0m;
                decimal totalCuotas = 0m;

                foreach (CuotaMensual cuota in carritoCuotasPendientes.CuotasSeleccionadas)
                {
                    decimal valorCuota = cuota.Valor ?? 0m;
                    totalCuotas += valorCuota;

                    if (controladoraCuotas.CuotaEstaVencida(cuota))
                    {
                        cuotasVencidas.Add(cuota);
                        decimal recargo = controladoraCuotas.CalcularRecargo(cuota);
                        totalRecargo += recargo;
                    }
                }

                // Mostrar mensaje si hay cuotas vencidas
                if (cuotasVencidas.Any())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Las siguientes cuotas están vencidas:");
                    foreach (CuotaMensual cuota in cuotasVencidas)
                    {
                        decimal recargo = controladoraCuotas.CalcularRecargo(cuota);
                        sb.AppendLine($"- Año {cuota.Año}, Mes {cuota.NumeroMes}, Valor Original: {cuota.Valor:C}, Recargo: {recargo:C}");
                    }
                    MessageBox.Show(sb.ToString(), "Cuotas Vencidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Calcular el total a pagar
                decimal totalAPagar = totalCuotas + totalRecargo;

                // Mostrar mensaje final con el total a pagar
                MessageBox.Show($"¡Pago generado correctamente! Total a pagar: {totalAPagar:C}", "Generación de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarDetallesCarritoCuotasPendientes(CarritoCuotasPendientes carrito)
        {
            if (carrito == null)
            {
                MessageBox.Show("El carrito de cuotas pendientes está vacío.", "Detalles del Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine($"ID del Socio: {carrito.SocioId}");
            sb.AppendLine($"Socio: {carrito.SocioSeleccionado.Nombre} {carrito.SocioSeleccionado.Apellido} (DNI: {carrito.SocioSeleccionado.Dni})");

            sb.AppendLine("\nCuotas Seleccionadas:");

            foreach (var cuota in carrito.CuotasSeleccionadas)
            {
                sb.AppendLine($"- Año: {cuota.Año}, Mes: {cuota.Mes}, Valor: {cuota.Valor}");
            }

            MessageBox.Show(sb.ToString(), "Detalles del Carrito de Cuotas Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarSeleccionSocioCuota()
        {
            // Verificar si se ha seleccionado un socio
            if (carritoCuotasPendientes.SocioSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un socio.", "Selección de Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // Verificar si se ha seleccionado al menos una cuota
            if (carritoCuotasPendientes.CuotasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una cuota.", "Selección de Cuotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // Si ambas validaciones son exitosas, retornar true
            return true;
        }


    }
}
