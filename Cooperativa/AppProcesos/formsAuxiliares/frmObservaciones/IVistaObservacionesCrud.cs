using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmObservaciones
{
    public interface IVistaObservacionesCrud
    {

        long codigo { get; set; }
        int tipoObservaciones { get; set; }
        string codigoRegistro { get; set; }
        Boolean obsDefecto { get; set; }
        DateTime fecha { get; set; }
        string detalle { get; set; }
        Adjuntos adjunto { get; set; }
        string adjuntoFileName { get; set; }
       


    }
}
