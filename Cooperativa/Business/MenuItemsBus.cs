using System;
using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class MenuItemsBus
    {
        public int MenuItemsAdd(MenuItems oMenuItems)
        {
            MenuItemsImpl oMenuItemsImp = new MenuItemsImpl();
            return oMenuItemsImp.MenuItemsAdd(oMenuItems);
        }

        public bool MenuItemsUpdate(MenuItems oMenuItems)
        {
            MenuItemsImpl oMenuItemsImp = new MenuItemsImpl();
            return oMenuItemsImp.MenuItemsUpdate(oMenuItems);
        }

        public bool MenuItemsDelete(String Id)
        {
            MenuItemsImpl oMenuItemsImp = new MenuItemsImpl();
            return oMenuItemsImp.MenuItemsDelete(Id);
        }

        public MenuItems MenuItemsGetById(string Id)
        {
            MenuItemsImpl oMenuItemsImp = new MenuItemsImpl();
            return oMenuItemsImp.MenuItemsGetById(Id);
        }

        public List<MenuItems> MenuItemsGetBySbsCodigo(string Id)
        {
            MenuItemsImpl oMenuItemsImp = new MenuItemsImpl();
            return oMenuItemsImp.MenuItemsGetBySbsCodigo(Id);
        }

        public List<MenuItems> MenuItemsGetAll()
        {
            MenuItemsImpl oMenuItemsImp = new MenuItemsImpl();
            return oMenuItemsImp.MenuItemsGetAll();
        }


        public DataTable MenuItemsGetByIdCodigo(string codigo)
        {
            MenuItemsImpl oMenuItemsImp = new MenuItemsImpl();
            return oMenuItemsImp.MenuItemsGetByIdCodigo(codigo);
        }
    }
}
