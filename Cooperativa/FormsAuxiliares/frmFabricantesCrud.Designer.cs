namespace GesServicios.controles.forms
{
    partial class frmFabricantesCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFabricantesCrud));
            this.lbCalle = new Controles.labels.lblEtiqueta();
            this.lbLocalidad = new Controles.labels.lblEtiqueta();
            this.cmbEMPNumero = new Controles.datos.cmbLista();
            this.lblBloque = new Controles.labels.lblEtiqueta();
            this.txtDescripcion = new Controles.textBoxes.txtDescripcionCorta();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.chkHabilitado = new Controles.datos.chkBox();
            this.dtpFechaCarga = new Controles.Fecha.dtpFecha();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(9, 167);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(86, 13);
            this.lbCalle.TabIndex = 0;
            this.lbCalle.Text = "Fecha de Carga:";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(6, 16);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(66, 13);
            this.lbLocalidad.TabIndex = 3;
            this.lbLocalidad.Text = "Descripcion:";
            // 
            // cmbEMPNumero
            // 
            this.cmbEMPNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbEMPNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEMPNumero.FormattingEnabled = true;
            this.cmbEMPNumero.Location = new System.Drawing.Point(101, 71);
            this.cmbEMPNumero.Name = "cmbEMPNumero";
            this.cmbEMPNumero.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbEMPNumero.Size = new System.Drawing.Size(200, 21);
            this.cmbEMPNumero.TabIndex = 2;
            this.cmbEMPNumero.Visible = false;
            // 
            // lblBloque
            // 
            this.lblBloque.AutoSize = true;
            this.lblBloque.Location = new System.Drawing.Point(9, 79);
            this.lblBloque.Name = "lblBloque";
            this.lblBloque.Size = new System.Drawing.Size(51, 13);
            this.lblBloque.TabIndex = 17;
            this.lblBloque.Text = "Empresa:";
            this.lblBloque.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(101, 13);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDescripcion.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextoVacio = "<Descripcion>";
            this.txtDescripcion.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.chkHabilitado);
            this.gbDatos.Controls.Add(this.dtpFechaCarga);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lblBloque);
            this.gbDatos.Controls.Add(this.cmbEMPNumero);
            this.gbDatos.Controls.Add(this.lbLocalidad);
            this.gbDatos.Controls.Add(this.lbCalle);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(319, 263);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(6, 240);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta1.TabIndex = 25;
            this.lblEtiqueta1.Text = "Estado:";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Checked = true;
            this.chkHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitado.Location = new System.Drawing.Point(101, 240);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 4;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Location = new System.Drawing.Point(101, 161);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaCarga.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCarga.TabIndex = 3;
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(12, 281);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(319, 94);
            this.gesGroup2.TabIndex = 0;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(150, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 71);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(236, 17);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 71);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // frmFabricantesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 377);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmFabricantesCrud";
            this.Text = "Fabricantes";
            this.Load += new System.EventHandler(this.frmFabricantesCrud_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.labels.lblEtiqueta lbCalle;
        private Controles.labels.lblEtiqueta lbLocalidad;
        private Controles.datos.cmbLista cmbEMPNumero;
        private Controles.labels.lblEtiqueta lblBloque;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcion;
        public Controles.contenedores.gesGroup gbDatos;
        private Controles.datos.chkBox chkHabilitado;
        private Controles.Fecha.dtpFecha dtpFechaCarga;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
    }
}