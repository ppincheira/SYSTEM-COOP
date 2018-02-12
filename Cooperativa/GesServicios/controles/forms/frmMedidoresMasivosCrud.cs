using AppProcesos.gesServicios.frmMedidoresCrud;
using Controles.datos;
using Controles.form;
using Service;
using System;
using System.Windows.Forms;

namespace GesServicios.controles.forms
{
    public partial class frmMedidoresMasivosCrud : gesForm, IVistaMedidoresMasivosCrud
    {

        #region << PROPIEDADES >>

        UIMedidoresMasivosCrud _oMedidoresCrud;
        Utility oUtil;

        long _MmoNumero;
        int _usrNumero;
        string _EstCodigo;

        #endregion
        #region Implementation of IVistaMedidoresCrud


        public long Numero
        {
            get { return _MmoNumero; }
            set { _MmoNumero = value; }
        }
        public long NumeroSerieDesde
        {
            get { return long.Parse(this.gesTextBoxNumeroSerieDesde.Text); }
            set { this.gesTextBoxNumeroSerieDesde.Text = value.ToString(); }
        }

        public long NumeroSerieHasta
        {
            get { return long.Parse(this.gesTextBoxNumeroSerieHasta.Text); }
            set { this.gesTextBoxNumeroSerieHasta.Text = value.ToString(); }
        }
        public cmbLista NumeroProv
        {
            get { return this.cmbNumeroProv; }
            set { this.cmbNumeroProv = value; }
        }
        public int Digitos
        {
            get { return int.Parse(gesTextBoxDigitos.Text); }
            set { gesTextBoxDigitos.Text = value.ToString(); }
        }
        public string EstCodigo
        {
            get { return this.chkEstado.Checked ? "H" : "I"; }
            set { this.chkEstado.Checked = (value == "H"); }
        }

        public double FactorCalib
        {
            get { return double.Parse(gesTextBoxFactorCalib.Text); }
            set { gesTextBoxFactorCalib.Text = value.ToString(); }
        }

        public decimal? GisX
        {
            get { return string.IsNullOrEmpty(gesTextBoxGisX.Text) ? null : (decimal?)Convert.ToDecimal(gesTextBoxGisX.Text); }
            set { gesTextBoxGisX.Text = value.ToString(); }
        }

        public decimal? GisY
        {
            get { return string.IsNullOrEmpty(gesTextBoxGisY.Text) ? null : (decimal?)Convert.ToDecimal(gesTextBoxGisY.Text); }
            set { gesTextBoxGisY.Text = value.ToString(); }
        }

        public int UsrNumero
        {
            get { return _usrNumero; }
            set { _usrNumero = value; }
        }

        public DateTime FechaCarga
        {
            get { return DateTime.Parse(dtpFechaCarga.Text); }
            set { dtpFechaCarga.Text = value.ToString(); }
        }
        public cmbLista MmoCodigo
        {
            get { return this.cmbMmoCodigo; }
            set { this.cmbMmoCodigo = value; }
        }


        #endregion
        public frmMedidoresMasivosCrud(long NumeroMedidor, string Estado, int Usuario)
        {
            //try
            //{
            _MmoNumero = NumeroMedidor;
            _EstCodigo = Estado;
            _usrNumero = Usuario;
            _oMedidoresCrud = new UIMedidoresMasivosCrud(this);
            InitializeComponent();
        }

        private void frmMedidoresMasivosCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oMedidoresCrud.Inicializar();
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
            if (!this.gbDatos.Enabled)
            {
                this.Close();
                return;
            }
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormularioEP(this, this, 10);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oMedidoresCrud.Guardar();
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

        private void gesTextBoxGisX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
