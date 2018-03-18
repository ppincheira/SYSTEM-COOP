using System.Collections.Generic;
using Implement;
using Model;
using System.Data;


namespace Business
{
    public class ConceptosBus
    {
        public long ConceptosAdd(Conceptos oConceptos)
        {
            ConceptosImpl oConceptosImpl = new ConceptosImpl();
            return oConceptosImpl.ConceptosAdd(oConceptos);
        }

        public bool ConceptosUpdate(Conceptos oConceptos)
        {
            ConceptosImpl oConceptosImpl = new ConceptosImpl();
            return oConceptosImpl.ConceptosUpdate(oConceptos);
        }

        public bool ConceptosDelete(int Id)
        {
            ConceptosImpl oConceptosImpl = new ConceptosImpl();
            return oConceptosImpl.ConceptosDelete(Id);
        }

        public Conceptos ConceptosGetById(long Id)
        {
            ConceptosImpl oConceptosImpl = new ConceptosImpl();
            return oConceptosImpl.ConceptosGetById(Id);
        }

        public List<Conceptos> ConceptosGetAll()
        {
            ConceptosImpl oConceptosImpl = new ConceptosImpl();
            return oConceptosImpl.ConceptosGetAll();
        }
        
    }
}
