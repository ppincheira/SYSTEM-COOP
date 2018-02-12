using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmTiposConexionesCrud
{
    public interface IVistaTiposConexionesCrud
    {
                                                                    
        string tcsCodigo { get; set; }                               
        string tcsDescripcion { get; set; }                        
        string tcsDescripcionCorta { get; set; }                   
        cmbLista srvCodigo { get; set; }                           
        string estCodigo { get; set; }                             
        bool nuevo { get; set; }
    }
}
