using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmCalles
{
    public interface IVistaCallesCrud
    {
        long codigo { get; set; }
        string codigoProvincia { get; set; }
        string txtDescripcion { get; set; }
        cmbLista cmbLocalidad { get; set; }
    }

}
