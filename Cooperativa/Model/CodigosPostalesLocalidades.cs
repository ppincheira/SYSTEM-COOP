using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class CodigosPostalesLocalidades {
        public CodigosPostalesLocalidades() {
        }
        public virtual long CplNumero { get; set; }
        public virtual string CplDescripcion { get; set; }
        public virtual string CplCodigoPostal { get; set; }
        public virtual int LocNumero { get; set; }

    }
}
