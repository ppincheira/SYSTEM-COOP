using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmTelefonos
{
    public interface IVistaTelefonos
    {
        string tabCodigo { get; set; }        
        string telCodigoRegistro { get; set; }
        grdGrillaAdmin grilla { get; set; }        
        string cantidad { set; }       
    }
}
