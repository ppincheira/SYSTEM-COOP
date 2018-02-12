using AppProcesos.formsAuxiliares.frmCodigoPostal;
using Controles.datos;
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

namespace FormsAuxiliares
{
    public partial class frmCodigoPostalCrud : gesForm, IVistaCodigoPostalCrud
    {

        #region << PROPIEDADES >>

        UICodigoPostalCrud _oCodPostalCrud;
        Utility oUtil;
        string _codigoProvincia;
        long _cplNumero;




        #endregion

        #region Implementation of IVistaCallesCrud


        public long cplNumero
        {
            get { return _cplNumero; }
            set { _cplNumero = value; }
        }
        public string codigoProvincia
        {
            get { return _codigoProvincia; }
            set { _codigoProvincia = value; }
        }

        public string txtiDescripcion
        {
            get { return this.txtDescripcion.Text; }
            set { this.txtDescripcion.Text = value; }
        }

        
        public string txtiCodigoPostal
        {
            get { return this.txtCodigoPostal.Text; }
            set { this.txtCodigoPostal.Text = value; }
        }

        public cmbLista cmbiLocalidad
        {
            get { return this.cmbLocalidad; }
            set { this.cmbLocalidad = value; }
        }

        #endregion

        #region << EVENTOS >>
        public frmCodigoPostalCrud(long cplNumero, string codigoProvincia)
        {
            InitializeComponent();
            _cplNumero = cplNumero;
            _codigoProvincia = codigoProvincia;
            _oCodPostalCrud = new UICodigoPostalCrud(this);
        }

        private void frmCodigoPostalCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oCodPostalCrud.Inicializar();
                this.txtDescripcion.REQUERIDO = "SI";
                this.txtCodigoPostal.REQUERIDO = "SI";
                this.cmbLocalidad.REQUERIDO = "SI";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormulario(this, this, 5);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oCodPostalCrud.Guardar();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }

        }
        #endregion
    }
}
