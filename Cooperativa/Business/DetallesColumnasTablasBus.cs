using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class DetallesColumnasTablasBus
    {
        public int DetallesColumnasTablasAdd(DetallesColumnasTablas oDetallesColumnasTablas)
        {
            DetallesColumnasTablasImpl oDetallesColumnasTablasImpl = new DetallesColumnasTablasImpl();
            return oDetallesColumnasTablasImpl.DetallesColumnasTablasAdd(oDetallesColumnasTablas);
        }

        public bool DetallesColumnasTablasUpdate(DetallesColumnasTablas oDetallesColumnasTablas)
        {
            DetallesColumnasTablasImpl oDetallesColumnasTablasImpl = new DetallesColumnasTablasImpl();
            return oDetallesColumnasTablasImpl.DetallesColumnasTablasUpdate(oDetallesColumnasTablas);
        }

        public bool DetallesColumnasTablasDelete(String Id)
        {
            DetallesColumnasTablasImpl oDetallesColumnasTablasImpl = new DetallesColumnasTablasImpl();
            return oDetallesColumnasTablasImpl.DetallesColumnasTablasDelete(Id);
        }

        public DetallesColumnasTablas DetallesColumnasTablasGetById(string Id)
        {
            DetallesColumnasTablasImpl oDetallesColumnasTablasImpl = new DetallesColumnasTablasImpl();
            return oDetallesColumnasTablasImpl.DetallesColumnasTablasGetById(Id);
        }

        public List<DetallesColumnasTablas> DetallesColumnasTablasGetAll()
        {
            DetallesColumnasTablasImpl oDetallesColumnasTablasImpl = new DetallesColumnasTablasImpl();
            return oDetallesColumnasTablasImpl.DetallesColumnasTablasGetAll();
        }

        public List<DetallesColumnasTablas> DetallesColumnasTablasGetByName(string name)
        {
            DetallesColumnasTablasImpl oDetallesColumnasTablasImpl = new DetallesColumnasTablasImpl();
            return oDetallesColumnasTablasImpl.DetallesColumnasTablasGetByName(name);
        }

        public List<DetallesColumnasTablas> DetallesColumnasTablasGetByCodigo(string codigo)
        {
            DetallesColumnasTablasImpl oDetallesColumnasTablasImpl = new DetallesColumnasTablasImpl();
            return oDetallesColumnasTablasImpl.DetallesColumnasTablasGetByCodigo(codigo);
        }


    }
}
