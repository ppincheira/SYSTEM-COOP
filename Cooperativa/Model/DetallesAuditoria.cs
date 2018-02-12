using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class DetallesAuditoria {
        public DetallesAuditoria(){
        }
        public virtual long AudNumero { get; set; }
        public virtual short DauNumero { get; set; }
        public virtual string TabNombre { get; set; }
        public virtual string CotNombre { get; set; }
        public virtual string CotValorAnt { get; set; }
        public virtual string CotValorPost { get; set; }
        /*        #region NHibernate Composite Key Requirements
              public override bool Equals(object obj) {
                   if (obj == null) return false;
                   var t = obj as detallesAuditorium;
                   if (t == null) return false;
                   if (audNumero == t.audNumero
                    && dauNumero == t.dauNumero)
                       return true;

                   return false;
               }
               public override int GetHashCode() {
                   int hash = GetType().GetHashCode();
                   hash = (hash * 397) ^ audNumero.GetHashCode();
                   hash = (hash * 397) ^ dauNumero.GetHashCode();

                   return hash;
               }
               #endregion
          */
    }
}
