
using AppProcesos.formsAuxiliares.frmMiniListado;
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
    public partial class frmMiniListado : gesForm, IVistaMiniListado
    {
        
        #region << PROPIEDADES >>

        UIMiniListado _oMiniListado;
        Utility oUtil;
        string _tabCodigo;
        string _codigoRegistro;
    
        #endregion

        #region << Implementation of IVistaMiniListado >>
        public grdGrillaAdmin gviListado
        {
            get { return this.gvListado; }
            set { this.gvListado= value; }
        }
        public string filtro
        {
            get { return this.txtFiltro.Text; }
            set { this.txtFiltro.Text = value; }
        }
        public string cantidad
        {
            set { this.lblCantidad.Text = value; }
        }
        public string tabCodigo
        {
            get { return _tabCodigo; }
            set { _tabCodigo = value; }
        }
        public string codigoRegistro
        {
            get { return _codigoRegistro; }
            set { _codigoRegistro = value; }
        }

        #endregion
        public frmMiniListado(string tabCodigo, string codigoRegistro)
        {
            InitializeComponent();
            _oMiniListado = new UIMiniListado(this);
            _tabCodigo = tabCodigo;
            _codigoRegistro = codigoRegistro;
        }

        private void frmMiniListado_Load(object sender, EventArgs e)
        {
            _oMiniListado.Inicializar();
        }
    }
}
