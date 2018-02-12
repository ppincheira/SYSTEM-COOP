using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class TiposBarriosLocalidadesBus
    {
        public int TiposBarriosLocalidadesAdd(TiposBarriosLocalidades oTiposBarriosLocalidades)
        {
            TiposBarriosLocalidadesImpl oTiposBarriosLocalidadesImpl = new TiposBarriosLocalidadesImpl();
            return oTiposBarriosLocalidadesImpl.TiposBarriosLocalidadesAdd(oTiposBarriosLocalidades);
        }

        public bool TiposBarriosLocalidadesUpdate(TiposBarriosLocalidades oTiposBarriosLocalidades)
        {
            TiposBarriosLocalidadesImpl oTiposBarriosLocalidadesImpl = new TiposBarriosLocalidadesImpl();
            return oTiposBarriosLocalidadesImpl.TiposBarriosLocalidadesUpdate(oTiposBarriosLocalidades);
        }

        public bool TiposBarriosLocalidadesDelete(string Id)
        {
            TiposBarriosLocalidadesImpl oTiposBarriosLocalidadesImpl = new TiposBarriosLocalidadesImpl();
            return oTiposBarriosLocalidadesImpl.TiposBarriosLocalidadesDelete(Id);
        }

        public TiposBarriosLocalidades TiposBarriosLocalidadesGetById(string Id)
        {
            TiposBarriosLocalidadesImpl oTiposBarriosLocalidadesImpl = new TiposBarriosLocalidadesImpl();
            return oTiposBarriosLocalidadesImpl.TiposBarriosLocalidadesGetById(Id);
        }

        public List<TiposBarriosLocalidades> TiposBarriosLocalidadesGetAll()
        {
            TiposBarriosLocalidadesImpl oTiposBarriosLocalidadesImpl = new TiposBarriosLocalidadesImpl();
            return oTiposBarriosLocalidadesImpl.TiposBarriosLocalidadesGetAll();
        }
    }
}
