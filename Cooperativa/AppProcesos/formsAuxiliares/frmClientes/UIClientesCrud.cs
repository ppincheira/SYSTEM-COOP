using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _vista.lgCodigoDomicilio = 0;
            _vista.lgCodigoEmail = 0;
            _vista.lgCodigoTelefono = 0;
            _vista.lgCodigoObservacion = 0;
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
                _vista.dtpiFechaBajaCli.Value = oEmpresa.EmpFechaBajaCli.Value;
                _vista.dtpiFechaBajaPro.Value = oEmpresa.EmpFechaBajaPro.Value;
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

        



        public void CargarEmail(long CodigoRegistro, string TabCodigo)
        {
            Telefonos oTelefono = new Telefonos();
            TelefonosBus oTelefonoBus = new TelefonosBus();

            oTelefono = oTelefonoBus.TelefonosGetByCodigoRegistroDefecto(CodigoRegistro, TabCodigo, Enumeration.TelefonosTipos.Email);
            Dominios oDominio = new Dominios();
            DominiosBus oDomBus = new DominiosBus();
            oDominio = oDomBus.DominiosGetById("CARGO_CONTACTO_TEL", oTelefono.TelCargo);
      
            _vista.strEmail = oTelefono.TelEmail+" - "+oDominio.DmnDescripcion ;
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
        }

        public void CargarTelefono(long CodigoRegistro, string TabCodigo)
        {
            Telefonos oTelefono = new Telefonos();
            TelefonosBus oTelefonoBus = new TelefonosBus();

            oTelefono = oTelefonoBus.TelefonosGetByCodigoRegistroDefecto(CodigoRegistro, TabCodigo, Enumeration.TelefonosTipos.Telefono);
            Dominios oDominio = new Dominios();
            DominiosBus oDomBus = new DominiosBus();
            oDominio = oDomBus.DominiosGetById("CARGO_CONTACTO_TEL", oTelefono.TelCargo);
            _vista.strTelefono = oTelefono.TelNumero + " - " +oDominio.DmnDescripcion  ;
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
        
        private void CargarTiposDni()
        {
            TiposIdentificadoresBus oTipoIdentificadoresBus = new TiposIdentificadoresBus();
            oUtil.CargarCombo(_vista.cmbiTipoDocumento, oTipoIdentificadoresBus.TiposIdentificadoresGetAllDT(), "tid_codigo", "tid_descripcion", "..");
        }

        public void Guardar()
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
            oEmpresa.EmpFechaBajaCli = _vista.dtpiFechaBajaCli.Value;
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
            oEmpresaBus.EmpresasAdd(oEmpresa);
        }

    }
}
