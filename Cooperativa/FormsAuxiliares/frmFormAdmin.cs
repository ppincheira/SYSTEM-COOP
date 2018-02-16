using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Model;
using Controles;
using AppProcesos.formsAuxiliares.formAdmin;
using AppProcesos.gesServicios.frmMedidoresCrud;
using AppProcesos.gesServicios.frmMedidoresModelosCrud;
using Controles.datos;
using Service;
using Controles.form;
using System.Windows.Forms;
using GesServicios.controles.forms;
using static Model.Admin;
using GesSeguridad.controles.forms;
using GesConfiguracion;

namespace FormsAuxiliares
{
    public partial class frmFormAdmin : gesForm, IVistaFormAdmin
    {

        #region << PROPIEDADES >>

        private Admin _oAdmin;
        Utility _oUtil;
        public string _strRdoCodigo;
        private UIFormAdmin _oFormAdmin;
        #endregion

        #region Implementation of IVistaFormAdmin


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

        #endregion
        private Controles.contenedores.gpbGrupo gpbFiltro;
        private txtFiltro txtFiltro;
        private Controles.datos.cmbLista cmbBuscar;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblFiltro;
        private Controles.contenedores.gpbGrupo gpbFecha;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        private Controles.Fecha.dtpFecha dtpFechaHasta;
        private Controles.Fecha.dtpFecha dtpFechaDesde;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.buttons.btnSalir btnSalir;
        private Controles.buttons.btnExportar btnExportar;
        private Controles.buttons.btnImprimir btnImprimir;
        private Controles.buttons.btnVer btnVer;
        private Controles.buttons.btnEditar btnEditar;
        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        public Controles.datos.cmbLista cmbEstado;
        private Controles.labels.lblEtiqueta lblEEstado;
        private Controles.buttons.btnEliminar btnEliminar1;
        private Controles.datos.grdGrillaAdmin dgBusqueda;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormAdmin));
            this.gpbFiltro = new Controles.contenedores.gpbGrupo();
            this.txtFiltro = new Controles.txtFiltro();
            this.cmbBuscar = new Controles.datos.cmbLista();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblFiltro = new Controles.labels.lblEtiqueta();
            this.gpbFecha = new Controles.contenedores.gpbGrupo();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.dtpFechaHasta = new Controles.Fecha.dtpFecha();
            this.dtpFechaDesde = new Controles.Fecha.dtpFecha();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnEliminar1 = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.dgBusqueda = new Controles.datos.grdGrillaAdmin();
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new Controles.datos.cmbLista();
            this.lblEEstado = new Controles.labels.lblEtiqueta();
            this.gpbFiltro.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbGrupo3.SuspendLayout();
            this.gpbGrupo4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
            this.gpbGrupoEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.txtFiltro);
            this.gpbFiltro.Controls.Add(this.cmbBuscar);
            this.gpbFiltro.Controls.Add(this.lblEtiqueta2);
            this.gpbFiltro.Controls.Add(this.lblFiltro);
            this.gpbFiltro.Location = new System.Drawing.Point(12, 1);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(386, 101);
            this.gpbFiltro.TabIndex = 0;
            this.gpbFiltro.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro.Location = new System.Drawing.Point(105, 58);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtFiltro.Size = new System.Drawing.Size(256, 22);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextoVacio = "<Descripcion>";
            this.txtFiltro.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(105, 16);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbBuscar.Size = new System.Drawing.Size(256, 24);
            this.cmbBuscar.TabIndex = 2;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(42, 61);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(57, 17);
            this.lblEtiqueta2.TabIndex = 1;
            this.lblEtiqueta2.Text = "FILTRO";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(3, 19);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(99, 17);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "FILTRAR POR";
            // 
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.lblEFechaHasta);
            this.gpbFecha.Controls.Add(this.lblEFechaDesde);
            this.gpbFecha.Controls.Add(this.dtpFechaHasta);
            this.gpbFecha.Controls.Add(this.dtpFechaDesde);
            this.gpbFecha.Enabled = false;
            this.gpbFecha.Location = new System.Drawing.Point(399, 1);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(200, 103);
            this.gpbFecha.TabIndex = 1;
            this.gpbFecha.TabStop = false;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(8, 61);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(88, 17);
            this.lblEFechaHasta.TabIndex = 11;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(5, 23);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(92, 17);
            this.lblEFechaDesde.TabIndex = 10;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(97, 58);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaHasta.Size = new System.Drawing.Size(94, 22);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(97, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 22);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.btnEliminar1);
            this.gpbGrupo3.Controls.Add(this.btnSalir);
            this.gpbGrupo3.Controls.Add(this.btnExportar);
            this.gpbGrupo3.Controls.Add(this.btnImprimir);
            this.gpbGrupo3.Controls.Add(this.btnVer);
            this.gpbGrupo3.Controls.Add(this.btnEditar);
            this.gpbGrupo3.Controls.Add(this.btnNuevo);
            this.gpbGrupo3.Location = new System.Drawing.Point(605, 1);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(332, 53);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar1.BackgroundImage")));
            this.btnEliminar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar1.Enabled = false;
            this.btnEliminar1.Location = new System.Drawing.Point(98, 9);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar1.TabIndex = 7;
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(282, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(190, 8);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(40, 40);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(236, 8);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(40, 40);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer.BackgroundImage")));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Enabled = false;
            this.btnVer.Location = new System.Drawing.Point(144, 8);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(40, 40);
            this.btnVer.TabIndex = 2;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(52, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Location = new System.Drawing.Point(6, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.lblCantidad);
            this.gpbGrupo4.Controls.Add(this.dgBusqueda);
            this.gpbGrupo4.Location = new System.Drawing.Point(12, 110);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(925, 351);
            this.gpbGrupo4.TabIndex = 1;
            this.gpbGrupo4.TabStop = false;
            this.gpbGrupo4.Text = "Datos";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 333);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgBusqueda
            // 
            this.dgBusqueda.AllowUserToAddRows = false;
            this.dgBusqueda.Location = new System.Drawing.Point(6, 19);
            this.dgBusqueda.Name = "dgBusqueda";
            this.dgBusqueda.ReadOnly = true;
            this.dgBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBusqueda.Size = new System.Drawing.Size(913, 312);
            this.dgBusqueda.TabIndex = 0;
            this.dgBusqueda.SelectionChanged += new System.EventHandler(this.dgBusqueda_SelectionChanged);
            this.dgBusqueda.DoubleClick += new System.EventHandler(this.dgBusqueda_DoubleClick);
            this.dgBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgBusqueda_KeyPress);
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Enabled = false;
            this.gpbGrupoEstado.Location = new System.Drawing.Point(605, 56);
            this.gpbGrupoEstado.Name = "gpbGrupoEstado";
            this.gpbGrupoEstado.Size = new System.Drawing.Size(332, 46);
            this.gpbGrupoEstado.TabIndex = 8;
            this.gpbGrupoEstado.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(55, 13);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbEstado.Size = new System.Drawing.Size(188, 24);
            this.cmbEstado.TabIndex = 8;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.Location = new System.Drawing.Point(6, 16);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEEstado.TabIndex = 8;
            this.lblEEstado.Text = "Estado";
            // 
            // frmFormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(946, 487);
            this.Controls.Add(this.gpbGrupoEstado);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbFiltro);
            this.Name = "frmFormAdmin";
            this.Load += new System.EventHandler(this.frmFormAdmin_Load);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbGrupo4.ResumeLayout(false);
            this.gpbGrupo4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.ResumeLayout(false);

        }






        #region << EVENTOS >>


        public frmFormAdmin(Admin oAdmin, FuncionalidadesFoms oPerForm)
        {
            try
            {
                InitializeComponent();
                AsignarFuncionalidad(oPerForm);
                _oAdmin = oAdmin;
                _oFormAdmin = new UIFormAdmin(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }

        }
        private void frmFormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                _oFormAdmin.Inicializar(_oAdmin);
                _oUtil = new Utility();
                _oUtil.HabilitarAllControlesInTrue(this, 1, "frmFormAdmin");
                //No Borrar este comentario es la llama original
                //oUtil.HabilitarControles(this, 1, "frmFormAdmin", "CAJA", null);
                //if (this.dgBusqueda.RowCount > 0)
                //    dgBusqueda.CurrentCell = dgBusqueda.Rows[0].Cells[1];
                //No Borrar este comentario es la llama original
                //oUtil.HabilitarControles(this, 1, "frmFormAdmin", "CAJA", null);
                switch (_oAdmin.TabCodigo)
                {
                    case "PERB":
                        this.Text = "Personas";
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
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {

              if (  _oUtil.ExportarDataGridViewExcel(this.dgBusqueda))
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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgBusqueda.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);
                switch (_oAdmin.TabCodigo)
                {
                    case "MEM":
                        frmMedidoresModelosCrud oFrmMedModCrud = new frmMedidoresModelosCrud(id, "B", 1);
                        //if (oFrmMedModCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                        break;
                    case "MED":
                        frmMedidoresCrud oFrmMedCrud = new frmMedidoresCrud(id, "B", 1);
                        //if (oFrmMedCrud.ShowDialog() == DialogResult.OK)
                            _oFormAdmin.CargarGrilla(_oAdmin);
                        break;
                    case "PERB":
                        frmPersonasCrud oFrmPerCrud = new frmPersonasCrud(id, "B");
                        //if (oFrmPerCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                        break;
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





        private void btnEliminar1_Click(object sender, EventArgs e)
        {

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

        #endregion





        #region <<METODOS >>
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

        private void Ver()
        {

            DataGridViewRow row = this.dgBusqueda.CurrentRow;
            long id = Convert.ToInt64(row.Cells[0].Value);
            switch (_oAdmin.TabCodigo)
            {
                case "DOMB":

                    frmDomiciliosCrud oFrmDomCrud = new frmDomiciliosCrud(id, _oAdmin);
                    oFrmDomCrud.gbDatos.Enabled = false;
                    if (oFrmDomCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);

                    break;
                case "MEM":
                    frmMedidoresModelosCrud oFrmMedModCrud = new frmMedidoresModelosCrud(id, "H", 1);
                    //oFrmMedModCrud.txtOrdenRuta.Enabled = false;
                    if (oFrmMedModCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "MED":
                    frmMedidoresCrud oFrmMedCrud = new frmMedidoresCrud(id, "H", 1);
                    oFrmMedCrud.gbDatos.Enabled = false;
                    if (oFrmMedCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "PERB":
                    frmPersonasCrud oFrmPerCrud = new frmPersonasCrud(id, "V");
                    if (oFrmPerCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "":
                    Console.WriteLine("Case 2");
                    break;

            }
        }

        private void Nuevo()
        {

            switch (_oAdmin.TabCodigo)
            {
                case "DOMB":

                    
                    frmDomiciliosCrud oFrmDomCrud = new frmDomiciliosCrud(_oAdmin.CodigoEditar==null?0:long.Parse(_oAdmin.CodigoEditar), _oAdmin);
                    if (oFrmDomCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "MEM":
                    frmMedidoresModelosCrud oFrmMedModCrud = new frmMedidoresModelosCrud(0, "H", 1);
                    if (oFrmMedModCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "MED":
                    frmMedidoresCrud oFrmMedCrud = new frmMedidoresCrud(0, "H", 1);
                    if (oFrmMedCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "CLIE":
                    frmClientesCrud oFrmCliente = new frmClientesCrud(0);
                    if (oFrmCliente.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "PERB":
                    frmPersonasCrud oFrmPerCrud = new frmPersonasCrud(0, "I");
                    if (oFrmPerCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TCO":
                    frmTiposComprobantesCrud oFrmTcoCrud = new frmTiposComprobantesCrud("", "H");
                    if (oFrmTcoCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "":
                    Console.WriteLine("Case 2");
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
        private void Editar()
        {
            DataGridViewRow row = this.dgBusqueda.CurrentRow;
           

            switch (_oAdmin.TabCodigo)
            {
                case "DOMB":
                    long idDomicilio = Convert.ToInt64(row.Cells[0].Value);
                    frmDomiciliosCrud oFrmDomCrud = new frmDomiciliosCrud(idDomicilio, _oAdmin);
                    if (oFrmDomCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "MEM":
                    long idMedidor = Convert.ToInt64(row.Cells[0].Value);
                    frmMedidoresModelosCrud oFrmMedModCrud = new frmMedidoresModelosCrud(idMedidor, "H", 1);
                    if (oFrmMedModCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "MED":
                    long idMedidores = Convert.ToInt64(row.Cells[0].Value);
                    frmMedidoresCrud oFrmMedCrud = new frmMedidoresCrud(idMedidores, "H", 1);
                    if (oFrmMedCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "CLIE":
                    int idCliente = Convert.ToInt32(row.Cells[0].Value);
                    frmClientesCrud oFrmCliente = new frmClientesCrud(idCliente);
                    if (oFrmCliente.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "PERB":
                    int idPersona = Convert.ToInt32(row.Cells[0].Value);
                    frmPersonasCrud oFrmPerCrud = new frmPersonasCrud(idPersona, "E");
                    if (oFrmPerCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "TCO":
                    string id = row.Cells[0].Value.ToString();
                    frmTiposComprobantesCrud oFrmTcoCrud = new frmTiposComprobantesCrud(id, "E");
                    oFrmTcoCrud.editar = "SI";
                    if (oFrmTcoCrud.ShowDialog() == DialogResult.OK)
                        _oFormAdmin.CargarGrilla(_oAdmin);
                    break;
                case "":
                    Console.WriteLine("Case 2");
                    break;

            }
        }


        #endregion


    }
}
