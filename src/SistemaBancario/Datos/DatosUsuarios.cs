using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using SistemaBancario.Entidad;
using System.Data.Common;

namespace SistemaBancario.Datos
{
    class DatosUsuarios
    {
        private readonly MySqlConnection conexion = new MySqlConnection("datasource=localhost; port=3306; user=root; password=root; database=SistemaBancario;");
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public void CrearUsuario(EntidadUsuario usuario)//Crear un Usuario
        {
            cmd = new MySqlCommand
            {
                CommandText = "insert into usuarios values('" + usuario.Id + "', 1 , '" + usuario.CC + "', 1000000, '" + usuario.Nombres + "', '" + usuario.Correo + "', '" + usuario.Password + "');",
                Connection = conexion
            };
            conexion.Open();
            _ = cmd.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
        }

        public bool DuplicadoId(string id)//Buscar un ID Duplicado
        {
            bool existing;
            cmd = new MySqlCommand
            {
                CommandText = "select * from usuarios where id = '" + id + "';",
                Connection = conexion
            };
            conexion.Open();
            reader = cmd.ExecuteReader();
            existing = reader.HasRows;
            conexion.Close(); 
            conexion.Dispose();
            reader.Close();
            return existing;
        }
        public bool DuplicadoCC(string cc)//Buscar un CC Duplicado
        {
            bool existing;
            cmd = new MySqlCommand
            {
                CommandText = "select * from usuarios where cc = '" + cc + "';",
                Connection = conexion
            };
            conexion.Open();
            reader = cmd.ExecuteReader();
            existing = reader.HasRows;
            conexion.Close();
            conexion.Dispose();
            reader.Close();
            return existing;
        }
        public bool DuplicadoCorreo(string correo)//Buscar un Correo Duplicado
        {
            bool existing;
            cmd = new MySqlCommand
            {
                CommandText = "select * from usuarios where correo = '" + correo + "';",
                Connection = conexion
            };
            conexion.Open();
            reader = cmd.ExecuteReader();
            existing = reader.HasRows;
            conexion.Close();
            conexion.Dispose();
            reader.Close();
            return existing;
        }

        public EntidadUsuario IniciarSesion(string correo)//Buscar usuario por Correo
        {
            cmd = new MySqlCommand
            {
                CommandText = "select * from usuarios where correo = '" + correo + "';",
                Connection = conexion
            };
            conexion.Open();
            reader = cmd.ExecuteReader();
            EntidadUsuario usuario = new EntidadUsuario();
            while (reader.Read())
            {
                usuario.Id = reader.GetString(0);
                usuario.TipoUsuario = reader.GetInt32(1);
                usuario.CC = reader.GetString(2);
                usuario.Monto = reader.GetInt32(3);
                usuario.Nombres = reader.GetString(4);
                usuario.Correo = correo;
                usuario.Password = reader.GetString(6);
            }
            conexion.Close();
            conexion.Dispose();
            reader.Close();
            return usuario;
        }
    }
}
