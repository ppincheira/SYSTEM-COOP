using Controles.Fecha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmLecturasConceptosCrud
{
    public interface IVistaLecturasConceptosCrud
    {
        long lecCodigo { get; set; }                        //no null
        string lecDescripcion { get; set; }                 //null, 30 caracteres
        string lecDescripcionCorta { get; set; }            //null, 10 caracteres
        dtpFecha lecFechaAlta { get; set; }                 //null
        string estCodigo { get; set; }                      //null
        int usrCodigo { get; set; }                         //no null
    }
}
