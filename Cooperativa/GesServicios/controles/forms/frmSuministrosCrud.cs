using AppProcesos.gesServicios.frmSuministrosCrud;
using Controles.datos;
using Controles.form;
using Model;
using Service;
using System;
using System.Windows.Forms;
using FormsAuxiliares;
using Business;

namespace GesServicios.controles.forms
{
    public partial class frmSuministrosCrud : gesForm, IVistaSuministrosCrud
    {
        #region << PROPIEDADES >>

        UISuministrosCrud _oSuministrosCrud;
        Utility oUtil;

        long _SumNumero;
        string _EstCodigo;

        #endregion
        #region Implementation of IVistaRutasCrud


        public long Numero
        {
            get { return _SumNumero; }
            set { _SumNumero = value; }
        }
        public cmbLista Servicio
        {
            get { return this.cmbServicio; }
            set { this.cmbServicio = value; }
        }

        public cmbLista TipoConexion
        {
            get { return this.cmbTipoConexion; }
            set { this.cmbTipoConexion = value; }
        }

        public cmbLista Categoria
        {
            get { return cmbCategoria; }
            set { cmbCategoria = value; }
        }

        public long? OrdenRuta
        {
            get { return long.Parse(txtOrdenRuta.Text); }
            set { txtOrdenRuta.Text = value.ToString(); }
        }

        public long EmpNumero
        {
            get { return long.Parse(txtEmpNumero.Text); }
            set { txtEmpNumero.Text = value.ToString(); }
        }

        public DateTime? FechaAlta
        {
            get { return DateTime.Parse(dtpFechaAlta.Text); }
            set { dtpFechaAlta.Text = value.ToString(); }
        }

        public string EstCodigo
        {
            get { return this.chkEstado.Checked ? "H" : "I"; }
            set { this.chkEstado.Checked = (value == "H"); }
        }

        public float? ConsumoEstimado
        {
            get { return long.Parse(this.txtConsumoEstimado.Text); }
            set { this.txtConsumoEstimado.Text = value.ToString(); }
        }

        public long? Voltaje
        {
            get { return long.Parse(this.txtVoltaje.Text); }
            set { this.txtVoltaje.Text = value.ToString(); }
        }
        public string Conexion
        {
            get { return this.chkConexion.Checked ? "S" : "N"; }
            set { this.chkConexion.Checked = (value == "S"); }
        }

        public double? PotenciaL1
        {
            get { return double.Parse(txtPotenciaL1.Text); }
            set { txtPotenciaL1.Text = value.ToString(); }
        }

        public double? PotenciaL2
        {
            get { return double.Parse(txtPotenciaL2.Text); }
            set { txtPotenciaL2.Text = value.ToString(); }
        }

        public double? PotenciaL3
        {
            get { return double.Parse(txtPotenciaL3.Text); }
            set { txtPotenciaL3.Text = value.ToString(); }
        }

        public string PermiteCorte
        {
            get { return this.chkPermiteCorte.Checked ? "S" : "N"; }
            set { this.chkPermiteCorte.Checked = (value == "S"); }
        }

        public string Medido
        {
            get { return this.chkMedido.Checked ? "S" : "N"; }
            set { this.chkMedido.Checked = (value == "S"); }
        }

        public cmbLista Ruta
        {
            get { return cmbRuta; }
            set { cmbRuta = value; }
        }

        public cmbLista Zona
        {
            get { return cmbZona; }
            set { cmbZona = value; }
        }

        public string PermiteFactura
        {
            get { return this.chkPermiteFacturacion.Checked ? "S" : "N"; }
            set { this.chkPermiteFacturacion.Checked = (value == "S"); }
        }

        public DateTime FechaCarga
        {
            get { return DateTime.Parse(dtpFechaAlta.Text); }
            set { dtpFechaAlta.Text = value.ToString(); }
        }
        public string strRazonSocial
        {
            get { return this.txtEmpRazonSocial.Text; }
            set { this.txtEmpRazonSocial.Text=value; }
        }
        public string strDomicilioEmpresa
        {
            get { return this.txtDomicilioEmpresa.Text; }
            set { this.txtDomicilioEmpresa.Text=value; }
        }
        public string strRespIva
        {
            get { return this.txtRespIva.Text; }
            set { this.txtRespIva.Text=value; }
        }
         public string strTipoDoc
        {
            get { return this.txtTipoDoc.Text; }
            set { this.txtTipoDoc.Text=value; }
        }
        public string strEmpDocumentoNumero
        {
            get { return this.txtEmpDocumentoNumero.Text; }
            set { this.txtEmpDocumentoNumero.Text=value; }
        }
        public long numSocio
        {
            get { return long.Parse(txtSocio.Text); }
            set { txtSocio.Text = value.ToString(); }
        }
        #endregion
        public frmSuministrosCrud(long Suministro, string Estado)
        {
            _SumNumero = Numero;
            _EstCodigo = Estado;
            //_usrNumero = Usuario;
            _oSuministrosCrud = new UISuministrosCrud(this);
            InitializeComponent();
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
                    _oSuministrosCrud.Guardar();
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

        private void frmSuministrosCrud_Load(object sender, EventArgs e)
        {
            //Debo cargar primero el servicio que voy a dar, luego el cliente
            //y luego el domicilio asociado a ese suministro. 
            //El domicilio en un principio se muestrn los asociados a ese cliente 
            //pero con la opcion de poder agregar uno nuevo
            {
                try
                {
                    oUtil = new Utility();
                    _oSuministrosCrud.Inicializar();
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("100047", "100048", "100049", "0", "0", "100050");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "CLIE";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;

            frmFormAdmin frmbus = new frmFormAdmin(oAdmin, oPermiso);
            if (frmbus.ShowDialog() == DialogResult.OK)
            {
                string id = frmbus.striRdoCodigo;

                _oSuministrosCrud.CargarCliente(long.Parse(id));
            }
        }

        private void btnMedidor_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10100", "10101", "10102", "10104", "10105", "10103");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "MED";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            frmFormAdminMini frmbus = new frmFormAdminMini(oAdmin, oPermiso);
            if (frmbus.ShowDialog() == DialogResult.OK)
            {
                string nombre = frmbus.striRdoCodigo;
            }

        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            Domicilios oDomicilio = new Domicilios();
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "DOMB";
            oAdmin.Tipo = Admin.enumTipoForm.FiltroAndAlta;
            oAdmin.CodigoRegistro = txtEmpNumero.Text;
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "DE.DEN_CODIGO_REGISTRO&";
            oAdmin.FiltroValores = txtEmpNumero.Text + "&";
            FormsAuxiliares.frmFormAdmin oFrmAdminMini = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            if (oFrmAdminMini.ShowDialog() == DialogResult.OK)
            {
                string id = oFrmAdminMini.striRdoCodigo;
                oDomicilio = _oSuministrosCrud.CargarDomicilioSum(long.Parse(txtEmpNumero.Text), "CLIE");
                if (oDomicilio.DomCodigo != 0 && oDomicilio.DomCodigo != null)
                {
                    txtDomCodigo.Text = oDomicilio.DomCodigo.ToString();
                    CallesLocalidadesBus oCalleBus = new CallesLocalidadesBus();
                    txtCalle.Text = oCalleBus.CallesLocalidadesGetById(oDomicilio.CalNumero).CalDescripcion;
                    txtCalleNumero.Text = oDomicilio.DomNumero.ToString();
                    txtDepartamento.Text = oDomicilio.DomDepartamento.ToString();
                    txtBloque.Text = oDomicilio.DomBloque.ToString();
                    txtPiso.Text = oDomicilio.DomPiso.ToString();
                }

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

        private void cmbServicio_Leave(object sender, EventArgs e)
        {
            _oSuministrosCrud.CargarCategorias();
        }
    }

}
