using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
using AppProcesos.formsAuxiliares.principal;
using Controles.form;

namespace FormsAuxiliares
{
    public class frmPrincipal : gesForm, IVistaPrincipal
    {

        private UIPrincipal _oPrincipal;
        private Controles.contenedores.mnuMenuPrincipal mnuMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public Controles.contenedores.sstBarraEstado sstBarraEstado;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Controles.contenedores.pnlPanelContenedor pnlPanelContenedor1;
        private Controles.datos.trvMenu trvMenu;

        #region Implementation of IVistaPrincipal
        public Controles.datos.trvMenu oTreeNode
        {
            get { return this.trvMenu; }
            set { this.trvMenu = value; }
        }



        #endregion
        public frmPrincipal(string subsistema)
        {
            this.IsMdiContainer = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            _oPrincipal = new UIPrincipal(this);
        }



        public void InitializeComponent() {
            this.trvMenu = new Controles.datos.trvMenu();
            this.mnuMenuPrincipal = new Controles.contenedores.mnuMenuPrincipal();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sstBarraEstado = new Controles.contenedores.sstBarraEstado();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlPanelContenedor1 = new Controles.contenedores.pnlPanelContenedor();
            this.mnuMenuPrincipal.SuspendLayout();
            this.sstBarraEstado.SuspendLayout();
            this.pnlPanelContenedor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvMenu
            // 
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(341, 599);
            this.trvMenu.TabIndex = 0;
            // 
            // mnuMenuPrincipal
            // 
            this.mnuMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mnuMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuPrincipal.Name = "mnuMenuPrincipal";
            this.mnuMenuPrincipal.Size = new System.Drawing.Size(1022, 24);
            this.mnuMenuPrincipal.TabIndex = 1;
            this.mnuMenuPrincipal.Text = "mnuMenuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // sstBarraEstado
            // 
            this.sstBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sstBarraEstado.Location = new System.Drawing.Point(0, 623);
            this.sstBarraEstado.Name = "sstBarraEstado";
            this.sstBarraEstado.Size = new System.Drawing.Size(1022, 22);
            this.sstBarraEstado.TabIndex = 2;
            this.sstBarraEstado.Text = "sstBarraEstado";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pnlPanelContenedor1
            // 
            this.pnlPanelContenedor1.Controls.Add(this.trvMenu);
            this.pnlPanelContenedor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPanelContenedor1.Location = new System.Drawing.Point(0, 24);
            this.pnlPanelContenedor1.Name = "pnlPanelContenedor1";
            this.pnlPanelContenedor1.Size = new System.Drawing.Size(341, 599);
            this.pnlPanelContenedor1.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1022, 645);
            this.Controls.Add(this.pnlPanelContenedor1);
            this.Controls.Add(this.sstBarraEstado);
            this.Controls.Add(this.mnuMenuPrincipal);
            this.MainMenuStrip = this.mnuMenuPrincipal;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuMenuPrincipal.ResumeLayout(false);
            this.mnuMenuPrincipal.PerformLayout();
            this.sstBarraEstado.ResumeLayout(false);
            this.sstBarraEstado.PerformLayout();
            this.pnlPanelContenedor1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #region << EVENTOS >>


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            _oPrincipal.InicializarArbol();
        }
        #endregion

      
    }
}
