using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Provincias {
        public Provincias()
        {
        }
        public virtual string PrvCodigo { get; set; }
        public virtual string PaiCodigo { get; set; }
        public virtual string PrvDescripcion { get; set; }
    }
}
