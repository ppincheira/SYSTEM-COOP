using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class CuadrosTarifariosBus
    {
        public long CuadrosTarifariosAdd(CuadrosTarifarios oCuadrosTarifarios)
        {
            CuadrosTarifariosImpl oCuadrosTarifariosImpl = new CuadrosTarifariosImpl();
            return oCuadrosTarifariosImpl.CuadrosTarifariosAdd(oCuadrosTarifarios);
        }

        public bool CuadrosTarifariosUpdate(CuadrosTarifarios oCuadrosTarifarios)
        {
            CuadrosTarifariosImpl oCuadrosTarifariosImpl = new CuadrosTarifariosImpl();
            return oCuadrosTarifariosImpl.CuadrosTarifariosUpdate(oCuadrosTarifarios);
        }

        public bool CuadrosTarifariosDelete(long Id)
        {
            CuadrosTarifariosImpl oCuadrosTarifariosImpl = new CuadrosTarifariosImpl();
            return oCuadrosTarifariosImpl.CuadrosTarifariosDelete(Id);
        }

        public CuadrosTarifarios CuadrosTarifariosGetById(long Id)
        {
            CuadrosTarifariosImpl oCuadrosTarifariosImpl = new CuadrosTarifariosImpl();
            return oCuadrosTarifariosImpl.CuadrosTarifariosGetById(Id);
        }

        //public CuadrosTarifarios CuadrosTarifariosGetByEmpNumero(long EmpNumero)
        //{
        //    CuadrosTarifariosImpl oCuadrosTarifariosImpl = new CuadrosTarifariosImpl();
        //    return oCuadrosTarifariosImpl.CuadrosTarifariosGetById(EmpNumero);
        //}
        public List<CuadrosTarifarios> CuadrosTarifariosGetAll()
        {
            CuadrosTarifariosImpl oCuadrosTarifariosImpl = new CuadrosTarifariosImpl();
            return oCuadrosTarifariosImpl.CuadrosTarifariosGetAll();
        }
        public DataTable CuadrosTarifariosGetAllDT()
        {
            CuadrosTarifariosImpl oCuadrosTarifariosImpl = new CuadrosTarifariosImpl();
            return oCuadrosTarifariosImpl.CuadrosTarifariosGetAllDT();
        }
    }
}
