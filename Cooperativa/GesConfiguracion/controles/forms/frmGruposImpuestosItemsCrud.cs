using System;
using System.Windows.Forms;
using Controles.form;
using AppProcesos.gesConfiguracion.GruposImpuestosItemsCrud;
using Service;
using Controles.datos;
using Model;
using Controles.objects;
using System.Data;

namespace GesConfiguracion.controles.forms
{
    public partial class frmGruposImpuestosItemsCrud : gesForm, IVistaGruposImpuestosItemsCrud
    {
        #region << PROPIEDADES >>
        UIGruposImpuestosItemsCrud _oGruposImpuestosItemsCrud;
        Utility oUtility;
        int _intGiiNumero;        
        long _logCptNumero;        
        string _strAccion;
        #endregion

        #region Implementation of IVistaGruposImpuestosItemsCrud

        public int intGiiNumero
        {
            get { return _intGiiNumero; }
            set { _intGiiNumero = value; }
        }

        public cmbLista cmbTivCodigo
        {
            get { return this.cmbTipoIva; }
            set { this.cmbTipoIva = value; }
        }

        public decimal? decGiiPorcentaje
        {
            get { return string.IsNullOrEmpty(this.txtPorcentaje.Text) ? null : (decimal?)Convert.ToDecimal(this.txtPorcentaje.Text); }
            set { this.txtPorcentaje.Text = value.ToString(); }
        }

        public DateTime datGiiVigenciaDesde
        {
            get { return DateTime.Parse(this.dtpVigenciaDesde.Text); }
            set { this.dtpVigenciaDesde.Text = value.ToString(); }
        }

        public DateTime? datGiiVigenciaHasta
        {
            get {
                if (this.dtpVigenciaHasta.Checked)
                    return DateTime.Parse(this.dtpVigenciaHasta.Text);
                else
                    return null;
                }
            set {
                this.dtpVigenciaHasta.Text = value.ToString();
                }
        }

        public decimal? decGiiImporteMinimo
        {
            get { return string.IsNullOrEmpty(this.txtImporteMinimo.Text) ? null : (decimal?)Convert.ToDecimal(this.txtImporteMinimo.Text); }
            set { this.txtImporteMinimo.Text = value.ToString(); }
        }

        public decimal? decGiiImporteFijo
        {
            get { return string.IsNullOrEmpty(this.txtImporteFijo.Text) ? null : (decimal?)Convert.ToDecimal(this.txtImporteFijo.Text); }
            set { this.txtImporteFijo.Text = value.ToString(); }
        }

        public decimal? decGiiImporteBaseMinimo
        {
            get { return string.IsNullOrEmpty(this.txtBaseMinimo.Text) ? null : (decimal?)Convert.ToDecimal(this.txtBaseMinimo.Text); }
            set { this.txtBaseMinimo.Text = value.ToString(); }
        }

        public cmbLista cmbPrsLocalidad
        {
            get { return this.cmbLocalidad; }
            set { this.cmbLocalidad = value; }
        }

        public cmbLista cmbPrsProvincia
        {
            get { return this.cmbProvincia; }
            set { this.cmbProvincia = value; }
        }

        public long logCptConcepto
        {
            get { return _logCptNumero; }
            set { _logCptNumero = value; }
        }

        public string strCptDescripcion
        {
            get { return this.txtConcepto.Text; }
            set { this.txtConcepto.Text = value; }
        }

        public cmbLista cmbGciGrupo
        {
            get { return this.cmbGrupo; }
            set { this.cmbGrupo = value; }
        }
        #endregion

        #region << EVENTOS >>
        public frmGruposImpuestosItemsCrud(int Codigo, string Accion)
        {
            try
            {
                
                InitializeComponent();

                _oGruposImpuestosItemsCrud = new UIGruposImpuestosItemsCrud(this);
                _intGiiNumero = Codigo;
                _strAccion = Accion;
                if (_strAccion == "B")
                    if (MessageBox.Show("Desea eliminar El grupo: " + Codigo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _oGruposImpuestosItemsCrud.EliminarGruposImpuestosItems(_intGiiNumero);
                        Cursor.Current = Cursors.Default;
                        this.Close();
                    }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "frmGruposImpuestosItemsCrud",
                                "frmGruposImpuestosItemsCrud",
                                this.FindForm().Name);
            }
        }
        private void frmGruposImpuestosItemsCrud_Load(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("paso 1");
                _oGruposImpuestosItemsCrud.Inicializar();
                oUtility = new Utility();
                
                this.tttEtiqueta.SetToolTip(this.cmbTipoIva, "Tipo de IVA");
                this.tttEtiqueta.SetToolTip(this.dtpVigenciaDesde, "Fecha vigencia desde");
                this.tttEtiqueta.SetToolTip(this.cmbGrupo, "Grupo de concepto impuesto");
                this.tttEtiqueta.SetToolTip(this.dtpVigenciaHasta, "Fecha vigencia hasta");
                this.tttEtiqueta.SetToolTip(this.btnConcepto, "Carga Concepto");
                this.tttEtiqueta.SetToolTip(this.txtConcepto, "Concepto relacionado");
                this.tttEtiqueta.SetToolTip(this.txtPorcentaje, "Porcentaje");
                this.tttEtiqueta.SetToolTip(this.cmbPrsProvincia, "Provincia");
                this.tttEtiqueta.SetToolTip(this.cmbPrsLocalidad, "Localidad");
                this.tttEtiqueta.SetToolTip(this.txtImporteFijo, "Importe fijo");
                this.tttEtiqueta.SetToolTip(this.txtImporteMinimo, "Importe minimo");
                this.tttEtiqueta.SetToolTip(this.txtBaseMinimo, "Base minimo");               

                if (_strAccion == "V")
                {
                    this.gbDatos.Enabled = false;
                    this.btnAceptar.Enabled = false;                   
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
                oUtility.ValidarFormularioEP(this, this, 12);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    Cursor.Current = Cursors.WaitCursor;
                    logResultado = _oGruposImpuestosItemsCrud.Guardar();
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
        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _oGruposImpuestosItemsCrud.CambioProvincia();
                Cursor.Current = Cursors.Default;
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
        private void btnConcepto_Click(object sender, EventArgs e)
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
                    _oGruposImpuestosItemsCrud.CargarConcepto(strCodRes);                    
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
