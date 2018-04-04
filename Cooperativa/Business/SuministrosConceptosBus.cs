using System.Collections.Generic;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class SuministrosConceptosBus
    {
        public long SuministrosConceptosAdd(SuministrosConceptos oSuministrosConceptos)
        {
            SuministrosConceptosImpl oSuministrosConceptosImpl = new SuministrosConceptosImpl();
            return oSuministrosConceptosImpl.SuministrosConceptosAdd(oSuministrosConceptos);
        }

        public bool SuministrosConceptosUpdate(SuministrosConceptos oSuministrosConceptos)
        {
            SuministrosConceptosImpl oSuministrosConceptosImpl = new SuministrosConceptosImpl();
            return oSuministrosConceptosImpl.SuministrosConceptosUpdate(oSuministrosConceptos);
        }

        public bool SuministrosConceptosDelete(long Id)
        {
            SuministrosConceptosImpl oSuministrosConceptosImpl = new SuministrosConceptosImpl();
            return oSuministrosConceptosImpl.SuministrosConceptosDelete(Id);
        }

        public SuministrosConceptos SuministrosConceptosGetById(long Id)
        {
            SuministrosConceptosImpl oSuministrosConceptosImpl = new SuministrosConceptosImpl();
            return oSuministrosConceptosImpl.SuministrosConceptosGetById(Id);
        }

        public DataTable SuministrosConceptosGetBySuministroDT(long Id)
        {
            SuministrosConceptosImpl oSuministrosConceptosImpl = new SuministrosConceptosImpl();
            return oSuministrosConceptosImpl.SuministrosConceptosGetBySuministroDT(Id);
        }

        public List<SuministrosConceptos> SuministrosConceptosGetAll()
        {
            SuministrosConceptosImpl oSuministrosConceptosImpl = new SuministrosConceptosImpl();
            return oSuministrosConceptosImpl.SuministrosConceptosGetAll();
        }
    }
}
