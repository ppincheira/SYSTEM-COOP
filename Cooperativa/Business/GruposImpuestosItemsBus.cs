using System.Collections.Generic;
using Implement;
using Model;
using System.Data;


namespace Business
{
    public class GruposImpuestosItemsBus
    {
        public long GruposImpuestosItemsAdd(GruposImpuestosItems oGruposImpuestosItems)
        {
            GruposImpuestosItemsImpl oGruposImpuestosItemsImpl = new GruposImpuestosItemsImpl();
            return oGruposImpuestosItemsImpl.GruposImpuestosItemsAdd(oGruposImpuestosItems);
        }

        public bool GruposImpuestosItemsUpdate(GruposImpuestosItems oGruposImpuestosItems)
        {
            GruposImpuestosItemsImpl oGruposImpuestosItemsImpl = new GruposImpuestosItemsImpl();
            return oGruposImpuestosItemsImpl.GruposImpuestosItemsUpdate(oGruposImpuestosItems);
        }

        public bool GruposImpuestosItemsDelete(int Id)
        {
            GruposImpuestosItemsImpl oGruposImpuestosItemsImpl = new GruposImpuestosItemsImpl();
            return oGruposImpuestosItemsImpl.GruposImpuestosItemsDelete(Id);
        }

        public GruposImpuestosItems GruposImpuestosItemsGetById(long Id)
        {
            GruposImpuestosItemsImpl oGruposImpuestosItemsImpl = new GruposImpuestosItemsImpl();
            return oGruposImpuestosItemsImpl.GruposImpuestosItemsGetById(Id);
        }

        public List<GruposImpuestosItems> GruposImpuestosItemsGetAll()
        {
            GruposImpuestosItemsImpl oGruposImpuestosItemsImpl = new GruposImpuestosItemsImpl();
            return oGruposImpuestosItemsImpl.GruposImpuestosItemsGetAll();
        }
        public DataTable GruposImpuestosItemsGetByFilter()
        {
            GruposImpuestosItemsImpl oGruposImpuestosItemsImpl = new GruposImpuestosItemsImpl();
            return oGruposImpuestosItemsImpl.GruposImpuestosItemsGetByFilter();
        }
    }
}
