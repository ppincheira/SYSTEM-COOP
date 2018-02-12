using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class TiposGruposBus
    {
        public long TiposGruposAdd(TiposGrupos oTiposGrupos)
        {
            TiposGruposImpl oTiposGruposImpl = new TiposGruposImpl();
            return oTiposGruposImpl.TiposGruposAdd(oTiposGrupos);
        }

        public bool TiposGruposUpdate(TiposGrupos oTiposGrupos)
        {
            TiposGruposImpl oTiposGruposImpl = new TiposGruposImpl();
            return oTiposGruposImpl.TiposGruposUpdate(oTiposGrupos);
        }

        public bool TiposGruposDelete(string Id)
        {
            TiposGruposImpl oTiposGruposImpl = new TiposGruposImpl();
            return oTiposGruposImpl.TiposGruposDelete(Id);
        }

        public TiposGrupos TiposGruposGetById(string Id)
        {
            TiposGruposImpl oTiposGruposImpl = new TiposGruposImpl();
            return oTiposGruposImpl.TiposGruposGetById(Id);
        }

        public List<TiposGrupos> TiposGruposGetAll()
        {
            TiposGruposImpl oTiposGruposImpl = new TiposGruposImpl();
            return oTiposGruposImpl.TiposGruposGetAll();
        }
        public List<TiposGrupos> TiposGruposGetbyTabla(string TipoGrupo)
        {
            TiposGruposImpl oTiposGruposImpl = new TiposGruposImpl();
            return oTiposGruposImpl.TiposGruposGetbyTabla(TipoGrupo);
        }
    }
}
