using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class MonedasBus
    {
        public int MonedasAdd(Monedas oMonedas)
        {
            MonedasImpl oMonedasImpl = new MonedasImpl();
            return oMonedasImpl.MonedasAdd(oMonedas);
        }

        public bool MonedasUpdate(Monedas oMonedas)
        {
            MonedasImpl oMonedasImpl = new MonedasImpl();
            return oMonedasImpl.MonedasUpdate(oMonedas);
        }

        public bool MonedasDelete(short Id)
        {
            MonedasImpl oMonedasImpl = new MonedasImpl();
            return oMonedasImpl.MonedasDelete(Id);
        }

        public Monedas MonedasGetById(short Id)
        {
            MonedasImpl oMonedasImpl = new MonedasImpl();
            return oMonedasImpl.MonedasGetById(Id);
        }

        public List<Monedas> MonedasGetAll()
        {
            MonedasImpl oMonedasImpl = new MonedasImpl();
            return oMonedasImpl.MonedasGetAll();
        }
    }
}
