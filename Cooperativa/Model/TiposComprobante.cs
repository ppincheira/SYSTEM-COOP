using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TiposComprobante
    {
        public virtual string tcoCodigo { get; set; } // 3 caracteres no null
        public virtual string tcoDescripcion { get; set; }//30 caracteres no null
        public virtual string tcoLetra { get; set; } // 1 caracter nulo 
        public virtual string tcoOrigenNumerado { get; set; } // 1 caracher no null
        public virtual string tcoExterno { get; set; } //1 caracter no null
        public virtual int tcoCantidadCopias { get; set; }//  No null
        public virtual string pcbCodigo { get; set; } // 1 caracter    null
        public virtual string tcoCodigoAfip { get; set; } // 2 caracteres null
        public virtual string tcoLibroIvaCompras { get; set; } // 1 caracter null
        public virtual string tcoLibroIvaVentas { get; set; } // 1 caracter null
        public virtual string tcoCodigoSicore { get; set; } // 2 char null
        public virtual int tcmCantMinImpresion { get; set; } // null
        public virtual string tcoPreimpreso { get; set; } // 1 char no null
        public virtual string tcoCodigoRece { get; set; } // 2 char null
        public virtual string estCodigo { get; set; } // 1 char no null
        public virtual int cbpCodigo { get; set; } // 1 por el momento va a ser el unico valor que se le pas
    }
}
