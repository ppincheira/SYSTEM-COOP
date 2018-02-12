using System;
using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class TiposLocalidadesBus
    {
        public int TiposLocalidadesAdd(TiposLocalidades oTiposLocalidades)
        {
            TiposLocalidadesImpl oTiposLocalidadesImpl = new TiposLocalidadesImpl();
            return oTiposLocalidadesImpl.TiposLocalidadesAdd(oTiposLocalidades);
        }

        public bool TiposLocalidadesUpdate(TiposLocalidades oTiposLocalidades)
        {
            TiposLocalidadesImpl oTiposLocalidadesImpl = new TiposLocalidadesImpl();
            return oTiposLocalidadesImpl.TiposLocalidadesUpdate(oTiposLocalidades);
        }

        public bool TiposLocalidadesDelete(String Id)
        {
            TiposLocalidadesImpl oTiposLocalidadesImpl = new TiposLocalidadesImpl();
            return oTiposLocalidadesImpl.TiposLocalidadesDelete(Id);
        }

        public TiposLocalidades TiposLocalidadesGetById(string Id)
        {
            TiposLocalidadesImpl oTiposLocalidadesImpl = new TiposLocalidadesImpl();
            return oTiposLocalidadesImpl.TiposLocalidadesGetById(Id);
        }

        public List<TiposLocalidades> TiposLocalidadesGetAll()
        {
            TiposLocalidadesImpl oTiposLocalidadesImpl = new TiposLocalidadesImpl();
            return oTiposLocalidadesImpl.TiposLocalidadesGetAll();
        }

    }
}
