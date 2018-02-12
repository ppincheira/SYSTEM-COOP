using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class AuditoriasBus
    {
        public int AuditoriasAdd(Auditorias oAuditorias)
        {
            AuditoriasImpl oAuditoriasImpl = new AuditoriasImpl();
            return oAuditoriasImpl.AuditoriasAdd(oAuditorias);
        }

        public bool AuditoriasUpdate(Auditorias oAuditorias)
        {
            AuditoriasImpl oAuditoriasImpl = new AuditoriasImpl();
            return oAuditoriasImpl.AuditoriasUpdate(oAuditorias);
        }

        public bool AuditoriasDelete(long Id)
        {
            AuditoriasImpl oAuditoriasImpl = new AuditoriasImpl();
            return oAuditoriasImpl.AuditoriasDelete(Id);
        }

        public Auditorias AuditoriasGetById(long Id)
        {
            AuditoriasImpl oAuditoriasImpl = new AuditoriasImpl();
            return oAuditoriasImpl.AuditoriasGetById(Id);
        }

        public List<Auditorias> AuditoriasGetAll()
        {
            AuditoriasImpl oAuditoriasImpl = new AuditoriasImpl();
            return oAuditoriasImpl.AuditoriasGetAll();
        }
    }
}
