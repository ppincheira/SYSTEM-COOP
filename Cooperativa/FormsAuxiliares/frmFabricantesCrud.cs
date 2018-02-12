using AppProcesos.formsAuxiliares.frmFabricantesCrud;
using Controles.datos;
using Controles.Fecha;
using Controles.form;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesServicios.controles.forms
{
    public partial class frmFabricantesCrud : gesForm, IVistaFabricantesCrud
    {

        #region << PROPIEDADES >>
            UIFabricantesCrud _oFabricantesCrud;
            Utility oUtil;
            long _fabNumero;
            int _usrNumero;
        #endregion

        #region Implementacion de Interface
            public long fabNumero{ get { return this._fabNumero; }set { this._fabNumero = value; } }
            public string fabDescripcion { get { return this.txtDescripcion.Text; } set { this.txtDescripcion.Text = value; } }
            public chkBox fabHabilitado { get { return this.chkHabilitado; } set {this.chkHabilitado = value; } }
            public cmbLista empNumero { get { return this.cmbEMPNumero; } set { this.cmbEMPNumero = value; } }
            public dtpFecha fabFechaCarga { get { return this.dtpFechaCarga; } set { this.dtpFechaCarga = value; } }
            public int usrNumero { get { return this._usrNumero; } set { this._usrNumero = value; } }
        #endregion


        
        public frmFabricantesCrud(long numero, string Estado)
        {
            try
            {
            InitializeComponent();
            this._fabNumero = numero;      
            if(Estado == "H")
            {
                    this.chkHabilitado.Checked = true ;
            } 
            else
                    if (Estado == "I")
                {
                    this.chkHabilitado.Checked = false;
                }
                    _oFabricantesCrud = new UIFabricantesCrud(this);
                if (Estado == "B")
                    if (MessageBox.Show("Desea eliminar El Tipo de Medidor Código: " + _fabNumero + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _oFabricantesCrud.Eliminar(_fabNumero);
                        this.Close();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void frmFabricantesCrud_Load(object sender, EventArgs e)
        {

            try
            {
                oUtil = new Utility();
                _oFabricantesCrud.Inicializar();
                this.txtDescripcion.REQUERIDO = "SI";
                this.cmbEMPNumero.REQUERIDO = "SI";
                this.dtpFechaCarga.REQUERIDO = "SI";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {

                this.VALIDARFORM = true;
                //SAQUE EL VALIDAR HASTA QUE SE SOLUCIONE UN PROBLEMA DEL VALIDAR DONDE EL DTP SE LO QUIERE TOMAR COMO TXTDESCRIPCIONCORTA
                //oUtil.ValidarFormulario(this, this, 4);

                bool control = this.chkHabilitado.Checked;
               


                if (this.VALIDARFORM)

                {
                    DialogResult = DialogResult.OK;
                    _oFabricantesCrud.Guardar();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        public void bloquearFecha()
        {
            this.dtpFechaCarga.Enabled = false;
        }
    }
}
