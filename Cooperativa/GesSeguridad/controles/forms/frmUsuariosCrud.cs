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
using Model;
using FormsAuxiliares;


namespace GesSeguridad.controles.forms
{
    public partial class frmUsuariosCrud : gesForm, IVistaUsuariosCrud
    {
        #region << PROPIEDADES >>
        UIUsuariosCrud _oUsuariosCrud;
        Utility oUtility;
        int _intUsrNumero;
        string _strAccion;
        long _logPrsNumero;
        #endregion

        #region Implementation of IVistaUsuariosCrud

        public string strPrsDescripcion
        {
            get { return this.txtPersona.Text; }
            set { this.txtPersona.Text = value; }
        }

        public long logPrsNumero
        {
            get { return _logPrsNumero; }
            set { _logPrsNumero = value; }
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

        public DateTime? datUsrAlta
        {
            get { return DateTime.Parse(this.dtpFechaAlta.Text); }
            set { this.dtpFechaAlta.Text = value.ToString(); }

        }

        public DateTime? datUsrBaja
        {           
            get
            {
                if (this.dtpFechaBaja.Checked)
                    return DateTime.Parse(this.dtpFechaBaja.Text);
                else
                    return null;
            }
            set
            {
                this.dtpFechaBaja.Text = value.ToString();
            }
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

        public frmUsuariosCrud(int Codigo, string Accion,long NroPersona)
        {
            try
            {
                InitializeComponent();

                _oUsuariosCrud = new UIUsuariosCrud(this);
                _intUsrNumero = Codigo;
                _logPrsNumero = NroPersona;
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
                this.tttEtiqueta.SetToolTip(this.txtPersona, "Persona al que se le crea el Usuario");
                this.tttEtiqueta.SetToolTip(this.txtNombre, "Nombre del Usuario");
                this.tttEtiqueta.SetToolTip(this.txtClave, "Clave del Usuario");
                this.tttEtiqueta.SetToolTip(this.cmbPerfil, "Perfil del Usuario");
                this.tttEtiqueta.SetToolTip(this.dtpFechaAlta, "Fecha de Alta de la Usuario");
                this.tttEtiqueta.SetToolTip(this.dtpFechaBaja, "Fecha de Baja de la Usuario");
                this.tttEtiqueta.SetToolTip(this.chkBloqueado, "Indica si el Usuario esta Bloqueado");
                this.tttEtiqueta.SetToolTip(this.chkEstado, "Indica si el Usuario esta Habilitado");
                //valor por defecto si crea el usuario por la persona
                if ((_logPrsNumero != 0 & _strAccion == "I") ||(_logPrsNumero != 0) & _strAccion == "E")
                {
                    //deberia buscar la descripcion de la persona                     
                    Console.WriteLine("persona nuevo usuario o modificacion de personas " + _logPrsNumero);
                    _oUsuariosCrud.CargarPersona(int.Parse(_logPrsNumero.ToString()));

                }
                //
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

        private void btnPersona_Click(object sender, EventArgs e)
        {           

            FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
            Admin oAdmin = new Admin();
            oAdmin.TabCodigo = "PERB";
            oAdmin.Tipo = Admin.enumTipoForm.Selector;
            FormsAuxiliares.frmFormAdmin frmPersona = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            if (frmPersona.ShowDialog() == DialogResult.OK)
            {
                string strCodPersona = frmPersona.striRdoCodigo;
                _logPrsNumero = long.Parse(strCodPersona);
                Console.WriteLine("persona "+ strCodPersona);
                _oUsuariosCrud.CargarPersona(int.Parse(strCodPersona));
            }           


        }


        #endregion

    }
}
