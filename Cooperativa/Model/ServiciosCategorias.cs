using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class ServiciosCategorias {
        public ServiciosCategorias() {
//			Suministros = new List<Suministro>();
        }
        public virtual long ScaNumero { get; set; }
        public virtual string ScaDescripcion { get; set; }
        public virtual string ScaDescripcionCorta { get; set; }
        public virtual string SrvCodigo { get; set; }
        public virtual string EstCodigo { get; set; }
//        public virtual IList<Suministro> Suministros { get; set; }
    }
}
