using Business;
using Model;
using Service;
using System.Windows.Forms;

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
                _vista.cmbPrsCargo.SelectedValue = oPersonas.PrsCargo;
                _vista.cmbPrsBaja.SelectedValue = oPersonas.PrsMotivoBaja;
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

        public void Guardar()
        {
            long rtdo;
            Personas oPersonas = new Personas();
            PersonasBus oPersonasBus = new PersonasBus();

            oPersonas.PrsEstadoCivil = _vista.cmbPrsCivil.SelectedValue.ToString();
            oPersonas.PrsSexo =_vista.cmbPrsSexo.SelectedValue.ToString();
            oPersonas.PrsCargo = _vista.cmbPrsCargo.SelectedValue.ToString();
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
            if (_vista.booPrsEstado)
                oPersonas.EstCodigo = "H";
            else
                oPersonas.EstCodigo = "I";           

            if (_vista.logPrsNumero == 0)
            {
                rtdo = oPersonasBus.PersonasAdd(oPersonas);                
            }
            else
            {
                rtdo = (oPersonasBus.PersonasUpdate(oPersonas)) ? oPersonas.PrsNumero : 0;               
            }
        }

        public bool EliminarPersona(long idPersona)
        {
            
            PersonasBus oPersonasBus = new PersonasBus();
            Personas oPersonas = oPersonasBus.PersonasGetById(idPersona);
            oPersonas.EstCodigo = "B";
            return oPersonasBus.PersonasUpdate(oPersonas);
        }

    }
}
