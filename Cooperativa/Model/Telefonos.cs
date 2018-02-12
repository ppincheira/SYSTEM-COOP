using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Telefonos {
        public Telefonos()
        {
        }
        public virtual long TelCodigo { get; set; }        
        public virtual string TelNumero { get; set; }        
        public virtual string TelCargo { get; set; }
        public virtual string TelTipo { get; set; }
        public virtual string TelDefecto { get; set; }
        public virtual string TelEmail { get; set; }
        public virtual string TelNombreContacto { get; set; }
        public virtual string TabCodigo { get; set; }
        public virtual string TelCodigoRegistro { get; set; }
    }
}
