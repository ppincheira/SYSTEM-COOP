using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TiposIdentificadores
    {
        public TiposIdentificadores()
        {
        }
        public virtual string TidCodigo { get; set; }
        public virtual string TidDescripcion { get; set; }
        public virtual string TidDescripcionCorta { get; set; }
        public virtual string TidCodigoAfip { get; set; }
    }
}
