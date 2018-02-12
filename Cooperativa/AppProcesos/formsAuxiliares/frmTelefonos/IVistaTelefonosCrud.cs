using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles.datos;

namespace AppProcesos.formsAuxiliares.frmTelefonos
{
    public interface IVistaTelefonosCrud
    {
        long telCodigo { get; set; }
        string telNumero { get; set; }
        cmbLista telCargo { get; set; }
        cmbLista telTipo { get; set; }
        Boolean telDefecto { get; set; }        
        string telEmail { get; set; }
        string telNombreContacto { get; set; }
        string tabCodigo { get; set; }       
        string telCodigoRegistro { get; set; }
    }
}
