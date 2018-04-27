using Implement;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TiposComprobanteBus
    {
        public string TiposComprobantesAdd(TiposComprobante otc)
        {
            TiposComprobanteImpl otcmImpl = new TiposComprobanteImpl();
            return otcmImpl.TiposComprobanteAdd(otc);
        }
        public bool TiposComprobantesUpdate(TiposComprobante otc)
        {
            TiposComprobanteImpl otcmImpl = new TiposComprobanteImpl();
            return otcmImpl.TiposComprobanteUpdate(otc);
        }
        public TiposComprobante TiposComprobanteGetById( string id)
        {
            TiposComprobanteImpl otcmImpl = new TiposComprobanteImpl();
            return otcmImpl.TiposComprobanteGetById(id);
        }
        public List<TiposComprobante> TiposComprobanteGetAll()
        {
            TiposComprobanteImpl otcmImpl = new TiposComprobanteImpl();
            return otcmImpl.TiposMedidoresGetAll();
        }
        public DataTable TiposComprobanteGetDT()
        {
            TiposComprobanteImpl otcmImpl = new TiposComprobanteImpl();
            return otcmImpl.TiposComprobanteGetAllDT();
        }
    }
}
