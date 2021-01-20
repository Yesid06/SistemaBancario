using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.Datos;
using SistemaBancario.Entidad;

namespace SistemaBancario.Negocio
{
    class NegocioRetiros
    {
        DatosRetiros datos = new DatosRetiros();

        public bool RegistrarRetiro(EntidadRetiros retiros)
        {
            try
            {
                datos.RegistrarRetiro(retiros);
                return true;
            }
            catch { return false; }
        }
    }
}
