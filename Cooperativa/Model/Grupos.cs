using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Grupos {
        public Grupos() {
			//GruposDetalles = new List<GruposDetalle>();
        }
        public virtual long GrpCodigo { get; set; }
        public virtual string GrpDescripcion { get; set; }
        public virtual string TgrCodigo { get; set; }
        //public virtual IList<GruposDetalle> GruposDetalles { get; set; }
    }
}
