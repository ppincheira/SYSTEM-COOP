using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class DetallesColumnasTablas {
        public DetallesColumnasTablas(){
        }
        public virtual string TabCodigo { get; set; }
        public virtual string DctColumna { get; set; }
        public virtual short DctNroOrden { get; set; }
        public virtual string DctHabilitado { get; set; }
        public virtual string DctRequerido { get; set; }
        public virtual string DctDescripcion { get; set; }
        public virtual string DctEtiqueta { get; set; }
        public virtual string DctTipoControl { get; set; }
        public virtual string DctListaValores { get; set; }
        public virtual string DctFiltroBusqueda { get; set; }
        /*       #region NHibernate Composite Key Requirements
               public override bool Equals(object obj) {
                   if (obj == null) return false;
                   var t = obj as detallesColumnasTabla;
                   if (t == null) return false;
                   if (tabCodigo == t.tabCodigo
                    && dctCodigoTabla == t.dctCodigoTabla
                    && dctColumna == t.dctColumna)
                       return true;

                   return false;
               }
               public override int GetHashCode() {
                   int hash = GetType().GetHashCode();
                   hash = (hash * 397) ^ tabCodigo.GetHashCode();
                   hash = (hash * 397) ^ dctCodigoTabla.GetHashCode();
                   hash = (hash * 397) ^ dctColumna.GetHashCode();

                   return hash;
               }
               #endregion
          */
    }
}
