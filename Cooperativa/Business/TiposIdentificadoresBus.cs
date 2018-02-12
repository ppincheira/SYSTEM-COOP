
using System;
using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class TiposIdentificadoresBus
    {
        public int TiposIdentificadoresAdd(TiposIdentificadores oTiposIdentificadores)
        {
            TiposIdentificadoresImpl oTiposIdentificadoresImpl = new TiposIdentificadoresImpl();
            return oTiposIdentificadoresImpl.TiposIdentificadoresAdd(oTiposIdentificadores);
        }

        public bool TiposIdentificadoresUpdate(TiposIdentificadores oTiposIdentificadores)
        {
            TiposIdentificadoresImpl oTiposIdentificadoresImpl = new TiposIdentificadoresImpl();
            return oTiposIdentificadoresImpl.TiposIdentificadoresUpdate(oTiposIdentificadores);
        }

        public bool TiposIdentificadoresDelete(String Id)
        {
            TiposIdentificadoresImpl oTiposIdentificadoresImpl = new TiposIdentificadoresImpl();
            return oTiposIdentificadoresImpl.TiposIdentificadoresDelete(Id);
        }

        public TiposIdentificadores TiposIdentificadoresGetById(string Id)
        {
            TiposIdentificadoresImpl oTiposIdentificadoresImpl = new TiposIdentificadoresImpl();
            return oTiposIdentificadoresImpl.TiposIdentificadoresGetById(Id);
        }

        public List<TiposIdentificadores> TiposIdentificadoresGetAll()
        {
            TiposIdentificadoresImpl oTiposIdentificadoresImpl = new TiposIdentificadoresImpl();
            return oTiposIdentificadoresImpl.TiposIdentificadoresGetAll();
        }
        public DataTable TiposIdentificadoresGetByFilter()
        {
            TiposIdentificadoresImpl oTiposIdentificadoresImpl = new TiposIdentificadoresImpl();
            return oTiposIdentificadoresImpl.TiposIdentificadoresGetByFilter();
        }
        public DataTable TiposIdentificadoresGetAllDT()
        {
            TiposIdentificadoresImpl oTiposIdentificadoresImpl = new TiposIdentificadoresImpl();
            return oTiposIdentificadoresImpl.TiposIdentificadoresGetAllDT();
        }
    }
}
