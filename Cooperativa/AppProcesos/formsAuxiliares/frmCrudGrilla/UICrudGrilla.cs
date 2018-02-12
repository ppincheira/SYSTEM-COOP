using Business;
using Model;
using System;
using Service;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AppProcesos.formsAuxiliares.frmCrudGrilla
{
    public partial class UICrudGrilla
    {
        private IVistaCrudGrilla _vista;
        Utility oUtil;

        private string _Campo, _Combos, _Checks;
        private string _filtroCampos;
        private string _filtroValores;
        private DataTable _dtCombo;
        private string _Fecha;
        public string columnaClave = "";
        public bool insertarClave = false;
        public DataTable _estructuraTablaGrilla;

        
        public UICrudGrilla(IVistaCrudGrilla vista)
        {
            _vista = vista;
            oUtil = new Utility();

        }

        public void Inicializar(string tabla, string campoClave, bool claveSecuencia)
        {
            _filtroCampos = "";
            _filtroValores = "";
            _Campo = "";
            _Checks = "";
            _Combos = "";
            _dtCombo = new DataTable();
            _dtCombo.Columns.Add("DctColumna", typeof(string));
            _dtCombo.Columns.Add("DctDescripcion", typeof(string));
            DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
            List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(tabla);
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {
                if (oDetalle.DctTipoControl=="COMBO")
                    _Combos += ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                if (oDetalle.DctTipoControl=="CHECK")
                    _Checks += ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                //else
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
                if (campoClave == oDetalle.DctDescripcion)
                    columnaClave = oDetalle.DctColumna;
            }

            oUtil.CargarCombo(_vista.comboBuscar, _dtCombo, "DctColumna", "DctDescripcion");
            if (_Campo.Length > 0)
                _Campo = _Campo.Substring(0, _Campo.Length - 1);
            TablasBus oTablasBus = new TablasBus();
            DataTable dt = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad = oUtil.CargarGrilla(_vista.grilla, dt) + " registros";
            
            int indice = 0;
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {
                if (oDetalle.DctTipoControl == "COMBO")
                {
                    DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                    cmb.HeaderText = oDetalle.DctDescripcion;
                    cmb.Name = oDetalle.DctColumna;
                    // CARGAR LA LISTA DE VALORES DEL COMBO
                    switch (oDetalle.DctListaValores)
                    {
                        case "AREAS":
                        {
                            AreasBus oAreaBusCombo = new AreasBus();

                            cmb.DataSource = oAreaBusCombo.AreasGetAll();
                            cmb.DisplayMember = "AreDescripcion";
                            cmb.ValueMember = "AreCodigo";
                            break;
                        }
                        default: break;
                    }
                    _vista.grilla.Columns.Add(cmb);
                    foreach (DataGridViewRow row in _vista.grilla.Rows)
                        row.Cells[_vista.grilla.ColumnCount - 1].Value = row.Cells[indice].Value;
                    _vista.grilla.Columns[indice].Visible = false;
                }
                if (oDetalle.DctTipoControl == "CHECK")
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.HeaderText = oDetalle.DctDescripcion;
                    chk.Name = oDetalle.DctColumna;
                    _vista.grilla.Columns.Add(chk);
                    foreach (DataGridViewRow row in _vista.grilla.Rows)
                    {
                        row.Cells[_vista.grilla.ColumnCount - 1].Value = Equals(row.Cells[indice].Value, "S");
                    }
                    _vista.grilla.Columns[indice].Visible = false;

                }
                indice++;
            }

            _vista.grilla.Columns.Add("Estado", "");
            _vista.grilla.Columns[campoClave].ReadOnly = true;
            _vista.grilla.Columns[_vista.grilla.ColumnCount - 1].Visible = false;
            foreach (DataGridViewRow row in _vista.grilla.Rows)
            {
                //  if (!row.IsNewRow)
                row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
            }
            // Obtengo nombre de la tabla 
            Tablas otabla = new Tablas();
            otabla = oTablasBus.TablasGetById(tabla);
            // Obtengo la estructura de la tabla con la que cargue la grilla
            _estructuraTablaGrilla= oTablasBus.Estructura(otabla.TabNombre);
            // Si la clave es secuencia no permito editarla, caso contrario si
            // La clave se edita unicamente cuando se agrega un nuevo registro, esto se habilita en addnew
            // cuando doy confirmar cambios se debe validar cada uno de los campos teniendo en cuenta los tipos de datos de la tabla y el mapeo
        }

        public void CargarGrilla(string tabla, string campoClave, bool claveSecuencia)
        {
            _filtroCampos = "";
            _filtroValores = "";

            if (_vista.grupoFecha)
            {
                _filtroValores = _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                _filtroCampos = _Fecha;
            }
            if (_vista.grupoEstado)
                _filtroValores = _vista.comboEstado.Text + "&";

            _filtroCampos = _filtroCampos + _vista.comboBuscar.SelectedValue.ToString() + "&";
            _filtroValores = _filtroValores + _vista.filtro + "&";

            TablasBus oTablasBus = new TablasBus();
            _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad = "Se encontraron " + _vista.grilla.RowCount.ToString() + " registros";
        }
        public void MostrarTabla(string Tabla)
        {
            // Obtener de DetallesColumnasTablas todos los campos de la tabla menos el campo clave
            // Pasar esos campos a un arreglo de campos y valores
            // actualizar
            Tablas otabla = new Tablas();
            TablasBus tablasGrd = new TablasBus();
            tablasGrd.MostrarEstructura(Tabla);
        }

        public void ActualizaTabla(string Tabla, string campoClave, bool claveSecuencia)
        {
            // Obtener de DetallesColumnasTablas todos los campos de la tabla menos el campo clave
            // Pasar esos campos a un arreglo de campos y valores
            // actualizar
            bool datosOK = true;
            Tablas otabla = new Tablas();
            TablasBus tablasGrd = new TablasBus();
            otabla = tablasGrd.TablasGetById(Tabla);
            DetallesColumnasTablasBus oDetalleGrd = new DetallesColumnasTablasBus();
            List<DetallesColumnasTablas> ListDetalle = oDetalleGrd.DetallesColumnasTablasGetByCodigo(Tabla);
            foreach (DataGridViewRow row in _vista.grilla.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] nombreCampos = { };
                    string[] valoresCampos = { };
                    string valorClave = "";
                    string columnaClave = "";
                    int posicion = 0;
                    // Actualizar tabla
                    foreach (DetallesColumnasTablas oDetalle in ListDetalle)
                    {
                        posicion++;
                        if (oDetalle.DctDescripcion != campoClave ||
                            (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "3" && oDetalle.DctDescripcion == campoClave && !claveSecuencia))
                        {
                            Array.Resize(ref nombreCampos, nombreCampos.Length + 1);
                            Array.Resize(ref valoresCampos, valoresCampos.Length + 1);
                            nombreCampos[nombreCampos.Length - 1] = oDetalle.DctColumna;

                            if (row.Cells[posicion - 1].Visible)
                                if (row.Cells[posicion - 1].ValueType == typeof(DateTime))
                                {
                                    String fechatmp;
                                    fechatmp = row.Cells[posicion - 1].FormattedValue.ToString();
                                    valoresCampos[valoresCampos.Length - 1] = fechatmp;
                                }
                                else
                                    valoresCampos[valoresCampos.Length - 1] = row.Cells[posicion - 1].Value.ToString();
                            else
                            // Si la columna a actualizar no es visible tiene una homonima visible
                            // Busco la homonima visible y tomo su valor que es el que debo tener en cuenta para actualizar
                            {
                                for (int pos = posicion; pos < row.Cells.Count; pos++)
                                    if (_vista.grilla.Columns[posicion - 1].Name == _vista.grilla.Columns[pos].Name)
                                    {
                                        if (_vista.grilla.Columns[pos].ValueType == typeof(string))
                                            valoresCampos[valoresCampos.Length - 1] = row.Cells[pos].Value.ToString();
                                        else //Es un checkbox
                                            valoresCampos[valoresCampos.Length - 1] = row.Cells[pos].Value.Equals(true) ? "S" : "N";

                                    }

                            }
                        }
                        else  
                            //Agrego un registro y la clave no es secuencia
                        {
                            valorClave = row.Cells[posicion - 1].Value.ToString();
                            columnaClave = oDetalle.DctColumna;
                        }
                    };
                    // Para cada registro deberia actualizar su estado si se pudo actualizar
                    if (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "1" && !row.IsNewRow)
                    {
                        // Update
                        // Para cada campo validar que tenga el tipo de dato adecuado 
                        // contra la estructura de la tabla que esta en _estructuraTablaGrilla datatable
                        // Si todos los campos menos la clave son validos actualizo
                        foreach (DataRow oCampo in _estructuraTablaGrilla.Rows) {
                            int pos;
                            pos = Array.IndexOf(nombreCampos, oCampo.ItemArray[2]);
                            if (pos>= 0 && datosOK)
                                datosOK = (oUtil.TipoDatoValido(valoresCampos[pos], oCampo.ItemArray[4].ToString()));
                                //MessageBox.Show(oCampo.ItemArray[2].ToString()); // campo
                        }
                        if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "U"))
                            row.Cells[_vista.grilla.ColumnCount - 1].Value="0";

                    }
                    else if (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "2" && !row.IsNewRow)
                    {
                        // Delete
                        tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "D");
                    }
                    else if (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "3" && !row.IsNewRow)
                    {
                        // Insert
                        // Para cada campo validar que tenga el tipo de dato adecuado 
                        // contra la estructura de la tabla que esta en _estructuraTablaGrilla datatable
                        // Si todos los campos inclusive la clave, si no es secuencia, son validos actualizo
                        foreach (DataRow oCampo in _estructuraTablaGrilla.Rows) {
                            int pos;
                            pos = Array.IndexOf(nombreCampos, oCampo.ItemArray[2]);
                            if (pos >= 0 && datosOK)
                            {
                                datosOK = (oUtil.TipoDatoValido(valoresCampos[pos], oCampo.ItemArray[4].ToString()));
                                datosOK = valoresCampos[pos].Length > 0 || oCampo.ItemArray[8].ToString() == "Y";
                            }
                        }
                        if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "I"))
                            row.Cells[_vista.grilla.ColumnCount - 1].Value="0";
                    };
                }

            };
            if (!datosOK)
                MessageBox.Show("Error al actualizar los datos, Revice las filas resaltadas.");
        }
    }
}
