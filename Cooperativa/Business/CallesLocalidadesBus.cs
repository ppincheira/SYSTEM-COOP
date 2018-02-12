using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class CallesLocalidadesBus
    {

        public long CallesLocalidadesAdd(CallesLocalidades oCallesLocalidades)
        {
            CallesLocalidadesImpl oCallesLocalidadesImpl = new CallesLocalidadesImpl();
            return oCallesLocalidadesImpl.CallesLocalidadesAdd(oCallesLocalidades);
        }

        public bool CallesLocalidadesUpdate(CallesLocalidades oCallesLocalidades)
        {
            CallesLocalidadesImpl oCallesLocalidadesImpl = new CallesLocalidadesImpl();
            return oCallesLocalidadesImpl.CallesLocalidadesUpdate(oCallesLocalidades);
        }

        public bool CallesLocalidadesDelete(long Id)
        {
            CallesLocalidadesImpl oCallesLocalidadesImpl = new CallesLocalidadesImpl();
            return oCallesLocalidadesImpl.CallesLocalidadesDelete(Id);
        }

        public CallesLocalidades CallesLocalidadesGetById(long Id)
        {
            CallesLocalidadesImpl oCallesLocalidadesImpl = new CallesLocalidadesImpl();
            return oCallesLocalidadesImpl.CallesLocalidadesGetById(Id);
        }

        public List<CallesLocalidades> CallesLocalidadesGetAll()
        {
            CallesLocalidadesImpl oCallesLocalidadesImpl = new CallesLocalidadesImpl();
            return oCallesLocalidadesImpl.CallesLocalidadesGetAll();
        }

        public DataTable CallesLocalidadesGetByLocalidad(int IdProvincia)
        {
            CallesLocalidadesImpl oCallesLocalidadesImpl = new CallesLocalidadesImpl();
            return oCallesLocalidadesImpl.CallesLocalidadesGetByLocalidad(IdProvincia);
        }
    }
}
