using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConceptosServicios
    {
        public virtual long cosCodigo { get; set; }
        public virtual long cptNumero { get; set; }
        public virtual string srvCodigo { get; set; }
        public virtual DateTime cosFechaCarga { get; set; }
    }
}
