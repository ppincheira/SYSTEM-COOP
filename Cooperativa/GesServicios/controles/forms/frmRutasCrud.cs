using AppProcesos.gesServicios.frmRutasCrud;
using Controles.datos;
using Controles.form;
using Service;
using System;
using System.Windows.Forms;

namespace GesServicios.controles.forms
{
    public partial class frmRutasCrud : gesForm, IVistaRutasCrud
    {

        #region << PROPIEDADES >>

        UIRutasCrud _oRutasCrud;
        Utility oUtil;

        long _SruNumero;
        string _EstCodigo;
        long _GrdCodigo;
        string _GrdCodigoRegistro;

        #endregion
        #region Implementation of IVistaRutasCrud


        public long sruNumero
        {
            get { return _SruNumero; }
            set { _SruNumero = value; }
        }
        public string Descripcion
        {
            get { return this.txtDescripcion.Text; }
            set { this.txtDescripcion.Text = value; }
        }

        public string DescripcionCorta
        {
            get { return this.txtDescripcionCorta.Text; }
            set { this.txtDescripcionCorta.Text = value; }
        }

        public string estCodigo
        {
            get { return this.chkEstado.Checked?"H":"I"; }
            set { this.chkEstado.Checked= (value=="H"); }
        }

        public cmbLista srvCodigo
        {
            get { return this.cmbServicio; }
            set { this.cmbServicio = value; }
        }
        public long grdCodigo
        {
            get { return _GrdCodigo; }
            set { _GrdCodigo = value; }
        }
        public cmbLista grupo
        {
            get { return this.cmbGrupo; }
            set { this.cmbGrupo = value; }
        }
        public string grdCodigoRegistro
        {
            get { return _GrdCodigoRegistro; }
            set { _GrdCodigoRegistro = value; }
        }
        #endregion
        public frmRutasCrud(long SRuta, string Estado)
            //SRuta, Estado 
        {
            _SruNumero=SRuta;
            _EstCodigo = Estado;
            _oRutasCrud = new UIRutasCrud(this);
            InitializeComponent();
            if (Estado == "B")
                if (MessageBox.Show("Desea eliminar La Ruta Código: " + SRuta + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oRutasCrud.EliminarRuta(SRuta);
                    this.Close();
                }
        }

        private void frmRutasCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oRutasCrud.Inicializar();
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
                Close();
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormularioEP(this, this, 4);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oRutasCrud.Guardar();

                    Close();
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

    }
}
