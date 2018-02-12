using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class TiposLocalidades {
        public TiposLocalidades() {
//			Localidades = new List<Localidade>();
        }
        public virtual string TloCodigo { get; set; }
        public virtual string TloDescripcion { get; set; }
//        public virtual IList<Localidade> Localidades { get; set; }
    }
}
