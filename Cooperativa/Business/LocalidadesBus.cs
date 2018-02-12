using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class LocalidadesBus
    {

        public int LocalidadesAdd(Localidades oLocalidades)
        {
            LocalidadesImpl oLocalidadesImpl = new LocalidadesImpl();
            return oLocalidadesImpl.LocalidadesAdd(oLocalidades);
        }

        public bool LocalidadesUpdate(Localidades oLocalidades)
        {
            LocalidadesImpl oLocalidadesImpl = new LocalidadesImpl();
            return oLocalidadesImpl.LocalidadesUpdate(oLocalidades);
        }

        public bool LocalidadesDelete(int Id)
        {
            LocalidadesImpl oLocalidadesImpl = new LocalidadesImpl();
            return oLocalidadesImpl.LocalidadesDelete(Id);
        }

        public Localidades LocalidadesGetById(int Id)
        {
            LocalidadesImpl oLocalidadesImpl = new LocalidadesImpl();
            return oLocalidadesImpl.LocalidadesGetById(Id);
        }

        public List<Localidades> LocalidadesGetAll()
        {
            LocalidadesImpl oLocalidadesImpl = new LocalidadesImpl();
            return oLocalidadesImpl.LocalidadesGetAll();
        }

        public DataTable LocalidadesGetByProvincia(string Codigo) {
            LocalidadesImpl oLocalidadesImpl = new LocalidadesImpl();
            return oLocalidadesImpl.LocalidadesGetByProvincia(Codigo);
        }
    }
}
