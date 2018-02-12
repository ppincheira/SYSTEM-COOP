namespace GesSeguridad.controles.forms
{
    partial class frmPersonasCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonasCrud));
            this.tttEtiqueta = new Controles.objects.tttEtiqueta();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.lblEtiqueta15 = new Controles.labels.lblEtiqueta();
            this.btnLocalidad = new Controles.buttons.btnGeneral();
            this.txtLocalidad = new Controles.textBoxes.txtDescripcion();
            this.lblEtiqueta14 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta13 = new Controles.labels.lblEtiqueta();
            this.txtLegajo = new Controles.NumericTextBox();
            this.lblEtiqueta12 = new Controles.labels.lblEtiqueta();
            this.cmbCargo = new Controles.datos.cmbLista();
            this.lblEtiqueta11 = new Controles.labels.lblEtiqueta();
            this.txtCuil = new Controles.textBoxes.txtCuit();
            this.lblEtiqueta10 = new Controles.labels.lblEtiqueta();
            this.cmbMotivoBaja = new Controles.datos.cmbLista();
            this.dtpFechaBaja = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta9 = new Controles.labels.lblEtiqueta();
            this.dtpFechaIngreso = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta8 = new Controles.labels.lblEtiqueta();
            this.dtpFechaNacimiento = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta7 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta6 = new Controles.labels.lblEtiqueta();
            this.cmbSexo = new Controles.datos.cmbLista();
            this.lblEtiqueta5 = new Controles.labels.lblEtiqueta();
            this.txtNroDocumento = new Controles.textBoxes.txtDescripcionCorta();
            this.lblEtiqueta4 = new Controles.labels.lblEtiqueta();
            this.cmbTipo = new Controles.datos.cmbLista();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.cmbEstadoCivil = new Controles.datos.cmbLista();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.txtNombre = new Controles.textBoxes.txtDescripcion();
            this.txtApellido = new Controles.textBoxes.txtDescripcion();
            this.chkHabilitado = new Controles.datos.chkBox();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnVerUsuario = new Controles.buttons.btnVer();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblEtiqueta15);
            this.gbDatos.Controls.Add(this.btnLocalidad);
            this.gbDatos.Controls.Add(this.txtLocalidad);
            this.gbDatos.Controls.Add(this.lblEtiqueta14);
            this.gbDatos.Controls.Add(this.lblEtiqueta13);
            this.gbDatos.Controls.Add(this.txtLegajo);
            this.gbDatos.Controls.Add(this.lblEtiqueta12);
            this.gbDatos.Controls.Add(this.cmbCargo);
            this.gbDatos.Controls.Add(this.lblEtiqueta11);
            this.gbDatos.Controls.Add(this.txtCuil);
            this.gbDatos.Controls.Add(this.lblEtiqueta10);
            this.gbDatos.Controls.Add(this.cmbMotivoBaja);
            this.gbDatos.Controls.Add(this.dtpFechaBaja);
            this.gbDatos.Controls.Add(this.lblEtiqueta9);
            this.gbDatos.Controls.Add(this.dtpFechaIngreso);
            this.gbDatos.Controls.Add(this.lblEtiqueta8);
            this.gbDatos.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatos.Controls.Add(this.lblEtiqueta7);
            this.gbDatos.Controls.Add(this.lblEtiqueta6);
            this.gbDatos.Controls.Add(this.cmbSexo);
            this.gbDatos.Controls.Add(this.lblEtiqueta5);
            this.gbDatos.Controls.Add(this.txtNroDocumento);
            this.gbDatos.Controls.Add(this.lblEtiqueta4);
            this.gbDatos.Controls.Add(this.cmbTipo);
            this.gbDatos.Controls.Add(this.lblEtiqueta3);
            this.gbDatos.Controls.Add(this.cmbEstadoCivil);
            this.gbDatos.Controls.Add(this.lblEtiqueta2);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.chkHabilitado);
            this.gbDatos.Location = new System.Drawing.Point(12, 13);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(603, 288);
            this.gbDatos.TabIndex = 10;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblEtiqueta15
            // 
            this.lblEtiqueta15.AutoSize = true;
            this.lblEtiqueta15.Location = new System.Drawing.Point(299, 258);
            this.lblEtiqueta15.Name = "lblEtiqueta15";
            this.lblEtiqueta15.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta15.TabIndex = 42;
            this.lblEtiqueta15.Text = "Estado:";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.Location = new System.Drawing.Point(557, 123);
            this.btnLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(21, 19);
            this.btnLocalidad.TabIndex = 41;
            this.btnLocalidad.Text = "...";
            this.btnLocalidad.UseVisualStyleBackColor = true;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.Color.White;
            this.txtLocalidad.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtLocalidad.Location = new System.Drawing.Point(405, 123);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidad.MaxLength = 50;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtLocalidad.Size = new System.Drawing.Size(147, 20);
            this.txtLocalidad.TabIndex = 8;
            this.txtLocalidad.TextoVacio = "<Descripcion>";
            this.txtLocalidad.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblEtiqueta14
            // 
            this.lblEtiqueta14.AutoSize = true;
            this.lblEtiqueta14.Location = new System.Drawing.Point(299, 126);
            this.lblEtiqueta14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtiqueta14.Name = "lblEtiqueta14";
            this.lblEtiqueta14.Size = new System.Drawing.Size(56, 13);
            this.lblEtiqueta14.TabIndex = 39;
            this.lblEtiqueta14.Text = "Localidad:";
            // 
            // lblEtiqueta13
            // 
            this.lblEtiqueta13.AutoSize = true;
            this.lblEtiqueta13.Location = new System.Drawing.Point(4, 192);
            this.lblEtiqueta13.Name = "lblEtiqueta13";
            this.lblEtiqueta13.Size = new System.Drawing.Size(42, 13);
            this.lblEtiqueta13.TabIndex = 38;
            this.lblEtiqueta13.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.AllowSpace = false;
            this.txtLegajo.Location = new System.Drawing.Point(121, 189);
            this.txtLegajo.MaxLength = 8;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(151, 20);
            this.txtLegajo.TabIndex = 11;
            // 
            // lblEtiqueta12
            // 
            this.lblEtiqueta12.AutoSize = true;
            this.lblEtiqueta12.Location = new System.Drawing.Point(299, 192);
            this.lblEtiqueta12.Name = "lblEtiqueta12";
            this.lblEtiqueta12.Size = new System.Drawing.Size(38, 13);
            this.lblEtiqueta12.TabIndex = 36;
            this.lblEtiqueta12.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(405, 189);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbCargo.Size = new System.Drawing.Size(173, 21);
            this.cmbCargo.TabIndex = 12;
            // 
            // lblEtiqueta11
            // 
            this.lblEtiqueta11.AutoSize = true;
            this.lblEtiqueta11.Location = new System.Drawing.Point(299, 159);
            this.lblEtiqueta11.Name = "lblEtiqueta11";
            this.lblEtiqueta11.Size = new System.Drawing.Size(27, 13);
            this.lblEtiqueta11.TabIndex = 34;
            this.lblEtiqueta11.Text = "Cuil:";
            // 
            // txtCuil
            // 
            this.txtCuil.BackColor = System.Drawing.Color.White;
            this.txtCuil.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtCuil.Location = new System.Drawing.Point(405, 156);
            this.txtCuil.MaxLength = 15;
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtCuil.Size = new System.Drawing.Size(173, 20);
            this.txtCuil.TabIndex = 10;
            this.txtCuil.TextoVacio = "<Descripcion>";
            this.txtCuil.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblEtiqueta10
            // 
            this.lblEtiqueta10.AutoSize = true;
            this.lblEtiqueta10.Location = new System.Drawing.Point(299, 225);
            this.lblEtiqueta10.Name = "lblEtiqueta10";
            this.lblEtiqueta10.Size = new System.Drawing.Size(66, 13);
            this.lblEtiqueta10.TabIndex = 32;
            this.lblEtiqueta10.Text = "Motivo Baja:";
            // 
            // cmbMotivoBaja
            // 
            this.cmbMotivoBaja.FormattingEnabled = true;
            this.cmbMotivoBaja.Location = new System.Drawing.Point(405, 222);
            this.cmbMotivoBaja.Name = "cmbMotivoBaja";
            this.cmbMotivoBaja.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbMotivoBaja.Size = new System.Drawing.Size(173, 21);
            this.cmbMotivoBaja.TabIndex = 14;
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaBaja.Location = new System.Drawing.Point(120, 222);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaBaja.Size = new System.Drawing.Size(152, 20);
            this.dtpFechaBaja.TabIndex = 13;
            // 
            // lblEtiqueta9
            // 
            this.lblEtiqueta9.AutoSize = true;
            this.lblEtiqueta9.Location = new System.Drawing.Point(4, 225);
            this.lblEtiqueta9.Name = "lblEtiqueta9";
            this.lblEtiqueta9.Size = new System.Drawing.Size(79, 13);
            this.lblEtiqueta9.TabIndex = 30;
            this.lblEtiqueta9.Text = "Fecha de Baja:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(121, 156);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaIngreso.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaIngreso.TabIndex = 9;
            // 
            // lblEtiqueta8
            // 
            this.lblEtiqueta8.AutoSize = true;
            this.lblEtiqueta8.Location = new System.Drawing.Point(4, 159);
            this.lblEtiqueta8.Name = "lblEtiqueta8";
            this.lblEtiqueta8.Size = new System.Drawing.Size(93, 13);
            this.lblEtiqueta8.TabIndex = 28;
            this.lblEtiqueta8.Text = "Fecha de Ingreso:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(120, 123);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblEtiqueta7
            // 
            this.lblEtiqueta7.AutoSize = true;
            this.lblEtiqueta7.Location = new System.Drawing.Point(4, 126);
            this.lblEtiqueta7.Name = "lblEtiqueta7";
            this.lblEtiqueta7.Size = new System.Drawing.Size(111, 13);
            this.lblEtiqueta7.TabIndex = 26;
            this.lblEtiqueta7.Text = "Fecha de Nacimiento:";
            // 
            // lblEtiqueta6
            // 
            this.lblEtiqueta6.AutoSize = true;
            this.lblEtiqueta6.Location = new System.Drawing.Point(299, 60);
            this.lblEtiqueta6.Name = "lblEtiqueta6";
            this.lblEtiqueta6.Size = new System.Drawing.Size(34, 13);
            this.lblEtiqueta6.TabIndex = 21;
            this.lblEtiqueta6.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(405, 55);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbSexo.Size = new System.Drawing.Size(173, 21);
            this.cmbSexo.TabIndex = 4;
            // 
            // lblEtiqueta5
            // 
            this.lblEtiqueta5.AutoSize = true;
            this.lblEtiqueta5.Location = new System.Drawing.Point(299, 93);
            this.lblEtiqueta5.Name = "lblEtiqueta5";
            this.lblEtiqueta5.Size = new System.Drawing.Size(85, 13);
            this.lblEtiqueta5.TabIndex = 19;
            this.lblEtiqueta5.Text = "Nro.Documento:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNroDocumento.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNroDocumento.Location = new System.Drawing.Point(405, 89);
            this.txtNroDocumento.MaxLength = 20;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtNroDocumento.Size = new System.Drawing.Size(173, 20);
            this.txtNroDocumento.TabIndex = 6;
            this.txtNroDocumento.TextoVacio = "<Descripcion>";
            this.txtNroDocumento.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblEtiqueta4
            // 
            this.lblEtiqueta4.AutoSize = true;
            this.lblEtiqueta4.Location = new System.Drawing.Point(4, 93);
            this.lblEtiqueta4.Name = "lblEtiqueta4";
            this.lblEtiqueta4.Size = new System.Drawing.Size(31, 13);
            this.lblEtiqueta4.TabIndex = 17;
            this.lblEtiqueta4.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(121, 89);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbTipo.Size = new System.Drawing.Size(150, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(4, 60);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new System.Drawing.Size(65, 13);
            this.lblEtiqueta3.TabIndex = 15;
            this.lblEtiqueta3.Text = "Estado Civil:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(121, 55);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbEstadoCivil.Size = new System.Drawing.Size(150, 21);
            this.cmbEstadoCivil.TabIndex = 3;
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(299, 27);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(47, 13);
            this.lblEtiqueta2.TabIndex = 13;
            this.lblEtiqueta2.Text = "Nombre:";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(4, 27);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(47, 13);
            this.lblEtiqueta1.TabIndex = 12;
            this.lblEtiqueta1.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(405, 22);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextoVacio = "<Descripcion>";
            this.txtNombre.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtApellido.Location = new System.Drawing.Point(121, 22);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtApellido.Size = new System.Drawing.Size(150, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextoVacio = "<Descripcion>";
            this.txtApellido.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(405, 258);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 15;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnVerUsuario);
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(15, 310);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(600, 89);
            this.gesGroup2.TabIndex = 11;
            this.gesGroup2.TabStop = false;
            // 
            // btnVerUsuario
            // 
            this.btnVerUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerUsuario.BackgroundImage")));
            this.btnVerUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerUsuario.Enabled = false;
            this.btnVerUsuario.Location = new System.Drawing.Point(23, 19);
            this.btnVerUsuario.Name = "btnVerUsuario";
            this.btnVerUsuario.Size = new System.Drawing.Size(80, 60);
            this.btnVerUsuario.TabIndex = 16;
            this.btnVerUsuario.Text = "Usuario";
            this.btnVerUsuario.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(400, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(495, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmPersonasCrud
            // 
            this.ClientSize = new System.Drawing.Size(626, 415);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmPersonasCrud";
            this.Text = "Personas";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.objects.tttEtiqueta tttEtiqueta;
        private Controles.contenedores.gesGroup gbDatos;
        private Controles.labels.lblEtiqueta lblEtiqueta6;
        private Controles.datos.cmbLista cmbSexo;
        private Controles.labels.lblEtiqueta lblEtiqueta5;
        private Controles.textBoxes.txtDescripcionCorta txtNroDocumento;
        private Controles.labels.lblEtiqueta lblEtiqueta4;
        private Controles.datos.cmbLista cmbTipo;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
        private Controles.datos.cmbLista cmbEstadoCivil;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.textBoxes.txtDescripcion txtNombre;
        private Controles.textBoxes.txtDescripcion txtApellido;
        private Controles.datos.chkBox chkHabilitado;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.Fecha.dtpFecha dtpFechaNacimiento;
        private Controles.labels.lblEtiqueta lblEtiqueta7;
        private Controles.Fecha.dtpFecha dtpFechaIngreso;
        private Controles.labels.lblEtiqueta lblEtiqueta8;
        private Controles.Fecha.dtpFecha dtpFechaBaja;
        private Controles.labels.lblEtiqueta lblEtiqueta9;
        private Controles.labels.lblEtiqueta lblEtiqueta10;
        private Controles.datos.cmbLista cmbMotivoBaja;
        private Controles.labels.lblEtiqueta lblEtiqueta12;
        private Controles.datos.cmbLista cmbCargo;
        private Controles.labels.lblEtiqueta lblEtiqueta11;
        private Controles.textBoxes.txtCuit txtCuil;
        private Controles.NumericTextBox txtLegajo;
        private Controles.labels.lblEtiqueta lblEtiqueta13;
        private Controles.buttons.btnGeneral btnLocalidad;
        private Controles.textBoxes.txtDescripcion txtLocalidad;
        private Controles.labels.lblEtiqueta lblEtiqueta14;
        private Controles.labels.lblEtiqueta lblEtiqueta15;
        private Controles.buttons.btnVer btnVerUsuario;
    }
}
