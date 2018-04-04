namespace FormsAuxiliares
{
    partial class frmFormAdminMini
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormAdminMini));
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.dgBusqueda = new Controles.datos.grdGrillaAdmin();
            this.tabAdmin = new Controles.contenedores.tabSolapas();
            this.tabPageBuscador = new System.Windows.Forms.TabPage();
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new Controles.datos.cmbLista();
            this.lblEEstado = new Controles.labels.lblEtiqueta();
            this.gpbFecha = new Controles.contenedores.gpbGrupo();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.dtpFechaHasta = new Controles.Fecha.dtpFecha();
            this.dtpFechaDesde = new Controles.Fecha.dtpFecha();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnEliminar = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.gpbFiltro = new Controles.contenedores.gpbGrupo();
            this.txtFiltro = new Controles.txtFiltro();
            this.cmbBuscar = new Controles.datos.cmbLista();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblFiltro = new Controles.labels.lblEtiqueta();
            this.tabPageAvanzado = new System.Windows.Forms.TabPage();
            this.grdGrillaFiltro = new Controles.datos.grdGrillaAdmin();
            this.btnEliminarAvanzada = new Controles.buttons.btnGeneral();
            this.txtValor1 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor6 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor5 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor4 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor3 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtValor2 = new Controles.textBoxes.txtDescripcionCorta();
            this.btnAgregar = new Controles.buttons.btnGeneral();
            this.cmbOpcionesA = new Controles.datos.cmbLista();
            this.cmbBuscarA = new Controles.datos.cmbLista();
            this.gpbGrupo4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.tabPageBuscador.SuspendLayout();
            this.gpbGrupoEstado.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbGrupo3.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.tabPageAvanzado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.btnAceptar);
            this.gpbGrupo4.Controls.Add(this.lblCantidad);
            this.gpbGrupo4.Controls.Add(this.dgBusqueda);
            this.gpbGrupo4.Location = new System.Drawing.Point(6, 182);
            this.gpbGrupo4.Margin = new System.Windows.Forms.Padding(4);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Padding = new System.Windows.Forms.Padding(4);
            this.gpbGrupo4.Size = new System.Drawing.Size(796, 412);
            this.gpbGrupo4.TabIndex = 10;
            this.gpbGrupo4.TabStop = false;
            this.gpbGrupo4.Text = "Datos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(688, 362);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 43);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(14, 368);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgBusqueda
            // 
            this.dgBusqueda.AllowUserToAddRows = false;
            this.dgBusqueda.AllowUserToDeleteRows = false;
            this.dgBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBusqueda.Location = new System.Drawing.Point(12, 20);
            this.dgBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.dgBusqueda.MultiSelect = false;
            this.dgBusqueda.Name = "dgBusqueda";
            this.dgBusqueda.ReadOnly = true;
            this.dgBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBusqueda.Size = new System.Drawing.Size(769, 339);
            this.dgBusqueda.TabIndex = 0;
            this.dgBusqueda.SelectionChanged += new System.EventHandler(this.dgBusqueda_SelectionChanged);
            this.dgBusqueda.DoubleClick += new System.EventHandler(this.dgBusqueda_DoubleClick);
            this.dgBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgBusqueda_KeyPress);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabPageBuscador);
            this.tabAdmin.Controls.Add(this.tabPageAvanzado);
            this.tabAdmin.Location = new System.Drawing.Point(6, -1);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(800, 180);
            this.tabAdmin.TabIndex = 4;
            // 
            // tabPageBuscador
            // 
            this.tabPageBuscador.Controls.Add(this.gpbGrupoEstado);
            this.tabPageBuscador.Controls.Add(this.gpbFecha);
            this.tabPageBuscador.Controls.Add(this.gpbGrupo3);
            this.tabPageBuscador.Controls.Add(this.gpbFiltro);
            this.tabPageBuscador.Location = new System.Drawing.Point(4, 25);
            this.tabPageBuscador.Name = "tabPageBuscador";
            this.tabPageBuscador.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscador.Size = new System.Drawing.Size(792, 151);
            this.tabPageBuscador.TabIndex = 0;
            this.tabPageBuscador.Text = "Principal";
            this.tabPageBuscador.UseVisualStyleBackColor = true;
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Enabled = false;
            this.gpbGrupoEstado.Location = new System.Drawing.Point(500, 92);
            this.gpbGrupoEstado.Margin = new System.Windows.Forms.Padding(4);
            this.gpbGrupoEstado.Name = "gpbGrupoEstado";
            this.gpbGrupoEstado.Padding = new System.Windows.Forms.Padding(4);
            this.gpbGrupoEstado.Size = new System.Drawing.Size(277, 50);
            this.gpbGrupoEstado.TabIndex = 15;
            this.gpbGrupoEstado.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(73, 16);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbEstado.Size = new System.Drawing.Size(189, 24);
            this.cmbEstado.TabIndex = 8;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.Location = new System.Drawing.Point(8, 20);
            this.lblEEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEEstado.TabIndex = 8;
            this.lblEEstado.Text = "Estado";
            // 
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.lblEFechaHasta);
            this.gpbFecha.Controls.Add(this.lblEFechaDesde);
            this.gpbFecha.Controls.Add(this.dtpFechaHasta);
            this.gpbFecha.Controls.Add(this.dtpFechaDesde);
            this.gpbFecha.Enabled = false;
            this.gpbFecha.Location = new System.Drawing.Point(7, 92);
            this.gpbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Padding = new System.Windows.Forms.Padding(4);
            this.gpbFecha.Size = new System.Drawing.Size(480, 52);
            this.gpbFecha.TabIndex = 14;
            this.gpbFecha.TabStop = false;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(243, 23);
            this.lblEFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(88, 17);
            this.lblEFechaHasta.TabIndex = 11;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(5, 23);
            this.lblEFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(92, 17);
            this.lblEFechaDesde.TabIndex = 10;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(341, 16);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaHasta.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(108, 15);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaDesde.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.btnEliminar);
            this.gpbGrupo3.Controls.Add(this.btnSalir);
            this.gpbGrupo3.Controls.Add(this.btnExportar);
            this.gpbGrupo3.Controls.Add(this.btnImprimir);
            this.gpbGrupo3.Controls.Add(this.btnVer);
            this.gpbGrupo3.Controls.Add(this.btnEditar);
            this.gpbGrupo3.Controls.Add(this.btnNuevo);
            this.gpbGrupo3.Location = new System.Drawing.Point(333, -2);
            this.gpbGrupo3.Margin = new System.Windows.Forms.Padding(4);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Padding = new System.Windows.Forms.Padding(4);
            this.gpbGrupo3.Size = new System.Drawing.Size(443, 91);
            this.gpbGrupo3.TabIndex = 13;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(131, 25);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 49);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(376, 23);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(253, 23);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(53, 49);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(315, 23);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(53, 49);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer.BackgroundImage")));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Enabled = false;
            this.btnVer.Location = new System.Drawing.Point(192, 23);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(53, 49);
            this.btnVer.TabIndex = 2;
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(69, 25);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(53, 49);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Location = new System.Drawing.Point(8, 25);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(53, 49);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.txtFiltro);
            this.gpbFiltro.Controls.Add(this.cmbBuscar);
            this.gpbFiltro.Controls.Add(this.lblEtiqueta2);
            this.gpbFiltro.Controls.Add(this.lblFiltro);
            this.gpbFiltro.Location = new System.Drawing.Point(10, -2);
            this.gpbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Padding = new System.Windows.Forms.Padding(4);
            this.gpbFiltro.Size = new System.Drawing.Size(315, 91);
            this.gpbFiltro.TabIndex = 12;
            this.gpbFiltro.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro.Location = new System.Drawing.Point(115, 50);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtFiltro.Size = new System.Drawing.Size(184, 22);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextoVacio = "<Descripcion>";
            this.txtFiltro.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(115, 17);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbBuscar.Size = new System.Drawing.Size(184, 24);
            this.cmbBuscar.TabIndex = 2;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(8, 59);
            this.lblEtiqueta2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(57, 17);
            this.lblEtiqueta2.TabIndex = 1;
            this.lblEtiqueta2.Text = "FILTRO";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(8, 27);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(99, 17);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "FILTRAR POR";
            // 
            // tabPageAvanzado
            // 
            this.tabPageAvanzado.Controls.Add(this.grdGrillaFiltro);
            this.tabPageAvanzado.Controls.Add(this.btnEliminarAvanzada);
            this.tabPageAvanzado.Controls.Add(this.txtValor1);
            this.tabPageAvanzado.Controls.Add(this.txtValor6);
            this.tabPageAvanzado.Controls.Add(this.txtValor5);
            this.tabPageAvanzado.Controls.Add(this.txtValor4);
            this.tabPageAvanzado.Controls.Add(this.txtValor3);
            this.tabPageAvanzado.Controls.Add(this.txtValor2);
            this.tabPageAvanzado.Controls.Add(this.btnAgregar);
            this.tabPageAvanzado.Controls.Add(this.cmbOpcionesA);
            this.tabPageAvanzado.Controls.Add(this.cmbBuscarA);
            this.tabPageAvanzado.Location = new System.Drawing.Point(4, 25);
            this.tabPageAvanzado.Name = "tabPageAvanzado";
            this.tabPageAvanzado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAvanzado.Size = new System.Drawing.Size(792, 151);
            this.tabPageAvanzado.TabIndex = 1;
            this.tabPageAvanzado.Text = "Avanzada";
            this.tabPageAvanzado.UseVisualStyleBackColor = true;
            // 
            // grdGrillaFiltro
            // 
            this.grdGrillaFiltro.AllowDrop = true;
            this.grdGrillaFiltro.AllowUserToAddRows = false;
            this.grdGrillaFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGrillaFiltro.Location = new System.Drawing.Point(247, 15);
            this.grdGrillaFiltro.MultiSelect = false;
            this.grdGrillaFiltro.Name = "grdGrillaFiltro";
            this.grdGrillaFiltro.ReadOnly = true;
            this.grdGrillaFiltro.RowTemplate.Height = 24;
            this.grdGrillaFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGrillaFiltro.Size = new System.Drawing.Size(530, 103);
            this.grdGrillaFiltro.TabIndex = 30;
            // 
            // btnEliminarAvanzada
            // 
            this.btnEliminarAvanzada.Location = new System.Drawing.Point(154, 95);
            this.btnEliminarAvanzada.Name = "btnEliminarAvanzada";
            this.btnEliminarAvanzada.Size = new System.Drawing.Size(43, 23);
            this.btnEliminarAvanzada.TabIndex = 28;
            this.btnEliminarAvanzada.Text = "-";
            this.btnEliminarAvanzada.UseVisualStyleBackColor = true;
            this.btnEliminarAvanzada.Click += new System.EventHandler(this.btnEliminarAvanzada_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.Color.White;
            this.txtValor1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor1.Location = new System.Drawing.Point(6, 71);
            this.txtValor1.MaxLength = 20;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor1.Size = new System.Drawing.Size(235, 22);
            this.txtValor1.TabIndex = 22;
            this.txtValor1.TextoVacio = "Filtro";
            this.txtValor1.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor6
            // 
            this.txtValor6.BackColor = System.Drawing.Color.White;
            this.txtValor6.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor6.Location = new System.Drawing.Point(81, 96);
            this.txtValor6.MaxLength = 20;
            this.txtValor6.Name = "txtValor6";
            this.txtValor6.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor6.Size = new System.Drawing.Size(70, 22);
            this.txtValor6.TabIndex = 27;
            this.txtValor6.TextoVacio = "<Descripcion>";
            this.txtValor6.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor5
            // 
            this.txtValor5.BackColor = System.Drawing.Color.White;
            this.txtValor5.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor5.Location = new System.Drawing.Point(6, 96);
            this.txtValor5.MaxLength = 20;
            this.txtValor5.Name = "txtValor5";
            this.txtValor5.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor5.Size = new System.Drawing.Size(70, 22);
            this.txtValor5.TabIndex = 26;
            this.txtValor5.TextoVacio = "<Descripcion>";
            this.txtValor5.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor4
            // 
            this.txtValor4.BackColor = System.Drawing.Color.White;
            this.txtValor4.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor4.Location = new System.Drawing.Point(164, 71);
            this.txtValor4.MaxLength = 20;
            this.txtValor4.Name = "txtValor4";
            this.txtValor4.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor4.Size = new System.Drawing.Size(77, 22);
            this.txtValor4.TabIndex = 25;
            this.txtValor4.TextoVacio = "<Descripcion>";
            this.txtValor4.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor3
            // 
            this.txtValor3.BackColor = System.Drawing.Color.White;
            this.txtValor3.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor3.Location = new System.Drawing.Point(85, 71);
            this.txtValor3.MaxLength = 20;
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor3.Size = new System.Drawing.Size(75, 22);
            this.txtValor3.TabIndex = 24;
            this.txtValor3.TextoVacio = "<Descripcion>";
            this.txtValor3.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.Color.White;
            this.txtValor2.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtValor2.Location = new System.Drawing.Point(6, 71);
            this.txtValor2.MaxLength = 20;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtValor2.Size = new System.Drawing.Size(76, 22);
            this.txtValor2.TabIndex = 23;
            this.txtValor2.TextoVacio = "<Descripcion>";
            this.txtValor2.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(198, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(43, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbOpcionesA
            // 
            this.cmbOpcionesA.FormattingEnabled = true;
            this.cmbOpcionesA.Location = new System.Drawing.Point(6, 41);
            this.cmbOpcionesA.Name = "cmbOpcionesA";
            this.cmbOpcionesA.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbOpcionesA.Size = new System.Drawing.Size(235, 24);
            this.cmbOpcionesA.TabIndex = 21;
            this.cmbOpcionesA.SelectedIndexChanged += new System.EventHandler(this.cmbOpcionesA_SelectedIndexChanged);
            // 
            // cmbBuscarA
            // 
            this.cmbBuscarA.FormattingEnabled = true;
            this.cmbBuscarA.Location = new System.Drawing.Point(6, 15);
            this.cmbBuscarA.Name = "cmbBuscarA";
            this.cmbBuscarA.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbBuscarA.Size = new System.Drawing.Size(235, 24);
            this.cmbBuscarA.TabIndex = 20;
            // 
            // frmFormAdminMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 603);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.gpbGrupo4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFormAdminMini";
            this.Text = "frmFormAdminMini";
            this.Load += new System.EventHandler(this.frmFormAdminMini_Load);
            this.gpbGrupo4.ResumeLayout(false);
            this.gpbGrupo4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabPageBuscador.ResumeLayout(false);
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.tabPageAvanzado.ResumeLayout(false);
            this.tabPageAvanzado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.datos.grdGrillaAdmin dgBusqueda;
        private Controles.contenedores.tabSolapas tabAdmin;
        private System.Windows.Forms.TabPage tabPageBuscador;
        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        public Controles.datos.cmbLista cmbEstado;
        private Controles.labels.lblEtiqueta lblEEstado;
        private Controles.contenedores.gpbGrupo gpbFecha;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        private Controles.Fecha.dtpFecha dtpFechaHasta;
        private Controles.Fecha.dtpFecha dtpFechaDesde;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.buttons.btnEliminar btnEliminar;
        private Controles.buttons.btnSalir btnSalir;
        private Controles.buttons.btnExportar btnExportar;
        private Controles.buttons.btnImprimir btnImprimir;
        private Controles.buttons.btnVer btnVer;
        private Controles.buttons.btnEditar btnEditar;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.contenedores.gpbGrupo gpbFiltro;
        private Controles.txtFiltro txtFiltro;
        private Controles.datos.cmbLista cmbBuscar;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblFiltro;
        private System.Windows.Forms.TabPage tabPageAvanzado;
        private Controles.buttons.btnGeneral btnEliminarAvanzada;
        private Controles.textBoxes.txtDescripcionCorta txtValor1;
        private Controles.textBoxes.txtDescripcionCorta txtValor6;
        private Controles.textBoxes.txtDescripcionCorta txtValor5;
        private Controles.textBoxes.txtDescripcionCorta txtValor4;
        private Controles.textBoxes.txtDescripcionCorta txtValor3;
        private Controles.textBoxes.txtDescripcionCorta txtValor2;
        private Controles.buttons.btnGeneral btnAgregar;
        private Controles.datos.cmbLista cmbOpcionesA;
        private Controles.datos.cmbLista cmbBuscarA;
        private Controles.datos.grdGrillaAdmin grdGrillaFiltro;
        private Controles.buttons.btnAceptar btnAceptar;
    }
}