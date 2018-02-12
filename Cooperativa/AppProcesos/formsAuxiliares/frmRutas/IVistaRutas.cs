using Controles.datos;

namespace AppProcesos.formsAuxiliares.frmRutas
{
    public interface IVistaRutas
    {

        string tabCodigo { get; set; }
        int srvNumero { get; set; }
        string srvDescripcion { get; set; }
        string srvCodigo { get; set; }
        string estCodigo { get; set; }
        string srvDescripcionCorta { set; }
        grdGrillaAdmin grilla { get; set; }
        string cantidad { set; }

    }
}
