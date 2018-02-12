using Controles.datos;
using Controles.Fecha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmFabricantesCrud
{
    public interface IVistaFabricantesCrud
    {
        long fabNumero { get; set; }
        string fabDescripcion { get; set; }
        chkBox fabHabilitado { get; set; }
        cmbLista empNumero { get; set; }
        dtpFecha fabFechaCarga { get; set; }
        int usrNumero { get; set; }


    }
}
