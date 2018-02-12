namespace FormsAuxiliares
{
    partial class frmObservacionesCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservacionesCrud));
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.btnVer = new Controles.buttons.btnGeneral();
            this.txtDescripcionPath = new Controles.textBoxes.txtDescripcionCorta();
            this.dtpFecha = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.btnAgregar = new Controles.buttons.btnGeneral();
            this.lbAdjunto = new Controles.labels.lblEtiqueta();
            this.lbFecha = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.txtDetalle = new Controles.textBoxes.txtObservaciones();
            this.lbDetalle = new Controles.labels.lblEtiqueta();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkPorDefecto = new Controles.datos.chkBox();
            this.gbDatos.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.chkPorDefecto);
            this.gbDatos.Controls.Add(this.btnVer);
            this.gbDatos.Controls.Add(this.txtDescripcionPath);
            this.gbDatos.Controls.Add(this.dtpFecha);
            this.gbDatos.Controls.Add(this.lblEtiqueta2);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.lbAdjunto);
            this.gbDatos.Controls.Add(this.lbFecha);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.txtDetalle);
            this.gbDatos.Controls.Add(this.lbDetalle);
            this.gbDatos.Location = new System.Drawing.Point(16, 15);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Size = new System.Drawing.Size(672, 313);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(599, 252);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(49, 41);
            this.btnVer.TabIndex = 13;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtDescripcionPath
            // 
            this.txtDescripcionPath.BackColor = System.Drawing.Color.White;
            this.txtDescripcionPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionPath.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcionPath.Location = new System.Drawing.Point(232, 268);
            this.txtDescripcionPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionPath.MaxLength = 20;
            this.txtDescripcionPath.Name = "txtDescripcionPath";
            this.txtDescripcionPath.ReadOnly = true;
            this.txtDescripcionPath.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDescripcionPath.Size = new System.Drawing.Size(357, 22);
            this.txtDescripcionPath.TabIndex = 12;
            this.txtDescripcionPath.TextoVacio = "<Descripcion>";
            this.txtDescripcionPath.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(163, 34);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFecha.Size = new System.Drawing.Size(139, 22);
            this.dtpFecha.TabIndex = 11;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(52, 276);
            this.lblEtiqueta2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(65, 17);
            this.lblEtiqueta2.TabIndex = 10;
            this.lblEtiqueta2.Text = "Adjuntar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(163, 254);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(49, 41);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "...";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbAdjunto
            // 
            this.lbAdjunto.AutoSize = true;
            this.lbAdjunto.Location = new System.Drawing.Point(52, 277);
            this.lbAdjunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdjunto.Name = "lbAdjunto";
            this.lbAdjunto.Size = new System.Drawing.Size(65, 17);
            this.lbAdjunto.TabIndex = 10;
            this.lbAdjunto.Text = "Adjuntar:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(52, 42);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(51, 17);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha:";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(52, 80);
            this.lblEtiqueta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(56, 17);
            this.lblEtiqueta1.TabIndex = 0;
            this.lblEtiqueta1.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.Color.White;
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDetalle.Location = new System.Drawing.Point(163, 78);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDetalle.Size = new System.Drawing.Size(484, 168);
            this.txtDetalle.TabIndex = 2;
            this.txtDetalle.TextoVacio = "<Descripcion>";
            this.txtDetalle.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Location = new System.Drawing.Point(52, 81);
            this.lbDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(56, 17);
            this.lbDetalle.TabIndex = 0;
            this.lbDetalle.Text = "Detalle:";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(16, 335);
            this.gesGroup2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gesGroup2.Size = new System.Drawing.Size(672, 110);
            this.gesGroup2.TabIndex = 1;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(432, 17);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 74);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(557, 17);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 74);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkPorDefecto
            // 
            this.chkPorDefecto.AutoSize = true;
            this.chkPorDefecto.Location = new System.Drawing.Point(542, 33);
            this.chkPorDefecto.Name = "chkPorDefecto";
            this.chkPorDefecto.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkPorDefecto.Size = new System.Drawing.Size(105, 21);
            this.chkPorDefecto.TabIndex = 14;
            this.chkPorDefecto.Text = "Por Defecto";
            this.chkPorDefecto.UseVisualStyleBackColor = true;
            // 
            // frmObservacionesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 459);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmObservacionesCrud";
            this.Text = "frmObservacionesCrud";
            this.Load += new System.EventHandler(this.frmObservacionesCrud_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gbDatos;
        private Controles.labels.lblEtiqueta lbFecha;
        private Controles.textBoxes.txtObservaciones txtDetalle;
        private Controles.labels.lblEtiqueta lbDetalle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.labels.lblEtiqueta lbAdjunto;
        private Controles.buttons.btnGeneral btnAgregar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Controles.Fecha.dtpFecha dtpFecha;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionPath;
        private Controles.buttons.btnGeneral btnVer;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.datos.chkBox chkPorDefecto;
    }
}