using System;


namespace Model
{

    public class MedidoresModelos {
        public MedidoresModelos() {
        }
        public virtual long MMoCodigo { get; set; }
        public virtual string MMoDescripcion { get; set; }
        public virtual string MMoDescripcionCorta { get; set; }
        public virtual int? MMoDigitos { get; set; }
        public virtual int? MMoDecimales { get; set; }
        public virtual int? MMoCantHilos { get; set; }
        public virtual int? MMoKwVueltas { get; set; }
        public virtual string MMoAmperaje { get; set; }
        public virtual int? MMoClase { get; set; }
        public virtual string MMoTipoContador { get; set; }
        public virtual string TCSCodigo { get; set; }
        public virtual int FabNumero { get; set; }
        public virtual int TmeCodigo { get; set; }
        public virtual int UsrNumero { get; set; }
        public virtual DateTime MMoFechaCarga { get; set; }
        public virtual string EstCodigo { get; set; }
    }
}
