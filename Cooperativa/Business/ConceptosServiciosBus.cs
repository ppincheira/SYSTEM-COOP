using System;
using Implement;
using Model;
using System.Data;
using System.Collections.Generic;

namespace Business
{
    public class ConceptosServiciosBus
    {
        public DataTable ConceptosServiciosGetByFilter(long numero)
        {
            ConceptosServiciosImpl oConceptosServiciosImpl = new ConceptosServiciosImpl();
            return oConceptosServiciosImpl.ConceptosServiciosGetByFilter(numero);
        }

        public long ConceptosServiciosAdd(ConceptosServicios oConceptosServicios)
        {
            ConceptosServiciosImpl oConceptosServiciosImpl = new ConceptosServiciosImpl();
            return oConceptosServiciosImpl.ConceptosServiciosAdd(oConceptosServicios);
        }

        public bool ConceptosServiciosDelete(ConceptosServicios oConceptosServicios)
        {
            ConceptosServiciosImpl oConceptosServiciosImpl = new ConceptosServiciosImpl();
            return oConceptosServiciosImpl.ConceptosServiciosDelete(oConceptosServicios);
        }

        public Transacciones ConceptosServiciosAddTrans(ConceptosServicios oConceptosServicios)
        {
            ConceptosServiciosImpl oConceptosServiciosImpl = new ConceptosServiciosImpl();
            return oConceptosServiciosImpl.ConceptosServiciosAddTrans(oConceptosServicios);
        }

        public Transacciones ConceptosServiciosDeleteTrans(ConceptosServicios oConceptosServicios)
        {
            ConceptosServiciosImpl oConceptosServiciosImpl = new ConceptosServiciosImpl();
            return oConceptosServiciosImpl.ConceptosServiciosDeleteTrans(oConceptosServicios);
        }
    }
}
