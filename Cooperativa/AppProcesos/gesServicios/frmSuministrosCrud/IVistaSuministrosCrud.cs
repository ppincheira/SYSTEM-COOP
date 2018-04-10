using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmSuministrosCrud
{
    public interface IVistaSuministrosCrud
    {

        long Numero { get; set; }
        //string SrvCodigo { get; set; }
        cmbLista Servicio { get; set; }
        //string TcsCodigo { get; set; }
        cmbLista TipoConexion { get; set; }
        //long ScaNumero { get; set; }
        cmbLista Categoria { get; set; }
        long? OrdenRuta { get; set; }
        long EmpNumero { get; set; }
        DateTime FechaAlta { get; set; }
        cmbLista EstCodigo { get; set; }
        float? ConsumoEstimado { get; set; }
        long? Voltaje { get; set; }
        string Conexion { get; set; }
        double? PotenciaL1 { get; set; }
        double? PotenciaL2 { get; set; }
        double? PotenciaL3 { get; set; }
        string PermiteCorte { get; set; }
        string Medido { get; set; }
        cmbLista Ruta { get; set; }
        //long SruNumero { get; set; }
        cmbLista Zona { get; set; }
        //long SzoNumero { get; set; }
        string PermiteFactura { get; set; }
        //int UsrNumero { get; set; }
        DateTime FechaCarga { get; set; }
        string strRazonSocial { get; set; }
        string strDomicilioEmpresa { get; set; }
        string strRespIva { get; set; }
        string strTipoDoc { get; set; }
        string strEmpDocumentoNumero { get; set; }
        long numSocio { get; set; }
        long numMedidor { get; set; }
        long numSerieMedidor { get; set; }
        string strModeloMedidor { get; set; }
        string strTipoMedidor { get; set; }
        string strFabricante { get; set; }
        string strLecturaModo { get; set; }
        long numDomicilio { get; set; }
        double? Registrador { get; set; }
        string strProvLoc { get; set; }
        string strBarrio { get; set; }
        string strCalle { get; set; }
        string strCalleNumero { get; set; }
        string strBloque { get; set; }
        string strDepartamento { get; set; }
        string strPiso { get; set; }
        grdGrillaAdmin grdSumConceptos  { get; set; }

    }
}
