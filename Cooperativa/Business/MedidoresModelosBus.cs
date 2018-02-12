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
    public class MedidoresModelosBus
    {
        public long MedidoresModelosAdd(MedidoresModelos oMedidoresModelos)
        {
            MedidoresModelosImpl oMedidoresModelosImpl = new MedidoresModelosImpl();
            return oMedidoresModelosImpl.MedidoresModelosAdd(oMedidoresModelos);
        }

        public bool MedidoresModelosUpdate(MedidoresModelos oMedidoresModelos)
        {
            MedidoresModelosImpl oMedidoresModelosImpl = new MedidoresModelosImpl();
            return oMedidoresModelosImpl.MedidoresModelosUpdate(oMedidoresModelos);
        }

        public bool MedidoresModelosDelete(long Id)
        {
            MedidoresModelosImpl oMedidoresModelosImpl = new MedidoresModelosImpl();
            return oMedidoresModelosImpl.MedidoresModelosDelete(Id);
        }

        public MedidoresModelos MedidoresModelosGetById(long Id)
        {
            MedidoresModelosImpl oMedidoresModelosImpl = new MedidoresModelosImpl();
            return oMedidoresModelosImpl.MedidoresModelosGetById(Id);
        }

        public List<MedidoresModelos> MedidoresModelosGetAll()
        {
            MedidoresModelosImpl oMedidoresModelosImpl = new MedidoresModelosImpl();
            return oMedidoresModelosImpl.MedidoresModelosGetAll();
        }
        public DataTable MedidoresModelosGetAllDT()
        {
            MedidoresModelosImpl oMedidoresModelosImpl = new MedidoresModelosImpl();
            return oMedidoresModelosImpl.MedidoresModelosGetAllDT();
        }
    }
}
