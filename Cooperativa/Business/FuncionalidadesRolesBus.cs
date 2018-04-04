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
    public class FuncionalidadesRolesBus
    {
        public int FuncionalidadesAdd(FuncionalidadesRoles oFuncionalidades)
        {
            FuncionalidadesRolesImpl oFuncionalidadesImpl = new FuncionalidadesRolesImpl();
            return oFuncionalidadesImpl.FuncionalidadesRolesAdd(oFuncionalidades);
        }

        public bool FuncionalidadesUpdate(FuncionalidadesRoles oFuncionalidades)
        {
            FuncionalidadesRolesImpl oFuncionalidadesImpl = new FuncionalidadesRolesImpl();
            return oFuncionalidadesImpl.FuncionalidadesRolesUpdate(oFuncionalidades);
        }

        public bool FuncionalidadesDelete(String Id)
        {
            FuncionalidadesRolesImpl oFuncionalidadesImpl = new FuncionalidadesRolesImpl();
            return oFuncionalidadesImpl.FuncionalidadesRolesDelete(Id);
        }

        public List<FuncionalidadesRoles> FuncionalidadesGetById(string Id)
        {
            FuncionalidadesRolesImpl oFuncionalidadesImpl = new FuncionalidadesRolesImpl();
            return oFuncionalidadesImpl.FuncionalidadesRolesGetById(Id);
        }

        public List<FuncionalidadesRoles> FuncionalidadesGetAll()
        {
            FuncionalidadesRolesImpl oFuncionalidadesImpl = new FuncionalidadesRolesImpl();
            return oFuncionalidadesImpl.FuncionalidadesRolesGetAll();
        }       
    }
}

