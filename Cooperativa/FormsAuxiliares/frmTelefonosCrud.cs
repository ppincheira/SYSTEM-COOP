using AppProcesos.formsAuxiliares.frmTelefonos;
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
using Controles.form;
using Controles.datos;

namespace FormsAuxiliares
{
    public partial class frmTelefonosCrud : gesForm, IVistaTelefonosCrud
    {
        #region << PROPIEDADES >>
        UITelefonosCrud _oTelefonosCrud;
        Utility oUtility;
        long _Codigo;
        string _TabCodigo;
        string _CodigoRegistro;       
        string _Accion;

        #endregion

        #region Implementation of IVistaTelefonosCrud

        public cmbLista telCargo
        {
            get { return this.cmbCargo; }
            set { this.cmbCargo = value; }
        }
        public cmbLista telTipo
        {
            get { return this.cmbTipo; }
            set { this.cmbTipo = value; }
        }
        public long telCodigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        public string telNumero
        {
            get { return this.txtNumeroTelefono.Text; }
            set { this.txtNumeroTelefono.Text = value; }
        }                
        public Boolean telDefecto
        {
            get { return this.chkPorDefecto.Checked; }
            set { this.chkPorDefecto.Checked = value; }
        }
        public string telEmail
        {
            get { return this.txtEmail.Text; }
            set { this.txtEmail.Text = value; }
        }
        public string telNombreContacto
        {
            get { return this.txtNombreContacto.Text; }
            set { this.txtNombreContacto.Text = value; }
        }
        public String tabCodigo
        {
            get { return _TabCodigo; }
            set { _TabCodigo = value; }
        }

        public string telCodigoRegistro
        {
            get { return _CodigoRegistro; }
            set { _CodigoRegistro = value; }
        }       
        #endregion

        #region << EVENTOS >>

        public frmTelefonosCrud(long Codigo, string TabCodigo, string CodigoRegistro, string Accion)
        {
            InitializeComponent();
            _oTelefonosCrud = new UITelefonosCrud(this);
            _Codigo = Codigo;
            _TabCodigo = TabCodigo;
            _CodigoRegistro = CodigoRegistro;
            _Accion = Accion;
        }
        private void frmTelefonosCrud_Load(object sender, EventArgs e)
        {
            try
            {                
                _oTelefonosCrud.Inicializar();
                oUtility = new Utility();

                this.tttEtiqueta.SetToolTip(this.txtNombreContacto, "Nombre del contacto");
                this.tttEtiqueta.SetToolTip(this.txtEmail, "Email del contacto");
                this.tttEtiqueta.SetToolTip(this.txtNumeroTelefono, "Numero de Telefono");
                this.tttEtiqueta.SetToolTip(this.chkPorDefecto, "Indica si el numero para llamar por defecto");
                this.tttEtiqueta.SetToolTip(this.cmbCargo, "Cargo del contacto");
                this.tttEtiqueta.SetToolTip(this.cmbTipo, "Tipo de numero de telefono");
                                
                if (_Accion == "V")
                {
                    this.gesDatos.Enabled = false;
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
                if (this.txtEmail.emailValido())
                {
                    this.VALIDARFORM = true;
                    oUtility.ValidarFormularioEP(this, this, 6);
                    if (this.VALIDARFORM)
                    {
                        DialogResult = DialogResult.OK;
                        Cursor.Current = Cursors.WaitCursor;
                        _oTelefonosCrud.Guardar();
                        Cursor.Current = Cursors.Default;
                        this.Close();
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
