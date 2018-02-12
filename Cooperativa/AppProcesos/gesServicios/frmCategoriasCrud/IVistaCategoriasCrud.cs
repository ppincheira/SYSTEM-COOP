using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmCategoriasCrud
{
    public interface IVistaCategoriasCrud
    {
        long scaNumero { get; set; }
        string Descripcion { get; set; }
        string DescripcionCorta { get; set; }
        Boolean estCodigo { get; set; }
        cmbLista srvCodigo { get; set; }
        cmbLista Grupo { get; set; }
        long grdCodigo { get; set; }
        string grdCodigoRegistro { get; set; }
    }
}

