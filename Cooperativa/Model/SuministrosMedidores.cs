using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class SuministrosMedidores {
        public SuministrosMedidores(){
        }
        public virtual long SmeNumero { get; set; }
        public virtual DateTime SmeFechaAlta { get; set; }
        public virtual DateTime? SmeFechaBaja { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual long MedNumero { get; set; }
        public virtual long SumNumero { get; set; }
    }
}
