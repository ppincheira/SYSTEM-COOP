using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class ServiciosRutas {
        public ServiciosRutas() {
//			Suministros = new List<Suministro>();
        }
        public virtual long SruNumero { get; set; }
        public virtual string SruDescripcion { get; set; }
        public virtual string SruDescripcionCorta { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual string SrvCodigo { get; set; }
//        public virtual IList<Suministro> Suministros { get; set; }
    }
}
