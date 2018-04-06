using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmMedidoresModelosCrud
{
    public interface IVistaMedidoresModelosCrud
    {

        long Codigo { get; set; }
        string Descripcion { get; set; }
        string DescripcionCorta { get; set; }
        int? Digitos { get; set; }
        int? Decimales { get; set; }
        int? CantHilos { get; set; }
        int? KWVueltas { get; set; }
        string Amperaje { get; set; }
        int? Clase { get; set; }
        decimal? Registrador { get; set; }
        Controles.datos.cmbLista TipoContador { get; set; }
        Controles.datos.cmbLista TipoConexion { get; set; }
        Controles.datos.cmbLista FabNumero { get; set; }
        Controles.datos.cmbLista TMeCodigo { get; set; }
        int UsrNumero { get; set; }
        DateTime FechaCarga { get; set; }
        string EstCodigo { get; set; }

    }
}
