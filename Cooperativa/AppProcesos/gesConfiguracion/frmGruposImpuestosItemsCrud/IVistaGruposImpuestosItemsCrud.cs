using Controles.datos;
using Controles.objects;
using System;
using Model;

namespace AppProcesos.gesConfiguracion.GruposImpuestosItemsCrud
{
    public interface IVistaGruposImpuestosItemsCrud
    {
        int intGiiNumero { get; set; }
        cmbLista cmbTivCodigo { get; set; }
        decimal? decGiiPorcentaje { get; set; }
        DateTime datGiiVigenciaDesde { get; set; }
        DateTime? datGiiVigenciaHasta { get; set; }
        decimal? decGiiImporteMinimo { get; set; }
        decimal? decGiiImporteFijo { get; set; }
        decimal? decGiiImporteBaseMinimo { get; set; }
        cmbLista cmbPrsLocalidad { get; set; }
        cmbLista cmbPrsProvincia { get; set; }
        long     logCptConcepto { get; set; }
        string   strCptDescripcion { get; set; }
        cmbLista cmbGciGrupo { get; set; }
    }
}
