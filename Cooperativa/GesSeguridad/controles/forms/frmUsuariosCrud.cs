using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppProcesos.gesSeguridad.frmUsuariosCrud;
using Service;
using Controles.datos;
using Controles.form;


namespace GesSeguridad.controles.forms
{
    public partial class frmUsuariosCrud : gesForm, IVistaUsuariosCrud
    {
        #region << PROPIEDADES >>
        UIUsuariosCrud _oUsuariosCrud;
        Utility oUtility;
        int _intUsrNumero;
        string _strAccion;
        #endregion

        #region Implementation of IVistaUsuariosCrud

        public cmbLista cmbPrsNumero
        {
            get { return this.cmbPersona; }
            set { this.cmbPersona = value; }
        }
        public int intUsrNumero
        {
            get { return _intUsrNumero; }
            set { _intUsrNumero = value; }
        }
        public string strUsrNombre
        {
            get { return this.txtNombre.Text; }
            set { this.txtNombre.Text = value; }
        }

        public string strUsrClave
        {
            get { return this.txtClave.Text; }
            set { this.txtClave.Text = value; }
        }

        public cmbLista cmbUsrPerfil
        {
            get { return this.cmbPerfil; }
            set { this.cmbPerfil = value; }
        }

        public DateTime datUsrAlta
        {
            get { return DateTime.Parse(this.dtpFechaAlta.Text); }
            set { this.dtpFechaAlta.Text = value.ToString(); }
        }

        public DateTime datUsrBaja
        {
            get { return DateTime.Parse(this.dtpFechaBaja.Text); }
            set { this.dtpFechaBaja.Text = value.ToString(); }
        }

        public Boolean booUsrBloqueado
        {
            get { return this.chkBloqueado.Checked; }
            set { this.chkBloqueado.Checked = value; }
        }
        public Boolean booUsrEstado
        {
            get { return this.chkEstado.Checked; }
            set { this.chkEstado.Checked = value; }
        }
        #endregion

        #region << EVENTOS >>

        public frmUsuariosCrud(int Codigo, string Accion)
        {
            try
            {
                InitializeComponent();

                _oUsuariosCrud = new UIUsuariosCrud(this);
                _intUsrNumero = Codigo;
                _strAccion = Accion;
                if (_strAccion == "B")
                    if (MessageBox.Show("Desea eliminar El Usuario Código: " + Codigo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _oUsuariosCrud.EliminarUsuario(Codigo);
                        Cursor.Current = Cursors.Default;
                        this.Close();
                    }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "frmUsuariosCrud",
                                "frmUsuariosCrud",
                                this.FindForm().Name);
            }
        }
        private void frmUsuariosCrud_Load(object sender, EventArgs e)
        {
            try
            {
                _oUsuariosCrud.Inicializar();
                oUtility = new Utility();
                this.tttEtiqueta.SetToolTip(this.txtNombre, "Persona al que se le crea el Usuario");
                this.tttEtiqueta.SetToolTip(this.txtNombre, "Nombre del Usuario");
                this.tttEtiqueta.SetToolTip(this.txtClave, "Clave del Usuario");
                this.tttEtiqueta.SetToolTip(this.cmbPerfil, "Perfil del Usuario");
                this.tttEtiqueta.SetToolTip(this.dtpFechaAlta, "Fecha de Alta de la Usuario");
                this.tttEtiqueta.SetToolTip(this.dtpFechaBaja, "Fecha de Baja de la Usuario");
                this.tttEtiqueta.SetToolTip(this.chkBloqueado, "Indica si el Usuario esta Bloqueado");
                this.tttEtiqueta.SetToolTip(this.chkEstado, "Indica si el Usuario esta Habilitado");

                if (_strAccion == "V")
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
                oUtility.ValidarFormularioEP(this, this, 8);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    Cursor.Current = Cursors.WaitCursor;
                    _oUsuariosCrud.Guardar();
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
