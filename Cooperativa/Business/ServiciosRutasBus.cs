using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class ServiciosRutasBus
    {
        public long ServiciosRutasAdd(ServiciosRutas oServiciosRutas)
        {
            ServiciosRutasImpl oServiciosRutasImpl = new ServiciosRutasImpl();
            return oServiciosRutasImpl.ServiciosRutasAdd(oServiciosRutas);
        }

        public bool ServiciosRutasUpdate(ServiciosRutas oServiciosRutas)
        {
            ServiciosRutasImpl oServiciosRutasImpl = new ServiciosRutasImpl();
            return oServiciosRutasImpl.ServiciosRutasUpdate(oServiciosRutas);
        }

        public bool ServiciosRutasDelete(long Id)
        {
            ServiciosRutasImpl oServiciosRutasImpl = new ServiciosRutasImpl();
            return oServiciosRutasImpl.ServiciosRutasDelete(Id);
        }

        public ServiciosRutas ServiciosRutasGetById(long Id)
        {
            ServiciosRutasImpl oServiciosRutasImpl = new ServiciosRutasImpl();
            return oServiciosRutasImpl.ServiciosRutasGetById(Id);
        }

        public List<ServiciosRutas> ServiciosRutasGetAll()
        {
            ServiciosRutasImpl oServiciosRutasImpl = new ServiciosRutasImpl();
            return oServiciosRutasImpl.ServiciosRutasGetAll();
        }
    }
}
