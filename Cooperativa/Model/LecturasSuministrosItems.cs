using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LecturasSuministrosItems
    {
        public virtual long lesCodigo { get; set; }
        public virtual long lecCodigo { get; set; }
        public virtual string lsiDescripcion { get; set; }
        public virtual long lsiLecturaAnterior { get; set; }
        public virtual long lsiLecturaActual { get; set; }
        public virtual long lsiCantidadUnidades { get; set; }
    }
}
