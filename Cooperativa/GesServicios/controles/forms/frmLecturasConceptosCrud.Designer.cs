namespace GesServicios.controles.forms
{
    partial class frmLecturasConceptosCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLecturasConceptosCrud));
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.chkEstado = new Controles.datos.chkBox();
            this.txtLCDescripcionCorta = new Controles.textBoxes.txtDescripcionCorta();
            this.lblFechaCarga = new Controles.labels.lblEtiqueta();
            this.lblDescripcionCorta = new Controles.labels.lblTitulo();
            this.dtpFechaCarga = new Controles.Fecha.dtpFecha();
            this.txtLCDescripcion = new Controles.textBoxes.txtDescripcion();
            this.lblDescripcion = new Controles.labels.lblEtiqueta();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.gbDatos.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.txtLCDescripcionCorta);
            this.gbDatos.Controls.Add(this.lblFechaCarga);
            this.gbDatos.Controls.Add(this.lblDescripcionCorta);
            this.gbDatos.Controls.Add(this.dtpFechaCarga);
            this.gbDatos.Controls.Add(this.txtLCDescripcion);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(345, 173);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(109, 146);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 39;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtLCDescripcionCorta
            // 
            this.txtLCDescripcionCorta.BackColor = System.Drawing.Color.White;
            this.txtLCDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLCDescripcionCorta.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtLCDescripcionCorta.Location = new System.Drawing.Point(109, 15);
            this.txtLCDescripcionCorta.MaxLength = 10;
            this.txtLCDescripcionCorta.Name = "txtLCDescripcionCorta";
            this.txtLCDescripcionCorta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtLCDescripcionCorta.Size = new System.Drawing.Size(224, 20);
            this.txtLCDescripcionCorta.TabIndex = 1;
            this.txtLCDescripcionCorta.TextoVacio = "<Descripcion>";
            this.txtLCDescripcionCorta.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Location = new System.Drawing.Point(9, 107);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(76, 13);
            this.lblFechaCarga.TabIndex = 32;
            this.lblFechaCarga.Text = "Fecha de Alta:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(9, 22);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(94, 13);
            this.lblDescripcionCorta.TabIndex = 31;
            this.lblDescripcionCorta.Text = "Descripcion Corta:";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCarga.Location = new System.Drawing.Point(109, 100);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaCarga.Size = new System.Drawing.Size(224, 20);
            this.dtpFechaCarga.TabIndex = 30;
            // 
            // txtLCDescripcion
            // 
            this.txtLCDescripcion.BackColor = System.Drawing.Color.White;
            this.txtLCDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLCDescripcion.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtLCDescripcion.Location = new System.Drawing.Point(109, 53);
            this.txtLCDescripcion.MaxLength = 30;
            this.txtLCDescripcion.Multiline = true;
            this.txtLCDescripcion.Name = "txtLCDescripcion";
            this.txtLCDescripcion.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtLCDescripcion.Size = new System.Drawing.Size(224, 21);
            this.txtLCDescripcion.TabIndex = 2;
            this.txtLCDescripcion.TextoVacio = "<Descripcion>";
            this.txtLCDescripcion.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 61);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(179, 191);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(178, 89);
            this.gesGroup2.TabIndex = 5;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(6, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(92, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(9, 146);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta1.TabIndex = 40;
            this.lblEtiqueta1.Text = "Estado:";
            // 
            // frmLecturasConceptosCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 288);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmLecturasConceptosCrud";
            this.Text = "Lecturas Conceptos";
            this.Load += new System.EventHandler(this.frmLecturasConceptosCrud_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Controles.contenedores.gesGroup gbDatos;
        private Controles.datos.chkBox chkEstado;
        private Controles.textBoxes.txtDescripcionCorta txtLCDescripcionCorta;
        private Controles.labels.lblEtiqueta lblFechaCarga;
        private Controles.labels.lblTitulo lblDescripcionCorta;
        private Controles.Fecha.dtpFecha dtpFechaCarga;
        private Controles.textBoxes.txtDescripcion txtLCDescripcion;
        private Controles.labels.lblEtiqueta lblDescripcion;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
    }
}