using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesConfiguracion
{
    public interface IVistaTiposComprobantesCrud
    {
        string editar { get; set; }
        string tcoCodigo { get; set; } // 3 caracteres no null
        string tcoDescripcion { get; set; }//30 caracteres no null
        string tcoLetra { get; set; } // 1 caracter nulo 
        string tcoOrigenNumerado { get; set; } // 1 caracher no null
        string tcoExterno { get; set; } //1 caracter no null
        int tcoCantidadCopias { get; set; }//  No null
        string pcbCodigo { get; set; } // 1 caracter    null
        string tcoCodigoAfip { get; set; } // 2 caracteres null
        string tcoLibroIvaCompras { get; set; } // 1 caracter null
        string tcoLibroIvaVentas { get; set; } // 1 caracter null
        string tcoCodigoSicore { get; set; } // 2 char null
        int tcmCantMinImpresion { get; set; } // null
        string tcoPreimpreso { get; set; } // 1 char no null
        string tcoCodigoRece { get; set; } // 2 char null
        string estCodigo { get; set; } // 1 char no null
    //    int cbpCodigo { get; set; } // 1 por el momento va a ser el unico valor que se le pasa
    }
}
