namespace GesServicios.controles.forms
{
    partial class frmMedidoresCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedidoresCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.txtEmpNumero = new Controles.textBoxes.txtDescripcion();
            this.txtEmpRazonSocial = new Controles.textBoxes.txtDescripcion();
            this.btnCliente = new Controles.buttons.btnGeneral();
            this.cmbLmeCodigo = new Controles.datos.cmbLista();
            this.lblLecturaModo = new Controles.labels.lblEtiqueta();
            this.TextBoxGisY = new Controles.textBoxes.txtDescripcion();
            this.TextBoxGisX = new Controles.textBoxes.txtDescripcion();
            this.TextBoxFactorCalib = new Controles.textBoxes.txtDescripcion();
            this.TextBoxDigitos = new Controles.textBoxes.txtDescripcion();
            this.TextBoxNumeroSerie = new Controles.textBoxes.gesTextBox();
            this.dtpFechaCarga = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.cmbMmoCodigo = new Controles.datos.cmbLista();
            this.lblGisY = new Controles.labels.lblEtiqueta();
            this.lblMmoCodigo = new Controles.labels.lblEtiqueta();
            this.lblDecimales = new Controles.labels.lblEtiqueta();
            this.lblNumeroProv = new Controles.labels.lblEtiqueta();
            this.lblGisX = new Controles.labels.lblEtiqueta();
            this.lblEstado = new Controles.labels.lblEtiqueta();
            this.lblDigitos = new Controles.labels.lblEtiqueta();
            this.lbDescripcion = new Controles.labels.lblEtiqueta();
            this.cmbEstado = new Controles.datos.cmbLista();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(159, 324);
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
            this.gbDatos.Controls.Add(this.cmbEstado);
            this.gbDatos.Controls.Add(this.txtEmpNumero);
            this.gbDatos.Controls.Add(this.txtEmpRazonSocial);
            this.gbDatos.Controls.Add(this.btnCliente);
            this.gbDatos.Controls.Add(this.cmbLmeCodigo);
            this.gbDatos.Controls.Add(this.lblLecturaModo);
            this.gbDatos.Controls.Add(this.TextBoxGisY);
            this.gbDatos.Controls.Add(this.TextBoxGisX);
            this.gbDatos.Controls.Add(this.TextBoxFactorCalib);
            this.gbDatos.Controls.Add(this.TextBoxDigitos);
            this.gbDatos.Controls.Add(this.TextBoxNumeroSerie);
            this.gbDatos.Controls.Add(this.dtpFechaCarga);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.cmbMmoCodigo);
            this.gbDatos.Controls.Add(this.lblGisY);
            this.gbDatos.Controls.Add(this.lblMmoCodigo);
            this.gbDatos.Controls.Add(this.lblDecimales);
            this.gbDatos.Controls.Add(this.lblNumeroProv);
            this.gbDatos.Controls.Add(this.lblGisX);
            this.gbDatos.Controls.Add(this.lblEstado);
            this.gbDatos.Controls.Add(this.lblDigitos);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(599, 288);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtEmpNumero
            // 
            this.txtEmpNumero.BackColor = System.Drawing.Color.White;
            this.txtEmpNumero.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtEmpNumero.Enabled = false;
            this.txtEmpNumero.Location = new System.Drawing.Point(175, 58);
            this.txtEmpNumero.MaxLength = 50;
            this.txtEmpNumero.Name = "txtEmpNumero";
            this.txtEmpNumero.ReadOnly = true;
            this.txtEmpNumero.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtEmpNumero.Size = new System.Drawing.Size(47, 20);
            this.txtEmpNumero.TabIndex = 37;
            this.txtEmpNumero.TextoVacio = "<Descripcion>";
            this.txtEmpNumero.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtEmpRazonSocial
            // 
            this.txtEmpRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtEmpRazonSocial.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtEmpRazonSocial.Enabled = false;
            this.txtEmpRazonSocial.Location = new System.Drawing.Point(228, 58);
            this.txtEmpRazonSocial.MaxLength = 50;
            this.txtEmpRazonSocial.Multiline = true;
            this.txtEmpRazonSocial.Name = "txtEmpRazonSocial";
            this.txtEmpRazonSocial.ReadOnly = true;
            this.txtEmpRazonSocial.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtEmpRazonSocial.Size = new System.Drawing.Size(344, 40);
            this.txtEmpRazonSocial.TabIndex = 36;
            this.txtEmpRazonSocial.TextoVacio = "<Descripcion>";
            this.txtEmpRazonSocial.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(127, 58);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(35, 19);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // cmbLmeCodigo
            // 
            this.cmbLmeCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLmeCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLmeCodigo.FormattingEnabled = true;
            this.cmbLmeCodigo.Location = new System.Drawing.Point(427, 173);
            this.cmbLmeCodigo.Name = "cmbLmeCodigo";
            this.cmbLmeCodigo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbLmeCodigo.Size = new System.Drawing.Size(165, 21);
            this.cmbLmeCodigo.TabIndex = 9;
            this.cmbLmeCodigo.Text = "<Seleccione Modelo>";
            // 
            // lblLecturaModo
            // 
            this.lblLecturaModo.AutoSize = true;
            this.lblLecturaModo.Location = new System.Drawing.Point(312, 176);
            this.lblLecturaModo.Name = "lblLecturaModo";
            this.lblLecturaModo.Size = new System.Drawing.Size(91, 13);
            this.lblLecturaModo.TabIndex = 26;
            this.lblLecturaModo.Text = "Modo de Lectura:";
            // 
            // TextBoxGisY
            // 
            this.TextBoxGisY.BackColor = System.Drawing.Color.Red;
            this.TextBoxGisY.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TextBoxGisY.Location = new System.Drawing.Point(427, 133);
            this.TextBoxGisY.MaxLength = 50;
            this.TextBoxGisY.Name = "TextBoxGisY";
            this.TextBoxGisY.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.TextBoxGisY.Size = new System.Drawing.Size(150, 20);
            this.TextBoxGisY.TabIndex = 6;
            this.TextBoxGisY.TextoVacio = "<Descripcion>";
            this.TextBoxGisY.TipoControl = Controles.util.Enumerados.enumTipos.Decimal;
            // 
            // TextBoxGisX
            // 
            this.TextBoxGisX.BackColor = System.Drawing.Color.Red;
            this.TextBoxGisX.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TextBoxGisX.Location = new System.Drawing.Point(72, 133);
            this.TextBoxGisX.MaxLength = 50;
            this.TextBoxGisX.Name = "TextBoxGisX";
            this.TextBoxGisX.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.TextBoxGisX.Size = new System.Drawing.Size(150, 20);
            this.TextBoxGisX.TabIndex = 5;
            this.TextBoxGisX.TextoVacio = "<Descripcion>";
            this.TextBoxGisX.TipoControl = Controles.util.Enumerados.enumTipos.Decimal;
            // 
            // TextBoxFactorCalib
            // 
            this.TextBoxFactorCalib.BackColor = System.Drawing.Color.White;
            this.TextBoxFactorCalib.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TextBoxFactorCalib.Location = new System.Drawing.Point(427, 101);
            this.TextBoxFactorCalib.MaxLength = 50;
            this.TextBoxFactorCalib.Name = "TextBoxFactorCalib";
            this.TextBoxFactorCalib.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.TextBoxFactorCalib.Size = new System.Drawing.Size(150, 20);
            this.TextBoxFactorCalib.TabIndex = 4;
            this.TextBoxFactorCalib.TextoVacio = "<Descripcion>";
            this.TextBoxFactorCalib.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // TextBoxDigitos
            // 
            this.TextBoxDigitos.BackColor = System.Drawing.Color.Red;
            this.TextBoxDigitos.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TextBoxDigitos.Location = new System.Drawing.Point(72, 101);
            this.TextBoxDigitos.MaxLength = 50;
            this.TextBoxDigitos.Name = "TextBoxDigitos";
            this.TextBoxDigitos.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.TextBoxDigitos.Size = new System.Drawing.Size(116, 20);
            this.TextBoxDigitos.TabIndex = 3;
            this.TextBoxDigitos.TextoVacio = "<Descripcion>";
            this.TextBoxDigitos.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // TextBoxNumeroSerie
            // 
            this.TextBoxNumeroSerie.BackColor = System.Drawing.Color.Red;
            this.TextBoxNumeroSerie.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TextBoxNumeroSerie.Location = new System.Drawing.Point(128, 26);
            this.TextBoxNumeroSerie.Name = "TextBoxNumeroSerie";
            this.TextBoxNumeroSerie.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.TextBoxNumeroSerie.Size = new System.Drawing.Size(165, 20);
            this.TextBoxNumeroSerie.TabIndex = 1;
            this.TextBoxNumeroSerie.TextoVacio = "<Descripcion>";
            this.TextBoxNumeroSerie.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCarga.Location = new System.Drawing.Point(128, 213);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.dtpFechaCarga.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaCarga.TabIndex = 10;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(13, 211);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(86, 13);
            this.lblEtiqueta1.TabIndex = 24;
            this.lblEtiqueta1.Text = "Fecha de Carga:";
            // 
            // cmbMmoCodigo
            // 
            this.cmbMmoCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMmoCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMmoCodigo.FormattingEnabled = true;
            this.cmbMmoCodigo.Location = new System.Drawing.Point(128, 173);
            this.cmbMmoCodigo.Name = "cmbMmoCodigo";
            this.cmbMmoCodigo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbMmoCodigo.Size = new System.Drawing.Size(165, 21);
            this.cmbMmoCodigo.TabIndex = 8;
            this.cmbMmoCodigo.Text = "<Seleccione Modelo>";
            // 
            // lblGisY
            // 
            this.lblGisY.AutoSize = true;
            this.lblGisY.Location = new System.Drawing.Point(314, 140);
            this.lblGisY.Name = "lblGisY";
            this.lblGisY.Size = new System.Drawing.Size(35, 13);
            this.lblGisY.TabIndex = 22;
            this.lblGisY.Text = "GIS Y";
            // 
            // lblMmoCodigo
            // 
            this.lblMmoCodigo.AutoSize = true;
            this.lblMmoCodigo.Location = new System.Drawing.Point(13, 176);
            this.lblMmoCodigo.Name = "lblMmoCodigo";
            this.lblMmoCodigo.Size = new System.Drawing.Size(101, 13);
            this.lblMmoCodigo.TabIndex = 22;
            this.lblMmoCodigo.Text = "Modelo de Medidor:";
            // 
            // lblDecimales
            // 
            this.lblDecimales.AutoSize = true;
            this.lblDecimales.Location = new System.Drawing.Point(314, 104);
            this.lblDecimales.Name = "lblDecimales";
            this.lblDecimales.Size = new System.Drawing.Size(110, 13);
            this.lblDecimales.TabIndex = 22;
            this.lblDecimales.Text = "Factor de Calibración:";
            // 
            // lblNumeroProv
            // 
            this.lblNumeroProv.AutoSize = true;
            this.lblNumeroProv.Location = new System.Drawing.Point(13, 63);
            this.lblNumeroProv.Name = "lblNumeroProv";
            this.lblNumeroProv.Size = new System.Drawing.Size(109, 13);
            this.lblNumeroProv.TabIndex = 22;
            this.lblNumeroProv.Text = "Empresa Proveedora;";
            // 
            // lblGisX
            // 
            this.lblGisX.AutoSize = true;
            this.lblGisX.Location = new System.Drawing.Point(13, 140);
            this.lblGisX.Name = "lblGisX";
            this.lblGisX.Size = new System.Drawing.Size(38, 13);
            this.lblGisX.TabIndex = 22;
            this.lblGisX.Text = "GIS X:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 247);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDigitos
            // 
            this.lblDigitos.AutoSize = true;
            this.lblDigitos.Location = new System.Drawing.Point(13, 104);
            this.lblDigitos.Name = "lblDigitos";
            this.lblDigitos.Size = new System.Drawing.Size(44, 13);
            this.lblDigitos.TabIndex = 22;
            this.lblDigitos.Text = "Dígitos:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(13, 29);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(89, 13);
            this.lbDescripcion.TabIndex = 0;
            this.lbDescripcion.Text = "Numero de Serie:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(127, 244);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbEstado.Size = new System.Drawing.Size(165, 21);
            this.cmbEstado.TabIndex = 45;
            // 
            // frmMedidoresCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 436);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmMedidoresCrud";
            this.Text = "frmMedidoresCrud";
            this.Load += new System.EventHandler(this.frmMedidoresCrud_Load);
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
        private Controles.Fecha.dtpFecha dtpFechaCarga;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.datos.cmbLista cmbMmoCodigo;
        private Controles.labels.lblEtiqueta lblGisY;
        private Controles.labels.lblEtiqueta lblMmoCodigo;
        private Controles.labels.lblEtiqueta lblDecimales;
        private Controles.labels.lblEtiqueta lblNumeroProv;
        private Controles.labels.lblEtiqueta lblGisX;
        private Controles.labels.lblEtiqueta lblEstado;
        private Controles.labels.lblEtiqueta lblDigitos;
        private Controles.labels.lblEtiqueta lbDescripcion;
        private Controles.textBoxes.gesTextBox TextBoxNumeroSerie;
        private Controles.textBoxes.txtDescripcion TextBoxGisY;
        private Controles.textBoxes.txtDescripcion TextBoxGisX;
        private Controles.textBoxes.txtDescripcion TextBoxFactorCalib;
        private Controles.textBoxes.txtDescripcion TextBoxDigitos;
        private Controles.datos.cmbLista cmbLmeCodigo;
        private Controles.labels.lblEtiqueta lblLecturaModo;
        private Controles.buttons.btnGeneral btnCliente;
        private Controles.textBoxes.txtDescripcion txtEmpRazonSocial;
        private Controles.textBoxes.txtDescripcion txtEmpNumero;
        private Controles.datos.cmbLista cmbEstado;
    }
}