using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
using Model;
using Controles.form;

namespace FormsAuxiliares
{
    public partial class frmABM : gesForm
    {

        #region << PROPIEDADES >>
        private string _Tabla;
        #endregion

        public frmABM(string clave)
        {
            _Tabla = clave;
            InitializeComponent();
        }

        private void frmABM_Load(object sender, EventArgs e)
        {

            Inicializar();
        }


        private void Inicializar()
        {
            int x = 120;
            int y = 40;
            DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
            List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(_Tabla);
            foreach (DetallesColumnasTablas oDetalle in ListDetalle)
            {

                Label lblELabel = new System.Windows.Forms.Label();
                lblELabel.Location = new System.Drawing.Point(x-100, y);
                lblELabel.Name = "lblE" + oDetalle.DctColumna;
                lblELabel.Size = new System.Drawing.Size(88, 21);
                lblELabel.TabIndex = 0;
                lblELabel.Text = oDetalle.DctDescripcion + ":";
                Controls.Add(lblELabel);

                if (oDetalle.DctTipoControl == "TEXTO") {
                


                    TextBox txtTexto = new System.Windows.Forms.TextBox();
                    txtTexto.Location = new System.Drawing.Point(x, y);
                    txtTexto.Name = "txt"+oDetalle.DctColumna;
                    txtTexto.Size = new System.Drawing.Size(88, 21);
                    txtTexto.TabIndex = 0;
                    txtTexto.Text = "";
                    Controls.Add(txtTexto);
                }

                if (oDetalle.DctTipoControl == "LABEL")
                {

                    Label lblLabel = new System.Windows.Forms.Label();
                    lblLabel.Location = new System.Drawing.Point(x, y);
                    lblLabel.Name = "txt" + oDetalle.DctColumna;
                    lblLabel.Size = new System.Drawing.Size(88, 21);
                    lblLabel.TabIndex = 0;
                    lblLabel.Text = "";
                    Controls.Add(lblLabel);
                }


                if (oDetalle.DctTipoControl == "COMBO")
                {

                    ComboBox cmbCombo = new System.Windows.Forms.ComboBox();
                    cmbCombo.Location = new System.Drawing.Point(x, y);
                    cmbCombo.Name = "cmb" + oDetalle.DctColumna;
                    cmbCombo.Size = new System.Drawing.Size(88, 21);
                    cmbCombo.TabIndex = 0;
                    Controls.Add(cmbCombo);
                }


                if (oDetalle.DctTipoControl == "FECHA")
                {
                    DateTimePicker dtpDate = new System.Windows.Forms.DateTimePicker();
                    dtpDate.Location = new System.Drawing.Point(x, y);
                    dtpDate.Name = "dtp" + oDetalle.DctColumna;
                    dtpDate.Size = new System.Drawing.Size(88, 21);
                    dtpDate.TabIndex = 0;
                    Controls.Add(dtpDate);
                }

                y += 70;



            }

            Button btnBotonGuardar = new System.Windows.Forms.Button();
            btnBotonGuardar.Location = new System.Drawing.Point(x, y);
            btnBotonGuardar.Name = "btnGuardar" ;
            btnBotonGuardar.Size = new System.Drawing.Size(80, 30);
            btnBotonGuardar.Text = "Guardar";
            btnBotonGuardar.TabIndex = 0;
            Controls.Add(btnBotonGuardar);

            Button btnBotonCancelar = new System.Windows.Forms.Button();
            btnBotonCancelar.Location = new System.Drawing.Point(x+100, y );
            btnBotonCancelar.Name = "btnCancelar";
            btnBotonCancelar.Text = "&Cancelar";
            btnBotonCancelar.Size = new System.Drawing.Size(80, 30);
            btnBotonCancelar.TabIndex = 0;
            Controls.Add(btnBotonCancelar);

        }
    }
}
