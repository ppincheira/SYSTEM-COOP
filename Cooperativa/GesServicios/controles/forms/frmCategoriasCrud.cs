using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controles.form;
using AppProcesos.gesServicios.frmCategoriasCrud;
using Service;
using Controles.datos;

namespace GesServicios.controles.forms
{
    public partial class frmCategoriasCrud : gesForm, IVistaCategoriasCrud
    {
        #region << PROPIEDADES >>
        UICategoriasCrud _oCategoriasCrud;
        Utility oUtility;
        long    _ScaNumero;             
        string  _Accion;
        long    _GrdCodigo;
        string  _GrdCodigoRegistro;

        #endregion
        #region Implementation of IVistaCategoriasCrud


        public long scaNumero
        {
            get { return _ScaNumero; }
            set { _ScaNumero = value; }
        }
        public string Descripcion
        {
            get { return this.txtDescripcion.Text; }
            set { this.txtDescripcion.Text = value; }
        }

        public string DescripcionCorta
        {
            get { return this.txtDescripcionCorta.Text; }
            set { this.txtDescripcionCorta.Text = value; }
        }

        public Boolean estCodigo
        {
            get { return this.chkHabilitado.Checked; }
            set { this.chkHabilitado.Checked = value; }
        }        

        public cmbLista srvCodigo
        {
            get { return this.cmbServicio; }
            set { this.cmbServicio = value; }
        }
        public cmbLista Grupo
        {
            get { return this.cmbGrupo; }
            set { this.cmbGrupo = value; }
        }
        public string grdCodigoRegistro
        {
            get { return _GrdCodigoRegistro; }
            set { _GrdCodigoRegistro = value; }
        }
        public long grdCodigo
        {
            get { return _GrdCodigo; }
            set { _GrdCodigo = value; }
        }
        #endregion

        #region << EVENTOS >>

        public frmCategoriasCrud(long Codigo,  string Accion)
        {
          try
            {
            InitializeComponent();

            _oCategoriasCrud = new UICategoriasCrud(this);
            _ScaNumero = Codigo;            
            _Accion = Accion;
            if (Accion == "B")
                if (MessageBox.Show("Desea eliminar La Categoria Código: " + Codigo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oCategoriasCrud.EliminarCategoria(Codigo);
                    Cursor.Current = Cursors.Default;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "frmCategoriasCrud",
                                "frmCategoriasCrud",
                                this.FindForm().Name);
            }
        }
        private void frmCategoriasCrud_Load(object sender, EventArgs e)
        {
            try
            {
                _oCategoriasCrud.Inicializar();
                oUtility = new Utility();

                this.tttEtiqueta.SetToolTip(this.txtDescripcion, "Descripcion de la Categoria");
                this.tttEtiqueta.SetToolTip(this.txtDescripcionCorta, "Abreviaura de la Categoria");
                this.tttEtiqueta.SetToolTip(this.cmbServicio, "Servicio de la Categoria");
                this.tttEtiqueta.SetToolTip(this.chkHabilitado, "Indica si esta Habilitada la Categoria");
                this.tttEtiqueta.SetToolTip(this.cmbGrupo, "Tipo de Grupo");                

                if (_Accion == "V")
                {
                    this.gbDatos.Enabled = false;
                    this.btnAceptar.Enabled = false;
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
                    this.VALIDARFORM = true;
                    //Console.WriteLine("ValidarFormulario  " + this.VALIDARFORM);
                    oUtility.ValidarFormularioEP(this, this, 4);
                    //Console.WriteLine("ValidarFormulario  " + this.VALIDARFORM);
                    if (this.VALIDARFORM)
                    {
                        DialogResult = DialogResult.OK;
                        Cursor.Current = Cursors.WaitCursor;
                        _oCategoriasCrud.Guardar();
                        Cursor.Current = Cursors.Default;
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
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
