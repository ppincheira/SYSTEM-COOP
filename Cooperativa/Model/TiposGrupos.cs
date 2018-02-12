using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class TiposGrupos {
        public TiposGrupos() {
			//Grupos = new List<Grupo>();
        }
        public virtual string TgrCodigo { get; set; }
        public virtual string TgrDescripcion { get; set; }
        public virtual string TabCodigo { get; set; }
        //public virtual IList<Grupo> Grupos { get; set; }
    }
}
