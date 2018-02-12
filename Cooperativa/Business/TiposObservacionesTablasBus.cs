using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class TiposObservacionesTablasBus
    {
        public int TiposObservacionesTablasAdd(TiposObservacionesTablas oTiposObservacionesTablas)
        {
            TiposObservacionesTablasImpl oTiposObservacionesTablasImpl = new TiposObservacionesTablasImpl();
            return oTiposObservacionesTablasImpl.TiposObservacionesTablasAdd(oTiposObservacionesTablas);
        }

        public bool TiposObservacionesTablasUpdate(TiposObservacionesTablas oTiposObservacionesTablas)
        {
            TiposObservacionesTablasImpl oTiposObservacionesTablasImpl = new TiposObservacionesTablasImpl();
            return oTiposObservacionesTablasImpl.TiposObservacionesTablasUpdate(oTiposObservacionesTablas);
        }

        public bool TiposObservacionesTablasDelete(string Tab, string Tob)
        {
            TiposObservacionesTablasImpl oTiposObservacionesTablasImpl = new TiposObservacionesTablasImpl();
            return oTiposObservacionesTablasImpl.TiposObservacionesTablasDelete(Tab, Tob);
        }

        public TiposObservacionesTablas TiposObservacionesTablasGetById(string Tab, string Tob)
        {
            TiposObservacionesTablasImpl oTiposObservacionesTablasImpl = new TiposObservacionesTablasImpl();
            return oTiposObservacionesTablasImpl.TiposObservacionesTablasGetById(Tab, Tob);
        }

        public List<TiposObservacionesTablas> TiposObservacionesTablasGetAll()
        {
            TiposObservacionesTablasImpl oTiposObservacionesTablasImpl = new TiposObservacionesTablasImpl();
            return oTiposObservacionesTablasImpl.TiposObservacionesTablasGetAll();
        }
    }
}
