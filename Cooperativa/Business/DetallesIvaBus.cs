using System;
using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class DetallesIvaBus
    {
        public int DetallesIvaAdd(DetallesIva oDetallesIva)
        {
            DetallesIvaImpl oDetallesIvaImpl = new DetallesIvaImpl();
            return oDetallesIvaImpl.DetallesIvaAdd(oDetallesIva);
        }

        public bool DetallesIvaUpdate(DetallesIva oDetallesIva)
        {
            DetallesIvaImpl oDetallesIvaImpl = new DetallesIvaImpl();
            return oDetallesIvaImpl.DetallesIvaUpdate(oDetallesIva);
        }

        public bool DetallesIvaDelete(string Tiv, DateTime Vig)
        {
            DetallesIvaImpl oDetallesIvaImpl = new DetallesIvaImpl();
            return oDetallesIvaImpl.DetallesIvaDelete(Tiv, Vig);
        }

        public DetallesIva DetallesIvaGetById(string Tiv, DateTime Vig)
        {
            DetallesIvaImpl oDetallesIvaImpl = new DetallesIvaImpl();
            return oDetallesIvaImpl.DetallesIvaGetById(Tiv, Vig);
        }

        public List<DetallesIva> DetallesIvaGetAll()
        {
            DetallesIvaImpl oDetallesIvaImpl = new DetallesIvaImpl();
            return oDetallesIvaImpl.DetallesIvaGetAll();
        }
    }
}
