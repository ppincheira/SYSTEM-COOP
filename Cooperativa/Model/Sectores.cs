using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Sectores {
        public Sectores() {
/*			PersonasSectores = new List<PersonasSectore>();
			PersonasSectores = new List<PersonasSectore>();
			PersonasSectores = new List<PersonasSectore>();
*/
        }
        public virtual string SecCodigo { get; set; }
        public virtual short DepNumero { get; set; }
        public virtual string AreCodigo { get; set; }
        public virtual string SecDescripcion { get; set; }
/*        public virtual IList<PersonasSectore> PersonasSectores { get; set; }
        public virtual IList<PersonasSectore> PersonasSectores { get; set; }
        public virtual IList<PersonasSectore> PersonasSectores { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Sectore;
			if (t == null) return false;
			if (SecCodigo == t.SecCodigo
			 && DepNumero == t.DepNumero
			 && AreCodigo == t.AreCodigo)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ SecCodigo.GetHashCode();
			hash = (hash * 397) ^ DepNumero.GetHashCode();
			hash = (hash * 397) ^ AreCodigo.GetHashCode();

			return hash;
        }
        #endregion
*/
    }
}
