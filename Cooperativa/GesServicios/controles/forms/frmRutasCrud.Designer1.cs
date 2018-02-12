namespace GesServicios.controles.forms
{
    partial class frmRutasCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRutasCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.btnGeneral2 = new Controles.buttons.btnGeneral();
            this.btnVer = new Controles.buttons.btnGeneral();
            this.txtDescripcionCorta1 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtDescripcionPath = new Controles.textBoxes.txtDescripcionCorta();
            this.dtpFecha1 = new Controles.Fecha.dtpFecha();
            this.btnGeneral1 = new Controles.buttons.btnGeneral();
            this.dtpFecha = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.btnAgregar = new Controles.buttons.btnGeneral();
            this.lbAdjunto = new Controles.labels.lblEtiqueta();
            this.txtObservaciones1 = new Controles.textBoxes.txtObservaciones();
            this.lbFecha = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.txtDetalle = new Controles.textBoxes.txtObservaciones();
            this.lbDetalle = new Controles.labels.lblEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(40, 312);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(504, 89);
            this.gesGroup2.TabIndex = 3;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(309, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(418, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnGeneral2);
            this.gbDatos.Controls.Add(this.btnVer);
            this.gbDatos.Controls.Add(this.txtDescripcionCorta1);
            this.gbDatos.Controls.Add(this.txtDescripcionPath);
            this.gbDatos.Controls.Add(this.dtpFecha1);
            this.gbDatos.Controls.Add(this.btnGeneral1);
            this.gbDatos.Controls.Add(this.dtpFecha);
            this.gbDatos.Controls.Add(this.lblEtiqueta2);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.lbAdjunto);
            this.gbDatos.Controls.Add(this.txtObservaciones1);
            this.gbDatos.Controls.Add(this.lbFecha);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.txtDetalle);
            this.gbDatos.Controls.Add(this.lbDetalle);
            this.gbDatos.Location = new System.Drawing.Point(40, 52);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(504, 254);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // btnGeneral2
            // 
            this.btnGeneral2.Location = new System.Drawing.Point(449, 204);
            this.btnGeneral2.Name = "btnGeneral2";
            this.btnGeneral2.Size = new System.Drawing.Size(37, 33);
            this.btnGeneral2.TabIndex = 13;
            this.btnGeneral2.Text = "Ver";
            this.btnGeneral2.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(449, 205);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(37, 33);
            this.btnVer.TabIndex = 13;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionCorta1
            // 
            this.txtDescripcionCorta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCorta1.Location = new System.Drawing.Point(174, 217);
            this.txtDescripcionCorta1.MaxLength = 20;
            this.txtDescripcionCorta1.Name = "txtDescripcionCorta1";
            this.txtDescripcionCorta1.ReadOnly = true;
            this.txtDescripcionCorta1.Size = new System.Drawing.Size(269, 20);
            this.txtDescripcionCorta1.TabIndex = 12;
            // 
            // txtDescripcionPath
            // 
            this.txtDescripcionPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionPath.Location = new System.Drawing.Point(174, 218);
            this.txtDescripcionPath.MaxLength = 20;
            this.txtDescripcionPath.Name = "txtDescripcionPath";
            this.txtDescripcionPath.ReadOnly = true;
            this.txtDescripcionPath.Size = new System.Drawing.Size(269, 20);
            this.txtDescripcionPath.TabIndex = 12;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(122, 27);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(105, 20);
            this.dtpFecha1.TabIndex = 11;
            // 
            // btnGeneral1
            // 
            this.btnGeneral1.Location = new System.Drawing.Point(122, 205);
            this.btnGeneral1.Name = "btnGeneral1";
            this.btnGeneral1.Size = new System.Drawing.Size(37, 33);
            this.btnGeneral1.TabIndex = 3;
            this.btnGeneral1.Text = "...";
            this.btnGeneral1.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(122, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(105, 20);
            this.dtpFecha.TabIndex = 11;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(39, 224);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(49, 13);
            this.lblEtiqueta2.TabIndex = 10;
            this.lblEtiqueta2.Text = "Adjuntar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(122, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(37, 33);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "...";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lbAdjunto
            // 
            this.lbAdjunto.AutoSize = true;
            this.lbAdjunto.Location = new System.Drawing.Point(39, 225);
            this.lbAdjunto.Name = "lbAdjunto";
            this.lbAdjunto.Size = new System.Drawing.Size(49, 13);
            this.lbAdjunto.TabIndex = 10;
            this.lbAdjunto.Text = "Adjuntar:";
            // 
            // txtObservaciones1
            // 
            this.txtObservaciones1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones1.Location = new System.Drawing.Point(122, 62);
            this.txtObservaciones1.Multiline = true;
            this.txtObservaciones1.Name = "txtObservaciones1";
            this.txtObservaciones1.Size = new System.Drawing.Size(364, 137);
            this.txtObservaciones1.TabIndex = 2;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(39, 34);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(40, 13);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha:";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(39, 65);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta1.TabIndex = 0;
            this.lblEtiqueta1.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.Location = new System.Drawing.Point(122, 63);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(364, 137);
            this.txtDetalle.TabIndex = 2;
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Location = new System.Drawing.Point(39, 66);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(43, 13);
            this.lbDetalle.TabIndex = 0;
            this.lbDetalle.Text = "Detalle:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(585, 453);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gesGroup2.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.contenedores.gesGroup gbDatos;
        private Controles.buttons.btnGeneral btnGeneral2;
        private Controles.buttons.btnGeneral btnVer;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta1;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionPath;
        private Controles.Fecha.dtpFecha dtpFecha1;
        private Controles.buttons.btnGeneral btnGeneral1;
        private Controles.Fecha.dtpFecha dtpFecha;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.buttons.btnGeneral btnAgregar;
        private Controles.labels.lblEtiqueta lbAdjunto;
        private Controles.textBoxes.txtObservaciones txtObservaciones1;
        private Controles.labels.lblEtiqueta lbFecha;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.textBoxes.txtObservaciones txtDetalle;
        private Controles.labels.lblEtiqueta lbDetalle;
    }
}
