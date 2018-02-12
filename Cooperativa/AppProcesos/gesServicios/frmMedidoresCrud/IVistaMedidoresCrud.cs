using Controles.datos;
using System;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public interface IVistaMedidoresCrud
    {

        long Numero { get; set; }
        long NumeroSerie { get; set; }
        cmbLista NumeroProv { get; set; }
        int Digitos { get; set; }
        string EstCodigo { get; set; }
        double FactorCalib { get; set; }
        decimal? GisX { get; set; }
        decimal? GisY { get; set; }
        int UsrNumero { get; set; } 
        DateTime FechaCarga { get; set; }
        cmbLista MmoCodigo { get; set; }

    }
}
