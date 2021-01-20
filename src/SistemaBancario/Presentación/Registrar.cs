using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SistemaBancario.Negocio;
using SistemaBancario.Entidad;

namespace SistemaBancario.Presentación
{
    public partial class Registrar : Form
    {
        NegocioUsuarios negocio = new NegocioUsuarios();

        public Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.Length != 10)
            {
                _ = MessageBox.Show("Identificacíon incompleta.");
            }
            else if (txtNombre.Text == "")
            {
                _ = MessageBox.Show("Nombre imcompleto.");
            }
            else if (txtCorreo.Text == "" || !NegocioUsuarios.ComprobarFormatoEmail(txtCorreo.Text))
            {
                _ = MessageBox.Show("Correo incompleto.");
            }
            else if (txtPassword.Text == "")
            {
                _ = MessageBox.Show("Contraseña imcompleta.");
            }
            else if (!negocio.ComprobarPw(txtPassword.Text))
            {
                _ = MessageBox.Show("La contraseña debe contener numeros y letras");
            }
            else if (negocio.DuplicadoCC(textBox1.Text))
            {
                _ = MessageBox.Show("Identificacíon ya registrada.");
            }
            else if (negocio.DuplicadoCorreo(txtCorreo.Text))
            {
                _ = MessageBox.Show("Correo ya regisrado.");
            }
            else
            {
                negocio.CrearUsuario(new EntidadUsuario()
                {
                    CC = textBox1.Text,
                    Nombres = txtNombre.Text,
                    Correo = txtCorreo.Text,
                    Password = txtPassword.Text
                });
                Close();
            }
        }
    }
}
