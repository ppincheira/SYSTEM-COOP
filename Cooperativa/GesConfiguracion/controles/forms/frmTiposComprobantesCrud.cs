using AppProcesos.gesConfiguracion;
using AppProcesos.gesConfiguracion.frmTiposComprobantesCrud;
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

namespace GesConfiguracion
{
    public partial class frmTiposComprobantesCrud : gesForm, IVistaTiposComprobantesCrud
    {
        private Utility oUtil;
        private UITiposComprobantesCrud _oTiposComprobantes;
        private long _USRCodigo;


        public string editar = "NO";


        public frmTiposComprobantesCrud()
        {
            InitializeComponent();
        }

        public string tcoCodigo { get { return this.txtTCOcodigo.Text; } set { this.txtTCOcodigo.Text = value; } }
        public string tcoDescripcion { get { return this.txtDescripcion.Text; } set { this.txtDescripcion.Text = value; } }
        public string tcoLetra { get { return this.txtTCOletra.Text; } set { this.txtTCOletra.Text = value; } }
        public string tcoOrigenNumerado { get { return this.txtTCoorigenNumerado.Text; } set { this.txtTCoorigenNumerado.Text = value; } }
        public string tcoExterno { get { return this.chkTCOExterno.Checked ? "S" : "N"; } set { if (value == "S") this.chkTCOExterno.Checked = true; else if (value == "N") this.chkTCOExterno.Checked = false; } }
        public int tcoCantidadCopias { get { return int.Parse(this.txtTCOCantidadCopias.Text); } set { this.txtTCOCantidadCopias.Text = value.ToString(); } }
        public string pcbCodigo { get { return this.txtPCBCodigo.Text; } set { this.txtPCBCodigo.Text = value; } }
        public string tcoCodigoAfip { get { return this.txtCodigoAfip.Text; } set { this.txtCodigoAfip.Text = value; } }
        public string tcoLibroIvaCompras { get { return this.chkLibroIvaCompra.Checked ? "S" : "N"; } set { if (value == "S") this.chkLibroIvaCompra.Checked = true; else if (value == "N") this.chkLibroIvaCompra.Checked = false; } }
        public string tcoLibroIvaVentas { get { return this.chkLibroIvaVenta.Checked ? "S" : "N"; } set { if (value == "N") this.chkLibroIvaVenta.Checked = true; else if (value == "N") this.chkLibroIvaVenta.Checked = false; } }
        public string tcoCodigoSicore { get { return this.txtCodigoSicore.Text; } set { this.txtCodigoSicore.Text = value; } }
        public int tcmCantMinImpresion { get { return int.Parse(this.txtCantMinImpreciones.Text); } set { this.txtCantMinImpreciones.Text = value.ToString(); } }
        public string tcoPreimpreso { get { return this.chkPreimpreso.Checked ? "S" : "N"; } set { if (value == "N") this.chkPreimpreso.Checked = true; else if (value == "N") this.chkPreimpreso.Checked = false; } }
        public string tcoCodigoRece { get { return this.txtCodigoRece.Text; } set { this.txtCodigoRece.Text = value; } }
        public string estCodigo { get { return this.chkEstado.Checked ? "H" : "I"; } set { if (value == "H") this.chkEstado.Checked = true; else if (value == "I") this.chkEstado.Checked = false; } }
   
        string IVistaTiposComprobantesCrud.editar { get {return this.editar; } set {this.editar= value; } }

        //public int cbpCodigo { get { return int.Parse(this.txtPCBCodigo.Text); } set { this.txtTCOcodigo.Text = value.ToString(); } }

        public frmTiposComprobantesCrud(string id, string estado)
        {
            try
            {
                InitializeComponent();
                this.txtTCOcodigo.Text = id;
                this.estCodigo = estado;
                _oTiposComprobantes = new UITiposComprobantesCrud(this);                
                if (estado == "B")
                    if (MessageBox.Show("Desea eliminar el Tipo de comprobantea: " + id + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _oTiposComprobantes.EliminarTipoComprobante(id);
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
                validar();
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oTiposComprobantes.Guardar();
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
            this.VALIDARFORM = true;
        }

        private void frmTiposComprobantesCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oTiposComprobantes.Inicializar();
                //Por alguna razon este InitializeComponent hacia desastres en 
                //el comportamiento del formulario
                //            InitializeComponent();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
