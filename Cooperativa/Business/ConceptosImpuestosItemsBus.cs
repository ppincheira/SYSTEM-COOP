using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class ConceptosImpuestosItemsBus
    {
        public int ConceptosImpuestosItemsAdd(ConceptosImpuestosItems oConceptosImpuestosItems)
        {
            ConceptosImpuestosItemsImpl oConceptosImpuestosItemsImpl = new ConceptosImpuestosItemsImpl();
            return oConceptosImpuestosItemsImpl.ConceptosImpuestosItemsAdd(oConceptosImpuestosItems);
        }

        public Transacciones ConceptosImpuestosItemsAddTrans(ConceptosImpuestosItems oConceptosImpuestosItems)
        {
            ConceptosImpuestosItemsImpl oConceptosImpuestosItemsImpl = new ConceptosImpuestosItemsImpl();
            return oConceptosImpuestosItemsImpl.ConceptosImpuestosItemsAddTrans(oConceptosImpuestosItems);
        }

        public bool ConceptosImpuestosItemsUpdate(ConceptosImpuestosItems oConceptosImpuestosItems)
        {
            ConceptosImpuestosItemsImpl oConceptosImpuestosItemsImpl = new ConceptosImpuestosItemsImpl();
            return oConceptosImpuestosItemsImpl.ConceptosImpuestosItemsUpdate(oConceptosImpuestosItems);
        }

        public Transacciones ConceptosImpuestosItemsUpdateTrans(ConceptosImpuestosItems oConceptosImpuestosItems)
        {
            ConceptosImpuestosItemsImpl oConceptosImpuestosItemsImpl = new ConceptosImpuestosItemsImpl();
            return oConceptosImpuestosItemsImpl.ConceptosImpuestosItemsUpdateTrans(oConceptosImpuestosItems);
        }

        public bool ConceptosImpuestosItemsDelete(String Id)
        {
            ConceptosImpuestosItemsImpl oConceptosImpuestosItemsImpl = new ConceptosImpuestosItemsImpl();
            return oConceptosImpuestosItemsImpl.ConceptosImpuestosItemsDelete(Id);
        }

        public ConceptosImpuestosItems ConceptosImpuestosItemsGetById(int Id)
        {
            ConceptosImpuestosItemsImpl oConceptosImpuestosItemsImpl = new ConceptosImpuestosItemsImpl();
            return oConceptosImpuestosItemsImpl.ConceptosImpuestosItemsGetById(Id);
        }

        public ConceptosImpuestosItems ConceptosImpuestosItemsGetByCptNumero(long CptNumero)
        {
            ConceptosImpuestosItemsImpl oConceptosImpuestosItemsImpl = new ConceptosImpuestosItemsImpl();
            return oConceptosImpuestosItemsImpl.ConceptosImpuestosItemsGetByCptNumero(CptNumero);
        }

        public List<ConceptosImpuestosItems> ConceptosImpuestosItemsGetAll()
        {
            ConceptosImpuestosItemsImpl oConceptosImpuestosItemsImpl = new ConceptosImpuestosItemsImpl();
            return oConceptosImpuestosItemsImpl.ConceptosImpuestosItemsGetAll();
        }        
    }
}
