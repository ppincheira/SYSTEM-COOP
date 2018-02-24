using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class ProvinciasBus
    {

        public int ProvinciasAdd(Provincias oProvincias)
        {
            ProvinciasImpl oProvinciasImpl = new ProvinciasImpl();
            return oProvinciasImpl.ProvinciasAdd(oProvincias);
        }

        public bool ProvinciasUpdate(Provincias oProvincias)
        {
            ProvinciasImpl oProvinciasImpl = new ProvinciasImpl();
            return oProvinciasImpl.ProvinciasUpdate(oProvincias);
        }

        public bool ProvinciasDelete(string Id)
        {
            ProvinciasImpl oProvinciasImpl = new ProvinciasImpl();
            return oProvinciasImpl.ProvinciasDelete(Id);
        }

        public Provincias ProvinciasGetById(string Id)
        {
            ProvinciasImpl oProvinciasImpl = new ProvinciasImpl();
            return oProvinciasImpl.ProvinciasGetById(Id);
        }

        public List<Provincias> ProvinciasGetAll()
        {
            ProvinciasImpl oProvinciasImpl = new ProvinciasImpl();
            return oProvinciasImpl.ProvinciasGetAll();
        }
        public DataTable ProvinciasGetByFilter(string Codigo)
        {
            ProvinciasImpl oProvinciasImpl = new ProvinciasImpl();
            return oProvinciasImpl.ProvinciasGetByFilter(Codigo);
        }
    }
}
