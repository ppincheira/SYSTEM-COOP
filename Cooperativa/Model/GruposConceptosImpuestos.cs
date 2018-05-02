using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GruposConceptosImpuestos
    {
        public virtual string GciCodigo { get; set; } // 10 caracteres no null
        public virtual string GciDescripcion { get; set; }//50 caracteres no null
        public virtual string TgcCodigo { get; set; }//50 caracteres no null
    }
}
