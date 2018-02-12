using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Subsistema {
        public Subsistema() {
/*			MenuItems = new List<MenuItem>();
			Roles = new List<Role>();
			Funcionalidades = new List<Funcionalidade>();
*/        }
        public virtual string SbsCodigo { get; set; }
        public virtual string SbsNombre { get; set; }
/*        public virtual IList<MenuItem> MenuItems { get; set; }
        public virtual IList<Role> Roles { get; set; }
        public virtual IList<Funcionalidade> Funcionalidades { get; set; }
*/
    }
}
