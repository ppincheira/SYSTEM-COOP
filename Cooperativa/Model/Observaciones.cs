using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Observaciones {
        public Observaciones()
        {
        }
        public virtual long ObsCodigo { get; set; }
        public virtual string ObsCodigoRegistro { get; set; }
        public virtual string ObsDetalle { get; set; }
        public virtual DateTime ObsFechaAlta { get; set;}
        public virtual int TobCodigo { get; set; }

        public virtual string ObsDefecto { get; set; }
        
    }
}
