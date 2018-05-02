using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Estados {
        public Estados()
        {
        }
        public virtual long EstNumero { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual string EstDescripcion { get; set; }
        public virtual string EstDescripcionCorta { get; set; }
        public virtual string tabNombre { get; set; }
        public virtual string EstColumnaTabla { get; set; }
        public virtual string EstTipoDato { get; set; }

    }
}
