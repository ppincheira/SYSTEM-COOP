using System.Collections.Generic;
using Implement;
using Model;
using System;
using System.Data;

namespace Business
{
    public class ObservacionesBus
    {
        public long ObservacionesAdd(Observaciones oObservaciones)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesAdd(oObservaciones);
        }
        public long ObservacionesAdd(Observaciones oObservaciones, AdminObs oAdmin )
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesAdd(oObservaciones, oAdmin);
        }

        public bool ObservacionesUpdate(Observaciones oObservaciones)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesUpdate(oObservaciones);
        }

        public bool ObservacionesDelete(long Id)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesDelete(Id);
        }

         
        public Observaciones ObservacionesGetById(long Id)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetById(Id);
        }

        public Observaciones ObservacionesGetByCodigoRegistroDefecto(long CodigoRegistro, string TabCodigo)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetByCodigoRegistroDefecto(CodigoRegistro,TabCodigo);
        }

        public List<Observaciones> ObservacionesGetAll()
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetAll();
        }

        public DataTable ObservacionesGetByFilter(AdminObs oAdmin, DateTime fechaDesde, DateTime fechaHasta)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetByFilter(oAdmin, fechaDesde, fechaHasta);
        }

        public DataTable ObservacionesGetAdjuntoById(int Id)
        {
            ObservacionesImpl oObservacionesImpl = new ObservacionesImpl();
            return oObservacionesImpl.ObservacionesGetAdjuntoById(Id);

        }
    }
}
