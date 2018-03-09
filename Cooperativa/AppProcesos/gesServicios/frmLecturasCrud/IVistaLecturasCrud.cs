using Controles.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmLecturasCrud
{
    interface IVistaLecturasCrud
    {

        long lemCodigo { get; set; }
        string strSuministro { get; set; }
        string strRuta { get; set; }
        string strNroOrden { get; set; }
        string strNroSuministro { get; set; }

        grdGrillaEdit grdiLecturas { get; set; }


    }
}
