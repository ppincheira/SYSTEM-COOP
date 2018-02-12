using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LecturasConceptos
    {
        public virtual long LecCodigo { get; set; }
        public virtual string LecDescripcion { get; set; }
        public virtual string LecDescripcionCorta { get; set; }
        public virtual DateTime LecFechaAlta { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual int UsrCodigo { get; set; }

    }
}
