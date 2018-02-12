using Controles.datos;
using Controles.contenedores;
using System;

namespace AppProcesos.formsAuxiliares.buscador
{
    public interface IVistaBuscador
    {
        Boolean grupoFecha { get; set; }
        Boolean grupoEstado { get; set; }
        grdGrillaAdmin grilla { get; set; }
        DateTime fechaDesde { get; set; }
        DateTime fechaHasta { get; set; }
        cmbLista comboBuscar { get; set; }
        string filtro { get; set; }
        cmbLista comboEstado { get; set; }
        string cantidad { set; }

    }
}
