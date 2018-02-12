using AppProcesos.gesServicios.frmTiposConexionesCrud;
using Controles.datos;
using Controles.form;
using Service;
using System;
using System.Windows.Forms;


namespace GesServicios.controles.forms
{
    public partial class frmTiposConexionesCrud : gesForm, IVistaTiposConexionesCrud
    {
        #region << PROPIEDADES >>
        UITiposConexionesCrud _oTiposConexionesCrud;
        Utility oUtil;
        int _UsrNumero;
        string _TcsCodigo;
        bool _Nuevo ;
        #endregion
        #region << IMPLEMENTACION >>
        public string tcsCodigo
        {
            get { return  _TcsCodigo; }
            set { gesTextBoxCodigo.Text= value; }
        }
        public string tcsDescripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }
        public string tcsDescripcionCorta
        {
            get { return txtDescripcionCorta.Text; }
            set { txtDescripcionCorta.Text = value; }
        }
        public cmbLista srvCodigo
        {
            get { return cmbSRVCodigo; }
            set { cmbSRVCodigo = value; }
        }
        public int usrNumero
        {
            get { return _UsrNumero; }
            set { _UsrNumero = value; }
        }
        public string estCodigo
        {
            get { return chkEstado.Checked ? "H" : "I"; }
            set { chkEstado.Checked = (value == "H"); }
        }
        public bool nuevo
        {
            get { return _Nuevo; }
            set { _Nuevo = value; }
        }
        #endregion

        public frmTiposConexionesCrud(string SConexionTipo, string Estado)
        {
            _TcsCodigo = SConexionTipo;
            _oTiposConexionesCrud = new UITiposConexionesCrud(this);
            InitializeComponent();

            if (Estado == "B")
                if (MessageBox.Show("Desea eliminar El Tipo de Conexion Código: " + SConexionTipo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oTiposConexionesCrud.EliminarConexion(_TcsCodigo);
                    this.Close();
                }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!gbDatos.Enabled)
                this.Close();
            try
            {
                usrNumero = 1;
                if (VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oTiposConexionesCrud.Guardar();
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

        private void frmTiposConexionesCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oTiposConexionesCrud.Inicializar();
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
