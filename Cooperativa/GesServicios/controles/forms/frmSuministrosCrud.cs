using AppProcesos.gesServicios.frmSuministrosCrud;
using Controles.datos;
using Controles.form;
using Model;
using Service;
using System;
using System.Windows.Forms;
using FormsAuxiliares;
using Business;

namespace GesServicios.controles.forms
{
    public partial class frmSuministrosCrud : gesForm, IVistaSuministrosCrud
    {
        #region << PROPIEDADES >>

        UISuministrosCrud _oSuministrosCrud;
        Utility oUtil;

        long _SumNumero, _MedNumero, _DomNumero, _CodigoObservacion, _MedAntNumero, _DomAntNumero;
        string _EstCodigo;

        #endregion
        #region Implementation of IVistaSuministrosCrud


        public long Numero
        {
            get { return _SumNumero; }
            set { _SumNumero = value; }
        }
        public cmbLista Servicio
        {
            get { return this.cmbServicio; }
            set { this.cmbServicio = value; }
        }

        public cmbLista TipoConexion
        {
            get { return this.cmbTipoConexion; }
            set { this.cmbTipoConexion = value; }
        }

        public cmbLista Categoria
        {
            get { return cmbCategoria; }
            set { cmbCategoria = value; }
        }

        public long? OrdenRuta
        {
            get { return string.IsNullOrEmpty(txtOrdenRuta.Text) ? 0 :  long.Parse(txtOrdenRuta.Text); }
            set { txtOrdenRuta.Text = value.ToString(); }
        }

        public long EmpNumero
        {
            get { return long.Parse(txtEmpNumero.Text); }
            set { txtEmpNumero.Text = value.ToString(); }
        }

        public DateTime FechaAlta
        {
            get { return DateTime.Parse(dtpFechaAlta.Text); }
            set { dtpFechaAlta.Text = value.ToString(); }
        }

        public cmbLista EstCodigo
        {
            get { return cmbEstado; }
            set { this.cmbEstado = value; }
        }

        public float? ConsumoEstimado
        {
            get { return this.txtConsumoEstimado.Text != "" ? float.Parse(this.txtConsumoEstimado.Text) : 0; }
            set { this.txtConsumoEstimado.Text = value.ToString(); }
        }

        public long? Voltaje
        {
            get { return string.IsNullOrEmpty(txtVoltaje.Text) ? 0 : long.Parse(txtVoltaje.Text); }
            set { this.txtVoltaje.Text = value.ToString(); }
        }
        public string Conexion
        {
            get { return this.chkConexion.Checked ? "S" : "N"; }
            set { this.chkConexion.Checked = (value == "S"); }
        }

        public double? PotenciaL1
        {
            get { return txtPotenciaL1.Text != "" ? double.Parse(txtPotenciaL1.Text) : 0; }
            set { txtPotenciaL1.Text = value.ToString(); }
        }

        public double? PotenciaL2
        {
            get { return txtPotenciaL2.Text != "" ? double.Parse(txtPotenciaL2.Text) : 0; }
            set { txtPotenciaL2.Text = value.ToString(); }
        }

        public double? PotenciaL3
        {
            get { return txtPotenciaL3.Text != "" ? double.Parse(txtPotenciaL3.Text) : 0; }
            set { txtPotenciaL3.Text = value.ToString(); }
        }

        public string PermiteCorte
        {
            get { return this.chkPermiteCorte.Checked ? "S" : "N"; }
            set { this.chkPermiteCorte.Checked = (value == "S"); }
        }

        public string Medido
        {
            get { return this.chkMedido.Checked ? "S" : "N"; }
            set { this.chkMedido.Checked = (value == "S"); }
        }

        public cmbLista Ruta
        {
            get { return cmbRuta; }
            set { cmbRuta = value; }
        }

        public cmbLista Zona
        {
            get { return cmbZona; }
            set { cmbZona = value; }
        }

        public string PermiteFactura
        {
            get { return this.chkPermiteFacturacion.Checked ? "S" : "N"; }
            set { this.chkPermiteFacturacion.Checked = (value == "S"); }
        }

        public DateTime FechaCarga
        {
            get { return dtpFechaCarga.Value; }
            set { dtpFechaCarga.Value = value; }
        }
        public string strRazonSocial
        {
            get { return this.txtEmpRazonSocial.Text; }
            set { this.txtEmpRazonSocial.Text=value; }
        }
        public string strDomicilioEmpresa
        {
            get { return this.txtDomicilioEmpresa.Text; }
            set { this.txtDomicilioEmpresa.Text=value; }
        }
        public string strRespIva
        {
            get { return this.txtRespIva.Text; }
            set { this.txtRespIva.Text=value; }
        }
         public string strTipoDoc
        {
            get { return this.txtTipoDoc.Text; }
            set { this.txtTipoDoc.Text=value; }
        }
        public string strEmpDocumentoNumero
        {
            get { return this.txtEmpDocumentoNumero.Text; }
            set { this.txtEmpDocumentoNumero.Text=value; }
        }
        public long numSocio
        {
            get { return long.Parse(txtSocio.Text); }
            set { txtSocio.Text = value.ToString(); }
        }
        public long numMedidor
        {
            get { return _MedNumero; }
            set { _MedNumero = value; }
        }
        public long numSerieMedidor
        {
            get { return long.Parse(txtMedNumeroSerie.Text); }
            set { txtMedNumeroSerie.Text = value.ToString(); }
        }
        public string strModeloMedidor
        {
            get { return this.txtMedidorModelo.Text; }
            set { this.txtMedidorModelo.Text=value; }
        }
         public string strTipoMedidor
        {
            get { return this.txtTipoMedidor.Text; }
            set { this.txtTipoMedidor.Text=value; }
        }
        public string strFabricante
        {
            get { return this.txtFabricanteMedidor.Text; }
            set { this.txtFabricanteMedidor.Text=value; }
        }
        public string strLecturaModo
        {
            get { return this.txtLecturaModoMedidor.Text; }
            set { this.txtLecturaModoMedidor.Text=value; }
        }
        public long numDomicilio
        {
            get { return long.Parse(txtDomCodigo.Text); }
            set { txtDomCodigo.Text = value.ToString(); }
        }
        public double? Registrador
        {
            get { return txtRegistrador.Text != "" ? double.Parse(txtRegistrador.Text) : 0; }
            set { txtRegistrador.Text = value.ToString(); }
        }
        public string strProvLoc
        {
            get { return this.txtProvLoc.Text; }
            set { this.txtProvLoc.Text=value; }
        }
        public string strBarrio
        {
            get { return this.txtBarrio.Text; }
            set { this.txtBarrio.Text=value; }
        }
        public string strCalle
        {
            get { return this.txtCalle.Text; }
            set { this.txtCalle.Text=value; }
        }
        public string strCalleNumero
        {
            get { return this.txtCalleNumero.Text; }
            set { this.txtCalleNumero.Text=value; }
        }
        public string strBloque
        {
            get { return this.txtBloque.Text; }
            set { this.txtBloque.Text=value; }
        }
        public string strPiso
        {
            get { return this.txtPiso.Text; }
            set { this.txtPiso.Text=value; }
        }
        public string strDepartamento
        {
            get { return this.txtDepartamento.Text; }
            set { this.txtDepartamento.Text=value; }
        }
        public grdGrillaAdmin grdSumConceptos
        {
            get { return grdSuministrosConceptos; }
            set { grdSuministrosConceptos = value; }
        }
        public cmbLista EstMedidorActual
        {
            get { return cmbEstadoMedidor; }
            set { this.cmbEstadoMedidor = value; }
        }
        public grdGrillaAdmin grdSumMedidores
        {
            get { return grdMedidores; }
            set { grdMedidores = value; }
        }

        public long numCodigoObservacion
        {
            get { return _CodigoObservacion; }
            set { _CodigoObservacion = value; }
        }
        public string strObservacion
        {
            get { return this.txtObservaciones.Text; }
            set { this.txtObservaciones.Text = value; }
        }
        public grdGrillaAdmin grdSumObservaciones
        { 
            get { return grdSuministrosObservaciones; }
            set { grdSuministrosObservaciones = value; }
        }
        public long numMedidorAnterior
        {
            get { return _MedAntNumero; }
            set { _MedAntNumero = value; }
        }
        public long numDomicilioAnterior
        {
            get { return _DomAntNumero; }
            set { _DomAntNumero = value; }
        }

        #endregion
        public frmSuministrosCrud(long Suministro, string Estado)
        {
            _SumNumero = Suministro;
            _EstCodigo = Estado;
            //_usrNumero = Usuario;
            _oSuministrosCrud = new UISuministrosCrud(this);
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!gbDatos.Enabled)
            {
                Close();
            }
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormularioEP(this, this, 40);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oSuministrosCrud.Guardar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }

        private void frmSuministrosCrud_Load(object sender, EventArgs e)
        {
            //Debo cargar primero el servicio que voy a dar, luego el cliente
            //y luego el domicilio asociado a ese suministro. 
            //El domicilio en un principio se muestrn los asociados a ese cliente 
            //pero con la opcion de poder agregar uno nuevo
            {
                try
                {
                    oUtil = new Utility();
                    _oSuministrosCrud.Inicializar();
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    ManejarError Err = new ManejarError();
                    Err.CargarError(ex,
                                    e.ToString(),
                                    ((Control)sender).Name,
                                    this.FindForm().Name);
                }

            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("100047", "100048", "100049", "0", "0", "100050");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "CLIE";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            oAdmin.FiltroCampos = "e.emp_cliente&e.est_codigo_cli&";
            oAdmin.FiltroOperador = "1&1&";
            oAdmin.FiltroValores = "S&H&";
            frmFormAdmin frmbus = new frmFormAdmin(oAdmin, oPermiso);
            if (frmbus.ShowDialog() == DialogResult.OK)
            {
                string id = frmbus.striRdoCodigo;

                _oSuministrosCrud.CargarCliente(long.Parse(id));
            }
        }

        private void btnMedidor_Click(object sender, EventArgs e)
        {
            Medidores oMedidor = new Medidores();
            MedidoresBus oMedidoresBus = new MedidoresBus();
            oMedidor = oMedidoresBus.MedidoresGetById(_MedNumero);
            if (oMedidor.EstCodigo == EstMedidorActual.SelectedValue && _SumNumero!=0)
                MessageBox.Show("Debe cambiar el estado del medidor antes de asignar otro al suministro","", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10121", "10122", "10123", "0", "0", "10124");
                Admin oAdmin = new Admin();
                oAdmin.TabCodigo = "MED";
                oAdmin.Tipo = Admin.enumTipoForm.Selector;
                oAdmin.CodigoRegistro = _SumNumero.ToString();
                oAdmin.CodigoEditar = _MedNumero.ToString();
                oAdmin.TabCodigoRegistro = "SUM";
                oAdmin.FiltroCampos = "TCS_DESCRIPCION&M.EST_CODIGO&";
                oAdmin.FiltroOperador = "1&1&";
                oAdmin.FiltroValores = cmbTipoConexion.Text + "&D&";
                oAdmin.TabCodigo = "MED";
                oAdmin.Tipo = Admin.enumTipoForm.Selector;
                frmFormAdmin frmbus = new frmFormAdmin(oAdmin, oPermiso);
                if (frmbus.ShowDialog() == DialogResult.OK)
                {
                    string medidor = frmbus.striRdoCodigo;

                    _oSuministrosCrud.CargarMedidor(long.Parse(medidor));
                }

            }

        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("31", "32", "33", "0", "0", "34");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "DOMB";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            oAdmin.CodigoRegistro = txtEmpNumero.Text;
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "DE.DEN_CODIGO_REGISTRO&";
            oAdmin.FiltroOperador = "1&";
            oAdmin.FiltroValores = txtEmpNumero.Text + "&";
            FormsAuxiliares.frmFormAdmin oFrmAdminMini = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            if (oFrmAdminMini.ShowDialog() == DialogResult.OK)
            {
                string id = oFrmAdminMini.striRdoCodigo;
                _oSuministrosCrud.CargarDomicilioSum(long.Parse(id));
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }

        private void cmbServicio_Leave(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedIndex == 0)
            {
                cmbServicio.Focus();
                cmbTipoConexion.Enabled = false;
            }
            else
            {
                cmbTipoConexion.Enabled = true;
                Servicios oSer = new Servicios();
                ServiciosBus oSerBus = new ServiciosBus();
                oSer = oSerBus.ServiciosGetById(cmbServicio.SelectedValue.ToString());
                if (oSer.SrvRequiereMedidor == "S")
                {
                    chkMedido.Checked = true;
                    tabSumnistros.TabPages[0].Enabled = true;
                }
                else
                {
                    chkMedido.Checked = false;
                    tabSumnistros.TabPages[0].Enabled = false;
                }
                _oSuministrosCrud.CargarCategorias();
                _oSuministrosCrud.CargarTiposConexiones();
            }
        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZona.SelectedIndex > 0)
            {
                _oSuministrosCrud.CargarRutas();
                cmbRuta.Enabled = cmbRuta.Items.Count > 1;
            }
            else
                cmbRuta.Enabled = false;

        }

        private void btnNuevo1_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    long logResultado;
            //    this.VALIDARFORM = true;
            //    oUtility.ValidarFormularioEP(this, this, 7);
            //    if (this.VALIDARFORM && _logCptNumero <= 0)
            //    {
            //        Cursor.Current = Cursors.WaitCursor;
            //        logResultado = _oConceptosCrud.Guardar();
            //        Cursor.Current = Cursors.Default;
            //    }

            //    if (_logCptNumero > 0)
            //    {
            //        //FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla("TCO", "TCO_CODIGO", false);
            //        //frmbus.ShowDialog();

            //        FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
            //        Admin oAdmin = new Admin();
            //        oAdmin.TabCodigo = "TCO";
            //        oAdmin.Tipo = Admin.enumTipoForm.Selector;
            //        FormsAuxiliares.frmFormAdminMini frmTcmp = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            //        if (frmTcmp.ShowDialog() == DialogResult.OK)
            //        {
            //            string strCodTcmp = frmTcmp.striRdoCodigo;
            //            Console.WriteLine("--tipocomprobante  -" + strCodTcmp);
            //            _oConceptosCrud.CargarTipoComprobante(strCodTcmp);
            //        }
            //    }


            //}
            //catch (Exception ex)
            //{
            //    Cursor.Current = Cursors.Default;
            //    ManejarError Err = new ManejarError();
            //    Err.CargarError(ex,
            //                    e.ToString(),
            //                    ((Control)sender).Name,
            //                    this.FindForm().Name);
            //}

        }

        private void grdGrillaAdmin1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaObs_Click(object sender, EventArgs e)
        {
            NuevaObservacion();

        }

        private void cmbTipoConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoConexion.SelectedIndex > 0)
                btnMedidor.Enabled = true;
            else
                btnMedidor.Enabled = false;
        }

        private void cmbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtOrdenRuta.Enabled=true;
        }
        private void NuevaObservacion()
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            AdminObs oAdmin = new AdminObs();
            oAdmin.TabCodigo = "SUM";
            if (this.numCodigoObservacion == 0)
                oAdmin.Tipo = AdminObs.enumTipoForm.FiltroAndAlta;
            else
                oAdmin.Tipo = AdminObs.enumTipoForm.Filtro;

            oAdmin.CodigoRegistro = _SumNumero.ToString();
            oAdmin.TabCodigoRegistro = "SUM";
            oAdmin.FiltroCampos = "OBS_CODIGO_REGISTRO&";
            oAdmin.FiltroValores = _SumNumero.ToString() + "&";
            oAdmin.TobCodigo = 2;
            FormsAuxiliares.frmObservacionesAdmin frmobs = new FormsAuxiliares.frmObservacionesAdmin(oAdmin, oPermiso);
            if (frmobs.ShowDialog() == DialogResult.OK)
            {
                string id = frmobs._strRdoCodigo;
                _oSuministrosCrud.CargarObservaciones(_SumNumero, "SUM");

            }
    }

    }

}
