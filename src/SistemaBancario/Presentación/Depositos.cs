using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBancario.Entidad;
using SistemaBancario.Negocio;

namespace SistemaBancario.Presentación
{
    public partial class Depositos : Form
    {
        public int Monto = 0;
        NegocioDepositos depositos = new NegocioDepositos();
        private EntidadUsuario eUsuario = new EntidadUsuario();

        public Depositos(EntidadUsuario usuario)
        {
            InitializeComponent();
            eUsuario = usuario;
        }

        private void Depositos_Load(object sender, EventArgs e)
        {
            label1.Text = eUsuario.Id;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("No puede depositar $0.");
            }
            else if (txtEsta.Text == "")
            {
                _ = MessageBox.Show("El establecimento no puede estar vacío.");
            }
            else if(depositos.RegistrarDeposito(new EntidadDepositos()
            {
                Id = eUsuario.Id,
                Establecimiento = txtEsta.Text,
                Valor = Convert.ToInt32(numericUpDown1.Value)
            }))
            {
                Monto = eUsuario.Monto + Convert.ToInt32(numericUpDown1.Value);
                Close();
            }
            else
            {
                MessageBox.Show("Error al retirar");
            }
        }
    }
}
