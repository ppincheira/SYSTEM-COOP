using System;
using System.Collections.Generic;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class SubsistemaBus
    {
        public int SubsistemaAdd(Subsistema oSubsistema)
        {
            SubsistemaImpl oSubsistemaImp = new SubsistemaImpl();
            return oSubsistemaImp.SubsistemaAdd(oSubsistema);
        }

        public bool SubsistemaUpdate(Subsistema oSubsistema)
        {
            SubsistemaImpl oSubsistemaImp = new SubsistemaImpl();
            return oSubsistemaImp.SubsistemaUpdate(oSubsistema);
        }

        public bool SubsistemaDelete(String Id)
        {
            SubsistemaImpl oSubsistemaImp = new SubsistemaImpl();
            return oSubsistemaImp.SubsistemaDelete(Id);
        }

        public Subsistema SubsistemaGetById(string Id)
        {
            SubsistemaImpl oSubsistemaImp = new SubsistemaImpl();
            return oSubsistemaImp.SubsistemaGetById(Id);
        }

        public DataTable SubsistemaGetDT()
        {
            SubsistemaImpl oSubsistemaImp = new SubsistemaImpl();
            return oSubsistemaImp.SubsistemaGetDT();
        }
        public List<Subsistema> SubsistemaGetAll()
        {
            SubsistemaImpl oSubsistemaImp = new SubsistemaImpl();
            return oSubsistemaImp.SubsistemaGetAll();
        }
    }
}
