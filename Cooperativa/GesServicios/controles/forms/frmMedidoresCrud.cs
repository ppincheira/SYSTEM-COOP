using AppProcesos.gesServicios.frmMedidoresCrud;
using Controles.datos;
using Controles.form;
using Service;
using Model;
using System;
using System.Windows.Forms;
using FormsAuxiliares;

namespace GesServicios.controles.forms
{
    public partial class frmMedidoresCrud : gesForm, IVistaMedidoresCrud
    {

        #region << PROPIEDADES >>

        UIMedidoresCrud _oMedidoresCrud;
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
        public long NumeroSerie
        {
            get { return long.Parse(this.TextBoxNumeroSerie.Text); }
            set { this.TextBoxNumeroSerie.Text = value.ToString(); }
        }

        public long NumeroProv
        {
            get { return long.Parse(txtEmpNumero.Text); }
            set { txtEmpNumero.Text = value.ToString(); }
        }
        public int Digitos
        {
            get { return int.Parse(TextBoxDigitos.Text); }
            set { TextBoxDigitos.Text = value.ToString(); }
        }
        public cmbLista EstCodigo
        {
            get { return cmbEstado; }
            set { this.cmbEstado = value; }
        }

        public double FactorCalib
        {
            get { return double.Parse(TextBoxFactorCalib.Text); }
            set { TextBoxFactorCalib.Text = value.ToString(); }
        }

        public decimal? GisX
        {
            get { return string.IsNullOrEmpty(TextBoxGisX.Text) ? null : (decimal?)Convert.ToDecimal(TextBoxGisX.Text); }
            set { TextBoxGisX.Text = value.ToString(); }
        }

        public decimal? GisY
        {
            get { return string.IsNullOrEmpty(TextBoxGisY.Text) ? null : (decimal?)Convert.ToDecimal(TextBoxGisY.Text); }
            set { TextBoxGisY.Text = value.ToString(); }
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

        public cmbLista LemCodigo
        {
            get { return this.cmbLmeCodigo; }
            set { this.cmbLmeCodigo = value; }
        }
        //public decimal Registrador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string strRazonSocial
        {
            get { return this.txtEmpRazonSocial.Text; }
            set { this.txtEmpRazonSocial.Text = value; }
        }

        #endregion
        public frmMedidoresCrud(long NumeroMedidor, string Estado, int Usuario)
        {
            //try
            //{
            _MmoNumero = NumeroMedidor;
            _EstCodigo = Estado;
            _usrNumero = Usuario;
            _oMedidoresCrud = new UIMedidoresCrud(this);
            InitializeComponent();
            if (Estado == "B")
                if (MessageBox.Show("Desea eliminar el Numero de Medidor Código: " + NumeroMedidor + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oMedidoresCrud.EliminarModeloMedidor(NumeroMedidor);
                    this.Close();
                }
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

        private void frmMedidoresCrud_Load(object sender, EventArgs e)
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
            if (!gbDatos.Enabled)
            {
                Close();
            }
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormularioEP(this, this, 11);
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("100047", "100048", "100049", "0", "0", "100050");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "CLIE";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            oAdmin.FiltroCampos = "e.emp_proveedor&e.est_codigo_pro&";
            oAdmin.FiltroOperador = "1&1&";
            oAdmin.FiltroValores = "S&H&";
            frmFormAdmin frmbus = new frmFormAdmin(oAdmin, oPermiso);
            if (frmbus.ShowDialog() == DialogResult.OK)
            {
                string id = frmbus.striRdoCodigo;
                _oMedidoresCrud.CargarProveedor(long.Parse(id));
            }

        }
    }
}
