using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Distritos {
        public Distritos() {
//			Accionistas = new List<Accionista>();
        }
        public virtual long DisNumero { get; set; }
        public virtual string DisDescripcion { get; set; }
        public virtual string EstCodigo { get; set; }
//        public virtual IList<Accionista> Accionistas { get; set; }
    }
}
