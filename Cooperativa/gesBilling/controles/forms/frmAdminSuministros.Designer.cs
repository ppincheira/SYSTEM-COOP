namespace gesBilling.controles.forms
{
    partial class frmAdminSuministros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminSuministros));
            this.gpbGrupoEstado = new Controles.contenedores.gpbGrupo();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
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
            this.txtFiltro = new Controles.txtFiltro();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblFiltro = new Controles.labels.lblEtiqueta();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.dgBusqueda = new Controles.datos.gesGrid();
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.tabSolapas1 = new Controles.contenedores.tabSolapas();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.btnAccionesSuministros2 = new Controles.buttons.btnAccionesSuministros();
            this.btnAccionesSuministros1 = new Controles.buttons.btnAccionesSuministros();
            this.gpbGrupoEstado.SuspendLayout();
            this.gpbGrupo3.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbGrupo4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
            this.gpbGrupo1.SuspendLayout();
            this.tabSolapas1.SuspendLayout();
            this.gpbGrupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupoEstado
            // 
            this.gpbGrupoEstado.Controls.Add(this.cmbEstado);
            this.gpbGrupoEstado.Controls.Add(this.lblEEstado);
            this.gpbGrupoEstado.Enabled = false;
            this.gpbGrupoEstado.Location = new System.Drawing.Point(605, 67);
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
            this.gpbGrupo3.Location = new System.Drawing.Point(605, 12);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(332, 53);
            this.gpbGrupo3.TabIndex = 10;
            this.gpbGrupo3.TabStop = false;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar1.BackgroundImage")));
            this.btnEliminar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar1.Location = new System.Drawing.Point(98, 9);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar1.FUN_CODIGO = "134";
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
            this.btnEditar.Location = new System.Drawing.Point(52, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(6, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.lblEFechaHasta);
            this.gpbFecha.Controls.Add(this.lblEFechaDesde);
            this.gpbFecha.Controls.Add(this.dtpFechaHasta);
            this.gpbFecha.Controls.Add(this.dtpFechaDesde);
            this.gpbFecha.Enabled = false;
            this.gpbFecha.Location = new System.Drawing.Point(399, 12);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(200, 103);
            this.gpbFecha.TabIndex = 11;
            this.gpbFecha.TabStop = false;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(4, 65);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblEFechaHasta.TabIndex = 11;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(4, 23);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblEFechaDesde.TabIndex = 10;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(81, 58);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(81, 17);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro.Location = new System.Drawing.Point(86, 58);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(289, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextoVacio = "<Descripcion>";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(86, 14);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(289, 21);
            this.cmbBuscar.TabIndex = 2;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(6, 64);
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
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.lblCantidad);
            this.gpbGrupo4.Controls.Add(this.dgBusqueda);
            this.gpbGrupo4.Location = new System.Drawing.Point(12, 121);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(925, 351);
            this.gpbGrupo4.TabIndex = 13;
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
            this.dgBusqueda.DataMember = "";
            //this.dgBusqueda.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgBusqueda.Location = new System.Drawing.Point(6, 19);
            this.dgBusqueda.Name = "dgBusqueda";
            this.dgBusqueda.Size = new System.Drawing.Size(913, 312);
            this.dgBusqueda.TabIndex = 0;
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.tabSolapas1);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 478);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(1315, 335);
            this.gpbGrupo1.TabIndex = 14;
            this.gpbGrupo1.TabStop = false;
            this.gpbGrupo1.Text = "Datos";
            // 
            // tabSolapas1
            // 
            this.tabSolapas1.Controls.Add(this.tabPage1);
            this.tabSolapas1.Controls.Add(this.tabPage2);
            this.tabSolapas1.Location = new System.Drawing.Point(10, 19);
            this.tabSolapas1.Name = "tabSolapas1";
            this.tabSolapas1.SelectedIndex = 0;
            this.tabSolapas1.Size = new System.Drawing.Size(1299, 301);
            this.tabSolapas1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1291, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CUENTA CORREINTE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1291, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSUMOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Controls.Add(this.btnAccionesSuministros2);
            this.gpbGrupo2.Controls.Add(this.btnAccionesSuministros1);
            this.gpbGrupo2.Location = new System.Drawing.Point(943, 12);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(384, 460);
            this.gpbGrupo2.TabIndex = 15;
            this.gpbGrupo2.TabStop = false;
            this.gpbGrupo2.Text = "Datos";
            // 
            // btnAccionesSuministros2
            // 
            this.btnAccionesSuministros2.Location = new System.Drawing.Point(204, 24);
            this.btnAccionesSuministros2.Name = "btnAccionesSuministros2";
            this.btnAccionesSuministros2.Size = new System.Drawing.Size(170, 60);
            this.btnAccionesSuministros2.TabIndex = 1;
            this.btnAccionesSuministros2.Text = "RUTA";
            this.btnAccionesSuministros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccionesSuministros2.UseVisualStyleBackColor = true;
            // 
            // btnAccionesSuministros1
            // 
             this.btnAccionesSuministros1.Location = new System.Drawing.Point(6, 23);
            this.btnAccionesSuministros1.Name = "btnAccionesSuministros1";
            this.btnAccionesSuministros1.Size = new System.Drawing.Size(170, 60);
            this.btnAccionesSuministros1.TabIndex = 0;
            this.btnAccionesSuministros1.Text = "CATEGORIA";
            this.btnAccionesSuministros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccionesSuministros1.UseVisualStyleBackColor = true;
            // 
            // frmAdminSuministros
            // 
            this.ClientSize = new System.Drawing.Size(1339, 825);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupoEstado);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbFecha);
            this.Name = "frmAdminSuministros";
            this.gpbGrupoEstado.ResumeLayout(false);
            this.gpbGrupoEstado.PerformLayout();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbGrupo4.ResumeLayout(false);
            this.gpbGrupo4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
            this.gpbGrupo1.ResumeLayout(false);
            this.tabSolapas1.ResumeLayout(false);
            this.gpbGrupo2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gpbGrupo gpbGrupoEstado;
        public System.Windows.Forms.ComboBox cmbEstado;
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
        private Controles.txtFiltro txtFiltro;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblFiltro;
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.datos.gesGrid dgBusqueda;
        private Controles.contenedores.gpbGrupo gpbGrupo1;
        private Controles.contenedores.gpbGrupo gpbGrupo2;
        private Controles.contenedores.tabSolapas tabSolapas1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controles.buttons.btnAccionesSuministros btnAccionesSuministros2;
        private Controles.buttons.btnAccionesSuministros btnAccionesSuministros1;
    }
}
