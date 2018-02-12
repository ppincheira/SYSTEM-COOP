using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmCodigoPostal
{
    public interface IVistaCodigoPostalCrud
    {
        long cplNumero { get; set; }
        string txtiDescripcion { get; set; }
        string txtiCodigoPostal { get; set; }
        cmbLista cmbiLocalidad { get; set; }
        string codigoProvincia { get; set; }

    }
}
