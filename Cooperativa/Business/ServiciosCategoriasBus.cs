using System.Collections.Generic;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class ServiciosCategoriasBus
    {
        public long ServiciosCategoriasAdd(ServiciosCategorias oServiciosCategorias)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasAdd(oServiciosCategorias);
        }

        public bool ServiciosCategoriasUpdate(ServiciosCategorias oServiciosCategorias)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasUpdate(oServiciosCategorias);
        }

        public bool ServiciosCategoriasDelete(long Id)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasDelete(Id);
        }

        public ServiciosCategorias ServiciosCategoriasGetById(long Id)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasGetById(Id);
        }

        public List<ServiciosCategorias> ServiciosCategoriasGetAll()
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasGetAll();
        }
        public DataTable ServiciosCategoriasGetbySrv(string srvCodigo)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasGetbySrv(srvCodigo);
        }
        public DataTable ServiciosCategoriasCdtGetbySrv(string srvCodigo)
        {
            ServiciosCategoriasImpl oServiciosCategoriasImpl = new ServiciosCategoriasImpl();
            return oServiciosCategoriasImpl.ServiciosCategoriasCdtGetbySrv(srvCodigo);
        }
       
    }
}
