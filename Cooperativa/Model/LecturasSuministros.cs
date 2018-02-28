using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LecturasSuministros
    {
        public virtual long lesCodigo { get; set; }
        public virtual DateTime lesFechaAlta { get; set; }
        public virtual DateTime lesFechaAnterior { get; set; }
        public virtual string lesPeriodo { get; set; }
        public virtual long sumNumero { get; set; }
        public virtual int medNumero { get; set; }
        public virtual int sruNumero { get; set; }
        public virtual long lemCodigo { get; set; }
        public virtual string estCodigo { get; set; }
        public virtual long cbpNumero { get; set; }


    }
}
