using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Domicilios {
        public Domicilios() { }
        public virtual long DomCodigo { get; set; }
        public virtual int LocNumero { get; set; }
        public virtual long BarNumero { get; set; }
        public virtual long CalNumero { get; set; }
        public virtual long CalNumeroDesde { get; set; }
        public virtual long CalNumeroHasta { get; set; }
        public virtual int DomNumero { get; set; }
        public virtual string DomBloque { get; set; }
        public virtual string DomPiso { get; set; }
        public virtual string DomDepartamento { get; set; }
        public virtual string DomParcela { get; set; }
        public virtual long CplNumero { get; set; }
        public virtual string DomLote { get; set; }
        public virtual decimal? DomGisX { get; set; }
        public virtual decimal? DomGisY { get; set; }
      
    }
}
