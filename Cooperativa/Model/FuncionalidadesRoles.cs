using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class FuncionalidadesRoles {
        public FuncionalidadesRoles()
        {
        }
        public virtual string RolCodigo { get; set; }
        public virtual string FunCodigo { get; set; }
 /*       #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as RolesFuncionalidade;
			if (t == null) return false;
			if (RolCodigo == t.RolCodigo
			 && FunCodigo == t.FunCodigo)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ RolCodigo.GetHashCode();
			hash = (hash * 397) ^ FunCodigo.GetHashCode();

			return hash;
        }
        #endregion
*/
    }
}
