using System.Collections.Generic;
using Implement;
using Model;


namespace Business
{
    public class PuntosVentasBus
    {

        public int PuntosVentasAdd(PuntosVentas oPv)
        {
            PuntosVentasImpl oPVImpl = new PuntosVentasImpl();
            return oPVImpl.PuntosVentasAdd(oPv);
        }

        public bool PuntosVentasUpdate(PuntosVentas oPv)
        {
            PuntosVentasImpl oPVImpl = new PuntosVentasImpl();
            return oPVImpl.PuntosVentasUpdate(oPv);
        }

        public bool PuntosVentasDelete(string Id)
        {
            PuntosVentasImpl oPVImpl = new PuntosVentasImpl();
            return oPVImpl.PuntosVentasDelete(Id);
        }

        public PuntosVentas PuntosVentasGetById(string Id)
        {
            PuntosVentasImpl oPVImpl = new PuntosVentasImpl();
            return oPVImpl.PuntosVentasGetById(Id);
        }

        public List<PuntosVentas> PuntosVentasGetAll()
        {
            PuntosVentasImpl oPVImpl = new PuntosVentasImpl();
            return oPVImpl.PuntosVentasGetAll();
        }
    }
}
