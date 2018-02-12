using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class DetallesAuditoriaBus
    {
        public int DetallesAuditoriaAdd(DetallesAuditoria oDetallesAuditoria)
        {
            DetallesAuditoriaImpl oDetallesAuditoriaImpl = new DetallesAuditoriaImpl();
            return oDetallesAuditoriaImpl.DetallesAuditoriaAdd(oDetallesAuditoria);
        }

        public bool DetallesAuditoriaUpdate(DetallesAuditoria oDetallesAuditoria)
        {
            DetallesAuditoriaImpl oDetallesAuditoriaImpl = new DetallesAuditoriaImpl();
            return oDetallesAuditoriaImpl.DetallesAuditoriaUpdate(oDetallesAuditoria);
        }

        public bool DetallesAuditoriaDelete(long Aud, short Dau)
        {
            DetallesAuditoriaImpl oDetallesAuditoriaImpl = new DetallesAuditoriaImpl();
            return oDetallesAuditoriaImpl.DetallesAuditoriaDelete(Aud, Dau);
        }

        public DetallesAuditoria DetallesAuditoriaGetById(long Aud, short Dau)
        {
            DetallesAuditoriaImpl oDetallesAuditoriaImpl = new DetallesAuditoriaImpl();
            return oDetallesAuditoriaImpl.DetallesAuditoriaGetById(Aud, Dau);
        }

        public List<DetallesAuditoria> DetallesAuditoriaGetAll()
        {
            DetallesAuditoriaImpl oDetallesAuditoriaImpl = new DetallesAuditoriaImpl();
            return oDetallesAuditoriaImpl.DetallesAuditoriaGetAll();
        }
    }
}
