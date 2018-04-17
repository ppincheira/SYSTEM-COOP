using Controles.datos;
using System;

namespace AppProcesos.gesConfiguracion.frmCuadrosTarifariosCrud
{
    public interface IVistaCuadrosTarifariosCrud
   {

        grdGrillaAdmin grillaCuadrosTarifarios { get; set; }
        grdGrillaAdmin grillaCategorias { get; set; }
        grdGrillaAdmin grillaConceptosCategorias { get; set; }
        grdGrillaAdmin grillaConceptosGenerales { get; set; }

    }
}
