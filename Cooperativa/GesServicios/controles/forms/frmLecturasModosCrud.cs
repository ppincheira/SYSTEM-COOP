using System;
using AppProcesos.gesServicios.frmLecturasModosCrud;
using Controles.buttons;
using Controles.contenedores;
using Controles.datos;
using System.Windows.Forms;
using Controles.form;
using Service;
using Model;
using System.Collections.Generic;
using Business;


namespace GesServicios.controles.forms
{
    public class frmLecturasModosCrud : gesForm
    {
        #region Propiedades

        private long _LEMCodigo;
        private int _USRCodigo;
        private Utility oUtil;
        private UILecturasModosCrud _oLecturasModosCrud;
        private string _EstCodigo;



        private Controles.contenedores.gesGroup gesGroup1;
        private gesGroup gesGroup3;
        private btnCancelar btnCancelar;
        private btnAceptar btnAceptar;
        private Controles.labels.lblEtiqueta lblLEMDescripcion;
        private Controles.Fecha.dtpFecha dtpFechaAlta;
        private Controles.labels.lblEtiqueta lblLEMFechaAlta;
        private cmbLista cmbSRVCodigo;
        private chkBox chkESTCodigo;
        private Controles.labels.lblEtiqueta lblSRVCodigo;
        private Controles.labels.lblEtiqueta lblESTCodigo;
        private grdGrillaEdit grdLecturasConceptos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private gesGroup gesGroup2;
        #endregion

        public long lemCodigo { get { return this._LEMCodigo; } set { this._LEMCodigo = value; } }
        //        public string lemDescripcion { get { return this.txtLEMDescripcion.Text; } set { this.txtLEMDescripcion.Text = value; } }
        public DateTime lemFechaCarga { get { return this.dtpFechaAlta.Value; } set { this.dtpFechaAlta.Value = value; } }
        public cmbLista srvCodigo { get { return this.cmbSRVCodigo; } set { this.cmbSRVCodigo = value; } }
        public int usrCodigo { get { return _USRCodigo; } set { this._USRCodigo = value; } }
        public string estCodigo { get { return this.chkESTCodigo.Checked ? "H" : "I"; } set { this.chkESTCodigo.Checked = (value == "H"); } }
        public grdGrillaEdit conceptos { get { return this.grdLecturasConceptos; } set { this.grdLecturasConceptos = value; } }

        public frmLecturasModosCrud(long NumeroLectura, string estado)
        {
            try
            {
                _LEMCodigo = NumeroLectura;
                _EstCodigo = estado;
                //           _oLecturasModosCrud = new UILecturasModosCrud(this);
                InitializeComponent();
                if (estado == "B")
                    if (MessageBox.Show("Desea eliminar el Modelo de Lectura: " + NumeroLectura + " ?", "Cooperativa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _oLecturasModosCrud.EliminarModoLectura(NumeroLectura);
                        this.Close();
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLecturasModosCrud));
            this.gesGroup1 = new Controles.contenedores.gesGroup();
            this.lblESTCodigo = new Controles.labels.lblEtiqueta();
            this.cmbSRVCodigo = new Controles.datos.cmbLista();
            this.chkESTCodigo = new Controles.datos.chkBox();
            this.lblSRVCodigo = new Controles.labels.lblEtiqueta();
            this.dtpFechaAlta = new Controles.Fecha.dtpFecha();
            this.lblLEMFechaAlta = new Controles.labels.lblEtiqueta();
            this.lblLEMDescripcion = new Controles.labels.lblEtiqueta();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.grdLecturasConceptos = new Controles.datos.grdGrillaEdit();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gesGroup3 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gesGroup1.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLecturasConceptos)).BeginInit();
            this.gesGroup3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gesGroup1
            // 
            this.gesGroup1.Controls.Add(this.lblESTCodigo);
            this.gesGroup1.Controls.Add(this.cmbSRVCodigo);
            this.gesGroup1.Controls.Add(this.chkESTCodigo);
            this.gesGroup1.Controls.Add(this.lblSRVCodigo);
            this.gesGroup1.Controls.Add(this.dtpFechaAlta);
            this.gesGroup1.Controls.Add(this.lblLEMFechaAlta);
            this.gesGroup1.Controls.Add(this.lblLEMDescripcion);
            this.gesGroup1.Location = new System.Drawing.Point(12, 12);
            this.gesGroup1.Name = "gesGroup1";
            this.gesGroup1.Size = new System.Drawing.Size(566, 181);
            this.gesGroup1.TabIndex = 0;
            this.gesGroup1.TabStop = false;
            this.gesGroup1.Text = "Datos";
            // 
            // lblESTCodigo
            // 
            this.lblESTCodigo.AutoSize = true;
            this.lblESTCodigo.Location = new System.Drawing.Point(6, 165);
            this.lblESTCodigo.Name = "lblESTCodigo";
            this.lblESTCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblESTCodigo.TabIndex = 7;
            this.lblESTCodigo.Text = "Estado:";
            // 
            // cmbSRVCodigo
            // 
            this.cmbSRVCodigo.FormattingEnabled = true;
            this.cmbSRVCodigo.Location = new System.Drawing.Point(89, 47);
            this.cmbSRVCodigo.Name = "cmbSRVCodigo";
            this.cmbSRVCodigo.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.cmbSRVCodigo.Size = new System.Drawing.Size(199, 21);
            this.cmbSRVCodigo.TabIndex = 6;
            // 
            // chkESTCodigo
            // 
            this.chkESTCodigo.AutoSize = true;
            this.chkESTCodigo.Checked = true;
            this.chkESTCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkESTCodigo.Location = new System.Drawing.Point(89, 161);
            this.chkESTCodigo.Name = "chkESTCodigo";
            this.chkESTCodigo.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkESTCodigo.Size = new System.Drawing.Size(73, 17);
            this.chkESTCodigo.TabIndex = 5;
            this.chkESTCodigo.Text = "Habilitado";
            this.chkESTCodigo.UseVisualStyleBackColor = true;
            // 
            // lblSRVCodigo
            // 
            this.lblSRVCodigo.AutoSize = true;
            this.lblSRVCodigo.Location = new System.Drawing.Point(6, 55);
            this.lblSRVCodigo.Name = "lblSRVCodigo";
            this.lblSRVCodigo.Size = new System.Drawing.Size(53, 13);
            this.lblSRVCodigo.TabIndex = 4;
            this.lblSRVCodigo.Text = "Servicios:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(89, 94);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaAlta.Size = new System.Drawing.Size(199, 20);
            this.dtpFechaAlta.TabIndex = 3;
            // 
            // lblLEMFechaAlta
            // 
            this.lblLEMFechaAlta.AutoSize = true;
            this.lblLEMFechaAlta.Location = new System.Drawing.Point(6, 101);
            this.lblLEMFechaAlta.Name = "lblLEMFechaAlta";
            this.lblLEMFechaAlta.Size = new System.Drawing.Size(61, 13);
            this.lblLEMFechaAlta.TabIndex = 2;
            this.lblLEMFechaAlta.Text = "Fecha Alta:";
            // 
            // lblLEMDescripcion
            // 
            this.lblLEMDescripcion.AutoSize = true;
            this.lblLEMDescripcion.Location = new System.Drawing.Point(6, 27);
            this.lblLEMDescripcion.Name = "lblLEMDescripcion";
            this.lblLEMDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblLEMDescripcion.TabIndex = 0;
            this.lblLEMDescripcion.Text = "Descripcion:";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.grdLecturasConceptos);
            this.gesGroup2.Location = new System.Drawing.Point(12, 214);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(566, 184);
            this.gesGroup2.TabIndex = 1;
            this.gesGroup2.TabStop = false;
            this.gesGroup2.Text = "Conceptos asociados";
            // 
            // grdLecturasConceptos
            // 
            this.grdLecturasConceptos.AllowUserToAddRows = false;
            this.grdLecturasConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLecturasConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdLecturasConceptos.Location = new System.Drawing.Point(9, 19);
            this.grdLecturasConceptos.MultiSelect = false;
            this.grdLecturasConceptos.Name = "grdLecturasConceptos";
            this.grdLecturasConceptos.Size = new System.Drawing.Size(546, 150);
            this.grdLecturasConceptos.TabIndex = 0;
            this.grdLecturasConceptos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLecturasConceptos_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DESCRIPCION CORTA";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESCRIPCION";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // gesGroup3
            // 
            this.gesGroup3.Controls.Add(this.btnCancelar);
            this.gesGroup3.Controls.Add(this.btnAceptar);
            this.gesGroup3.Location = new System.Drawing.Point(386, 404);
            this.gesGroup3.Name = "gesGroup3";
            this.gesGroup3.Size = new System.Drawing.Size(192, 89);
            this.gesGroup3.TabIndex = 6;
            this.gesGroup3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(6, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(101, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmLecturasModosCrud
            // 
            this.ClientSize = new System.Drawing.Size(593, 496);
            this.Controls.Add(this.gesGroup3);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gesGroup1);
            this.Name = "frmLecturasModosCrud";
            this.Load += new System.EventHandler(this.frmLecturasModosCrud_Load);
            this.gesGroup1.ResumeLayout(false);
            this.gesGroup1.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLecturasConceptos)).EndInit();
            this.gesGroup3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void frmLecturasModosCrud_Load(object sender, EventArgs e)
        {
            try
            {
                oUtil = new Utility();
                _oLecturasModosCrud.Inicializar();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void bloquearFecha()
        {
            this.dtpFechaAlta.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
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
                _USRCodigo = 1;
                if (this.chkESTCodigo.Checked == true) { this._EstCodigo = "H"; }
                else this._EstCodigo = "I";
                //               oUtil.ValidarFormulario(this, this, 3);
                if (this.VALIDARFORM)
                {
                    DialogResult = DialogResult.OK;
                    _oLecturasModosCrud.Guardar();
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


        private void grdLecturasConceptos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //esto es necesario porque por alguna razon se des asocia la grilla de la vista de la grilla de los datos
                conceptos = (grdGrillaEdit)sender;
                string valorCelda = (string)(((grdGrillaEdit)sender).SelectedCells[0].Value);
                string valorCampo = "";
                //Se tiene que preguntar cual es la celda de la cual se esta saliendo,
                //y se tiene que buscar si alguna lectura concepto concuerda                
                if (valorCelda != "")
                {

                    List<LecturasConceptos> datos = new List<LecturasConceptos>();
                    datos = LecturasConceptosBus.RecuperarLecturasConceptos(valorCelda, e.ColumnIndex);

                    //En caso de no concordar, si es descripcion corta o descripcion 
                    //se carga el formulario para agregarlo
                    if (datos.Count == 0)
                    {


                        FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
                        Admin oAdmin = new Admin();
                        oAdmin.TabCodigo = "LEC";
                        oAdmin.Tipo = Admin.enumTipoForm.Selector;
                        oAdmin.FiltroValores = valorCelda;
                        switch (e.ColumnIndex)
                        {
                            case 0:
                                valorCampo = "LEC_CODIGO";
                                break;
                            case 1:
                                valorCampo = "LEC_DESCRIPCION_CORTA";
                                break;
                            case 2:
                                valorCampo = "LEC_DESCRIPCION";
                                break;
                        }
                        oAdmin.FiltroCampos = valorCampo;

                        /*       frmFormAdminMini frmbus = new frmFormAdminMini(oAdmin, oPermiso);

                               if (frmbus.ShowDialog() == DialogResult.OK)
                               {
                                   string id = frmbus.striRdoCodigo;
                                   LecturasConceptosBus aux = new LecturasConceptosBus();
                                   LecturasConceptos aux2 = aux.LecturasConceptosGetById(long.Parse(id));
                                   cargarGrilla(aux2, e.RowIndex);
                               }*/



                    }
                }


                //Si retorna mas de un resultado se tiene que poder elegir entre las opciones

                //de dejar la columna NUMERO se tiene que mostrar todos las lecturas conceptos 
                //para que se peuda selecionar la que se desea 

                //Una vez agregada una se guardan las referencias y se tiene que agregar una fila para poder 
                //agregar otro concepto de ser necesario
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarGrilla(LecturasConceptos olc, int rows)
        {
            if (conceptos.Rows.Count == 0)
            {
                conceptos.Rows.Add();
            }
            conceptos.Rows[rows].Cells[0].Value = olc.LecCodigo;
            conceptos.Rows[rows].Cells[1].Value = olc.LecDescripcionCorta;
            conceptos.Rows[rows].Cells[2].Value = olc.LecDescripcion;
            reorganizarGrilla();
        }

        private void reorganizarGrilla()
        {
            foreach (DataGridViewRow a in conceptos.Rows)
            {
                if (a.Cells[0].Value.ToString() == "")
                {
                    conceptos.Rows.Remove(a);
                }
            }
            conceptos.Rows.Add();
        }
    }
}
