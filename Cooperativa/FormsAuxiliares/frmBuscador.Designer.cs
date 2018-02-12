namespace FormsAuxiliares
{
    partial class frmBuscador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new Controles.datos.cmbLista();
            this.lblEEstado = new Controles.labels.lblEtiqueta();
            this.gpbGrupoFecha = new Controles.contenedores.gpbGrupo();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbBuscar = new Controles.datos.cmbLista();
            this.txtFiltro = new Controles.txtFiltro();
            this.gbData = new Controles.contenedores.gesGroup();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgBusqueda = new Controles.datos.grdGrillaAdmin();
            this.gbBotones.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.gpbGrupoEstado.SuspendLayout();
            this.gpbGrupoFecha.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnCancelar);
            this.gbBotones.Controls.Add(this.btnAceptar);
            this.gbBotones.Location = new System.Drawing.Point(9, 439);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(581, 51);
            this.gbBotones.TabIndex = 10;
            this.gbBotones.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(464, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(310, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 31);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.gpbGrupoEstado);
            this.gbBusqueda.Controls.Add(this.gpbGrupoFecha);
            this.gbBusqueda.Controls.Add(this.lblTitulo);
            this.gbBusqueda.Controls.Add(this.cmbBuscar);
            this.gbBusqueda.Controls.Add(this.txtFiltro);
            this.gbBusqueda.Location = new System.Drawing.Point(9, 6);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(581, 118);
            this.gbBusqueda.TabIndex = 9;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            this.gbBusqueda.Enter += new System.EventHandler(this.gbBusqueda_Enter);
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Location = new System.Drawing.Point(438, 19);
            this.gpbGrupoEstado.Name = "gpbGrupoEstado";
            this.gpbGrupoEstado.Size = new System.Drawing.Size(137, 83);
            this.gpbGrupoEstado.TabIndex = 7;
            this.gpbGrupoEstado.TabStop = false;
            this.gpbGrupoEstado.Visible = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(6, 54);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(125, 24);
            this.cmbEstado.TabIndex = 8;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
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
            // gpbGrupoFecha
            // 
            this.gpbGrupoFecha.Controls.Add(this.dtpFechaHasta);
            this.gpbGrupoFecha.Controls.Add(this.dtpFechaDesde);
            this.gpbGrupoFecha.Controls.Add(this.lblEFechaHasta);
            this.gpbGrupoFecha.Controls.Add(this.lblEFechaDesde);
            this.gpbGrupoFecha.Location = new System.Drawing.Point(206, 19);
            this.gpbGrupoFecha.Name = "gpbGrupoFecha";
            this.gpbGrupoFecha.Size = new System.Drawing.Size(226, 83);
            this.gpbGrupoFecha.TabIndex = 6;
            this.gpbGrupoFecha.TabStop = false;
            this.gpbGrupoFecha.Visible = false;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(117, 55);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(96, 22);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(6, 55);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(96, 22);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(114, 16);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(88, 17);
            this.lblEFechaHasta.TabIndex = 7;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(6, 16);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(92, 17);
            this.lblEFechaDesde.TabIndex = 6;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(6, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(81, 17);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Buscar por:";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(49, 36);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(140, 24);
            this.cmbBuscar.TabIndex = 2;
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro.Location = new System.Drawing.Point(49, 74);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(140, 22);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextoVacio = "<Descripcion>";
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lblCantidad);
            this.gbData.Controls.Add(this.dgBusqueda);
            this.gbData.Location = new System.Drawing.Point(9, 130);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(581, 307);
            this.gbData.TabIndex = 8;
            this.gbData.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(9, 288);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(169, 17);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Se econtraron 0 registros";
            // 
            // dgBusqueda
            // 
            this.dgBusqueda.Location = new System.Drawing.Point(6, 19);
            this.dgBusqueda.Name = "dgBusqueda";
            this.dgBusqueda.ReadOnly = true;
            this.dgBusqueda.Size = new System.Drawing.Size(569, 261);
            this.dgBusqueda.TabIndex = 0;
            // 
            // frmBuscador
            // 
            this.ClientSize = new System.Drawing.Size(597, 495);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.gbData);
            this.Name = "frmBuscador";
            this.Load += new System.EventHandler(this.frmBuscador_Load);
            this.gbBotones.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.gpbGrupoFecha.ResumeLayout(false);
            this.gpbGrupoFecha.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.GroupBox gbBusqueda;
        internal System.Windows.Forms.Label lblTitulo;
        private Controles.datos.cmbLista cmbBuscar;
        private Controles.contenedores.gesGroup gbData;
        private System.Windows.Forms.Label lblCantidad;
        public Controles.datos.grdGrillaAdmin dgBusqueda;
        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        private Controles.datos.cmbLista cmbEstado;
        private Controles.labels.lblEtiqueta lblEEstado;
        private Controles.contenedores.gpbGrupo gpbGrupoFecha;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        internal Controles.txtFiltro txtFiltro;
    }
}
