using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TiposGruposConceptos
    {
        public virtual string tgcCodigo { get; set; } // 10 caracteres no null
        public virtual string tgcDescripcion { get; set; }//50 caracteres no null
    }
}
