namespace GesServicios.controles.forms
{
    partial class frmRutasCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRutasCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.cmbGrupo = new Controles.datos.cmbLista();
            this.lblTipoGrupo = new Controles.labels.lblEtiqueta();
            this.chkEstado = new Controles.datos.chkBox();
            this.cmbServicio = new Controles.datos.cmbLista();
            this.lblEstado = new Controles.labels.lblEtiqueta();
            this.lblParcela = new Controles.labels.lblEtiqueta();
            this.lblDescripcionCorta = new Controles.labels.lblEtiqueta();
            this.txtDescripcionCorta = new Controles.textBoxes.txtDescripcionCorta();
            this.txtDescripcion = new Controles.textBoxes.txtDescripcionCorta();
            this.lbDescripcion = new Controles.labels.lblEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(8, 221);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(451, 89);
            this.gesGroup2.TabIndex = 3;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(234, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(329, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbGrupo);
            this.gbDatos.Controls.Add(this.lblTipoGrupo);
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.cmbServicio);
            this.gbDatos.Controls.Add(this.lblEstado);
            this.gbDatos.Controls.Add(this.lblParcela);
            this.gbDatos.Controls.Add(this.lblDescripcionCorta);
            this.gbDatos.Controls.Add(this.txtDescripcionCorta);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(8, 3);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(451, 199);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(149, 136);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbGrupo.Size = new System.Drawing.Size(165, 21);
            this.cmbGrupo.TabIndex = 4;
            // 
            // lblTipoGrupo
            // 
            this.lblTipoGrupo.AutoSize = true;
            this.lblTipoGrupo.Location = new System.Drawing.Point(52, 144);
            this.lblTipoGrupo.Name = "lblTipoGrupo";
            this.lblTipoGrupo.Size = new System.Drawing.Size(78, 13);
            this.lblTipoGrupo.TabIndex = 24;
            this.lblTipoGrupo.Text = "Tipo de Grupo:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(149, 167);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 5;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // cmbServicio
            // 
            this.cmbServicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbServicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(149, 100);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbServicio.Size = new System.Drawing.Size(165, 21);
            this.cmbServicio.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(52, 167);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado:";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(52, 108);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(48, 13);
            this.lblParcela.TabIndex = 22;
            this.lblParcela.Text = "Servicio:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(52, 71);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(91, 13);
            this.lblDescripcionCorta.TabIndex = 21;
            this.lblDescripcionCorta.Text = "Descripción Corta";
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCorta.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcionCorta.Location = new System.Drawing.Point(149, 64);
            this.txtDescripcionCorta.MaxLength = 20;
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtDescripcionCorta.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcionCorta.TabIndex = 2;
            this.txtDescripcionCorta.TextoVacio = "<Descripcion>";
            this.txtDescripcionCorta.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(149, 29);
            this.txtDescripcion.MaxLength = 20;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextoVacio = "<Descripcion>";
            this.txtDescripcion.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(52, 37);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 0;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // frmRutasCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 335);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmRutasCrud";
            this.Text = "frmRutasCrud";
            this.Load += new System.EventHandler(this.frmRutasCrud_Load);
            this.gesGroup2.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.labels.lblEtiqueta lblParcela;
        private Controles.labels.lblEtiqueta lblDescripcionCorta;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcion;
        private Controles.labels.lblEtiqueta lbDescripcion;
        private Controles.datos.cmbLista cmbServicio;
        public Controles.contenedores.gesGroup gbDatos;
        private Controles.datos.chkBox chkEstado;
        private Controles.labels.lblEtiqueta lblEstado;
        private Controles.datos.cmbLista cmbGrupo;
        private Controles.labels.lblEtiqueta lblTipoGrupo;
    }
}