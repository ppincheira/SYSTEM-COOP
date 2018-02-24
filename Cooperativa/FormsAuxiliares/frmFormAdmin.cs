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

        #region << Implementation of IVistaFormAdmin >>


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
            get {  return this.dgBusqueda; }
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
            get { return  this.cmbBuscar;}
            set { this.cmbBuscar = value;}
        }
        public cmbLista comboBuscarA
        {
            get { return  this.cmbBuscarA; }
            set {this.cmbBuscarA = value; }
        }

        public cmbLista comboOpcionesA
        {
            get { return this.cmbOpcionesA; }
            set { this.cmbOpcionesA = value; }
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

        #region << CONTROLES >>
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.contenedores.tabSolapas tabAdmin;
        private TabPage tabPageBuscador;
        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        public cmbLista cmbEstado;
        private Controles.labels.lblEtiqueta lblEEstado;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.buttons.btnEliminar btnEliminar1;
        private Controles.buttons.btnSalir btnSalir;
        private Controles.buttons.btnExportar btnExportar;
        private Controles.buttons.btnImprimir btnImprimir;
        private Controles.buttons.btnVer btnVer;
        private Controles.buttons.btnEditar btnEditar;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.contenedores.gpbGrupo gpbFecha;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        private Controles.Fecha.dtpFecha dtpFechaHasta;
        private Controles.Fecha.dtpFecha dtpFechaDesde;
        private Controles.contenedores.gpbGrupo gpbFiltro;
        private txtFiltro txtFiltro;
        private cmbLista cmbBuscar;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblFiltro;
        private TabPage tabPageAvanzada;
        private Controles.buttons.btnGeneral btnAgregar;
        private grdGrillaAdmin grdGrillaFiltro;
        private cmbLista cmbOpcionesA;
        private cmbLista cmbBuscarA;
        private Controles.textBoxes.txtDescripcionCorta txtValor1;
        private Controles.textBoxes.txtDescripcionCorta txtValor6;
        private Controles.textBoxes.txtDescripcionCorta txtValor5;
        private Controles.textBoxes.txtDescripcionCorta txtValor4;
        private Controles.textBoxes.txtDescripcionCorta txtValor3;
        private Controles.textBoxes.txtDescripcionCorta txtValor2;
        private Controles.datos.grdGrillaAdmin dgBusqueda;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormAdmin));
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.dgBusqueda = new Controles.datos.grdGrillaAdmin();
            this.tabAdmin = new Controles.contenedores.tabSolapas();
            this.tabPageBuscador = new System.Windows.Forms.TabPage();
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new Controles.datos.cmbLista();
            this.lblEEstado = new Controles.labels.lblEtiqueta();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnEliminar1 = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.gpbFecha = new Controles.contenedores.gpbGrupo();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.dtpFechaHasta = new Controles.Fecha.dtpFecha();
            this.dtpFechaDesde = new Controles.Fecha.dtpFecha();
            this.gpbFiltro = new Controles.contenedores.gpbGrupo();
            this.txtFiltro = new Controles.txtFiltro();
            this.cmbBuscar = new Controles.datos.cmbLista();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblFiltro = new Controles.labels.lblEtiqueta();
            this.tabPageAvanzada = new System.Windows.Forms.TabPage();
            this.txtValor1 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor6 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor5 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor4 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor3 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor2 = new Controles.textBoxes.txtDescripcionCorta();
            this.btnAgregar = new Controles.buttons.btnGeneral();
            this.grdGrillaFiltro = new Controles.datos.grdGrillaAdmin();
            this.cmbOpcionesA = new Controles.datos.cmbLista();
            this.cmbBuscarA = new Controles.datos.cmbLista();
            this.gpbGrupo4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.tabPageBuscador.SuspendLayout();
            this.gpbGrupoEstado.SuspendLayout();
            this.gpbGrupo3.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.tabPageAvanzada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.lblCantidad);
            this.gpbGrupo4.Controls.Add(this.dgBusqueda);
            this.gpbGrupo4.Location = new System.Drawing.Point(5, 144);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(932, 351);
            this.gpbGrupo4.TabIndex = 1;
            this.gpbGrupo4.TabStop = false;
            this.gpbGrupo4.Text = "Datos";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 333);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgBusqueda
            // 
            this.dgBusqueda.AllowUserToAddRows = false;
            this.dgBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabPageBuscador);
            this.tabAdmin.Controls.Add(this.tabPageAvanzada);
            this.tabAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabAdmin.Location = new System.Drawing.Point(5, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(939, 145);
            this.tabAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAdmin.TabIndex = 2;
            // 
            // tabPageBuscador
            // 
            this.tabPageBuscador.Controls.Add(this.gpbGrupoEstado);
            this.tabPageBuscador.Controls.Add(this.gpbGrupo3);
            this.tabPageBuscador.Controls.Add(this.gpbFecha);
            this.tabPageBuscador.Controls.Add(this.gpbFiltro);
            this.tabPageBuscador.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscador.Name = "tabPageBuscador";
            this.tabPageBuscador.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscador.Size = new System.Drawing.Size(931, 119);
            this.tabPageBuscador.TabIndex = 0;
            this.tabPageBuscador.UseVisualStyleBackColor = true;
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Enabled = false;
            this.gpbGrupoEstado.Location = new System.Drawing.Point(596, 62);
            this.gpbGrupoEstado.Name = "gpbGrupoEstado";
            this.gpbGrupoEstado.Size = new System.Drawing.Size(332, 46);
            this.gpbGrupoEstado.TabIndex = 12;
            this.gpbGrupoEstado.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(55, 13);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbEstado.Size = new System.Drawing.Size(188, 21);
            this.cmbEstado.TabIndex = 8;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.Location = new System.Drawing.Point(6, 16);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEEstado.TabIndex = 8;
            this.lblEEstado.Text = "Estado";
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
            this.gpbGrupo3.Location = new System.Drawing.Point(596, 7);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(332, 53);
            this.gpbGrupo3.TabIndex = 10;
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
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.lblEFechaHasta);
            this.gpbFecha.Controls.Add(this.lblEFechaDesde);
            this.gpbFecha.Controls.Add(this.dtpFechaHasta);
            this.gpbFecha.Controls.Add(this.dtpFechaDesde);
            this.gpbFecha.Enabled = false;
            this.gpbFecha.Location = new System.Drawing.Point(390, 7);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(200, 103);
            this.gpbFecha.TabIndex = 11;
            this.gpbFecha.TabStop = false;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(8, 61);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblEFechaHasta.TabIndex = 11;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(5, 23);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblEFechaDesde.TabIndex = 10;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(97, 58);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaHasta.Size = new System.Drawing.Size(94, 20);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(97, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.txtFiltro);
            this.gpbFiltro.Controls.Add(this.cmbBuscar);
            this.gpbFiltro.Controls.Add(this.lblEtiqueta2);
            this.gpbFiltro.Controls.Add(this.lblFiltro);
            this.gpbFiltro.Location = new System.Drawing.Point(3, 7);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(386, 101);
            this.gpbFiltro.TabIndex = 9;
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
            this.txtFiltro.Size = new System.Drawing.Size(256, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextoVacio = "<Descripcion>";
            this.txtFiltro.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(105, 16);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbBuscar.Size = new System.Drawing.Size(256, 21);
            this.cmbBuscar.TabIndex = 2;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(42, 61);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(45, 13);
            this.lblEtiqueta2.TabIndex = 1;
            this.lblEtiqueta2.Text = "FILTRO";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(3, 19);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(78, 13);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "FILTRAR POR";
            // 
            // tabPageAvanzada
            // 
            this.tabPageAvanzada.Controls.Add(this.txtValor1);
            this.tabPageAvanzada.Controls.Add(this.txtValor6);
            this.tabPageAvanzada.Controls.Add(this.txtValor5);
            this.tabPageAvanzada.Controls.Add(this.txtValor4);
            this.tabPageAvanzada.Controls.Add(this.txtValor3);
            this.tabPageAvanzada.Controls.Add(this.txtValor2);
            this.tabPageAvanzada.Controls.Add(this.btnAgregar);
            this.tabPageAvanzada.Controls.Add(this.grdGrillaFiltro);
            this.tabPageAvanzada.Controls.Add(this.cmbOpcionesA);
            this.tabPageAvanzada.Controls.Add(this.cmbBuscarA);
            this.tabPageAvanzada.Location = new System.Drawing.Point(4, 22);
            this.tabPageAvanzada.Name = "tabPageAvanzada";
            this.tabPageAvanzada.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAvanzada.Size = new System.Drawing.Size(931, 119);
            this.tabPageAvanzada.TabIndex = 1;
            this.tabPageAvanzada.Text = "Avanzada";
            this.tabPageAvanzada.UseVisualStyleBackColor = true;
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.Color.White;
            this.txtValor1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor1.Location = new System.Drawing.Point(6, 65);
            this.txtValor1.MaxLength = 20;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor1.Size = new System.Drawing.Size(204, 20);
            this.txtValor1.TabIndex = 14;
            this.txtValor1.TextoVacio = "<Descripcion>";
            this.txtValor1.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor6
            // 
            this.txtValor6.BackColor = System.Drawing.Color.White;
            this.txtValor6.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor6.Location = new System.Drawing.Point(76, 90);
            this.txtValor6.MaxLength = 20;
            this.txtValor6.Name = "txtValor6";
            this.txtValor6.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor6.Size = new System.Drawing.Size(65, 20);
            this.txtValor6.TabIndex = 13;
            this.txtValor6.TextoVacio = "<Descripcion>";
            this.txtValor6.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor5
            // 
            this.txtValor5.BackColor = System.Drawing.Color.White;
            this.txtValor5.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor5.Location = new System.Drawing.Point(6, 90);
            this.txtValor5.MaxLength = 20;
            this.txtValor5.Name = "txtValor5";
            this.txtValor5.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor5.Size = new System.Drawing.Size(65, 20);
            this.txtValor5.TabIndex = 12;
            this.txtValor5.TextoVacio = "<Descripcion>";
            this.txtValor5.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor4
            // 
            this.txtValor4.BackColor = System.Drawing.Color.White;
            this.txtValor4.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor4.Location = new System.Drawing.Point(145, 65);
            this.txtValor4.MaxLength = 20;
            this.txtValor4.Name = "txtValor4";
            this.txtValor4.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor4.Size = new System.Drawing.Size(65, 20);
            this.txtValor4.TabIndex = 11;
            this.txtValor4.TextoVacio = "<Descripcion>";
            this.txtValor4.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor3
            // 
            this.txtValor3.BackColor = System.Drawing.Color.White;
            this.txtValor3.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor3.Location = new System.Drawing.Point(76, 65);
            this.txtValor3.MaxLength = 20;
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor3.Size = new System.Drawing.Size(65, 20);
            this.txtValor3.TabIndex = 10;
            this.txtValor3.TextoVacio = "<Descripcion>";
            this.txtValor3.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.Color.White;
            this.txtValor2.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor2.Location = new System.Drawing.Point(6, 65);
            this.txtValor2.MaxLength = 20;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor2.Size = new System.Drawing.Size(65, 20);
            this.txtValor2.TabIndex = 9;
            this.txtValor2.TextoVacio = "<Descripcion>";
            this.txtValor2.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(160, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grdGrillaFiltro
            // 
            this.grdGrillaFiltro.AllowDrop = true;
            this.grdGrillaFiltro.AllowUserToAddRows = false;
            this.grdGrillaFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGrillaFiltro.Location = new System.Drawing.Point(216, 3);
            this.grdGrillaFiltro.MultiSelect = false;
            this.grdGrillaFiltro.Name = "grdGrillaFiltro";
            this.grdGrillaFiltro.ReadOnly = true;
            this.grdGrillaFiltro.RowTemplate.Height = 24;
            this.grdGrillaFiltro.Size = new System.Drawing.Size(712, 110);
            this.grdGrillaFiltro.TabIndex = 5;
            // 
            // cmbOpcionesA
            // 
            this.cmbOpcionesA.FormattingEnabled = true;
            this.cmbOpcionesA.Location = new System.Drawing.Point(6, 37);
            this.cmbOpcionesA.Name = "cmbOpcionesA";
            this.cmbOpcionesA.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbOpcionesA.Size = new System.Drawing.Size(204, 21);
            this.cmbOpcionesA.TabIndex = 3;
            this.cmbOpcionesA.SelectedIndexChanged += new System.EventHandler(this.cmbOpcionesA_SelectedIndexChanged);
            // 
            // cmbBuscarA
            // 
            this.cmbBuscarA.BackColor = System.Drawing.Color.White;
            this.cmbBuscarA.FormattingEnabled = true;
            this.cmbBuscarA.Location = new System.Drawing.Point(6, 9);
            this.cmbBuscarA.Name = "cmbBuscarA";
            this.cmbBuscarA.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbBuscarA.Size = new System.Drawing.Size(204, 21);
            this.cmbBuscarA.TabIndex = 2;
            // 
            // frmFormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(946, 513);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.gpbGrupo4);
            this.Name = "frmFormAdmin";
            this.Load += new System.EventHandler(this.frmFormAdmin_Load);
            this.gpbGrupo4.ResumeLayout(false);
            this.gpbGrupo4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabPageBuscador.ResumeLayout(false);
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.tabPageAvanzada.ResumeLayout(false);
            this.tabPageAvanzada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaFiltro)).EndInit();
            this.ResumeLayout(false);

        }


#endregion

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
                CargarOpciones("1");
                _oFormAdmin.Inicializar(_oAdmin);
                _oUtil = new Utility();
                _oUtil.HabilitarAllControlesInTrue(this, 1, "frmFormAdmin");
                //No Borrar este comentario es la llama original
                //oUtil.HabilitarControles(this, 1, "frmFormAdmin", "CAJA", null);
                if (this.dgBusqueda.RowCount > 0)
                    dgBusqueda.CurrentCell = dgBusqueda.Rows[0].Cells[1];
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
       
        public void CargarOpciones(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    this.txtValor1.Visible =true;
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
                    this.txtValor2.Visible = true;
                    this.txtValor3.Visible = true;
                    this.txtValor1.Visible = false;
                    this.txtValor4.Visible = false;
                    this.txtValor5.Visible = false;
                    this.txtValor6.Visible = false;
                    break;
                case "9":
                    this.txtValor1.Visible = false;
                    this.txtValor2.Visible = true;
                    this.txtValor3.Visible = true;
                    this.txtValor4.Visible = true;
                    this.txtValor5.Visible = true;
                    this.txtValor6.Visible = true;
                    break;
                case "10":
                    this.txtValor1.Visible = false;
                    this.txtValor2.Visible = true;
                    this.txtValor3.Visible = true;
                    this.txtValor4.Visible = true;
                    this.txtValor5.Visible = true;
                    this.txtValor6.Visible = true;
                    break;






            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _oFormAdmin.CargarDataTable();
        }

        private void cmbOpcionesA_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarOpciones(this.cmbOpcionesA.SelectedValue.ToString());
        }


    }
}
