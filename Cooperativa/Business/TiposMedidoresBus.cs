using System;
using System.Collections.Generic;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class TiposMedidoresBus
    {
        public int TiposMedidoresAdd(TiposMedidores oTiposMedidores)
        {
            TiposMedidoresImpl oTiposMedidoresImpl = new TiposMedidoresImpl();
            return oTiposMedidoresImpl.TiposMedidoresAdd(oTiposMedidores);
        }

        public bool TiposMedidoresUpdate(TiposMedidores oTiposMedidores)
        {
            TiposMedidoresImpl oTiposMedidoresImpl = new TiposMedidoresImpl();
            return oTiposMedidoresImpl.TiposMedidoresUpdate(oTiposMedidores);
        }

        public bool TiposMedidoresDelete(String Id)
        {
            TiposMedidoresImpl oTiposMedidoresImpl = new TiposMedidoresImpl();
            return oTiposMedidoresImpl.TiposMedidoresDelete(Id);
        }

        public TiposMedidores TiposMedidoresGetById(string Id)
        {
            TiposMedidoresImpl oTiposMedidoresImpl = new TiposMedidoresImpl();
            return oTiposMedidoresImpl.TiposMedidoresGetById(Id);
        }

        public List<TiposMedidores> TiposMedidoresGetAll()
        {
            TiposMedidoresImpl oTiposMedidoresImpl = new TiposMedidoresImpl();
            return oTiposMedidoresImpl.TiposMedidoresGetAll();
        }

        public DataTable TiposMedidoresGetAllDT()
        {
            TiposMedidoresImpl oTiposMedidoresImpl = new TiposMedidoresImpl();
            return oTiposMedidoresImpl.TiposMedidoresGetAllDT();
        }
    }
}
