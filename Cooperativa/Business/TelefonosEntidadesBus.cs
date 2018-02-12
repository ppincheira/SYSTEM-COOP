using Implement;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TelefonosEntidadesBus
    {
        public int TelefonosEntidadesAdd(TelefonosEntidades oTelefonoEntidad)
        {
            TelefonosEntidadesImpl oTelefonosImpl = new TelefonosEntidadesImpl();
            return oTelefonosImpl.TelefonosEntidadesAdd(oTelefonoEntidad);
        }

        public bool TelefonosEntidadesUpdate(TelefonosEntidades oTelefonoEntidad)
        {
            TelefonosEntidadesImpl oTelefonosImpl = new TelefonosEntidadesImpl();
            return oTelefonosImpl.TelefonosEntidadesUpdate(oTelefonoEntidad);
        }

        public bool TelefonosEntidadesDelete(long Id)
        {
            TelefonosEntidadesImpl oTelefonosEntidadesImpl = new TelefonosEntidadesImpl();
            return oTelefonosEntidadesImpl.TelefonosEntidadesDelete(Id);
        }

        public TelefonosEntidades TelefonosEntidadesGetById(long Id)
        {
            TelefonosEntidadesImpl oTelefonosEntidadesImpl = new TelefonosEntidadesImpl();
            return oTelefonosEntidadesImpl.TelefonosEntidadesGetById(Id);
        }

        public List<TelefonosEntidades> TelefonosEntidadesGetAll()
        {
            TelefonosEntidadesImpl oTelEntidadesImpl = new TelefonosEntidadesImpl();
            return oTelEntidadesImpl.TelefonosEntidadesGetAll();
        }

        public DataTable TelefonosEntidadesGetByFilter(string tabCodigo, string telCodigoRegistro)
        {
            TelefonosEntidadesImpl oTelEntidadesImpl = new TelefonosEntidadesImpl();
            return oTelEntidadesImpl.TelefonosEntidadesGetByFilter(tabCodigo, telCodigoRegistro);
        }
    }
}
