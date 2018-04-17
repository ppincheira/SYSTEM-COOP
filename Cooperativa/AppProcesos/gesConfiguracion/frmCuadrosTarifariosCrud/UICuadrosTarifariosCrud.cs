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

        public void Inicializar(string tabla)
        {
            //Obtengo los cuadros tarifarios
            CargarGrillaCuadrosTarifarios();
         
         }
        private void CargarGrillaCuadrosTarifarios (){
            CuadrosTarifariosBus oCdt = new CuadrosTarifariosBus();
            DataTable dt = oCdt.CuadrosTarifariosGetAllDT();

            oUtil.CargarGrilla(_vista.grillaCuadrosTarifarios, dt);

            //_vista.grdSumConceptos.Columns["cpt_numero"].Visible = false;
            //Cambio los headers por defecto por los definidos en detalles columnas tablas 
            //DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
            //List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo("SCO");
            //foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            //{
            //    _vista.grdSumConceptos.Columns[indice].HeaderText = oDetalle.DctDescripcion.Replace('"', ' ');
            //    //_vista.grdSumConceptos.Columns[indice].HeaderText = oDetalle.DctDescripcion.Replace("AS ","");
            //    indice++;
            //}
        }

        //public void CargarGrilla(string tabla)
        //{
        //    _filtroCampos = "";
        //    _filtroValores = "";

        //    if (_vista.grupoFecha && _Fecha != null)
        //    {
        //        _filtroValores = _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
        //        _filtroCampos = _Fecha;
        //    }
        //    if (_vista.grupoEstado && _vista.comboEstado.Text != "")
        //        _filtroValores = _vista.comboEstado.Text + "&";

        //    TablasBus oTablasBus = new TablasBus();
        //    _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
        //    _vista.cantidad = "Se encontraron " + _vista.grilla.RowCount + " registros";
            
        //}


        //public void CargarGrilla(string tabla,string filtroCampo, string filtroValor)
        //{
        //    _filtroCampos = filtroCampo;
        //    _filtroValores = filtroValor;

        //    if (_vista.grupoFecha)
        //    {
        //        _filtroValores = _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
        //        _filtroCampos = _Fecha;
        //    }
        //    if (_vista.grupoEstado)
        //        _filtroValores = _filtroValores + " & " + _vista.comboEstado.Text + "&";

        //    TablasBus oTablasBus = new TablasBus();
        //    _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
        //    _vista.cantidad = "Se encontraron " + _vista.grilla.RowCount + " registros";

        //}
    }
}
