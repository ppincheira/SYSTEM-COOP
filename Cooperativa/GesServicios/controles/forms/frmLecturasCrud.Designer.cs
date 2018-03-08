namespace GesServicios.controles.forms
{
    partial class frmLecturasCrud
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
            this.gesGroup1 = new Controles.contenedores.gesGroup();
            this.gesGroup5 = new Controles.contenedores.gesGroup();
            this.gesGroup4 = new Controles.contenedores.gesGroup();
            this.grdLecturas = new Controles.datos.grdGrillaEdit();
            this.gesGroup3 = new Controles.contenedores.gesGroup();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.txtDescripcionCorta1 = new Controles.textBoxes.txtDescripcionCorta();
            this.cmbLista1 = new Controles.datos.cmbLista();
            this.txtDescripcionCorta2 = new Controles.textBoxes.txtDescripcionCorta();
            this.txtDescripcionCorta3 = new Controles.textBoxes.txtDescripcionCorta();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta2 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta3 = new Controles.labels.lblEtiqueta();
            this.lblEtiqueta4 = new Controles.labels.lblEtiqueta();
            this.gesGroup1.SuspendLayout();
            this.gesGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLecturas)).BeginInit();
            this.gesGroup3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup1
            // 
            this.gesGroup1.Controls.Add(this.gesGroup5);
            this.gesGroup1.Controls.Add(this.gesGroup4);
            this.gesGroup1.Controls.Add(this.gesGroup3);
            this.gesGroup1.Controls.Add(this.gesGroup2);
            this.gesGroup1.Location = new System.Drawing.Point(2, 2);
            this.gesGroup1.Name = "gesGroup1";
            this.gesGroup1.Size = new System.Drawing.Size(1054, 437);
            this.gesGroup1.TabIndex = 0;
            this.gesGroup1.TabStop = false;
            // 
            // gesGroup5
            // 
            this.gesGroup5.Location = new System.Drawing.Point(7, 329);
            this.gesGroup5.Name = "gesGroup5";
            this.gesGroup5.Size = new System.Drawing.Size(1038, 100);
            this.gesGroup5.TabIndex = 1;
            this.gesGroup5.TabStop = false;
            // 
            // gesGroup4
            // 
            this.gesGroup4.Controls.Add(this.grdLecturas);
            this.gesGroup4.Location = new System.Drawing.Point(6, 116);
            this.gesGroup4.Name = "gesGroup4";
            this.gesGroup4.Size = new System.Drawing.Size(1039, 213);
            this.gesGroup4.TabIndex = 2;
            this.gesGroup4.TabStop = false;
            // 
            // grdLecturas
            // 
            this.grdLecturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLecturas.Location = new System.Drawing.Point(6, 12);
            this.grdLecturas.Name = "grdLecturas";
            this.grdLecturas.RowTemplate.Height = 24;
            this.grdLecturas.Size = new System.Drawing.Size(1027, 185);
            this.grdLecturas.TabIndex = 0;
            // 
            // gesGroup3
            // 
            this.gesGroup3.Controls.Add(this.lblEtiqueta4);
            this.gesGroup3.Controls.Add(this.lblEtiqueta3);
            this.gesGroup3.Controls.Add(this.lblEtiqueta2);
            this.gesGroup3.Controls.Add(this.lblEtiqueta1);
            this.gesGroup3.Controls.Add(this.txtDescripcionCorta3);
            this.gesGroup3.Controls.Add(this.txtDescripcionCorta2);
            this.gesGroup3.Controls.Add(this.cmbLista1);
            this.gesGroup3.Controls.Add(this.txtDescripcionCorta1);
            this.gesGroup3.Location = new System.Drawing.Point(353, 10);
            this.gesGroup3.Name = "gesGroup3";
            this.gesGroup3.Size = new System.Drawing.Size(692, 100);
            this.gesGroup3.TabIndex = 1;
            this.gesGroup3.TabStop = false;
            // 
            // gesGroup2
            // 
            this.gesGroup2.Location = new System.Drawing.Point(6, 10);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(341, 100);
            this.gesGroup2.TabIndex = 0;
            this.gesGroup2.TabStop = false;
            // 
            // txtDescripcionCorta1
            // 
            this.txtDescripcionCorta1.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCorta1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcionCorta1.Location = new System.Drawing.Point(6, 54);
            this.txtDescripcionCorta1.MaxLength = 20;
            this.txtDescripcionCorta1.Name = "txtDescripcionCorta1";
            this.txtDescripcionCorta1.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDescripcionCorta1.Size = new System.Drawing.Size(246, 22);
            this.txtDescripcionCorta1.TabIndex = 0;
            this.txtDescripcionCorta1.TextoVacio = "<Descripcion>";
            this.txtDescripcionCorta1.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // cmbLista1
            // 
            this.cmbLista1.FormattingEnabled = true;
            this.cmbLista1.Location = new System.Drawing.Point(255, 54);
            this.cmbLista1.Name = "cmbLista1";
            this.cmbLista1.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbLista1.Size = new System.Drawing.Size(154, 24);
            this.cmbLista1.TabIndex = 1;
            // 
            // txtDescripcionCorta2
            // 
            this.txtDescripcionCorta2.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCorta2.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcionCorta2.Location = new System.Drawing.Point(412, 54);
            this.txtDescripcionCorta2.MaxLength = 20;
            this.txtDescripcionCorta2.Name = "txtDescripcionCorta2";
            this.txtDescripcionCorta2.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDescripcionCorta2.Size = new System.Drawing.Size(160, 22);
            this.txtDescripcionCorta2.TabIndex = 2;
            this.txtDescripcionCorta2.TextoVacio = "<Descripcion>";
            this.txtDescripcionCorta2.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtDescripcionCorta3
            // 
            this.txtDescripcionCorta3.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCorta3.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcionCorta3.Location = new System.Drawing.Point(578, 54);
            this.txtDescripcionCorta3.MaxLength = 20;
            this.txtDescripcionCorta3.Name = "txtDescripcionCorta3";
            this.txtDescripcionCorta3.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtDescripcionCorta3.Size = new System.Drawing.Size(108, 22);
            this.txtDescripcionCorta3.TabIndex = 3;
            this.txtDescripcionCorta3.TextoVacio = "<Descripcion>";
            this.txtDescripcionCorta3.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(6, 34);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(48, 17);
            this.lblEtiqueta1.TabIndex = 4;
            this.lblEtiqueta1.Text = "Titular";
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Location = new System.Drawing.Point(254, 34);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(52, 17);
            this.lblEtiqueta2.TabIndex = 5;
            this.lblEtiqueta2.Text = "Estado";
            // 
            // lblEtiqueta3
            // 
            this.lblEtiqueta3.AutoSize = true;
            this.lblEtiqueta3.Location = new System.Drawing.Point(411, 34);
            this.lblEtiqueta3.Name = "lblEtiqueta3";
            this.lblEtiqueta3.Size = new System.Drawing.Size(41, 17);
            this.lblEtiqueta3.TabIndex = 6;
            this.lblEtiqueta3.Text = "Zona";
            // 
            // lblEtiqueta4
            // 
            this.lblEtiqueta4.AutoSize = true;
            this.lblEtiqueta4.Location = new System.Drawing.Point(575, 34);
            this.lblEtiqueta4.Name = "lblEtiqueta4";
            this.lblEtiqueta4.Size = new System.Drawing.Size(111, 17);
            this.lblEtiqueta4.TabIndex = 6;
            this.lblEtiqueta4.Text = "Cant. Medidores";
            // 
            // frmLecturasCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 438);
            this.Controls.Add(this.gesGroup1);
            this.Name = "frmLecturasCrud";
            this.Text = "frmLecturasCrud";
            this.Load += new System.EventHandler(this.frmLecturasCrud_Load);
            this.gesGroup1.ResumeLayout(false);
            this.gesGroup4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLecturas)).EndInit();
            this.gesGroup3.ResumeLayout(false);
            this.gesGroup3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup1;
        private Controles.contenedores.gesGroup gesGroup5;
        private Controles.contenedores.gesGroup gesGroup4;
        private Controles.datos.grdGrillaEdit grdLecturas;
        private Controles.contenedores.gesGroup gesGroup3;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.labels.lblEtiqueta lblEtiqueta4;
        private Controles.labels.lblEtiqueta lblEtiqueta3;
        private Controles.labels.lblEtiqueta lblEtiqueta2;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta3;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta2;
        private Controles.datos.cmbLista cmbLista1;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcionCorta1;
    }
}