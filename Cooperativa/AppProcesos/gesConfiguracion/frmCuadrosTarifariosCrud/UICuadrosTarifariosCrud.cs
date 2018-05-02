using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppProcesos.gesConfiguracion.frmCuadrosTarifariosCrud
{
    public class UICuadrosTarifariosCrud
    {
        private IVistaCuadrosTarifariosCrud _vista;
        Utility oUtil;

        //private string _Campo;
        //private string _filtroCampos;
        //private string _filtroValores;
        //private DataTable _dtCombo;
        //private string _Fecha;


        public UICuadrosTarifariosCrud(IVistaCuadrosTarifariosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();

        }

        public void Inicializar()
        {
            //Obtengo los cuadros tarifarios
            CargarGrillaCuadrosTarifarios();
            CargarGrillaCategorias();
         
         }
        private void CargarGrillaCuadrosTarifarios (){
            CuadrosTarifariosBus oCdt = new CuadrosTarifariosBus();
            DataTable dt = oCdt.CuadrosTarifariosGetAllDT();

            oUtil.CargarGrilla(_vista.grillaCuadrosTarifarios, dt);
            _vista.grillaCuadrosTarifarios.ReadOnly = true;
            _vista.grillaCuadrosTarifarios.AutoResizeColumns();
           
        }
        private void CargarGrillaCategorias()
        {
            ServiciosCategoriasBus oSC = new ServiciosCategoriasBus();
            DataTable dt = oSC.ServiciosCategoriasCdtGetbySrv("1");

            oUtil.CargarGrilla(_vista.grillaCategorias, dt);
            _vista.grillaCategorias.ReadOnly = true;
            _vista.grillaCategorias.AutoResizeColumns();

        }

    }
}
