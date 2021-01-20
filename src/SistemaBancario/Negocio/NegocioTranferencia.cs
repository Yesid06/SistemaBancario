using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.Datos;
using SistemaBancario.Entidad;

namespace SistemaBancario.Negocio
{
    class NegocioTranferencia
    {
        DatosTranferencias datos = new DatosTranferencias();

        public bool RegistrarTranferencia(EntidadTransferencias tranferencia)
        {
            try
            {
                datos.RegistrarTranferencias(tranferencia);
                return true;
            }
            catch { return false; }
        }
    }
}
