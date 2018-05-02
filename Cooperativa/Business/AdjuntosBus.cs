using Model;
using Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business
{
    public class AdjuntosBus
    {
        public long AdjuntosAdd(Adjuntos oAdjunto)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosAdd(oAdjunto);
        }

        public bool AdjuntoUpdate(Adjuntos oAdjunto)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosUpdate(oAdjunto);
        }

        public Transacciones AdjuntosAddTrans(Adjuntos oAdjunto)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosAddTrans(oAdjunto);
        }

        public Transacciones AdjuntoUpdateTrans(Adjuntos oAdjunto)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosUpdateTrans(oAdjunto);
        }

        public bool AdjuntosDelete(long Id)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosDelete(Id);
        }

        public Adjuntos AdjuntosGetById(long Id)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosGetById(Id);
        }

        public Boolean AdjuntoExisteByCodigoRegistro(long Id,string tabcodigo) {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntoExisteByCodigoRegistro(Id,tabcodigo);
        }
        public Adjuntos AdjuntosGetByCodigoRegistro(long Id, string TabCodigo)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosGetByCodigoRegistro(Id, TabCodigo);
        }

        public DataTable AdjuntoGetAdjuntoById(long Id)
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntoGetAdjuntoById(Id);
        }
        public List<Adjuntos> AdjuntosGetAll()
        {
            AdjuntosImpl oAdjuntoImpl = new AdjuntosImpl();
            return oAdjuntoImpl.AdjuntosGetAll();
        }

    }
}
