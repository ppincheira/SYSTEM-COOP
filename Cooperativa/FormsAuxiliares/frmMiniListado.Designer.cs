namespace FormsAuxiliares
{
    partial class frmMiniListado
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
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.txtFiltro = new Controles.textBoxes.txtDescripcion();
            this.lblTitulo1 = new Controles.labels.lblTitulo();
            this.gvListado = new Controles.datos.grdGrillaAdmin();
            this.gesGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gesGroup1
            // 
            this.gesGroup1.Controls.Add(this.lblCantidad);
            this.gesGroup1.Controls.Add(this.txtFiltro);
            this.gesGroup1.Controls.Add(this.lblTitulo1);
            this.gesGroup1.Controls.Add(this.gvListado);
            this.gesGroup1.Location = new System.Drawing.Point(7, 0);
            this.gesGroup1.Name = "gesGroup1";
            this.gesGroup1.Size = new System.Drawing.Size(468, 347);
            this.gesGroup1.TabIndex = 0;
            this.gesGroup1.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(3, 325);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 17);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFiltro.Location = new System.Drawing.Point(98, 12);
            this.txtFiltro.MaxLength = 50;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtFiltro.Size = new System.Drawing.Size(364, 22);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextoVacio = "<Descripcion>";
            this.txtFiltro.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Location = new System.Drawing.Point(6, 15);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(86, 17);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "Descripción:";
            // 
            // gvListado
            // 
            this.gvListado.AllowUserToAddRows = false;
            this.gvListado.AllowUserToDeleteRows = false;
            this.gvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListado.Location = new System.Drawing.Point(6, 51);
            this.gvListado.Name = "gvListado";
            this.gvListado.RowTemplate.Height = 24;
            this.gvListado.Size = new System.Drawing.Size(456, 271);
            this.gvListado.TabIndex = 0;
            // 
            // frmMiniListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 352);
            this.Controls.Add(this.gesGroup1);
            this.Name = "frmMiniListado";
            this.Text = "frmMiniListado";
            this.Load += new System.EventHandler(this.frmMiniListado_Load);
            this.gesGroup1.ResumeLayout(false);
            this.gesGroup1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gesGroup gesGroup1;
        private Controles.datos.grdGrillaAdmin gvListado;
        private Controles.textBoxes.txtDescripcion txtFiltro;
        private Controles.labels.lblTitulo lblTitulo1;
        private Controles.labels.lblEtiqueta lblCantidad;
    }
}