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
    public partial class Menu : Form
    {
        EntidadUsuario entidadusuario = new EntidadUsuario();
        public Menu(EntidadUsuario Eusuario)
        {
            InitializeComponent();
            entidadusuario = Eusuario;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label4.Text = entidadusuario.Id;
            label5.Text = entidadusuario.Nombres;
            label1.Text = entidadusuario.Monto.ToString("C0");
        }

        private void btnTransferencias_Click(object sender, EventArgs e)
        {
            Transferencias tranferencia = new Transferencias(entidadusuario);
            tranferencia.ShowDialog();
            label1.Text = tranferencia.Monto.ToString("C0");
            tranferencia.Dispose();
            entidadusuario.Monto = tranferencia.Monto;
        }

        private void btnRetiros_Click(object sender, EventArgs e)
        {
            Retiros retiros = new Retiros(entidadusuario);
            retiros.ShowDialog();
            label1.Text = retiros.Monto.ToString("C0");
            retiros.Dispose();
            entidadusuario.Monto = retiros.Monto;
        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {
            Depositos depositos = new Depositos(entidadusuario);
            depositos.ShowDialog();
            label1.Text = depositos.Monto.ToString("C0");
            depositos.Dispose();
            entidadusuario.Monto = depositos.Monto;
        }
    }
}
