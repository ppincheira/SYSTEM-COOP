using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class CdtConceptosCategorias {
        public CdtConceptosCategorias()
        {
        }
        public virtual long CcaCodigo { get; set; }
        public virtual long ScaNumero { get; set; }
        public virtual long CptNumero { get; set; }
        public virtual double? CcaImporte { get; set; }
        public virtual float? CcaTasa { get; set; }
        public virtual string CcaScriptImporte { get; set; }
        public virtual string CcaScriptTasa { get; set; }
        public virtual short? CcaOrdenCalculo { get; set; }
        public virtual short? CcaOrdenImpresion { get; set; }
        public virtual string CcaTipoTarifa { get; set; }
        public virtual string CcaTipoCalculo { get; set; }
        public virtual double? CcaValorLimite { get; set; }
        public virtual short MonCodigo { get; set; }
    }
}
