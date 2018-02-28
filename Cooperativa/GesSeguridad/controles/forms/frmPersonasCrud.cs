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

        public cmbLista cmbPrsLocalidad
        {
            get { return this.cmbLocalidad; }
            set { this.cmbLocalidad = value; }
        }

        public cmbLista cmbPrsProvincia
        {
            get { return this.cmbProvincia; }
            set { this.cmbProvincia = value; }
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

        public DateTime? datPrsIngreso
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

        public DateTime? datPrsBaja
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
                        _oPersonasCrud.EliminarPersona(_logPrsNumero);
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
                this.tttEtiqueta.SetToolTip(this.cmbPrsProvincia, "Provincia de Nacimiento de la Persona");
                this.tttEtiqueta.SetToolTip(this.cmbPrsLocalidad, "Localidad de Nacimiento de la Persona");
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
                    this.btnVerUsuario.Enabled = false;
                }
                if (_strAccion == "I")
                {
                    this.btnVerUsuario.Enabled = false;
                }
                if (_strAccion == "E")
                {
                    this.btnVerUsuario.Enabled = true;
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
                long logResultado;
                this.VALIDARFORM = true;
                oUtility.ValidarFormularioEP(this, this, 16);             
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    Cursor.Current = Cursors.WaitCursor;
                    logResultado = _oPersonasCrud.Guardar();
                    Cursor.Current = Cursors.Default;
                    if (_strAccion == "I")
                    {
                        if (MessageBox.Show("Desea crear un Usuario para la persona ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            frmUsuariosCrud ofrmUsu = new frmUsuariosCrud(0, "I", logResultado);
                            if (ofrmUsu.ShowDialog() == DialogResult.OK)
                                Console.WriteLine("sale del la ceacion del user");
                        }
                    }                    
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
        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                Cursor.Current = Cursors.WaitCursor;
                _oPersonasCrud.CambioProvincia();                   
                Cursor.Current = Cursors.Default;                                  
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
        private void btnVerUsuario_Click(object sender, EventArgs e)
        {
            try
            {                
                frmUsuariosCrud ofrmUsu = new frmUsuariosCrud(_oPersonasCrud.ConsultarUsuario(_logPrsNumero), "E", _logPrsNumero);
                if (ofrmUsu.ShowDialog() == DialogResult.OK)
                    Console.WriteLine("ver el user asociado");
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


        #endregion

   
    }
}
