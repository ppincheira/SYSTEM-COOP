using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConceptosTiposComprobantes
    {
        public virtual string tcoCodigo { get; set; } // 3 caracteres no null        
        public virtual long cptNumero { get; set; }//  15 numero No null        
    }
}
