using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entidad
{
    public class EntidadDepositos
    {
        public int Cod { get; set; }
        public string Id { get; set; }
        public int Valor { get; set; }
        public string Establecimiento { get; set; }
        public DateTime Fecha { get; set; }
    }
}
