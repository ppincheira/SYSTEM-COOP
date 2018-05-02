using Business;
using Model;
using System;
using Service;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Controles.datos;
using Controles.Fecha;

namespace AppProcesos.formsAuxiliares.frmCrudGrilla
{
    public partial class UICrudGrilla
    {
        #region VARIABLES
        private IVistaCrudGrilla _vista;
        Utility oUtil;
        private string _Campo;   //     SE CARGAN TODOS LOS NOMBRES DE LAS COLUMNAS Y SU DETALLE
                                 //     PARA DESPUES ARMAR A QUERY DE BUSQUEDA
        private string _Fecha;   //     UTILIZADO PARA EL FILTRO
        private string _Combos;  //     SE CARGA EL NOMBRE DE LA COLUMNA Y EL DETALLE DE COOLUMNA DE LOS DETALLESCOLUMNASTABLAS DETIPOC COMBO
        private string _Checks;  //     SE CARGA EL NOMBRE DE LA COLUMNA Y EL DETALLE DE COOLUMNA DE LOS DETALLESCOLUMNASTABLAS DETIPOC CHKCK
        private string _filtroCampos;
        private string _filtroValores;
        private DataTable _dtCombo;  //UTILIZADO PARA LA BUSQUEDA DE FILTR
        public string columnaClave = "";
        public bool insertarClave = false;
        public DataTable _estructuraTablaGrilla;
        bool ClaveSecuencia = false;
        string ColumnaClave = "";
        string Tabla;
        List<DetallesColumnasTablas> ListDetalle;
        #endregion


        #region METODOS CORE

        //PRIMER METODO EN EJECUTARCE AL CREARCE EL FORMULARIO
        //ENCARGADO DE ADAPTAR LA GRILLA PARA CONTENER TODO TIPO DE TABLAS
        public void Inicializar(string tabla, bool claveSecuencia)
        {
            Tabla = tabla;
            ClaveSecuencia = claveSecuencia;

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
            ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(tabla);

            /*  DE LAS COLUMAS QUE SE RECUPERAN DE LA BD, SE CONTROLA QUE TIPO DE CONTROL ES
             *  EN EL CASO DE SER COMBO O CHECK  
             *  
             *  NO SE QUE SE HACE CON LAS VARIABLES _Combos y _Check
             *  TAMBIEN SE HACE LA CARGA DE LA QUERY QUE LUEGO BUSCARA LOS DATOS
             */
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {
                if (oDetalle.DctNroOrden == 1)
                {
                    // ESTO ES PARA PODER GUARDAR EL NOMBRE DE LA COLUMNA
                    ColumnaClave = oDetalle.DctDescripcion;
                }

                //ACA SE PUEDEN CARGAR MAS CONTROLES PARA DARLE VERSATILIDAD A LA GRILLA
                switch (oDetalle.DctTipoControl)
                {
                    //          ESTO ESTOY MUY SEGURO QUE SE PUEDE OMITIR TOTAL MENTE......
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

            //CARGAR GRILLA
            _vista.grilla.AutoGenerateColumns = false;
            _vista.cantidad = oUtil.CargarGrilla(_vista.grilla, dt) + " registros";

            //SUBRUTINA ENCARGADA DE QUE LA GRILLA TENGA LAS COLUMNAS DEL TIPO NECESARIA
            generarDT(ListDetalle);
            //SUBRUTINA QUE ENLAZA LOS DATOS RECUPERADOS CON LA GRILLA YA PREPARADA
            vincularDT(_vista.grilla);


            //LA ULTIMA COLUMNA ES EL CONTROL PARA SABER SI LA FILA FUE CREADA, MODIFICADA O ELIMINADA
            _vista.grilla.Columns.Add("ALTERADO", "");
            _vista.grilla.Columns["ALTERADO"].Visible = false;

            if (claveSecuencia)
            {
                _vista.grilla.Columns[ColumnaClave].ReadOnly = true;
            }
            //ESTE METODO SE UTILIZARA PARA ACOMODAR LAS COLUMNAS, CELDAS O CUALQUEIR OTRA PROPIEDAD VISUAL
            //DE LA GRILLA, ORIENTADA A PERSONALIZAR MAS LA GRILLA DEPENDIENDO LA TABLA QUE SE LE PIDA 
            // TRABAJAR
            presonalizarGrilla(_vista.grilla, tabla);

            //SETEA TODAS LAS ROWS EN ESTADO SIN MODIFICACION
            foreach (DataGridViewRow row in _vista.grilla.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["ALTERADO"].Value = "0";
            }

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

        //ESTE METODO SE ENCARGA DE IMPACTAR LOS NUEVOS CAMBIOS A LA BASE DE DATOS
        public void ActualizaTabla(string Tabla, string campoClave, bool claveSecuencia)
        {
            // Obtener de DetallesColumnasTablas todos los campos de la tabla menos el campo clave
            // Pasar esos campos a un arreglo de campos y valores
            // actualizar
            bool datosOK = true;
            Tablas otabla = new Tablas();
            TablasBus tablasGrd = new TablasBus();
            otabla = tablasGrd.TablasGetById(Tabla);


            if (ListDetalle == null)
            {
                DetallesColumnasTablasBus oDetalleGrd = new DetallesColumnasTablasBus();
                ListDetalle = oDetalleGrd.DetallesColumnasTablasGetByCodigo(Tabla);
            }

            //ACA SE RECORREN TODAS LAS ROWS DE LA GRILLA
            foreach (DataGridViewRow row in _vista.grilla.Rows)
            {
                if (!row.IsNewRow)
                {
                    string caso = row.Cells["ALTERADO"].Value.ToString();
                    if (caso != "0")
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
                                    {
                                        if (row.Cells[posicion - 1].Value != null)
                                        {
                                            valoresCampos[valoresCampos.Length - 1] = row.Cells[posicion - 1].Value.ToString();
                                        }
                                        else
                                        {
                                            if (oDetalle.DctTipoControl == "CHKCK")
                                            {

                                                valoresCampos[valoresCampos.Length - 1] = ((DataGridViewCheckBoxCell)row.Cells[posicion - 1]).FalseValue.ToString();

                                            }

                                        }

                                    }

                                else
                                // Si la columna a actualizar no es visible tiene una homonima visible
                                // Busco la homonima visible y tomo su valor que es el que debo tener en cuenta para actualizar
                                //ACA TENDRIA QUE RECUPERAR EL VALOR DEL cmbLista, pero no lo hace!!!!!!!!!!!!

                                {
                                    object celda = row.Cells[oDetalle.DctColumna];

                                    switch (oDetalle.DctTipoControl)
                                    {
                                        case "COMBO":
                                            {
                                                valoresCampos[valoresCampos.Length - 1] = ((DataGridViewComboBoxCell)celda).Value.ToString();
                                                break;
                                            }
                                        case "CHKCK":
                                            {
                                                valoresCampos[valoresCampos.Length - 1] = ((DataGridViewCheckBoxCell)celda).Value.ToString();

                                                break;
                                            }
                                        case "FECHA":
                                            {
                                                valoresCampos[valoresCampos.Length - 1] = ((DataGridViewTextBoxCell)celda).Value.ToString();
                                                valoresCampos[valoresCampos.Length - 1] = valoresCampos[valoresCampos.Length - 1].Substring(0, 9);
                                                break;
                                            }
                                    }

                                }
                            }
                            else
                            {
                                if (row.Cells[posicion - 1].Value != null)
                                    valorClave = row.Cells[posicion - 1].Value.ToString();
                                columnaClave = oDetalle.DctColumna;
                            }
                        };
                        //FIN FOREACH DE DETALLES COLUMNA
                        // Para cada registro deberia actualizar su estado si se pudo actualizar
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
                                    if (claveSecuencia)
                                    {
                                        if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "IN"))
                                            row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
                                    }
                                    else
                                    {
                                        if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "I"))
                                            row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
                                    }


                                    break;
                                }
                        }

                    };
                    if (!datosOK)
                        MessageBox.Show("Error al actualizar los datos, Revice las filas resaltadas.");
                }
            }
        }

        //ESTE METODO SE ENCARGA DE REFRESCAR LOS DATOS DE LA GRILLA CUANDO OCURREN MODIFICACIONES
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
            if (_filtroValores == "&")
            {
                _filtroValores = "";
                _filtroCampos = "";
            }
            TablasBus oTablasBus = new TablasBus();
            DataTable dt = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidad = oUtil.CargarGrilla(_vista.grilla, dt) + " registros";
            vincularDT(_vista.grilla);
            foreach (DataGridViewRow row in _vista.grilla.Rows)
            {
                row.Cells["ALTERADO"].Value = "0";
            }
            _vista.cantidad = "Se encontraron " + _vista.grilla.RowCount.ToString() + " registros";
        }

        public UICrudGrilla(IVistaCrudGrilla vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }
        #endregion


        #region METODOS VARIABLES

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
                case "PVC":
                    {

                        break;
                    }
            }
        }

        //VINCULA LOS DATOS DEL DATASOURS CON LA GRILLA QUE SE ENCUENTRA VISIBLE
        private void vincularDT(grdGrillaEdit grilla)
        {
            DataTable aux = (DataTable)grilla.DataSource;
            grilla.DataSource = null;
            int i = 0;
            string arreglo = "";
            foreach (DataRow a in aux.Rows)
            {
                arreglo = "";
                for (i = 0; i < aux.Columns.Count; i++)
                {
                    if (aux.Columns[i].DataType.Name == "DateTime")
                    {
                        arreglo = arreglo + ((DateTime)a[i]).ToShortDateString() + "&";
                    }
                    else
                        arreglo = arreglo + a[i].ToString() + "&";

                }


                string[] algo = arreglo.Split('&');
                grilla.Rows.Add(arreglo.Split('&'));

            }
            //FIN DEL FOREACH
        }

        //SE ENCARGA DE GENERAR LA ESTRUCTURA DE LA GRILLA VISIBLE PARA PODER CONTENER LAS DISTINTAS TABLAS
        private void generarDT(List<DetallesColumnasTablas> lista)
        {
            grdGrillaEdit salidass = new grdGrillaEdit();
            salidass.AutoGenerateColumns = false;

            DataTable salida = new DataTable();

            foreach (DetallesColumnasTablas dct in lista)
            {
                switch (dct.DctTipoControl)
                {
                    case "TEXTO":
                        {
                            DataGridViewTextBoxColumn txt = new DataGridViewTextBoxColumn();
                            txt.Name = dct.DctDescripcion;
                            _vista.grilla.Columns.Add(txt);

                            break;
                        }
                    case "NUMERO":
                        {
                            DataGridViewTextBoxColumn txt = new DataGridViewTextBoxColumn();
                            txt.Name = dct.DctDescripcion;
                            _vista.grilla.Columns.Add(txt);

                            break;
                        }
                    case "COMBO":
                        {
                            #region LISTAS DEL COMBO
                            //   DataGridViewComboBoxCell cmb = new DataGridViewComboBoxCell();
                            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

                            cmb.HeaderText = dct.DctDescripcion;
                            cmb.Name = dct.DctColumna;

                            // CARGAR LA LISTA DE VALORES DEL COMBO
                            // EN CASO DE QUERER AGREGAR MAS PCIONES DE COMBO SOLO SE TIENE QUE HACER REFERENCIA 
                            // A SUS CLASES BISSNES
                            switch (dct.DctListaValores)
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
                                case "LOCALIDADES":
                                    {
                                        LocalidadesBus oLocalidadesBus = new LocalidadesBus();
                                        cmb.DataSource = oLocalidadesBus.LocalidadesGetAll();
                                        cmb.DisplayMember = "LocDescripcion";
                                        cmb.ValueMember = "LocNumero";
                                        break;
                                    }
                                case "TIPOS_BARRIOS_LOCALIDADES":
                                    {
                                        TiposBarriosLocalidadesBus oLocalidadesBus = new TiposBarriosLocalidadesBus();
                                        cmb.DataSource = oLocalidadesBus.TiposBarriosLocalidadesGetAll();
                                        cmb.DisplayMember = "TblDescripcion";
                                        cmb.ValueMember = "TblCodigo";
                                        break;
                                    }

                                case "TIPOS_COMPROBANTE":
                                    {
                                        TiposComprobanteBus oTiposComprobantes = new TiposComprobanteBus();

                                        cmb.DataSource = oTiposComprobantes.TiposComprobanteGetAll();
                                        cmb.DisplayMember = "TcoDescripcion";
                                        cmb.ValueMember = "TcoCodigo";
                                        break;
                                    }

                                case "PUNTOS_VENTAS":
                                    {
                                        PuntosVentasBus oPV = new PuntosVentasBus();
                                        cmb.DataSource = oPV.PuntosVentasGetAll();
                                        cmb.DisplayMember = "PvtDescripcion";
                                        cmb.ValueMember = "PvtNumero";
                                        break;
                                    }
                                //case "GRUPOS_CONCEPTOS_IMPUESTOS":
                                //    {
                                //        GruposConceptosImpuestosBus oGCI = new GruposConceptosImpuestosBus();
                                //        cmb.DataSource = oGCI.GruposConceptosImpuestosGetAll();
                                //        cmb.DisplayMember = "GciDescripcion";
                                //        cmb.ValueMember = "GciCodigo";
                                //        break;
                                //    }
                                case "TIPOS_GRUPOS_CONCEPTOS":
                                    {
                                        TiposGruposConceptosBus oTGC = new TiposGruposConceptosBus();
                                        cmb.DataSource = oTGC.TiposGruposConceptosGetAll();
                                        cmb.DisplayMember = "TgcDescripcion";
                                        cmb.ValueMember = "TgcCodigo";
                                        break;
                                    }
                                default: break;
                            }
                            _vista.grilla.Columns.Add(cmb);
                            //        salidass.Columns.Add(cmb);
                            break;
                            #endregion
                        }
                    case "CHKCK":

                        {
                            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                            chk.HeaderText = dct.DctDescripcion;
                            chk.Name = dct.DctColumna;

                            // COMO CADA TABLA VA A TENER SU PROPIO VAOR DE REFERENCIA SI SU ESTADO O OTRO VALOR QUE REQUIERA CHKCK
                            //  EN ESTA SECCION SE CONFIGURA PARA CADA TABLA QUE VALOR VALOR CORRESPONDE A VERDADERO
                            switch (Tabla)
                            {
                                case "PVC":
                                    {
                                        chk.TrueValue = "H";
                                        chk.FalseValue = "I";
                                        break;
                                    }
                                default:
                                    {
                                        chk.TrueValue = "S";
                                        chk.FalseValue = "N";
                                        break;
                                    }
                            }
                            _vista.grilla.Columns.Add(chk);
                            //     salidass.Columns.Add(chk);  
                            break;
                        }
                    case "FECHA":
                        {
                            ColumnaCalendario col = new ColumnaCalendario();
                            col.HeaderText = dct.DctDescripcion;

                            col.Name = dct.DctColumna;
                            _vista.grilla.Columns.Add(col);
                            //             salidass.Columns.Add(col);  
                            break;
                        }
                }

            }
            salida = (DataTable)salidass.DataSource;
        }

        #endregion



        public void MostrarTabla(string Tabla)
        {
            // Obtener de DetallesColumnasTablas todos los campos de la tabla menos el campo clave
            // Pasar esos campos a un arreglo de campos y valores
            // actualizar
            Tablas otabla = new Tablas();
            TablasBus tablasGrd = new TablasBus();
            tablasGrd.MostrarEstructura(Tabla);
        }






    }
}
