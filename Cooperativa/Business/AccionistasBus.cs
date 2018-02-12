using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class AccionistasBus
    {
        public int AccionistasAdd(Accionistas oAccionistas)
        {
            AccionistasImpl oAccionistasImpl = new AccionistasImpl();
            return oAccionistasImpl.AccionistasAdd(oAccionistas);
        }

        public bool AccionistasUpdate(Accionistas oAccionistas)
        {
            AccionistasImpl oAccionistasImpl = new AccionistasImpl();
            return oAccionistasImpl.AccionistasUpdate(oAccionistas);
        }

        public bool AccionistasDelete(long Id)
        {
            AccionistasImpl oAccionistasImpl = new AccionistasImpl();
            return oAccionistasImpl.AccionistasDelete(Id);
        }

        public Accionistas AccionistasGetById(long Id)
        {
            AccionistasImpl oAccionistasImpl = new AccionistasImpl();
            return oAccionistasImpl.AccionistasGetById(Id);
        }

        public List<Accionistas> AccionistasGetAll()
        {
            AccionistasImpl oAccionistasImpl = new AccionistasImpl();
            return oAccionistasImpl.AccionistasGetAll();
        }
    }
}
