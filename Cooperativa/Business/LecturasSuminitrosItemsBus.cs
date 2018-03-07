using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Implement;

namespace Business
{
    public class LecturasSuminitrosItemsBus
    {

        public long LecturasSuministrosItemsAdd(LecturasSuministrosItems oLecSum)
        {
            LecturasSuministrosItemsImpl oLecSumItemsImpl = new LecturasSuministrosItemsImpl();
            return oLecSumItemsImpl.LecturasSuministrosItemsAdd(oLecSum);
        }

        public bool LecturasSuministrosItemsUpdate(LecturasSuministrosItems oLecSum)
        {
            LecturasSuministrosItemsImpl oLecSumItemsImpl = new LecturasSuministrosItemsImpl();
            return oLecSumItemsImpl.LecturasSuministrosItemsUpdate(oLecSum);
        }

        public bool LecturasSuministrosDelete(long Id)
        {
            LecturasSuministrosItemsImpl oLecSumItemsImpl = new LecturasSuministrosItemsImpl();
            return oLecSumItemsImpl.LecturasSuministrosItemsDelete(Id);
        }

        public LecturasSuministrosItems LecturasSuministrosGetById(long Id)
        {
            LecturasSuministrosItemsImpl oLecSumItemsImpl = new LecturasSuministrosItemsImpl();
            return oLecSumItemsImpl.LecturasSuministrosItemsGetById(Id);
        }

        public List<LecturasSuministrosItems> LecturasSuministrosGetAll()
        {
            LecturasSuministrosItemsImpl oLecSumItemsImpl = new LecturasSuministrosItemsImpl();
            return oLecSumItemsImpl.LecturasSuministrosItemsGetAll();
        }
        //public DataTable FabricantesGetAllDT()
        //{
        //    FabricantesImpl oFabricantesImpl = new FabricantesImpl();
        //    return oFabricantesImpl.FabricantesGetAllDT();
        //}
    }
}
