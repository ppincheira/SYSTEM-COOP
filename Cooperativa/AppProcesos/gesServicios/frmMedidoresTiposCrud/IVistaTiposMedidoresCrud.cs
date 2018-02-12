using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public interface IVistaTiposMedidoresCrud
    {
                                                                   // Permite valores nullos? y / n 
        long tmeCodigo { get; set; }                               //N
        string tmeDescripcion { get; set; }                        //N
        string tmeDescripcionCorta { get; set; }                   //N
        DateTime tmeFechaCarga { get; set; }                       //N
        cmbLista srvCodigo { get; set; }                           //N
        int usrNumero { get; set; }                                //N
        string estCodigo { get; set; }                             //Y

    }
}
