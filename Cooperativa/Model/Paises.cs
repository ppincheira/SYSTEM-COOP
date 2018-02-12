using System;
using System.Text;
using System.Collections.Generic;


namespace Model {

    public class Paises
    {
        public Paises() {
//			Provincias = new List<Provincia>();
        }
        public virtual string PaiCodigo { get; set; }
        public virtual string PaiDescripcion { get; set; }
//        public virtual IList<Provincia> Provincias { get; set; }
    }
}
