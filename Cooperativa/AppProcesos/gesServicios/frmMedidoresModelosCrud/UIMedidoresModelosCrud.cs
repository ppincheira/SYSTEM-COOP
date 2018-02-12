using Business;
using Model;
using Service;

namespace AppProcesos.gesServicios.frmMedidoresModelosCrud
{
    public class UIMedidoresModelosCrud
    {
        private IVistaMedidoresModelosCrud _vista;
        Utility oUtil;

        public UIMedidoresModelosCrud(IVistaMedidoresModelosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            //Obtengo los tipos de contadores
            DominiosBus oDominios = new DominiosBus();
            oUtil.CargarCombo(_vista.TipoContador, oDominios.DominiosGetByFilter("TIPO_CONTADOR"), "DMN_VALOR", "DMN_DESCRIPCION", "SELECCIONE..");

            // Obtengo los grupos del Tipo de conexiones
            TipoConexionServiciosBus oTiposConexiones = new TipoConexionServiciosBus();
            oUtil.CargarCombo(_vista.TipoConexion, oTiposConexiones.TipoConexionServiciosGetAllDT(), "TCS_CODIGO", "TCS_DESCRIPCION", "SELECCIONE..");

            // Obtengo los Fabricantes
            FabricantesBus oFabricantes = new FabricantesBus();
            oUtil.CargarCombo(_vista.FabNumero, oFabricantes.FabricantesGetAllDT(), "FAB_NUMERO", "FAB_DESCRIPCION", "SELECCIONE..");

            // Obtengo los grupos del Tipo de medidores
            TiposMedidoresBus oTiposMedidores = new TiposMedidoresBus();
            oUtil.CargarCombo(_vista.TMeCodigo, oTiposMedidores.TiposMedidoresGetAllDT(), "TME_CODIGO", "TME_DESCRIPCION", "SELECCIONE..");

            if (_vista.Codigo != 0)
            {
                MedidoresModelos oMedidoresModelos = new MedidoresModelos();
                MedidoresModelosBus oMedidoresModelosBus = new MedidoresModelosBus();
                //Obtengo datos de la entidad principal que trabajo
                oMedidoresModelos = oMedidoresModelosBus.MedidoresModelosGetById(_vista.Codigo);
                _vista.TipoContador.SelectedValue = oMedidoresModelos.MMoTipoContador;
                _vista.TipoConexion.SelectedValue = oMedidoresModelos.MMoTipoConexion;
                _vista.FabNumero.SelectedValue = oMedidoresModelos.FabNumero;
                _vista.TMeCodigo.SelectedValue = oMedidoresModelos.TmeCodigo;
                _vista.Descripcion = oMedidoresModelos.MMoDescripcion;
                _vista.DescripcionCorta = oMedidoresModelos.MMoDescripcionCorta;
                _vista.Decimales = oMedidoresModelos.MMoDecimales;
                _vista.Digitos = oMedidoresModelos.MMoDigitos;
                _vista.CantHilos = oMedidoresModelos.MMoCantHilos;
                _vista.KWVueltas = oMedidoresModelos.MMoKwVueltas;
                _vista.Amperaje = oMedidoresModelos.MMoAmperaje;
                _vista.Clase = oMedidoresModelos.MMoClase;
                _vista.Registrador = oMedidoresModelos.MMoRegistrador;
                _vista.FechaCarga = oMedidoresModelos.MMoFechaCarga;
                _vista.EstCodigo = oMedidoresModelos.EstCodigo;
            }
        }



        public void Guardar()
        {
            long rtdo;
            MedidoresModelos oMMO = new MedidoresModelos();
            MedidoresModelosBus oMMOBus = new MedidoresModelosBus();
            //Cargar los datos ingresados al objeto

            oMMO.MMoCodigo = _vista.Codigo;
            oMMO.MMoDescripcion = _vista.Descripcion;
            oMMO.MMoDescripcionCorta = _vista.DescripcionCorta;
            oMMO.MMoDecimales = _vista.Decimales;
            oMMO.MMoDigitos = _vista.Digitos;
            oMMO.MMoCantHilos = _vista.CantHilos;
            oMMO.MMoKwVueltas = _vista.KWVueltas;
            oMMO.MMoAmperaje = _vista.Amperaje;
            oMMO.MMoClase = _vista.Clase;
            oMMO.MMoRegistrador = _vista.Registrador;
            oMMO.MMoFechaCarga = _vista.FechaCarga;
            oMMO.MMoTipoContador = _vista.TipoContador.SelectedValue.ToString();
            oMMO.MMoTipoConexion = _vista.TipoConexion.SelectedValue.ToString();
            oMMO.FabNumero = int.Parse(_vista.FabNumero.SelectedValue.ToString());
            oMMO.TmeCodigo = int.Parse(_vista.TMeCodigo.SelectedValue.ToString());
            oMMO.EstCodigo = _vista.EstCodigo;
            oMMO.UsrNumero = _vista.UsrNumero;

            if (_vista.Codigo == 0)
                oMMO.MMoCodigo =  oMMOBus.MedidoresModelosAdd(oMMO);
            else
                rtdo = (oMMOBus.MedidoresModelosUpdate(oMMO)) ? oMMO.MMoCodigo : 0;
        }

        public bool EliminarModeloMedidor(long idMedidor)
        {
            MedidoresModelosBus oMMOBus = new MedidoresModelosBus();
            MedidoresModelos oMMO = oMMOBus.MedidoresModelosGetById(idMedidor);
            oMMO.EstCodigo = "B";
            return oMMOBus.MedidoresModelosUpdate(oMMO);
       }


    }
}
