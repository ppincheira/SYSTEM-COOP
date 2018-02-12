namespace Model
{

    public class ParametrosGenerales {
        public ParametrosGenerales()
        {
        }
        public virtual string PagCodigo { get; set; }
        public virtual string PagTipo { get; set; }
        public virtual string PagDescripcion { get; set; }
        public virtual string PagValor { get; set; }
        public virtual string PagVisible { get; set; }
        public virtual string PagModificableUsr { get; set; }
/*        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as ParametrosGenerale;
			if (t == null) return false;
			if (PagCodigo == t.PagCodigo
			 && PagTipo == t.PagTipo)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ PagCodigo.GetHashCode();
			hash = (hash * 397) ^ PagTipo.GetHashCode();

			return hash;
        }
        #endregion
*/
    }
}
