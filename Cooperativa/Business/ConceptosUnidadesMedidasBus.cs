using System.Collections.Generic;
using Implement;
using Model;
using System.Data;


namespace Business
{
    public class ConceptosUnidadesMedidasBus
    {
        public long ConceptosUnidadesMedidasAdd(ConceptosUnidadesMedidas oConceptosUnidadesMedidas)
        {
            ConceptosUnidadesMedidasImpl oConceptosUnidadesMedidasImpl = new ConceptosUnidadesMedidasImpl();
            return oConceptosUnidadesMedidasImpl.ConceptosUnidadesMedidasAdd(oConceptosUnidadesMedidas);
        }

        public bool ConceptosUnidadesMedidasUpdate(ConceptosUnidadesMedidas oConceptosUnidadesMedidas)
        {
            ConceptosUnidadesMedidasImpl oConceptosUnidadesMedidasImpl = new ConceptosUnidadesMedidasImpl();
            return oConceptosUnidadesMedidasImpl.ConceptosUnidadesMedidasUpdate(oConceptosUnidadesMedidas);
        }

        public bool ConceptosUnidadesMedidasDelete(long Id)
        {
            ConceptosUnidadesMedidasImpl oConceptosUnidadesMedidasImpl = new ConceptosUnidadesMedidasImpl();
            return oConceptosUnidadesMedidasImpl.ConceptosUnidadesMedidasDelete(Id);
        }

        public ConceptosUnidadesMedidas ConceptosUnidadesMedidasGetById(long Id)
        {
            ConceptosUnidadesMedidasImpl oConceptosUnidadesMedidasImpl = new ConceptosUnidadesMedidasImpl();
            return oConceptosUnidadesMedidasImpl.ConceptosUnidadesMedidasGetById(Id);
        }       

        public List<ConceptosUnidadesMedidas> ConceptosUnidadesMedidasGetAll()
        {
            ConceptosUnidadesMedidasImpl oConceptosUnidadesMedidasImpl = new ConceptosUnidadesMedidasImpl();
            return oConceptosUnidadesMedidasImpl.ConceptosUnidadesMedidasGetAll();
        }

        public DataTable ConceptosUnidadesMedidasGetByFilter()
        {
            ConceptosUnidadesMedidasImpl oConceptosUnidadesMedidasImpl = new ConceptosUnidadesMedidasImpl();
            return oConceptosUnidadesMedidasImpl.ConceptosUnidadesMedidasGetByFilter();
        }
    }
}
