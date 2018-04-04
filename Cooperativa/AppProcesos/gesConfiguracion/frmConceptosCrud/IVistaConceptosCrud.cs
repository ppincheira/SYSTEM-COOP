using Controles.datos;
using Controles.objects;
using System;
using Model;

namespace AppProcesos.gesConfiguracion.frmConceptosCrud
{
    public interface IVistaConceptosCrud
    {
        long logCptNumero { get; set; }
        string strCptCodigo { get; set; }
        string strCptDescripcion { get; set; }
        string strCptDescripcionCorta { get; set; }
        bool booCptControlaStock { get; set; }
        bool booCptFraccionado { get; set; }
        cmbLista cmbCumCodigo { get; set; }
        long? logCptCodigoBarra { get; set; }
        string strCptCodigoQr { get; set; }
        long? logCptCodigoPadre { get; set; }
        string strCodPadreDescripcion { get; set; }
        long? logCptCodigoEnvase { get; set; }
        string strCodEnvaseDescripcion { get; set; }
        long? logCptCodigoBonificacion { get; set; }
        string strCodBonificacionDescripcion { get; set; }
        long? logCptCodigoRecargo { get; set; }
        string strCodRecargoDescripcion { get; set; }
        int? intCptFraccionadoPor { get; set; }
        bool booCptMedible { get; set; }
        bool booCptFabricado { get; set; }
        decimal? decCptPeso { get; set; }
        decimal? decCptAncho { get; set; }
        decimal? decCptLargo { get; set; }
        decimal? decCptProfundidad { get; set; }
        decimal? decCptStockMinimo { get; set; }
        decimal? decCptStockMaximo { get; set; }
        decimal? decCptStockReposicion { get; set; }
        cmbLista cmbTicCodigo { get; set; }
        cmbLista cmbCodRubro { get; set; }
        cmbLista cmbCodLinea { get; set; }
        cmbLista cmbCodClase { get; set; }
        cmbLista cmbCodEstacionalidad { get; set; }
        bool booModificaCmpImp { get; set; }
        bool booModificaCmpDes { get; set; }
        bool booCptEstado { get; set; }
        grdGrillaEdit grdCptTipoCmp { get; set; }
        grdGrillaEdit grdCptFabricado { get; set; }
        string strCantidadComprobantes { set; }
        string strCantidadComponentes { set; }
        Adjuntos adjunto { get; set; }
        string adjuntoFileName { get; set; }
        pbxImagen pbxImagenP { get; set; }     
    }
}
