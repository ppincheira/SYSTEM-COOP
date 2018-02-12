using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class DistritosBus
    {
        public int DistritosAdd(Distritos oDistritos)
        {
            DistritosImpl oDistritosImpl = new DistritosImpl();
            return oDistritosImpl.DistritosAdd(oDistritos);
        }

        public bool DistritosUpdate(Distritos oDistritos)
        {
            DistritosImpl oDistritosImpl = new DistritosImpl();
            return oDistritosImpl.DistritosUpdate(oDistritos);
        }

        public bool DistritosDelete(long Id)
        {
            DistritosImpl oDistritosImpl = new DistritosImpl();
            return oDistritosImpl.DistritosDelete(Id);
        }

        public Distritos DistritosGetById(long Id)
        {
            DistritosImpl oDistritosImpl = new DistritosImpl();
            return oDistritosImpl.DistritosGetById(Id);
        }

        public List<Distritos> DistritosGetAll()
        {
            DistritosImpl oDistritosImpl = new DistritosImpl();
            return oDistritosImpl.DistritosGetAll();
        }
    }
}
