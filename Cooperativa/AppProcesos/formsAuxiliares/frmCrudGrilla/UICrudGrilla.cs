using Business;
using Model;
using System;
using Service;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Controles.datos;

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
            int indice = 0;
            _filtroCampos = "";
            _filtroValores = "";
            _Campo = "";
            _Checks = "";
            _Combos = "";
            _dtCombo = new DataTable();
            _dtCombo.Columns.Add("DctColumna", typeof(string));
            _dtCombo.Columns.Add("DctDescripcion", typeof(string));
            DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
            /* 
            *  SE RECUPERA LAS COLUMAS DE LA TABLA QUE SE VA A CARGAR 
            *  DETALLES COLUMNAS TABLAS TRAE MUCHA INFORMACION 
            *  DE LOS CAMPOS DE LA BASE DE DATOS Y DE LAS TABLAS 
            *  A TRABAJAR, CONTROLAR BIEN CUALES SON ESOS DATOS,
            *  Y INDICAR PARA QUE SIRVE CADA CAMPO, COMO VA A MODIFICAR LA EJECUCION DEL PROGRAMA?
            */
            List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(tabla);

            /*  DE LAS COLUMAS QUE SE RECUPERAN DE LA BD, SE CONTROLA QUE TIPO DE CONTROL ES
             *  EN EL CASO DE SER COMBO O CHECK  
             *  
             *  NO SE QUE SE HACE CON LAS VARIABLES _Combos y _Check
             *  TAMBIEN SE HACE LA CARGA DE LA QUERY QUE LUEGO BUSCARA LOS DATOS
             */
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {
                //ACA SE PUEDEN CARGAR MAS CONTROLES PARA DARLE VERSATILIDAD A LA GRILLA
                switch (oDetalle.DctTipoControl)
                {
                    case "COMBO":
                        {
                            _Combos += ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                            break;
                        }
                    case "CHECK":
                        {
                            _Checks += ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                            break;
                        }
                }
                //CASO PARA LA TABLA ROLES
                /*          DCTCOLUMNA                              DCTDESCRIPCION
                 *          ROL_CODIGO                              CODIGO
                 *          SBS_CODIGO                              SUBSISTEMAS
                 *          ROL_DESCRIPCION                         DESCRIPCION
                 *          ROL_TIPO                                TIPO
                 */
                _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                // ROL_CODIGO CODIGO, SBS_CODIGO SUBSISTEMAS, ROL_DESCRIPCION DESCRIPCION, ROL_TIPO TIPO,

                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                {
                    //_DTCOMBO CONTIENE EN COLUMNAS COLUMNA Y DESCRIPCION
                    // 
                    _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                }
                //LOS CONTROLES PARA LOS FILTROS DE CONTROL FECHA
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "FECHA"))
                {
                    _vista.grupoFecha = true;
                    _vista.fechaDesde = DateTime.Now.Date.AddMonths(-1);
                    _vista.fechaHasta = DateTime.Now.Date;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _Fecha = oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                }
                //TIPO DE CONTROL AGREGA FILTROS A LO QUE SERA LA QUERY FINAL
                //DENTRO DE LA GRILLA MANEJA EL COMBO BOX ESTADO, TANTO PARA CARGAR LOS VALORES POR LOS QUE SE PUEDE FILTRAR
                //COMO PARA GENERAR EL FILTRO EN LA QUERY
                if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "ESTADO"))
                {
                    _vista.grupoEstado = true;
                    _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                    _filtroValores = _filtroValores + _vista.comboEstado.Text + "&";
                }
                //SE AGREGGA LA COLUMNA QUE SERA LA CLAVE 
                //ATENTO A QUE ES LO UQE HACE CON ESTA VARIABLE
                if (campoClave == oDetalle.DctDescripcion)
                    columnaClave = oDetalle.DctColumna;
            }
            //FIN DEL FOREACH
            /*
             *HASTA ACA SE ENCARGO DE PREPARAR LOS DATOS PARA DESPUES CARGAR LA GRILLA             
             */

            //SE CARGA EL COMBO DE BUSQUEDA
            oUtil.CargarCombo(_vista.comboBuscar, _dtCombo, "DctColumna", "DctDescripcion");
            if (_Campo.Length > 0)
                _Campo = _Campo.Substring(0, _Campo.Length - 1);

            /*
             * ACA HACE LA BUSQUEDA EN LA BASE DE DATOS 
             */

            TablasBus oTablasBus = new TablasBus();
            DataTable dt = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            //_cAMPO = ROL_CODIGO CODIGO, SBS_CODIGO SUBSISTEMAS, ROL_DESCRIPCION DESCRIPCION, ROL_TIPO TIPO

            //CARGAR GRILLA
            _vista.cantidad = oUtil.CargarGrilla(_vista.grilla, dt) + " registros";

            //EN ESTA SECCION SE AGREGARA LA CELDA CON EL CONTROL ESPECIAL   
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {
                switch (oDetalle.DctTipoControl)
                {
                    case "COMBO":
                        {
                            #region LISTAS DEL COMBO
                            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                            cmb.HeaderText = oDetalle.DctDescripcion;
                            cmb.Name = oDetalle.DctColumna;
                            // CARGAR LA LISTA DE VALORES DEL COMBO
                            // EN CASO DE QUERER AGREGAR MAS PCIONES DE COMBO SOLO SE TIENE QUE HACER REFERENCIA 
                            // A SUS CLASES BISSNES
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
                                case "SUBSISTEMAS":
                                    {
                                        SubsistemaBus oSubsistemaBus = new SubsistemaBus();
                                        cmb.DataSource = oSubsistemaBus.SubsistemaGetAll();
                                        cmb.DisplayMember = "SbsNombre";
                                        cmb.ValueMember = "SbsCodigo";
                                        break;
                                    }
                                default: break;
                            }
                            //AGREGA EL LA NUEVA CELDAD
                            _vista.grilla.Columns.Add(cmb);
                            //ESTO SE ENCARGA DE PASAR LOS VALORES DE LA COLUMNA QUE SE CREO ORIGINAL MENTE CON LO QUE TRAJO DE LA BD
                            //Y SE LO ASIGNA A LA NUEVA CELDA CREADA                          
                            foreach (DataGridViewRow row in _vista.grilla.Rows)
                                row.Cells[_vista.grilla.ColumnCount - 1].Value = row.Cells[indice].Value;
                            _vista.grilla.Columns[indice].Visible = false;
                            break;
                            #endregion
                        }
                    case "CHECK":
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
                            break;
                        }
                    case "FECHA":
                        {
                            break; 
                        }
                }
                //LA FUNCION DE ESTA VARIABLE ES QUE VA REGISTRANDO EL INDICE DE COLUMNA QUE SE RECORRE
                //PARA ASI CUANDO LLEGA A UN CONTROL QUE SE TIENE QUE AGREGAR UN NUEVO TIPO DE CELDA
                //OCULTA LA COLUMNA Y PASA LOS VALORES A LA NUEVA COLUMNA CON EL NUEVO CONTROL
                indice++;
            }
            //FIN DEL FOREACH
            _vista.grilla.Columns.Add("Estado", "");
            if (claveSecuencia)
            {
                _vista.grilla.Columns[campoClave].ReadOnly = true;
            }           
            //CONTROLAR QUE COLUMNA ESTA OCULTANDO
            //OCULTA LA ULTIMA COLUMA, ESTADO
            _vista.grilla.Columns[_vista.grilla.ColumnCount - 1].Visible = false;

            //ESTE METODO SE UTILIZARA PARA ACOMODAR LAS COLUMNAS, CELDAS O CUALQUEIR OTRA PROPIEDAD VISUAL
            //DE LA GRILLA, ORIENTADA A PERSONALIZAR MAS LA GRILLA DEPENDIENDO LA TABLA QUE SE LE PIDA 
            // TRABAJAR
            presonalizarGrilla(_vista.grilla, tabla);

            //SETEA TODAS LAS ROWS EN ESTADO SIN MODIFICACION
            foreach (DataGridViewRow row in _vista.grilla.Rows)
            {
                //  if (!row.IsNewRow)
                row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
            }
            //ESTO HAY QUE ANALIZARLO.....
            // Obtengo nombre de la tabla 
            Tablas otabla = new Tablas();
            otabla = oTablasBus.TablasGetById(tabla);
            
            // Obtengo la estructura de la tabla con la que cargue la grilla
            //LA ESTRUCTURA SE ENCARGA DESPUES DE AYUDAR A PASAR LOS VALORES A LA CLASE BISSNES DE TABLAS PARA REALIZAR LOS CAMBIOS EN LA BASE DE DATOS
           _estructuraTablaGrilla = oTablasBus.Estructura(otabla.TabNombre);

            // Si la clave es secuencia no permito editarla, caso contrario si
            // La clave se edita unicamente cuando se agrega un nuevo registro, esto se habilita en addnew
            // cuando doy confirmar cambios se debe validar cada uno de los campos teniendo en cuenta los tipos de datos de la tabla y el mapeo
        }






        /*
         *  LA FUNCION DE ESTE METODO ES ESPESIFICAR DISTINTOS TAMAÑOS DE COLUMAS
         *  O MODIFICAR DE FORMA PERSONALIZADA PARA UNA TABLA CARGADA EN PARTICULAR 
         */
        private void presonalizarGrilla(grdGrillaEdit grilla, string tabla)
        {
            switch (tabla)
            {
                case "ROL":
                    {
                        grilla.Columns[0].Width = 150;
                        grilla.Columns[2].Width = 250;
                        grilla.Columns[3].Width = 50;
                        grilla.Columns[4].Width = 155;
                        break;
                    }
            }
        }


        //CONTROLAR COMO BUSCA Y COMO TRAE LOS DATOS 
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

            //EN ESTE LUGAR SE REALIZA LA BUSQUEDA CUIDADO QUE ESTO TOCA UNA CLASE CRITICA!!!!!!!!!!!
            //    _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            //         Inicializar2(tabla, campoClave, claveSecuencia);


            _vista.cantidad = "Se encontraron " + _vista.grilla.RowCount.ToString() + " registros";


        }



        //QUIERO VER ESTE METODO EN ACCION
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

            //ACA SE RECORREN TODAS LAS ROWS DE LA GRILLA
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

                    /*
                     * EN ESTA SECUENCIA SE BUSCA COMPLETAR
                     * nombresCampos = CON LOS NOMBRES DE LAS COLUMNAS
                     * valoresCampos = CON SUS VALORES CORRESPONDIENTES
                     */

                    //ESTO NO CONTIENE TODA LA TABLA QUE SE RECUPERA ...SOLO TRAE LO VISIBLE..                   
                    foreach (DetallesColumnasTablas oDetalle in ListDetalle)
                    {
                        posicion++;
                        if (oDetalle.DctDescripcion != campoClave || (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "3" && oDetalle.DctDescripcion == campoClave && !claveSecuencia))
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
                            //ACA TENDRIA QUE RECUPERAR EL VALOR DEL cmbLista, pero no lo hace!!!!!!!!!!!!

                            {
                                //OJOO
                                object celda = row.Cells[oDetalle.DctColumna];
                                //COMBO
                                //DataGridViewComboBoxColumn
                                //CHKBOX
                                // DataGridViewCheckBoxColumn
                                switch (oDetalle.DctTipoControl)
                                {
                                    case "COMBO":
                                        {
                                            valoresCampos[valoresCampos.Length - 1] = ((DataGridViewComboBoxCell)celda).Value.ToString();
                                            break;
                                        }
                                    //CONTROLA LA ESCRITURA
                                    case "CHKCK":
                                        {
                                            valoresCampos[valoresCampos.Length - 1] = ((DataGridViewCheckBoxColumn)celda).TrueValue.Equals(true) ? "S" : "N";
                                            break;
                                        }
                                    case "DATE":
                                        {
                                            //    valoresCampos[valoresCampos.Length - 1] = (DataGridView)
                                            break;
                                        }
                                }

                            }
                        }
                        else
                        {
                            valorClave = row.Cells[posicion - 1].Value.ToString();
                            columnaClave = oDetalle.DctColumna;
                        }
                    };
                    //FIN FOREACH DE DETALLES COLUMNA


                    string caso = row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString();

                    // Para cada registro deberia actualizar su estado si se pudo actualizar

                    if (!row.IsNewRow)
                        switch (caso)
                        {
                            case "1":
                                {
                                    // Update
                                    // Para cada campo validar que tenga el tipo de dato adecuado 
                                    // contra la estructura de la tabla que esta en _estructuraTablaGrilla datatable
                                    // Si todos los campos menos la clave son validos actualizo
                                    foreach (DataRow oCampo in _estructuraTablaGrilla.Rows)
                                    {
                                        int pos;
                                        pos = Array.IndexOf(nombreCampos, oCampo.ItemArray[2]);
                                        if (pos >= 0 && datosOK)
                                            datosOK = (oUtil.TipoDatoValido(valoresCampos[pos], oCampo.ItemArray[4].ToString()));
                                        //MessageBox.Show(oCampo.ItemArray[2].ToString()); // campo
                                    }
                                    if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "U"))
                                        row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
                                    break;
                                }
                            case "2":
                                {
                                    // Delete
                                    if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "D"))
                                    {
                                        _vista.grilla.Rows.Remove(row);
                                        row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
                                    }
                                    break;
                                }
                            case "3":
                                {
                                    // Insert
                                    // Para cada campo validar que tenga el tipo de dato adecuado 
                                    // contra la estructura de la tabla que esta en _estructuraTablaGrilla datatable
                                    // Si todos los campos inclusive la clave, si no es secuencia, son validos actualizo
                                    foreach (DataRow oCampo in _estructuraTablaGrilla.Rows)
                                    {
                                        int pos;
                                        pos = Array.IndexOf(nombreCampos, oCampo.ItemArray[2]);
                                        if (pos >= 0 && datosOK)
                                        {
                                            datosOK = (oUtil.TipoDatoValido(valoresCampos[pos], oCampo.ItemArray[4].ToString()));
                                            if (valoresCampos[pos] != null)
                                                datosOK = valoresCampos[pos].Length > 0 || oCampo.ItemArray[8].ToString() == "Y";
                                        }
                                    }
                                    if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "I"))
                                        row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
                                    break;
                                }
                        }

                };
                if (!datosOK)
                    MessageBox.Show("Error al actualizar los datos, Revice las filas resaltadas.");

            }

        }
    }
}
