using System;
using System.Collections.Generic;
using Implement;
using Model;

namespace Busines
{
    public class RolesMenuItemsBus
    {
        public int RolesMenuItemsAdd(RolesMenuItems oRolesMenuItems)
        {
            RolesMenuItemsImpl oRolesMenuItemsImp = new RolesMenuItemsImpl();
            return oRolesMenuItemsImp.RolesMenuItemsAdd(oRolesMenuItems);
        }

        public bool RolesMenuItemsUpdate(RolesMenuItems oRolesMenuItemsA, RolesMenuItems oRolesMenuItemsN)
        {
            RolesMenuItemsImpl oRolesMenuItemsImp = new RolesMenuItemsImpl();
            return oRolesMenuItemsImp.RolesMenuItemsUpdate(oRolesMenuItemsA, oRolesMenuItemsN);
        }

        public bool RolesMenuItemsDelete(string IdRol, string IdMni)
        {
            RolesMenuItemsImpl oRolesMenuItemsImp = new RolesMenuItemsImpl();
            return oRolesMenuItemsImp.RolesMenuItemsDelete(IdRol, IdMni);
        }

        public RolesMenuItems RolesMenuItemsGetById(string IdRol, string IdMni)
        {
            RolesMenuItemsImpl oRolesMenuItemsImp = new RolesMenuItemsImpl();
            return oRolesMenuItemsImp.RolesMenuItemsGetById(IdRol, IdMni);
        }

        public List<RolesMenuItems> RolesMenuItemsGetByRol(string Id)
        {
            RolesMenuItemsImpl oRolesMenuItemsImp = new RolesMenuItemsImpl();
            return oRolesMenuItemsImp.RolesMenuItemsGetByRol(Id);
        }
        public List<RolesMenuItems> RolesMenuItemsGetByMenu(string Id)
        {
            RolesMenuItemsImpl oRolesMenuItemsImp = new RolesMenuItemsImpl();
            return oRolesMenuItemsImp.RolesMenuItemsGetByMenu(Id);
        }

        public List<RolesMenuItems> RolesMenuItemsGetAll()
        {
            RolesMenuItemsImpl oRolesMenuItemsImp = new RolesMenuItemsImpl();
            return oRolesMenuItemsImp.RolesMenuItemsGetAll();
        }
    }
}
