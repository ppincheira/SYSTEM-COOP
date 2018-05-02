using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Transacciones
    {
        public virtual string traQuery { get; set; }
        public virtual string traParametroOutLog { get; set; }
        public virtual string traParametroInBlob { get; set; }
        public virtual byte[] traParametroBlob { get; set; }
    }
}
