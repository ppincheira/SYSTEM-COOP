using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class PaisesBus
    {

        public int PaisesAdd(Paises oPaises)
        {
            PaisesImpl oPaisesImpl = new PaisesImpl();
            return oPaisesImpl.PaisesAdd(oPaises);
        }

        public bool PaisesUpdate(Paises oPaises)
        {
            PaisesImpl oPaisesImpl = new PaisesImpl();
            return oPaisesImpl.PaisesUpdate(oPaises);
        }

        public bool PaisesDelete(string Id)
        {
            PaisesImpl oPaisesImpl = new PaisesImpl();
            return oPaisesImpl.PaisesDelete(Id);
        }

        public Paises PaisesGetById(string Id)
        {
            PaisesImpl oPaisesImpl = new PaisesImpl();
            return oPaisesImpl.PaisesGetById(Id);
        }

        public List<Paises> PaisesGetAll()
        {
            PaisesImpl oPaisesImpl = new PaisesImpl();
            return oPaisesImpl.PaisesGetAll();
        }
    }
}
