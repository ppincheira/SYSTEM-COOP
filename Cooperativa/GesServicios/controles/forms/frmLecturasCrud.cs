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
    public partial class frmLecturasCrud : gesForm,IVistaLecturasCrud
    {

        #region << PROPIEDADES >>
        UILecturasCrud _oLecturasCrud;
        Utility oUtil;
        long _sumNumero;
        Enumeration.Acciones _Accion;
        #endregion

        #region Implementation of IVistaLecturasCrud

        public long sumNumero
        {
            get { return _sumNumero; }
            set { _sumNumero = value;}
        }
        public string strSuministro
        {
            get { return this.txtSuministro.Text; }
            set { this.txtSuministro.Text = value; }
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

        public string strNroSuministro
        {
            get { return this.txtNroSuministro.Text; }
            set { this.txtNroSuministro.Text = value; }
        }
        public string strFechaAlta
        {
            get { return this.txtFechaAlta.Text; }
            set { this.txtFechaAlta.Text = value; }
        }

        public string strCategoria
        {
            get { return this.txtCategortia.Text; }
            set { this.txtCategortia.Text = value; }
        }
        public string strTitular
        {
            get { return this.txtTitular.Text; }
            set { this.txtTitular.Text = value; }
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
        public grdGrillaEdit grdiLecturas
        {
            get { return this.grdiLecturas; }
            set { this.grdiLecturas = value; }
        }

        #endregion
        public frmLecturasCrud(long sumNumero)
        {
            InitializeComponent();
            _sumNumero = sumNumero;
            if (sumNumero == 0)
                _Accion = Enumeration.Acciones.New;
            else
                _Accion = Enumeration.Acciones.Edit;
            _oLecturasCrud = new UILecturasCrud(this);
        }

        private void frmLecturasCrud_Load(object sender, EventArgs e)
        {
            oUtil = new Utility();
            _oLecturasCrud.Inicializar(_sumNumero);
            
        }
    }
}
