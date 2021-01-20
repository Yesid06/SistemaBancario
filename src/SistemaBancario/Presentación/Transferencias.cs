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
    public partial class Transferencias : Form
    {
        public int Monto = 0;
        NegocioTranferencia Ntranferencia = new NegocioTranferencia();
        private EntidadUsuario eUsuario = new EntidadUsuario();
        public Transferencias(EntidadUsuario Eusuario)
        {
            InitializeComponent();
            eUsuario = Eusuario;
        }

        private void Transferencias_Load(object sender, EventArgs e)
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

        private void btnTranferir_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("No puede transferir $0.");
            }
            else if(Ntranferencia.RegistrarTranferencia(new EntidadTransferencias()
            {
                Id = eUsuario.Id,
                Cuenta = txtCuenta.Text,
                Valor = Convert.ToInt32(numericUpDown1.Value)
            }))
            {
                Monto = eUsuario.Monto - Convert.ToInt32(numericUpDown1.Value);
                Close();
            }
            else MessageBox.Show("Error al tranferir");
        }
    }
}
