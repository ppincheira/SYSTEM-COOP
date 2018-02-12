using Controles.datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmObservaciones
{
    public interface IVistaObservaciones
    {
        AdminObs oAdminObs { get; set; }
        grdGrillaAdmin grilla { get; set; }
        DateTime fechaDesde { get; set; }
        DateTime fechaHasta { get; set; }
        string cantidad { set; }
        string detalle { set; }
        string striRdoCodigo { get; set; }

    }
}
