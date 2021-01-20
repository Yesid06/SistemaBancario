using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.Datos;
using SistemaBancario.Entidad;

namespace SistemaBancario.Negocio
{
    class NegocioDepositos
    {
        DatosDeposito datos = new DatosDeposito();

        public bool RegistrarDeposito(EntidadDepositos depositos)
        {
            try
            {
                datos.RegistrarDeposito(depositos);
                return true;
            }
            catch { return false; }
        }
    }
}
