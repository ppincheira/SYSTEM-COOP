using Business;
using Model;
using Service;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public class UIMedidoresMasivosCrud
    {
        private IVistaMedidoresMasivosCrud _vista;
        Utility oUtil;

        public UIMedidoresMasivosCrud(IVistaMedidoresMasivosCrud vista)
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

        }



        public void Guardar()
        {
            Medidores oMMO = new Medidores();
            MedidoresBus oMMOBus = new MedidoresBus();
            //Cargar los datos ingresados al objeto

            oMMO.MedNumero = _vista.Numero;
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
            for (long NumeroSerie=_vista.NumeroSerieDesde; NumeroSerie <= _vista.NumeroSerieHasta; NumeroSerie++)
            {
                oMMO.MedNumeroserie = NumeroSerie;
                oMMO.MedNumero =  oMMOBus.MedidoresAdd(oMMO);

            }
        }

    }
}
