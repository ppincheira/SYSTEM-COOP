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

namespace AppProcesos.formsAuxiliares.formAdmin
{
    public class UIFormAdmin
    {
        private IVistaFormAdmin _vista;
        Utility oUtil;

        private string _Campo;
        private string _filtroCampos;
        private string _filtroValores;
        private DataTable _dtCombo;
        private string _Fecha;


        public UIFormAdmin(IVistaFormAdmin vista)
        {
            _vista = vista;
            oUtil = new Utility();

        }

        public void Inicializar(Admin oAdmin)
        {
            
            _Campo = "";
            _filtroCampos = oAdmin.FiltroCampos!=null?oAdmin.FiltroCampos:"" ;
            _filtroValores = oAdmin.FiltroValores != null?oAdmin.FiltroValores:"";
            _dtCombo = new DataTable();
            _dtCombo.Columns.Add("DctColumna", typeof(string));
            _dtCombo.Columns.Add("DctDescripcion", typeof(string));
            DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
            List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(oAdmin.TabCodigo);
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {
                _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                {
                    _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                }
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "FECHA"))
                {
                    _vista.grupoFecha = true;
                    _vista.fechaDesde = DateTime.Now.Date.AddMonths(-1);
                    _vista.fechaHasta = DateTime.Now.Date;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _Fecha = oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                }
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "ESTADO"))
                {
                    _vista.grupoEstado = true;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + _vista.comboEstado.Text + "&";
                }
            }

            oUtil.CargarCombo(_vista.comboBuscar, _dtCombo, "DctColumna", "DctDescripcion" ,"SELECCIONE..");
            if (_Campo.Length > 0)
                _Campo = _Campo.Substring(0, _Campo.Length - 1);
            TablasBus oTablasBus = new TablasBus();
            DataTable dt = oTablasBus.TablasBusquedaGetAllFilter(oAdmin.TabCodigo, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad = "Se encontraron " + oUtil.CargarGrilla(_vista.grilla, dt) + " registros";
            _vista.grilla.Columns["CODIGO"].Visible = false;

        }


        public void CargarGrilla(Admin oAdmin)
        {
            
            _filtroCampos = oAdmin.FiltroCampos != null ? oAdmin.FiltroCampos : "";
            _filtroValores = oAdmin.FiltroValores != null ? oAdmin.FiltroValores : "";

            if (_vista.grupoFecha && _Fecha != null)
            {
                _filtroValores = _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                _filtroCampos = _Fecha;
            }
            if (_vista.grupoEstado && _vista.comboEstado.Text != "")
                _filtroValores = _vista.comboEstado.Text + "&";

            if (_vista.comboBuscar.SelectedValue.ToString()!="0")
            { 
            _filtroCampos = _filtroCampos + _vista.comboBuscar.SelectedValue.ToString() + "&";
            _filtroValores = _filtroValores + _vista.filtro + "&";
            }
            TablasBus oTablasBus = new TablasBus();
            _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(oAdmin.TabCodigo, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad = "Se encontraron " + _vista.grilla.RowCount + " registros";
            _vista.grilla.Columns["CODIGO"].Visible = false;

        }


          public void CargarGrilla(string tabla,string filtroCampo, string filtroValor)
        {
            _filtroCampos = filtroCampo;
            _filtroValores = filtroValor;
            if (_vista.grupoFecha)
            {
                _filtroValores = _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                _filtroCampos = _Fecha;
            }
            if (_vista.grupoEstado)
                _filtroValores = _filtroValores + " & " + _vista.comboEstado.Text + "&";
            _filtroCampos = _filtroCampos + _vista.comboBuscar.SelectedValue.ToString() + "&";
            _filtroValores = _filtroValores + _vista.filtro + "&";
            TablasBus oTablasBus = new TablasBus();
            _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad = "Se encontraron " + _vista.grilla.RowCount + " registros";
            _vista.grilla.Columns["CODIGO"].Visible = false;

        }

        public void MarcarSeleccion(string tabla)
        {
            for (int i = 0; i < _vista.grilla.Rows.Count; i++)
            {
                switch (tabla)
                {
                    case "TETE":
                        if (_vista.grilla.Rows[i].Cells["DEFECTO"].Value.ToString() == "S")
                            _vista.grilla.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
                        break;
                    case "CLIE":
                        if (_vista.grilla.Rows[i].Cells["DEFECTO"].Value.ToString() == "S")
                            _vista.grilla.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
                        break;

                }

            }
        }

        public void Seleccion()
        {
            DataGridViewRow row = _vista.grilla.CurrentRow;
            _vista.striRdoCodigo =row.Cells["CODIGO"].Value.ToString();
        }
    }
}
