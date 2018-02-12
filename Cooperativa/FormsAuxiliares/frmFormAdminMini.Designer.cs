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
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new Controles.datos.cmbLista();
            this.lblEEstado = new Controles.labels.lblEtiqueta();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.dgBusqueda = new Controles.datos.grdGrillaAdmin();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnEliminar = new Controles.buttons.btnEliminar();
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
            this.gpbGrupoEstado.SuspendLayout();
            this.gpbGrupo4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
            this.gpbGrupo3.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Enabled = false;
            this.gpbGrupoEstado.Location = new System.Drawing.Point(376, 85);
            this.gpbGrupoEstado.Name = "gpbGrupoEstado";
            this.gpbGrupoEstado.Size = new System.Drawing.Size(208, 41);
            this.gpbGrupoEstado.TabIndex = 13;
            this.gpbGrupoEstado.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(55, 13);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbEstado.Size = new System.Drawing.Size(143, 21);
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
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.lblCantidad);
            this.gpbGrupo4.Controls.Add(this.dgBusqueda);
            this.gpbGrupo4.Location = new System.Drawing.Point(10, 132);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(574, 351);
            this.gpbGrupo4.TabIndex = 10;
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
            this.dgBusqueda.AllowUserToDeleteRows = false;
            this.dgBusqueda.Location = new System.Drawing.Point(6, 19);
            this.dgBusqueda.MultiSelect = false;
            this.dgBusqueda.Name = "dgBusqueda";
            this.dgBusqueda.ReadOnly = true;
            this.dgBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBusqueda.Size = new System.Drawing.Size(558, 312);
            this.dgBusqueda.TabIndex = 0;
            this.dgBusqueda.SelectionChanged += new System.EventHandler(this.dgBusqueda_SelectionChanged);
            this.dgBusqueda.DoubleClick += new System.EventHandler(this.dgBusqueda_DoubleClick);
            this.dgBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgBusqueda_KeyPress);
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
            this.gpbGrupo3.Location = new System.Drawing.Point(252, 8);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(332, 74);
            this.gpbGrupo3.TabIndex = 11;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(98, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(282, 19);
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
            this.btnExportar.Location = new System.Drawing.Point(190, 19);
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
            this.btnImprimir.Location = new System.Drawing.Point(236, 19);
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
            this.btnVer.Location = new System.Drawing.Point(144, 19);
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
            this.btnEditar.Location = new System.Drawing.Point(52, 20);
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
            this.btnNuevo.Location = new System.Drawing.Point(6, 20);
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
            this.gpbFecha.Location = new System.Drawing.Point(10, 85);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(360, 42);
            this.gpbFecha.TabIndex = 12;
            this.gpbFecha.TabStop = false;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(182, 19);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblEFechaHasta.TabIndex = 11;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(4, 19);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblEFechaDesde.TabIndex = 10;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(256, 13);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(81, 12);
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
            this.gpbFiltro.Location = new System.Drawing.Point(10, 8);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(236, 74);
            this.gpbFiltro.TabIndex = 9;
            this.gpbFiltro.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro.Location = new System.Drawing.Point(86, 41);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtFiltro.Size = new System.Drawing.Size(139, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextoVacio = "<Descripcion>";
            this.txtFiltro.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(86, 14);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbBuscar.Size = new System.Drawing.Size(139, 21);
            this.cmbBuscar.TabIndex = 2;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(6, 48);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(45, 13);
            this.lblEtiqueta2.TabIndex = 1;
            this.lblEtiqueta2.Text = "FILTRO";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(6, 22);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(78, 13);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "FILTRAR POR";
            // 
            // frmFormAdminMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 490);
            this.Controls.Add(this.gpbGrupoEstado);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbFiltro);
            this.Name = "frmFormAdminMini";
            this.Text = "frmFormAdminMini";
            this.Load += new System.EventHandler(this.frmFormAdminMini_Load);
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.gpbGrupo4.ResumeLayout(false);
            this.gpbGrupo4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        public Controles.datos.cmbLista cmbEstado;
        private Controles.labels.lblEtiqueta lblEEstado;
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.datos.grdGrillaAdmin dgBusqueda;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.buttons.btnEliminar btnEliminar;
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
        private Controles.txtFiltro txtFiltro;
        private Controles.datos.cmbLista cmbBuscar;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblFiltro;
    }
}