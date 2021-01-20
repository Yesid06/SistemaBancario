using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBancario.Negocio;
using SistemaBancario.Entidad;

namespace SistemaBancario.Presentación
{
    public partial class Retiros : Form
    {
        public int Monto = 0;
        NegocioRetiros Ntranferencia = new NegocioRetiros();
        private EntidadUsuario eUsuario = new EntidadUsuario();

        public Retiros(EntidadUsuario usuario)
        {
            InitializeComponent();
            eUsuario = usuario;
        }

        private void Retiros_Load(object sender, EventArgs e)
        {
            label1.Text = eUsuario.Monto.ToString("C0");
            label4.Text = label1.Text;
            numericUpDown1.Maximum = eUsuario.Monto;
            Monto = eUsuario.Monto;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = (eUsuario.Monto - numericUpDown1.Value).ToString("C0");
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("No puede retirar $0.");
            }
            else if (txtEsta.Text == "")
            {
                _ = MessageBox.Show("El establecimento no puede estar vacío.");
            }
            else if (txtPassword.Text != eUsuario.Password)
            {
                _ = MessageBox.Show("Contraseña incorrecta.");
            }
            else if (Ntranferencia.RegistrarRetiro(         
                new EntidadRetiros()
                    {
                        Id = eUsuario.Id,
                        Establecimiento = txtEsta.Text,
                        Valor = Convert.ToInt32(numericUpDown1.Value)
                    }))
            {
                Monto = eUsuario.Monto - Convert.ToInt32(numericUpDown1.Value);
                Close();
            }
            else
            {
                MessageBox.Show("Error al retirar");
            }
        }
    }
}
