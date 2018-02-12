using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Fabricantes {
        public Fabricantes() {
/*			tmeFabs = new List<TmeFab>();
			detallesModelosMedidores = new List<DetallesModelosMedidore>();
  */      }
        public virtual long FabNumero { get; set; }
        public virtual string FabDescripcion { get; set; }
        public virtual string FabHabilitado { get; set; }
        public virtual long EmpNumero { get; set; }
        public virtual int UsrNumero { get; set; }
        public virtual DateTime FabFechaCarga { get; set; }
//        public virtual IList<TmeFab> tmeFabs { get; set; }
//        public virtual IList<DetallesModelosMedidore> detallesModelosMedidores { get; set; }
    }
}
