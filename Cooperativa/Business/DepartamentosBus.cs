using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;


namespace Business
{
    public class DepartamentosBus
    {

        public int DepartamentosAdd(Departamentos oDepartamentos)
        {
            DepartamentosImpl oDepartamentosImpl = new DepartamentosImpl();
            return oDepartamentosImpl.DepartamentoAdd(oDepartamentos);
        }

        public bool DepartamentosUpdate(Departamentos oDepartamentos)
        {
            DepartamentosImpl oDepartamentosImpl = new DepartamentosImpl();
            return oDepartamentosImpl.DepartamentosUpdate(oDepartamentos);
        }

        public bool DepartamentosDelete(int Id)
        {
            DepartamentosImpl oDepartamentosImpl = new DepartamentosImpl();
            return oDepartamentosImpl.DepartamentosDelete(Id);
        }

        public Departamentos DepartamentosGetById(int Id)
        {
            DepartamentosImpl oDepartamentosImpl = new DepartamentosImpl();
            return oDepartamentosImpl.DepartamentosGetById(Id);
        }

        public List<Departamentos> DepartamentosGetAll()
        {
            DepartamentosImpl oDepartamentosImpl = new DepartamentosImpl();
            return oDepartamentosImpl.DepartamentosGetAll();
        }
   

    }
}
