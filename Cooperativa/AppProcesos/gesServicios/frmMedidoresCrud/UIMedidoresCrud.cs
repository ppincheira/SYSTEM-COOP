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

            // Obtengo las empresas Proveedoras
            EmpresasBus oEmpresas = new EmpresasBus();
            oUtil.CargarCombo(_vista.NumeroProv, oEmpresas.EmpresasGetAllDT(), "EMP_NUMERO", "EMP_RAZON_SOCIAL", "SELECCIONE..");

            //Obtengo los Modos de lectura de medidores
            LecturasModosBus oLeModo = new LecturasModosBus();
            oUtil.CargarCombo(_vista.LemCodigo, oLeModo.LecturasModosGetAllDT(), "LEM_CODIGO", "LEM_DESCRIPCION", "SELECCIONE..");


            if (_vista.Numero != 0)
            {
                Medidores oMedidores = new Medidores();
                MedidoresBus oMedidoresBus = new MedidoresBus();
                //Obtengo datos de la entidad principal que trabajo
                oMedidores = oMedidoresBus.MedidoresGetById(_vista.Numero);
                _vista.NumeroProv.SelectedValue = oMedidores.EmpNumeroProveedor;
                _vista.MmoCodigo.SelectedValue = oMedidores.MmoCodigo;
                _vista.NumeroSerie = oMedidores.MedNumeroserie;
                _vista.Digitos = oMedidores.MedDigitos;
                _vista.EstCodigo = oMedidores.EstCodigo;
                _vista.FactorCalib = oMedidores.MedFactorCalib;
                _vista.GisX = oMedidores.GisX;
                _vista.GisY = oMedidores.GisY;
                _vista.UsrNumero = oMedidores.UsrNumero;
                _vista.FechaCarga = oMedidores.MedFechaCarga;
                _vista.LemCodigo.SelectedValue = oMedidores.LemCodigo;
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
            oMMO.EmpNumeroProveedor = long.Parse(_vista.NumeroProv.SelectedValue.ToString());
            oMMO.MedDigitos = _vista.Digitos;
            oMMO.EstCodigo = _vista.EstCodigo;
            oMMO.MedFactorCalib = _vista.FactorCalib;
            oMMO.GisX = _vista.GisX;
            oMMO.GisY = _vista.GisY;
            oMMO.UsrNumero = _vista.UsrNumero;
            oMMO.MedFechaCarga = _vista.FechaCarga;
            oMMO.MmoCodigo = short.Parse(_vista.MmoCodigo.SelectedValue.ToString());
            oMMO.LemCodigo = long.Parse(_vista.LemCodigo.SelectedValue.ToString());

            if (_vista.Numero == 0)
                oMMO.MedNumero =  oMMOBus.MedidoresAdd(oMMO);
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


    }
}
