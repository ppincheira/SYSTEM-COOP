using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConceptosFabricados
    {
        public virtual long cfbCodigo { get; set; } 
        public virtual long cptCodigoFabricado { get; set; }
        public virtual long cptCodigoParte { get; set; }
        public virtual int cfbCantidadParte { get; set; }
    }
}
