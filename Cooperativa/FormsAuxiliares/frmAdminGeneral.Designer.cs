namespace FormsAuxiliares
{
    partial class frmAdminGeneral
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
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Location = new System.Drawing.Point(5, 131);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(1257, 569);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            this.gpbGrupo1.Text = "gpbGrupo1";
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Location = new System.Drawing.Point(529, 12);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(733, 113);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            this.gpbGrupo2.Text = "gpbGrupo2";
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Location = new System.Drawing.Point(5, 12);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(518, 113);
            this.gpbGrupo3.TabIndex = 2;
            this.gpbGrupo3.TabStop = false;
            this.gpbGrupo3.Text = "gpbGrupo3";
            // 
            // frmAdminGeneral
            // 
            this.ClientSize = new System.Drawing.Size(1274, 722);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmAdminGeneral";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.contenedores.gpbGrupo gpbGrupo1;
        private Controles.contenedores.gpbGrupo gpbGrupo2;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
    }
}
