using AppProcesos.gesServicios.frmLecturasModosCrud;
using Business;
using Controles.datos;
using Controles.form;
using FormsAuxiliares;
using Model;
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
    public partial class frmLecturasModosCrud : gesForm, IVistaLecturasModosCrud
    {
        private long _LEMCodigo;
        private int _USRCodigo;
        private Utility oUtil;
        private UILecturasModosCrud _oLecturasModosCrud;
        private string _EstCodigo;
        public FuncionalidadesFoms _oFuncionalidad;


        public long lemCodigo { get { return this._LEMCodigo; } set { this._LEMCodigo = value; } }
        public string lemDescripcion { get { return this.txtLEMDescripcion.Text; } set { this.txtLEMDescripcion.Text = value; } }
        public DateTime lemFechaCarga { get { return this.dtpFechaAlta.Value; } set { this.dtpFechaAlta.Value = value; } }
        public cmbLista srvCodigo { get { return this.cmbSRVCodigo; } set { this.cmbSRVCodigo = value; } }
        public int usrCodigo { get { return _USRCodigo; } set { this._USRCodigo = value; } }
        public string estCodigo { get { return this.chkESTCodigo.Checked ? "H" : "I"; } set { this.chkESTCodigo.Checked = (value == "H"); } }
        public grdGrillaEdit grdiLecturasConceptos { get { return this.grdLecturasConceptos; } set { this.grdLecturasConceptos = value; } }

        public frmLecturasModosCrud()
        {
            InitializeComponent();
        }

        public frmLecturasModosCrud(long NumeroLectura, string estado)
        {
            try
            {
                _LEMCodigo = NumeroLectura;
                _EstCodigo = estado;
                _oLecturasModosCrud = new UILecturasModosCrud(this);
                InitializeComponent();
                //if (grdiLecturasConceptos.Rows.Count == 0)
                //    grdiLecturasConceptos.Rows.Add();
                if (estado == "B")
                    if (MessageBox.Show("Desea eliminar el Modelo de Lectura: " + NumeroLectura + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _oLecturasModosCrud.EliminarModoLectura(NumeroLectura);
                        this.Close();
                    }
              
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.VALIDARFORM = true;
                oUtil.ValidarFormulario(this, this, 10);
                validar();
                _USRCodigo = 1;
                //      this.srvCodigo = (int)((DataRowView)this.cmbSRVCodigo.SelectedItem).Row.ItemArray[0];

                if (this.chkESTCodigo.Checked == true)
                {
                    this._EstCodigo = "H";
                }
                else
                    this._EstCodigo = "I";
                //               oUtil.ValidarFormulario(this, this, 3);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oLecturasModosCrud.Guardar();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Faltan Campos por cargar", "Cooperativa");
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

        private void validar()
        {
            if (this.txtLEMDescripcion.Text == "")
            {
                this.VALIDARFORM = false;
            }
            if (this.cmbSRVCodigo.SelectedValue.ToString() == "0")
            {
                this.VALIDARFORM = false;
            }
        }



  

        private void grdLecturasConceptos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try

           {
                string valorCelda = (string)(((grdGrillaEdit)sender).SelectedCells[0].Value);
                string valorCampo="0";
                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
                Admin oAdmin = new Admin();
                oAdmin.TabCodigo = "LEC";
                string strSelector= _oLecturasModosCrud.CargarGrillaConceptos(valorCelda, e.ColumnIndex);
                switch (strSelector)
                {
                    case "0":
                        oAdmin.Tipo = Admin.enumTipoForm.Selector;
                        break;
                    case "2":
                        oAdmin.Tipo = Admin.enumTipoForm.Selector;
                        break;
                    case "3":
                        oAdmin.Tipo = Admin.enumTipoForm.Selector;
                        break;
                }
                oAdmin.FiltroValores = valorCelda;
                switch (e.ColumnIndex)
                {
                        case 0:
                                valorCampo = "LEC_CODIGO";
                                break;
                        case 1:
                                valorCampo = "LEC_DESCRIPCION_CORTA";
                                break;
                        case 2:
                                valorCampo = "LEC_DESCRIPCION";
                                break;
                }
                oAdmin.FiltroCampos = valorCampo;
                oAdmin.FiltroOperador = "7";
                if (strSelector!="1")
                {
                    frmFormAdminMini frmbus = new frmFormAdminMini(oAdmin, oPermiso);
                    if (frmbus.ShowDialog() == DialogResult.OK)
                    {
                        string id = frmbus.striRdoCodigo;
                        LecturasConceptosBus oLecturasConceptosBus = new LecturasConceptosBus();
                        LecturasConceptos oLecturaConcepto = oLecturasConceptosBus.LecturasConceptosGetById(long.Parse(id));
                        _oLecturasModosCrud.CargarGrilla(oLecturaConcepto, e.RowIndex);
                    }
                }

                //Si retorna mas de un resultado se tiene que poder elegir entre las opciones
                //de dejar la columna NUMERO se tiene que mostrar todos las lecturas conceptos 
                //para que se peuda selecionar la que se desea 
                //Una vez agregada una se guardan las referencias y se tiene que agregar una fila para poder 
                //agregar otro concepto de ser necesario
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void bloquearFecha()
        {
            this.dtpFechaAlta.Enabled = false;
        }

        private void frmLecturasModosCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oLecturasModosCrud.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void grdLecturasConceptos_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
