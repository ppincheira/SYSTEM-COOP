using System.Collections.Generic;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class EmpresasBus
    {
        public long EmpresasGetID()
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasGetID();
        }

        public long EmpresasAdd(Empresas oEmpresas)
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasAdd(oEmpresas);
        }

        public bool EmpresasUpdate(Empresas oEmpresas)
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasUpdate(oEmpresas);
        }

        public bool EmpresasDelete(long Id)
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasDelete(Id);
        }

        public Empresas EmpresasGetById(long Id)
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasGetById(Id);
        }

        public List<Empresas> EmpresasGetAll()
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasGetAll();
        }
        public DataTable EmpresasGetAllDT()
        {
            EmpresasImpl oEmpresasImpl = new EmpresasImpl();
            return oEmpresasImpl.EmpresasGetAllDT();
        }
    }
}
