using Controladora;
using System.Diagnostics.Eventing.Reader;

namespace Vista
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxContrase�a.Clear();
            textBoxUsuario.Clear();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "admin" && textBoxContrase�a.Text == "123")
            {
                ControladoraMultas controladoraMultas = new ControladoraMultas();
                controladoraMultas.VerificarYActualizarEstadoSociosMultados();
                MostrarFormMenu(controladoraMultas);

            }
            else
            {
                MessageBox.Show("Los datos son incorrectos");

                textBoxContrase�a.Clear();
                textBoxUsuario.Clear();
            }





        }
        private void MostrarFormMenu(ControladoraMultas controladoraMultas)
        {
            FormMenu formMenu = new FormMenu(controladoraMultas);
            formMenu.FormClosed += (s, args) => this.Close(); // Cierra la aplicaci�n cuando se cierre el formulario del men�
            formMenu.Show();
            this.Hide(); // Oculta el formulario de inicio de sesi�n despu�s de mostrar el men�
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
