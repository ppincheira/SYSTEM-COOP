using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class AreasBus
    {
        public int AreasAdd(Areas oAreas)
        {
            AreasImpl oAreasImpl = new AreasImpl();
            return oAreasImpl.AreasAdd(oAreas);
        }

        public bool AreasUpdate(Areas oAreas)
        {
            AreasImpl oAreasImpl = new AreasImpl();
            return oAreasImpl.AreasUpdate(oAreas);
        }

        public bool AreasDelete(String Id)
        {
            AreasImpl oAreasImpl = new AreasImpl();
            return oAreasImpl.AreasDelete(Id);
        }

        public Areas AreasGetById(string Id)
        {
            AreasImpl oAreasImpl = new AreasImpl();
            return oAreasImpl.AreasGetById(Id);
        }

        public List<Areas> AreasGetAll()
        {
            AreasImpl oAreasImpl = new AreasImpl();
            return oAreasImpl.AreasGetAll();
        }
    }
}
