using System;
using Implement;
using Model;
using System.Data;
using System.Collections.Generic;

namespace Business
{
    public class ConceptosFabricadosBus
    {
        public DataTable ConceptosFabricadosGetByFilter(long CodigoFabricado)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosGetByFilter(CodigoFabricado);
        }
        public long ConceptosFabricadosAdd(ConceptosFabricados oConceptosFabricados)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosAdd(oConceptosFabricados);
        }

        public bool ConceptosFabricadosUpdate(ConceptosFabricados oConceptosFabricados)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosUpdate(oConceptosFabricados);
        }

        public bool ConceptosFabricadosDelete(ConceptosFabricados oConceptosTiposComprobante)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosDelete(oConceptosTiposComprobante);
        }

        public bool ConceptosFabricadosDeleteAll(ConceptosFabricados oConceptosTiposComprobante)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosDeleteAll(oConceptosTiposComprobante);
        }

        public Transacciones ConceptosFabricadosAddTrans(ConceptosFabricados oConceptosFabricados)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosAddTrans(oConceptosFabricados);
        }

        public Transacciones ConceptosFabricadosUpdateTrans(ConceptosFabricados oConceptosFabricados)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosUpdateTrans(oConceptosFabricados);
        }

        public Transacciones ConceptosFabricadosDeleteTrans(ConceptosFabricados oConceptosTiposComprobante)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosDeleteTrans(oConceptosTiposComprobante);
        }

        public Transacciones ConceptosFabricadosDeleteAllTrans(ConceptosFabricados oConceptosTiposComprobante)
        {
            ConceptosFabricadosImpl oConceptosFabricadosImpl = new ConceptosFabricadosImpl();
            return oConceptosFabricadosImpl.ConceptosFabricadosDeleteAllTrans(oConceptosTiposComprobante);
        }
    }
}
