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


        DateTime dtFechaDesde { get; set; }
        DateTime dtFechaHasta { get; set; }
        long sumNumero { get; set; }
        string strSuministro { get; set; }
        string strEstado { get; set; }
        string strZona { get; set; }
        string strCantidadMedidor { get; set; }
        string strCUIT { get; set; }
        string strTitular { get; set; }


        string strPeriodo { get; set; }
        string strRuta { get; set; }
        string strNroOrden { get; set; }
        string strModos { get; set; }
        string strFechaAlta { get; set; }
        string strCategoria { get; set; }

        
        
        string strFecha { get; set; }
        string strRegistrador { get; set; }
        string strDigitos { get; set; }
        string strTipoMedidor { get; set; }
        string strDecimal { get; set; }
        string strRubro { get; set; }
        string strNroTransaccion { get; set; }
        string strConexion { get; set; }
        grdGrillaEdit grdiLecturas { get; set; }

        Controles.datos.chkBox chkiTodos { get; set; }
        Controles.datos.chkBox chkiPendiente { get; set; }
        Controles.datos.chkBox chkiFacturado { get; set; }
        Controles.datos.chkBox chkiInstalado { get; set; }
        Controles.datos.chkBox chkiCorregido { get; set; }

    }
}
