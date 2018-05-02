using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles.form;
namespace GesConfiguracion.controles.forms
{
    class frmConceptosCategoriasCrud:gesForm
    {
        private Controles.contenedores.gpbGrupo gpbGrupo1;
        private Controles.labels.lblEtiqueta lblCategoria;
        private Controles.labels.lblEtiqueta lblServicio;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.textBoxes.txtDescripcion txtCategoria;
        private Controles.textBoxes.txtDescripcion txtServicio;
        private Controles.textBoxes.txtDescripcion txtConceptoDescripcion;
        private Controles.textBoxes.txtDescripcion txtCodigoConcepto;
        private Controles.labels.lblEtiqueta lblConcepto;
        private Controles.buttons.btnGeneral btnConceptoPadre;
        private Controles.textBoxes.txtDescripcion txtCodigoCuadroTarifario;

        private void InitializeComponent()
        {
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.txtCodigoCuadroTarifario = new Controles.textBoxes.txtDescripcion();
            this.txtServicio = new Controles.textBoxes.txtDescripcion();
            this.txtCategoria = new Controles.textBoxes.txtDescripcion();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.lblServicio = new Controles.labels.lblEtiqueta();
            this.lblCategoria = new Controles.labels.lblEtiqueta();
            this.lblConcepto = new Controles.labels.lblEtiqueta();
            this.txtCodigoConcepto = new Controles.textBoxes.txtDescripcion();
            this.txtConceptoDescripcion = new Controles.textBoxes.txtDescripcion();
            this.btnConceptoPadre = new Controles.buttons.btnGeneral();
            this.gpbGrupo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.btnConceptoPadre);
            this.gpbGrupo1.Controls.Add(this.txtConceptoDescripcion);
            this.gpbGrupo1.Controls.Add(this.txtCodigoConcepto);
            this.gpbGrupo1.Controls.Add(this.lblConcepto);
            this.gpbGrupo1.Controls.Add(this.lblCategoria);
            this.gpbGrupo1.Controls.Add(this.lblServicio);
            this.gpbGrupo1.Controls.Add(this.lblEtiqueta1);
            this.gpbGrupo1.Controls.Add(this.txtCategoria);
            this.gpbGrupo1.Controls.Add(this.txtServicio);
            this.gpbGrupo1.Controls.Add(this.txtCodigoCuadroTarifario);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 1);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(669, 107);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            // 
            // txtCodigoCuadroTarifario
            // 
            this.txtCodigoCuadroTarifario.BackColor = System.Drawing.Color.White;
            this.txtCodigoCuadroTarifario.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtCodigoCuadroTarifario.Location = new System.Drawing.Point(88, 19);
            this.txtCodigoCuadroTarifario.MaxLength = 50;
            this.txtCodigoCuadroTarifario.Name = "txtCodigoCuadroTarifario";
            this.txtCodigoCuadroTarifario.ReadOnly = true;
            this.txtCodigoCuadroTarifario.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtCodigoCuadroTarifario.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoCuadroTarifario.TabIndex = 0;
            this.txtCodigoCuadroTarifario.TextoVacio = "<Descripcion>";
            this.txtCodigoCuadroTarifario.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.Color.White;
            this.txtServicio.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtServicio.Location = new System.Drawing.Point(264, 19);
            this.txtServicio.MaxLength = 50;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtServicio.Size = new System.Drawing.Size(212, 20);
            this.txtServicio.TabIndex = 1;
            this.txtServicio.TextoVacio = "<Descripcion>";
            this.txtServicio.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtCategoria.Location = new System.Drawing.Point(88, 45);
            this.txtCategoria.MaxLength = 50;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtCategoria.Size = new System.Drawing.Size(388, 20);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.TextoVacio = "<Descripcion>";
            this.txtCategoria.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(31, 25);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(34, 13);
            this.lblEtiqueta1.TabIndex = 3;
            this.lblEtiqueta1.Text = "Tarifa";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(213, 25);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(45, 13);
            this.lblServicio.TabIndex = 4;
            this.lblServicio.Text = "Servicio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(30, 48);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(31, 74);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(53, 13);
            this.lblConcepto.TabIndex = 6;
            this.lblConcepto.Text = "Concepto";
            // 
            // txtCodigoConcepto
            // 
            this.txtCodigoConcepto.BackColor = System.Drawing.Color.White;
            this.txtCodigoConcepto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtCodigoConcepto.Location = new System.Drawing.Point(88, 71);
            this.txtCodigoConcepto.MaxLength = 50;
            this.txtCodigoConcepto.Name = "txtCodigoConcepto";
            this.txtCodigoConcepto.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtCodigoConcepto.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoConcepto.TabIndex = 7;
            this.txtCodigoConcepto.TextoVacio = "<Descripcion>";
            this.txtCodigoConcepto.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtConceptoDescripcion
            // 
            this.txtConceptoDescripcion.BackColor = System.Drawing.Color.White;
            this.txtConceptoDescripcion.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtConceptoDescripcion.Location = new System.Drawing.Point(156, 71);
            this.txtConceptoDescripcion.MaxLength = 50;
            this.txtConceptoDescripcion.Name = "txtConceptoDescripcion";
            this.txtConceptoDescripcion.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtConceptoDescripcion.Size = new System.Drawing.Size(284, 20);
            this.txtConceptoDescripcion.TabIndex = 8;
            this.txtConceptoDescripcion.TextoVacio = "<Descripcion>";
            this.txtConceptoDescripcion.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // btnConceptoPadre
            // 
            this.btnConceptoPadre.Location = new System.Drawing.Point(445, 70);
            this.btnConceptoPadre.Margin = new System.Windows.Forms.Padding(2);
            this.btnConceptoPadre.Name = "btnConceptoPadre";
            this.btnConceptoPadre.Size = new System.Drawing.Size(31, 21);
            this.btnConceptoPadre.TabIndex = 9;
            this.btnConceptoPadre.Text = "...";
            this.btnConceptoPadre.UseVisualStyleBackColor = true;
            // 
            // frmConceptosCategoriasCrud
            // 
            this.ClientSize = new System.Drawing.Size(685, 527);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmConceptosCategoriasCrud";
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
