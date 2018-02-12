using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmMiniListado
{
    public interface IVistaMiniListado
    {
        string tabCodigo { get; set; }
        string codigoRegistro { get; set; }
        string filtro { get; set; }
        grdGrillaAdmin gviListado { get; set; }
        string cantidad { set; }
    }
}
