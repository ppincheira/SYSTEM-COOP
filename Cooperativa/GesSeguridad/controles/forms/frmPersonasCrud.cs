using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controles.form;
using AppProcesos.gesSeguridad.frmPersonasCrud;
using Service;
using Controles.datos;

namespace GesSeguridad.controles.forms
{
    public partial class frmPersonasCrud : gesForm, IVistaPersonasCrud
    {
        #region << PROPIEDADES >>
        UIPersonasCrud _oPersonasCrud;
        Utility oUtility;
        long _logPrsNumero;
        string _strAccion;
        #endregion

        #region Implementation of IVistaPersonasCrud

        public long logPrsNumero
        {
            get { return _logPrsNumero; }
            set { _logPrsNumero = value; }
        }
        public string strPrsApellido
        {
            get { return this.txtApellido.Text; }
            set { this.txtApellido.Text = value; }
        }

        public string strPrsNombre
        {
            get { return this.txtNombre.Text; }
            set { this.txtNombre.Text = value; }
        }

        public cmbLista cmbPrsCivil
        {
            get { return this.cmbEstadoCivil; }
            set { this.cmbEstadoCivil = value; }
        }
        public cmbLista cmbPrsSexo
        {
            get { return this.cmbSexo; }
            set { this.cmbSexo = value; }
        }
        public cmbLista cmbPrsTpoDni
        {
            get { return this.cmbTipo; }
            set { this.cmbTipo = value; }
        }

        public string strPrsNroDocumento
        {
            get { return this.txtNroDocumento.Text; }
            set { this.txtNroDocumento.Text = value; }
        }

        public DateTime datPrsNacimiento
        {
            get { return DateTime.Parse(this.dtpFechaNacimiento.Text); }
            set { this.dtpFechaNacimiento.Text = value.ToString(); }
        }

        public string strPrsLocalidad
        {
            get { return this.txtLocalidad.Text; }
            set { this.txtLocalidad.Text = value; }
        }

        public DateTime datPrsIngreso
        {
            get { return DateTime.Parse(this.dtpFechaIngreso.Text); }
            set { this.dtpFechaIngreso.Text = value.ToString(); }
        }

        public string strPrsCuil
        {
            get { return this.txtCuil.Text; }
            set { this.txtCuil.Text = value; }
        }

        public string strPrsLegajo
        {
            get { return this.txtLegajo.Text; }
            set { this.txtLegajo.Text = value; }
        }

        public cmbLista cmbPrsCargo
        {
            get { return this.cmbCargo; }
            set { this.cmbTipo = value; }
        }

        public DateTime datPrsBaja
        {
            get { return DateTime.Parse(this.dtpFechaBaja.Text); }
            set { this.dtpFechaBaja.Text = value.ToString(); }
        }

        public cmbLista cmbPrsBaja
        {
            get { return this.cmbMotivoBaja; }
            set { this.cmbMotivoBaja = value; }
        }

        public Boolean booPrsEstado
        {
            get { return this.chkHabilitado.Checked; }
            set { this.chkHabilitado.Checked = value; }
        }
        #endregion

        #region << EVENTOS >>

        public frmPersonasCrud(long Codigo, string Accion)
        {
            try
            {
                InitializeComponent();

                _oPersonasCrud = new UIPersonasCrud(this);
                _logPrsNumero = Codigo;
                _strAccion = Accion;
                if (_strAccion == "B")
                    if (MessageBox.Show("Desea eliminar La Persona Código: " + Codigo + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _oPersonasCrud.EliminarPersona(Codigo);
                        Cursor.Current = Cursors.Default;
                        this.Close();
                    }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                "frmPersonasCrud",
                                "frmPersonasCrud",
                                this.FindForm().Name);
            }
        }
        private void frmPersonasCrud_Load(object sender, EventArgs e)
        {
            try
            {
                _oPersonasCrud.Inicializar();
                oUtility = new Utility();

                this.tttEtiqueta.SetToolTip(this.txtApellido, "Apellido de la Persona");
                this.tttEtiqueta.SetToolTip(this.txtNombre, "Nombre de la Persona");
                this.tttEtiqueta.SetToolTip(this.cmbEstadoCivil, "Estado Civil de la Persona");
                this.tttEtiqueta.SetToolTip(this.cmbPrsSexo, "Sexo de Persona");
                this.tttEtiqueta.SetToolTip(this.cmbPrsTpoDni, "DNI de Persona");
                this.tttEtiqueta.SetToolTip(this.txtNroDocumento, "Numero de Documento de la Persona");
                this.tttEtiqueta.SetToolTip(this.dtpFechaNacimiento, "Fecha de Nacimiento de la Persona");
                this.tttEtiqueta.SetToolTip(this.txtLocalidad, "Localidad de la Persona");
                this.tttEtiqueta.SetToolTip(this.dtpFechaIngreso, "Fecha de Ingreso de la Persona");
                this.tttEtiqueta.SetToolTip(this.txtCuil, "C.U.I.L. de la Persona");
                this.tttEtiqueta.SetToolTip(this.txtLegajo, "Legajo de la Persona");
                this.tttEtiqueta.SetToolTip(this.cmbPrsCargo, "Cargo de la Persona");
                this.tttEtiqueta.SetToolTip(this.dtpFechaBaja, "Fecha de Baja de la Persona");
                this.tttEtiqueta.SetToolTip(this.cmbMotivoBaja, "Motivo de Baja de la Persona");
                this.tttEtiqueta.SetToolTip(this.chkHabilitado, "Indica si esta Habilitada la Persona");

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
                oUtility.ValidarFormularioEP(this, this, 15);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    Cursor.Current = Cursors.WaitCursor;
                    _oPersonasCrud.Guardar();
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
