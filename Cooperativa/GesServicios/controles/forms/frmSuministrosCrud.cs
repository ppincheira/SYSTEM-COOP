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

        long _SumNumero, _MedNumero, _OrdenRuta;
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
            get { return string.IsNullOrEmpty(txtOrdenRuta.Text) ? 0 :  long.Parse(txtOrdenRuta.Text); }
            set { txtOrdenRuta.Text = value.ToString(); }
        }

        public long EmpNumero
        {
            get { return long.Parse(txtEmpNumero.Text); }
            set { txtEmpNumero.Text = value.ToString(); }
        }

        public DateTime FechaAlta
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
            get { return this.txtConsumoEstimado.Text != "" ? float.Parse(this.txtConsumoEstimado.Text) : 0; }
            set { this.txtConsumoEstimado.Text = value.ToString(); }
        }

        public long? Voltaje
        {
            get { return string.IsNullOrEmpty(txtVoltaje.Text) ? 0 : long.Parse(txtVoltaje.Text); }
            set { this.txtVoltaje.Text = value.ToString(); }
        }
        public string Conexion
        {
            get { return this.chkConexion.Checked ? "S" : "N"; }
            set { this.chkConexion.Checked = (value == "S"); }
        }

        public double? PotenciaL1
        {
            get { return txtPotenciaL1.Text != "" ? double.Parse(txtPotenciaL1.Text) : 0; }
            set { txtPotenciaL1.Text = value.ToString(); }
        }

        public double? PotenciaL2
        {
            get { return txtPotenciaL2.Text != "" ? double.Parse(txtPotenciaL2.Text) : 0; }
            set { txtPotenciaL2.Text = value.ToString(); }
        }

        public double? PotenciaL3
        {
            get { return txtPotenciaL3.Text != "" ? double.Parse(txtPotenciaL3.Text) : 0; }
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
        public long numMedidor
        {
            get { return _MedNumero; }
            set { _MedNumero = value; }
        }
        public long numSerieMedidor
        {
            get { return long.Parse(txtMedNumeroSerie.Text); }
            set { txtMedNumeroSerie.Text = value.ToString(); }
        }
        public string strModeloMedidor
        {
            get { return this.txtMedidorModelo.Text; }
            set { this.txtMedidorModelo.Text=value; }
        }
         public string strTipoMedidor
        {
            get { return this.txtTipoMedidor.Text; }
            set { this.txtTipoMedidor.Text=value; }
        }
        public string strFabricante
        {
            get { return this.txtFabricanteMedidor.Text; }
            set { this.txtFabricanteMedidor.Text=value; }
        }
        public string strLecturaModo
        {
            get { return this.txtLecturaModoMedidor.Text; }
            set { this.txtLecturaModoMedidor.Text=value; }
        }
        #endregion
        public frmSuministrosCrud(long Suministro, string Estado)
        {
            _SumNumero = Suministro;
            _EstCodigo = Estado;
            //_usrNumero = Usuario;
            _oSuministrosCrud = new UISuministrosCrud(this);
            _OrdenRuta = 0;
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
                oUtil.ValidarFormularioEP(this, this, 40);
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
            oAdmin.FiltroCampos = "e.emp_cliente&";
            oAdmin.FiltroOperador = "1&";
            oAdmin.FiltroValores = "S&";
            frmFormAdmin frmbus = new frmFormAdmin(oAdmin, oPermiso);
            if (frmbus.ShowDialog() == DialogResult.OK)
            {
                string id = frmbus.striRdoCodigo;

                _oSuministrosCrud.CargarCliente(long.Parse(id));
            }
        }

        private void btnMedidor_Click(object sender, EventArgs e)
        {
            Medidores oMedidor = new Medidores();
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10100", "10101", "10102", "10104", "10105", "10103");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "MED";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            oAdmin.CodigoRegistro = _SumNumero.ToString();
            oAdmin.CodigoEditar = _MedNumero.ToString();
            oAdmin.TabCodigoRegistro = "SUM";
            oAdmin.FiltroCampos = "TCS_DESCRIPCION&";
            oAdmin.FiltroOperador = "1&";
            oAdmin.FiltroValores = cmbTipoConexion.Text + "&";
            oAdmin.TabCodigo = "MED";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            frmFormAdmin frmbus = new frmFormAdmin(oAdmin, oPermiso);
            if (frmbus.ShowDialog() == DialogResult.OK)
            {
                string medidor = frmbus.striRdoCodigo;

                _oSuministrosCrud.CargarMedidor(long.Parse(medidor));
            }

        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            Domicilios oDomicilio = new Domicilios();
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "DOMB";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            oAdmin.CodigoRegistro = txtEmpNumero.Text;
            oAdmin.TabCodigoRegistro = "CLIE";
            oAdmin.FiltroCampos = "DE.DEN_CODIGO_REGISTRO&";
            oAdmin.FiltroOperador = "1&";
            oAdmin.FiltroValores = txtEmpNumero.Text + "&";
            FormsAuxiliares.frmFormAdmin oFrmAdminMini = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            if (oFrmAdminMini.ShowDialog() == DialogResult.OK)
            {
                string id = oFrmAdminMini.striRdoCodigo;
                oDomicilio = _oSuministrosCrud.CargarDomicilioSum(long.Parse(id));
                if (oDomicilio.DomCodigo != 0)
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
            _oSuministrosCrud.CargarTiposConexiones();
        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZona.SelectedIndex > 0)
            {
                cmbRuta.Enabled = true;
                _oSuministrosCrud.CargarRutas();
            }
           else
                cmbRuta.Enabled = false;

        }

        private void cmbTipoConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoConexion.SelectedIndex > 0)
                btnMedidor.Enabled = true;
            else
                btnMedidor.Enabled = false;
        }

        private void cmbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtOrdenRuta.Enabled=true;
        }
    }

}
