using Business;
using Model;
using Service;
using System.Windows.Forms;
using System;
using System.Data;
using System.IO;
using System.Collections.Generic;

namespace AppProcesos.gesConfiguracion.GruposImpuestosItemsCrud
{   
    public class UIGruposImpuestosItemsCrud
    {
        private IVistaGruposImpuestosItemsCrud _vista;
        Utility oUtil;

        public UIGruposImpuestosItemsCrud(IVistaGruposImpuestosItemsCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            ProvinciasBus oProvinciasBus = new ProvinciasBus();
            oUtil.CargarCombo(_vista.cmbPrsProvincia, oProvinciasBus.ProvinciasGetByFilter("ARG"), "PRV_CODIGO", "PRV_DESCRIPCION", "Seleccione Provincia");
            _vista.cmbPrsProvincia.SelectedValue = "NQ";            
            LocalidadesBus oLocalidadesBus = new LocalidadesBus();
            oUtil.CargarCombo(_vista.cmbPrsLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(_vista.cmbPrsProvincia.SelectedValue.ToString()), "LOC_NUMERO", "LOC_DESCRIPCION", "Seleccione Localidad");            
            GruposConceptosImpuestosBus oGciBus = new GruposConceptosImpuestosBus();
            oUtil.CargarCombo(_vista.cmbGciGrupo, oGciBus.GruposConceptosImpuestosGetAllDT(), "gci_codigo", "gci_descripcion", "Seleccione Grupo");            
            TiposIvaBus oTivBus = new TiposIvaBus();
            oUtil.CargarCombo(_vista.cmbTivCodigo, oTivBus.TiposIvaGetAllDT(), "tiv_codigo", "tiv_descripcion", "Seleccione un Tipo");            

            if (_vista.intGiiNumero != 0)
            {
                GruposImpuestosItems oGruposImpuestosItems = new GruposImpuestosItems();
                GruposImpuestosItemsBus oGruposImpuestosItemsBus = new GruposImpuestosItemsBus();

                oGruposImpuestosItems = oGruposImpuestosItemsBus.GruposImpuestosItemsGetById(_vista.intGiiNumero);
                _vista.cmbTivCodigo.SelectedValue = oGruposImpuestosItems.tivCodigo;                
                _vista.decGiiPorcentaje = oGruposImpuestosItems.giiPorcentaje;
                _vista.datGiiVigenciaDesde = oGruposImpuestosItems.giiVigenciaDesde;                
                _vista.datGiiVigenciaHasta = oGruposImpuestosItems.giiVigenciaHasta;
                _vista.decGiiImporteMinimo = oGruposImpuestosItems.giiImporteMinimo;
                _vista.decGiiImporteFijo = oGruposImpuestosItems.giiImporteFijo;
                _vista.decGiiImporteBaseMinimo = oGruposImpuestosItems.giiImporteBaseMinimo;

                _vista.logCptConcepto = oGruposImpuestosItems.cptNumero;
                if (!string.IsNullOrEmpty(oGruposImpuestosItems.cptNumero.ToString()))
                    CargarConcepto(oGruposImpuestosItems.cptNumero.ToString());

                if (!string.IsNullOrEmpty(oGruposImpuestosItems.locNumero.ToString()))
                {
                    Localidades oLocalidades = new Localidades();
                    oLocalidades = oLocalidadesBus.LocalidadesGetById(int.Parse(oGruposImpuestosItems.locNumero.ToString()));
                    _vista.cmbPrsProvincia.SelectedValue = oLocalidades.PrvCodigo;
                    oUtil.CargarCombo(_vista.cmbPrsLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(oLocalidades.PrvCodigo), "LOC_NUMERO", "LOC_DESCRIPCION", "Seleccione Localidad");
                    _vista.cmbPrsLocalidad.SelectedValue = oGruposImpuestosItems.locNumero;
                }
                _vista.logCptConcepto = oGruposImpuestosItems.cptNumero;
                _vista.cmbGciGrupo.SelectedValue = oGruposImpuestosItems.gciCodigo;
            }
           
        }

        public void CambioProvincia()
        {
            LocalidadesBus oLocalidadesBus = new LocalidadesBus();
            oUtil.CargarCombo(_vista.cmbPrsLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(_vista.cmbPrsProvincia.SelectedValue.ToString()), "LOC_NUMERO", "LOC_DESCRIPCION", "Seleccione Localidad");
        }

        public bool EliminarGruposImpuestosItems(int idGruposImpuestosItems)
        {
            GruposImpuestosItemsBus oGruposImpuestosItemsBus = new GruposImpuestosItemsBus();            
            return oGruposImpuestosItemsBus.GruposImpuestosItemsDelete(idGruposImpuestosItems);
        }

        public long Guardar()
        {
            long logResultado;
            GruposImpuestosItems oGruposImpuestosItems = new GruposImpuestosItems();
            GruposImpuestosItemsBus oGruposImpuestosItemsBus = new GruposImpuestosItemsBus();
            oGruposImpuestosItems.giiNumero = _vista.intGiiNumero;
            oGruposImpuestosItems.tivCodigo = _vista.cmbTivCodigo.SelectedValue.ToString();                        
            oGruposImpuestosItems.giiPorcentaje = _vista.decGiiPorcentaje;
            oGruposImpuestosItems.giiVigenciaDesde = _vista.datGiiVigenciaDesde;           
            oGruposImpuestosItems.giiVigenciaHasta = _vista.datGiiVigenciaHasta;            
            oGruposImpuestosItems.giiImporteMinimo = _vista.decGiiImporteMinimo;
            oGruposImpuestosItems.giiImporteFijo = _vista.decGiiImporteFijo;
            oGruposImpuestosItems.giiImporteBaseMinimo = _vista.decGiiImporteBaseMinimo;
            oGruposImpuestosItems.cptNumero = _vista.logCptConcepto;            
            oGruposImpuestosItems.gciCodigo = _vista.cmbGciGrupo.SelectedValue.ToString();

            if (int.Parse(_vista.cmbPrsLocalidad.SelectedValue.ToString()) > 0)
            {
                oGruposImpuestosItems.locNumero = int.Parse(_vista.cmbPrsLocalidad.SelectedValue.ToString());
                oGruposImpuestosItems.prvCodigo = _vista.cmbPrsProvincia.SelectedValue.ToString();
                oGruposImpuestosItems.paiCodigo = "ARG";
            }
                            
            if (_vista.intGiiNumero == 0)
            {
                logResultado = oGruposImpuestosItemsBus.GruposImpuestosItemsAdd(oGruposImpuestosItems);
                Console.WriteLine("El numero de grupo creado " + logResultado);
                return logResultado;
            }
            else
            {
                logResultado = (oGruposImpuestosItemsBus.GruposImpuestosItemsUpdate(oGruposImpuestosItems)) ? oGruposImpuestosItems.giiNumero : 0;
                return logResultado;
            }
        }
        public void CargarConcepto(string id)
        {
            Conceptos oCpt = new Conceptos();
            ConceptosBus oCptBus = new ConceptosBus();
            oCpt = oCptBus.ConceptosGetById(long.Parse(id));
            _vista.strCptDescripcion = oCpt.cptCodigo + " - " + oCpt.cptDescripcion;
            _vista.logCptConcepto = long.Parse(id);
        }
    }
}
