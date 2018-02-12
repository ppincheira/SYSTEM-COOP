using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Accionistas {
        public Accionistas()
        {

        }
        public virtual long AccNumero { get; set; }
        public virtual DateTime? AccFechaAlta { get; set; }
        public virtual long DisNumero { get; set; }
        public virtual DateTime? AccFechaBaja { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual long EmpNumero { get; set; }
    }
}
