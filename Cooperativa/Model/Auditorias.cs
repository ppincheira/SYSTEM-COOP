using System;
using System.Text;
using System.Collections.Generic;


namespace Model{
    
    public class Auditorias {
        public Auditorias() {
//			DetallesAuditoria = new List<DetallesAuditoria>();
        }
        public virtual long AudNumero { get; set; }
        public virtual string UsrCodigo { get; set; }
        public virtual DateTime AudFecha { get; set; }
        public virtual string AudTerminal { get; set; }
        public virtual string TabNombre { get; set; }
        public virtual string AudTipo { get; set; }
        public virtual string CotClaveBusqueda { get; set; }
//        public virtual IList<DetallesAuditoria> DetallesAuditoria { get; set; }
    }
}
