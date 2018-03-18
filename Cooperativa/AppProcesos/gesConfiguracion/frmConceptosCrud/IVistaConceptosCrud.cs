using Controles.datos;
using System;

namespace AppProcesos.gesConfiguracion.frmConceptosCrud
{
    public interface IVistaConceptosCrud
    {
        long logCptNumero { get; set; }
        string strCptCodigo { get; set; }
        string strCptDescripcion { get; set; }
        string strCptDescripcionCorta { get; set; }
        Boolean booCptControlaStock { get; set; }
        Boolean booCptFraccionado { get; set; }
        cmbLista cmbCumCodigo { get; set; }
        long? logCptCodigoBarra { get; set; }
        string strCptCodigoQr { get; set; }
        long? logCptCodigoPadre { get; set; }
        string strCodPadreDescripcion { get; set; }
        int? intCptFraccionadoPor { get; set; }
        Boolean booCptMedible { get; set; }
        Boolean booCptFabricado { get; set; }
        decimal? decCptPeso { get; set; }
        decimal? decCptAncho { get; set; }
        decimal? decCptLargo { get; set; }
        decimal? decCptProfundidad { get; set; }
        decimal? decCptStockMinimo { get; set; }
        decimal? decCptStockMaximo { get; set; }
        decimal? decCptStockReposicion { get; set; }
        cmbLista cmbTicCodigo { get; set; }
        Boolean booCptEstado { get; set; }
        grdGrillaAdmin grdCptTipoCmp { get; set; }
        string strCantidad { set; }
    }
}
