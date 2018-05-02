using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CuadrosTarifarios
    {
     
        public CuadrosTarifarios()
        {

        }
        public virtual long CdtCodigo { get; set; }
        public virtual DateTime? CdtFechaVigencia { get; set; }
        public virtual DateTime? CdtFechaAlta { get; set; }
        public virtual string SrvCodigo { get; set; }
    }

}
