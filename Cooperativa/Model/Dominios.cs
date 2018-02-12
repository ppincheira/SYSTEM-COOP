using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Dominios {
        public Dominios()
        {
        }
        public virtual string DmnCodigo { get; set; }
        public virtual string DmnValor { get; set; }
        public virtual string DmnDescripcion { get; set; }
        public virtual string DmnActivo { get; set; }
        public virtual string DmnDefault { get; set; }
 /*       #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as dominio;
			if (t == null) return false;
			if (DmnCodigo == t.DmnCodigo
			 && DmnValor == t.DmnValor)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ DmnCodigo.GetHashCode();
			hash = (hash * 397) ^ DmnValor.GetHashCode();

			return hash;
        }
        #endregion
   */
    }
}
