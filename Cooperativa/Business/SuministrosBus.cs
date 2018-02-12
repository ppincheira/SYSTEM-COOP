using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class SuministrosBus
    {
        public long SuministrosAdd(Suministros oSuministros)
        {
            SuministrosImpl oSuministrosImpl = new SuministrosImpl();
            return oSuministrosImpl.SuministrosAdd(oSuministros);
        }

        public bool SuministrosUpdate(Suministros oSuministros)
        {
            SuministrosImpl oSuministrosImpl = new SuministrosImpl();
            return oSuministrosImpl.SuministrosUpdate(oSuministros);
        }

        public bool SuministrosDelete(long Id)
        {
            SuministrosImpl oSuministrosImpl = new SuministrosImpl();
            return oSuministrosImpl.SuministrosDelete(Id);
        }

        public Suministros SuministrosGetById(long Id)
        {
            SuministrosImpl oSuministrosImpl = new SuministrosImpl();
            return oSuministrosImpl.SuministrosGetById(Id);
        }

        public List<Suministros> SuministrosGetAll()
        {
            SuministrosImpl oSuministrosImpl = new SuministrosImpl();
            return oSuministrosImpl.SuministrosGetAll();
        }
    }
}
