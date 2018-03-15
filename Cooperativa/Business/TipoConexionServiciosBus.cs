using System.Collections.Generic;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class TipoConexionServiciosBus
    {
        public int TipoConexionServiciosAdd(TipoConexionServicios oTipoConexionServicios)
        {
            TipoConexionServiciosImpl oTipoConexionServiciosImpl = new TipoConexionServiciosImpl();
            return oTipoConexionServiciosImpl.TipoConexionServiciosAdd(oTipoConexionServicios);
        }

        public bool TipoConexionServiciosUpdate(TipoConexionServicios oTipoConexionServicios)
        {
            TipoConexionServiciosImpl oTipoConexionServiciosImpl = new TipoConexionServiciosImpl();
            return oTipoConexionServiciosImpl.TipoConexionServiciosUpdate(oTipoConexionServicios);
        }

        public bool TipoConexionServiciosDelete(string Id)
        {
            TipoConexionServiciosImpl oTipoConexionServiciosImpl = new TipoConexionServiciosImpl();
            return oTipoConexionServiciosImpl.TipoConexionServiciosDelete(Id);
        }

        public TipoConexionServicios TipoConexionServiciosGetById(string Id)
        {
            TipoConexionServiciosImpl oTipoConexionServiciosImpl = new TipoConexionServiciosImpl();
            return oTipoConexionServiciosImpl.TipoConexionServiciosGetById(Id);
        }

        public List<TipoConexionServicios> TipoConexionServiciosGetAll()
        {
            TipoConexionServiciosImpl oTipoConexionServiciosImpl = new TipoConexionServiciosImpl();
            return oTipoConexionServiciosImpl.TipoConexionServiciosGetAll();
        }
        public DataTable TipoConexionServiciosGetAllDT()
        {
            TipoConexionServiciosImpl oTipoConexionServiciosImpl = new TipoConexionServiciosImpl();
            return oTipoConexionServiciosImpl.TipoConexionServiciosGetAllDT();
        }
    public DataTable TipoConexionServiciosGetByServicioDT(string servicio)
        {
            TipoConexionServiciosImpl oTipoConexionServiciosImpl = new TipoConexionServiciosImpl();
            return oTipoConexionServiciosImpl.TipoConexionServiciosGetByServicioDT(servicio);
        }
    }
}
