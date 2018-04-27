using System.Collections.Generic;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class SuministrosMedidoresBus
    {
        public long SuministrosMedidoresAdd(SuministrosMedidores oSuministrosMedidores)
        {
            SuministrosMedidoresImpl oSuministrosMedidoresImpl = new SuministrosMedidoresImpl();
            return oSuministrosMedidoresImpl.SuministrosMedidoresAdd(oSuministrosMedidores);
        }

        public bool SuministrosMedidoresUpdate(SuministrosMedidores oSuministrosMedidores)
        {
            SuministrosMedidoresImpl oSuministrosMedidoresImpl = new SuministrosMedidoresImpl();
            return oSuministrosMedidoresImpl.SuministrosMedidoresUpdate(oSuministrosMedidores);
        }

        public bool SuministrosMedidoresDelete(long Id)
        {
            SuministrosMedidoresImpl oSuministrosMedidoresImpl = new SuministrosMedidoresImpl();
            return oSuministrosMedidoresImpl.SuministrosMedidoresDelete(Id);
        }

        public SuministrosMedidores SuministrosMedidoresGetById(long Id)
        {
            SuministrosMedidoresImpl oSuministrosMedidoresImpl = new SuministrosMedidoresImpl();
            return oSuministrosMedidoresImpl.SuministrosMedidoresGetById(Id);
        }

        public SuministrosMedidores SuministrosMedidoresGetBySuministro(long Id)
        {
            SuministrosMedidoresImpl oSuministrosMedidoresImpl = new SuministrosMedidoresImpl();
            return oSuministrosMedidoresImpl.SuministrosMedidoresGetBySuministro(Id);
        }
        public DataTable SuministrosMedidoresGetBySuministroDT(long Id)
        {
            SuministrosMedidoresImpl oSuministrosMedidoresImpl = new SuministrosMedidoresImpl();
            return oSuministrosMedidoresImpl.SuministrosMedidoresGetBySuministroDT(Id);
        }
        public List<SuministrosMedidores> SuministrosMedidoresGetAll()
        {
            SuministrosMedidoresImpl oSuministrosMedidoresImpl = new SuministrosMedidoresImpl();
            return oSuministrosMedidoresImpl.SuministrosMedidoresGetAll();
        }
    }
}
