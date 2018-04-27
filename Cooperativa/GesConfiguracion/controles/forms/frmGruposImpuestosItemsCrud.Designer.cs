namespace GesConfiguracion.controles.forms
{
    partial class frmGruposImpuestosItemsCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGruposImpuestosItemsCrud));
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.txtImporteFijo = new Controles.NumericTextBox();
            this.lblEtiqueta12 = new Controles.labels.lblEtiqueta();
            this.txtBaseMinimo = new Controles.NumericTextBox();
            this.lblEtiqueta13 = new Controles.labels.lblEtiqueta();
            this.txtImporteMinimo = new Controles.NumericTextBox();
            this.lblEtiqueta10 = new Controles.labels.lblEtiqueta();
            this.txtPorcentaje = new Controles.NumericTextBox();
            this.lblEtiqueta9 = new Controles.labels.lblEtiqueta();
            this.btnConcepto = new Controles.buttons.btnGeneral();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.txtConcepto = new Controles.textBoxes.txtDescripcion();
            this.cmbProvincia = new Controles.datos.cmbLista();
            this.lblEtiqueta16 = new Controles.labels.lblEtiqueta();
            this.cmbLocalidad = new Controles.datos.cmbLista();
            this.lblEtiqueta14 = new Controles.labels.lblEtiqueta();
            this.dtpVigenciaHasta = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta8 = new Controles.labels.lblEtiqueta();
            this.dtpVigenciaDesde = new Controles.Fecha.dtpFecha();
            this.lblEtiqueta7 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta4 = new Controles.labels.lblEtiqueta();
            this.cmbGrupo = new Controles.datos.cmbLista();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.cmbTipoIva = new Controles.datos.cmbLista();
            this.tttEtiqueta = new Controles.objects.tttEtiqueta();
            this.gesGroup2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(8, 246);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(600, 89);
            this.gesGroup2.TabIndex = 13;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(400, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(495, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtImporteFijo);
            this.gbDatos.Controls.Add(this.lblEtiqueta12);
            this.gbDatos.Controls.Add(this.txtBaseMinimo);
            this.gbDatos.Controls.Add(this.lblEtiqueta13);
            this.gbDatos.Controls.Add(this.txtImporteMinimo);
            this.gbDatos.Controls.Add(this.lblEtiqueta10);
            this.gbDatos.Controls.Add(this.txtPorcentaje);
            this.gbDatos.Controls.Add(this.lblEtiqueta9);
            this.gbDatos.Controls.Add(this.btnConcepto);
            this.gbDatos.Controls.Add(this.lblEtiqueta2);
            this.gbDatos.Controls.Add(this.txtConcepto);
            this.gbDatos.Controls.Add(this.cmbProvincia);
            this.gbDatos.Controls.Add(this.lblEtiqueta16);
            this.gbDatos.Controls.Add(this.cmbLocalidad);
            this.gbDatos.Controls.Add(this.lblEtiqueta14);
            this.gbDatos.Controls.Add(this.dtpVigenciaHasta);
            this.gbDatos.Controls.Add(this.lblEtiqueta8);
            this.gbDatos.Controls.Add(this.dtpVigenciaDesde);
            this.gbDatos.Controls.Add(this.lblEtiqueta7);
            this.gbDatos.Controls.Add(this.lblEtiqueta4);
            this.gbDatos.Controls.Add(this.cmbGrupo);
            this.gbDatos.Controls.Add(this.lblEtiqueta3);
            this.gbDatos.Controls.Add(this.cmbTipoIva);
            this.gbDatos.Location = new System.Drawing.Point(8, 5);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(603, 235);
            this.gbDatos.TabIndex = 12;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Grupos Impuestos Items";
            // 
            // txtImporteFijo
            // 
            this.txtImporteFijo.AllowSpace = false;
            this.txtImporteFijo.Location = new System.Drawing.Point(405, 128);
            this.txtImporteFijo.MaxLength = 17;
            this.txtImporteFijo.Name = "txtImporteFijo";
            this.txtImporteFijo.Size = new System.Drawing.Size(151, 20);
            this.txtImporteFijo.TabIndex = 8;
            // 
            // lblEtiqueta12
            // 
            this.lblEtiqueta12.AutoSize = true;
            this.lblEtiqueta12.Location = new System.Drawing.Point(298, 135);
            this.lblEtiqueta12.Name = "lblEtiqueta12";
            this.lblEtiqueta12.Size = new System.Drawing.Size(64, 13);
            this.lblEtiqueta12.TabIndex = 69;
            this.lblEtiqueta12.Text = "Importe Fijo:";
            // 
            // txtBaseMinimo
            // 
            this.txtBaseMinimo.AllowSpace = false;
            this.txtBaseMinimo.Location = new System.Drawing.Point(405, 161);
            this.txtBaseMinimo.MaxLength = 17;
            this.txtBaseMinimo.Name = "txtBaseMinimo";
            this.txtBaseMinimo.Size = new System.Drawing.Size(151, 20);
            this.txtBaseMinimo.TabIndex = 10;
            // 
            // lblEtiqueta13
            // 
            this.lblEtiqueta13.AutoSize = true;
            this.lblEtiqueta13.Location = new System.Drawing.Point(298, 168);
            this.lblEtiqueta13.Name = "lblEtiqueta13";
            this.lblEtiqueta13.Size = new System.Drawing.Size(70, 13);
            this.lblEtiqueta13.TabIndex = 68;
            this.lblEtiqueta13.Text = "Base Minimo:";
            // 
            // txtImporteMinimo
            // 
            this.txtImporteMinimo.AllowSpace = false;
            this.txtImporteMinimo.Location = new System.Drawing.Point(123, 161);
            this.txtImporteMinimo.MaxLength = 17;
            this.txtImporteMinimo.Name = "txtImporteMinimo";
            this.txtImporteMinimo.Size = new System.Drawing.Size(150, 20);
            this.txtImporteMinimo.TabIndex = 9;
            // 
            // lblEtiqueta10
            // 
            this.lblEtiqueta10.AutoSize = true;
            this.lblEtiqueta10.Location = new System.Drawing.Point(6, 168);
            this.lblEtiqueta10.Name = "lblEtiqueta10";
            this.lblEtiqueta10.Size = new System.Drawing.Size(81, 13);
            this.lblEtiqueta10.TabIndex = 67;
            this.lblEtiqueta10.Text = "Importe Minimo:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.AllowSpace = false;
            this.txtPorcentaje.Location = new System.Drawing.Point(123, 128);
            this.txtPorcentaje.MaxLength = 17;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(150, 20);
            this.txtPorcentaje.TabIndex = 7;
            // 
            // lblEtiqueta9
            // 
            this.lblEtiqueta9.AutoSize = true;
            this.lblEtiqueta9.Location = new System.Drawing.Point(6, 135);
            this.lblEtiqueta9.Name = "lblEtiqueta9";
            this.lblEtiqueta9.Size = new System.Drawing.Size(61, 13);
            this.lblEtiqueta9.TabIndex = 63;
            this.lblEtiqueta9.Text = "Porcentaje:";
            // 
            // btnConcepto
            // 
            this.btnConcepto.Location = new System.Drawing.Point(97, 95);
            this.btnConcepto.Margin = new System.Windows.Forms.Padding(2);
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Size = new System.Drawing.Size(21, 19);
            this.btnConcepto.TabIndex = 5;
            this.btnConcepto.Text = "...";
            this.btnConcepto.UseVisualStyleBackColor = true;
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(6, 99);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(56, 13);
            this.lblEtiqueta2.TabIndex = 61;
            this.lblEtiqueta2.Text = "Concepto:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtConcepto.Location = new System.Drawing.Point(123, 95);
            this.txtConcepto.MaxLength = 100;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtConcepto.Size = new System.Drawing.Size(433, 20);
            this.txtConcepto.TabIndex = 6;
            this.txtConcepto.TextoVacio = "<Descripcion>";
            this.txtConcepto.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.ItemHeight = 13;
            this.cmbProvincia.Location = new System.Drawing.Point(123, 194);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbProvincia.Size = new System.Drawing.Size(151, 21);
            this.cmbProvincia.TabIndex = 11;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // lblEtiqueta16
            // 
            this.lblEtiqueta16.AutoSize = true;
            this.lblEtiqueta16.Location = new System.Drawing.Point(6, 202);
            this.lblEtiqueta16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtiqueta16.Name = "lblEtiqueta16";
            this.lblEtiqueta16.Size = new System.Drawing.Size(80, 13);
            this.lblEtiqueta16.TabIndex = 44;
            this.lblEtiqueta16.Text = "Provincia Nac.:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.ItemHeight = 13;
            this.cmbLocalidad.Location = new System.Drawing.Point(405, 194);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbLocalidad.Size = new System.Drawing.Size(151, 21);
            this.cmbLocalidad.TabIndex = 12;
            // 
            // lblEtiqueta14
            // 
            this.lblEtiqueta14.AutoSize = true;
            this.lblEtiqueta14.Location = new System.Drawing.Point(298, 202);
            this.lblEtiqueta14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtiqueta14.Name = "lblEtiqueta14";
            this.lblEtiqueta14.Size = new System.Drawing.Size(82, 13);
            this.lblEtiqueta14.TabIndex = 39;
            this.lblEtiqueta14.Text = "Localidad Nac.:";
            // 
            // dtpVigenciaHasta
            // 
            this.dtpVigenciaHasta.Checked = false;
            this.dtpVigenciaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigenciaHasta.Location = new System.Drawing.Point(405, 62);
            this.dtpVigenciaHasta.Name = "dtpVigenciaHasta";
            this.dtpVigenciaHasta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpVigenciaHasta.ShowCheckBox = true;
            this.dtpVigenciaHasta.Size = new System.Drawing.Size(151, 20);
            this.dtpVigenciaHasta.TabIndex = 4;
            // 
            // lblEtiqueta8
            // 
            this.lblEtiqueta8.AutoSize = true;
            this.lblEtiqueta8.Location = new System.Drawing.Point(298, 66);
            this.lblEtiqueta8.Name = "lblEtiqueta8";
            this.lblEtiqueta8.Size = new System.Drawing.Size(82, 13);
            this.lblEtiqueta8.TabIndex = 28;
            this.lblEtiqueta8.Text = "Vigencia Hasta:";
            // 
            // dtpVigenciaDesde
            // 
            this.dtpVigenciaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigenciaDesde.Location = new System.Drawing.Point(405, 26);
            this.dtpVigenciaDesde.Name = "dtpVigenciaDesde";
            this.dtpVigenciaDesde.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.dtpVigenciaDesde.Size = new System.Drawing.Size(151, 20);
            this.dtpVigenciaDesde.TabIndex = 2;
            // 
            // lblEtiqueta7
            // 
            this.lblEtiqueta7.AutoSize = true;
            this.lblEtiqueta7.Location = new System.Drawing.Point(298, 32);
            this.lblEtiqueta7.Name = "lblEtiqueta7";
            this.lblEtiqueta7.Size = new System.Drawing.Size(85, 13);
            this.lblEtiqueta7.TabIndex = 26;
            this.lblEtiqueta7.Text = "Vigencia Desde:";
            // 
            // lblEtiqueta4
            // 
            this.lblEtiqueta4.AutoSize = true;
            this.lblEtiqueta4.Location = new System.Drawing.Point(6, 68);
            this.lblEtiqueta4.Name = "lblEtiqueta4";
            this.lblEtiqueta4.Size = new System.Drawing.Size(39, 13);
            this.lblEtiqueta4.TabIndex = 17;
            this.lblEtiqueta4.Text = "Grupo:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(123, 61);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbGrupo.Size = new System.Drawing.Size(150, 21);
            this.cmbGrupo.TabIndex = 3;
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(6, 32);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new System.Drawing.Size(56, 13);
            this.lblEtiqueta3.TabIndex = 15;
            this.lblEtiqueta3.Text = "Tipos IVA:";
            // 
            // cmbTipoIva
            // 
            this.cmbTipoIva.FormattingEnabled = true;
            this.cmbTipoIva.Location = new System.Drawing.Point(123, 27);
            this.cmbTipoIva.Name = "cmbTipoIva";
            this.cmbTipoIva.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.cmbTipoIva.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoIva.TabIndex = 1;
            // 
            // frmGruposImpuestosItemsCrud
            // 
            this.ClientSize = new System.Drawing.Size(620, 345);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmGruposImpuestosItemsCrud";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmGruposImpuestosItemsCrud_Load);
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
        private Controles.datos.cmbLista cmbProvincia;
        private Controles.labels.lblEtiqueta lblEtiqueta16;
        private Controles.datos.cmbLista cmbLocalidad;
        private Controles.labels.lblEtiqueta lblEtiqueta14;
        private Controles.Fecha.dtpFecha dtpVigenciaHasta;
        private Controles.labels.lblEtiqueta lblEtiqueta8;
        private Controles.Fecha.dtpFecha dtpVigenciaDesde;
        private Controles.labels.lblEtiqueta lblEtiqueta7;
        private Controles.labels.lblEtiqueta lblEtiqueta4;
        private Controles.datos.cmbLista cmbGrupo;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
        private Controles.datos.cmbLista cmbTipoIva;
        private Controles.buttons.btnGeneral btnConcepto;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.textBoxes.txtDescripcion txtConcepto;
        private Controles.NumericTextBox txtPorcentaje;
        private Controles.labels.lblEtiqueta lblEtiqueta9;
        private Controles.NumericTextBox txtImporteFijo;
        private Controles.labels.lblEtiqueta lblEtiqueta12;
        private Controles.NumericTextBox txtBaseMinimo;
        private Controles.labels.lblEtiqueta lblEtiqueta13;
        private Controles.NumericTextBox txtImporteMinimo;
        private Controles.labels.lblEtiqueta lblEtiqueta10;
        private Controles.objects.tttEtiqueta tttEtiqueta;
    }
}
