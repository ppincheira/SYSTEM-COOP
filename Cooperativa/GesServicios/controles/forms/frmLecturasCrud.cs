using AppProcesos.gesServicios.frmLecturasCrud;
using Controles.datos;
using Controles.form;
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
    public partial class frmLecturasCrud : gesForm, IVistaLecturasCrud
    {

        #region << PROPIEDADES >>
        UILecturasCrud _oLecturasCrud;
        Utility oUtil;
        long _sumNumero;
        long _lecSum;
        Enumeration.Acciones _oAccion;
        #endregion

        #region Implementation of IVistaLecturasCrud

        public DateTime dtFechaDesde
        {
            get { return this.dtpFechaDesde.Value; }
            set { this.dtpFechaDesde.Value = value; }
        }

        public DateTime dtFechaHasta
        {
            get { return this.dtpFechaHasta.Value; }
            set { this.dtpFechaHasta.Value = value; }
        }

        public long sumNumero
        {
            get { return _sumNumero; }
            set { _sumNumero = value; }
        }
        public string strSuministro
        {
            get { return this.txtSuministro.Text; }
            set { this.txtSuministro.Text = value; }
        }
        public string strEstado
        {
            get { return this.txtEstado.Text; }
            set { this.txtEstado.Text = value; }
        }
        public string strZona
        {
            get { return this.txtZona.Text; }
            set { this.txtZona.Text = value; }
        }
        public string strCantidadMedidor
        {
            get { return this.txtCantidadMedidores.Text; }
            set { this.txtCantidadMedidores.Text = value; }
        }
        public string strCUIT
        {
            get { return this.txtCUIT.Text; }
            set { this.txtCUIT.Text = value; }
        }
        public string strTitular
        {
            get { return this.txtTitular.Text; }
            set { this.txtTitular.Text = value; }
        }
        public string strPeriodo
        {
            get { return this.mtxtPeriodo.Text; }
            set { this.mtxtPeriodo.Text = value; }
        }
        public string strRuta
        {
            get { return this.txtRuta.Text; }
            set { this.txtRuta.Text = value; }
        }
        public string strNroOrden
        {
            get { return this.txtNroOrden.Text; }
            set { this.txtNroOrden.Text = value; }
        }
        public string strModos
        {
            get { return this.txtModos.Text; }
            set { this.txtModos.Text = value; }
        }
        public string strFechaAlta
        {
            get { return this.txtFechaAlta.Text; }
            set { this.txtFechaAlta.Text = value; }
        }
        public string strCategoria
        {
            get { return this.txtTitular.Text; }
            set { this.txtTitular.Text = value; }
        }




        public string strFecha
        {
            get { return this.txtFecha.Text; }
            set { this.txtFecha.Text = value; }
        }
        public string strRegistrador
        {
            get { return this.txtRegistrador.Text; }
            set { this.txtRegistrador.Text = value; }
        }
        public string strDigitos
        {
            get { return this.txtDigitos.Text; }
            set { this.txtDigitos.Text = value; }
        }
        public string strTipoMedidor
        {
            get { return this.txtTipoMedidor.Text; }
            set { this.txtTipoMedidor.Text = value; }
        }
        public string strDecimal
        {
            get { return this.txtDecimal.Text; }
            set { this.txtDecimal.Text = value; }
        }
        public string strRubro
        {
            get { return this.txtRubro.Text; }
            set { this.txtRubro.Text = value; }
        }

        public string strNroTransaccion
        {
            get { return this.txtNroTransaccion.Text; }
            set { this.txtNroTransaccion.Text = value; }
        }
        public string strConexion
        {
            get { return this.txtConexion.Text; }
            set { this.txtConexion.Text = value; }
        }

        public grdGrillaEdit grdiLecturas
        {
            get { return this.grdLecturas; }
            set { this.grdLecturas = value; }
        }



        public Controles.datos.chkBox chkiTodos
        {
            get { return this.chkTodos; }
            set { this.chkTodos = value; }
        }

        public Controles.datos.chkBox chkiPendiente
        {
            get { return this.chkPendiente; }
            set { this.chkPendiente = value; }
        }
        public Controles.datos.chkBox chkiFacturado
        {
            get { return this.chkFacturado; }
            set { this.chkFacturado = value; }
        }
        public Controles.datos.chkBox chkiInstalado
        {
            get { return this.chkInstalado; }
            set { this.chkInstalado = value; }
        }
        public Controles.datos.chkBox chkiCorregido
        {
            get { return this.chkPendiente; }
            set { this.chkiCorregido = value; }
        }

















        #endregion
        public frmLecturasCrud()
        {

            InitializeComponent();
            _sumNumero = sumNumero;
            if (sumNumero == 0)
                _oAccion = Enumeration.Acciones.New;
            else
                _oAccion = Enumeration.Acciones.Edit;
            _oLecturasCrud = new UILecturasCrud(this);
        }

        private void frmLecturasCrud_Load(object sender, EventArgs e)
        {
            try
            {

                oUtil = new Utility();
                _oLecturasCrud.Inicializar();

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

        private void btnSuministro_Click(object sender, EventArgs e)
        {
            try
            {

                FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
                Admin oAdmin = new Admin();
                oAdmin.TabCodigo = "SUM";
                oAdmin.Tipo = Admin.enumTipoForm.Selector;
                FormsAuxiliares.frmFormAdmin oFrmAdmin = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
                oFrmAdmin.ShowDialog();
                if (oFrmAdmin.ShowDialog() == DialogResult.OK)
                {
                    string id = oFrmAdmin.striRdoCodigo;
                    _sumNumero = long.Parse(id);
                    _oLecturasCrud.CargarLecturaSuministro(_sumNumero);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _oLecturasCrud.Guardar(0);
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

        private void mtxtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void mtxtPeriodo_Leave(object sender, EventArgs e)
        {
            try
            {
                _oLecturasCrud.CargarLecturaAsociada();
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

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _oLecturasCrud.SetChkAll();
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

        private void chkPendiente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _oLecturasCrud.setChkPendiente();
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

        private void chkFacturado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                _oLecturasCrud.setChkFacturado();
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

        private void chkInstalado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _oLecturasCrud.setChkInstalado();
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

        private void chkCorregido_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _oLecturasCrud.setChkCorregido();
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
    }
}
