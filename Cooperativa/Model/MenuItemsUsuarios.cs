using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class MenuItemsUsuarios {
        public MenuItemsUsuarios()
        {
        }
        public virtual string MniCodigo { get; set; }
        public virtual int UsrNumero { get; set; }
        public virtual string RolCodigo { get; set; }
        public virtual string MiuSoloLectura { get; set; }
    }
}
