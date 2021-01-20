using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entidad
{
    public class EntidadUsuario
    {
        public string Id { get; set; }
        public int TipoUsuario { get; set; }
        public string CC { get; set; }
        public int Monto { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
    }
}
