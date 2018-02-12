using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class RolesBus
    {

        public int RolesAdd(Roles oRoles)
        {
            RolesImpl oRolesImpl = new RolesImpl();
            return oRolesImpl.RolesAdd(oRoles);
        }

        public bool RolesUpdate(Roles oRoles)
        {
            RolesImpl oRolesImpl = new RolesImpl();
            return oRolesImpl.RolesUpdate(oRoles);
        }

        public bool RolesDelete(string Id)
        {
            RolesImpl oRolesImpl = new RolesImpl();
            return oRolesImpl.RolesDelete(Id);
        }

        public Roles RolesGetById(string Id)
        {
            RolesImpl oRolesImpl = new RolesImpl();
            return oRolesImpl.RolesGetById(Id);
        }

        public List<Roles> RolesGetAll()
        {
            RolesImpl oRolesImpl = new RolesImpl();
            return oRolesImpl.RolesGetAll();
        }
    }
}
