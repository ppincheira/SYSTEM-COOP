using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConceptosImpuestosItems
    {
        public virtual long ciiNumero { get; set; }//50 caracteres no null
        public virtual long cptNumero { get; set; }//50 caracteres no null
        public virtual int giiNumero { get; set; }//50 caracteres no null        
        public virtual DateTime ciiVigenciaDesde { get; set; } // 10 caracteres no null
    }
}
