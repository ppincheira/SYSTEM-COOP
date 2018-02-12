using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class TipoConexionServicios {
        public TipoConexionServicios()
        {
        }
        public virtual string TcsCodigo { get; set; }
        public virtual string TcsDescripcion { get; set; }
        public virtual string TcsDescripcionCorta { get; set; }
        public virtual string SrvCodigo { get; set; }
        public virtual string EstCodigo { get; set; }
    }
}
