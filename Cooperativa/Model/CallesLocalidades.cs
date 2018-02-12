using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class CallesLocalidades {
        public CallesLocalidades() {
/*			Domicilios = new List<Domicilio>();
			Domicilios = new List<Domicilio>();
			Domicilios = new List<Domicilio>();
			Domicilios = new List<Domicilio>();
			Domicilios = new List<Domicilio>();
			Domicilios = new List<Domicilio>();
*/
        }
        public virtual long CalNumero { get; set; }
        public virtual string CalDescripcion { get; set; }
        public virtual int LocNumero { get; set; }
/*        public virtual IList<Domicilio> Domicilios { get; set; }
        public virtual IList<Domicilio> Domicilios { get; set; }
        public virtual IList<Domicilio> Domicilios { get; set; }
        public virtual IList<Domicilio> Domicilios { get; set; }
        public virtual IList<Domicilio> Domicilios { get; set; }
        public virtual IList<Domicilio> Domicilios { get; set; }
*/
    }
}
