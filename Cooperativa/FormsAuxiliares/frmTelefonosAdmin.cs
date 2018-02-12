﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProcesos.formsAuxiliares.frmTelefonos;
using Controles.datos;
using Controles.form;
using System.Windows.Forms;
using Service;
using Model;

namespace FormsAuxiliares
{
    public partial class frmTelefonosAdmin : gesForm, IVistaTelefonos
    {
        #region << PROPIEDADES >>
        private UITelefonos _oUITelefonos;
        string _tabCodigo;
        string _telCodigoRegistro;
        private Utility _oUtil;

        #endregion

        private Controles.contenedores.gpbGrupo gpbGrupo4;
        private Controles.buttons.btnImprimir btnImprimir;
        private Controles.buttons.btnVer btnVer;
        private Controles.buttons.btnExportar btnExportar;
        private Controles.buttons.btnEliminar btnEliminar;
        private Controles.buttons.btnSalir btnSalir;
        private Controles.buttons.btnEditar btnEditar;
        private Controles.buttons.btnNuevo btnNuevo;
        private Controles.contenedores.gpbGrupo gpbGrupo1;
        private Controles.labels.lblEtiqueta lblCantidad;
        private Controles.datos.grdGrillaAdmin grdGrillaAdmin;

        #region Implementation of IVistaTelefonos

        public string tabCodigo
        {
            get { return this._tabCodigo; }
            set { this._tabCodigo = value; }
        }

        public string telCodigoRegistro
        {
            get { return this._telCodigoRegistro; }
            set { this._telCodigoRegistro = value; }
        }
        public grdGrillaAdmin grilla
        {
            get { return this.grdGrillaAdmin; }
            set { this.grdGrillaAdmin = value; }
        }

        public string cantidad
        {
            set { this.lblCantidad.Text = value; }

        }
        #endregion

        public frmTelefonosAdmin(string tabCodigo, string telCodigoRegistro, FuncionalidadesFoms oPerForm)
        {
            InitializeComponent();
            AsignarFuncionalidad(oPerForm);
            _oUITelefonos = new UITelefonos(this);
            _tabCodigo = tabCodigo;
            _telCodigoRegistro = telCodigoRegistro;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonosAdmin));
            this.gpbGrupo4 = new Controles.contenedores.gpbGrupo();
            this.btnImprimir = new Controles.buttons.btnImprimir();
            this.btnVer = new Controles.buttons.btnVer();
            this.btnExportar = new Controles.buttons.btnExportar();
            this.btnEliminar = new Controles.buttons.btnEliminar();
            this.btnSalir = new Controles.buttons.btnSalir();
            this.btnEditar = new Controles.buttons.btnEditar();
            this.btnNuevo = new Controles.buttons.btnNuevo();
            this.gpbGrupo1 = new Controles.contenedores.gpbGrupo();
            this.lblCantidad = new Controles.labels.lblEtiqueta();
            this.grdGrillaAdmin = new Controles.datos.grdGrillaAdmin();
            this.gpbGrupo4.SuspendLayout();
            this.gpbGrupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin)).BeginInit();
            this.SuspendLayout();
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
            this.gpbGrupo4.Location = new System.Drawing.Point(319, 9);
            this.gpbGrupo4.Name = "gpbGrupo4";
            this.gpbGrupo4.Size = new System.Drawing.Size(336, 78);
            this.gpbGrupo4.TabIndex = 4;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);            
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            // gpbGrupo1
            // 
            this.gpbGrupo1.Controls.Add(this.lblCantidad);
            this.gpbGrupo1.Controls.Add(this.grdGrillaAdmin);
            this.gpbGrupo1.Location = new System.Drawing.Point(12, 93);
            this.gpbGrupo1.Name = "gpbGrupo1";
            this.gpbGrupo1.Size = new System.Drawing.Size(643, 328);
            this.gpbGrupo1.TabIndex = 3;
            this.gpbGrupo1.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(3, 312);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // grdGrillaAdmin
            // 
            this.grdGrillaAdmin.AllowUserToAddRows = false;
            this.grdGrillaAdmin.Location = new System.Drawing.Point(6, 19);
            this.grdGrillaAdmin.Name = "grdGrillaAdmin";
            this.grdGrillaAdmin.Size = new System.Drawing.Size(631, 290);
            this.grdGrillaAdmin.TabIndex = 0;
            // 
            // frmTelefonosAdmin
            // 
            this.ClientSize = new System.Drawing.Size(668, 433);
            this.Controls.Add(this.gpbGrupo4);
            this.Controls.Add(this.gpbGrupo1);
            this.Name = "frmTelefonosAdmin";
            this.Load += new System.EventHandler(this.frmTelefonosAdmin_Load);
            this.gpbGrupo4.ResumeLayout(false);
            this.gpbGrupo1.ResumeLayout(false);
            this.gpbGrupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrillaAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmTelefonosAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _oUITelefonos.Inicializar();
                _oUtil = new Utility();
                _oUtil.HabilitarAllControlesInTrue(this, 1, "frmTelefonos");
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _oUtil.ExportarDataGridViewExcel(this.grdGrillaAdmin);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmTelefonosCrud ofrmTel = new frmTelefonosCrud(0, _tabCodigo, _telCodigoRegistro, "I");
                if (ofrmTel.ShowDialog() == DialogResult.OK)
                    _oUITelefonos.CargarGrilla();
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
                DataGridViewRow row = this.grdGrillaAdmin.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);
                frmTelefonosCrud ofrmTel = new frmTelefonosCrud(id, _tabCodigo, _telCodigoRegistro, "E");
                if (ofrmTel.ShowDialog() == DialogResult.OK)
                    _oUITelefonos.CargarGrilla();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {               
                DataGridViewRow row = this.grdGrillaAdmin.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);

                if(MessageBox.Show("Desea eliminar el Telefono Código: " + id + " ?", "Cooperativa", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _oUITelefonos.EliminarTelefono(id);
                    _oUITelefonos.CargarGrilla();
                    Cursor.Current = Cursors.Default;
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdGrillaAdmin.CurrentRow;
                long id = Convert.ToInt64(row.Cells[0].Value);
                frmTelefonosCrud ofrmObs = new frmTelefonosCrud(id, _tabCodigo, _telCodigoRegistro, "V");
                ofrmObs.Show();
            }
            catch (Exception ex)
            {
                ManejarError Err = new ManejarError();
                Err.CargarError(ex,
                                e.ToString(),
                                ((Control)sender).Name,
                                this.FindForm().Name);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #region << METODOS >>
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
        #endregion
    }
}
