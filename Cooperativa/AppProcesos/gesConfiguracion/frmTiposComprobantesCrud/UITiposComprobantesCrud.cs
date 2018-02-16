using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesConfiguracion.frmTiposComprobantesCrud
{
    public class UITiposComprobantesCrud
    {
        private IVistaTiposComprobantesCrud _vista;
        Utility oUtil;

        public UITiposComprobantesCrud(IVistaTiposComprobantesCrud vista)
        {
            this._vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {

            if (_vista.tcoCodigo != "")
            {
                TiposComprobante oTc = new TiposComprobante();
                TiposComprobanteBus oTcb = new TiposComprobanteBus();
                oTc = oTcb.TiposComprobanteGetById(_vista.tcoCodigo);
                _vista.tcoDescripcion = oTc.tcoDescripcion;
                _vista.tcoLetra = oTc.tcoLetra;
                _vista.tcoOrigenNumerado = oTc.tcoOrigenNumerado;
                _vista.tcoExterno = oTc.tcoExterno;
                _vista.tcoCantidadCopias = oTc.tcoCantidadCopias;
                _vista.pcbCodigo = oTc.pcbCodigo;
                _vista.tcoCodigoAfip = oTc.tcoCodigoAfip;
                _vista.tcoLibroIvaCompras = oTc.tcoLibroIvaCompras;
                _vista.tcoLibroIvaVentas = oTc.tcoLibroIvaVentas;
                _vista.tcoCodigoSicore = oTc.tcoCodigoSicore;
                _vista.tcmCantMinImpresion = oTc.tcmCantMinImpresion;
                _vista.tcoPreimpreso = oTc.tcoPreimpreso;
                _vista.tcoCodigoRece = oTc.tcoCodigoRece;
                _vista.estCodigo = oTc.estCodigo;
            }
        }


        public string Guardar()
        {
            string rtdo = "";
            TiposComprobante oTc = new TiposComprobante();
            TiposComprobanteBus oTcb = new TiposComprobanteBus();
            oTc.tcoDescripcion = _vista.tcoDescripcion;
            oTc.tcoCodigo = _vista.tcoCodigo;
            oTc.tcoLetra = _vista.tcoLetra;
            oTc.tcoOrigenNumerado = _vista.tcoOrigenNumerado;
            oTc.tcoExterno = _vista.tcoExterno;
            oTc.tcoCantidadCopias = _vista.tcoCantidadCopias;
            oTc.pcbCodigo = _vista.pcbCodigo;
            oTc.tcoCodigoAfip = _vista.tcoCodigoAfip;
            oTc.tcoLibroIvaCompras = _vista.tcoLibroIvaCompras;
            oTc.tcoLibroIvaVentas = _vista.tcoLibroIvaVentas;
            oTc.tcoCodigoSicore = _vista.tcoCodigoSicore;
            oTc.tcmCantMinImpresion = _vista.tcmCantMinImpresion;
            oTc.tcoPreimpreso = _vista.tcoPreimpreso;
            oTc.tcoCodigoRece = _vista.tcoCodigoRece;
            oTc.estCodigo = _vista.estCodigo;


            
            if (_vista.editar == "NO")
                rtdo = oTcb.TiposComprobantesAdd(oTc);
            else
            {
                rtdo = _vista.tcoCodigo;
                oTcb.TiposComprobantesUpdate(oTc);
            }


            return rtdo;
        }

        public bool EliminarTipoComprobante(string id)
        {
            TiposComprobanteBus oSMeBus = new TiposComprobanteBus();
            TiposComprobante oSMe = oSMeBus.TiposComprobanteGetById(id);
            oSMe.estCodigo = "B";
            return oSMeBus.TiposComprobantesUpdate(oSMe);
        }

    }
}
