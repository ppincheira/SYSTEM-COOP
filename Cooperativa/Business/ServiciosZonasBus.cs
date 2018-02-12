using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class ServiciosZonasBus
    {
        public int ServiciosZonasAdd(ServiciosZonas oServiciosZonas)
        {
            ServiciosZonasImpl oServiciosZonasImpl = new ServiciosZonasImpl();
            return oServiciosZonasImpl.ServiciosZonasAdd(oServiciosZonas);
        }

        public bool ServiciosZonasUpdate(ServiciosZonas oServiciosZonas)
        {
            ServiciosZonasImpl oServiciosZonasImpl = new ServiciosZonasImpl();
            return oServiciosZonasImpl.ServiciosZonasUpdate(oServiciosZonas);
        }

        public bool ServiciosZonasDelete(long Id)
        {
            ServiciosZonasImpl oServiciosZonasImpl = new ServiciosZonasImpl();
            return oServiciosZonasImpl.ServiciosZonasDelete(Id);
        }

        public ServiciosZonas ServiciosZonasGetById(long Id)
        {
            ServiciosZonasImpl oServiciosZonasImpl = new ServiciosZonasImpl();
            return oServiciosZonasImpl.ServiciosZonasGetById(Id);
        }

        public List<ServiciosZonas> ServiciosZonasGetAll()
        {
            ServiciosZonasImpl oServiciosZonasImpl = new ServiciosZonasImpl();
            return oServiciosZonasImpl.ServiciosZonasGetAll();
        }
    }
}
