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
        grdGrillaEdit conceptos { get; set; }


    }
}
