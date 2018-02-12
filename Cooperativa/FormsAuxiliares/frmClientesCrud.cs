using AppProcesos.formsAuxiliares.frmClientes;
using Controles.datos;
using Controles.Fecha;
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
    public partial class frmClientesCrud : gesForm, IVistaClientesCrud
    {

        #region << PROPIEDADES >>
        UIClientesCrud _oClientesCrud;
        Utility oUtil;
        long _EmpNumero;
        Enumeration.Acciones _Accion;
        long _CodigoDomicilio;
        long _CodigoTelefono;
        long _CodigoEmail;
        long _CodigoObservacion;

        #endregion


        #region Implementation of IVistaClientesCrud
        public long empNumero
        {
            get { return _EmpNumero; }
            set { _EmpNumero = value; }
        }
        public string strRazonSocial
        {
            get { return this.txtRazonSocial.Text; }
            set { this.txtRazonSocial.Text = value; }
        }
        public string strDenominacionComercial
        {
            get { return this.txtDenominacionComercial.Text; }
            set { this.txtDenominacionComercial.Text = value; }
        }
        public string strCuit
        {
            get { return this.rbIndividual.Checked ? this.txtCuitI.Text: this.txtCuit.Text; }
            set { this.txtCuitI.Text = value; this.txtCuit.Text= value; }
        }

        public cmbLista cmbiTipoIva
        {
            get { return this.rbIndividual.Checked ? this.cmbTipoIvaI:this.cmbTipoIVA; }
            set { this.cmbTipoIvaI = value; this.cmbTipoIVA = value;}
        }
        public string strObservacion
        {
            get { return this.txtObservaciones.Text; }
            set { this.txtObservaciones.Text = value; }
        }
        public string strTitularCheques
        {
            get { return this.txtTitularCheques.Text; }
            set { this.txtTitularCheques.Text = value; }
        }
        public string strPropia
        {
            get { return this.chkEmpPropia.Checked?"S":"N"; }
            set { this.chkEmpPropia.Checked = value=="S"?true:false; }
        }
        public string strCliente
        {
            get { return this.chkEsCliente.Checked ? "S" : "N"; }
            set { this.chkEsCliente.Checked = value == "S" ? true : false; }
        }

        public string strProveedor
        {
            get { return this.chkEsProveedor.Checked ? "S" : "N"; }
            set { this.chkEsProveedor.Checked = value == "S" ? true : false; }
        }
        public string strCategoriaMonotributo
        {

            get { return null; }
            set {}
        }
        public cmbLista cmbiTipoDocumento
        {
            get { return this.cmbTipoDniI; }
            set { this.cmbTipoDniI = value;}
        }
        public string strNroDocumento
        {
            get { return this.txtDNII.Text; }
            set { this.txtDNII.Text = value; }
        }
        public string strApellido
        {
            get { return this.txtApellidoI.Text; }
            set { this.txtApellidoI.Text = value; }
        }
        public string strNombre
        {
            get { return this.txtNombreI.Text; }
            set { this.txtNombreI.Text = value; }
        }
        public double? dblLimiteCredito
        {
            get { return this.txtLimiteCredito.Text!=""? double.Parse(this.txtLimiteCredito.Text):0; }
            set { this.txtLimiteCredito.Text = value.ToString(); }
        }
        public cmbLista cmbiEstadoCredito
        {
            get { return this.cmbEstadoCredito; }
            set { this.cmbEstadoCredito = value; }
        }

        public int? intNumeroTransporte
        {
            get { return this.txtNroTransporte.Text==""?0:int.Parse(this.txtNroTransporte.Text); }
            set { this.txtNroTransporte.Text = value.ToString(); }
        }
        public string strTelefono
        {
            get { return this.chkEsCliente.Checked ? this.txtTelefonoI.Text:this.txtTelefono.Text ; }
            set { this.txtTelefonoI.Text = value; this.txtTelefono.Text = value; }
        }
        public string strEmail
        {
            get { return this.chkEsCliente.Checked ? this.txtEmailI.Text : this.txtEmail.Text; }
            set { this.txtEmailI.Text = value; this.txtEmail.Text = value; }
        }
        public string strDomicilio
        {
            get { return this.chkEsCliente.Checked ? this.txtDomicilioI.Text : this.txtDomicilio.Text; }
            set { this.txtDomicilioI.Text = value; this.txtDomicilio.Text = value; }
        }
        public dtpFecha dtpiFechaAlta
        {
            get { return this.dtpFechaAlta; }
            set { this.dtpFechaAlta= value; }
        }
        public dtpFecha dtpiFechaAltaCli
        {
            get { return this.dtpFechaAltaCli; }
            set { this.dtpFechaAltaCli = value; }
        }
        public dtpFecha dtpiFechaBajaCli
        {
            get { return this.dtpFechaBajaCli; }
            set { this.dtpFechaBajaCli = value; }
        }
        public dtpFecha dtpiFechaAltaPro
        {
            get { return this.dtpFechaAltaPro; }
            set { this.dtpFechaAltaPro = value; }
        }
        public dtpFecha dtpiFechaBajaPro
        {
            get { return this.dtpFechaBajaPro; }
            set { this.dtpFechaBajaPro = value; }
        }

        public long lgCodigoDomicilio
        {
            get { return _CodigoDomicilio; }
            set { _CodigoDomicilio = value; }
        }

        public long lgCodigoTelefono
        {
            get { return _CodigoTelefono; }
            set { _CodigoTelefono = value; }
        }
        public long lgCodigoEmail
        {
            get { return _CodigoEmail; }
            set { _CodigoEmail = value; }
        }

        public long lgCodigoObservacion
        {
            get { return _CodigoObservacion; }
            set { _CodigoObservacion= value; }
        }

        #endregion



        public frmClientesCrud(Int32 EmpNumero)
        {
            InitializeComponent();
            _EmpNumero = EmpNumero;
            if (EmpNumero == 0)
                _Accion = Enumeration.Acciones.New;
            else
                _Accion = Enumeration.Acciones.Edit;
            _oClientesCrud = new UIClientesCrud(this);
        }

        private void frmClientesCrud_Load(object sender, EventArgs e)
        {
            oUtil = new Utility();
            _oClientesCrud.ObtenerId(_EmpNumero);
            this.rbEmpresa.Checked = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.VALIDARFORM = true;
                //oUtil.ValidarFormulario(this, this,60);
                //if (this.VALIDARFORM)
                //{
                //    
                     _oClientesCrud.Guardar();
                     DialogResult = DialogResult.OK;
                     this.Close();
                //}
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
        private void rbIndividual_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            this.pnlEmpresa.Visible = false;
            this.pnlIndividuo.Visible = true;
            _oClientesCrud.Inicializar(_EmpNumero,_Accion);
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

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            this.pnlEmpresa.Visible = true;
            this.pnlIndividuo.Visible = false;
            _oClientesCrud.Inicializar(_EmpNumero,_Accion);
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
        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            NuevoDomicilio();
        }
        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        { 
        //    if (_CodigoDomicilio != 0)
        //        EditarDomicilio();
        //    else
        //        NuevoDomicilio();
            
          }

        private void btnDomicilioI_Click(object sender, EventArgs e)
        {
            NuevoDomicilio();
        }
        private void txtDomicilioI_TextChanged(object sender, EventArgs e)
        {
            //if (_CodigoDomicilio != 0)
            //    EditarDomicilio();
            //else
            //    NuevoDomicilio();
        }


        private void btnTelefono_Click(object sender, EventArgs e)
        {
            NuevoTelefono();
            
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

            NuevoEmail();
        }

      
        private void pbImagen_Click(object sender, EventArgs e)
        {

        }
        private void btnTelefonosI_Click(object sender, EventArgs e)
        {
            NuevoTelefono();
        }
        private void btnEmailI_Click(object sender, EventArgs e)
        {
            NuevoEmail();
        }

        private void btnNuevaObs_Click(object sender, EventArgs e)
        {

            NuevaObservacion();
        }

        private void EditarDomicilio()
        {


            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "DOMB";
            oAdmin.Tipo = Admin.enumTipoForm.FiltroAndEditar;
            oAdmin.CodigoRegistro = _EmpNumero.ToString();
            oAdmin.CodigoEditar = _CodigoDomicilio.ToString();
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "DE.DEN_CODIGO_REGISTRO&";
            oAdmin.FiltroValores = _EmpNumero.ToString()+"&";
            

            FormsAuxiliares.frmFormAdmin oFrmAdminMini = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            if (oFrmAdminMini.ShowDialog() == DialogResult.OK)
            {
                string id = oFrmAdminMini.striRdoCodigo;
                _oClientesCrud.CargarDomicilio(_EmpNumero,"CLIE");

            }

        }

        private void NuevoDomicilio() { 
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "DOMB";
            oAdmin.Tipo = Admin.enumTipoForm.FiltroAndAlta;
            oAdmin.CodigoRegistro = _EmpNumero.ToString();
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "DE.DEN_CODIGO_REGISTRO&";
            oAdmin.FiltroValores = _EmpNumero.ToString()+"&";
            FormsAuxiliares.frmFormAdmin oFrmAdminMini = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            if (oFrmAdminMini.ShowDialog() == DialogResult.OK)
            {
                string id = oFrmAdminMini.striRdoCodigo;
                _oClientesCrud.CargarDomicilio(_EmpNumero,"CLIE");
            }
        }


        private void NuevaObservacion()
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            AdminObs oAdmin = new AdminObs();
            oAdmin.TabCodigo = "CLIE";
            oAdmin.Tipo = AdminObs.enumTipoForm.FiltroAndAlta;
            oAdmin.CodigoRegistro = _EmpNumero.ToString();
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "OBS_CODIGO_REGISTRO&";
            oAdmin.FiltroValores = _EmpNumero.ToString() + "&";
            oAdmin.TobCodigo = 1;
            //FormsAuxiliares.frmFormAdmin oFrmAdminMini = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);

            FormsAuxiliares.frmObservacionesAdmin frmobs = new FormsAuxiliares.frmObservacionesAdmin(oAdmin, oPermiso);
            if (frmobs.ShowDialog() == DialogResult.OK)
            {
                string id = frmobs._strRdoCodigo;
                _oClientesCrud.CargarObservaciones(_EmpNumero, "CLIE");

            }

        }
        private void NuevoTelefono()
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.Tipo = Admin.enumTipoForm.FiltroAndAlta;
            oAdmin.TabCodigo = "TETE";
            oAdmin.CodigoRegistro = _EmpNumero.ToString();
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "TEL_CODIGO_REGISTRO&";
            oAdmin.FiltroValores = _EmpNumero.ToString() + "&";
            FormsAuxiliares.frmFormAdminMini oFrmAdminMini = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            if (oFrmAdminMini.ShowDialog() == DialogResult.OK)
            {
                string id = oFrmAdminMini.striRdoCodigo;
                _oClientesCrud.CargarTelefono(_EmpNumero,"CLIE");
            }
        }


        private void EditarTelefono() {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.Tipo = Admin.enumTipoForm.FiltroAndEditar;
            oAdmin.TabCodigo = "TETE";
            oAdmin.CodigoRegistro = _EmpNumero.ToString();
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "TEL_CODIGO_REGISTRO&";
            oAdmin.FiltroValores = _EmpNumero.ToString() + "&";
            FormsAuxiliares.frmFormAdminMini oFrmAdminMini = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            if (oFrmAdminMini.ShowDialog() == DialogResult.OK)
            {
                string id = oFrmAdminMini.striRdoCodigo;
                _oClientesCrud.CargarTelefono(_EmpNumero, "CLIE");
            }
        }

        private void NuevoEmail()
        {

            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.Tipo = Admin.enumTipoForm.FiltroAndAlta;
            oAdmin.TabCodigo = "TEEM";
            oAdmin.CodigoRegistro = _EmpNumero.ToString();
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "TEL_CODIGO_REGISTRO&";
            oAdmin.FiltroValores = _EmpNumero.ToString() + "&";
            FormsAuxiliares.frmFormAdminMini oFrmAdminMini = new FormsAuxiliares.frmFormAdminMini(oAdmin, oPermiso);
            if (oFrmAdminMini.ShowDialog() == DialogResult.OK)
            {
                string id = oFrmAdminMini.striRdoCodigo;
                _oClientesCrud.CargarTelefono(_EmpNumero, "CLIE");
            }

        }

    }
}
