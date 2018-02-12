using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class ServiciosZonas {
        public ServiciosZonas() {
//			Suministros = new List<Suministro>();
        }
        public virtual long SzoNumero { get; set; }
        public virtual string SzoDescripcion { get; set; }
        public virtual string SzoDescripcionCorta { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual string SrvCodigo { get; set; }
//        public virtual IList<Suministro> Suministros { get; set; }
    }
}
