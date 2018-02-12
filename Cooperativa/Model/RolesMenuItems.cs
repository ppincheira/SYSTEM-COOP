using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class RolesMenuItems {
        public RolesMenuItems()
        {

        }
        public virtual string RolCodigo { get; set; }
        public virtual string MniCodigo { get; set; }
        public virtual string RmiSoloLectura { get; set; }
/*        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as RolesMenuItem;
			if (t == null) return false;
			if (RolCodigo == t.RolCodigo
			 && MniCodigo == t.MniCodigo)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ RolCodigo.GetHashCode();
			hash = (hash * 397) ^ MniCodigo.GetHashCode();

			return hash;
        }
        #endregion
*/
    }
}
