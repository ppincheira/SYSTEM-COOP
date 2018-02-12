using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProcesos.formsAuxiliares.frmObservaciones;
using Controles.datos;
using Controles.form;
using System.Windows.Forms;
using Service;
using Model;
using static Model.AdminObs;

namespace FormsAuxiliares
{
    public partial class frmObservacionesAdmin : gesForm, IVistaObservaciones
    {
        #region << PROPIEDADES >>
        private UIObservaciones _oUIObservaciones;
        public AdminObs _oAdmin = new AdminObs();
        public string _strRdoCodigo;
        private Utility _oUtility;

        #endregion

        private Controles.contenedores.gpbGrupo gpbGrupo2;
        private Controles.contenedores.gpbGrupo gpbGrupo3;
        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.buttons.btnEditar btnEditar;
        private Controles.buttons.btnSalir btnSalir;
        private Controles.buttons.btnEliminar btnEliminar;
        private Controles.buttons.btnExportar btnExportar;
        private Controles.buttons.btnVer btnVer;
        private Controles.buttons.btnImprimir btnImprimir;
        private Controles.datos.grdGrillaAdmin grdGrillaAdmin;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.textBoxes.txtObservaciones txtObservaciones;
        private Controles.labels.lblEtiqueta lblEFechaHasta;
        private Controles.labels.lblEtiqueta lblEFechaDesde;
        private Controles.Fecha.dtpFecha dtpFechaHasta;
        private Controles.Fecha.dtpFecha dtpFechaDesde;
        private Controles.contenedores.gpbGrupo gpbGrupo1;

        #region Implementation of IVistaObservaciones

        
        public AdminObs oAdminObs
        {
            get { return _oAdmin; }
            set { _oAdmin = value; }
        }
        
        public grdGrillaAdmin grilla
        {
            get { return this.grdGrillaAdmin; }
            set { this.grdGrillaAdmin = value; }
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
        public string cantidad
        {
            set { this.lblCantidad.Text = value; }
        }
        public string detalle
        {
            set { this.txtObservaciones.Text = value; }
        }

        public string striRdoCodigo
        {
            get { return _strRdoCodigo; }
            set { _strRdoCodigo = value; }
        }
        #endregion

        public frmObservacionesAdmin(AdminObs oAdmin, FuncionalidadesFoms oPerForm)
        {
            InitializeComponent();
            _oUIObservaciones = new UIObservaciones(this);
            AsignarFuncionalidad(oPerForm);
            _oAdmin = oAdmin;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservacionesAdmin));
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.grdGrillaAdmin = new Controles.datos.grdGrillaAdmin();
            this.gpbGrupo2 = new Controles.contenedores.gpbGrupo();
            this.txtObservaciones = new Controles.textBoxes.txtObservaciones();
            this.gpbGrupo3 = new Controles.contenedores.gpbGrupo();
            this.lblEFechaHasta = new Controles.labels.lblEtiqueta();
            this.lblEFechaDesde = new Controles.labels.lblEtiqueta();
            this.dtpFechaHasta = new Controles.Fecha.dtpFecha();
            this.dtpFechaDesde = new Controles.Fecha.dtpFecha();
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnEliminar = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.gpbGrupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin)).BeginInit();
            this.gpbGrupo2.SuspendLayout();
            this.gpbGrupo3.SuspendLayout();
            this.gpbGrupo4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblCantidad);
            this.gpbGrupo1.Controls.Add(this.grdGrillaAdmin);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 87);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(643, 235);
            this.gpbGrupo1.TabIndex = 0;
            this.gpbGrupo1.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 218);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // grdGrillaAdmin
            // 
            this.grdGrillaAdmin.AllowUserToAddRows = false;
            this.grdGrillaAdmin.AllowUserToDeleteRows = false;
            this.grdGrillaAdmin.AllowUserToOrderColumns = true;
            this.grdGrillaAdmin.Location = new System.Drawing.Point(6, 16);
            this.grdGrillaAdmin.Name = "grdGrillaAdmin";
            this.grdGrillaAdmin.ReadOnly = true;
            this.grdGrillaAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGrillaAdmin.Size = new System.Drawing.Size(631, 197);
            this.grdGrillaAdmin.TabIndex = 0;
            this.grdGrillaAdmin.SelectionChanged += new System.EventHandler(this.grdGrillaAdmin_SelectionChanged);
            this.grdGrillaAdmin.DoubleClick += new System.EventHandler(this.grdGrillaAdmin_DoubleClick);
            this.grdGrillaAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdGrillaAdmin_KeyPress);
            // 
            // gpbGrupo2
            // 
            this.gpbGrupo2.Controls.Add(this.txtObservaciones);
            this.gpbGrupo2.Location = new System.Drawing.Point(12, 328);
            this.gpbGrupo2.Name = "gpbGrupo2";
            this.gpbGrupo2.Size = new System.Drawing.Size(643, 141);
            this.gpbGrupo2.TabIndex = 1;
            this.gpbGrupo2.TabStop = false;
            this.gpbGrupo2.Text = "Detalle de la observacionseleccionada";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtObservaciones.Location = new System.Drawing.Point(10, 19);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtObservaciones.Size = new System.Drawing.Size(627, 102);
            this.txtObservaciones.TabIndex = 0;
            this.txtObservaciones.TextoVacio = "<Descripcion>";
            this.txtObservaciones.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // gpbGrupo3
            // 
            this.gpbGrupo3.Controls.Add(this.lblEFechaHasta);
            this.gpbGrupo3.Controls.Add(this.lblEFechaDesde);
            this.gpbGrupo3.Controls.Add(this.dtpFechaHasta);
            this.gpbGrupo3.Controls.Add(this.dtpFechaDesde);
            this.gpbGrupo3.Location = new System.Drawing.Point(12, 3);
            this.gpbGrupo3.Name = "gpbGrupo3";
            this.gpbGrupo3.Size = new System.Drawing.Size(301, 78);
            this.gpbGrupo3.TabIndex = 1;
            this.gpbGrupo3.TabStop = false;
            // 
            // lblEFechaHasta
            // 
            this.lblEFechaHasta.AutoSize = true;
            this.lblEFechaHasta.Location = new System.Drawing.Point(10, 50);
            this.lblEFechaHasta.Name = "lblEFechaHasta";
            this.lblEFechaHasta.Size = new System.Drawing.Size(88, 17);
            this.lblEFechaHasta.TabIndex = 15;
            this.lblEFechaHasta.Text = "Fecha Hasta";
            // 
            // lblEFechaDesde
            // 
            this.lblEFechaDesde.AutoSize = true;
            this.lblEFechaDesde.Location = new System.Drawing.Point(7, 19);
            this.lblEFechaDesde.Name = "lblEFechaDesde";
            this.lblEFechaDesde.Size = new System.Drawing.Size(92, 17);
            this.lblEFechaDesde.TabIndex = 14;
            this.lblEFechaDesde.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(105, 44);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaHasta.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaHasta.TabIndex = 13;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(105, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.dtpFechaDesde.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaDesde.TabIndex = 12;
            // 
            // gpbGrupo4
            // 
            this.gpbGrupo4.Controls.Add(this.btnImprimir);
            this.gpbGrupo4.Controls.Add(this.btnVer);
            this.gpbGrupo4.Controls.Add(this.btnExportar);
            this.gpbGrupo4.Controls.Add(this.btnEliminar);
            this.gpbGrupo4.Controls.Add(this.btnSalir);
            this.gpbGrupo4.Controls.Add(this.btnEditar);
            this.gpbGrupo4.Controls.Add(this.btnNuevo);
            this.gpbGrupo4.Location = new System.Drawing.Point(319, 3);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(336, 78);
            this.gpbGrupo4.TabIndex = 2;
            this.gpbGrupo4.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(237, 19);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(40, 40);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVer.BackgroundImage")));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Location = new System.Drawing.Point(145, 20);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(40, 40);
            this.btnVer.TabIndex = 5;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Location = new System.Drawing.Point(191, 20);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(40, 40);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(99, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(283, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(53, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(6, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmObservacionesAdmin
            // 
            this.ClientSize = new System.Drawing.Size(667, 481);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo3);
            this.Controls.Add(this.gpbGrupo2);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmObservacionesAdmin";
            this.Text = "[OBSERVACIONES]";
            this.Load += new System.EventHandler(this.frmObservacionesAdmin_Load);
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin)).EndInit();
            this.gpbGrupo2.ResumeLayout(false);
            this.gpbGrupo2.PerformLayout();
            this.gpbGrupo3.ResumeLayout(false);
            this.gpbGrupo3.PerformLayout();
            this.gpbGrupo4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void frmObservacionesAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                _oUIObservaciones.Inicializar();
                _oUtility = new Utility();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmObservacionesCrud ofrmObs = new frmObservacionesCrud(0, _oAdmin, "I");
                if (ofrmObs.ShowDialog() == DialogResult.OK)
                    _oUIObservaciones.CargarGrilla();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar();
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                _oUtility.ExportarDataGridViewExcel(this.grdGrillaAdmin);
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdGrillaAdmin.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                frmObservacionesCrud ofrmObs = new frmObservacionesCrud(id, oAdminObs, "V");

                ofrmObs.Show();
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

        private void grdGrillaAdmin_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _oUIObservaciones.CargarDetalle(this.grdGrillaAdmin.CurrentRow);
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

        private void grdGrillaAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    AccionOptativa();

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

        private void grdGrillaAdmin_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                AccionOptativa();
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


        #region <<  METODOS >>
        public void AsignarFuncionalidad(FuncionalidadesFoms oPerForm)
        {
            //Esta funcion asigna la funcionalidad a los controles de este dinamico
            this.btnNuevo.FUN_CODIGO = oPerForm.New;
            this.btnEditar.FUN_CODIGO = oPerForm.Edit;
            this.btnExportar.FUN_CODIGO = oPerForm.Exp;
            this.btnEliminar.FUN_CODIGO = oPerForm.Del;
            this.btnImprimir.FUN_CODIGO = oPerForm.Imp;
            this.btnVer.FUN_CODIGO = oPerForm.Ver;
        }

        private void AccionOptativa()
        {
            switch (_oAdmin.Tipo)
            {
                case enumTipoForm.Selector:
                    if (_strRdoCodigo != "")
                        DialogResult = DialogResult.OK; //cierra el formulario    
                    else
                        DialogResult = DialogResult.No;
                    this.Close();
                    break;
                case enumTipoForm.FiltroAndAlta:
                    if (_strRdoCodigo != "")
                        DialogResult = DialogResult.OK; //cierra el formulario    
                    else
                        DialogResult = DialogResult.No;
                    this.Close();
                    break;
                case enumTipoForm.FiltroAndEditar:
                    if (_strRdoCodigo != "")
                        DialogResult = DialogResult.OK; //cierra el formulario    
                    else
                        DialogResult = DialogResult.No;
                    this.Close();
                    break;
                case enumTipoForm.Ninguna:
                    Editar();
                    break;
            }
        }

        private void Editar()
        {
            DataGridViewRow row = this.grdGrillaAdmin.CurrentRow;
            long id = Convert.ToInt64(row.Cells[0].Value);
            frmObservacionesCrud ofrmObs = new frmObservacionesCrud(id, oAdminObs, "E");
            if (ofrmObs.ShowDialog() == DialogResult.OK)
                _oUIObservaciones.CargarGrilla();
        }
        #endregion
    }
}
