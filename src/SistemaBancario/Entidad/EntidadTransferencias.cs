using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entidad
{
    public class EntidadTransferencias
    {
        public int Cod { get; set; }
        public string Id { get; set; }
        public int Valor { get; set; }
        public string Cuenta { get; set; }
        public DateTime Fecha { get; set; }
    }
}
