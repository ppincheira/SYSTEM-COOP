using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class TiposMedidores {
        public TiposMedidores() {
/*			DetallesModelosMedidores = new List<DetallesModelosMedidore>();
			TiposMedidoresFabricantes = new List<TiposMedidoresFabricante>();
*/        }
        public virtual long TmeCodigo { get; set; }
        public virtual string TmeDescripcion { get; set; }
        public virtual string TmeDescripcionCorta { get; set; }
        public virtual DateTime TmeFechaCarga { get; set; }
        public virtual string SrvCodigo { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual int UsrNumero { get; set; }
/*        public virtual IList<DetallesModelosMedidore> DetallesModelosMedidores { get; set; }
        public virtual IList<TiposMedidoresFabricante> TiposMedidoresFabricantes { get; set; }
*/    }
}
