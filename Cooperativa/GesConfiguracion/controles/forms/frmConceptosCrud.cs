using System;
using System.Windows.Forms;
using Controles.form;
using AppProcesos.gesConfiguracion.frmConceptosCrud;
using Service;
using Controles.datos;
using Model;
using Controles.objects;
using System.Data;

namespace GesConfiguracion.controles.forms
{
    public partial class frmConceptosCrud : gesForm, IVistaConceptosCrud
    {
        #region << PROPIEDADES >>
        UIConceptosCrud _oConceptosCrud;
        Utility oUtility;
        long _logCptNumero;
        long? _logCptCodigoPadre;
        long? _logCptCodigoEnvase;
        long? _logCptCodigoBonificacion;
        long? _logCptCodigoRecargo;
        string _DescripcionPath;
        string _strAccion;
        Adjuntos _Adjunto;
        #endregion

        #region Implementation of IVistaConceptosCrud

        public long logCptNumero
        {
            get { return _logCptNumero; }
            set { _logCptNumero = value; }
        }

        public Adjuntos adjunto
        {
            get { return _Adjunto; }
            set { _Adjunto = value; }
        }

        public string adjuntoFileName
        {
            get { return _DescripcionPath; }
            set { _DescripcionPath = value; }
        }

        public grdGrillaEdit grdCptTipoCmp
        {
            get { return this.grdTiposComprobantes; }
            set { this.grdTiposComprobantes = value; }
        }

        public grdGrillaEdit grdCptServicio
        {
            get { return this.grdServicios; }
            set { this.grdServicios = value; }
        }

        public grdGrillaEdit grdCptFabricado
        {
            get { return this.grdFabricado; }
            set { this.grdFabricado = value; }
        }

        public string strCptCodigo
        {
            get { return this.txtCodigo.Text; }
            set { this.txtCodigo.Text = value; }
        }

        public pbxImagen pbxImagenP
        {
            get { return this.pbxImagen; }
            set { this.pbxImagen = value; }
        }

        public string strCantidadComprobantes
        {
            get { return this.lblCantidadComprobantes.Text; }
            set { this.lblCantidadComprobantes.Text = value; }
        }

        public string strCantidadComponentes
        {
            get { return this.lblCantidadComponentes.Text; }
            set { this.lblCantidadComponentes.Text = value; }
        }

        public string strCantidadServicios
        {
            get { return this.lblCantidadServicios.Text; }
            set { this.lblCantidadServicios.Text = value; }
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

        public bool booCptControlaStock
        {
            get { return this.chkControlaStock.Checked; }
            set { this.chkControlaStock.Checked = value; }
        }

        public bool booModificaCmpImp
        {
            get { return this.chkImporteMod.Checked; }
            set { this.chkImporteMod.Checked = value; }
        }

        public bool booModificaCmpDes
        {
            get { return this.chkDescripcionMod.Checked; }
            set { this.chkDescripcionMod.Checked = value; }
        }

        public bool booCptFraccionado
        {
            get { return this.chkFraccionado.Checked; }
            set { this.chkFraccionado.Checked = value; }
        }

        public cmbLista cmbCumCodigo
        {
            get { return this.cmbUnidadMedida; }
            set { this.cmbUnidadMedida = value; }
        }

        public cmbLista cmbCodRubro
        {
            get { return this.cmbRubro; }
            set { this.cmbRubro = value; }
        }

        public cmbLista cmbCodLinea
        {
            get { return this.cmbLinea; }
            set { this.cmbLinea = value; }
        }

        public cmbLista cmbCodClase
        {
            get { return this.cmbClase; }
            set { this.cmbClase = value; }
        }

        public cmbLista cmbCodEstacionalidad
        {
            get { return this.cmbEstacionalidad; }
            set { this.cmbEstacionalidad = value; }
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

        public long? logCptCodigoEnvase
        {
            get { return _logCptCodigoEnvase; }
            set { _logCptCodigoEnvase = value; }
        }

        public string strCodEnvaseDescripcion
        {
            get { return this.txtRepEnvase.Text; }
            set { this.txtRepEnvase.Text = value; }
        }

        public long? logCptCodigoBonificacion
        {
            get { return _logCptCodigoBonificacion; }
            set { _logCptCodigoBonificacion = value; }
        }

        public string strCodBonificacionDescripcion
        {
            get { return this.txtCodBonificacion.Text; }
            set { this.txtCodBonificacion.Text = value; }
        }

        public long? logCptCodigoRecargo
        {
            get { return _logCptCodigoRecargo; }
            set { _logCptCodigoRecargo = value; }
        }

        public string strCodRecargoDescripcion
        {
            get { return this.txtCodRecargo.Text; }
            set { this.txtCodRecargo.Text = value; }
        }

        public int? intCptFraccionadoPor
        {
            get { return string.IsNullOrEmpty(this.txtFraccionaPor.Text) ? null : (int?)Convert.ToInt16(this.txtFraccionaPor.Text); }
            set { this.txtFraccionaPor.Text = value.ToString(); }
        }

        public bool booCptMedible
        {
            get { return this.chkMedible.Checked; }
            set { this.chkMedible.Checked = value; }
        }

        public bool booCptFabricado
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

        public bool booCptEstado
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
                this.tttEtiqueta.SetToolTip(this.btnCargarImagen, "Carga Imagen");
                this.tttEtiqueta.SetToolTip(this.btnNuevoTipoCmp, "Nuevo Tipo de Comprobante");
                this.tttEtiqueta.SetToolTip(this.btnEliminarTipoCmp, "Eliminar Tipo de Comprobante");
                this.tttEtiqueta.SetToolTip(this.btnNuevoFabricado, "Nuevo Componente");
                this.tttEtiqueta.SetToolTip(this.btnEliminarFabricado, "Eliminar Componente");
                this.tttEtiqueta.SetToolTip(this.btnNuevoServicio, "Nuevo Servicio");
                this.tttEtiqueta.SetToolTip(this.btnEliminarServicio, "Eliminar Servicio");

                if (this.chkControlaStock.Checked)
                    this.gesControlaStock.Enabled = true;
                else
                    this.gesControlaStock.Enabled = false;

                if (this.chkFabricado.Checked)
                    this.gesFabricado.Enabled = true;
                else
                    this.gesFabricado.Enabled = false;

                if (_strAccion == "V")
                {
                    this.gpbDetalle.Enabled = false;
                    this.btnAceptar.Enabled = false;
                    this.tabPagControl.Enabled = false;
                    this.tabPagEspecificaciones.Enabled = false;                   
                }
                if (_strAccion == "I")
                {
                    this.gesControlaStock.Enabled = false;
                    this.gesFabricado.Enabled = false;
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
                bool booCampoVacio = _oConceptosCrud.ValidarGrillaFabricado();
                if (!booCampoVacio)
                    MessageBox.Show("Debe ingresar la cantidad en la Grilla Componetes!");
                
                long logResultado;
                this.VALIDARFORM = true;
                oUtility.ValidarFormularioEP(this, this, 7);
                if (this.VALIDARFORM && booCampoVacio)
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
        
        private void chkControlaStock_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkControlaStock.Checked)
                this.gesControlaStock.Enabled = true;
            else
            {
                this.gesControlaStock.Enabled = false;
                this.txtStockMin.Text = "";
                this.txtStockMax.Text = "";
                this.txtStockReposicion.Text = "";
            }
        }

        private void chkFabricado_CheckedChanged(object sender, EventArgs e)
        {            
            try
            {
                if (this.chkFabricado.Checked)
                {
                    this.gesFabricado.Enabled = true;
                    _oConceptosCrud.CargarGrillaFabricados();
                }
                else
                {
                    this.gesFabricado.Enabled = false;                    
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

        private void btnRepEnvase_Click(object sender, EventArgs e)
        {
            SeleccionaConcepto("ENV");
        }

        private void btnConceptoPadre_Click(object sender, EventArgs e)
        {
            SeleccionaConcepto("PAD");
        }

        private void btnCodBonificacion_Click(object sender, EventArgs e)
        {
            SeleccionaConcepto("BON");
        }

        private void btnCodRecargo_Click(object sender, EventArgs e)
        {
            SeleccionaConcepto("REC");
        }

        private void SeleccionaConcepto(String strOrigen)
        {
            try
            {
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
                Admin oAdmin = new Admin();
                oAdmin.TabCodigo = "CPT";
                oAdmin.Tipo = Admin.enumTipoForm.Selector;
                FormsAuxiliares.frmFormAdminMini frmConcepto = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
                if (frmConcepto.ShowDialog() == DialogResult.OK)
                {
                    string strCodRes = frmConcepto.striRdoCodigo;
                    //Console.WriteLine("--strCodconsepto  -" + strCodRes);
                    if (strOrigen.Equals("PAD"))
                        _oConceptosCrud.CargarConceptoPadre(strCodRes);
                    if (strOrigen.Equals("ENV"))
                        _oConceptosCrud.CargarConceptoEnvase(strCodRes);
                    if (strOrigen.Equals("BON"))
                        _oConceptosCrud.CargarConceptoBonificacion(strCodRes);
                    if (strOrigen.Equals("REC"))
                        _oConceptosCrud.CargarConceptoRecargo(strCodRes);
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "SeleccionaConcepto",
                                "SeleccionaConcepto",
                                this.FindForm().Name);
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                _oConceptosCrud.AgregarImagen();
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

        //private void grdTiposComprobantes_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            //try
            //{
            //    if (!e.ColumnIndex.ToString().Equals("-1"))
            //    {
            //        if (this.grdTiposComprobantes.Columns[e.ColumnIndex].Name == "selector")
            //        {
            //            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
            //            Admin oAdmin = new Admin();
            //            oAdmin.TabCodigo = "TCO";
            //            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            //            FormsAuxiliares.frmFormAdminMini frmConcepto = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            //            if (frmConcepto.ShowDialog() == DialogResult.OK)
            //            {
            //                string strCodRes = frmConcepto.striRdoCodigo;
            //                Console.WriteLine("strCodRes " + strCodRes);
            //                bool resultado =_oConceptosCrud.CargarTipoComprobante(strCodRes, e.RowIndex);
            //                if(!resultado)
            //                    MessageBox.Show("El tipo de comprobante seleccionado ya esta ingresado!");
            //            }
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
        //}

        //private void grdTiposComprobantes_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        //{
        //    try
        //    {
        //        if (!e.Row.Index.ToString().Equals("-1"))
        //        {
        //            if (!this.grdTiposComprobantes.Rows[e.Row.Index].Cells[1].Value.ToString().Equals("0"))
        //            {
        //                string strCodigo = this.grdTiposComprobantes.Rows[e.Row.Index].Cells[2].Value.ToString();
        //                long lonCodigo = long.Parse(this.grdTiposComprobantes.Rows[e.Row.Index].Cells[1].Value.ToString());
        //                Console.WriteLine("tipo a borrar " + lonCodigo+"-"+ strCodigo);
        //                _oConceptosCrud.EliminarTipoComprobante (strCodigo,lonCodigo);
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Cursor.Current = Cursors.Default;
        //        ManejarError Err = new ManejarError();
        //        Err.CargarError(ex,
        //                        e.ToString(),
        //                        ((Control)sender).Name,
        //                        this.FindForm().Name);
        //    }
        //}

        //private void grdFabricado_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (!e.ColumnIndex.ToString().Equals("-1"))
        //        {
        //            if (this.grdFabricado.Columns[e.ColumnIndex].Name == "selector")
        //            {
        //                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
        //                Admin oAdmin = new Admin();
        //                oAdmin.TabCodigo = "CPT";
        //                oAdmin.Tipo = Admin.enumTipoForm.Selector;
        //                FormsAuxiliares.frmFormAdminMini frmConcepto = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
        //                if (frmConcepto.ShowDialog() == DialogResult.OK)
        //                {
        //                    string strCodRes = frmConcepto.striRdoCodigo;
        //                    bool resultado = _oConceptosCrud.CargarConceptoFabricado(strCodRes, e.RowIndex);
        //                    if (!resultado)
        //                        MessageBox.Show("El concepto seleccionado ya esta ingresado!");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Cursor.Current = Cursors.Default;
        //        ManejarError Err = new ManejarError();
        //        Err.CargarError(ex,
        //                        e.ToString(),
        //                        ((Control)sender).Name,
        //                        this.FindForm().Name);
        //    }
        //}

        //private void grdFabricado_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        //{
        //    try
        //    {
        //        if (!e.Row.Index.ToString().Equals("-1"))
        //        {
        //            if(!this.grdFabricado.Rows[e.Row.Index].Cells[1].Value.ToString().Equals("0"))
        //            {                        
        //                long lonCodigo = long.Parse(this.grdFabricado.Rows[e.Row.Index].Cells[2].Value.ToString());
        //                Console.WriteLine("fabricado concepto borrar " + lonCodigo);
        //                _oConceptosCrud.EliminarConceptoFabricado(lonCodigo);
        //            }                    
        //        }
                 
        //    }
        //    catch (Exception ex)
        //    {
        //        Cursor.Current = Cursors.Default;
        //        ManejarError Err = new ManejarError();
        //        Err.CargarError(ex,
        //                        e.ToString(),
        //                        ((Control)sender).Name,
        //                        this.FindForm().Name);
        //    }            
        //}
        private void btnNuevoTipoCmp_Click(object sender, EventArgs e)
        {
            try
            {                
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
                Admin oAdmin = new Admin();
                oAdmin.TabCodigo = "TCO";
                oAdmin.Tipo = Admin.enumTipoForm.Selector;
                FormsAuxiliares.frmFormAdminMini frmConcepto = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
                if (frmConcepto.ShowDialog() == DialogResult.OK)
                {
                    string strCodRes = frmConcepto.striRdoCodigo;
                    //Console.WriteLine("strCodRes " + strCodRes);
                    bool resultado = _oConceptosCrud.CargarTipoComprobante(strCodRes);
                    if (!resultado)
                        MessageBox.Show("El tipo de comprobante seleccionado ya esta ingresado!");
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

        private void btnEliminarTipoCmp_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdTiposComprobantes.CurrentRow;
                if (row == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de comprobante!");
                }
                else
                {                                           
                        string strCodigo = row.Cells[1].Value.ToString();
                        long lonCodigo = long.Parse(row.Cells[0].Value.ToString());
                       // Console.WriteLine("tipo a borrar " + lonCodigo + "-" + strCodigo);
                        _oConceptosCrud.EliminarTipoComprobante(strCodigo, lonCodigo);                                     
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

        private void btnNuevoFabricado_Click(object sender, EventArgs e)
        {
            try
            {                
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
                Admin oAdmin = new Admin();
                oAdmin.TabCodigo = "CPT";
                oAdmin.Tipo = Admin.enumTipoForm.Selector;
                FormsAuxiliares.frmFormAdminMini frmConcepto = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
                if (frmConcepto.ShowDialog() == DialogResult.OK)
                {
                    string strCodRes = frmConcepto.striRdoCodigo;
                    //bool resultado = _oConceptosCrud.CargarConceptoFabricado(strCodRes, e.RowIndex);
                    bool resultado = _oConceptosCrud.CargarConceptoFabricado(strCodRes);
                    if (!resultado)
                        MessageBox.Show("El concepto seleccionado ya esta ingresado!");
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

        private void btnEliminarFabricado_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdFabricado.CurrentRow;
                if (row == null)
                {
                    MessageBox.Show("Debe seleccionar un componente!");
                }
                else
                {
                    long lonCodigo = long.Parse(row.Cells[0].Value.ToString());
                  //  Console.WriteLine("fabricado concepto borrar " + lonCodigo);
                    _oConceptosCrud.EliminarConceptoFabricado(lonCodigo);                    
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

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
                Admin oAdmin = new Admin();
                oAdmin.TabCodigo = "SRV";
                oAdmin.Tipo = Admin.enumTipoForm.Selector;
                FormsAuxiliares.frmFormAdminMini frmServicio = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
                if (frmServicio.ShowDialog() == DialogResult.OK)
                {
                    string strCodRes = frmServicio.striRdoCodigo;
                    //bool resultado = _oConceptosCrud.CargarConceptoFabricado(strCodRes, e.RowIndex);
                    bool resultado = _oConceptosCrud.CargarServicio(strCodRes);
                    if (!resultado)
                        MessageBox.Show("El servicio seleccionado ya esta ingresado!");
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

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdServicios.CurrentRow;
                if (row == null)
                {
                    MessageBox.Show("Debe seleccionar un servicio!");
                }
                else
                {
                    long lonCodigo = long.Parse(row.Cells[0].Value.ToString());
                    //  Console.WriteLine("fabricado concepto borrar " + lonCodigo);
                    _oConceptosCrud.EliminarServicio(lonCodigo);
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


    }
}
