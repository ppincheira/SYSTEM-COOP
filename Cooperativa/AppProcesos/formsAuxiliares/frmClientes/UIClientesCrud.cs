using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProcesos.formsAuxiliares.frmClientes
{
    public class UIClientesCrud
    {

        private IVistaClientesCrud _vista;
        Utility oUtil;


        public UIClientesCrud(IVistaClientesCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void ObtenerId(long empNumero)
        {
            if (empNumero == 0)
            {
                EmpresasBus oEmpBus = new EmpresasBus();
                _vista.empNumero = oEmpBus.EmpresasGetID();
            }
        }

        public void Inicializar(long empNumero, Enumeration.Acciones oAccion )
        {
            CargarTipoIva();
            CargarEstadoCredito();
            CargarTiposDni();
            CargarDistritos();
            _vista.lgCodigoDomicilio = 0;
            _vista.lgCodigoEmail = 0;
            _vista.lgCodigoTelefono = 0;
            _vista.lgCodigoObservacion = 0;
            _vista.btniEmail.BackColor = System.Drawing.Color.Gray;
            _vista.btniTelefono.BackColor = System.Drawing.Color.Gray;
            _vista.btniDomicilio.BackColor = System.Drawing.Color.Gray;
            if (oAccion !=Enumeration.Acciones.New)
            {
                EmpresasBus oEmpBus = new EmpresasBus();
                Empresas oEmpresa = new Empresas();
                oEmpresa = oEmpBus.EmpresasGetById(empNumero);
                _vista.cmbiEstadoCredito.SelectedValue = oEmpresa.EstCodigoCredito;
                _vista.cmbiTipoDocumento.SelectedValue = oEmpresa.TidCodigo;
                _vista.cmbiTipoIva.SelectedValue = oEmpresa.TivCodigo;
                _vista.dblLimiteCredito = oEmpresa.EmpLimiteCredito;
                _vista.dtpiFechaAlta.Value = oEmpresa.EmpFechaAlta.Value;
                _vista.dtpiFechaAltaCli.Value = oEmpresa.EmpFechaAltaCli.Value;
                _vista.dtpiFechaAltaPro.Value = oEmpresa.EmpFechaAltaPro;
                if (_vista.dtpiFechaBajaCli.Checked)
                    _vista.dtpiFechaBajaCli.Value = oEmpresa.EmpFechaBajaCli.Value;
                else
                    _vista.dtpiFechaBajaCli.Value = DateTime.FromOADate(0);

                if (_vista.dtpiFechaBajaPro.Checked)
                    _vista.dtpiFechaBajaPro.Value = oEmpresa.EmpFechaBajaPro.Value;
                else
                    _vista.dtpiFechaBajaPro.Value= DateTime.FromOADate(0);

                EsSocio_Carga(empNumero);
                _vista.empNumero = empNumero;
                _vista.intNumeroTransporte = oEmpresa.EmpNumeroTransporte;
                _vista.strApellido = oEmpresa.EmpApellidos;
                _vista.strCategoriaMonotributo = oEmpresa.EmpCategoriaMonotributo;
                _vista.strCliente = oEmpresa.EmpCliente;
                _vista.strCuit = oEmpresa.EmpCuit;
                _vista.strDenominacionComercial = oEmpresa.EmpDenominacionComercial;
                CargarDomicilio(empNumero, "CLIE");
                CargarTelefono(empNumero, "CLIE");
                CargarEmail(empNumero, "CLIE");
                CargarObservaciones(empNumero, "CLIE");
                _vista.strNombre = oEmpresa.EmpNombres;
                _vista.strNroDocumento = oEmpresa.EmpDocumentoNumero;
                _vista.strPropia = oEmpresa.EmpPropia;
                _vista.strProveedor = oEmpresa.EmpProveedor;
                _vista.strRazonSocial = oEmpresa.EmpRazonSocial;
                _vista.strTitularCheques = oEmpresa.EmpTitularCheques;

            }
        }

        public void FechaBajaCliente(bool estado) {

            if (estado)
            {
                _vista.dtpiFechaBajaCli.Format = DateTimePickerFormat.Custom;
                _vista.dtpiFechaBajaCli.CustomFormat = "dd/MM/yyyy";
                _vista.dtpiFechaBajaCli.Value = DateTime.Now;
                _vista.dtpiFechaBajaCli.Enabled = true;
            }
            else
            {
                _vista.dtpiFechaBajaCli.Format = DateTimePickerFormat.Custom;
                _vista.dtpiFechaBajaCli.CustomFormat = " ";
                _vista.dtpiFechaBajaCli.Value = DateTime.FromOADate(0);
                _vista.dtpiFechaBajaCli.Enabled = false;
                _vista.dtpiFechaBajaCli.Checked = false;
            }
        }


        public void FechaBajaProveedor(bool estado)
        {

            if (estado)
            {
                _vista.dtpiFechaBajaPro.Format = DateTimePickerFormat.Custom;
                _vista.dtpiFechaBajaPro.CustomFormat = "dd/MM/yyyy";
                _vista.dtpiFechaBajaPro.Value = DateTime.Now;
                _vista.dtpiFechaBajaPro.Enabled = true;
            }
            else
            {
                _vista.dtpiFechaBajaPro.Format = DateTimePickerFormat.Custom;
                _vista.dtpiFechaBajaPro.CustomFormat = " ";
                _vista.dtpiFechaBajaPro.Value = DateTime.FromOADate(0);
                _vista.dtpiFechaBajaPro.Enabled = false;
                _vista.dtpiFechaBajaPro.Checked = false;
            }
        }



        public void FechaBajaAccionista(bool estado)
        {

            if (estado)
            {
                _vista.dtpiFechaBajaAccionista.Format = DateTimePickerFormat.Custom;
                _vista.dtpiFechaBajaAccionista.CustomFormat = "dd/MM/yyyy";
                _vista.dtpiFechaBajaAccionista.Value = DateTime.Now;
                _vista.dtpiFechaBajaAccionista.Enabled = true;
              
            }
            else
            {
                _vista.dtpiFechaBajaAccionista.Format = DateTimePickerFormat.Custom;
                _vista.dtpiFechaBajaAccionista.CustomFormat = " ";
                _vista.dtpiFechaBajaAccionista.Value = DateTime.FromOADate(0);
                _vista.dtpiFechaBajaAccionista.Enabled = false;
                _vista.dtpiFechaBajaAccionista.Checked = false;
               
            }
        }

        private void EsSocio_Carga(long EmpNumero)
        {
            AccionistasBus oAccionistaBus = new AccionistasBus();
            Accionistas oAccionista = new Accionistas();
            oAccionista = oAccionistaBus.AccionistasGetByEmpNumero(EmpNumero);
            if (oAccionista.DisNumero != 0) {
                _vista.strEsSocio = "S";
                _vista.dtpiFechaAltaAccionista.Value = oAccionista.AccFechaAlta.Value;
                _vista.cmbiDistrito.SelectedValue = oAccionista.DisNumero;
                _vista.lgAccNumero = oAccionista.AccNumero;   
            }
        }
        public void CargarEmail(long CodigoRegistro, string TabCodigo)
        {
            Telefonos oTelefono = new Telefonos();
            TelefonosBus oTelefonoBus = new TelefonosBus();

            oTelefono = oTelefonoBus.TelefonosGetByCodigoRegistroDefecto(CodigoRegistro, TabCodigo, Enumeration.TelefonosTipos.Email);
            _vista.lgCodigoEmail = oTelefono.TelCodigo;
            Dominios oDominio = new Dominios();
            DominiosBus oDomBus = new DominiosBus();
            oDominio = oDomBus.DominiosGetById("CARGO_CONTACTO_TEL", oTelefono.TelCargo);
            DataTable dtEmail = new DataTable();
            dtEmail = oTelefonoBus.TelefonosGetByCodigoRegistroDT(CodigoRegistro, TabCodigo, Enumeration.TelefonosTipos.Email);
            _vista.strEmail = oTelefono.TelEmail+" - "+oDominio.DmnDescripcion ;
            _vista.btniEmail.Text = "...[" + dtEmail.Rows.Count + "]";
            if (dtEmail.Rows.Count > 1)
                _vista.btniEmail.BackColor = System.Drawing.Color.Green;
            else
                _vista.btniEmail.BackColor = System.Drawing.Color.Gray;

        }

        public void CargarDomicilio(long CodigoRegistro,string tabCodigo)
        {
            DomiciliosBus oDomicilioBus = new DomiciliosBus();
            Domicilios oDomicilio = new Domicilios();
            oDomicilio = oDomicilioBus.DomiciliosGetByCodigoRegistroDefecto(CodigoRegistro, tabCodigo);
            if (oDomicilio.DomCodigo != 0){ 
            CallesLocalidadesBus oCalleBus = new CallesLocalidadesBus();
            _vista.strDomicilio = oCalleBus.CallesLocalidadesGetById(oDomicilio.CalNumero).CalDescripcion + " Nro.: " + oDomicilio.DomNumero + " "
                + " Dpto:" + oDomicilio.DomDepartamento;
            }
            _vista.lgCodigoDomicilio = oDomicilio.DomCodigo;
            DataTable dtDomicilio = new DataTable();
            dtDomicilio = oDomicilioBus.DomiciliosGetByCodigoRegistroDT(CodigoRegistro, tabCodigo);
            _vista.btniDomicilio.Text = "...[" + dtDomicilio.Rows.Count + "]";
            if (dtDomicilio.Rows.Count > 1)
                _vista.btniDomicilio.BackColor = System.Drawing.Color.Green;
            else
                _vista.btniDomicilio.BackColor = System.Drawing.Color.Gray;
        }

        public void CargarTelefono(long CodigoRegistro, string TabCodigo)
        {
            Telefonos oTelefono = new Telefonos();
            TelefonosBus oTelefonoBus = new TelefonosBus();
            
            oTelefono = oTelefonoBus.TelefonosGetByCodigoRegistroDefecto(CodigoRegistro, TabCodigo, Enumeration.TelefonosTipos.Telefono);
            _vista.lgCodigoTelefono = oTelefono.TelCodigo;
            Dominios oDominio = new Dominios();
            DominiosBus oDomBus = new DominiosBus();
            oDominio = oDomBus.DominiosGetById("CARGO_CONTACTO_TEL", oTelefono.TelCargo);
            _vista.strTelefono = oTelefono.TelNumero + " - " +oDominio.DmnDescripcion  ;
            DataTable dtTelefono = new DataTable();
            dtTelefono = oTelefonoBus.TelefonosGetByCodigoRegistroDT(CodigoRegistro, TabCodigo, Enumeration.TelefonosTipos.Telefono);
            _vista.btniTelefono.Text = "...[" + dtTelefono.Rows.Count + "]";
            if (dtTelefono.Rows.Count > 1)
                _vista.btniTelefono.BackColor = System.Drawing.Color.Green;
            else
                _vista.btniTelefono.BackColor = System.Drawing.Color.Gray;

        }

        public void CargarObservaciones(long CodigoRegistro, string TabCodigo)
        {
            ObservacionesBus oObsBus = new ObservacionesBus();
            Observaciones oObs = new Observaciones();
            oObs = oObsBus.ObservacionesGetByCodigoRegistroDefecto(CodigoRegistro, TabCodigo);
            _vista.strObservacion = oObs.ObsDetalle;
        }


        private void CargarTipoIva()
        {
            TiposIvaBus oTipoIvaBus = new TiposIvaBus();
            oUtil.CargarCombo(_vista.cmbiTipoIva, oTipoIvaBus.TiposIvaGetAllDT(), "TIV_CODIGO", "TIV_DESCRIPCION", "SELECCIONE..");
        }

        private void CargarEstadoCredito()
        {
            EstadosBus oEstadoBus = new EstadosBus();
            oUtil.CargarCombo(_vista.cmbiEstadoCredito, oEstadoBus.EstadosGetByFilterDT("EMPRESAS", "EST_CODIGO_CREDITO"), "EST_CODIGO", "EST_DESCRIPCION", "SELECCIONE.."); 
        }
        private void CargarDistritos()
        {
            DistritosBus oDistritoBus = new DistritosBus();
            oUtil.CargarCombo(_vista.cmbiDistrito,oDistritoBus.DistritosGetAllDT(),"DIS_NUMERO","DIS_DESCRIPCION","SELECCIONE DISTRITO");
        }

        private void CargarTiposDni()
        {
            TiposIdentificadoresBus oTipoIdentificadoresBus = new TiposIdentificadoresBus();
            oUtil.CargarCombo(_vista.cmbiTipoDocumento, oTipoIdentificadoresBus.TiposIdentificadoresGetAllDT(), "tid_codigo", "tid_descripcion", "..");
        }

        public void Guardar(Enumeration.Acciones oAccion)
        {
            Empresas oEmpresa = new Empresas();
            EmpresasBus oEmpresaBus = new EmpresasBus();
            oEmpresa.EmpApellidos = _vista.strApellido;
            oEmpresa.EmpCategoriaMonotributo = _vista.strCategoriaMonotributo;
            oEmpresa.EmpCliente = _vista.strCliente;
            oEmpresa.EmpCuit = _vista.strCuit;
            oEmpresa.EmpDenominacionComercial = _vista.strDenominacionComercial;
            oEmpresa.EmpDocumentoNumero = _vista.strNroDocumento;
            oEmpresa.EmpFechaAlta = _vista.dtpiFechaAlta.Value;
            oEmpresa.EmpFechaAltaCli = _vista.dtpiFechaAltaCli.Value;
            oEmpresa.EmpFechaAltaPro = _vista.dtpiFechaAltaPro.Value;
            if (_vista.dtpiFechaBajaCli.Checked)
                oEmpresa.EmpFechaBajaCli = _vista.dtpiFechaBajaCli.Value;
            if (_vista.dtpiFechaBajaPro.Checked)
                oEmpresa.EmpFechaBajaPro = _vista.dtpiFechaBajaPro.Value;
            oEmpresa.EmpLimiteCredito = _vista.dblLimiteCredito;
            oEmpresa.EmpNombres = _vista.strNombre;
            oEmpresa.EmpNumero = _vista.empNumero;
            oEmpresa.EmpNumeroTransporte = _vista.intNumeroTransporte;
            oEmpresa.EmpObservacion = _vista.strObservacion;
            oEmpresa.EmpPropia = _vista.strPropia;
            oEmpresa.EmpProveedor = _vista.strProveedor;
            oEmpresa.EmpRazonSocial = _vista.strRazonSocial;
            oEmpresa.EmpTitularCheques = _vista.strTitularCheques;
            oEmpresa.EstCodigoCli = "";
            oEmpresa.EstCodigoCredito = _vista.cmbiEstadoCredito.SelectedValue.ToString();
            oEmpresa.EstCodigoPro = "";
            oEmpresa.PrsNumero = 1;//falta definir
            oEmpresa.TidCodigo = _vista.cmbiTipoDocumento.SelectedValue.ToString();
            oEmpresa.TivCodigo = _vista.cmbiTipoIva.SelectedValue.ToString();
            oEmpresa.UsrNumeroCarga = 1;//Falta definir
            if (oAccion == Enumeration.Acciones.New)
                oEmpresaBus.EmpresasAdd(oEmpresa);
            else
                oEmpresaBus.EmpresasUpdate(oEmpresa);

            if (_vista.strEsSocio == "S")
            {

                if (int.Parse(_vista.cmbiDistrito.SelectedValue.ToString()) > 0)
                {

                    Accionistas oAccionista = new Accionistas();
                    AccionistasBus oAccionistasBus = new AccionistasBus();
                    oAccionista.AccFechaAlta = _vista.dtpiFechaAltaAccionista.Value;
                    oAccionista.DisNumero = long.Parse(_vista.cmbiDistrito.SelectedValue.ToString());
                    oAccionista.EstCodigo = "H";
                    oAccionista.EmpNumero = _vista.empNumero;
                    if (_vista.dtpiFechaBajaAccionista.Checked)
                        oAccionista.AccFechaBaja = _vista.dtpiFechaBajaAccionista.Value;
                    if (_vista.lgAccNumero != 0)
                        oAccionistasBus.AccionistasUpdate(oAccionista);
                    else
                        _vista.lgAccNumero = oAccionistasBus.AccionistasAdd(oAccionista);
                }
            }
        }



    }
}
