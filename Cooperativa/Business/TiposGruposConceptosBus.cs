using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class TiposGruposConceptosBus
    {
        public List<TiposGruposConceptos> TiposGruposConceptosGetAll()
        {
            TiposGruposConceptosImpl oTiposGruposConceptosImpl = new TiposGruposConceptosImpl();
            return oTiposGruposConceptosImpl.TiposGruposConceptosGetAll();
        }
    }
}
