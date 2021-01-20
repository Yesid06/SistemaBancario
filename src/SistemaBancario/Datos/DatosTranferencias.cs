using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaBancario.Negocio;
using SistemaBancario.Entidad;

namespace SistemaBancario.Datos
{
    class DatosTranferencias
    {
        private readonly MySqlConnection conexion = new MySqlConnection("datasource=localhost; port=3306; user=root; password=root; database=SistemaBancario;");
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public void RegistrarTranferencias(EntidadTransferencias transferencias)
        {
            cmd = new MySqlCommand
            {
                CommandText = "update usuarios set monto = monto-"+transferencias.Valor+" where id='"+transferencias.Id+"'; "+
                "update usuarios set monto = monto+"+transferencias.Valor+" where id='"+transferencias.Cuenta+"'; " +
                "insert into transferencias values(default, '"+transferencias.Id+"', "+transferencias.Valor+", '"+transferencias.Cuenta+"', now());",
            Connection = conexion
            };
            conexion.Open();
            _ = cmd.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
        }
    }
}
