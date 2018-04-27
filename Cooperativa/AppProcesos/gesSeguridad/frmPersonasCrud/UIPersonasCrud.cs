using Business;
using Model;
using Service;
using System.Windows.Forms;
using System;

namespace AppProcesos.gesSeguridad.frmPersonasCrud
{
    public class UIPersonasCrud
    {
        private IVistaPersonasCrud _vista;
        Utility oUtil;

        public UIPersonasCrud(IVistaPersonasCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }
        public void Inicializar()
        {
            ProvinciasBus oProvinciasBus = new ProvinciasBus();
            oUtil.CargarCombo(_vista.cmbPrsProvincia, oProvinciasBus.ProvinciasGetByFilter("ARG"), "PRV_CODIGO", "PRV_DESCRIPCION", "Seleccione Provincia");
            _vista.cmbPrsProvincia.SelectedValue = "NQ";
            LocalidadesBus oLocalidadesBus = new LocalidadesBus();          
            oUtil.CargarCombo(_vista.cmbPrsLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(_vista.cmbPrsProvincia.SelectedValue.ToString()), "LOC_NUMERO", "LOC_DESCRIPCION", "Seleccione Localidad");

            DominiosBus oDonBus = new DominiosBus();
            oUtil.CargarCombo(_vista.cmbPrsCivil, oDonBus.DominiosGetByFilter("ESTADO_CIVIL_PER"), "dmn_valor", "dmn_descripcion", "Seleccione Estado");
            oUtil.CargarCombo(_vista.cmbPrsSexo, oDonBus.DominiosGetByFilter("SEXO_PER"), "dmn_valor", "dmn_descripcion", "Seleccione Sexo");                        
            oUtil.CargarCombo(_vista.cmbPrsCargo, oDonBus.DominiosGetByFilter("CARGO_PER"), "dmn_valor", "dmn_descripcion", "Seleccione Cargo");
            oUtil.CargarCombo(_vista.cmbPrsBaja, oDonBus.DominiosGetByFilter("MOTIVO_BAJA_PER"), "dmn_valor", "dmn_descripcion", "Seleccione Motivo");        
            TiposIdentificadoresBus oTiIBus = new TiposIdentificadoresBus();
            oUtil.CargarCombo(_vista.cmbPrsTpoDni, oTiIBus.TiposIdentificadoresGetByFilter(), "tid_codigo", "tid_descripcion", "Seleccione un Tipo");

            if (_vista.logPrsNumero != 0)
            {
                Personas oPersonas = new Personas();
                PersonasBus oPersonasBus = new PersonasBus();

                oPersonas = oPersonasBus.PersonasGetById(_vista.logPrsNumero);
                _vista.cmbPrsCivil.SelectedValue = oPersonas.PrsEstadoCivil;
                _vista.cmbPrsSexo.SelectedValue = oPersonas.PrsSexo;
                if (!string.IsNullOrEmpty(oPersonas.PrsCargo))
                    _vista.cmbPrsCargo.SelectedValue = oPersonas.PrsCargo;                
                if (!string.IsNullOrEmpty(oPersonas.PrsMotivoBaja))
                    _vista.cmbPrsBaja.SelectedValue = oPersonas.PrsMotivoBaja;
                if (!string.IsNullOrEmpty(oPersonas.LocNumeroNacimiento.ToString()))
                {                                      
                    Localidades oLocalidades = new Localidades();                 
                    oLocalidades = oLocalidadesBus.LocalidadesGetById(int.Parse(oPersonas.LocNumeroNacimiento.ToString()));
                    _vista.cmbPrsProvincia.SelectedValue = oLocalidades.PrvCodigo;
                    oUtil.CargarCombo(_vista.cmbPrsLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(oLocalidades.PrvCodigo), "LOC_NUMERO", "LOC_DESCRIPCION", "Seleccione Localidad");                    
                    _vista.cmbPrsLocalidad.SelectedValue = oPersonas.LocNumeroNacimiento;                    
                }                    
                _vista.cmbPrsTpoDni.SelectedValue = oPersonas.PrsTipoDoc;
                _vista.strPrsApellido = oPersonas.PrsApellido;
                _vista.strPrsNombre = oPersonas.PrsNombre;
                _vista.strPrsNroDocumento = oPersonas.PrsNumeroDoc;
                _vista.datPrsNacimiento = oPersonas.PrsFechaNacimiento;
                _vista.datPrsIngreso = oPersonas.PrsFechaIngreso;
                _vista.datPrsBaja = oPersonas.PrsFechaBaja;
                _vista.strPrsLegajo = oPersonas.PrsLegajo;
                _vista.strPrsCuil = oPersonas.PrsCuil;
                if (oPersonas.EstCodigo == "H")
                    _vista.booPrsEstado = true;
                else
                    _vista.booPrsEstado = false;               
            }
            else
                _vista.booPrsEstado = true; ;
        }

        public void CambioProvincia()
        {            
            LocalidadesBus oLocalidadesBus = new LocalidadesBus();
            oUtil.CargarCombo(_vista.cmbPrsLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(_vista.cmbPrsProvincia.SelectedValue.ToString()), "LOC_NUMERO", "LOC_DESCRIPCION", "Seleccione Localidad");
        }

        public long Guardar()
        {
            long logResultado;
            Personas oPersonas = new Personas();
            PersonasBus oPersonasBus = new PersonasBus();

            oPersonas.PrsEstadoCivil = _vista.cmbPrsCivil.SelectedValue.ToString();
            oPersonas.PrsSexo =_vista.cmbPrsSexo.SelectedValue.ToString();

            if (_vista.cmbPrsCargo.SelectedValue.ToString() != "0")
                oPersonas.PrsCargo = _vista.cmbPrsCargo.SelectedValue.ToString();

            if (_vista.cmbPrsBaja.SelectedValue.ToString() != "0")
                oPersonas.PrsMotivoBaja = _vista.cmbPrsBaja.SelectedValue.ToString();

            oPersonas.PrsTipoDoc =_vista.cmbPrsTpoDni.SelectedValue.ToString();            
            oPersonas.PrsNumero = _vista.logPrsNumero;
            oPersonas.PrsApellido = _vista.strPrsApellido;
            oPersonas.PrsNombre = _vista.strPrsNombre;
            oPersonas.PrsNumeroDoc = _vista.strPrsNroDocumento;
            oPersonas.PrsFechaNacimiento = _vista.datPrsNacimiento;
            oPersonas.PrsFechaIngreso = _vista.datPrsIngreso;
            oPersonas.PrsFechaBaja = _vista.datPrsBaja;
            oPersonas.PrsLegajo = _vista.strPrsLegajo;
            oPersonas.PrsCuil = _vista.strPrsCuil;
            if (int.Parse(_vista.cmbPrsLocalidad.SelectedValue.ToString()) > 0)
                oPersonas.LocNumeroNacimiento = int.Parse(_vista.cmbPrsLocalidad.SelectedValue.ToString());

            if (_vista.booPrsEstado)
                oPersonas.EstCodigo = "H";
            else
                oPersonas.EstCodigo = "I";           

            if (_vista.logPrsNumero == 0)
            {
                logResultado = oPersonasBus.PersonasAdd(oPersonas);
                Console.WriteLine("El numero de persona creado " + logResultado);
                return logResultado;               
            }
            else
            {
                logResultado = (oPersonasBus.PersonasUpdate(oPersonas)) ? oPersonas.PrsNumero : 0;
                return logResultado;
            }
        }

        public bool EliminarPersona(long idPersona)
        {
            
            PersonasBus oPersonasBus = new PersonasBus();
            Personas oPersonas = oPersonasBus.PersonasGetById(idPersona);
            oPersonas.EstCodigo = "B";
            return oPersonasBus.PersonasUpdate(oPersonas);
        }
        public int ConsultarUsuario(long idPersona)
        {

            UsuariosBus oUsuariosBus = new UsuariosBus();
            Usuarios oUsuarios = oUsuariosBus.PersonaUsuarios(idPersona.ToString());          
            return oUsuarios.UsrNumero;
        }
    }
}
