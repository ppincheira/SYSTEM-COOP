namespace FormsAuxiliares
{
    partial class frmCodigoPostalCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodigoPostalCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.txtCodigoPostal = new Controles.textBoxes.txtDescripcionCorta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.cmbLocalidad = new Controles.datos.cmbLista();
            this.txtDescripcion = new Controles.textBoxes.txtDescripcionCorta();
            this.lbDescripcion = new Controles.labels.lblEtiqueta();
            this.lbLocalidad = new Controles.labels.lblEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(13, 181);
            this.gesGroup2.Margin = new System.Windows.Forms.Padding(4);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Padding = new System.Windows.Forms.Padding(4);
            this.gesGroup2.Size = new System.Drawing.Size(672, 110);
            this.gesGroup2.TabIndex = 7;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(412, 17);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 74);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtCodigoPostal);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.cmbLocalidad);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Controls.Add(this.lbLocalidad);
            this.gbDatos.Location = new System.Drawing.Point(13, 13);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatos.Size = new System.Drawing.Size(672, 161);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostal.Location = new System.Drawing.Point(148, 31);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.MaxLength = 8;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(135, 22);
            this.txtCodigoPostal.TabIndex = 1;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(39, 31);
            this.lblEtiqueta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(99, 17);
            this.lblEtiqueta1.TabIndex = 6;
            this.lblEtiqueta1.Text = "Codigo Postal:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(148, 112);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(311, 24);
            this.cmbLocalidad.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(148, 72);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.MaxLength = 25;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(311, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(52, 72);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(65, 122);
            this.lbLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(73, 17);
            this.lbLocalidad.TabIndex = 0;
            this.lbLocalidad.Text = "Localidad:";
            // 
            // frmCodigoPostalCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 300);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmCodigoPostalCrud";
            this.Text = "frmCodigoPostalCrud";
            this.Load += new System.EventHandler(this.frmCodigoPostalCrud_Load);
            this.gesGroup2.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        public Controles.contenedores.gesGroup gbDatos;
        private Controles.datos.cmbLista cmbLocalidad;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcion;
        private Controles.labels.lblEtiqueta lbDescripcion;
        private Controles.labels.lblEtiqueta lbLocalidad;
        private Controles.textBoxes.txtDescripcionCorta txtCodigoPostal;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
    }
}