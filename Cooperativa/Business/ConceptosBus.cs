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

        public Transacciones ConceptosAddTrans(Conceptos oConceptos)
        {
            ConceptosImpl oConceptosImpl = new ConceptosImpl();
            return oConceptosImpl.ConceptosAddTrans(oConceptos);
        }

        public bool ConceptosUpdate(Conceptos oConceptos)
        {
            ConceptosImpl oConceptosImpl = new ConceptosImpl();
            return oConceptosImpl.ConceptosUpdate(oConceptos);
        }

        public Transacciones ConceptosUpdateTrans(Conceptos oConceptos)
        {
            ConceptosImpl oConceptosImpl = new ConceptosImpl();
            return oConceptosImpl.ConceptosUpdateTrans(oConceptos);
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
