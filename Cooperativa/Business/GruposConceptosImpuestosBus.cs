using System;
using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class GruposConceptosImpuestosBus
    {
        public DataTable GruposConceptosImpuestosGetAllDT()
        {
            GruposConceptosImpuestosImpl oGruposConceptosImpuestosImpl = new GruposConceptosImpuestosImpl();
            return oGruposConceptosImpuestosImpl.GruposConceptosImpuestosGetAllDT();
        }
        public GruposConceptosImpuestos GruposConceptosImpuestosGetById(string Id)
        {
            GruposConceptosImpuestosImpl oGruposConceptosImpuestosImpl = new GruposConceptosImpuestosImpl();
            return oGruposConceptosImpuestosImpl.GruposConceptosImpuestosGetById(Id);
        }
    }
}
