using System;
using System.Windows.Forms;
using AppProcesos.gesServicios.frmSuministrosAdmin;
using Controles.datos;
using Controles.form;
using Model;
using Service;

namespace GesServicios.controles.forms
{
    public partial class frmSuministrosAdmin : gesForm, IVistaSuministrosAdmin
    {
        #region << PROPIEDADES >>

        public Admin _oAdmin;
        private string _Tabla;
        Utility _oUtil;
        public string _strRdoCodigo;
        private UISuministrosAdmin _oSuministrosAdmin;
        #endregion

        #region Implementation of IVistaSuministrosAdmin
        public Boolean grupoEstado
        {
            get { return this.gpbGrupoEstado.Enabled; }
            set { this.gpbGrupoEstado.Enabled = value; }
        }
        public Boolean grupoFecha
        {
            get { return this.gpbFecha.Enabled; }
            set { this.gpbFecha.Enabled = value; }
        }

        public grdGrillaAdmin grilla
        {
            get { return this.dgBusqueda; }
            set { this.dgBusqueda = value; }
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
        public cmbLista comboEstado
        {
            get { return this.cmbEstado; }
            set { this.cmbEstado = value; }
        }
        public cmbLista comboBuscar
        {
            get { return this.cmbBuscar; }
            set { this.cmbBuscar = value; }
        }
        public string filtro
        {
            get { return this.txtFiltro.Text; }
            set { this.txtFiltro.Text = value; }
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


        #endregion
        #region << EVENTOS >>
        public frmSuministrosAdmin(string tabCodigo, FuncionalidadesFoms oPerForm)
        {
            try
            {
                InitializeComponent();
                AsignarFuncionalidad(oPerForm);
                _Tabla = tabCodigo;

                _oSuministrosAdmin = new UISuministrosAdmin(this);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "frmSuministrosAdmin",
                                "frmSuministrosAdmin",
                                this.FindForm().Name);
            }
        }

        private void gpbGrupo2_Enter(object sender, EventArgs e)
        {

        }

        private void frmSuministrosAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                _oSuministrosAdmin.Inicializar(_Tabla);
                _oUtil = new Utility();
                _oUtil.HabilitarAllControlesInTrue(this, 1, "frmSuministrosAdmin");
                //No Borrar este comentario es la llama original
                //oUtil.HabilitarControles(this, 1, "frmSuministrosAdmin", "CAJA", null);

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
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("31", "32", "33", "0", "0", "34");
                frmSuministrosCrud oFrmSumCrud = new frmSuministrosCrud(0,"H");
                if (oFrmSumCrud.ShowDialog() == DialogResult.OK)
                    _oSuministrosAdmin.CargarGrilla(_Tabla);
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
                DataGridViewRow row = this.dgBusqueda.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);

                frmSuministrosCrud oFrmSumCrud = new frmSuministrosCrud(id,"H");
                if (oFrmSumCrud.ShowDialog() == DialogResult.OK)
                    _oSuministrosAdmin.CargarGrilla(_Tabla);
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgBusqueda.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);
                frmSuministrosCrud oFrmSumCrud = new frmSuministrosCrud(id,"H");
                oFrmSumCrud.gbDatos.Enabled = false;
                if (oFrmSumCrud.ShowDialog() == DialogResult.OK)
                    _oSuministrosAdmin.CargarGrilla(_Tabla);
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

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgBusqueda.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);
                //frmSuministrosCrud oFrmSumCrud = new frmSuministrosCrud(id,"B",1);
                //_oSuministrosAdmin.CargarGrilla(_Tabla);
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
        #endregion

        #region << METODOS >>
        public void AsignarFuncionalidad(FuncionalidadesFoms oPerForm)
        {
            //Esta funcion asigna la funcionalidad a los controles de este dinamico
            this.btnNuevo.FUN_CODIGO = oPerForm.New;
            this.btnEditar.FUN_CODIGO = oPerForm.Edit;
            this.btnExportar.FUN_CODIGO = oPerForm.Exp;
            this.btnEliminar1.FUN_CODIGO = oPerForm.Del;
            this.btnImprimir.FUN_CODIGO = oPerForm.Imp;
            this.btnVer.FUN_CODIGO = oPerForm.Ver;
        }
        #endregion

        private void gpbGrupo1_Enter(object sender, EventArgs e)
        {

        }
    }
}
