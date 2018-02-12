namespace GesServicios.controles.forms
{
    partial class frmTiposConexionesCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposConexionesCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.txtDescripcion = new Controles.textBoxes.txtDescripcion();
            this.txtDescripcionCorta = new Controles.textBoxes.txtDescripcion();
            this.gesTextBoxCodigo = new Controles.textBoxes.gesTextBox();
            this.chkEstado = new Controles.datos.chkBox();
            this.lblServicios = new Controles.labels.lblEtiqueta();
            this.cmbSRVCodigo = new Controles.datos.cmbLista();
            this.lblFechaCarga = new Controles.labels.lblEtiqueta();
            this.lblDescripcionCorta = new Controles.labels.lblTitulo();
            this.lblDescripcion = new Controles.labels.lblEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(12, 259);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(258, 89);
            this.gesGroup2.TabIndex = 6;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(12, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(156, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.txtDescripcionCorta);
            this.gbDatos.Controls.Add(this.gesTextBoxCodigo);
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.lblServicios);
            this.gbDatos.Controls.Add(this.cmbSRVCodigo);
            this.gbDatos.Controls.Add(this.lblFechaCarga);
            this.gbDatos.Controls.Add(this.lblDescripcionCorta);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(258, 241);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(6, 82);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDescripcion.Size = new System.Drawing.Size(150, 20);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextoVacio = "<Descripcion>";
            this.txtDescripcion.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCorta.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcionCorta.Location = new System.Drawing.Point(6, 122);
            this.txtDescripcionCorta.MaxLength = 50;
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDescripcionCorta.Size = new System.Drawing.Size(224, 20);
            this.txtDescripcionCorta.TabIndex = 3;
            this.txtDescripcionCorta.TextoVacio = "<Descripcion>";
            this.txtDescripcionCorta.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // gesTextBoxCodigo
            // 
            this.gesTextBoxCodigo.BackColor = System.Drawing.Color.White;
            this.gesTextBoxCodigo.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxCodigo.Location = new System.Drawing.Point(6, 41);
            this.gesTextBoxCodigo.Name = "gesTextBoxCodigo";
            this.gesTextBoxCodigo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.gesTextBoxCodigo.TabIndex = 1;
            this.gesTextBoxCodigo.TextoVacio = "<Descripcion>";
            this.gesTextBoxCodigo.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(6, 204);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 39;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(3, 145);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(48, 13);
            this.lblServicios.TabIndex = 35;
            this.lblServicios.Text = "Servicio:";
            // 
            // cmbSRVCodigo
            // 
            this.cmbSRVCodigo.FormattingEnabled = true;
            this.cmbSRVCodigo.Items.AddRange(new object[] {
            "Energia Electrica",
            "Agua"});
            this.cmbSRVCodigo.Location = new System.Drawing.Point(6, 161);
            this.cmbSRVCodigo.Name = "cmbSRVCodigo";
            this.cmbSRVCodigo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbSRVCodigo.Size = new System.Drawing.Size(224, 21);
            this.cmbSRVCodigo.TabIndex = 4;
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Location = new System.Drawing.Point(3, 25);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(43, 13);
            this.lblFechaCarga.TabIndex = 32;
            this.lblFechaCarga.Text = "Código:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(3, 66);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(94, 13);
            this.lblDescripcionCorta.TabIndex = 31;
            this.lblDescripcionCorta.Text = "Descripcion Corta:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 105);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // frmTiposConexionesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 366);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmTiposConexionesCrud";
            this.Text = "Tiposs de Conexiones";
            this.Load += new System.EventHandler(this.frmTiposConexionesCrud_Load);
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
        private Controles.datos.chkBox chkEstado;
        private Controles.labels.lblEtiqueta lblServicios;
        private Controles.datos.cmbLista cmbSRVCodigo;
        private Controles.labels.lblEtiqueta lblFechaCarga;
        private Controles.labels.lblTitulo lblDescripcionCorta;
        private Controles.labels.lblEtiqueta lblDescripcion;
        private Controles.textBoxes.txtDescripcion txtDescripcion;
        private Controles.textBoxes.txtDescripcion txtDescripcionCorta;
        private Controles.textBoxes.gesTextBox gesTextBoxCodigo;
    }
}