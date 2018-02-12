using System;
using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class DominiosBus
    {
        public int DominiosAdd(Dominios oDominios)
        {
            DominiosImpl oDominiosImpl = new DominiosImpl();
            return oDominiosImpl.DominiosAdd(oDominios);
        }

        public bool DominiosUpdate(Dominios oDominios)
        {
            DominiosImpl oDominiosImpl = new DominiosImpl();
            return oDominiosImpl.DominiosUpdate(oDominios);
        }

        public bool DominiosDelete(string Codigo, string Valor)
        {
            DominiosImpl oDominiosImpl = new DominiosImpl();
            return oDominiosImpl.DominiosDelete(Codigo, Valor);
        }

        public Dominios DominiosGetById(string Codigo, string Valor)
        {
            DominiosImpl oDominiosImpl = new DominiosImpl();
            return oDominiosImpl.DominiosGetById(Codigo, Valor);
        }

        public List<Dominios> DominiosGetAll()
        {
            DominiosImpl oDominiosImpl = new DominiosImpl();
            return oDominiosImpl.DominiosGetAll();
        }
        public DataTable DominiosGetByFilter(string dmnCodigo)
        {
            DominiosImpl oDominiodImpl = new DominiosImpl();
            return oDominiodImpl.DominiosGetByFilter(dmnCodigo);
        }
        public List<Dominios> DominiosGetListByFilter(string dmnCodigo)
        {
            DominiosImpl oDominiodImpl = new DominiosImpl();
            return oDominiodImpl.DominiosGetListByFilter(dmnCodigo);
        }

    }
}
