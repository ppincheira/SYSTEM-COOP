using System;
using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class TiposMedidoresFabricantesBus
    {
        public int TiposMedidoresFabricantesAdd(TiposMedidoresFabricantes oTiposMedidoresFabricantes)
        {
            TiposMedidoresFabricantesImpl oTiposMedidoresFabricantesImpl = new TiposMedidoresFabricantesImpl();
            return oTiposMedidoresFabricantesImpl.TiposMedidoresFabricantesAdd(oTiposMedidoresFabricantes);
        }

        public bool TiposMedidoresFabricantesUpdate(TiposMedidoresFabricantes oTiposMedidoresFabricantes)
        {
            TiposMedidoresFabricantesImpl oTiposMedidoresFabricantesImpl = new TiposMedidoresFabricantesImpl();
            return oTiposMedidoresFabricantesImpl.TiposMedidoresFabricantesUpdate(oTiposMedidoresFabricantes);
        }

        public bool TiposMedidoresFabricantesDelete(String Id, int Fab)
        {
            TiposMedidoresFabricantesImpl oTiposMedidoresFabricantesImpl = new TiposMedidoresFabricantesImpl();
            return oTiposMedidoresFabricantesImpl.TiposMedidoresFabricantesDelete(Id, Fab);
        }

        public TiposMedidoresFabricantes TiposMedidoresFabricantesGetById(string Id, int Fab)
        {
            TiposMedidoresFabricantesImpl oTiposMedidoresFabricantesImpl = new TiposMedidoresFabricantesImpl();
            return oTiposMedidoresFabricantesImpl.TiposMedidoresFabricantesGetById(Id, Fab);
        }

        public List<TiposMedidoresFabricantes> TiposMedidoresFabricantesGetAll()
        {
            TiposMedidoresFabricantesImpl oTiposMedidoresFabricantesImpl = new TiposMedidoresFabricantesImpl();
            return oTiposMedidoresFabricantesImpl.TiposMedidoresFabricantesGetAll();
        }

    }
}
