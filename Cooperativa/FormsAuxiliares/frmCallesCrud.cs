using AppProcesos.formsAuxiliares.frmCalles;
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
    public partial class frmCallesCrud : gesForm, IVistaCallesCrud
    {

        #region << PROPIEDADES >>
        UICallesCrud _oCallesCrud;
        Utility oUtil;
        long _codigo;
        string _codigoProvincia;
    
        #endregion
        public frmCallesCrud(long codigo, string codigoProvincia)
        {
            try { 
            InitializeComponent();
            _codigo = codigo;
            _codigoProvincia = codigoProvincia;
            _oCallesCrud = new UICallesCrud(this);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }


        #region Implementation of IVistaCallesCrud


        public long codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string codigoProvincia
        {
            get { return _codigoProvincia; }
            set { _codigoProvincia = value; }
        }

        public string txtDescripcion
        {
            get { return this.txtDescripcionCorta.Text; }
            set { this.txtDescripcionCorta.Text =  value; }
        }
        public cmbLista cmbLocalidad
        {
            get { return this.cmbLista; }
            set { this.cmbLista= value; }
        }

        #endregion
        #region << EVENTOS >>
        private void frmCallesCrud_Load(object sender, EventArgs e)
        {
            try {
                oUtil = new Utility();
                _oCallesCrud.Inicializar();
                this.txtDescripcionCorta.REQUERIDO = "SI";
                this.cmbLista.REQUERIDO = "SI";
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
                    _oCallesCrud.Guardar();

                    this.Close();
                }
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
        private void gesGroup2_Enter(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
