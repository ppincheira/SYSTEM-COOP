using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Roles {
        public Roles() {
/*			RolesMenuItems = new List<RolesMenuItem>();
			RolesFuncionalidades = new List<RolesFuncionalidade>();
*/        }
        public virtual string RolCodigo { get; set; }
        public virtual string SbsCodigo { get; set; }
        public virtual string RolDescripcion { get; set; }
        public virtual string RolTipo { get; set; }
/*        public virtual IList<RolesMenuItem> RolesMenuItems { get; set; }
        public virtual IList<RolesFuncionalidade> RolesFuncionalidades { get; set; }
*/
    }
}
