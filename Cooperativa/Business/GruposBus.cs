using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class GruposBus
    {
        public long GruposAdd(Grupos oGrupos)
        {
            GruposImpl oGruposImpl = new GruposImpl();
            return oGruposImpl.GruposAdd(oGrupos);
        }

        public bool GruposUpdate(Grupos oGrupos)
        {
            GruposImpl oGruposImpl = new GruposImpl();
            return oGruposImpl.GruposUpdate(oGrupos);
        }

        public bool GruposDelete(long Id)
        {
            GruposImpl oGruposImpl = new GruposImpl();
            return oGruposImpl.GruposDelete(Id);
        }

        public Grupos GruposGetById(long Id)
        {
            GruposImpl oGruposImpl = new GruposImpl();
            return oGruposImpl.GruposGetById(Id);
        }

        public List<Grupos> GruposGetAll()
        {
            GruposImpl oGruposImpl = new GruposImpl();
            return oGruposImpl.GruposGetAll();
        }
        public List<Grupos> GruposGetbyTipoGrupo(string TipoGrupo)
        {
            GruposImpl oGruposImpl = new GruposImpl();
            return oGruposImpl.GruposGetbyTipoGrupo(TipoGrupo);
        }
        public DataTable GruposGetByFilter(string TipoGrupo)
        {
            GruposImpl oGruposImpl = new GruposImpl();
            return oGruposImpl.GruposGetByFilter(TipoGrupo);
        }
    }
}
