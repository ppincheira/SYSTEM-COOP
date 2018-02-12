using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TelefonosEntidades
    {
        public TelefonosEntidades()
        {
        }
        public virtual long TeeNumero { get; set; }
        public virtual string TteNumero { get; set; }
        public virtual string TelCodigoRegistro { get; set; }
        public virtual long TelCodigo { get; set; }
        public virtual string TabCodigo { get; set; }
    }
}
