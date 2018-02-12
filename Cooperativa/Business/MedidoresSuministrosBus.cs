using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class MedidoresSuministrosBus
    {
        public int MedidoresSuministrosAdd(MedidoresSuministros oMedidoresSuministros)
        {
            MedidoresSuministrosImpl oMedidoresSuministrosImpl = new MedidoresSuministrosImpl();
            return oMedidoresSuministrosImpl.MedidoresSuministrosAdd(oMedidoresSuministros);
        }

        public bool MedidoresSuministrosUpdate(MedidoresSuministros oMedidoresSuministros)
        {
            MedidoresSuministrosImpl oMedidoresSuministrosImpl = new MedidoresSuministrosImpl();
            return oMedidoresSuministrosImpl.MedidoresSuministrosUpdate(oMedidoresSuministros);
        }

        public bool MedidoresSuministrosDelete(long Id)
        {
            MedidoresSuministrosImpl oMedidoresSuministrosImpl = new MedidoresSuministrosImpl();
            return oMedidoresSuministrosImpl.MedidoresSuministrosDelete(Id);
        }

        public MedidoresSuministros MedidoresSuministrosGetById(long Id)
        {
            MedidoresSuministrosImpl oMedidoresSuministrosImpl = new MedidoresSuministrosImpl();
            return oMedidoresSuministrosImpl.MedidoresSuministrosGetById(Id);
        }

        public List<MedidoresSuministros> MedidoresSuministrosGetAll()
        {
            MedidoresSuministrosImpl oMedidoresSuministrosImpl = new MedidoresSuministrosImpl();
            return oMedidoresSuministrosImpl.MedidoresSuministrosGetAll();
        }
    }
}
