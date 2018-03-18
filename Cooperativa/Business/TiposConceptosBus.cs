using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class TiposConceptosBus
    {
        public long TiposConceptosAdd(TiposConceptos oTiposConceptos)
        {
            TiposConceptosImpl oTiposConceptosImpl = new TiposConceptosImpl();
            return oTiposConceptosImpl.TiposConceptosAdd(oTiposConceptos);
        }

        public bool TiposConceptosUpdate(TiposConceptos oTiposConceptos)
        {
            TiposConceptosImpl oTiposConceptosImpl = new TiposConceptosImpl();
            return oTiposConceptosImpl.TiposConceptosUpdate(oTiposConceptos);
        }

        public bool TiposConceptosDelete(long Id)
        {
            TiposConceptosImpl oTiposConceptosImpl = new TiposConceptosImpl();
            return oTiposConceptosImpl.TiposConceptosDelete(Id);
        }

        public TiposConceptos TiposConceptosGetById(long Id)
        {
            TiposConceptosImpl oTiposConceptosImpl = new TiposConceptosImpl();
            return oTiposConceptosImpl.TiposConceptosGetById(Id);
        }

        public List<TiposConceptos> TiposConceptosGetAll()
        {
            TiposConceptosImpl oTiposConceptosImpl = new TiposConceptosImpl();
            return oTiposConceptosImpl.TiposConceptosGetAll();
        }

        public DataTable TiposConceptosGetByFilter()
        {
            TiposConceptosImpl oTiposConceptosImpl = new TiposConceptosImpl();
            return oTiposConceptosImpl.TiposConceptosGetByFilter();
        }
    }
}
