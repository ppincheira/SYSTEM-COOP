using Business;
using Model;
using Service;
using System.Windows.Forms;
using System;
using System.Data;
using System.IO;
using System.Collections.Generic;

namespace AppProcesos.gesConfiguracion.frmConceptosCrud
{
    public class UIConceptosCrud
    {
        private IVistaConceptosCrud _vista;
        Utility oUtil;
        //Declaracionde variable de tipos de grupos
        string strTgrRubro = "4";
        string strTgrLinea = "5";
        string strTgrClase = "6";
        string strTgrEstacionalidad = "7";
        List<ConceptosFabricados> ListaDelFabricados = new List<ConceptosFabricados>();
        List<ConceptosTiposComprobantes> ListaDelTipos = new List<ConceptosTiposComprobantes>();
        List<ConceptosServicios> ConceptosServicios = new List<ConceptosServicios>();
        //---------------------------------------------------

        public UIConceptosCrud(IVistaConceptosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }
        public void Inicializar()
        {       
            TiposConceptosBus oTicBus = new TiposConceptosBus();
            oUtil.CargarCombo(_vista.cmbTicCodigo, oTicBus.TiposConceptosGetByFilter(), "tic_codigo", "tic_descripcion", "Seleccione Tipo");

            ConceptosUnidadesMedidasBus oCumBus = new ConceptosUnidadesMedidasBus();
            oUtil.CargarCombo(_vista.cmbCumCodigo, oCumBus.ConceptosUnidadesMedidasGetByFilter(), "cum_codigo", "cum_descripcion", "Seleccione Unidad");

            GruposBus oGruposBus = new GruposBus();
            oUtil.CargarCombo(_vista.cmbCodRubro, oGruposBus.GruposGetByFilter(strTgrRubro), "grp_codigo", "grp_descripcion", "Seleccione el Rubro");
            
            oUtil.CargarCombo(_vista.cmbCodLinea, oGruposBus.GruposGetByFilter(strTgrLinea), "grp_codigo", "grp_descripcion", "Seleccione la Linea");

            oUtil.CargarCombo(_vista.cmbCodClase, oGruposBus.GruposGetByFilter(strTgrClase), "grp_codigo", "grp_descripcion", "Seleccione la Clase");

            oUtil.CargarCombo(_vista.cmbCodEstacionalidad, oGruposBus.GruposGetByFilter(strTgrEstacionalidad), "grp_codigo", "grp_descripcion", "Seleccione la Estacionalidad");
           
            Adjuntos oAdj = new Adjuntos();
            AdjuntosBus oAdjBus = new AdjuntosBus();
            oAdj = oAdjBus.AdjuntosGetByCodigoRegistro(_vista.logCptNumero, "CPT");
            _vista.adjunto = oAdj;
            //-------------------
            //CONSULTA Y CARGA LA GRILLA TIPOS DE COMPROBANTES
            CargarGrillaTiposComprobantes();
            CargarGrillaServicios();

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
                if (!string.IsNullOrEmpty(oConceptos.cptCodigoPadre.ToString()))
                    CargarConceptoPadre(oConceptos.cptCodigoPadre.ToString());

                if (!string.IsNullOrEmpty(oConceptos.cptCodigoRecargo.ToString()))
                    CargarConceptoRecargo(oConceptos.cptCodigoRecargo.ToString());

                if (!string.IsNullOrEmpty(oConceptos.cptCodigoBonificacion.ToString()))
                    CargarConceptoBonificacion(oConceptos.cptCodigoBonificacion.ToString());

                if (!string.IsNullOrEmpty(oConceptos.cptCodigoEnvase.ToString()))
                    CargarConceptoEnvase(oConceptos.cptCodigoEnvase.ToString());

                _vista.intCptFraccionadoPor = oConceptos.cptFraccionadoPor;
                if (oConceptos.cptMedible == "S")
                    _vista.booCptMedible = true;
                else
                    _vista.booCptMedible = false;

                if (oConceptos.cptFabricado == "S")
                    _vista.booCptFabricado = true;
                else
                    _vista.booCptFabricado = false;

                if (oConceptos.cptModificableDescripcion == "S")
                    _vista.booModificaCmpDes = true;
                else
                    _vista.booModificaCmpDes = false;

                if (oConceptos.cptModificableImporte == "S")
                    _vista.booModificaCmpImp = true;
                else
                    _vista.booModificaCmpImp = false;

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

                GruposDetalles oGrD = new GruposDetalles();
                GruposDetallesBus oGrDBus = new GruposDetallesBus();
                oGrD = oGrDBus.GruposDetallesGetByTipo(_vista.logCptNumero.ToString(), strTgrRubro);
                _vista.cmbCodRubro.SelectedValue = oGrD.GrpCodigo;

                oGrD = oGrDBus.GruposDetallesGetByTipo(_vista.logCptNumero.ToString(), strTgrLinea);
                _vista.cmbCodLinea.SelectedValue = oGrD.GrpCodigo;

                oGrD = oGrDBus.GruposDetallesGetByTipo(_vista.logCptNumero.ToString(), strTgrClase);
                _vista.cmbCodClase.SelectedValue = oGrD.GrpCodigo;

                oGrD = oGrDBus.GruposDetallesGetByTipo(_vista.logCptNumero.ToString(), strTgrEstacionalidad);
                _vista.cmbCodEstacionalidad.SelectedValue = oGrD.GrpCodigo;
                // carga la foto
                AdjuntosBus oAdjuntoBus = new AdjuntosBus();
                if (oAdjuntoBus.AdjuntoExisteByCodigoRegistro(_vista.logCptNumero, "CPT"))
                {
                   
                    DataTable dtb = oAdjBus.AdjuntoGetAdjuntoById(oAdj.AdjCodigo);                   
                    DataRow f = dtb.Rows[0];
                    byte[] bits = ((byte[])(f.ItemArray[0]));
                    string sFile = oAdj.AdjNombre;                   
                    FileStream fs = new FileStream(sFile, FileMode.Create);
                    fs.Write(bits, 0, Convert.ToInt32(bits.Length));                    
                    _vista.pbxImagenP.Image = new System.Drawing.Bitmap(fs);
                    fs.Close();                    
                }                  
                //----------------------

                if (oConceptos.cptFabricado == "S")
                {
                    CargarGrillaFabricados();
                }                
            }
            else
                _vista.booCptEstado = true; ;
        }

        public void CargarGrillaTiposComprobantes()
        {
            //--carga la grilla de tipos comprobantes
            //DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();
            //colBotones.Name = "selector";
            //colBotones.HeaderText = " ";
            //colBotones.Text = "Tipo Comprobante";
            //colBotones.UseColumnTextForButtonValue = true;
            //_vista.grdCptTipoCmp.Columns.Add(colBotones);

            ConceptosTiposComprobantesBus oCtcBus = new ConceptosTiposComprobantesBus();
            DataTable dt = oCtcBus.ConceptosTiposComprobantesGetByFilter(_vista.logCptNumero);
            _vista.strCantidadComprobantes = "Se encontraron " + oUtil.CargarGrilla(_vista.grdCptTipoCmp, dt) + " registros";
            //oculta la pk 
            _vista.grdCptTipoCmp.Columns[0].Visible = false;           
            _vista.grdCptTipoCmp.Columns[1].ReadOnly = true;            
            _vista.grdCptTipoCmp.Columns[2].ReadOnly = true;                    
        }

        public void CargarGrillaServicios()
        {
            ConceptosServiciosBus oCseBus = new ConceptosServiciosBus();
            DataTable dt = oCseBus.ConceptosServiciosGetByFilter(_vista.logCptNumero);
            _vista.strCantidadComprobantes = "Se encontraron " + oUtil.CargarGrilla(_vista.grdCptServicio, dt) + " registros";
            //oculta la pk 
            _vista.grdCptServicio.Columns[0].Visible = false;
            _vista.grdCptServicio.Columns[1].Visible = false;
            _vista.grdCptServicio.Columns[2].ReadOnly = true;
            _vista.grdCptServicio.Columns[3].ReadOnly = true;
            _vista.grdCptServicio.Columns[4].ReadOnly = true;
        }

        public void CargarGrillaFabricados()
        {
            //--carga la grilla de fabricado
            //DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();
            //colBotones.Name = "selector";
            //colBotones.HeaderText = " ";
            //colBotones.Text = "Concepto";
            //colBotones.UseColumnTextForButtonValue = true;
            //_vista.grdCptFabricado.Columns.Add(colBotones);

            ConceptosFabricadosBus oCompFabBus = new ConceptosFabricadosBus();
            DataTable dt = oCompFabBus.ConceptosFabricadosGetByFilter(_vista.logCptNumero);
            _vista.strCantidadComponentes = "Se encontraron " + oUtil.CargarGrilla(_vista.grdCptFabricado, dt) + " registros";
            //oculta la pk y fk
            _vista.grdCptFabricado.Columns[0].Visible = false;
            _vista.grdCptFabricado.Columns[1].Visible = false;
            _vista.grdCptFabricado.Columns[2].ReadOnly = true;
            _vista.grdCptFabricado.Columns[3].ReadOnly = true;
        }

        public long Guardar()
        {
            long logResultado;
            long logRtdo;
            bool booRest;
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

            if (_vista.booModificaCmpImp)
                oConceptos.cptModificableImporte = "S";
            else
                oConceptos.cptModificableImporte = "N";

            if (_vista.booModificaCmpDes)
                oConceptos.cptModificableDescripcion = "S";
            else
                oConceptos.cptModificableDescripcion = "N";

            oConceptos.cptCodigoRecargo = _vista.logCptCodigoRecargo;
            oConceptos.cptCodigoBonificacion = _vista.logCptCodigoBonificacion;
            oConceptos.cptCodigoEnvase = _vista.logCptCodigoEnvase;

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
                //--rubro
                if (_vista.cmbCodRubro.SelectedValue.ToString() != "0")
                {
                    GruposDetalles oGDe = new GruposDetalles();
                    GruposDetallesBus oGDeBus = new GruposDetallesBus();
                    oGDe.GrpCodigo = long.Parse(_vista.cmbCodRubro.SelectedValue.ToString());
                    oGDe.GrdCodigoRegistro = _vista.logCptNumero.ToString();
                    logRtdo = oGDeBus.GruposDetallesAdd(oGDe);
                }
                //--linea
                if (_vista.cmbCodLinea.SelectedValue.ToString() != "0")
                {
                    GruposDetalles oGDe = new GruposDetalles();
                    GruposDetallesBus oGDeBus = new GruposDetallesBus();
                    oGDe.GrpCodigo = long.Parse(_vista.cmbCodLinea.SelectedValue.ToString());
                    oGDe.GrdCodigoRegistro = _vista.logCptNumero.ToString();
                    logRtdo = oGDeBus.GruposDetallesAdd(oGDe);
                }
                //--clase
                if (_vista.cmbCodClase.SelectedValue.ToString() != "0")
                {
                    GruposDetalles oGDe = new GruposDetalles();
                    GruposDetallesBus oGDeBus = new GruposDetallesBus();
                    oGDe.GrpCodigo = long.Parse(_vista.cmbCodClase.SelectedValue.ToString());
                    oGDe.GrdCodigoRegistro = _vista.logCptNumero.ToString();
                    logRtdo = oGDeBus.GruposDetallesAdd(oGDe);
                }
                //--estacionalidad
                if (_vista.cmbCodEstacionalidad.SelectedValue.ToString() != "0")
                {
                    GruposDetalles oGDe = new GruposDetalles();
                    GruposDetallesBus oGDeBus = new GruposDetallesBus();
                    oGDe.GrpCodigo = long.Parse(_vista.cmbCodEstacionalidad.SelectedValue.ToString());
                    oGDe.GrdCodigoRegistro = _vista.logCptNumero.ToString();
                    logRtdo = oGDeBus.GruposDetallesAdd(oGDe);
                }

            }
            else
            {
                logResultado = (oConceptosBus.ConceptosUpdate(oConceptos)) ? oConceptos.cptNumero : 0;
                //-------------------
                GruposDetalles oGDe = new GruposDetalles();
                GruposDetallesBus oGDeBus = new GruposDetallesBus();
                //--rubro
                booRest = oGDeBus.GruposDetallesTipoDelete(_vista.logCptNumero.ToString(), strTgrRubro);
                if (_vista.cmbCodRubro.SelectedValue.ToString() != "0")
                {
                    oGDe.GrpCodigo = long.Parse(_vista.cmbCodRubro.SelectedValue.ToString());
                    oGDe.GrdCodigoRegistro = _vista.logCptNumero.ToString();
                    logRtdo = oGDeBus.GruposDetallesAdd(oGDe);
                }
                //--linea
                booRest = oGDeBus.GruposDetallesTipoDelete(_vista.logCptNumero.ToString(), strTgrLinea);
                if (_vista.cmbCodLinea.SelectedValue.ToString() != "0")
                {
                    oGDe.GrpCodigo = long.Parse(_vista.cmbCodLinea.SelectedValue.ToString());
                    oGDe.GrdCodigoRegistro = _vista.logCptNumero.ToString();
                    logRtdo = oGDeBus.GruposDetallesAdd(oGDe);
                }
                //--clase
                booRest = oGDeBus.GruposDetallesTipoDelete(_vista.logCptNumero.ToString(), strTgrClase);
                if (_vista.cmbCodClase.SelectedValue.ToString() != "0")
                {
                    oGDe.GrpCodigo = long.Parse(_vista.cmbCodClase.SelectedValue.ToString());
                    oGDe.GrdCodigoRegistro = _vista.logCptNumero.ToString();
                    logRtdo = oGDeBus.GruposDetallesAdd(oGDe);
                }
                //--estacionalidad
                booRest = oGDeBus.GruposDetallesTipoDelete(_vista.logCptNumero.ToString(), strTgrEstacionalidad);
                if (_vista.cmbCodEstacionalidad.SelectedValue.ToString() != "0")
                {
                    oGDe.GrpCodigo = long.Parse(_vista.cmbCodEstacionalidad.SelectedValue.ToString());
                    oGDe.GrdCodigoRegistro = _vista.logCptNumero.ToString();
                    logRtdo = oGDeBus.GruposDetallesAdd(oGDe);
                }

                //-------------------                
            }
            // guarda o actualiza imagen
            //if (_vista.adjuntoFileName != null)
            if (!string.IsNullOrEmpty(_vista.adjuntoFileName))
            {
                //Console.WriteLine("pasa para actualizar");
                if (_vista.adjunto.AdjNombre != "")
                {
                    _vista.adjunto.AdjCodigoRegistro = _vista.logCptNumero.ToString();
                    AdjuntosBus oAdjuntoBus = new AdjuntosBus();                    
                    if (oAdjuntoBus.AdjuntoExisteByCodigoRegistro(_vista.logCptNumero, "CPT"))
                    {                        
                        if (!string.IsNullOrEmpty(_vista.adjuntoFileName))
                        {                            
                            oAdjuntoBus.AdjuntoUpdate(_vista.adjunto);
                        }                        
                    }
                    else
                    {                       
                        oAdjuntoBus.AdjuntosAdd(_vista.adjunto);
                    }
                }
            }
            if (oConceptos.cptFabricado.Equals("S"))
            {
               // Console.WriteLine("sale4 guarda grilla de fabricados------------");
                ConceptosFabricados oCfb = new ConceptosFabricados();
                ConceptosFabricadosBus oCfbBus = new ConceptosFabricadosBus();
                //elimina  grilla de fabricado                      
                foreach (ConceptosFabricados oCof in ListaDelFabricados)
                {
                 //   Console.WriteLine("borro fabricado ------------");
                    oCfb.cfbCodigo = oCof.cfbCodigo;
                    oCfbBus.ConceptosFabricadosDelete(oCfb);
                }         
                // guarda o actualiza grilla de fabricado
                bool valido1;
                foreach (DataGridViewRow dr in _vista.grdCptFabricado.Rows)
                {
                    valido1 = false;
                    if (!dr.IsNewRow)
                    {
                        foreach (DataGridViewCell dc in dr.Cells)
                        {
                            if (dc.ColumnIndex == 0)
                            {
                                if (!string.IsNullOrEmpty(dc.Value.ToString()))
                                    oCfb.cfbCodigo = long.Parse(dc.Value.ToString());
                            }
                            if (dc.ColumnIndex == 1)
                            {
                                if (!string.IsNullOrEmpty(dc.Value.ToString()))
                                {
                                    oCfb.cptCodigoParte = long.Parse(dc.Value.ToString());
                                    valido1 = true;
                                }
                            }
                            if (dc.ColumnIndex == 4)
                            {
                                if (!string.IsNullOrEmpty(dc.Value.ToString()))
                                    oCfb.cfbCantidadParte = int.Parse(dc.Value.ToString());
                            }
                        }
                        ///actualizo o inserto el registro
                        if (valido1)
                        {
                            if (oCfb.cfbCodigo.ToString().Equals("0"))
                            {
                                oCfb.cptCodigoFabricado = _vista.logCptNumero;
                                // Console.WriteLine("dc.inserta ------------");
                                oCfbBus.ConceptosFabricadosAdd(oCfb);
                            }
                            else
                            {
                                oCfb.cptCodigoFabricado = _vista.logCptNumero;
                              //  Console.WriteLine("dc.actualiza------------");
                                oCfbBus.ConceptosFabricadosUpdate(oCfb);
                            }
                        }

                    }
                }
            }
            else
            {
                if (_vista.grdCptFabricado.Rows.Count > 0 || ListaDelFabricados.Count > 0)
                {
                    // borra todo lo relacionado al concepto
                    ConceptosFabricados oCfb = new ConceptosFabricados();
                    ConceptosFabricadosBus oCfbBus = new ConceptosFabricadosBus();
                    oCfb.cptCodigoFabricado = _vista.logCptNumero;
                    oCfbBus.ConceptosFabricadosDeleteAll(oCfb);
                }
            }
            /////////////////////////////////////////////////////////////////
           // Console.WriteLine("sale4 guarda tipos comprobantes  ------------");
            ConceptosTiposComprobantes oCtc = new ConceptosTiposComprobantes();
            ConceptosTiposComprobantesBus oCtcBus = new ConceptosTiposComprobantesBus();
            //elimina  grilla de tipos comprobantes                      
            foreach (ConceptosTiposComprobantes oCtcs in ListaDelTipos)
            {
                oCtc.cptNumero = oCtcs.cptNumero;
                oCtc.tcoCodigo = oCtcs.tcoCodigo;
                oCtcBus.ConceptosTiposComprobantesDelete(oCtc);
            }
            // guarda o actualiza tipos comprobantes 
            bool valido;
            foreach (DataGridViewRow dr in _vista.grdCptTipoCmp.Rows)
            {
                valido = false;
                if (!dr.IsNewRow) 
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.ColumnIndex == 1)
                        {
                              if (!string.IsNullOrEmpty(dc.Value.ToString()))
                              {
                                    oCtc.tcoCodigo = dc.Value.ToString();
                                    valido = true;
                              }                              
                        }                            
                        if (dc.ColumnIndex == 0)
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                                oCtc.cptNumero = long.Parse(dc.Value.ToString());
                        }
                            
                    }
                    ///actualizo o inserto el registro       
                    if (valido)
                    {
                        if (oCtc.cptNumero.ToString().Equals("0"))
                        {
                            oCtc.cptNumero = _vista.logCptNumero;
                            oCtcBus.ConceptosTiposComprobantesAdd(oCtc);
                        }
                    }                                     
                }

            }
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            Console.WriteLine("sale4 guarda conceptos servicios  ------------");
            ConceptosServicios oCse = new ConceptosServicios();
            ConceptosServiciosBus oCseBus = new ConceptosServiciosBus();
            //elimina  grilla de conceptos servicios                      
            foreach (ConceptosServicios oCtcs in ConceptosServicios)
            {
                oCse.cosCodigo = oCtcs.cosCodigo;                
                oCseBus.ConceptosServiciosDelete(oCse);
            }
            // guarda o actualiza conceptos servicios 
            bool valido2;
            foreach (DataGridViewRow dr in _vista.grdCptServicio.Rows)
            {
                valido2 = false;
                if (!dr.IsNewRow)
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.ColumnIndex == 2)
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                            {
                                oCse.srvCodigo = dc.Value.ToString();
                                Console.WriteLine("inserta  ------------"+ oCse.srvCodigo);
                                valido2 = true;
                            }
                        }
                        if (dc.ColumnIndex == 4)
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                            {
                                oCse.cosFechaCarga = Convert.ToDateTime(dc.Value.ToString());
                                Console.WriteLine("inserta  ------------" + oCse.cosFechaCarga);
                            }
                        }
                        if (dc.ColumnIndex == 1)
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                            {
                                oCse.cptNumero = long.Parse(dc.Value.ToString());
                                Console.WriteLine("inserta  ------------" + oCse.cptNumero);
                            }
                        }

                    }
                    ///actualizo o inserto el registro       
                    if (valido2)
                    {
                        if (oCse.cptNumero.ToString().Equals("0"))
                        {
                            Console.WriteLine("inserta  ------------");
                            oCse.cptNumero = _vista.logCptNumero;
                            oCseBus.ConceptosServiciosAdd(oCse);
                        }
                    }
                }

            }
            /////////////////////////////////////////////////////////////////
            return _vista.logCptNumero;
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

        public void CargarConceptoEnvase(string id)
        {
            Conceptos oCpt = new Conceptos();
            ConceptosBus oCptBus = new ConceptosBus();
            oCpt = oCptBus.ConceptosGetById(long.Parse(id));
            _vista.strCodEnvaseDescripcion = oCpt.cptCodigo + " - " + oCpt.cptDescripcion;
            _vista.logCptCodigoEnvase = long.Parse(id);
        }

        public void CargarConceptoBonificacion(string id)
        {
            Conceptos oCpt = new Conceptos();
            ConceptosBus oCptBus = new ConceptosBus();
            oCpt = oCptBus.ConceptosGetById(long.Parse(id));
            _vista.strCodBonificacionDescripcion = oCpt.cptCodigo + " - " + oCpt.cptDescripcion;
            _vista.logCptCodigoBonificacion = long.Parse(id);
        }

        public void CargarConceptoRecargo(string id)
        {
            Conceptos oCpt = new Conceptos();
            ConceptosBus oCptBus = new ConceptosBus();
            oCpt = oCptBus.ConceptosGetById(long.Parse(id));
            _vista.strCodRecargoDescripcion = oCpt.cptCodigo + " - " + oCpt.cptDescripcion;
            _vista.logCptCodigoRecargo = long.Parse(id);
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

        public void AgregarImagen()
        {                            
            _vista.adjunto = oUtil.Adjunto_Agregar(_vista.adjunto);            
            _vista.adjuntoFileName = _vista.adjunto.AdjNombre;
            _vista.pbxImagenP.Image = new System.Drawing.Bitmap(_vista.adjunto.AdjAdjunto);            
            _vista.adjunto.TabCodigo = "CPT";

        }        

        //public bool CargarConceptoFabricado(string idConcepto,int indice)
        public bool CargarConceptoFabricado(string idConcepto)
        {
            // valida la existencia en la tabla
            foreach (DataGridViewRow dr in _vista.grdCptFabricado.Rows)
            {
                if (!dr.IsNewRow)
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.ColumnIndex == 1)//
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                            {                               
                                if (dc.Value.ToString().Equals(idConcepto))
                                {                                   
                                    return false;
                                }
                                                                  
                            }
                        }
                    }
                }
            }
            
            Conceptos oCpt = new Conceptos();
            ConceptosBus oCptBus = new ConceptosBus();
            oCpt = oCptBus.ConceptosGetById(long.Parse(idConcepto));

            DataTable dt = (DataTable)_vista.grdCptFabricado.DataSource;
            DataRow row = dt.NewRow();
            row["pk"] = "0";
            row["fk"] = idConcepto;
            row["codigo"] = oCpt.cptCodigo;
            row["descripcion"] = oCpt.cptDescripcion;
            row["cantidad"] = DBNull.Value;
            dt.Rows.Add(row);
            
            _vista.grdCptFabricado.DataSource = dt;                       

            //_vista.grdCptFabricado.Rows[indice].Cells["pk"].Value = "0";
            //_vista.grdCptFabricado.Rows[indice].Cells["fk"].Value= idConcepto;
            //_vista.grdCptFabricado.Rows[indice].Cells["Codigo"].Value = oCpt.cptCodigo;
            //_vista.grdCptFabricado.Rows[indice].Cells["Descripcion"].Value = oCpt.cptDescripcion;
            _vista.grdCptFabricado.CurrentCell = _vista.grdCptFabricado.Rows[_vista.grdCptFabricado.RowCount-1].Cells["Cantidad"];
            _vista.grdCptFabricado.BeginEdit(true); //ABRIR LA EDICION DE LA CELDA
            return true;
        }

        public void EliminarConceptoFabricado(long idConcepto)
        {
            if (idConcepto > 0)
            {
                ConceptosFabricados oCof = new ConceptosFabricados();
                oCof.cfbCodigo = idConcepto;
                ListaDelFabricados.Add(oCof);
            }
            DataTable dt = (DataTable)_vista.grdCptFabricado.DataSource;
            dt.Rows.RemoveAt(_vista.grdCptFabricado.CurrentRow.Index);
            _vista.grdCptFabricado.DataSource = dt;
        }

        public bool CargarServicio(string idServicio)
        {
            // valida la existencia en la tabla
            foreach (DataGridViewRow dr in _vista.grdCptServicio.Rows)
            {
                if (!dr.IsNewRow)
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.ColumnIndex == 2)//
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                            {
                                if (dc.Value.ToString().Equals(idServicio))
                                {
                                    return false;
                                }

                            }
                        }
                    }
                }
            }

            Servicios oSer = new Servicios();
            ServiciosBus oSerBus = new ServiciosBus();
            oSer = oSerBus.ServiciosGetById(idServicio);

            DataTable dt = (DataTable)_vista.grdCptServicio.DataSource;
            DataRow row = dt.NewRow();
            row["pk"] = "0";
            row["fk"] = "0";
            row["codigo"] = idServicio;
            row["descripcion"] = oSer.SrvDescripcion;
            row["fecha"] = DateTime.Now.ToString("dd/MM/yyyy");
            dt.Rows.Add(row);
            _vista.grdCptServicio.DataSource = dt;            
            return true;
        }

        public void EliminarServicio(long idConServicio)
        {
            if (idConServicio > 0)
            {
                ConceptosServicios oCse = new ConceptosServicios();
                oCse.cosCodigo = idConServicio;
                ConceptosServicios.Add(oCse);
            }
            DataTable dt = (DataTable)_vista.grdCptServicio.DataSource;
            dt.Rows.RemoveAt(_vista.grdCptServicio.CurrentRow.Index);
            _vista.grdCptServicio.DataSource = dt;
        }

        //public bool CargarTipoComprobante(string idTipo, int indice)
        public bool CargarTipoComprobante(string idTipo)
        {
            // valida la existencia en la tabla
            foreach (DataGridViewRow dr in _vista.grdCptTipoCmp.Rows)
            {
                if (!dr.IsNewRow)
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.ColumnIndex == 1)//
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                            {
                                //Console.WriteLine("idTipo------------" + idTipo);
                                //Console.WriteLine("dc------------" + dc.Value.ToString());
                                if (dc.Value.ToString().Equals(idTipo))
                                    return false;
                                //Console.WriteLine("dc------------" + dc.Value.ToString());
                            }
                        }
                    }
                }
            }
            TiposComprobante oTco = new TiposComprobante();
            TiposComprobanteBus oTcoBus = new TiposComprobanteBus();
            oTco = oTcoBus.TiposComprobanteGetById(idTipo);

            DataTable dt = (DataTable)_vista.grdCptTipoCmp.DataSource;
            DataRow row = dt.NewRow();
            row["numero"] = "0";
            row["codigo"] = idTipo;
            row["descripcion"] = oTco.tcoDescripcion;
            dt.Rows.Add(row);
            _vista.grdCptTipoCmp.DataSource = dt;
            return true;
        }

        public void EliminarTipoComprobante(string idTipo, long idCptnumero)
        {
            if (idCptnumero > 0)
            {
                ConceptosTiposComprobantes oCtc = new ConceptosTiposComprobantes();
                oCtc.cptNumero = idCptnumero;
                oCtc.tcoCodigo = idTipo;
                ListaDelTipos.Add(oCtc);
            }
        
            DataTable dt = (DataTable)_vista.grdCptTipoCmp.DataSource;
            dt.Rows.RemoveAt(_vista.grdCptTipoCmp.CurrentRow.Index);
            _vista.grdCptTipoCmp.DataSource = dt;
        }

        public bool ValidarGrillaFabricado()
        {
            bool cantidad = false;
            bool concepto = false;
            foreach (DataGridViewRow dr in _vista.grdCptFabricado.Rows)
            {
                cantidad = false;
                concepto = false;
                if (!dr.IsNewRow)
                {
                   // Console.WriteLine("dc1-----zzzz");
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.ColumnIndex == 4)//cantidad
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                            {
                                cantidad = true;
                               // Console.WriteLine("cantidad------------" + dc.Value.ToString());
                            }
                        }
                        if (dc.ColumnIndex == 2)//concepto
                        {
                            if (!string.IsNullOrEmpty(dc.Value.ToString()))
                            {
                                concepto = true;
                               // Console.WriteLine("conepto------------" + dc.Value.ToString());
                            }
                        }
                    }                    
                }
                //valido el registro
                if(concepto && !cantidad)
                {                 
                    return false;
                }
            }
            return true;
        }
    }
}
