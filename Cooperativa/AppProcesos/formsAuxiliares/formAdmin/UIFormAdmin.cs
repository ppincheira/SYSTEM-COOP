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
        private Admin _oAdmin;
        private string _Campo;
        private DataTable _dtCombo;
        private DataTable _dtComboA;
        private DataTable _dtComboOpciones;
        private string _Fecha;
        public UIFormAdmin(IVistaFormAdmin vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        

        public void Inicializar(Admin oAdmin)
        {
            _Campo = "";
            _oAdmin = oAdmin;
            _oAdmin.FiltroCampos= oAdmin.FiltroCampos!=null?oAdmin.FiltroCampos:"" ;
            _oAdmin.FiltroValores = oAdmin.FiltroValores != null?oAdmin.FiltroValores:"";
            _oAdmin.FiltroOperador = oAdmin.FiltroOperador != null ? oAdmin.FiltroOperador : "";
            _dtCombo = new DataTable();
            _dtCombo.Columns.Add("DctColumna", typeof(string));
            _dtCombo.Columns.Add("DctDescripcion", typeof(string));
            _dtComboA = new DataTable();
            _dtComboA.Columns.Add("DctColumna", typeof(string));
            _dtComboA.Columns.Add("DctDescripcion", typeof(string));
            DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
            List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(oAdmin.TabCodigo);
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {
                _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                {
                    _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                    _dtComboA.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                }
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "FECHA"))
                {
                    _vista.grupoFecha = true;
                    _vista.fechaDesde = DateTime.Now.Date.AddMonths(-1);
                    _vista.fechaHasta = DateTime.Now.Date;
                    _oAdmin.FiltroCampos = _oAdmin.FiltroCampos + oDetalle.DctColumna + "&";
                    _Fecha = oDetalle.DctColumna + "&";
                    _oAdmin.FiltroValores = _oAdmin.FiltroValores + _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                }
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "ESTADO"))
                {
                    _vista.grupoEstado = true;
                    _oAdmin.FiltroCampos = _oAdmin.FiltroCampos + oDetalle.DctColumna + "&";
                    _oAdmin.FiltroValores = _oAdmin.FiltroValores + _vista.comboEstado.Text + "&";
                }
            }

           
            oUtil.CargarCombo(_vista.comboBuscar, _dtCombo, "DctColumna", "DctDescripcion" ,"SELECCIONE..");
            InicializarTabAvanzado();
            if (_Campo.Length > 0)
                _Campo = _Campo.Substring(0, _Campo.Length - 1);
            TablasBus oTablasBus = new TablasBus();
            DataTable dt = new DataTable();
            dt = oTablasBus.TablasBusquedaGetAllFilter( _Campo, _oAdmin);
            _vista.cantidad = "Se encontraron " + oUtil.CargarGrilla(_vista.grilla, dt) + " registros";
            _vista.grilla.Columns["CODIGO"].Visible = false;
        }
        private void InicializarTabAvanzado()
        {
            oUtil.CargarCombo(_vista.comboBuscarA, _dtComboA, "DctColumna", "DctDescripcion", "SELECCIONE CAMPO..");
            CargarOpcionesA();
            _vista.dtiFiltro = new DataTable();
            _vista.dtiFiltro.Columns.Add("Id", typeof(string));
            _vista.dtiFiltro.Columns.Add("DctColumna", typeof(string));
            _vista.dtiFiltro.Columns.Add("DctDescripcion", typeof(string));
            _vista.dtiFiltro.Columns.Add("Operador", typeof(string));
            _vista.dtiFiltro.Columns.Add("Descripcion", typeof(string));
            _vista.dtiFiltro.Columns.Add("Valor", typeof(string));
            _vista.dtiFiltro.Columns.Add("Valor2", typeof(string));
        }


        public void CargarOpcionesA()
        {
            _dtComboOpciones = new DataTable();
            _dtComboOpciones.Columns.Add("Id", typeof(string));
            _dtComboOpciones.Columns.Add("Descripcion", typeof(string));
            _dtComboOpciones.Rows.Add("1", "IGUAL");
            _dtComboOpciones.Rows.Add("2", "DISTINTO");
            _dtComboOpciones.Rows.Add("3", "MENOR");
            _dtComboOpciones.Rows.Add("4", "MENOR O IGUAL [<=]");
            _dtComboOpciones.Rows.Add("5", "MAYOR");
            _dtComboOpciones.Rows.Add("6", "MAYOR O IGUAL [>=]");
            _dtComboOpciones.Rows.Add("7", "CONTENIDO");
            _dtComboOpciones.Rows.Add("8", "EMPIEZA CON");
            _dtComboOpciones.Rows.Add("9", "TERMINA CON");
            _dtComboOpciones.Rows.Add("10", "ENTRE DOS VALORES");
            _dtComboOpciones.Rows.Add("11", "EN LISTA");
            _dtComboOpciones.Rows.Add("12", "NO EN LISTA");
            oUtil.CargarCombo(_vista.comboOpcionesA, _dtComboOpciones, "Id", "Descripcion", "SELECCIONE OPERADOR..");
        }

        public void Eliminar(int index)
        {
            _vista.dtiFiltro.Rows.RemoveAt(index);
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("DctColumna", typeof(string));
            dt.Columns.Add("DctDescripcion", typeof(string));
            dt.Columns.Add("Operador", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Valor", typeof(string));
            dt.Columns.Add("Valor2", typeof(string));

            //foreach (DataRow row in _vista.dtiFiltro.Rows)
            //{
               
            //            dt.Rows.Add(dt.Rows.Count + 1, row["DctColumna"].ToString(), row["DctDescripcion"].ToString(), row["Operador"].ToString(), row["Descripcion"].ToString(), row["valor"].ToString(), row["valor2"].ToString());
            //}
            //_vista.dtiFiltro.Rows.Clear();
            //_vista.dtiFiltro = dt;
            CargarGrilla(_vista.oiAdmin);
        }

        public string GuardarSeleccionados()
        {
           string strDatos = "";
            DataGridViewSelectedRowCollection Seleccionados = _vista.grilla.SelectedRows;

            foreach (DataGridViewRow item in Seleccionados)
            {
                strDatos = strDatos  + item.Cells["CODIGO"].Value.ToString() + "&";
            }

            return strDatos;

        }
        public void CargarGrilla(Admin oAdmin)
        {
            _oAdmin.FiltroCampos = oAdmin.FiltroCampos != null ? oAdmin.FiltroCampos : "";
            _oAdmin.FiltroValores = oAdmin.FiltroValores != null ? oAdmin.FiltroValores : "";
            _oAdmin.FiltroOperador = oAdmin.FiltroOperador != null ? oAdmin.FiltroOperador : "";
            if (_vista.dtiFiltro.Rows.Count>0)
            {
                
                for (int i = 0; i < _vista.dtiFiltro.Rows.Count; i++)
                {
                    _oAdmin.FiltroCampos += _vista.dtiFiltro.Rows[i]["DctColumna"].ToString() + "&";
                    _oAdmin.FiltroOperador += _vista.dtiFiltro.Rows[i]["Operador"].ToString() + "&";
                    _oAdmin.FiltroValores += _vista.dtiFiltro.Rows[i]["Valor2"].ToString() + "&";
                }
                LimpiarBusquedaAvanzada();
                _vista.comboBuscarA.SelectedIndex = 0;
                _vista.comboOpcionesA.SelectedIndex = 0;
            }
            if (_vista.grupoFecha && _Fecha != null)
            {
                _oAdmin.FiltroValores = _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                _oAdmin.FiltroCampos = _Fecha;
            }
            if (_vista.grupoEstado && _vista.comboEstado.Text != "")
                _oAdmin.FiltroValores = _vista.comboEstado.Text + "&";

            if (_vista.comboBuscar.SelectedValue.ToString()!="0")
            {
                _oAdmin.FiltroCampos = _oAdmin.FiltroCampos + _vista.comboBuscar.SelectedValue.ToString() + "&";
                _oAdmin.FiltroOperador = _oAdmin.FiltroOperador + "7&";
                _oAdmin.FiltroValores = _oAdmin.FiltroValores + _vista.filtro + "&";
            }
            TablasBus oTablasBus = new TablasBus();
            _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter( _Campo,_oAdmin);
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


        public void CargarDataTable()
        {
            string strValor = "";
            string strValor2 = "";
            switch (_vista.comboOpcionesA.SelectedValue.ToString())
            {
                case "1":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "2":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "3":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "4":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "5":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "6":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "7":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "8":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "9":
                    strValor = _vista.striValor1;
                    strValor2 = _vista.striValor1;
                    break;
                case "10":
                    strValor = _vista.striValor2 + " " + _vista.striValor3;
                    strValor2 = _vista.striValor2 + "%" + _vista.striValor3;
                    break;
                case "11":
                    strValor = _vista.striValor2 + " " + _vista.striValor3 + " " + _vista.striValor4 + " " + _vista.striValor5 + " " + _vista.striValor6;
                    strValor2 = _vista.striValor2 + "%" + _vista.striValor3 + "%" + _vista.striValor4 + "%" + _vista.striValor5 + "%" + _vista.striValor6;
                    break;
                case "12":
                    strValor = _vista.striValor2 + " " + _vista.striValor3 + " " + _vista.striValor4 + " " + _vista.striValor5 + " " + _vista.striValor6;
                    strValor2 = _vista.striValor2 + "%" + _vista.striValor3 + "%" + _vista.striValor4 + "%" + _vista.striValor5 + "%" + _vista.striValor6;
                    break;
            }

            _vista.dtiFiltro.Rows.Add(_vista.dtiFiltro.Rows.Count + 1, _vista.comboBuscarA.SelectedValue, _vista.comboBuscarA.Text, _vista.comboOpcionesA.SelectedValue, _vista.comboOpcionesA.Text, strValor,strValor2);
            oUtil.CargarGrilla(_vista.grillaFiltro, _vista.dtiFiltro);
            _vista.grillaFiltro.Columns["DctColumna"].Visible = false;
            _vista.grillaFiltro.Columns["Operador"].Visible = false;
            _vista.grillaFiltro.Columns["Id"].HeaderText = "NRO.";
            _vista.grillaFiltro.Columns["Id"].Width = 50;
            _vista.grillaFiltro.Columns["DctDescripcion"].HeaderText = "CAMPO";
            _vista.grillaFiltro.Columns["DctDescripcion"].Width = 200;
            _vista.grillaFiltro.Columns["Descripcion"].HeaderText = "DESCRIPCIÓN";
            _vista.grillaFiltro.Columns["Descripcion"].Width = 200;
            _vista.grillaFiltro.Columns["Valor"].HeaderText = "VALORES";
            _vista.grillaFiltro.Columns["Valor"].Width = 200;
            _vista.grillaFiltro.Columns["Valor2"].Visible = false;
            for (int i = 0; i < _vista.dtiFiltro.Rows.Count; i++)
            {
                _oAdmin.FiltroCampos += _vista.dtiFiltro.Rows[i]["DctColumna"].ToString() + "&";
                _oAdmin.FiltroOperador += _vista.dtiFiltro.Rows[i]["Operador"].ToString() + "&";
                _oAdmin.FiltroValores += _vista.dtiFiltro.Rows[i]["Valor2"].ToString() + "&";
            }
            CargarGrilla(_oAdmin);
            LimpiarBusquedaAvanzada();
            _vista.comboBuscarA.SelectedIndex = 0;
            _vista.comboOpcionesA.SelectedIndex = 0;  
        }
   
        private void LimpiarBusquedaAvanzada()
        {
            _vista.striValor1 = "";
            _vista.striValor2 = "";
            _vista.striValor3 = "";
            _vista.striValor4 = "";
            _vista.striValor5 = "";
            _vista.striValor6 = "";
        }
     

    }
}
