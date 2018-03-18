using Business;
using Model;
using Service;
using System.Windows.Forms;
using System;
using System.Data;

namespace AppProcesos.gesConfiguracion.frmConceptosCrud
{
    public class UIConceptosCrud
    {
        private IVistaConceptosCrud _vista;
        Utility oUtil;

        public UIConceptosCrud(IVistaConceptosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }
        public void Inicializar()
        {       
            TiposConceptosBus oTicBus = new TiposConceptosBus();
            oUtil.CargarCombo(_vista.cmbTicCodigo, oTicBus.TiposConceptosGetByFilter(), "TIC_CODIGO", "TIC_DESCRIPCION", "Seleccione Tipo");

            ConceptosUnidadesMedidasBus oCumBus = new ConceptosUnidadesMedidasBus();
            oUtil.CargarCombo(_vista.cmbCumCodigo, oCumBus.ConceptosUnidadesMedidasGetByFilter(), "cum_codigo", "cum_descripcion", "Seleccione Unidad");
            
            if (_vista.logCptNumero != 0)
            {
                Conceptos oConceptos = new Conceptos();
                ConceptosBus oConceptosBus = new ConceptosBus();

                oConceptos = oConceptosBus.ConceptosGetById(_vista.logCptNumero);

                _vista.logCptNumero = oConceptos.cptNumero;
                _vista.strCptCodigo = oConceptos.cptCodigo;
                _vista.strCptDescripcion = oConceptos.cptDescripcion;
                _vista.strCptDescripcionCorta = oConceptos.cptDescripcionCorta;

                if (oConceptos.cptControlaStock == "S")
                    _vista.booCptControlaStock = true;
                else
                    _vista.booCptControlaStock = false;
                if (oConceptos.cptFraccionado == "S")
                    _vista.booCptFraccionado = true;
                else
                    _vista.booCptFraccionado = false;

                if (!string.IsNullOrEmpty(oConceptos.cumCodigo.ToString()))
                    _vista.cmbCumCodigo.SelectedValue = oConceptos.cumCodigo;

                _vista.cmbTicCodigo.SelectedValue = oConceptos.ticCodigo;
                //-----------------------------null
                _vista.logCptCodigoBarra = oConceptos.cptCodigoBarra;
                _vista.strCptCodigoQr = oConceptos.cptCodigoQr;

                _vista.logCptCodigoPadre = oConceptos.cptCodigoPadre;                
                CargarConceptoPadre(oConceptos.cptCodigoPadre.ToString());

                _vista.intCptFraccionadoPor = oConceptos.cptFraccionadoPor;
                if (oConceptos.cptMedible == "S")
                    _vista.booCptMedible = true;
                else
                    _vista.booCptMedible = false;
                if (oConceptos.cptFabricado == "S")
                    _vista.booCptFabricado = true;
                else
                    _vista.booCptFabricado = false;
                _vista.decCptPeso = oConceptos.cptPeso;
                _vista.decCptAncho = oConceptos.cptAncho;
                _vista.decCptLargo = oConceptos.cptLargo;
                _vista.decCptProfundidad = oConceptos.cptProfundidad;
                _vista.decCptStockMinimo = oConceptos.cptStockMinimo;
                _vista.decCptStockMaximo = oConceptos.cptStockMaximo;
                _vista.decCptStockReposicion = oConceptos.cptStockReposicion;
                if (oConceptos.EstCodigo == "H")
                    _vista.booCptEstado = true;
                else
                    _vista.booCptEstado = false;
                //CONSULTA Y CARGA LA GRILLA TIPOS DE COMPROBANTES
                CargarGrillaTiposComprobantes();
                // oConceptos = oCtcBus.ConceptosGetById(_vista.logCptNumero);
            }
            else
                _vista.booCptEstado = true; ;
        }

        public void CargarGrillaTiposComprobantes()
        {
            ConceptosTiposComprobantesBus oCtcBus = new ConceptosTiposComprobantesBus();
            DataTable dt = oCtcBus.ConceptosTiposComprobantesGetByFilter(_vista.logCptNumero);
            _vista.strCantidad = "Se encontraron " + oUtil.CargarGrilla(_vista.grdCptTipoCmp, dt) + " registros";
            _vista.grdCptTipoCmp.Columns["cpt_numero"].Visible = false;
        }

        public long Guardar()
        {
            long logResultado;
            Conceptos oConceptos = new Conceptos();
            ConceptosBus oConceptosBus = new ConceptosBus();
            
            oConceptos.cptNumero = _vista.logCptNumero;
            oConceptos.cptCodigo = _vista.strCptCodigo;
            oConceptos.cptDescripcion = _vista.strCptDescripcion;
            oConceptos.cptDescripcionCorta = _vista.strCptDescripcionCorta;
            if (_vista.booCptControlaStock)
                oConceptos.cptControlaStock = "S";
            else
                oConceptos.cptControlaStock = "N";

            if (_vista.booCptFraccionado)
                oConceptos.cptFraccionado = "S";
            else
                oConceptos.cptFraccionado = "N";     
            
            oConceptos.ticCodigo = _vista.cmbTicCodigo.SelectedValue.ToString();
            
            if (int.Parse(_vista.cmbCumCodigo.SelectedValue.ToString()) > 0)
                oConceptos.cumCodigo = int.Parse(_vista.cmbCumCodigo.SelectedValue.ToString());

            oConceptos.cptCodigoBarra = _vista.logCptCodigoBarra;            
            oConceptos.cptCodigoQr = _vista.strCptCodigoQr;
            oConceptos.cptCodigoPadre = _vista.logCptCodigoPadre;
            oConceptos.cptFraccionadoPor = _vista.intCptFraccionadoPor;
            
            if (_vista.booCptMedible)
                oConceptos.cptMedible = "S";
            else
                oConceptos.cptMedible = "N";

            if (_vista.booCptFabricado)
                oConceptos.cptFabricado = "S";
            else
                oConceptos.cptFabricado = "N";
            
            oConceptos.cptPeso = _vista.decCptPeso;         
            oConceptos.cptAncho = _vista.decCptAncho;
            oConceptos.cptLargo = _vista.decCptLargo;
            oConceptos.cptProfundidad = _vista.decCptProfundidad;
            oConceptos.cptStockMinimo = _vista.decCptStockMinimo;
            oConceptos.cptStockMaximo = _vista.decCptStockMaximo;
            oConceptos.cptStockReposicion = _vista.decCptStockReposicion;

            if (_vista.booCptEstado)
                oConceptos.EstCodigo = "H";
            else
                oConceptos.EstCodigo = "I";

            if (_vista.logCptNumero == 0)
            {
                _vista.logCptNumero = oConceptosBus.ConceptosAdd(oConceptos);                
                return _vista.logCptNumero;
            }
            else
            {
                logResultado = (oConceptosBus.ConceptosUpdate(oConceptos)) ? oConceptos.cptNumero : 0;
                return logResultado;
            }
        }

        public bool EliminarConceptos(long idConcepto)
        {

            ConceptosBus oConceptosBus = new ConceptosBus();
            Conceptos oConceptos = oConceptosBus.ConceptosGetById(idConcepto);
            oConceptos.EstCodigo = "B";
            return oConceptosBus.ConceptosUpdate(oConceptos);
        }

        public void CargarConceptoPadre(string id)
        {
            Conceptos oCpt = new Conceptos();
            ConceptosBus oCptBus = new ConceptosBus();           
            oCpt = oCptBus.ConceptosGetById(long.Parse(id));          
            _vista.strCodPadreDescripcion = oCpt.cptCodigo + " - " + oCpt.cptDescripcion ;
            _vista.logCptCodigoPadre = long.Parse(id);
        }
        public void CargarTipoComprobante(string id)
        {
            long logResultado;
            ConceptosTiposComprobantes oCtc = new ConceptosTiposComprobantes();
            ConceptosTiposComprobantesBus oCtcBus = new ConceptosTiposComprobantesBus();           
            oCtc.cptNumero = _vista.logCptNumero;
            oCtc.tcoCodigo = id;
            logResultado = oCtcBus.ConceptosTiposComprobantesAdd(oCtc);
            CargarGrillaTiposComprobantes();

        }
        public void BorrarTipoComprobante(long concepto,string tipo)
        {
            Boolean logResultado;
            ConceptosTiposComprobantes oCtc = new ConceptosTiposComprobantes();
            ConceptosTiposComprobantesBus oCtcBus = new ConceptosTiposComprobantesBus();
            
            oCtc.cptNumero = concepto;
            oCtc.tcoCodigo = tipo;
            logResultado = oCtcBus.ConceptosTiposComprobantesDelete(oCtc);
            CargarGrillaTiposComprobantes();

        }
    }
}
