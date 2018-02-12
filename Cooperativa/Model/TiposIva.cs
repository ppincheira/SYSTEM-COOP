using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class TiposIva {
        public TiposIva() {
/*			DetallesIvas = new List<DetallesIva>();
			Empresas = new List<Empresa>();
*/        }
        public virtual string TivCodigo { get; set; }
        public virtual string TivDescripcion { get; set; }
        public virtual string TivDiscrimina { get; set; }
        public virtual string TivExento { get; set; }
        public virtual string TivGeneraIva { get; set; }
        public virtual string TivCodigoAfip { get; set; }
/*        public virtual IList<DetallesIva> DetallesIvas { get; set; }
        public virtual IList<Empresa> Empresas { get; set; }
*/
    }
}
