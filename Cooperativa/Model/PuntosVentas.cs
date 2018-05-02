using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class PuntosVentas {
        public PuntosVentas() {        }
        public virtual string PvtNumero { get; set; }
        public virtual string PvtDescripcion { get; set; }
        public virtual string PvtActividad { get; set; }
        public virtual string PvtFiscal        { get; set; }
    }
}
