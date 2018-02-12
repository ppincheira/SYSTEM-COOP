using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class TiposMedidoresFabricantes {
        public TiposMedidoresFabricantes()
        {
        }
        public virtual string TmeCodigo { get; set; }
        public virtual int FabNumero { get; set; }
/*        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as TiposMedidoresFabricante;
			if (t == null) return false;
			if (TmeCodigo == t.TmeCodigo
			 && FabNumero == t.FabNumero)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ TmeCodigo.GetHashCode();
			hash = (hash * 397) ^ FabNumero.GetHashCode();

			return hash;
        }
        #endregion
*/
    }
}
