using AppProcesos.gesServicios.frmMedidoresCrud;
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


namespace GesServicios.controles.forms
{
    public partial class frmTiposMedidoresCrud : gesForm, IVistaTiposMedidoresCrud
    {
        #region << PROPIEDADES >>
            UITiposMedidoresCrud _oMedidoresTipoCrud;
            Utility oUtil;
            int _UsrNumero;
            long _TmeCodigo;
            string _EstCodigo;

            public long tmeCodigo { get { return this._TmeCodigo; } set {this._TmeCodigo = value; } }
            public string tmeDescripcion { get {return this.txtTMEDescripcion.Text; } set {this.txtTMEDescripcion.Text = value; } }
            public string tmeDescripcionCorta { get { return this.txtTMEDescripcionCorta.Text; } set { this.txtTMEDescripcionCorta.Text = value; } }
            public DateTime tmeFechaCarga { get {return this.dtpFechaCarga.Value; } set {this.dtpFechaCarga.Value = value; } }
            public cmbLista srvCodigo { get {return this.cmbSRVCodigo; } set {this.cmbSRVCodigo = value; } }
            public int usrNumero { get {return this._UsrNumero; } set {this._UsrNumero = value; } }
            public string estCodigo { get { return this._EstCodigo;} set { this._EstCodigo = value;}
        }
        #endregion

        public frmTiposMedidoresCrud(long SMedidorTipo, string Estado)
        {
            _TmeCodigo = SMedidorTipo;
            _EstCodigo = Estado;
            _oMedidoresTipoCrud = new UITiposMedidoresCrud(this);
            InitializeComponent();
            if (this._EstCodigo == "H")
            {
                this.chkEstado.Checked = true;
            }
            else
            if (this._EstCodigo == "I")
            {
                this.chkEstado.Checked = false;
            }


            if (Estado == "B")
                if (MessageBox.Show("Desea eliminar El Tipo de Medidor Código: " + SMedidorTipo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oMedidoresTipoCrud.EliminarMedidor(_TmeCodigo);
                    this.Close();
                }

        }

        private void frmTiposMedidoresCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oMedidoresTipoCrud.Inicializar();
                this.txtTMEDescripcion.REQUERIDO = "SI";
                this.txtTMEDescripcionCorta.REQUERIDO = "SI";
                this.dtpFechaCarga.REQUERIDO = "SI";
                this.cmbSRVCodigo.REQUERIDO = "SI";
                this.chkEstado.REQUERIDO = "SI";
            }
            catch(Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }     


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                usrNumero = 1;
                if (this.chkEstado.Checked == true)
                {
                    this._EstCodigo = "H";
                }
                else
                    this._EstCodigo = "I";
 //               oUtil.ValidarFormulario(this, this, 3);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oMedidoresTipoCrud.Guardar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
             
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
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEstado.Checked)
            {
                this._EstCodigo = "H";
            }
            else
            {
                this._EstCodigo = "I";
            }

        }
        public void bloquearFecha()
        {
            this.dtpFechaCarga.Enabled = false;
        }
    }
}
