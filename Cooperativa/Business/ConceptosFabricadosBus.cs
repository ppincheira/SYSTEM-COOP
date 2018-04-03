using System;
using Implement;
using Model;
using System.Data;
using System.Collections.Generic;

namespace Business
{
    public class ConceptosFabricadosBus
    {
        public DataTable ConceptosFabricadosGetByFilter(long CodigoFabricado)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosGetByFilter(CodigoFabricado);
        }
        public long ConceptosFabricadosAdd(ConceptosFabricados oConceptosFabricados)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosAdd(oConceptosFabricados);
        }

        public bool ConceptosFabricadosUpdate(ConceptosFabricados oConceptosFabricados)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosUpdate(oConceptosFabricados);
        }

        public bool ConceptosFabricadosDelete(ConceptosFabricados oConceptosTiposComprobante)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosDelete(oConceptosTiposComprobante);
        }

        public bool ConceptosFabricadosDeleteAll(ConceptosFabricados oConceptosTiposComprobante)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosDeleteAll(oConceptosTiposComprobante);
        }
    }
}
