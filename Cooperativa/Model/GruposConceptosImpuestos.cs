using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GruposConceptosImpuestos
    {
        public virtual string gciCodigo { get; set; } // 10 caracteres no null
        public virtual string gciDescripcion { get; set; }//50 caracteres no null
        public virtual string tgcCodigo { get; set; }//50 caracteres no null
    }
}
