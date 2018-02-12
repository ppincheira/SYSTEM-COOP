using Controles.datos;
using System;

namespace AppProcesos.gesSeguridad.frmPersonasCrud
{
    public interface IVistaPersonasCrud
    {
        long logPrsNumero { get; set; }
        string strPrsApellido { get; set; }
        string strPrsNombre { get; set; }
        cmbLista cmbPrsCivil { get; set; }
        cmbLista cmbPrsSexo { get; set; }
        cmbLista cmbPrsTpoDni { get; set; }
        string strPrsNroDocumento { get; set; }
        DateTime datPrsNacimiento { get; set; }
        string strPrsLocalidad { get; set; }
        DateTime datPrsIngreso { get; set; }
        string strPrsCuil { get; set; }
        string strPrsLegajo { get; set; }
        cmbLista cmbPrsCargo { get; set; }
        DateTime datPrsBaja { get; set; }
        cmbLista cmbPrsBaja { get; set; }          
        Boolean booPrsEstado { get; set; }
    }
}
