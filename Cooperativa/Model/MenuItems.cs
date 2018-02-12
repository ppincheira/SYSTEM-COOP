using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class MenuItems {
        public MenuItems() {
//			RolesMenuItems = new List<RolesMenuItem>();
        }
        public virtual string MniCodigo { get; set; }
        public virtual string MniCodigoPadre { get; set; }
        public virtual string MniDescripcion { get; set; }
        public virtual string FrmNombre { get; set; }
        public virtual short? MniParametros { get; set; }
        public virtual string SbsCodigo { get; set; }
        public virtual string FunCodigo { get; set; }
        public virtual byte[] MniLogo { get; set; }
        //        public virtual IList<RolesMenuItem> RolesMenuItems { get; set; }
    }
}
