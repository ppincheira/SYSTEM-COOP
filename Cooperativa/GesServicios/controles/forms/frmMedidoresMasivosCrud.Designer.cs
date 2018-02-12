namespace GesServicios.controles.forms
{
    partial class frmMedidoresMasivosCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedidoresMasivosCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.gesTextBoxFactorCalib = new Controles.textBoxes.gesTextBox();
            this.gesTextBoxNumeroSerieHasta = new Controles.textBoxes.gesTextBox();
            this.gesTextBoxNumeroSerieDesde = new Controles.textBoxes.gesTextBox();
            this.gesTextBoxGisY = new Controles.textBoxes.gesTextBox();
            this.gesTextBoxGisX = new Controles.textBoxes.gesTextBox();
            this.gesTextBoxDigitos = new Controles.textBoxes.gesTextBox();
            this.dtpFechaCarga = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.cmbMmoCodigo = new Controles.datos.cmbLista();
            this.chkEstado = new Controles.datos.chkBox();
            this.lblGisY = new Controles.labels.lblEtiqueta();
            this.cmbNumeroProv = new Controles.datos.cmbLista();
            this.lblMmoCodigo = new Controles.labels.lblEtiqueta();
            this.lblDecimales = new Controles.labels.lblEtiqueta();
            this.lblNumeroProv = new Controles.labels.lblEtiqueta();
            this.lblGisX = new Controles.labels.lblEtiqueta();
            this.lblEstado = new Controles.labels.lblEtiqueta();
            this.lblSerieHasta = new Controles.labels.lblEtiqueta();
            this.lblDigitos = new Controles.labels.lblEtiqueta();
            this.lblSerieDesde = new Controles.labels.lblEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(159, 313);
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
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.gbDatos.Controls.Add(this.gesTextBoxFactorCalib);
            this.gbDatos.Controls.Add(this.gesTextBoxNumeroSerieHasta);
            this.gbDatos.Controls.Add(this.gesTextBoxNumeroSerieDesde);
            this.gbDatos.Controls.Add(this.gesTextBoxGisY);
            this.gbDatos.Controls.Add(this.gesTextBoxGisX);
            this.gbDatos.Controls.Add(this.gesTextBoxDigitos);
            this.gbDatos.Controls.Add(this.dtpFechaCarga);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.cmbMmoCodigo);
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.lblGisY);
            this.gbDatos.Controls.Add(this.cmbNumeroProv);
            this.gbDatos.Controls.Add(this.lblMmoCodigo);
            this.gbDatos.Controls.Add(this.lblDecimales);
            this.gbDatos.Controls.Add(this.lblNumeroProv);
            this.gbDatos.Controls.Add(this.lblGisX);
            this.gbDatos.Controls.Add(this.lblEstado);
            this.gbDatos.Controls.Add(this.lblSerieHasta);
            this.gbDatos.Controls.Add(this.lblDigitos);
            this.gbDatos.Controls.Add(this.lblSerieDesde);
            this.gbDatos.Location = new System.Drawing.Point(12, 1);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(598, 288);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // gesTextBoxFactorCalib
            // 
            this.gesTextBoxFactorCalib.BackColor = System.Drawing.Color.Red;
            this.gesTextBoxFactorCalib.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxFactorCalib.Location = new System.Drawing.Point(427, 115);
            this.gesTextBoxFactorCalib.Name = "gesTextBoxFactorCalib";
            this.gesTextBoxFactorCalib.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBoxFactorCalib.Size = new System.Drawing.Size(100, 20);
            this.gesTextBoxFactorCalib.TabIndex = 5;
            this.gesTextBoxFactorCalib.TextoVacio = "<Descripcion>";
            this.gesTextBoxFactorCalib.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // gesTextBoxNumeroSerieHasta
            // 
            this.gesTextBoxNumeroSerieHasta.BackColor = System.Drawing.Color.Red;
            this.gesTextBoxNumeroSerieHasta.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxNumeroSerieHasta.Location = new System.Drawing.Point(134, 53);
            this.gesTextBoxNumeroSerieHasta.Name = "gesTextBoxNumeroSerieHasta";
            this.gesTextBoxNumeroSerieHasta.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBoxNumeroSerieHasta.Size = new System.Drawing.Size(165, 20);
            this.gesTextBoxNumeroSerieHasta.TabIndex = 2;
            this.gesTextBoxNumeroSerieHasta.TextoVacio = "<Descripcion>";
            this.gesTextBoxNumeroSerieHasta.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // gesTextBoxNumeroSerieDesde
            // 
            this.gesTextBoxNumeroSerieDesde.BackColor = System.Drawing.Color.Red;
            this.gesTextBoxNumeroSerieDesde.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxNumeroSerieDesde.Location = new System.Drawing.Point(134, 23);
            this.gesTextBoxNumeroSerieDesde.Name = "gesTextBoxNumeroSerieDesde";
            this.gesTextBoxNumeroSerieDesde.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBoxNumeroSerieDesde.Size = new System.Drawing.Size(165, 20);
            this.gesTextBoxNumeroSerieDesde.TabIndex = 1;
            this.gesTextBoxNumeroSerieDesde.TextoVacio = "<Descripcion>";
            this.gesTextBoxNumeroSerieDesde.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // gesTextBoxGisY
            // 
            this.gesTextBoxGisY.BackColor = System.Drawing.Color.Red;
            this.gesTextBoxGisY.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxGisY.Location = new System.Drawing.Point(427, 147);
            this.gesTextBoxGisY.Name = "gesTextBoxGisY";
            this.gesTextBoxGisY.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.gesTextBoxGisY.Size = new System.Drawing.Size(155, 20);
            this.gesTextBoxGisY.TabIndex = 7;
            this.gesTextBoxGisY.TextoVacio = "<Descripcion>";
            this.gesTextBoxGisY.TipoControl = Controles.util.Enumerados.enumTipos.Decimal;
            // 
            // gesTextBoxGisX
            // 
            this.gesTextBoxGisX.BackColor = System.Drawing.Color.Red;
            this.gesTextBoxGisX.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxGisX.Location = new System.Drawing.Point(134, 147);
            this.gesTextBoxGisX.Name = "gesTextBoxGisX";
            this.gesTextBoxGisX.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.gesTextBoxGisX.Size = new System.Drawing.Size(155, 20);
            this.gesTextBoxGisX.TabIndex = 6;
            this.gesTextBoxGisX.TextoVacio = "<Descripcion>";
            this.gesTextBoxGisX.TipoControl = Controles.util.Enumerados.enumTipos.Decimal;
            this.gesTextBoxGisX.TextChanged += new System.EventHandler(this.gesTextBoxGisX_TextChanged);
            // 
            // gesTextBoxDigitos
            // 
            this.gesTextBoxDigitos.BackColor = System.Drawing.Color.Red;
            this.gesTextBoxDigitos.ColorTextoVacio = System.Drawing.Color.Gray;
            this.gesTextBoxDigitos.Location = new System.Drawing.Point(134, 111);
            this.gesTextBoxDigitos.Name = "gesTextBoxDigitos";
            this.gesTextBoxDigitos.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.gesTextBoxDigitos.Size = new System.Drawing.Size(100, 20);
            this.gesTextBoxDigitos.TabIndex = 4;
            this.gesTextBoxDigitos.TextoVacio = "<Descripcion>";
            this.gesTextBoxDigitos.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCarga.Location = new System.Drawing.Point(134, 225);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.dtpFechaCarga.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaCarga.TabIndex = 9;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(13, 225);
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
            this.cmbMmoCodigo.Location = new System.Drawing.Point(134, 187);
            this.cmbMmoCodigo.Name = "cmbMmoCodigo";
            this.cmbMmoCodigo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbMmoCodigo.Size = new System.Drawing.Size(165, 21);
            this.cmbMmoCodigo.TabIndex = 8;
            this.cmbMmoCodigo.Text = "<Seleccione Modelo>";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(134, 261);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.chkEstado.Size = new System.Drawing.Size(73, 17);
            this.chkEstado.TabIndex = 10;
            this.chkEstado.Text = "Habilitado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblGisY
            // 
            this.lblGisY.AutoSize = true;
            this.lblGisY.Location = new System.Drawing.Point(336, 154);
            this.lblGisY.Name = "lblGisY";
            this.lblGisY.Size = new System.Drawing.Size(35, 13);
            this.lblGisY.TabIndex = 22;
            this.lblGisY.Text = "GIS Y";
            // 
            // cmbNumeroProv
            // 
            this.cmbNumeroProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNumeroProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNumeroProv.FormattingEnabled = true;
            this.cmbNumeroProv.Location = new System.Drawing.Point(134, 84);
            this.cmbNumeroProv.Name = "cmbNumeroProv";
            this.cmbNumeroProv.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbNumeroProv.Size = new System.Drawing.Size(165, 21);
            this.cmbNumeroProv.TabIndex = 3;
            // 
            // lblMmoCodigo
            // 
            this.lblMmoCodigo.AutoSize = true;
            this.lblMmoCodigo.Location = new System.Drawing.Point(13, 190);
            this.lblMmoCodigo.Name = "lblMmoCodigo";
            this.lblMmoCodigo.Size = new System.Drawing.Size(101, 13);
            this.lblMmoCodigo.TabIndex = 22;
            this.lblMmoCodigo.Text = "Modelo de Medidor:";
            // 
            // lblDecimales
            // 
            this.lblDecimales.AutoSize = true;
            this.lblDecimales.Location = new System.Drawing.Point(314, 118);
            this.lblDecimales.Name = "lblDecimales";
            this.lblDecimales.Size = new System.Drawing.Size(110, 13);
            this.lblDecimales.TabIndex = 22;
            this.lblDecimales.Text = "Factor de Calibración:";
            // 
            // lblNumeroProv
            // 
            this.lblNumeroProv.AutoSize = true;
            this.lblNumeroProv.Location = new System.Drawing.Point(13, 87);
            this.lblNumeroProv.Name = "lblNumeroProv";
            this.lblNumeroProv.Size = new System.Drawing.Size(109, 13);
            this.lblNumeroProv.TabIndex = 22;
            this.lblNumeroProv.Text = "Empresa Proveedora;";
            // 
            // lblGisX
            // 
            this.lblGisX.AutoSize = true;
            this.lblGisX.Location = new System.Drawing.Point(13, 154);
            this.lblGisX.Name = "lblGisX";
            this.lblGisX.Size = new System.Drawing.Size(38, 13);
            this.lblGisX.TabIndex = 22;
            this.lblGisX.Text = "GIS X:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 261);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado:";
            // 
            // lblSerieHasta
            // 
            this.lblSerieHasta.AutoSize = true;
            this.lblSerieHasta.Location = new System.Drawing.Point(13, 56);
            this.lblSerieHasta.Name = "lblSerieHasta";
            this.lblSerieHasta.Size = new System.Drawing.Size(114, 13);
            this.lblSerieHasta.TabIndex = 0;
            this.lblSerieHasta.Text = "Numero de Serie Final:";
            // 
            // lblDigitos
            // 
            this.lblDigitos.AutoSize = true;
            this.lblDigitos.Location = new System.Drawing.Point(13, 118);
            this.lblDigitos.Name = "lblDigitos";
            this.lblDigitos.Size = new System.Drawing.Size(44, 13);
            this.lblDigitos.TabIndex = 22;
            this.lblDigitos.Text = "Dígitos:";
            // 
            // lblSerieDesde
            // 
            this.lblSerieDesde.AutoSize = true;
            this.lblSerieDesde.Location = new System.Drawing.Point(13, 26);
            this.lblSerieDesde.Name = "lblSerieDesde";
            this.lblSerieDesde.Size = new System.Drawing.Size(119, 13);
            this.lblSerieDesde.TabIndex = 0;
            this.lblSerieDesde.Text = "Numero de Serie Inicial:";
            // 
            // frmMedidoresMasivosCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 428);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmMedidoresMasivosCrud";
            this.Text = "Alta Masiva de Medidores";
            this.Load += new System.EventHandler(this.frmMedidoresMasivosCrud_Load);
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
        private Controles.textBoxes.gesTextBox gesTextBoxFactorCalib;
        private Controles.textBoxes.gesTextBox gesTextBoxNumeroSerieDesde;
        private Controles.textBoxes.gesTextBox gesTextBoxGisY;
        private Controles.textBoxes.gesTextBox gesTextBoxGisX;
        private Controles.textBoxes.gesTextBox gesTextBoxDigitos;
        private Controles.Fecha.dtpFecha dtpFechaCarga;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.datos.cmbLista cmbMmoCodigo;
        private Controles.datos.chkBox chkEstado;
        private Controles.labels.lblEtiqueta lblGisY;
        private Controles.datos.cmbLista cmbNumeroProv;
        private Controles.labels.lblEtiqueta lblMmoCodigo;
        private Controles.labels.lblEtiqueta lblDecimales;
        private Controles.labels.lblEtiqueta lblNumeroProv;
        private Controles.labels.lblEtiqueta lblGisX;
        private Controles.labels.lblEtiqueta lblEstado;
        private Controles.labels.lblEtiqueta lblDigitos;
        private Controles.labels.lblEtiqueta lblSerieDesde;
        private Controles.textBoxes.gesTextBox gesTextBoxNumeroSerieHasta;
        private Controles.labels.lblEtiqueta lblSerieHasta;
    }
}