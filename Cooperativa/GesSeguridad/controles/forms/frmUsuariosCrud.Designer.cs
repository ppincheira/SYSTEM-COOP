namespace GesSeguridad.controles.forms
{
    partial class frmUsuariosCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.dtpFechaBaja = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta9 = new Controles.labels.lblEtiqueta();
            this.dtpFechaAlta = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta8 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.txtClave = new Controles.textBoxes.txtDescripcion();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.chkBloqueado = new Controles.datos.chkBox();
            this.cmbPerfil = new Controles.datos.cmbLista();
            this.lblParcela = new Controles.labels.lblEtiqueta();
            this.txtNombre = new Controles.textBoxes.txtDescripcion();
            this.lbDescripcion = new Controles.labels.lblEtiqueta();
            this.tttEtiqueta = new Controles.objects.tttEtiqueta();
            this.cmbPersona = new Controles.datos.cmbLista();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.chkEstado = new Controles.datos.chkBox();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(13, 270);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(451, 89);
            this.gesGroup2.TabIndex = 7;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(234, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(329, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.cmbPersona);
            this.gbDatos.Controls.Add(this.lblEtiqueta3);
            this.gbDatos.Controls.Add(this.dtpFechaBaja);
            this.gbDatos.Controls.Add(this.lblEtiqueta9);
            this.gbDatos.Controls.Add(this.dtpFechaAlta);
            this.gbDatos.Controls.Add(this.lblEtiqueta8);
            this.gbDatos.Controls.Add(this.lblEtiqueta2);
            this.gbDatos.Controls.Add(this.txtClave);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.chkBloqueado);
            this.gbDatos.Controls.Add(this.cmbPerfil);
            this.gbDatos.Controls.Add(this.lblParcela);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(13, 17);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(451, 247);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaBaja.Location = new System.Drawing.Point(186, 187);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaBaja.Size = new System.Drawing.Size(166, 20);
            this.dtpFechaBaja.TabIndex = 6;
            // 
            // lblEtiqueta9
            // 
            this.lblEtiqueta9.AutoSize = true;
            this.lblEtiqueta9.Location = new System.Drawing.Point(69, 191);
            this.lblEtiqueta9.Name = "lblEtiqueta9";
            this.lblEtiqueta9.Size = new System.Drawing.Size(79, 13);
            this.lblEtiqueta9.TabIndex = 34;
            this.lblEtiqueta9.Text = "Fecha de Baja:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(186, 154);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.dtpFechaAlta.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaAlta.TabIndex = 5;
            // 
            // lblEtiqueta8
            // 
            this.lblEtiqueta8.AutoSize = true;
            this.lblEtiqueta8.Location = new System.Drawing.Point(69, 158);
            this.lblEtiqueta8.Name = "lblEtiqueta8";
            this.lblEtiqueta8.Size = new System.Drawing.Size(76, 13);
            this.lblEtiqueta8.TabIndex = 33;
            this.lblEtiqueta8.Text = "Fecha de Alta:";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(69, 218);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta2.TabIndex = 25;
            this.lblEtiqueta2.Text = "Estado:";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtClave.Location = new System.Drawing.Point(186, 87);
            this.txtClave.MaxLength = 30;
            this.txtClave.Name = "txtClave";
            this.txtClave.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtClave.Size = new System.Drawing.Size(165, 20);
            this.txtClave.TabIndex = 3;
            this.txtClave.TextoVacio = "<Descripcion>";
            this.txtClave.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(69, 91);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(37, 13);
            this.lblEtiqueta1.TabIndex = 23;
            this.lblEtiqueta1.Text = "Clave:";
            // 
            // chkBloqueado
            // 
            this.chkBloqueado.AutoSize = true;
            this.chkBloqueado.Location = new System.Drawing.Point(186, 217);
            this.chkBloqueado.Name = "chkBloqueado";
            this.chkBloqueado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkBloqueado.Size = new System.Drawing.Size(77, 17);
            this.chkBloqueado.TabIndex = 7;
            this.chkBloqueado.Text = "Bloqueado";
            this.chkBloqueado.UseVisualStyleBackColor = true;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPerfil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(186, 120);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbPerfil.Size = new System.Drawing.Size(165, 21);
            this.cmbPerfil.TabIndex = 4;
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(69, 125);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(33, 13);
            this.lblParcela.TabIndex = 22;
            this.lblParcela.Text = "Perfil:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(186, 54);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextoVacio = "<Descripcion>";
            this.txtNombre.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(69, 58);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(47, 13);
            this.lbDescripcion.TabIndex = 0;
            this.lbDescripcion.Text = "Nombre:";
            // 
            // cmbPersona
            // 
            this.cmbPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(187, 19);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbPersona.Size = new System.Drawing.Size(222, 21);
            this.cmbPersona.TabIndex = 1;
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(70, 24);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new System.Drawing.Size(49, 13);
            this.lblEtiqueta3.TabIndex = 36;
            this.lblEtiqueta3.Text = "Persona:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(275, 218);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 8;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // frmUsuariosCrud
            // 
            this.ClientSize = new System.Drawing.Size(479, 384);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmUsuariosCrud";
            this.Text = "Usuarios";
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
        private Controles.datos.chkBox chkBloqueado;
        private Controles.datos.cmbLista cmbPerfil;
        private Controles.labels.lblEtiqueta lblParcela;
        private Controles.textBoxes.txtDescripcion txtNombre;
        private Controles.labels.lblEtiqueta lbDescripcion;
        private Controles.textBoxes.txtDescripcion txtClave;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.Fecha.dtpFecha dtpFechaBaja;
        private Controles.labels.lblEtiqueta lblEtiqueta9;
        private Controles.Fecha.dtpFecha dtpFechaAlta;
        private Controles.labels.lblEtiqueta lblEtiqueta8;
        private Controles.objects.tttEtiqueta tttEtiqueta;
        private Controles.datos.chkBox chkEstado;
        private Controles.datos.cmbLista cmbPersona;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
    }
}
