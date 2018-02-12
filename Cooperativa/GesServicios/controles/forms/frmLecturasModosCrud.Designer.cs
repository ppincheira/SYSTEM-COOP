namespace GesServicios.controles.forms
{
    partial class frmLecturasModosCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLecturasModosCrud));
            this.gesGroup1 = new Controles.contenedores.gesGroup();
            this.txtLEMDescripcion = new Controles.textBoxes.txtDescripcion();
            this.lblESTCodigo = new Controles.labels.lblEtiqueta();
            this.cmbSRVCodigo = new Controles.datos.cmbLista();
            this.chkESTCodigo = new Controles.datos.chkBox();
            this.lblSRVCodigo = new Controles.labels.lblEtiqueta();
            this.dtpFechaAlta = new Controles.Fecha.dtpFecha();
            this.lblLEMFechaAlta = new Controles.labels.lblEtiqueta();
            this.lblLEMDescripcion = new Controles.labels.lblEtiqueta();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gesGroup3 = new Controles.contenedores.gesGroup();
            this.grdLecturasConceptos = new Controles.datos.grdGrillaEdit();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gesGroup1.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.gesGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLecturasConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // gesGroup1
            // 
            this.gesGroup1.Controls.Add(this.txtLEMDescripcion);
            this.gesGroup1.Controls.Add(this.lblESTCodigo);
            this.gesGroup1.Controls.Add(this.cmbSRVCodigo);
            this.gesGroup1.Controls.Add(this.chkESTCodigo);
            this.gesGroup1.Controls.Add(this.lblSRVCodigo);
            this.gesGroup1.Controls.Add(this.dtpFechaAlta);
            this.gesGroup1.Controls.Add(this.lblLEMFechaAlta);
            this.gesGroup1.Controls.Add(this.lblLEMDescripcion);
            this.gesGroup1.Location = new System.Drawing.Point(12, 12);
            this.gesGroup1.Name = "gesGroup1";
            this.gesGroup1.Size = new System.Drawing.Size(558, 189);
            this.gesGroup1.TabIndex = 0;
            this.gesGroup1.TabStop = false;
            this.gesGroup1.Text = "Datos";
            // 
            // txtLEMDescripcion
            // 
            this.txtLEMDescripcion.BackColor = System.Drawing.Color.White;
            this.txtLEMDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLEMDescripcion.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtLEMDescripcion.Location = new System.Drawing.Point(89, 10);
            this.txtLEMDescripcion.MaxLength = 50;
            this.txtLEMDescripcion.Name = "txtLEMDescripcion";
            this.txtLEMDescripcion.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtLEMDescripcion.Size = new System.Drawing.Size(199, 20);
            this.txtLEMDescripcion.TabIndex = 1;
            this.txtLEMDescripcion.TextoVacio = "<Descripcion>";
            this.txtLEMDescripcion.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblESTCodigo
            // 
            this.lblESTCodigo.AutoSize = true;
            this.lblESTCodigo.Location = new System.Drawing.Point(6, 154);
            this.lblESTCodigo.Name = "lblESTCodigo";
            this.lblESTCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblESTCodigo.TabIndex = 14;
            this.lblESTCodigo.Text = "Estado:";
            // 
            // cmbSRVCodigo
            // 
            this.cmbSRVCodigo.FormattingEnabled = true;
            this.cmbSRVCodigo.Location = new System.Drawing.Point(89, 44);
            this.cmbSRVCodigo.Name = "cmbSRVCodigo";
            this.cmbSRVCodigo.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbSRVCodigo.Size = new System.Drawing.Size(199, 21);
            this.cmbSRVCodigo.TabIndex = 2;
            // 
            // chkESTCodigo
            // 
            this.chkESTCodigo.AutoSize = true;
            this.chkESTCodigo.Checked = true;
            this.chkESTCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkESTCodigo.Location = new System.Drawing.Point(89, 150);
            this.chkESTCodigo.Name = "chkESTCodigo";
            this.chkESTCodigo.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkESTCodigo.Size = new System.Drawing.Size(73, 17);
            this.chkESTCodigo.TabIndex = 5;
            this.chkESTCodigo.Text = "Habilitado";
            this.chkESTCodigo.UseVisualStyleBackColor = true;
            // 
            // lblSRVCodigo
            // 
            this.lblSRVCodigo.AutoSize = true;
            this.lblSRVCodigo.Location = new System.Drawing.Point(6, 52);
            this.lblSRVCodigo.Name = "lblSRVCodigo";
            this.lblSRVCodigo.Size = new System.Drawing.Size(53, 13);
            this.lblSRVCodigo.TabIndex = 11;
            this.lblSRVCodigo.Text = "Servicios:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(89, 83);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaAlta.Size = new System.Drawing.Size(199, 20);
            this.dtpFechaAlta.TabIndex = 3;
            // 
            // lblLEMFechaAlta
            // 
            this.lblLEMFechaAlta.AutoSize = true;
            this.lblLEMFechaAlta.Location = new System.Drawing.Point(6, 90);
            this.lblLEMFechaAlta.Name = "lblLEMFechaAlta";
            this.lblLEMFechaAlta.Size = new System.Drawing.Size(61, 13);
            this.lblLEMFechaAlta.TabIndex = 9;
            this.lblLEMFechaAlta.Text = "Fecha Alta:";
            // 
            // lblLEMDescripcion
            // 
            this.lblLEMDescripcion.AutoSize = true;
            this.lblLEMDescripcion.Location = new System.Drawing.Point(6, 16);
            this.lblLEMDescripcion.Name = "lblLEMDescripcion";
            this.lblLEMDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblLEMDescripcion.TabIndex = 8;
            this.lblLEMDescripcion.Text = "Descripcion:";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(370, 372);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(200, 100);
            this.gesGroup2.TabIndex = 1;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(6, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(114, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gesGroup3
            // 
            this.gesGroup3.Controls.Add(this.grdLecturasConceptos);
            this.gesGroup3.Location = new System.Drawing.Point(12, 207);
            this.gesGroup3.Name = "gesGroup3";
            this.gesGroup3.Size = new System.Drawing.Size(558, 159);
            this.gesGroup3.TabIndex = 2;
            this.gesGroup3.TabStop = false;
            this.gesGroup3.Text = "Conceptos";
            // 
            // grdLecturasConceptos
            // 
            this.grdLecturasConceptos.AllowUserToAddRows = false;
            this.grdLecturasConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLecturasConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdLecturasConceptos.Location = new System.Drawing.Point(9, 19);
            this.grdLecturasConceptos.MultiSelect = false;
            this.grdLecturasConceptos.Name = "grdLecturasConceptos";
            this.grdLecturasConceptos.Size = new System.Drawing.Size(544, 134);
            this.grdLecturasConceptos.TabIndex = 1;
            this.grdLecturasConceptos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLecturasConceptos_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DESCRIPCION CORTA";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESCRIPCION";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // frmLecturasModosCrudAux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 484);
            this.Controls.Add(this.gesGroup3);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gesGroup1);
            this.Name = "frmLecturasModosCrudAux";
            this.Text = "frmLecturasModosCrudAux";
            this.Load += new System.EventHandler(this.frmLecturasModosCrudAux_Load);
            this.gesGroup1.ResumeLayout(false);
            this.gesGroup1.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.gesGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLecturasConceptos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup1;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.contenedores.gesGroup gesGroup3;
        private Controles.labels.lblEtiqueta lblESTCodigo;
        private Controles.datos.cmbLista cmbSRVCodigo;
        private Controles.datos.chkBox chkESTCodigo;
        private Controles.labels.lblEtiqueta lblSRVCodigo;
        private Controles.Fecha.dtpFecha dtpFechaAlta;
        private Controles.labels.lblEtiqueta lblLEMFechaAlta;
        private Controles.labels.lblEtiqueta lblLEMDescripcion;
        private Controles.textBoxes.txtDescripcion txtLEMDescripcion;
        private Controles.datos.grdGrillaEdit grdLecturasConceptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}