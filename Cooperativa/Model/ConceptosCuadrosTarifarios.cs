using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class ConceptosCuadrosTarifarios {
        public ConceptosCuadrosTarifarios() 
        { 
        }
        public virtual long CctCodigo { get; set; }
        public virtual long CptNumero { get; set; }
        public virtual long CdtCodigo { get; set; }
        public virtual string CdtTipoTarifa { get; set; }
        public virtual string CdtTipoCalculo { get; set; }
        public virtual double? CdtImporte { get; set; }
        public virtual float? CdtTasa { get; set; }
        public virtual string CdtScriptImporte { get; set; }
        public virtual string CdtScriptTasa { get; set; }
        public virtual short? CdtOrdenCalculo { get; set; }
        public virtual short? CdtOrdenImpresion { get; set; }
        public virtual double? CdtValorLimite { get; set; }
        public virtual short MonCodigo { get; set; }
    }
}
