using System;
using Model;
using AppProcesos.formsAuxiliares.formAdmin;
using GesServicios.controles.forms;
using Controles.datos;
using Service;
using Controles.form;
using System.Windows.Forms;
using static Model.Admin;
using System.Reflection;
using GesSeguridad.controles.forms;
using System.Data;
using GesConfiguracion.controles.forms;

namespace FormsAuxiliares
{
    public partial class frmFormAdminMini : gesForm, IVistaFormAdmin
    {


        #region << PROPIEDADES >>
        public Admin _oAdmin;
        public FuncionalidadesFoms _oPermiso;
        public string _strRdoCodigo;
        public string _strDatosSeleccionados;
        Utility _oUtil;
        private UIFormAdmin _oFormAdmin;
        private DataTable _dtFiltro;

        #endregion

        #region Implementation of IVistaAdminMini

        public Admin oiAdmin
        {
            get { return _oAdmin; }
            set { _oAdmin = value; }
        }
        public Boolean grupoEstado
        {
            get { return this.gpbGrupoEstado.Visible; }
            set { this.gpbGrupoEstado.Visible = value; }
        }
        public Boolean grupoFecha
        {
            get { return this.gpbFecha.Visible; }
            set { this.gpbFecha.Visible = value; }
        }

        public grdGrillaAdmin grilla
        {
            get { return this.dgBusqueda; }
            set { this.dgBusqueda = value; }
        }
        public grdGrillaAdmin grillaFiltro
        {
            get { return this.grdGrillaFiltro; }
            set { this.grdGrillaFiltro = value; }
        }
        public DateTime fechaDesde
        {
            get { return this.dtpFechaDesde.Value; }
            set { this.dtpFechaDesde.Value = value; }
        }
        public DateTime fechaHasta
        {
            get { return this.dtpFechaHasta.Value; }
            set { this.dtpFechaHasta.Value = value; }
        }
        public cmbLista comboBuscar
        {
            get { return this.cmbBuscar; }
            set { this.cmbBuscar = value; }
        }
        public cmbLista comboBuscarA
        {
            get { return this.cmbBuscarA; }
            set { this.cmbBuscarA = value; }
        }
        public cmbLista comboOpcionesA
        {
            get { return this.cmbOpcionesA; }
            set { this.cmbOpcionesA = value; }
        }
        public DataTable dtiFiltro
        {
            get { return _dtFiltro; }
            set { _dtFiltro = value; }
        }
        public string filtro
        {
            get { return this.txtFiltro.Text; }
            set { this.txtFiltro.Text = value; }
        }
        public cmbLista comboEstado
        {
            get { return this.cmbEstado; }
            set { this.cmbEstado = value; }
        }

   
        public string cantidad
        {

            set { this.lblCantidad.Text = value; }
        }

        public string striRdoCodigo
        {
            get { return _strRdoCodigo; }
            set { _strRdoCodigo = value; }
        }


        public string striValor1
        {
            get { return this.txtValor1.Text; }
            set { this.txtValor1.Text = value; }
        }
        public string striValor2
        {
            get { return this.txtValor2.Text; }
            set { this.txtValor2.Text = value; }
        }
        public string striValor3
        {
            get { return this.txtValor3.Text; }
            set { this.txtValor3.Text = value; }
        }
        public string striValor4
        {
            get { return this.txtValor4.Text; }
            set { this.txtValor4.Text = value; }
        }
        public string striValor5
        {
            get { return this.txtValor5.Text; }
            set { this.txtValor5.Text = value; }
        }
        public string striValor6
        {
            get { return this.txtValor6.Text; }
            set { this.txtValor6.Text = value; }
        }


        #endregion

        #region << EVENTOS >>
        public frmFormAdminMini(Admin oAdmin, FuncionalidadesFoms oPerForm)
        {
            try
            {
                InitializeComponent();
                AsignarFuncionalidad(oPerForm);
                this._oPermiso = oPerForm;
                _oAdmin = oAdmin;
                _oFormAdmin = new UIFormAdmin(this);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "frmFormAdminMini",
                                "frmFormAdminMini",
                                this.FindForm().Name);
            }

        }

        private void frmFormAdminMini_Load(object sender, EventArgs e)
        {
            try
            {
                if (_oAdmin.Tipo == enumTipoForm.SelectorMultiSeleccion) { 
                    this.dgBusqueda.MultiSelect = true;
                    this.btnAceptar.Visible = true;
                }
                CargarOpciones("1");
                _oFormAdmin.Inicializar(_oAdmin);
                _oUtil = new Utility();
                _oUtil.HabilitarAllControlesInTrue(this, 1, "frmFormAdmin");
               
                if (this.dgBusqueda.RowCount > 0)
                    dgBusqueda.CurrentCell = dgBusqueda.Rows[0].Cells[1];
                switch (_oAdmin.TabCodigo)
                {
                    case "SCAT":
                        this.dgBusqueda.Columns["DESCRIPCION"].Visible = false;
                        this.Text = "Categorias";
                        break;
                    case "TETE":
                        this.Text = "TELEFONOS";
                        this.dgBusqueda.Columns["DEFECTO"].Visible = false;
                        _oFormAdmin.MarcarSeleccion(_oAdmin.TabCodigo);
                        break;
                    case "USUS":
                        this.Text = "Usuarios";
                        break;
                }

                if (_oAdmin.Tipo == enumTipoForm.FiltroAndAlta)
                {
                    Nuevo();
                }               
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();

            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
               Editar();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex, e.ToString(),
                    ((Control) sender).Name,
                    this.FindForm().Name);
            }


        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                Ver();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_oUtil.ExportarDataGridViewExcel(this.dgBusqueda))
                    MessageBox.Show("Se completo la exportación a Excel", "APP");



            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _oFormAdmin.CargarGrilla(_oAdmin);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }
        private void dgBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    AccionOptativa();

                }
                
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }

        private void dgBusqueda_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                AccionOptativa();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void dgBusqueda_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _oFormAdmin.Seleccion();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }   
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string msje = "";
            bool band = false;
            if (this.cmbBuscarA.SelectedValue.ToString() == "0")
            {
                msje += "Debe seleccionar Parametro de Busqueda \n";
                band = true;
            }


            if (this.cmbOpcionesA.SelectedValue.ToString() == "0")
            {
                msje += "Debe seleccionar el operador \n";
                band = true;
            }

            switch (this.cmbOpcionesA.SelectedValue.ToString())
            {
                case "10":
                    if ((this.txtValor2.Text == "") && (this.txtValor3.Text == ""))
                    {
                        msje += "Deben estar completos los dos Valores \n";
                        this.txtValor2.Focus();
                        band = true;
                    }
                    break;
                case "11":
                    if ((this.txtValor2.Text == "") && (this.txtValor3.Text == "") && (this.txtValor4.Text == "") && (this.txtValor5.Text == "") && (this.txtValor6.Text == ""))
                    {
                        msje += "Deben estar completos los valores para la lista \n";
                        band = true;
                    }
                    break;
                case "12":
                    if ((this.txtValor2.Text == "") && (this.txtValor3.Text == "") && (this.txtValor4.Text == "") && (this.txtValor5.Text == "") && (this.txtValor6.Text == ""))
                    {
                        msje += "Deben estar completos los valores para la lista \n";
                        band = true;
                    }
                    break;
                default:
                    if (this.txtValor1.Text == "")
                    {
                        msje += "El Valor debe estar completo \n";
                        band = true;
                    }
                    break;
            }
            if (band)
                MessageBox.Show(msje, "Buscador Avanzado", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            else
                _oFormAdmin.CargarDataTable();
        }

        private void cmbOpcionesA_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarOpciones(this.cmbOpcionesA.SelectedValue.ToString());
        }

        private void btnEliminarAvanzada_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.grillaFiltro.CurrentRow;
            if (row != null)
            {
                _oFormAdmin.Eliminar(row.Index);
            }
        }
        #endregion
        #region << METODOS >>
        public void AsignarFuncionalidad(FuncionalidadesFoms oPerForm)
        {
            //Esta funcion asigna la funcionalidad a los controles de este dinamico
            this.btnNuevo.FUN_CODIGO = oPerForm.New;
            this.btnEditar.FUN_CODIGO = oPerForm.Edit;
            this.btnExportar.FUN_CODIGO = oPerForm.Exp;
            this.btnEliminar.FUN_CODIGO = oPerForm.Del;
            this.btnImprimir.FUN_CODIGO = oPerForm.Imp;
        }

        public void CargarOpciones(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "2":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "3":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "4":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "5":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "6":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "7":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "8":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "9":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = false;
                    this.txtValor3.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "10":
                    this.txtValor1.Visible = true;
                    this.txtValor2.Visible = true;
                    this.txtValor3.Visible = true;
                    this.txtValor1.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "11":
                    this.txtValor1.Visible = false;
                    this.txtValor2.Visible = true;
                    this.txtValor3.Visible = true;
                    this.txtValor4.Visible = true;
                    this.txtValor5.Visible = true;
                    this.txtValor6.Visible = true;
                    break;
                case "12":
                    this.txtValor1.Visible = false;
                    this.txtValor2.Visible = true;
                    this.txtValor3.Visible = true;
                    this.txtValor4.Visible = true;
                    this.txtValor5.Visible = true;
                    this.txtValor6.Visible = true;
                    break;






            }
        }
        private void AccionOptativa()
        {
            switch (_oAdmin.Tipo)
            {
                case enumTipoForm.Selector:
                    if (_strRdoCodigo != "")
                        DialogResult = DialogResult.OK; //cierra el formulario    
                    else
                        DialogResult = DialogResult.No;
                    this.Close();
                    break;
                case enumTipoForm.FiltroAndAlta:
                    if (_strRdoCodigo != "")
                        DialogResult = DialogResult.OK; //cierra el formulario    
                    else
                        DialogResult = DialogResult.No;
                    this.Close();
                    break;
                case enumTipoForm.FiltroAndEditar:
                    if (_strRdoCodigo != "")
                        DialogResult = DialogResult.OK; //cierra el formulario    
                    else
                        DialogResult = DialogResult.No;
                    this.Close();
                    break;
                case enumTipoForm.Ninguna:
                    Editar();
                    break;
            }
        }
        private void Nuevo()
        {

            switch (_oAdmin.TabCodigo)
            {
                case "CALB":
                    frmCallesCrud oFrmCalCrud = new frmCallesCrud(0, "NQ");
                    if (oFrmCalCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "SRUT":

                    frmRutasCrud oFrmRutCrud = new frmRutasCrud(0, "H");
                    if (oFrmRutCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TCS":
                    frmTiposConexionesCrud oFrmTCSCrud = new frmTiposConexionesCrud("", "H");

                    if (oFrmTCSCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "":
                    Console.WriteLine("Case 2");
                    break;
                case "COPB":

                    frmCodigoPostalCrud oFrmCodPostalCrud = new frmCodigoPostalCrud(0, "NQ");
                    if (oFrmCodPostalCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TME":
                    frmTiposMedidoresCrud oFrmTiposMedidores = new frmTiposMedidoresCrud(0, "");
                    if (oFrmTiposMedidores.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;

                case "FAB":

                    frmFabricantesCrud oFrmFabricantes = new frmFabricantesCrud(0, "");
                    if (oFrmFabricantes.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "SCAT":

                    frmCategoriasCrud oFrmCatCrud = new frmCategoriasCrud(0, "I");
                    if (oFrmCatCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "LEC":
                    frmLecturasConceptosCrud oFrmLecCrud = new frmLecturasConceptosCrud(0, "");
                    if (oFrmLecCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TETE":
                    frmTelefonosCrud oFrmTel = new frmTelefonosCrud(0, _oAdmin, "I");
                    if (oFrmTel.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TEEM":
                    frmTelefonosCrud oFrmTeem = new frmTelefonosCrud(0, _oAdmin, "I");
                    if (oFrmTeem.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;

                case "LEM":
                    frmLecturasModosCrud oFrmLemCrud = new frmLecturasModosCrud(0, "I");
                    oFrmLemCrud._oFuncionalidad = _oPermiso;
                    if (oFrmLemCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "USUS":
                    frmUsuariosCrud ofrmUsu = new frmUsuariosCrud(0, "I", 0);
                    if (ofrmUsu.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "CPT":
                    frmConceptosCrud oFrmCptCrud = new frmConceptosCrud(0, "I");
                    if (oFrmCptCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "GII":
                    frmGruposImpuestosItemsCrud oFrmGiiCrud = new frmGruposImpuestosItemsCrud(0, "I");
                    if (oFrmGiiCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;

            }

        }
        private void Ver() {

            DataGridViewRow row = this.dgBusqueda.CurrentRow;

            switch (_oAdmin.TabCodigo)
            {
                case "CALB":
                    long idCalle = Convert.ToInt64(row.Cells[0].Value);
                    frmCallesCrud oFrmCalCrud = new frmCallesCrud(idCalle, "NQ");
                    oFrmCalCrud.gbDatos.Enabled = false;
                    if (oFrmCalCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "SRUT":
                    long idRuta = Convert.ToInt64(row.Cells[0].Value);
                    frmRutasCrud oFrmRutCrud = new frmRutasCrud(idRuta, "H");
                    oFrmRutCrud.gbDatos.Enabled = false;
                    if (oFrmRutCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TCS":
                    string idTCS = row.Cells[0].Value.ToString();
                    frmTiposConexionesCrud oFrmTCSCrud = new frmTiposConexionesCrud(idTCS, "H");
                    oFrmTCSCrud.gbDatos.Enabled = false;
                    if (oFrmTCSCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "COPB":
                    int idCodPostal = Convert.ToInt32(row.Cells[0].Value);
                    frmCodigoPostalCrud oFrmCodPostalCrud = new frmCodigoPostalCrud(idCodPostal, "NQ");
                    oFrmCodPostalCrud.gbDatos.Enabled = false;
                    if (oFrmCodPostalCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;

                case "SCAT":
                    long id = Convert.ToInt64(row.Cells[0].Value);
                    frmCategoriasCrud oFrmCatCrud = new frmCategoriasCrud(id, "V");
                    if (oFrmCatCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "USUS":
                    int idUsus = Convert.ToInt32(row.Cells[0].Value);
                    frmUsuariosCrud oFrmUsuCrud = new frmUsuariosCrud(idUsus, "V", 0);
                    if (oFrmUsuCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "CPT":
                    long idCpt = Convert.ToInt64(row.Cells[0].Value);
                    frmConceptosCrud oFrmCptCrud = new frmConceptosCrud(idCpt, "V");
                    if (oFrmCptCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "GII":
                    int idGii = Convert.ToInt32(row.Cells[0].Value);
                    frmGruposImpuestosItemsCrud oFrmGiiCrud = new frmGruposImpuestosItemsCrud(idGii, "V");
                    if (oFrmGiiCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;          
            }
        }

        private void Eliminar() {

            DataGridViewRow row = this.dgBusqueda.CurrentRow;
            switch (_oAdmin.TabCodigo)
            {
                case "SRUT":
                    long idRuta = Convert.ToInt64(row.Cells[0].Value);
                    frmRutasCrud oFrmRutCrud = new frmRutasCrud(idRuta, "B");
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TCS":
                    string idTCS = row.Cells[0].Value.ToString();
                    frmTiposConexionesCrud oFrmTCSCrud = new frmTiposConexionesCrud(idTCS, "B");
                    if (oFrmTCSCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "FAB":
                    long idFabricantes = Convert.ToInt64(row.Cells[0].Value);
                    frmFabricantesCrud oFrmFabricantesCrud = new frmFabricantesCrud(idFabricantes, "B");
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;

                case "TME":
                    long idTme = Convert.ToInt64(row.Cells[0].Value);
                    frmTiposMedidoresCrud oFrmMedidorCrud = new frmTiposMedidoresCrud(idTme, "B");
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "SCAT":
                    long id = Convert.ToInt64(row.Cells[0].Value);
                    frmCategoriasCrud oFrmCatCrud = new frmCategoriasCrud(id, "B");
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "LEC":
                    long idLec = Convert.ToInt64(row.Cells[0].Value);
                    frmLecturasConceptosCrud oFrmLecCrud = new frmLecturasConceptosCrud(idLec, "B");
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "LEM":
                    long idLem = Convert.ToInt64(row.Cells[0].Value);
                    frmLecturasModosCrud oFrmLemCrud = new frmLecturasModosCrud(idLem, "B");
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "USUS":
                    int idUsu = Convert.ToInt32(row.Cells[0].Value);
                    frmUsuariosCrud oFrmUsuCrud = new frmUsuariosCrud(idUsu, "B", 0);
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "CPT":
                    long idCpt = Convert.ToInt64(row.Cells[0].Value);
                    frmConceptosCrud oFrmCptCrud = new frmConceptosCrud(idCpt, "B");
                    //if (oFrmPerCrud.ShowDialog() == DialogResult.OK)
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "GII":
                    int idGii = Convert.ToInt32(row.Cells[0].Value);
                    frmGruposImpuestosItemsCrud oFrmGiiCrud = new frmGruposImpuestosItemsCrud(idGii, "B");
                    //if (oFrmPerCrud.ShowDialog() == DialogResult.OK)
                    _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
            }
        }
        private void Editar() {
            DataGridViewRow row = this.dgBusqueda.CurrentRow;
            if(row == null)
            {
                row = this.dgBusqueda.Rows[1];
            }
            switch (_oAdmin.TabCodigo)
            {
                case "CALB":
                    long idCalle = Convert.ToInt64(row.Cells[0].Value);
                    frmCallesCrud oFrmCalCrud = new frmCallesCrud(idCalle, "NQ");
                    if (oFrmCalCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;

                case "SRUT":
                    long idRuta = Convert.ToInt64(row.Cells[0].Value);
                    frmRutasCrud oFrmRutCrud = new frmRutasCrud(idRuta, "H");
                    if (oFrmRutCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TCS":
                    string idTCS = row.Cells[0].Value.ToString();
                    frmTiposConexionesCrud oFrmTCSCrud = new frmTiposConexionesCrud(idTCS, "H");
                    if (oFrmTCSCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "COPB":
                    long idCodPostal = Convert.ToInt64(row.Cells[0].Value);
                    frmCodigoPostalCrud oFrmCodPostalCrud = new frmCodigoPostalCrud(idCodPostal, "NQ");
                    if (oFrmCodPostalCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TME":
                    long idMedidor = Convert.ToInt64(row.Cells[0].Value);
                    string estadoMedidor = row.Cells[5].Value.ToString();
                    frmTiposMedidoresCrud oTiposMedidoresCrud = new frmTiposMedidoresCrud(idMedidor, estadoMedidor);
                    oTiposMedidoresCrud.bloquearFecha();
                    if (!oTiposMedidoresCrud.IsDisposed)// ESTE CONTROL SE HACE HASTA QUE LA GRILLA DEJE DE TRAER LOS REGISTROS QUE TENGAN EL ESTADO "B"
                    {
                        if (oTiposMedidoresCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_oAdmin);
                    }
                    break;
                case "FAB":
                    long idFabricante = Convert.ToInt64(row.Cells[0].Value);
                    string estadoFabricante = row.Cells[2].Value.ToString();
                    frmFabricantesCrud oFabricantesCrud = new frmFabricantesCrud(idFabricante, estadoFabricante);
                    oFabricantesCrud.bloquearFecha();
                    if (!oFabricantesCrud.IsDisposed)
                        if (oFabricantesCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "SCAT":
                    long id = Convert.ToInt64(row.Cells[0].Value);
                    frmCategoriasCrud oFrmCatCrud = new frmCategoriasCrud(id, "E");
                    if (oFrmCatCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;

                case "LEC":
                    long idLec = Convert.ToInt64(row.Cells[0].Value);
                    frmLecturasConceptosCrud oFrmLecCrud = new frmLecturasConceptosCrud(idLec, "E");
                    oFrmLecCrud.bloquearFecha();
                    if (oFrmLecCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "LEM":
                    long idLem = Convert.ToInt64(row.Cells[0].Value);
                    frmLecturasModosCrud oFrmLemCrud = new frmLecturasModosCrud(idLem, "E");
                    oFrmLemCrud.bloquearFecha();
                    if (oFrmLemCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "USUS":
                    int idUsu = Convert.ToInt32(row.Cells[0].Value);
                    frmUsuariosCrud oFrmUsuCrud = new frmUsuariosCrud(idUsu, "E", 0);
                    if (oFrmUsuCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "CPT":
                    long idConcepto = Convert.ToInt64(row.Cells[0].Value);
                    frmConceptosCrud oFrmCptCrud = new frmConceptosCrud(idConcepto, "E");
                    if (oFrmCptCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "GII":
                    int idGii = Convert.ToInt32(row.Cells[0].Value);
                    frmGruposImpuestosItemsCrud oFrmGiiCrud = new frmGruposImpuestosItemsCrud(idGii, "E");
                    if (oFrmGiiCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
            }

        }
        #endregion
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _strDatosSeleccionados = _oFormAdmin.GuardarSeleccionados();
            Close();
        }

     
    }
}
