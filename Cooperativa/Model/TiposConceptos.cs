using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TiposConceptos
    {
        public virtual string ticCodigo { get; set; } // 10 caracteres no null
        public virtual string ticDescripcion { get; set; }//50 caracteres no null
    }
}
