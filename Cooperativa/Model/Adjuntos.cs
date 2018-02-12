using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adjuntos
    {
        public Adjuntos()
        {

        }
        public virtual long AdjCodigo { get; set; }  
        public virtual string TabCodigo { get; set; }
        public virtual string AdjCodigoRegistro { get; set; }
        public virtual string AdjNombre { get; set; }
        public virtual string AdjExtencion { get; set; }
        public virtual DateTime AdjFecha { get; set; }
        public virtual string AdjAdjunto { get; set; }
    }
}
