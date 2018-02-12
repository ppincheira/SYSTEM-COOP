using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmSuministrosAdmin
{
    public interface IVistaSuministrosAdmin
    {

        Boolean grupoFecha { get; set; }
        Boolean grupoEstado { get; set; }
        grdGrillaAdmin grilla { get; set; }
        DateTime fechaDesde { get; set; }
        DateTime fechaHasta { get; set; }
        cmbLista comboEstado { get; set; }
        string cantidad { set; }
    }
}
