using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class MonedasTasasCambio {
        public MonedasTasasCambio()
        { 
        }
        public virtual short MonCodigo { get; set; }
        public virtual DateTime MtcFechaVigencia { get; set; }
        public virtual double? MtcImporte { get; set; }
        //#region NHibernate Composite Key Requirements
        //public override bool Equals(object obj) {
        //    if (obj == null) return false;
        //    var t = obj as MonedasTasasCambio;
        //    if (t == null) return false;
        //    if (MonCodigo == t.MonCodigo
        //     && MtcFechaVigencia == t.MtcFechaVigencia)
        //        return true;

        //    return false;
        //}
        //public override int GetHashCode() {
        //    int hash = GetType().GetHashCode();
        //    hash = (hash * 397) ^ MonCodigo.GetHashCode();
        //    hash = (hash * 397) ^ MtcFechaVigencia.GetHashCode();

        //    return hash;
        //}
        //#endregion
    }
}
