using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.formAdmin
{
    public interface IVistaFormAdmin
    {

        Boolean grupoFecha { get; set; }
        Boolean grupoEstado { get; set; }
        grdGrillaAdmin grilla { get; set; }
        grdGrillaAdmin grillaFiltro { get; set; }
        DateTime fechaDesde { get; set; }
        DateTime fechaHasta { get; set; }
        cmbLista comboBuscar { get; set; }
        cmbLista comboBuscarA { get; set; }
        cmbLista comboOpcionesA { get; set; }
        string filtro { get; set; }
        cmbLista comboEstado { get; set; }
        string cantidad { set; }
        string striRdoCodigo { get; set; }
        string striValor1 { get; set; }
        string striValor2 { get; set; }
        string striValor3 { get; set; }
        string striValor4 { get; set; }
        string striValor5 { get; set; }
        string striValor6 { get; set; }
    }
}
