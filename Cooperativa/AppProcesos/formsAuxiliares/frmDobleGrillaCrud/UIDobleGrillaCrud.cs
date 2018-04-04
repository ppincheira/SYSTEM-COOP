using Business;
using Model;
using System;
using Service;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Controles.datos;
using Controles.labels;
using FormsAuxiliares;

namespace AppProcesos.formsAuxiliares.frmCrudGrilla
{
    public partial class UIDobleGrillaCrud
    {
        private IVistaDobleGrillaCrud _vista;
        Utility oUtil;

        #region PROPIEDADES OLD
        private string _Campo;
        private string _filtroCampos = "";
        private string _filtroValores = "";
        private DataTable _dtCombo;
        public string columnaClave = "";
        public bool insertarClave = false;
        public DataTable _estructuraTablaGrilla;
        #endregion

        #region PROPIEDADES NEW
        string tablaNexo = "";
        string _camposSecundarios = "", tablaSecundaria = "";
        string clavePrimaria = "", tablaPrimaria = "", _camposPrimarios = "";
        #endregion



        public UIDobleGrillaCrud(IVistaDobleGrillaCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar(string tabla, string tabla2, string nexoTablas, string campoClave1, string campoClave2)
        /*
         *  CONSIDERANDO LA NUEVA IDEA EN TABLA2 VA A ESTAR EL NEXO DE CAMPOS
         */
        {
            tablaPrimaria = tabla;
            tablaSecundaria = tabla2;
            tablaNexo = nexoTablas;
            _camposPrimarios = campoClave1;
            _camposSecundarios = campoClave2;
            _dtCombo = new DataTable();
            _dtCombo.Columns.Add("DctColumna", typeof(string));
            _dtCombo.Columns.Add("DctDescripcion", typeof(string));

            DataTable dt = new DataTable();
            DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
            List<DetallesColumnasTablas> list = oDetalleBus.DetallesColumnasTablasGetByCodigo(tablaSecundaria);
            foreach (DetallesColumnasTablas oDetalle in list)
            {
                foreach (string a in _camposSecundarios.Split('&'))
                {
                    if (oDetalle.DctColumna == a)
                    {
                        _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                        dt.Columns.Add(oDetalle.DctDescripcion);
                        if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                        {
                            _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                        }
                    }
                }
            }
            if (_Campo.Length > 0)
                _Campo = _Campo.Substring(0, _Campo.Length - 1);
            //SE CARGA EL COMBO DE BUSQUEDA
            oUtil.CargarCombo(_vista.busquedaSecundaria, _dtCombo, "DctColumna", "DctDescripcion");

            _dtCombo = new DataTable();
            _dtCombo.Columns.Add("DctColumna", typeof(string));
            _dtCombo.Columns.Add("DctDescripcion", typeof(string));

            dt = new DataTable();
            _Campo = "";
            list = oDetalleBus.DetallesColumnasTablasGetByCodigo(tablaPrimaria);
            foreach (DetallesColumnasTablas oDetalle in list)
            {
                foreach (string a in _camposPrimarios.Split('&'))
                {
                    if (oDetalle.DctColumna == a)
                    {
                        _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                        dt.Columns.Add(oDetalle.DctDescripcion);
                        if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                        {
                            _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                        }
                    }
                }
            }

            if (_Campo.Length > 0)
                _Campo = _Campo.Substring(0, _Campo.Length - 1);
            //SE CARGA EL COMBO DE BUSQUEDA
            oUtil.CargarCombo(_vista.busquedaPrimaria, _dtCombo, "DctColumna", "DctDescripcion");
            TablasBus oTablasBus = new TablasBus();
            _vista.lblEtiqueta1.Text = oTablasBus.TablasGetById(tabla).TabNombre;
            _vista.lblEtiqueta2.Text = oTablasBus.TablasGetById(tabla2).TabNombre;
            dt = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
            _vista.cantidadPrimaria = "Se encontraron: " + oUtil.CargarGrilla(_vista.grillaPrimaria, dt) + " registros";
        }

        public void Guardar()
        {
            try
            {
                switch (tablaNexo)
                {
                    case "FUNCIONALIDADES_ROLES":
                        {

                            FuncionalidadesRolesBus oRolFunBus = new FuncionalidadesRolesBus();
                            List<FuncionalidadesRoles> listaRF = new List<FuncionalidadesRoles>();
                            FuncionalidadesBus oFunBus = new FuncionalidadesBus();
                            Funcionalidades oFuncionalidades = new Funcionalidades();
                            FuncionalidadesRoles oRF;

                            listaRF = oRolFunBus.FuncionalidadesGetById(clavePrimaria);

                            foreach (FuncionalidadesRoles b in listaRF)
                            {
                                oRolFunBus.FuncionalidadesDelete(b.RolCodigo);
                            }
                            int cantidad = 0;
                            foreach (DataGridViewRow a in _vista.grillaSecundaria.Rows)
                            {
                                oRF = new FuncionalidadesRoles();
                                oRF.RolCodigo = clavePrimaria;

                                oRF.FunCodigo = ((DataGridViewTextBoxCell)a.Cells[0]).FormattedValue.ToString();
                                oRolFunBus.FuncionalidadesAdd(oRF);
                                cantidad++;
                            }
                            MessageBox.Show("Se agregaron " + cantidad + " de registros exitosamente");
                            break;
                        }

                    case "FUNCIONALIDADES_USUARIOS":
                        {
                            FuncionalidadesUsuariosBus oUsuariosFun = new FuncionalidadesUsuariosBus();
                            List<FuncionalidadesUsuarios> listaUF = new List<FuncionalidadesUsuarios>();

                            FuncionalidadesBus oFunBus = new FuncionalidadesBus();
                            Funcionalidades oFuncionalidades = new Funcionalidades();
                            FuncionalidadesUsuarios oUF;

                            listaUF = oUsuariosFun.FuncionalidadesUsuariosGetById(clavePrimaria);


                            foreach (FuncionalidadesUsuarios b in listaUF)
                            {
                                oUsuariosFun.FuncionalidadesUsuariosDelete(b.FunCodigo, b.UsrNumero, b.RolCodigo);
                            }
                            int cantidad = 0;
                            foreach (DataGridViewRow a in _vista.grillaSecundaria.Rows)
                            {
                                oUF = new FuncionalidadesUsuarios();
                                oUF.UsrNumero = int.Parse(clavePrimaria);

                                oUF.FunCodigo = ((DataGridViewTextBoxCell)a.Cells[0]).FormattedValue.ToString();
                                oUsuariosFun.FuncionalidadesUsuariosAdd(oUF);
                                cantidad++;
                            }
                            MessageBox.Show("Se agregaron " + cantidad + " de registros exitosamente");
                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algunos registros no se pudiergon guardar, esto se suele dar por ya estar incluidos. Para mas informacion el codigo de error es:" + ex.Message);
            }
        }

        public void Eliminar()
        {
            foreach (DataGridViewRow a in _vista.grillaSecundaria.SelectedRows)
            {
                _vista.grillaSecundaria.Rows.Remove(a);
            }
        }

        public bool agregarRegistros()
        {
            bool salida = false;
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = tablaSecundaria;
            oAdmin.Tipo = Admin.enumTipoForm.SelectorMultiSeleccion;
            frmFormAdmin frmbus = new frmFormAdmin(oAdmin, oPermiso);

            frmbus.ShowDialog();
            String recuperado = frmbus._strDatosSeleccionados;
            if (recuperado != null && recuperado.Length > 0)
            {
                recuperado = recuperado.Substring(0, recuperado.Length - 1);

                string[] valores = recuperado.Split('&');
                switch (tablaSecundaria)
                {
                    case "FUN":
                        {
                            FuncionalidadesBus oFunBus = new FuncionalidadesBus();
                            Funcionalidades oFuncionalidades = new Funcionalidades();
                            List<Funcionalidades> listaRF = new List<Funcionalidades>();
                            foreach (string a in valores)
                            {
                                oFuncionalidades = oFunBus.FuncionalidadesGetById(a);
                                DataTable dt = (DataTable)_vista.grillaSecundaria.DataSource;
                                string[] camposCargar = _camposSecundarios.Split('&');
                                string cargar = "";
                                foreach (string b in camposCargar)
                                {
                                    switch (b)
                                    {
                                        case "FUN_CODIGO":
                                            {
                                                cargar = cargar + oFuncionalidades.FunCodigo + "&";
                                                break;
                                            }
                                        case "FUN_DESCRIPCION":
                                            {
                                                cargar = cargar + oFuncionalidades.FunDescripcion + "&";
                                                break;
                                            }
                                        case "FUN_FUNCIONALIDAD":
                                            {
                                                cargar = cargar + oFuncionalidades.FunFuncionalidad + "&";
                                                break;
                                            }
                                        case "SBS_CODIGO":
                                            {
                                                cargar = cargar + oFuncionalidades.SbsCodigo + "&";
                                                break;
                                            }
                                        case "FFO_CODIGO":
                                            {
                                                cargar = cargar + oFuncionalidades.ffoCodigo + "&";
                                                break;
                                            }
                                    }
                                }
                                if (cargar.Length > 0)
                                    cargar = cargar.Substring(0, cargar.Length - 1);
                                camposCargar = cargar.Split('&');
                                dt.Rows.Add(cargar.Split('&'));
                            }
                            break;
                        }
                }
                salida = true;
            }

            return salida;






        }

        public void CargarGrillaSecundaria()
        {
            try
            {
                clavePrimaria = _vista.grillaPrimaria.SelectedCells[0].Value.ToString();
                _filtroCampos = "";
                _filtroValores = "";
                _Campo = "";
                string[] columnas = _camposSecundarios.Split('&');
                DataTable dt = new DataTable();
                DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
                List<DetallesColumnasTablas> list = oDetalleBus.DetallesColumnasTablasGetByCodigo(tablaSecundaria);
                foreach (DetallesColumnasTablas oDetalle in list)
                {
                    foreach (string a in columnas)
                    {
                        if (oDetalle.DctColumna == a)
                        {
                            _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                            dt.Columns.Add(oDetalle.DctDescripcion);
                            if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                            {
                                //    _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                            }
                        }
                    }
                }
                if (_Campo.Length > 0)
                    _Campo = _Campo.Substring(0, _Campo.Length - 1);
                //SE CARGA EL COMBO DE BUSQUEDA
                /*   oUtil.CargarCombo(_vista.comboBuscar, _dtCombo, "DctColumna", "DctDescripcion");
                   if (_Campo.Length > 0)
                       _Campo = _Campo.Substring(0, _Campo.Length - 1);
                */
                TablasBus oTablasBus = new TablasBus();
                Tablas oTabla = oTablasBus.TablasGetById(tablaSecundaria);
                string codigo1 = _camposPrimarios.Split('&')[0];
                string codigo2 = _camposSecundarios.Split('&')[0];
                switch (tablaNexo)
                {
                    case "FUNCIONALIDADES_ROLES":
                        {
                            FuncionalidadesRolesBus oFuncionalidadesRol = new FuncionalidadesRolesBus();
                            List<FuncionalidadesRoles> listaRF = oFuncionalidadesRol.FuncionalidadesGetById(clavePrimaria);
                            FuncionalidadesBus oFunBus = new FuncionalidadesBus();
                            Funcionalidades oFuncionalidades = new Funcionalidades();

                            foreach (FuncionalidadesRoles a in listaRF)
                            {
                                oFuncionalidades = oFunBus.FuncionalidadesGetById(a.FunCodigo);
                                cargarDT(dt, oFuncionalidades);
                                //dt.Rows.Add(oFuncionalidades.FunCodigo, oFuncionalidades.FunDescripcion, oFuncionalidades.FunFuncionalidad, oFuncionalidades.ffoCodigo);
                            }
                            break;
                        }

                    case "FUNCIONALIDADES_USUARIOS":
                        {
                            FuncionalidadesUsuariosBus oFuncionalidadesUsr = new FuncionalidadesUsuariosBus();
                            List<FuncionalidadesUsuarios> listaUF = oFuncionalidadesUsr.FuncionalidadesUsuariosGetById(clavePrimaria);
                            FuncionalidadesBus oFunBus = new FuncionalidadesBus();
                            Funcionalidades oFuncionalidades = new Funcionalidades();

                            foreach (FuncionalidadesUsuarios a in listaUF)
                            {
                                oFuncionalidades = oFunBus.FuncionalidadesGetById(a.FunCodigo);
                                cargarDT(dt, oFuncionalidades);
                                //dt.Rows.Add(oFuncionalidades.FunCodigo, oFuncionalidades.FunDescripcion, oFuncionalidades.FunFuncionalidad, oFuncionalidades.ffoCodigo);
                            }
                            break;
                        }
                }
                _vista.cantidadSecundaria = "Se encontraron: " + oUtil.CargarGrilla(_vista.grillaSecundaria, dt) + " registros";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarDT(DataTable dt, Object oObjeto)
        {
            string[] columnas = _camposSecundarios.Split('&');
            string[] cargar = new string[(columnas.Length)];
            int control = 0;
            switch (tablaSecundaria)
            {
                case "FUN":
                    {
                        Funcionalidades oFuncionalidades = (Funcionalidades)oObjeto;
                        foreach (string a in columnas)
                        {
                            control = 0;
                            foreach (string b in columnas)
                            {
                                switch (b)
                                {
                                    case "FUN_CODIGO":
                                        {
                                            cargar[control] = oFuncionalidades.FunCodigo;
                                            control++;
                                            break;
                                        }
                                    case "FUN_DESCRIPCION":
                                        {
                                            cargar[control] = oFuncionalidades.FunDescripcion;
                                            control++;
                                            break;
                                        }
                                    case "FUN_FUNCIONALIDAD":
                                        {
                                            cargar[control] = oFuncionalidades.FunFuncionalidad;
                                            control++;
                                            break;
                                        }
                                    case "SBS_CODIGO":
                                        {
                                            cargar[control] = oFuncionalidades.SbsCodigo;
                                            control++;
                                            break;
                                        }
                                    case "FFO_CODIGO":
                                        {
                                            cargar[control] = oFuncionalidades.ffoCodigo + "";
                                            control++;
                                            break;
                                        }
                                }
                            }

                        }
                        break;
                    }




            }


            dt.Rows.Add(cargar);
        }


        //CONTROLAR COMO BUSCA Y COMO TRAE LOS DATOS 
        public void CargarGrilla(string codigo)
        {
            cmbLista comboBuscar = new cmbLista();
            grdGrillaEdit grilla = new grdGrillaEdit();
            _filtroCampos = "";
            _filtroValores = "";
            string tabla = "";
            switch (codigo)
            {
                case "1":
                    {
                        comboBuscar = _vista.busquedaPrimaria;
                        _filtroValores = _vista.filtro1;
                        tabla = tablaPrimaria;
                        grilla = _vista.grillaPrimaria;
                        _Campo = _camposPrimarios;
                        break;
                    }
                case "2":
                    {
                        comboBuscar = _vista.busquedaSecundaria;
                        tabla = tablaSecundaria;
                        grilla = _vista.grillaSecundaria;
                        _filtroValores = _vista.filtro2;
                        _Campo = _camposSecundarios;
                        break;
                    }
            }
            _filtroCampos = comboBuscar.SelectedValue.ToString();
            TablasBus oTablasBus = new TablasBus();
            grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo.Replace('&', ','), _filtroCampos, _filtroValores);
            switch (codigo)
            {
                case "1":
                    {
                        _vista.cantidadPrimaria = "Se encontraron " + _vista.grillaPrimaria.RowCount.ToString() + " registros";
                        break;
                    }
                case "2":
                    {
                        _vista.cantidadSecundaria = "Se encontraron " + _vista.grillaSecundaria.RowCount.ToString() + " registros";
                        break;
                    }
            }

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
            //Obtener de DetallesColumnasTablas todos los campos de la tabla menos el campo clave
            //Pasar esos campos a un arreglo de campos y valores
            //actualizar
            //bool datosOK = true;
            //Tablas otabla = new Tablas();
            //TablasBus tablasGrd = new TablasBus();
            //otabla = tablasGrd.TablasGetById(Tabla);

            //DetallesColumnasTablasBus oDetalleGrd = new DetallesColumnasTablasBus();
            //List<DetallesColumnasTablas> ListDetalle = oDetalleGrd.DetallesColumnasTablasGetByCodigo(Tabla);

            //ACA SE RECORREN TODAS LAS ROWS DE LA GRILLA
            //foreach (DataGridViewRow row in _vista.grilla.Rows)
            //{
            //    if (!row.IsNewRow)
            //    {
            //        string[] nombreCampos = { };
            //        string[] valoresCampos = { };
            //        string valorClave = "";
            //        string columnaClave = "";
            //        int posicion = 0;

            //        Actualizar tabla

            //        /*
            //         * EN ESTA SECUENCIA SE BUSCA COMPLETAR
            //         * nombresCampos = CON LOS NOMBRES DE LAS COLUMNAS
            //         * valoresCampos = CON SUS VALORES CORRESPONDIENTES
            //         */

            //        ESTO NO CONTIENE TODA LA TABLA QUE SE RECUPERA...SOLO TRAE LO VISIBLE..
            //        foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            //        {
            //            posicion++;
            //            if (oDetalle.DctDescripcion != campoClave || (row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString() == "3" && oDetalle.DctDescripcion == campoClave && !claveSecuencia))
            //            {
            //                Array.Resize(ref nombreCampos, nombreCampos.Length + 1);
            //                Array.Resize(ref valoresCampos, valoresCampos.Length + 1);
            //                nombreCampos[nombreCampos.Length - 1] = oDetalle.DctColumna;

            //                if (row.Cells[posicion - 1].Visible)
            //                    if (row.Cells[posicion - 1].ValueType == typeof(DateTime))
            //                    {
            //                        String fechatmp;
            //                        fechatmp = row.Cells[posicion - 1].FormattedValue.ToString();
            //                        valoresCampos[valoresCampos.Length - 1] = fechatmp;
            //                    }
            //                    else
            //                        valoresCampos[valoresCampos.Length - 1] = row.Cells[posicion - 1].Value.ToString();
            //                else
            //                    Si la columna a actualizar no es visible tiene una homonima visible
            //                 Busco la homonima visible y tomo su valor que es el que debo tener en cuenta para actualizar
            //                ACA TENDRIA QUE RECUPERAR EL VALOR DEL cmbLista, pero no lo hace!!!!!!!!!!!!

            //                {
            //                    OJOO
            //                    object celda = row.Cells[oDetalle.DctColumna];
            //                    COMBO
            //                    DataGridViewComboBoxColumn
            //                    CHKBOX
            //                     DataGridViewCheckBoxColumn
            //                    switch (oDetalle.DctTipoControl)
            //                    {
            //                        case "COMBO":
            //                            {
            //                                valoresCampos[valoresCampos.Length - 1] = ((DataGridViewComboBoxCell)celda).Value.ToString();
            //                                break;
            //                            }
            //                            CONTROLA LA ESCRITURA
            //                        case "CHKCK":
            //                            {
            //                                valoresCampos[valoresCampos.Length - 1] = ((DataGridViewCheckBoxColumn)celda).TrueValue.Equals(true) ? "S" : "N";
            //                                break;
            //                            }
            //                        case "DATE":
            //                            {
            //                                valoresCampos[valoresCampos.Length - 1] = (DataGridView)
            //                                break;
            //                            }
            //                    }

            //                }
            //            }
            //            else
            //            {
            //                valorClave = row.Cells[posicion - 1].Value.ToString();
            //                columnaClave = oDetalle.DctColumna;
            //            }
            //        };
            //        FIN FOREACH DE DETALLES COLUMNA


            //        string caso = row.Cells[_vista.grilla.ColumnCount - 1].Value.ToString();

            //        Para cada registro deberia actualizar su estado si se pudo actualizar

            //        if (!row.IsNewRow)
            //            switch (caso)
            //            {
            //                case "1":
            //                    {
            //                        Update
            //                        Para cada campo validar que tenga el tipo de dato adecuado
            //                         contra la estructura de la tabla que esta en _estructuraTablaGrilla datatable
            //                         Si todos los campos menos la clave son validos actualizo
            //                        foreach (DataRow oCampo in _estructuraTablaGrilla.Rows)
            //                        {
            //                            int pos;
            //                            pos = Array.IndexOf(nombreCampos, oCampo.ItemArray[2]);
            //                            if (pos >= 0 && datosOK)
            //                                datosOK = (oUtil.TipoDatoValido(valoresCampos[pos], oCampo.ItemArray[4].ToString()));
            //                            MessageBox.Show(oCampo.ItemArray[2].ToString()); // campo
            //                        }
            //                        if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "U"))
            //                            row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
            //                        break;
            //                    }
            //                case "2":
            //                    {
            //                        Delete
            //                        if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "D"))
            //                        {
            //                            _vista.grilla.Rows.Remove(row);
            //                            row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
            //                        }
            //                        break;
            //                    }
            //                case "3":
            //                    {
            //                        Insert
            //                        Para cada campo validar que tenga el tipo de dato adecuado
            //                         contra la estructura de la tabla que esta en _estructuraTablaGrilla datatable
            //                         Si todos los campos inclusive la clave, si no es secuencia, son validos actualizo
            //                        foreach (DataRow oCampo in _estructuraTablaGrilla.Rows)
            //                        {
            //                            int pos;
            //                            pos = Array.IndexOf(nombreCampos, oCampo.ItemArray[2]);
            //                            if (pos >= 0 && datosOK)
            //                            {
            //                                datosOK = (oUtil.TipoDatoValido(valoresCampos[pos], oCampo.ItemArray[4].ToString()));
            //                                if (valoresCampos[pos] != null)
            //                                    datosOK = valoresCampos[pos].Length > 0 || oCampo.ItemArray[8].ToString() == "Y";
            //                            }
            //                        }
            //                        if (datosOK && tablasGrd.TablaActualizaGrid(otabla.TabNombre, nombreCampos, valoresCampos, columnaClave + "='" + valorClave + "'", "I"))
            //                            row.Cells[_vista.grilla.ColumnCount - 1].Value = "0";
            //                        break;
            //                    }
            //            }

            //    };
            //    if (!datosOK)
            //        MessageBox.Show("Error al actualizar los datos, Revice las filas resaltadas.");

            //}

        }
    }
}
