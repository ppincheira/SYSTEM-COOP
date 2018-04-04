using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class GruposDetallesBus
    {
        public long GruposDetallesAdd(GruposDetalles oGruposDetalles)
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesAdd(oGruposDetalles);
        }

        public bool GruposDetallesUpdate(GruposDetalles oGruposDetalles)
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesUpdate(oGruposDetalles);
        }

        public bool GruposDetallesDelete(long Id)
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesDelete(Id);
        }

        public GruposDetalles GruposDetallesGetById(long Id)
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesGetById(Id);
        }

        public bool GruposDetallesTipoDelete(string CodReg, string CodTipo)
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesTipoDelete(CodReg, CodTipo);
        }

        public GruposDetalles GruposDetallesGetByCodReg(string Id)
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesGetByCodReg(Id);
        }

        public GruposDetalles GruposDetallesGetByTipo(string CodReg,string CodTipo)
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesGetByTipo(CodReg,CodTipo);
        }

        public List<GruposDetalles> GruposDetallesGetAll()
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesGetAll();
        }
        public List<GruposDetalles> GruposDetallesGetbyGrupo(long Grupo)
        {
            GruposDetallesImpl oGruposDetallesImpl = new GruposDetallesImpl();
            return oGruposDetallesImpl.GruposDetallesGetbyGrupo(Grupo);
        }
    }
}
