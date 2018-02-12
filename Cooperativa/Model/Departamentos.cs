using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Departamentos {
        public Departamentos() {
        }
        public virtual int DepNumero { get; set; }
        public virtual string DepDescripcion { get; set; }
        public virtual string AreCodigo { get; set; }
    }
}
