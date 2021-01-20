using System;
using System.Windows.Forms;
using SistemaBancario.Negocio;
using SistemaBancario.Entidad;

namespace SistemaBancario.Presentación
{
    public partial class Login : Form
    {
        private readonly NegocioUsuarios negocio = new NegocioUsuarios();
        private EntidadUsuario usuario = new EntidadUsuario();

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            usuario = negocio.IniciarSesion(txtCorreo.Text);
            if (usuario.Id == null)
            {
                MessageBox.Show("La cuenta no se encuentra registrada");
            }
            else if (usuario.Password != txtPassword.Text)
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
            else if (usuario.TipoUsuario == 2)
            {
                MessageBox.Show("Cuenta Suspendida");
            }
            else
            {
                Hide();
                Menu menu = new Menu(usuario);
                menu.ShowDialog();
                Show();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            Hide();
            _ = registrar.ShowDialog();
            Show();
            registrar.Dispose();
        }
    }
}
