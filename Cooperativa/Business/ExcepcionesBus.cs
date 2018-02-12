using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;
namespace Business
{
    public class ExcepcionesBus
    {
        public int ExcepcionesAdd(Excepciones oExcepciones)
        {
            ExcepcionesImpl oExcepcionesImpl = new ExcepcionesImpl();
            return oExcepcionesImpl.ExcepcionesAdd(oExcepciones);
        }

        public bool ExcepcionesUpdate(Excepciones oExcepciones)
        {
            ExcepcionesImpl oExcepcionesImpl = new ExcepcionesImpl();
            return oExcepcionesImpl.ExcepcionesUpdate(oExcepciones);
        }

        public bool ExcepcionesDelete(String Id)
        {
            ExcepcionesImpl oExcepcionesImpl = new ExcepcionesImpl();
            return oExcepcionesImpl.ExcepcionesDelete(Id);
        }

        public Excepciones ExcepcionesGetById(string Id)
        {
            ExcepcionesImpl oExcepcionesImpl = new ExcepcionesImpl();
            return oExcepcionesImpl.ExcepcionesGetById(Id);
        }

        public List<Excepciones> ExcepcionesGetAll()
        {
            ExcepcionesImpl oExcepcionesImpl = new ExcepcionesImpl();
            return oExcepcionesImpl.ExcepcionesGetAll();
        }

    }
}