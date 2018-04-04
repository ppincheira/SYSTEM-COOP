namespace FormsAuxiliares
{
    partial class frmDobleGrillaCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDobleGrillaCrud));
            this.gpbGrupoFiltro = new Controles.contenedores.gpbGrupo();
            this.cmbBoxCampoSecundario = new Controles.datos.cmbLista();
            this.cmbBoxCamposPrimario = new Controles.datos.cmbLista();
            this.txtFiltroSecundario = new Controles.textBoxes.txtDescripcion();
            this.txtFiltroPrimario = new Controles.textBoxes.txtDescripcion();
            this.lblFiltroEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblFiltroEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.GrillaPrimaria = new Controles.datos.grdGrillaEdit();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.btnEliminar1 = new Controles.buttons.btnEliminar();
            this.btnCancelar1 = new Controles.buttons.btnCancelar();
            this.btnAceptar1 = new Controles.buttons.btnAceptar();
            this.GrillaSecundaria = new Controles.datos.grdGrillaEdit();
            this.lblCantidadPrimaria = new Controles.labels.lblEtiqueta();
            this.lblCantidadSecundaria = new Controles.labels.lblEtiqueta();
            this.gpbGrupoFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPrimaria)).BeginInit();
            this.gpbGrupo3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSecundaria)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGrupoFiltro
            // 
            this.gpbGrupoFiltro.Controls.Add(this.cmbBoxCampoSecundario);
            this.gpbGrupoFiltro.Controls.Add(this.cmbBoxCamposPrimario);
            this.gpbGrupoFiltro.Controls.Add(this.txtFiltroSecundario);
            this.gpbGrupoFiltro.Controls.Add(this.txtFiltroPrimario);
            this.gpbGrupoFiltro.Controls.Add(this.lblFiltroEtiqueta2);
            this.gpbGrupoFiltro.Controls.Add(this.lblFiltroEtiqueta1);
            this.gpbGrupoFiltro.Location = new System.Drawing.Point(12, 12);
            this.gpbGrupoFiltro.Name = "gpbGrupoFiltro";
            this.gpbGrupoFiltro.Size = new System.Drawing.Size(597, 87);
            this.gpbGrupoFiltro.TabIndex = 0;
            this.gpbGrupoFiltro.TabStop = false;
            this.gpbGrupoFiltro.Text = "Filtro";
            // 
            // cmbBoxCampoSecundario
            // 
            this.cmbBoxCampoSecundario.Enabled = false;
            this.cmbBoxCampoSecundario.FormattingEnabled = true;
            this.cmbBoxCampoSecundario.Location = new System.Drawing.Point(399, 17);
            this.cmbBoxCampoSecundario.Name = "cmbBoxCampoSecundario";
            this.cmbBoxCampoSecundario.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbBoxCampoSecundario.Size = new System.Drawing.Size(192, 21);
            this.cmbBoxCampoSecundario.TabIndex = 8;
            // 
            // cmbBoxCamposPrimario
            // 
            this.cmbBoxCamposPrimario.FormattingEnabled = true;
            this.cmbBoxCamposPrimario.Location = new System.Drawing.Point(103, 16);
            this.cmbBoxCamposPrimario.Name = "cmbBoxCamposPrimario";
            this.cmbBoxCamposPrimario.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbBoxCamposPrimario.Size = new System.Drawing.Size(160, 21);
            this.cmbBoxCamposPrimario.TabIndex = 7;
            // 
            // txtFiltroSecundario
            // 
            this.txtFiltroSecundario.BackColor = System.Drawing.Color.White;
            this.txtFiltroSecundario.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltroSecundario.Enabled = false;
            this.txtFiltroSecundario.Location = new System.Drawing.Point(399, 44);
            this.txtFiltroSecundario.MaxLength = 50;
            this.txtFiltroSecundario.Name = "txtFiltroSecundario";
            this.txtFiltroSecundario.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtFiltroSecundario.Size = new System.Drawing.Size(192, 20);
            this.txtFiltroSecundario.TabIndex = 6;
            this.txtFiltroSecundario.TextoVacio = "<Descripcion>";
            this.txtFiltroSecundario.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtFiltroPrimario
            // 
            this.txtFiltroPrimario.BackColor = System.Drawing.Color.White;
            this.txtFiltroPrimario.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltroPrimario.Location = new System.Drawing.Point(104, 44);
            this.txtFiltroPrimario.MaxLength = 50;
            this.txtFiltroPrimario.Name = "txtFiltroPrimario";
            this.txtFiltroPrimario.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtFiltroPrimario.Size = new System.Drawing.Size(159, 20);
            this.txtFiltroPrimario.TabIndex = 5;
            this.txtFiltroPrimario.TextoVacio = "<Descripcion>";
            this.txtFiltroPrimario.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            this.txtFiltroPrimario.TextChanged += new System.EventHandler(this.txtFiltroPrimario_TextChanged);
            // 
            // lblFiltroEtiqueta2
            // 
            this.lblFiltroEtiqueta2.AutoSize = true;
            this.lblFiltroEtiqueta2.Location = new System.Drawing.Point(296, 19);
            this.lblFiltroEtiqueta2.Name = "lblFiltroEtiqueta2";
            this.lblFiltroEtiqueta2.Size = new System.Drawing.Size(80, 13);
            this.lblFiltroEtiqueta2.TabIndex = 4;
            this.lblFiltroEtiqueta2.Text = "SECUNDARIA:";
            // 
            // lblFiltroEtiqueta1
            // 
            this.lblFiltroEtiqueta1.AutoSize = true;
            this.lblFiltroEtiqueta1.Location = new System.Drawing.Point(6, 19);
            this.lblFiltroEtiqueta1.Name = "lblFiltroEtiqueta1";
            this.lblFiltroEtiqueta1.Size = new System.Drawing.Size(62, 13);
            this.lblFiltroEtiqueta1.TabIndex = 1;
            this.lblFiltroEtiqueta1.Text = "PRIMARIA:";
            // 
            // GrillaPrimaria
            // 
            this.GrillaPrimaria.AllowUserToAddRows = false;
            this.GrillaPrimaria.AllowUserToDeleteRows = false;
            this.GrillaPrimaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPrimaria.Location = new System.Drawing.Point(12, 123);
            this.GrillaPrimaria.Name = "GrillaPrimaria";
            this.GrillaPrimaria.ReadOnly = true;
            this.GrillaPrimaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaPrimaria.Size = new System.Drawing.Size(263, 271);
            this.GrillaPrimaria.TabIndex = 1;
            this.GrillaPrimaria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaPrimaria_CellClick);
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.btnNuevo);
            this.gpbGrupo3.Controls.Add(this.btnEliminar1);
            this.gpbGrupo3.Controls.Add(this.btnCancelar1);
            this.gpbGrupo3.Controls.Add(this.btnAceptar1);
            this.gpbGrupo3.Location = new System.Drawing.Point(311, 423);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(289, 84);
            this.gpbGrupo3.TabIndex = 2;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(6, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar1.BackgroundImage")));
            this.btnEliminar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar1.Location = new System.Drawing.Point(52, 19);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar1.TabIndex = 9;
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar1.Image")));
            this.btnCancelar1.Location = new System.Drawing.Point(203, 18);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar1.TabIndex = 1;
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // btnAceptar1
            // 
            this.btnAceptar1.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar1.Image")));
            this.btnAceptar1.Location = new System.Drawing.Point(112, 18);
            this.btnAceptar1.Name = "btnAceptar1";
            this.btnAceptar1.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar1.TabIndex = 0;
            this.btnAceptar1.UseVisualStyleBackColor = true;
            this.btnAceptar1.Click += new System.EventHandler(this.btnAceptar1_Click);
            // 
            // GrillaSecundaria
            // 
            this.GrillaSecundaria.AllowUserToAddRows = false;
            this.GrillaSecundaria.AllowUserToDeleteRows = false;
            this.GrillaSecundaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaSecundaria.Location = new System.Drawing.Point(311, 123);
            this.GrillaSecundaria.Name = "GrillaSecundaria";
            this.GrillaSecundaria.ReadOnly = true;
            this.GrillaSecundaria.Size = new System.Drawing.Size(289, 271);
            this.GrillaSecundaria.TabIndex = 3;
            // 
            // lblCantidadPrimaria
            // 
            this.lblCantidadPrimaria.AutoSize = true;
            this.lblCantidadPrimaria.Location = new System.Drawing.Point(9, 397);
            this.lblCantidadPrimaria.Name = "lblCantidadPrimaria";
            this.lblCantidadPrimaria.Size = new System.Drawing.Size(171, 13);
            this.lblCantidadPrimaria.TabIndex = 4;
            this.lblCantidadPrimaria.Text = "Cantidad de registros encontrados:";
            // 
            // lblCantidadSecundaria
            // 
            this.lblCantidadSecundaria.AutoSize = true;
            this.lblCantidadSecundaria.Location = new System.Drawing.Point(308, 397);
            this.lblCantidadSecundaria.Name = "lblCantidadSecundaria";
            this.lblCantidadSecundaria.Size = new System.Drawing.Size(171, 13);
            this.lblCantidadSecundaria.TabIndex = 5;
            this.lblCantidadSecundaria.Text = "Cantidad de registros encontrados:";
            // 
            // frmDobleGrillaCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 519);
            this.Controls.Add(this.lblCantidadSecundaria);
            this.Controls.Add(this.lblCantidadPrimaria);
            this.Controls.Add(this.GrillaSecundaria);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.GrillaPrimaria);
            this.Controls.Add(this.gpbGrupoFiltro);
            this.Name = "frmDobleGrillaCrud";
            this.Text = "frmRolesCrud";
            this.Load += new System.EventHandler(this.frmRolesCrud_Load);
            this.gpbGrupoFiltro.ResumeLayout(false);
            this.gpbGrupoFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPrimaria)).EndInit();
            this.gpbGrupo3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSecundaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.contenedores.gpbGrupo gpbGrupoFiltro;
        private Controles.labels.lblEtiqueta lblFiltroEtiqueta1;
        private Controles.datos.grdGrillaEdit GrillaPrimaria;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.buttons.btnCancelar btnCancelar1;
        private Controles.buttons.btnAceptar btnAceptar1;
        private Controles.textBoxes.txtDescripcion txtFiltroSecundario;
        private Controles.textBoxes.txtDescripcion txtFiltroPrimario;
        private Controles.labels.lblEtiqueta lblFiltroEtiqueta2;
        private Controles.datos.grdGrillaEdit GrillaSecundaria;
        private Controles.labels.lblEtiqueta lblCantidadPrimaria;
        private Controles.labels.lblEtiqueta lblCantidadSecundaria;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.buttons.btnEliminar btnEliminar1;
        private Controles.datos.cmbLista cmbBoxCamposPrimario;
        private Controles.datos.cmbLista cmbBoxCampoSecundario;
    }
}