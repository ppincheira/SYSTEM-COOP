using System;
using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class MonedasTasasCambioBus
    {
        public int MonedasTasasCambioAdd(MonedasTasasCambio oMTC)
        {
            MonedasTasasCambioImpl oMTCImpl = new MonedasTasasCambioImpl();
            return oMTCImpl.MonedasTasasCambioAdd(oMTC);
        }

        public bool MonedasTasasCambioUpdate(MonedasTasasCambio oMTC)
        {
            MonedasTasasCambioImpl oMTCImpl = new MonedasTasasCambioImpl();
            return oMTCImpl.MonedasTasasCambioUpdate(oMTC);
        }

        public bool MonedasTasasCambioDelete(short Id, DateTime Vigencia)
        {
            MonedasTasasCambioImpl oMTCImpl = new MonedasTasasCambioImpl();
            return oMTCImpl.MonedasTasasCambioDelete(Id, Vigencia);
        }

        public MonedasTasasCambio MonedasTasasCambioGetById(short Id, DateTime Vigencia)
        {
            MonedasTasasCambioImpl oMTCImpl = new MonedasTasasCambioImpl();
            return oMTCImpl.MonedasTasasCambioGetById(Id, Vigencia);
        }

        public List<MonedasTasasCambio> MonedasTasasCambioGetAll()
        {
            MonedasTasasCambioImpl oMTCImpl = new MonedasTasasCambioImpl();
            return oMTCImpl.MonedasTasasCambioGetAll();
        }
    }
}
