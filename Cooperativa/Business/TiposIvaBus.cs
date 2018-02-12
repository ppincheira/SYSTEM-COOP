using System;
using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class TiposIvaBus
    {
        public int TiposIvaAdd(TiposIva oTiposIva)
        {
            TiposIvaImpl oTiposIvaImpl = new TiposIvaImpl();
            return oTiposIvaImpl.TiposIvaAdd(oTiposIva);
        }

        public bool TiposIvaUpdate(TiposIva oTiposIva)
        {
            TiposIvaImpl oTiposIvaImpl = new TiposIvaImpl();
            return oTiposIvaImpl.TiposIvaUpdate(oTiposIva);
        }

        public bool TiposIvaDelete(String Id)
        {
            TiposIvaImpl oTiposIvaImpl = new TiposIvaImpl();
            return oTiposIvaImpl.TiposIvaDelete(Id);
        }

        public TiposIva TiposIvaGetById(string Id)
        {
            TiposIvaImpl oTiposIvaImpl = new TiposIvaImpl();
            return oTiposIvaImpl.TiposIvaGetById(Id);
        }

        public List<TiposIva> TiposIvaGetAll()
        {
            TiposIvaImpl oTiposIvaImpl = new TiposIvaImpl();
            return oTiposIvaImpl.TiposIvaGetAll();
        }


        public DataTable TiposIvaGetAllDT()
        {
            TiposIvaImpl oTiposIvaImpl = new TiposIvaImpl();
            return oTiposIvaImpl.TiposIvaGetAllDT();
        }
    }
}
