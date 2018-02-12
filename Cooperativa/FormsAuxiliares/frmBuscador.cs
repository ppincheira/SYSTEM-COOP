using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
using Model;
using System.Globalization;
using AppProcesos.formsAuxiliares.buscador;
using Controles.datos;
using Controles.contenedores;
using Controles.form;
namespace FormsAuxiliares
{
    public partial class frmBuscador : gesForm, IVistaBuscador
    {

        private UIBuscador _oBuscador;
        #region << PROPIEDADES >>
        private string _Tabla;
        #endregion
        #region Implementation of IVistaBuscador
        public Boolean grupoEstado
        {
            get { return this.gpbGrupoEstado.Visible; }
            set { this.gpbGrupoEstado.Visible = value; }
        }
        public Boolean grupoFecha
        {
            get { return this.gpbGrupoFecha.Visible; }
            set { this.gpbGrupoFecha.Visible = value; }
        }

        public grdGrillaAdmin grilla
        {
            get { return this.dgBusqueda; }
            set { this.dgBusqueda = value; }
        }
        public DateTime fechaDesde
        {
            get { return this.dtpFechaDesde.Value; }
            set { this.dtpFechaDesde.Value = value; }
        }
        public DateTime fechaHasta
        {
            get { return this.dtpFechaHasta.Value; }
            set { this.dtpFechaHasta.Value = value; }
        }
        public  cmbLista comboBuscar
        {
            get { return this.cmbBuscar; }
            set { this.cmbBuscar = value; }
        }
        public string filtro
        {
            get { return this.txtFiltro.Text; }
            set { this.txtFiltro.Text = value; }
        }
        public cmbLista comboEstado
        {
            get { return this.cmbEstado; }
            set { this.cmbEstado = value; }
        }
        public string cantidad
        {
        
            set { this.lblCantidad.Text = value; }
        }

        #endregion
        #region << EVENTOS >>

        public frmBuscador(string tabla)
        {
            _Tabla = tabla;
            InitializeComponent();
            _oBuscador = new UIBuscador(this);
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _oBuscador.CargarGrilla(_Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
         private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _oBuscador.CargarGrilla(_Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _oBuscador.CargarGrilla(_Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _oBuscador.CargarGrilla(_Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            try {

                _oBuscador.Inicializar(_Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void gbBusqueda_Enter(object sender, EventArgs e)
        {

        }
    }







}
