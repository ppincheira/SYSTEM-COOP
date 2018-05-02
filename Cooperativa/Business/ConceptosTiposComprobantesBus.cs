using System;
using Implement;
using Model;
using System.Data;
using System.Collections.Generic;


namespace Business
{
    public class ConceptosTiposComprobantesBus
    {
        public long ConceptosTiposComprobantesAdd(ConceptosTiposComprobantes oConceptosTiposComprobantes)
        {
            ConceptosTiposComprobantesImpl oConceptosTiposComprobantesImpl = new ConceptosTiposComprobantesImpl();
            return oConceptosTiposComprobantesImpl.ConceptosTiposComprobantesAdd(oConceptosTiposComprobantes);
        }        

        public bool ConceptosTiposComprobantesDelete(ConceptosTiposComprobantes oConceptosTiposComprobante)
        {
            ConceptosTiposComprobantesImpl oConceptosTiposComprobantesImpl = new ConceptosTiposComprobantesImpl();
            return oConceptosTiposComprobantesImpl.ConceptosTiposComprobantesDelete(oConceptosTiposComprobante);
        }

        public Transacciones ConceptosTiposComprobantesAddTrans(ConceptosTiposComprobantes oConceptosTiposComprobantes)
        {
            ConceptosTiposComprobantesImpl oConceptosTiposComprobantesImpl = new ConceptosTiposComprobantesImpl();
            return oConceptosTiposComprobantesImpl.ConceptosTiposComprobantesAddTrans(oConceptosTiposComprobantes);
        }

        public Transacciones ConceptosTiposComprobantesDeleteTrans(ConceptosTiposComprobantes oConceptosTiposComprobante)
        {
            ConceptosTiposComprobantesImpl oConceptosTiposComprobantesImpl = new ConceptosTiposComprobantesImpl();
            return oConceptosTiposComprobantesImpl.ConceptosTiposComprobantesDeleteTrans(oConceptosTiposComprobante);
        }

        public ConceptosTiposComprobantes ConceptosTiposComprobantesGetById(int numero)
        {
            ConceptosTiposComprobantesImpl oConceptosTiposComprobantesImpl = new ConceptosTiposComprobantesImpl();
            return oConceptosTiposComprobantesImpl.ConceptosTiposComprobantesGetById(numero);
        }

        public List<ConceptosTiposComprobantes> ConceptosTiposComprobantesGetAll()
        {
            ConceptosTiposComprobantesImpl oConceptosTiposComprobantesImpl = new ConceptosTiposComprobantesImpl();
            return oConceptosTiposComprobantesImpl.ConceptosTiposComprobantesGetAll();
        }
        public DataTable ConceptosTiposComprobantesGetByFilter(long numero)
        {
            ConceptosTiposComprobantesImpl oConceptosTiposComprobantesImpl = new ConceptosTiposComprobantesImpl();
            return oConceptosTiposComprobantesImpl.ConceptosTiposComprobantesGetByFilter(numero);
        }
    }
}
