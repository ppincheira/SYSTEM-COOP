using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Monedas {
        public Monedas() {
            //CdtConceptosCategorias = new List<CdtConceptosCategoria>();
            //ConceptosCuadrosTarifarios = new List<ConceptosCuadrosTarifario>();
            //MonedasTasasCambios = new List<MonedasTasasCambio>();
        }
        public virtual short MonCodigo { get; set; }
        public virtual string MonDescripcion { get; set; }
        public virtual string MonCodigoIso { get; set; }
        public virtual short MonNumeroIso { get; set; }
        //public virtual IList<CdtConceptosCategoria> CdtConceptosCategorias { get; set; }
        //public virtual IList<ConceptosCuadrosTarifario> ConceptosCuadrosTarifarios { get; set; }
        //public virtual IList<MonedasTasasCambio> MonedasTasasCambios { get; set; }
    }
}
