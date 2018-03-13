using Controles.datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmLecturasModosCrud
{
    public interface IVistaLecturasModosCrud
    {
        long lemCodigo { get; set; }                               //Y
        string lemDescripcion { get; set; }                        //N              
        DateTime lemFechaCarga { get; set; }                       //N
        cmbLista srvCodigo { get; set; }                           //N
        int usrCodigo { get; set; }                                //Y
        string estCodigo { get; set; }                        
        grdGrillaEdit conceptos { get; set; }

        void cargarGrilla(LecturasConceptos olc, int rows);

    }
}
