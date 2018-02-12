using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class FabricantesBus
    {
        public long FabricantesAdd(Fabricantes oFabricantes)
        {
            FabricantesImpl oFabricantesImpl = new FabricantesImpl();
            return oFabricantesImpl.FabricantesAdd(oFabricantes);
        }

        public bool FabricantesUpdate(Fabricantes oFabricantes)
        {
            FabricantesImpl oFabricantesImpl = new FabricantesImpl();
            return oFabricantesImpl.FabricantesUpdate(oFabricantes);
        }

        public bool FabricantesDelete(int Id)
        {
            FabricantesImpl oFabricantesImpl = new FabricantesImpl();
            return oFabricantesImpl.FabricantesDelete(Id);
        }

        public Fabricantes FabricantesGetById(long Id)
        {
            FabricantesImpl oFabricantesImpl = new FabricantesImpl();
            return oFabricantesImpl.FabricantesGetById(Id);
        }

        public List<Fabricantes> FabricantesGetAll()
        {
            FabricantesImpl oFabricantesImpl = new FabricantesImpl();
            return oFabricantesImpl.FabricantesGetAll();
        }
        public DataTable FabricantesGetAllDT()
        {
            FabricantesImpl oFabricantesImpl = new FabricantesImpl();
            return oFabricantesImpl.FabricantesGetAllDT();
        }
    }
}
