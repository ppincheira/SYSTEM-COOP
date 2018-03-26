using AppProcesos.formsAuxiliares.frmCrudGrilla;
using Controles.datos;
using Controles.form;
using Controles.labels;
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

namespace FormsAuxiliares
{
    public partial class frmDobleGrillaCrud : gesForm, IVistaDobleGrillaCrud
    {
        UIDobleGrillaCrud oDobleGrilla;
        private bool cambiosPendientes = false;

        #region PROPIEDADES       
        public grdGrillaEdit grillaPrimaria { get { return this.GrillaPrimaria; } set { this.GrillaPrimaria = value; } }
        public grdGrillaEdit grillaSecundaria { get { return this.GrillaSecundaria; } set { this.GrillaSecundaria = value; } }
        public string filtro1 { get { return this.txtFiltroPrimario.Text; } set { this.txtFiltroPrimario.Text = value; } }
        public string filtro2 { get { return this.txtFiltroSecundario.Text; } set { this.txtFiltroSecundario.Text = value; } }
        public string cantidadPrimaria { get { return this.lblCantidadPrimaria.Text; } set { this.lblCantidadPrimaria.Text = value; } }
        public string cantidadSecundaria { get { return this.lblCantidadSecundaria.Text; } set { this.lblCantidadSecundaria.Text = value; } }
        lblEtiqueta IVistaDobleGrillaCrud.lblEtiqueta1 { get { return this.lblFiltroEtiqueta1; } set { this.lblFiltroEtiqueta1 = value; } }
        lblEtiqueta IVistaDobleGrillaCrud.lblEtiqueta2 { get { return this.lblFiltroEtiqueta2; } set { this.lblFiltroEtiqueta2 = value; } }

        public cmbLista busquedaPrimaria { get { return this.cmbBoxCamposPrimario; } set { this.cmbBoxCamposPrimario = value; } }
        public cmbLista busquedaSecundaria { get { return this.cmbBoxCampoSecundario; } set { this.cmbBoxCampoSecundario = value; } }
        #endregion


        public frmDobleGrillaCrud(string tabla1, string tabla2, string tablaNexo, string campoClave1, string campoClave2)
        {
            InitializeComponent();
            oDobleGrilla = new UIDobleGrillaCrud(this);

            grillaPrimaria.MultiSelect = false;
            grillaPrimaria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            GrillaSecundaria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            oDobleGrilla.Inicializar(tabla1, tabla2, tablaNexo, campoClave1, campoClave2);

        }
        private void frmRolesCrud_Load(object sender, EventArgs e)
        {
            oDobleGrilla.CargarGrillaSecundaria();
            if (GrillaPrimaria.SelectedRows == null)
            {
                string auxy = GrillaPrimaria.SelectedRows[0].Cells[0].ToString();        
            }

        }

        private void GrillaPrimaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cambiosPendientes)
            {
                if (MessageBox.Show("¿Estas por perder los cambios, desea guardarlos?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)

                    oDobleGrilla.Guardar();
                cambiosPendientes = false;
            }          
      //      string auxy = ((grdGrillaEdit)sender).SelectedRows[0].Cells[0].FormattedValue.ToString();
            oDobleGrilla.CargarGrillaSecundaria();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "FUN";
            oAdmin.Tipo = Admin.enumTipoForm.SelectorMultiSeleccion;
            frmFormAdmin frmbus = new frmFormAdmin(oAdmin, oPermiso);

            frmbus.ShowDialog();
            String recuperado = frmbus._strDatosSeleccionados;
            if (recuperado != null && recuperado.Length > 0)
            {
                recuperado = recuperado.Substring(0, recuperado.Length - 1);
                oDobleGrilla.agregarRegistros(recuperado);
                cambiosPendientes = true;
            }

        }

        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            oDobleGrilla.Guardar();
            this.Close();
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Confirma que desea quitar estos registros?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                oDobleGrilla.Eliminar();
                cambiosPendientes = true;
            }
        }

        private void txtFiltroPrimario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                oDobleGrilla.CargarGrilla("1");
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
