using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class ConceptosCuadrosTarifariosBus
    {
        public long ConceptosCuadrosTarifariosAdd(ConceptosCuadrosTarifarios oCCT)
        {
            ConceptosCuadrosTarifariosImpl oCCTImpl = new ConceptosCuadrosTarifariosImpl();
            return oCCTImpl.ConceptosCuadrosTarifariosAdd(oCCT);
        }

        public bool ConceptosCuadrosTarifariosUpdate(ConceptosCuadrosTarifarios oCCT)
        {
            ConceptosCuadrosTarifariosImpl oCCTImpl = new ConceptosCuadrosTarifariosImpl();
            return oCCTImpl.ConceptosCuadrosTarifariosUpdate(oCCT);
        }

        public bool ConceptosCuadrosTarifariosDelete(long Id)
        {
            ConceptosCuadrosTarifariosImpl oCCTImpl = new ConceptosCuadrosTarifariosImpl();
            return oCCTImpl.ConceptosCuadrosTarifariosDelete(Id);
        }

        public ConceptosCuadrosTarifarios ConceptosCuadrosTarifariosGetById(long Id)
        {
            ConceptosCuadrosTarifariosImpl oCCTImpl = new ConceptosCuadrosTarifariosImpl();
            return oCCTImpl.ConceptosCuadrosTarifariosGetById(Id);
        }

        public List<ConceptosCuadrosTarifarios> ConceptosCuadrosTarifariosGetAll()
        {
            ConceptosCuadrosTarifariosImpl oCCTImpl = new ConceptosCuadrosTarifariosImpl();
            return oCCTImpl.ConceptosCuadrosTarifariosGetAll();
        }
        
    }
}
