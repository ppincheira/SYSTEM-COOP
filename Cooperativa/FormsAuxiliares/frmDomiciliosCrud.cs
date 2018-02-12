using AppProcesos.formsAuxiliares.frmDomicilios;
using Controles.datos;
using Controles.form;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAuxiliares
{
    public partial class frmDomiciliosCrud: gesForm, IVistaDomiciliosCrud
    {

        #region << PROPIEDADES >>
        UIDomiciliosCrud _oDomicilioCrud;
        Utility oUtil;
        long _DomCodigo;
        string _TabCodigo;
        long _DomCodigoRegistro;
        string _TdoCodigo;
        Admin _oAdmin;
        #endregion

        #region Implementation of IVistaDomiciliosCrud
        public long domCodigo
        {
            get { return _DomCodigo; }
            set { _DomCodigo = value; }
        }
        public string tabCodigo
        {
            get { return _TabCodigo; }
            set { _TabCodigo = value; }
        }
        public Boolean denDefecto
        {
            get { return this.chkPorDefecto.Checked; }
            set { this.chkPorDefecto.Checked = value; }
        }
        public long  domCodigoRegistro
        {
            get { return _DomCodigoRegistro; }
            set { _DomCodigoRegistro = value; }
        }
        public string tdoCodigo
        {
            get { return _TdoCodigo; }
            set { _TdoCodigo = value; }
        }

        public cmbLista cmbiLocalidad
        {
            get { return this.cmbLocalidad; }
            set { this.cmbLocalidad = value; }
        }
        public cmbLista cmbiCalle
        {
            get { return this.cmbCalle; }
            set { this.cmbCalle = value; }
        }
        public cmbLista cmbiBarrio
        {
            get { return this.cmbBarrio; }
            set { this.cmbBarrio = value; }
        }
        public cmbLista cmbiTipo
        {
            get { return this.cmbTipo; }
            set { this.cmbTipo = value; }
        }
        public int numero
        {
            get { return int.Parse(this.txtNumero.Text); }
            set { this.txtNumero.Text = value.ToString(); }
        }
        public string bloque
        {
            get { return this.txtBloque.Text; }
            set { this.txtBloque.Text = value; }
        }
        public string lote
        {
            get { return this.txtLote.Text; }
            set { this.txtLote.Text = value; }
        }
        public string departamento
        {
            get { return this.txtDepartamento.Text; }
            set { this.txtDepartamento.Text = value; }
        }
        public string piso
        {
            get { return this.txtPiso.Text; }
            set { this.txtPiso.Text = value; }
        }
        public string parcela
        {
            get { return this.txtParcela.Text; }
            set { this.txtParcela.Text = value; }
        }
        public cmbLista cmbiCalleDesde
        {
            get { return this.cmbCalleDesde; }
            set { this.cmbCalleDesde = value; }
        }
        public cmbLista cmbiCalleHasta
        {
            get { return this.cmbCalleHasta; }
            set { this.cmbCalleHasta = value; }
        }
        public cmbLista cmbiCodigoPostal
        {
            get { return this.cmbCodigoPostal; }
            set { this.cmbCodigoPostal = value; }
        }
        public decimal? gisX
        {
            get { return string.IsNullOrEmpty(this.txtGisX.Text) ? null : (decimal?)Convert.ToDecimal(this.txtGisX.Text);}
            set { this.txtGisX.Text = value.ToString(); }
        }
        public decimal? gisY
        {
            get { return string.IsNullOrEmpty(this.txtGisY.Text) ? null : (decimal?)Convert.ToDecimal(this.txtGisY.Text); }
            set { this.txtGisY.Text = value.ToString(); }
        }
        #endregion

        #region << EVENTOS >>
        public frmDomiciliosCrud(long domCodigo, Admin oAdmin )
        {
            try
            {
                InitializeComponent();
                _DomCodigo = domCodigo;
                _oDomicilioCrud = new UIDomiciliosCrud(this);
                _oAdmin = oAdmin;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void frmDomiciliosCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oDomicilioCrud.Inicializar();
                //this.cmbLocalidad.REQUERIDO = "SI";
                //this.cmbCalle.REQUERIDO = "SI";
                //this.cmbCalleDesde.REQUERIDO = "SI";
                //this.cmbCalleHasta.REQUERIDO = "SI";
                //this.cmbCodigoPostal.REQUERIDO = "SI";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormularioEP(this,this,14);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oDomicilioCrud.Guardar(_oAdmin);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
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
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            _oDomicilioCrud.CargarCallesCodigoPostal();
        }
        #endregion
    }
}
