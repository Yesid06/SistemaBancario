using System;

using SistemaBancario.Entidad;
using SistemaBancario.Datos;
using SistemaBancario.Presentación;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaBancario.Negocio
{
    class NegocioUsuarios
    {
        private readonly DatosUsuarios datos = new DatosUsuarios();

        public void CrearUsuario(EntidadUsuario nuevousuario)
        {
            do
            {
                nuevousuario.Id = Aleatorio();
            }
            while (datos.DuplicadoId(nuevousuario.Id));

            datos.CrearUsuario(nuevousuario);

            MessageBox.Show("Su usuario, fue creado con éxito.");
        }

        public bool DuplicadoCC(string cc)
        {
            return datos.DuplicadoCC(cc);
        }

        public bool DuplicadoCorreo(string correo)
        {
            return datos.DuplicadoCorreo(correo);
        }

        private string Aleatorio()
        {
            Random random = new Random();
            return random.Next(10000, 99999).ToString() + random.Next(99999).ToString().PadLeft(5, '0');
        }

        public EntidadUsuario IniciarSesion(string Iusuario)
        {
            return datos.IniciarSesion(Iusuario);
        }

        public bool ComprobarPw(string pw)
        {
            char[] vs = pw.ToCharArray();

            bool Letras = false;
            bool Numeros = false;

            foreach (char a in vs)
            {
                if (char.IsLetter(a))
                    Letras = true;
                if (char.IsDigit(a))
                    Numeros = true;
            }

            return Letras && Numeros;
        }

        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0) return true;
                else return false;
            }
            else return false;
        }
    }
}
