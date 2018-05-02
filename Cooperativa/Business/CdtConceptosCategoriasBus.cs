using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class CdtConceptosCategoriasBus
    {
        public long CdtConceptosCategoriasAdd(CdtConceptosCategorias oCCa)
        {
            CdtConceptosCategoriasImpl oCCaImpl = new CdtConceptosCategoriasImpl();
            return oCCaImpl.CdtConceptosCategoriasAdd(oCCa);
        }

        public bool CdtConceptosCategoriasUpdate(CdtConceptosCategorias oCCa)
        {
            CdtConceptosCategoriasImpl oCCaImpl = new CdtConceptosCategoriasImpl();
            return oCCaImpl.CdtConceptosCategoriasUpdate(oCCa);
        }

        public bool CdtConceptosCategoriasDelete(long Id)
        {
            CdtConceptosCategoriasImpl oCCaImpl = new CdtConceptosCategoriasImpl();
            return oCCaImpl.CdtConceptosCategoriasDelete(Id);
        }

        public CdtConceptosCategorias CdtConceptosCategoriasGetById(long Id)
        {
            CdtConceptosCategoriasImpl oCCaImpl = new CdtConceptosCategoriasImpl();
            return oCCaImpl.CdtConceptosCategoriasGetById(Id);
        }

        public List<CdtConceptosCategorias> CdtConceptosCategoriasGetAll()
        {
            CdtConceptosCategoriasImpl oCCaImpl = new CdtConceptosCategoriasImpl();
            return oCCaImpl.CdtConceptosCategoriasGetAll();
        }
        
    }
}
