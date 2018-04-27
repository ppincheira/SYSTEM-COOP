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
    }
}
