using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Controles.datos;
using Model;
using Controles.form;
using AppProcesos.gesConfiguracion.frmCuadrosTarifariosCrud;


namespace GesConfiguracion.controles.forms
{
    public partial class frmCuadrosTarifariosCrud : gesForm , IVistaCuadrosTarifariosCrud
    {

        #region << PROPIEDADES >>

       //public Admin _oAdmin;
       // private string _Tabla;
       // Utility _oUtil;
        //public string _strRdoCodigo;
        private UICuadrosTarifariosCrud _oCuadrosTarifariosCrud;
        #endregion

        #region Implementation of IVistaCuadrosTarifariosCrud
        public grdGrillaAdmin grillaCuadrosTarifarios
        {
            get { return this.grdCuadrosTarifarios; }
            set { this.grdCuadrosTarifarios = value; }
        }
        public grdGrillaAdmin grillaCategorias
        {
            get { return this.grdCategorias; }
            set { this.grdCategorias = value; }
        }
        public grdGrillaAdmin grillaConceptosCategorias
        {
            get { return this.grdConceptosCategorias; }
            set { this.grdConceptosCategorias = value; }
        }

        public grdGrillaAdmin grillaConceptosGenerales
        {
            get { return this.grdConceptosGenerales; }
            set { this.grdConceptosGenerales = value; }
        }


        #endregion


        private Controles.contenedores.gesGroup gesGroup1;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.contenedores.gesGroup gesGroup3;
        private grdGrillaAdmin grdCuadrosTarifarios;
        private grdGrillaAdmin grdConceptosGenerales;
        private grdGrillaAdmin grdConceptosCategorias;
        private grdGrillaAdmin grdCategorias;
        private Controles.contenedores.gesGroup gesGroup4;

        private void InitializeComponent()
        {
            this.gesGroup1 = new Controles.contenedores.gesGroup();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.gesGroup3 = new Controles.contenedores.gesGroup();
            this.gesGroup4 = new Controles.contenedores.gesGroup();
            this.grdCuadrosTarifarios = new Controles.datos.grdGrillaAdmin();
            this.grdConceptosGenerales = new Controles.datos.grdGrillaAdmin();
            this.grdCategorias = new Controles.datos.grdGrillaAdmin();
            this.grdConceptosCategorias = new Controles.datos.grdGrillaAdmin();
            this.gesGroup1.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.gesGroup3.SuspendLayout();
            this.gesGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuadrosTarifarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptosGenerales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptosCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // gesGroup1
            // 
            this.gesGroup1.Controls.Add(this.grdCuadrosTarifarios);
            this.gesGroup1.Location = new System.Drawing.Point(12, 12);
            this.gesGroup1.Name = "gesGroup1";
            this.gesGroup1.Size = new System.Drawing.Size(207, 729);
            this.gesGroup1.TabIndex = 0;
            this.gesGroup1.TabStop = false;
            this.gesGroup1.Text = "Cuadros Tarifarios";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.grdConceptosGenerales);
            this.gesGroup2.Location = new System.Drawing.Point(225, 12);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(1038, 260);
            this.gesGroup2.TabIndex = 1;
            this.gesGroup2.TabStop = false;
            this.gesGroup2.Text = "Conceptos Generales";
            // 
            // gesGroup3
            // 
            this.gesGroup3.Controls.Add(this.grdConceptosCategorias);
            this.gesGroup3.Location = new System.Drawing.Point(482, 278);
            this.gesGroup3.Name = "gesGroup3";
            this.gesGroup3.Size = new System.Drawing.Size(781, 463);
            this.gesGroup3.TabIndex = 2;
            this.gesGroup3.TabStop = false;
            this.gesGroup3.Text = "Conceptos por Categoria";
            // 
            // gesGroup4
            // 
            this.gesGroup4.Controls.Add(this.grdCategorias);
            this.gesGroup4.Location = new System.Drawing.Point(225, 278);
            this.gesGroup4.Name = "gesGroup4";
            this.gesGroup4.Size = new System.Drawing.Size(251, 463);
            this.gesGroup4.TabIndex = 1;
            this.gesGroup4.TabStop = false;
            this.gesGroup4.Text = "Categorias";
            // 
            // grdCuadrosTarifarios
            // 
            this.grdCuadrosTarifarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCuadrosTarifarios.Location = new System.Drawing.Point(6, 19);
            this.grdCuadrosTarifarios.Name = "grdCuadrosTarifarios";
            this.grdCuadrosTarifarios.Size = new System.Drawing.Size(195, 654);
            this.grdCuadrosTarifarios.TabIndex = 0;
            // 
            // grdConceptosGenerales
            // 
            this.grdConceptosGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConceptosGenerales.Location = new System.Drawing.Point(6, 19);
            this.grdConceptosGenerales.Name = "grdConceptosGenerales";
            this.grdConceptosGenerales.Size = new System.Drawing.Size(1026, 235);
            this.grdConceptosGenerales.TabIndex = 1;
            // 
            // grdCategorias
            // 
            this.grdCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategorias.Location = new System.Drawing.Point(6, 19);
            this.grdCategorias.Name = "grdCategorias";
            this.grdCategorias.Size = new System.Drawing.Size(239, 438);
            this.grdCategorias.TabIndex = 1;
            // 
            // grdConceptosCategorias
            // 
            this.grdConceptosCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConceptosCategorias.Location = new System.Drawing.Point(6, 19);
            this.grdConceptosCategorias.Name = "grdConceptosCategorias";
            this.grdConceptosCategorias.Size = new System.Drawing.Size(769, 438);
            this.grdConceptosCategorias.TabIndex = 1;
            // 
            // frmCuadrosTarifarios
            // 
            this.ClientSize = new System.Drawing.Size(1275, 751);
            this.Controls.Add(this.gesGroup4);
            this.Controls.Add(this.gesGroup3);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gesGroup1);
            this.Name = "frmCuadrosTarifariosCrud";
            this.gesGroup1.ResumeLayout(false);
            this.gesGroup2.ResumeLayout(false);
            this.gesGroup3.ResumeLayout(false);
            this.gesGroup4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCuadrosTarifarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptosGenerales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConceptosCategorias)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
