using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class SuministrosConceptos {
        public SuministrosConceptos() {
        }
        public virtual long SmcCodigo { get; set; }
        public virtual DateTime? SmcFechaAlta { get; set; }
        public virtual DateTime? SmcFechaBaja { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual long CptNumero { get; set; }
        public virtual long SumNumero { get; set; }
    }
}
