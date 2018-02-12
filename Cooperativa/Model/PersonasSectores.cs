using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class PersonasSectores {
        public PersonasSectores(){
        }
        public virtual DateTime? PseFechaAlta { get; set; }
        public virtual DateTime? PseFechaBaja { get; set; }
        public virtual int PrsNumero { get; set; }
        public virtual string SecCodigo { get; set; }
        public virtual int DepNumero { get; set; }
        public virtual string AreCodigo { get; set; }
    }
}
