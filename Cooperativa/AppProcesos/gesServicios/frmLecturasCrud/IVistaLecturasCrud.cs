using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmLecturasCrud
{
    public interface IVistaLecturasCrud
    {

        long sumNumero { get; set; }
        string strSuministro { get; set; }
        string strRuta { get; set; }
        string strNroOrden { get; set; }
        string strNroSuministro { get; set; }
        string strFechaAlta { get; set; }
        string strCategoria { get; set; }
        string strTitular { get; set; }
        string strEstado { get; set; }
        string strZona { get; set; }
        string strCantidadMedidor { get; set; }
        string strFecha { get; set; }
        string strRegistrador { get; set; }
        string strDigitos { get; set; }
        string strTipoMedidor { get; set; }
        string strRubro { get; set; }
        string strNroTransaccion { get; set; }
        grdGrillaEdit grdiLecturas { get; set; }
    }
}
