using Business;
using Model;
using Service;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public class UIMedidoresCrud
    {
        private IVistaMedidoresCrud _vista;
        Utility oUtil;

        public UIMedidoresCrud(IVistaMedidoresCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            //Obtengo los Modelos de medidores
            MedidoresModelosBus oMModelo = new MedidoresModelosBus();
            oUtil.CargarCombo(_vista.MmoCodigo, oMModelo.MedidoresModelosGetAllDT(), "MMO_CODIGO", "MMO_DESCRIPCION", "SELECCIONE..");

            //// Obtengo las empresas Proveedoras
            //EmpresasBus oEmpresas = new EmpresasBus();
            //oUtil.CargarCombo(_vista.NumeroProv, oEmpresas.EmpresasGetAllDT(), "EMP_NUMERO", "EMP_RAZON_SOCIAL", "SELECCIONE..");

            //Obtengo los Modos de lectura de medidores
            LecturasModosBus oLeModo = new LecturasModosBus();
            oUtil.CargarCombo(_vista.LemCodigo, oLeModo.LecturasModosGetAllDT(), "LEM_CODIGO", "LEM_DESCRIPCION", "SELECCIONE..");

            //// Obtengo los estados de Medidores
            EstadosBus oEstados = new EstadosBus();
            oUtil.CargarCombo(_vista.EstCodigo, oEstados.EstadosGetByFilterDT("MEDIDORES", "EST_CODIGO"), "EST_CODIGO", "EST_DESCRIPCION", "SELECCIONE..");
            _vista.EstCodigo.SelectedValue = "D";

            if (_vista.Numero != 0)
            {
                Medidores oMedidores = new Medidores();
                MedidoresBus oMedidoresBus = new MedidoresBus();
                //Obtengo datos de la entidad principal que trabajo
                oMedidores = oMedidoresBus.MedidoresGetById(_vista.Numero);
                _vista.NumeroProv = oMedidores.EmpNumeroProveedor;
                _vista.MmoCodigo.SelectedValue = oMedidores.MmoCodigo;
                _vista.NumeroSerie = oMedidores.MedNumeroserie;
                _vista.Digitos = oMedidores.MedDigitos;
                _vista.EstCodigo.SelectedValue = oMedidores.EstCodigo;
                _vista.FactorCalib = oMedidores.MedFactorCalib;
                _vista.GisX = oMedidores.GisX;
                _vista.GisY = oMedidores.GisY;
                _vista.UsrNumero = oMedidores.UsrNumero;
                _vista.FechaCarga = oMedidores.MedFechaCarga;
                _vista.LemCodigo.SelectedValue = oMedidores.LemCodigo;
                CargarProveedor(_vista.NumeroProv);
            }
        }



        public void Guardar()
        {
            long rtdo;
            Medidores oMMO = new Medidores();
            MedidoresBus oMMOBus = new MedidoresBus();
            //Cargar los datos ingresados al objeto

            oMMO.MedNumero = _vista.Numero;
            oMMO.MedNumeroserie = _vista.NumeroSerie;
            oMMO.EmpNumeroProveedor = _vista.NumeroProv;
            oMMO.MedDigitos = _vista.Digitos;
            oMMO.EstCodigo = _vista.EstCodigo.SelectedValue.ToString();
            oMMO.MedFactorCalib = _vista.FactorCalib;
            oMMO.GisX = _vista.GisX;
            oMMO.GisY = _vista.GisY;
            oMMO.UsrNumero = _vista.UsrNumero;
            oMMO.MedFechaCarga = _vista.FechaCarga;
            oMMO.MmoCodigo = short.Parse(_vista.MmoCodigo.SelectedValue.ToString());
            oMMO.LemCodigo = long.Parse(_vista.LemCodigo.SelectedValue.ToString());

            if (_vista.Numero == 0)
                oMMO.MedNumero = oMMOBus.MedidoresAdd(oMMO);
            else
                rtdo = (oMMOBus.MedidoresUpdate(oMMO)) ? oMMO.MedNumero : 0;
        }

        public bool EliminarModeloMedidor(long idMedidor)
        {
            MedidoresBus oMMOBus = new MedidoresBus();
            Medidores oMMO = oMMOBus.MedidoresGetById(idMedidor);
            oMMO.EstCodigo = "B";
            return oMMOBus.MedidoresUpdate(oMMO);
        }
        public void CargarProveedor(long id)
        {
            Empresas oEmpresa = new Empresas();
            EmpresasBus oEmpresasBus = new EmpresasBus();
            oEmpresa = oEmpresasBus.EmpresasGetById(id);
            _vista.NumeroProv = oEmpresa.EmpNumero;
            _vista.strRazonSocial = oEmpresa.EmpRazonSocial;
        }
    }
}
