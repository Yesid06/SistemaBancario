using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaBancario.Entidad;

namespace SistemaBancario.Datos
{
    class DatosRetiros
    {
        private readonly MySqlConnection conexion = new MySqlConnection("datasource=localhost; port=3306; user=root; password=root; database=SistemaBancario;");
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public void RegistrarRetiro(EntidadRetiros retiro)
        {
            cmd = new MySqlCommand
            {
                CommandText = "update usuarios set monto = monto -" + retiro.Valor + " where id='" + retiro.Id + "'; " +
                "insert into retiros values(default, '" + retiro.Id + "', " + retiro.Valor + ", '" + retiro.Establecimiento + "', now());",
                Connection = conexion
            };
            conexion.Open();
            _ = cmd.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
        }
    }
}
