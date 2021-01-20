using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaBancario.Entidad;

namespace SistemaBancario.Datos
{
    class DatosDeposito
    {
        private readonly MySqlConnection conexion = new MySqlConnection("datasource=localhost; port=3306; user=root; password=root; database=SistemaBancario;");
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public void RegistrarDeposito(EntidadDepositos depositos)
        {
            cmd = new MySqlCommand
            {
                CommandText = "update usuarios set monto = monto +" + depositos.Valor + " where id='" + depositos.Id + "'; " +
                "insert into depositos values(default, '" + depositos.Id + "', " + depositos.Valor + ", '" + depositos.Establecimiento + "', now());",
                Connection = conexion
            };
            conexion.Open();
            _ = cmd.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
        }
    }
}
