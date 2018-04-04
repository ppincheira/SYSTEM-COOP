using System;
using System.Windows.Forms;
using Controles.form;
using AppProcesos.gesConfiguracion.frmConceptosCrud;
using Service;
using Controles.datos;
using Model;


namespace GesConfiguracion.controles.forms
{
    public partial class frmConceptosCrud : gesForm ,IVistaConceptosCrud
    {
        #region << PROPIEDADES >>
        UIConceptosCrud _oConceptosCrud;
        Utility oUtility;
        long _logCptNumero;
        long? _logCptCodigoPadre;
        string _strAccion;
        #endregion

        #region Implementation of IVistaConceptosCrud

        public long logCptNumero
        {
            get { return _logCptNumero; }
            set { _logCptNumero = value; }
        }

        public grdGrillaAdmin grdCptTipoCmp
        {
            get { return this.grdTiposComprobantes; }
            set { this.grdTiposComprobantes = value; }
        }

        public string strCptCodigo
        {
            get { return this.txtCodigo.Text; }
            set { this.txtCodigo.Text = value; }
        }

        public string strCantidad
        {
            get { return this.lblCantidad.Text; }
            set { this.lblCantidad.Text = value; }
        }

        public string strCptDescripcion
        {
            get { return this.txtDescripcion.Text; }
            set { this.txtDescripcion.Text = value; }
        }

        public string strCptDescripcionCorta
        {
            get { return this.txtDescripcionCorta.Text; }
            set { this.txtDescripcionCorta.Text = value; }
        }

        public Boolean booCptControlaStock
        {
            get { return this.chkControlaStock.Checked; }
            set { this.chkControlaStock.Checked = value; }
        }

        public Boolean booCptFraccionado
        {
            get { return this.chkFraccionado.Checked; }
            set { this.chkFraccionado.Checked = value; }
        }

        public cmbLista cmbCumCodigo
        {
            get { return this.cmbUnidadMedida; }
            set { this.cmbUnidadMedida = value; }
        }      

        public long? logCptCodigoBarra
        {            
            get { return string.IsNullOrEmpty(this.txtCodigoBarra.Text) ? null : (long?)Convert.ToInt64(this.txtCodigoBarra.Text); }
            set { this.txtCodigoBarra.Text = value.ToString(); }
        }

        public string strCptCodigoQr
        {           
            get { return this.txtCodigoQr.Text; }
            set { this.txtCodigoQr.Text = value; }
        }

        public long? logCptCodigoPadre
        {   
            get { return _logCptCodigoPadre; }
            set { _logCptCodigoPadre = value; }
        }

        public string strCodPadreDescripcion
        {
            get { return this.txtCodigoPadre.Text; }
            set { this.txtCodigoPadre.Text = value; }
        }

        public int? intCptFraccionadoPor
        {         
            get { return string.IsNullOrEmpty(this.txtFraccionaPor.Text) ? null : (int?)Convert.ToInt16(this.txtFraccionaPor.Text); }
            set { this.txtFraccionaPor.Text = value.ToString(); }
        }

        public Boolean booCptMedible
        {
            get { return this.chkMedible.Checked; }
            set { this.chkMedible.Checked = value; }
        }

        public Boolean booCptFabricado
        {
            get { return this.chkFabricado.Checked; }
            set { this.chkFabricado.Checked = value; }
        }

        public decimal? decCptPeso
        {
            get { return string.IsNullOrEmpty(this.txtPeso.Text) ? null : (decimal?)Convert.ToDecimal(this.txtPeso.Text); }
            set { this.txtPeso.Text = value.ToString(); }
        }

        public decimal? decCptAncho
        {
            get { return string.IsNullOrEmpty(this.txtAncho.Text) ? null : (decimal?)Convert.ToDecimal(this.txtAncho.Text); }
            set { this.txtAncho.Text = value.ToString(); }
        }

        public decimal? decCptLargo
        {
            get { return string.IsNullOrEmpty(this.txtLargo.Text) ? null : (decimal?)Convert.ToDecimal(this.txtLargo.Text); }
            set { this.txtLargo.Text = value.ToString(); }
        }

        public decimal? decCptProfundidad
        {
            get { return string.IsNullOrEmpty(this.txtProfundidad.Text) ? null : (decimal?)Convert.ToDecimal(this.txtProfundidad.Text); }
            set { this.txtProfundidad.Text = value.ToString(); }
        }

        public decimal? decCptStockMinimo
        {
            get { return string.IsNullOrEmpty(this.txtStockMin.Text) ? null : (decimal?)Convert.ToDecimal(this.txtStockMin.Text); }
            set { this.txtStockMin.Text = value.ToString(); }
        }

        public decimal? decCptStockMaximo
        {
            get { return string.IsNullOrEmpty(this.txtStockMax.Text) ? null : (decimal?)Convert.ToDecimal(this.txtStockMax.Text); }
            set { this.txtStockMax.Text = value.ToString(); }
        }

        public decimal? decCptStockReposicion
        {
            get { return string.IsNullOrEmpty(this.txtStockReposicion.Text) ? null : (decimal?)Convert.ToDecimal(this.txtStockReposicion.Text); }
            set { this.txtStockReposicion.Text = value.ToString(); }
        }

        public cmbLista cmbTicCodigo
        {
            get { return this.cmbTipo; }
            set { this.cmbTipo = value; }
        }       

        public Boolean booCptEstado
        {
            get { return this.chkHabilitado.Checked; }
            set { this.chkHabilitado.Checked = value; }
        }
        #endregion

        #region << EVENTOS >>

        public frmConceptosCrud(long Codigo, string Accion)
        {
            try
            {
                InitializeComponent();

                _oConceptosCrud = new UIConceptosCrud(this);
                _logCptNumero = Codigo;
                _strAccion = Accion;
                if (_strAccion == "B")
                    if (MessageBox.Show("Desea eliminar El Concepto Código: " + Codigo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _oConceptosCrud.EliminarConceptos(_logCptNumero);
                        Cursor.Current = Cursors.Default;
                        this.Close();
                    }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "frmConceptosCrud",
                                "frmConceptosCrud",
                                this.FindForm().Name);
            }
        }
        private void frmConceptosCrud_Load(object sender, EventArgs e)
        {
            try
            {
                _oConceptosCrud.Inicializar();
                oUtility = new Utility();

                this.tttEtiqueta.SetToolTip(this.txtCodigo, "Codigo del Concepto");
                this.tttEtiqueta.SetToolTip(this.txtDescripcion, "Descripcion del Concepto");
                this.tttEtiqueta.SetToolTip(this.txtDescripcionCorta, "Descripcion corta del Concepto");
                this.tttEtiqueta.SetToolTip(this.cmbTipo, "Tipo de Concepto");
                this.tttEtiqueta.SetToolTip(this.txtCodigoPadre, "Codigo de origen del Concepto");
                this.tttEtiqueta.SetToolTip(this.chkHabilitado, "Indica si esta habilitado el Concepto ");
                this.tttEtiqueta.SetToolTip(this.btnTiposComprobantesA, "Carga Tipos de Comprobantes relacionados con el Concepto");
                this.tttEtiqueta.SetToolTip(this.txtCodigoBarra, "Codigo de Barras");
                this.tttEtiqueta.SetToolTip(this.txtCodigoQr, "Codigo Qr");
                this.tttEtiqueta.SetToolTip(this.chkMedible, "Indica si es Medible");
                this.tttEtiqueta.SetToolTip(this.chkFabricado, "Indica si es Fabricado");
                this.tttEtiqueta.SetToolTip(this.cmbUnidadMedida, "Unidad de Medida");
                this.tttEtiqueta.SetToolTip(this.txtPeso, "Peso");
                this.tttEtiqueta.SetToolTip(this.txtAncho, "Ancho");
                this.tttEtiqueta.SetToolTip(this.txtLargo, "Largo");
                this.tttEtiqueta.SetToolTip(this.txtProfundidad, "Profundidad");
                this.tttEtiqueta.SetToolTip(this.chkControlaStock, "Indica si controla Stock");
                this.tttEtiqueta.SetToolTip(this.txtStockMin, "Stock Minimo");
                this.tttEtiqueta.SetToolTip(this.txtStockMax, "Stock Maximo");
                this.tttEtiqueta.SetToolTip(this.txtStockReposicion, "Stock de Reposicion");
                this.tttEtiqueta.SetToolTip(this.chkFraccionado, "Indica si es Fraccionado");
                this.tttEtiqueta.SetToolTip(this.txtFraccionaPor, "Indicar por que cantidad es fraccionado");
                this.tttEtiqueta.SetToolTip(this.btnConceptoPadre, "Carga el Concepto relacionado");                
                if (_strAccion == "V")
                {
                    this.gpbDetalle.Enabled = false;
                    this.btnAceptar.Enabled = false;       
                    this.tabPagControl.Enabled = false;
                    this.tabPagEspecificaciones.Enabled = false;
                    this.btnTiposComprobantesB.Enabled = false;
                    this.btnTiposComprobantesA.Enabled = false;
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                long logResultado;
                this.VALIDARFORM = true;
                oUtility.ValidarFormularioEP(this, this, 7);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    Cursor.Current = Cursors.WaitCursor;                    
                    logResultado = _oConceptosCrud.Guardar();
                    Cursor.Current = Cursors.Default;                    
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConceptoPadre_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
                Admin oAdmin = new Admin();
                oAdmin.TabCodigo = "CPTS";
                oAdmin.Tipo = Admin.enumTipoForm.Selector;
                FormsAuxiliares.frmFormAdminMini frmConcepto = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
                if (frmConcepto.ShowDialog() == DialogResult.OK)
                {
                    string strCodPadre = frmConcepto.striRdoCodigo;
                    Console.WriteLine("--strCodconsepto  -" + strCodPadre);
                    _oConceptosCrud.CargarConceptoPadre(strCodPadre);
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

        private void btnTiposComprobantesA_Click(object sender, EventArgs e)
        {
            try
            {

                long logResultado;
                this.VALIDARFORM = true;
                oUtility.ValidarFormularioEP(this, this, 7);
                if (this.VALIDARFORM && _logCptNumero <= 0)
                {                    
                    Cursor.Current = Cursors.WaitCursor;
                    logResultado = _oConceptosCrud.Guardar();
                    Cursor.Current = Cursors.Default;                    
                }

                if (_logCptNumero > 0)
                {
                    //FormsAuxiliares.frmCrudGrilla frmbus = new FormsAuxiliares.frmCrudGrilla("TCO", "TCO_CODIGO", false);
                    //frmbus.ShowDialog();

                    FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
                    Admin oAdmin = new Admin();
                    oAdmin.TabCodigo = "TCO";
                    oAdmin.Tipo = Admin.enumTipoForm.Selector;
                    FormsAuxiliares.frmFormAdminMini frmTcmp = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
                    if (frmTcmp.ShowDialog() == DialogResult.OK)
                    {
                        string strCodTcmp = frmTcmp.striRdoCodigo;
                        Console.WriteLine("--tipocomprobante  -" + strCodTcmp);
                        _oConceptosCrud.CargarTipoComprobante(strCodTcmp);
                    }
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

        private void btnTiposComprobantesB_Click(object sender, EventArgs e)
        {
            try
            {
                if (_logCptNumero > 0 && this.grdCptTipoCmp.RowCount > 0 )
                {
                    DataGridViewRow row = this.grdCptTipoCmp.CurrentRow;
                    if (row == null)
                    {
                        row = this.grdCptTipoCmp.Rows[1];
                    }
                    long logConcepto = Convert.ToInt64(row.Cells[0].Value);
                    string strTipo = Convert.ToString(row.Cells[1].Value);
                    Console.WriteLine("logConcepto" + logConcepto + "strTipo" + strTipo);
                    _oConceptosCrud.BorrarTipoComprobante(logConcepto, strTipo);
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

        #endregion

        private void grdTiposComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
