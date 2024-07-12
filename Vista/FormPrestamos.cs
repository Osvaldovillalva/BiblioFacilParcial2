﻿using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormPrestamos : Form
    {
        private ControladoraPrestamos controladoraPrestamos; // Declarar una instancia de la controladora
        private ControladoraSocios controladoraSocios;
        private ControladoraLibros controladoraLibros;
        private ControladoraReglas controladoraReglas;
        private Carrito carrito = new Carrito();

        private SistemaBibliotecario contexto = new SistemaBibliotecario();

        public FormPrestamos()
        {
            InitializeComponent();

            controladoraPrestamos = new ControladoraPrestamos();
            controladoraSocios = new ControladoraSocios();
            controladoraLibros = new ControladoraLibros();
            controladoraReglas = new ControladoraReglas();

            carrito = new Carrito();
            carrito.LibrosSeleccionados = new List<Libro>();

            // Suscribir a los eventos SelectionChanged para los DataGridViews
            dgvSocios.SelectionChanged += dgvSocios_SelectionChanged;
            dgvLibros.SelectionChanged += dgvLibros_SelectionChanged;
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



        private void CargarDatosDataGridView()
        {
            // Obtén todos los préstamos de la base de datos utilizando la controladora
          

            // Carga los socios desde la controladora
            var socios = controladoraSocios.ObtenerTodosLosSocios();

            // Asigna los socios como la fuente de datos del DataGridView
            dgvSocios.DataSource = socios;

            var libros = controladoraLibros.ObtenerTodosLosLibros();

            // Asigna los libros como la fuente de datos del DataGridView
            dgvLibros.DataSource = libros;

        }

        private void FormPrestamos_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }








        private void buttonLimpiarLibro_Click(object sender, EventArgs e)
        {
            textBoxDatosLibro.Clear();
        }

        private void textBoxDatosSocio_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox de búsqueda
            string textoBusqueda = textBoxDatosSocio.Text;

            // Filtrar los socios en el DataGridView basados en el texto de búsqueda
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                // Filtrar los socios en el DataGridView basados en el texto de búsqueda
                List<Socio> sociosFiltrados = controladoraSocios.ObtenerSociosPorCoincidencia(textoBusqueda);

                // Actualizar el DataGridView con los socios filtrados
                dgvSocios.DataSource = sociosFiltrados;
            }
            else
            {
                // Si el texto de búsqueda está vacío, mostrar todos los socios en el DataGridView
                CargarDatosDataGridView();
            }
        }

        private void textBoxDatosLibro_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxDatosLibro.Text.Trim();

            // Verificar si el texto de búsqueda no está vacío
            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                // Realizar la búsqueda en la base de datos
                List<Libro> resultadosBusqueda = controladoraLibros.BuscarLibros(textoBusqueda);

                // Actualizar el DataGridView con los resultados de la búsqueda
                dgvLibros.DataSource = resultadosBusqueda;
            }
            else
            {
                // Si el texto de búsqueda está vacío, cargar todos los libros en el DataGridView
                CargarDatosDataGridView();
            }
        }

        private void buttonLimpiartodo_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            textBoxDatosLibro.Clear();
            textBoxDatosSocio.Clear();

            // Limpiar el ListBox
            listBoxCarrito.Items.Clear();

            // Limpiar los datos del carrito
            carrito.SocioSeleccionado = null;
            carrito.LibrosSeleccionados.Clear();
        }


        private void dgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count > 0)
            {
                // Obtener el socio seleccionado
                DataGridViewRow row = dgvSocios.SelectedRows[0];
                Socio socioSeleccionado = (Socio)row.DataBoundItem;

                // Actualizar el socio seleccionado en el carrito
                carrito.SocioSeleccionado = socioSeleccionado;

                // Establecer la fecha de préstamo
                carrito.FechaPrestamo = DateTime.Now;

                // Calcular la fecha de devolución
                ControladoraReglas controladoraReglas = new ControladoraReglas();
                carrito.FechaDevolucion = controladoraReglas.CalcularFechaDevolucion(carrito.FechaPrestamo);

                // Actualizar la información en el ListBox
                ActualizarListBoxCarrito();
            }
        }



        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                // Obtener el libro seleccionado
                DataGridViewRow row = dgvLibros.SelectedRows[0];
                Libro libroSeleccionado = (Libro)row.DataBoundItem;

                // Verificar si el libro ya está en el carrito
                if (!carrito.LibrosSeleccionados.Any(libro => libro.LibroId == libroSeleccionado.LibroId))
                {
                    // Agregar el libro seleccionado al carrito
                    carrito.LibrosSeleccionados.Add(libroSeleccionado);

                    // Actualizar la información en el ListBox
                    ActualizarListBoxCarrito();
                }
                else
                {
                    // Mostrar un mensaje si el libro ya está en el carrito
                    MessageBox.Show("¡El libro ya está en el carrito!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void ActualizarListBoxCarrito()
        {
            // Limpiar el ListBox antes de actualizarlo
            listBoxCarrito.Items.Clear();

            // Mostrar la información del socio seleccionado
            if (carrito.SocioSeleccionado != null)
            {
                listBoxCarrito.Items.Add($"Socio: {carrito.SocioSeleccionado.Nombre} {carrito.SocioSeleccionado.Apellido} (DNI: {carrito.SocioSeleccionado.Dni}, ID: {carrito.SocioSeleccionado.SocioId})");
                listBoxCarrito.Items.Add($"Fecha de Préstamo: {carrito.FechaPrestamo.ToShortDateString()}");
                listBoxCarrito.Items.Add($"Fecha de Devolución: {carrito.FechaDevolucion.ToShortDateString()}");
            }

            // Mostrar la información de los libros seleccionados
            foreach (var libro in carrito.LibrosSeleccionados)
            {
                listBoxCarrito.Items.Add($"Libro: {libro.LibroId} - {libro.Titulo} (Autor: {libro.Autor}, Ubicación: {libro.Ubicacion})");
            }
        }


        private void buttonGenerarPrestamo_Click(object sender, EventArgs e)
        {
            // Verificar si hay libros seleccionados en el carrito
            if (carrito.LibrosSeleccionados.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Por favor, seleccione al menos un libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que se haya seleccionado un socio
            if (carrito.SocioSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado un socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var contexto = new SistemaBibliotecario())
            {
                try
                {
                    foreach (var libro in carrito.LibrosSeleccionados)
                    {
                        // Verificar disponibilidad del libro
                        if (!controladoraLibros.VerificarDisponibilidadLibro(libro.LibroId))
                        {
                            MessageBox.Show($"El libro \"{libro.Titulo}\" no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Verificar que el socio esté habilitado
                    if (!controladoraSocios.SocioEstaHabilitado(carrito.SocioSeleccionado.SocioId))
                    {
                        MessageBox.Show($"El socio \"{carrito.SocioSeleccionado.Nombre} {carrito.SocioSeleccionado.Apellido}\" no está habilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Verificar cantidad máxima de libros prestados
                    int maxLibrosPrestados = controladoraReglas.ObtenerMaxLibrosPrestados();
                    if (carrito.LibrosSeleccionados.Count + carrito.SocioSeleccionado.CantidadLibros > maxLibrosPrestados)
                    {
                        MessageBox.Show($"El socio \"{carrito.SocioSeleccionado.Nombre} {carrito.SocioSeleccionado.Apellido}\" ha alcanzado el límite máximo de libros prestados ({maxLibrosPrestados}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Confirmar la generación de préstamos
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Se van a generar los siguientes préstamos:");
                    foreach (var libro in carrito.LibrosSeleccionados)
                    {
                        sb.AppendLine($"- Libro: {libro.Titulo}");
                    }
                    sb.AppendLine($"- Socio: {carrito.SocioSeleccionado.Nombre} {carrito.SocioSeleccionado.Apellido}");
                    sb.AppendLine($"- Fecha de Devolución: {carrito.FechaDevolucion}");
                    sb.AppendLine("¿Desea continuar y generar estos préstamos?");

                    DialogResult result = MessageBox.Show(sb.ToString(), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Generar los préstamos
                        List<Prestamo> prestamos = new List<Prestamo>();
                        // Dentro del método buttonGenerarPrestamo_Click
                        foreach (var libro in carrito.LibrosSeleccionados)
                        {
                            // Obtener el libro y el socio asociados al préstamo actual
                            Libro libroCompleto = contexto.Libros.FirstOrDefault(l => l.LibroId == libro.LibroId);
                            Socio socioCompleto = contexto.Socios.FirstOrDefault(s => s.SocioId == carrito.SocioSeleccionado.SocioId);

                            // Verificar que se hayan encontrado el libro y el socio
                            if (libroCompleto != null && socioCompleto != null)
                            {
                                // Generar el préstamo
                                Prestamo prestamo = new Prestamo
                                {
                                    FechaPrestamo = DateTime.Now,
                                    FechaDevolucion = carrito.FechaDevolucion,
                                    LibroId = libroCompleto.LibroId,
                                    SocioId = socioCompleto.SocioId,
                                    CarritoId = carrito.CarritoId, // Asignar el ID del carrito al préstamo
                                    EnPrestamo = true
                                };

                                prestamos.Add(prestamo);

                                // Cambiar el estado de disponibilidad del libro
                                controladoraLibros.CambiarEstadoDisponibilidadLibro(libro.LibroId);

                                // Incrementar la cantidad de libros prestados del socio
                                controladoraPrestamos.IncrementarCantidadLibrosPrestados(socioCompleto.SocioId);
                            }
                        }


                        controladoraPrestamos.GuardarPrestamos(prestamos);

                        // Obtener el PrestamoId del último préstamo generado
                        int ultimoPrestamoId = prestamos.Last().PrestamoId;

                        // Asignar el PrestamoId al carrito
                        carrito.PrestamoId = ultimoPrestamoId;

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Préstamos generados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar el carrito y actualizar la interfaz
                        carrito.SocioSeleccionado = null;
                        carrito.LibrosSeleccionados.Clear();
                        ActualizarListBoxCarrito();
                        textBoxDatosSocio.Clear();
                        textBoxDatosLibro.Clear();
                        CargarDatosDataGridView();

                        // Actualizar la base de datos (opcional)
                        contexto.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar los préstamos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        
        
       
    }




}















