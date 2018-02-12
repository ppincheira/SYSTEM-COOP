using AppProcesos.formsAuxiliares.frmObservaciones;
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
using Controles.form;
using Model;

namespace FormsAuxiliares
{

    public partial class frmObservacionesCrud : gesForm, IVistaObservacionesCrud
    {
        #region << PROPIEDADES >>
        UIObservacionesCrud _oObservacionCrud;
        Utility oUtil;

        long _Codigo;
        int _TipoObservaciones;
        string _CodigoRegistro;
        Adjuntos _Adjunto;
        string _Accion;
        AdminObs _oAdmin;

        #endregion

        #region Implementation of IVistaObservaciones


        public long codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        public int tipoObservaciones
        {
            get { return _TipoObservaciones; }
            set { _TipoObservaciones = value; }
        }

        public string codigoRegistro
        {
            get { return _CodigoRegistro; }
            set { _CodigoRegistro = value; }
        }
        public DateTime fecha
        {
            get { return this.dtpFecha.Value; }
            set { this.dtpFecha.Value = value; }
        }

        public string detalle
        {
            get { return this.txtDetalle.Text; }
            set { this.txtDetalle.Text = value; }
        }

        public Adjuntos adjunto
        {
            get { return _Adjunto; }
            set { _Adjunto = value; }
        }

        public string adjuntoFileName
        {
            get { return this.txtDescripcionPath.Text; }
            set { this.txtDescripcionPath.Text = value; }
        }
        public Boolean obsDefecto
        {
            get { return this.chkPorDefecto.Checked; }
            set { this.chkPorDefecto.Checked = value; }
        }

        #endregion

        #region << EVENTOS >>
        public frmObservacionesCrud(long Codigo,AdminObs oAdmin, string Accion)
        {

            try
            {
                InitializeComponent();
                _oObservacionCrud = new UIObservacionesCrud(this);
                _Codigo = Codigo;
                _TipoObservaciones = oAdmin.TobCodigo;
                _CodigoRegistro = oAdmin.CodigoRegistro;
                _Accion = Accion;
                _oAdmin = oAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void frmObservacionesCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oObservacionCrud.Inicializar();
                this.dtpFecha.REQUERIDO = "SI";
                this.txtDetalle.REQUERIDO = "SI";
                
                if (_Adjunto==null || _Adjunto.AdjCodigo == 0)
                    this.btnVer.Enabled = false;
                if (_Accion == "V")
                    this.gbDatos.Enabled = false;

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
               // oUtil.ValidarFormulario(this, this, 5);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oObservacionCrud.Guardar(_oAdmin);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _oObservacionCrud.AgregarImagen();
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            try { 
            _oObservacionCrud.Mostrar();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
}

        #endregion


    }
}