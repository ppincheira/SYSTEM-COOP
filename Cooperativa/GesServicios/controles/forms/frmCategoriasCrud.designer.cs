namespace GesServicios.controles.forms
{
    partial class frmCategoriasCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriasCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.cmbGrupo = new Controles.datos.cmbLista();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.chkHabilitado = new Controles.datos.chkBox();
            this.cmbServicio = new Controles.datos.cmbLista();
            this.lblParcela = new Controles.labels.lblEtiqueta();
            this.lblDescripcionCorta = new Controles.labels.lblEtiqueta();
            this.txtDescripcionCorta = new Controles.textBoxes.txtDescripcionCorta();
            this.txtDescripcion = new Controles.textBoxes.txtDescripcion();
            this.lbDescripcion = new Controles.labels.lblEtiqueta();
            this.tttEtiqueta = new Controles.objects.tttEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(10, 220);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(451, 89);
            this.gesGroup2.TabIndex = 5;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(234, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(329, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblEtiqueta2);
            this.gbDatos.Controls.Add(this.cmbGrupo);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.chkHabilitado);
            this.gbDatos.Controls.Add(this.cmbServicio);
            this.gbDatos.Controls.Add(this.lblParcela);
            this.gbDatos.Controls.Add(this.lblDescripcionCorta);
            this.gbDatos.Controls.Add(this.txtDescripcionCorta);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(10, 15);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(451, 185);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(52, 152);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta2.TabIndex = 37;
            this.lblEtiqueta2.Text = "Estado:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(149, 116);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbGrupo.Size = new System.Drawing.Size(260, 21);
            this.cmbGrupo.TabIndex = 4;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(52, 124);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(78, 13);
            this.lblEtiqueta1.TabIndex = 35;
            this.lblEtiqueta1.Text = "Tipo de Grupo:";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(149, 148);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 5;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // cmbServicio
            // 
            this.cmbServicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbServicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(149, 82);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbServicio.Size = new System.Drawing.Size(260, 21);
            this.cmbServicio.TabIndex = 3;
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(52, 90);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(48, 13);
            this.lblParcela.TabIndex = 22;
            this.lblParcela.Text = "Servicio:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(52, 58);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(94, 13);
            this.lblDescripcionCorta.TabIndex = 21;
            this.lblDescripcionCorta.Text = "Descripción Corta:";
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCorta.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcionCorta.Location = new System.Drawing.Point(149, 51);
            this.txtDescripcionCorta.MaxLength = 10;
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
            this.txtDescripcion.Location = new System.Drawing.Point(149, 17);
            this.txtDescripcion.MaxLength = 50;
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
            this.lbDescripcion.Location = new System.Drawing.Point(52, 25);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 0;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // frmCategoriasCrud
            // 
            this.ClientSize = new System.Drawing.Size(471, 335);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmCategoriasCrud";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoriasCrud_Load);
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
        private Controles.labels.lblEtiqueta lblParcela;
        private Controles.labels.lblEtiqueta lblDescripcionCorta;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta;
        private Controles.textBoxes.txtDescripcion txtDescripcion;
        private Controles.labels.lblEtiqueta lbDescripcion;
        private Controles.datos.chkBox chkHabilitado;
        private Controles.objects.tttEtiqueta tttEtiqueta;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.datos.cmbLista cmbGrupo;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.datos.cmbLista cmbServicio;
    }
}
