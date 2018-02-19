using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
using AppProcesos.formsAuxiliares.principal;
using Controles.form;
using Model;

namespace FormsAuxiliares
{
    public class frmPrincipal : gesForm, IVistaPrincipal
    {

        private UIPrincipal _oPrincipal;
        public string _subSistema;
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
            _subSistema = subsistema;
           
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
            this.trvMenu.Size = new System.Drawing.Size(341, 592);
            this.trvMenu.TabIndex = 0;
            this.trvMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMenu_NodeMouseDoubleClick);
            // 
            // mnuMenuPrincipal
            // 
            this.mnuMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mnuMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuPrincipal.Name = "mnuMenuPrincipal";
            this.mnuMenuPrincipal.Size = new System.Drawing.Size(1022, 28);
            this.mnuMenuPrincipal.TabIndex = 1;
            this.mnuMenuPrincipal.Text = "mnuMenuPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // sstBarraEstado
            // 
            this.sstBarraEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sstBarraEstado.Location = new System.Drawing.Point(0, 620);
            this.sstBarraEstado.Name = "sstBarraEstado";
            this.sstBarraEstado.Size = new System.Drawing.Size(1022, 25);
            this.sstBarraEstado.TabIndex = 2;
            this.sstBarraEstado.Text = "sstBarraEstado";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pnlPanelContenedor1
            // 
            this.pnlPanelContenedor1.Controls.Add(this.trvMenu);
            this.pnlPanelContenedor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPanelContenedor1.Location = new System.Drawing.Point(0, 28);
            this.pnlPanelContenedor1.Name = "pnlPanelContenedor1";
            this.pnlPanelContenedor1.Size = new System.Drawing.Size(341, 592);
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
            _oPrincipal.InicializarArbol(_subSistema);
            _oPrincipal.DesplegarArbol();
        }

 



        #endregion
        #region << METODOS >>

        private void AbrirFormulario()
        {

            string strFormulario = _oPrincipal.FormularioActivo(this.trvMenu.SelectedNode);
            switch (strFormulario)
            {
                case "frmFabricantes":
                    Console.WriteLine("Case 1");
                    break;
                case "frmTiposMedidores":
                    Console.WriteLine("Case 2");
                    break;
                case "frmModelosMedidiores":
                    Console.WriteLine("Case 1");
                    break;
                case "frmTelefonos":
                    Console.WriteLine("Case 2");
                    break;
                case "frmCalles":
                    Console.WriteLine("Case 1");
                    break;
                case "frmDomicilios":
                    FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
                    Admin oAdmin = new Admin();
                    oAdmin.TabCodigo = "DOMB";

                    FormsAuxiliares.frmFormAdmin frm = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
                    frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                    frm.ShowDialog();

                    break;
                case "frmObservaciones":
                    Console.WriteLine("Case 1");
                    break;
                case "frmRutas":
                    Console.WriteLine("Case 2");
                    break;
                case "frmCategorias":
                    FuncionalidadesFoms oCatPermiso = new FuncionalidadesFoms("2", "3", "0", "4", "0", "0");
                    Admin oCatAdmin = new Admin();
                    oCatAdmin.TabCodigo = "SCAT";
                    FormsAuxiliares.frmFormAdminMini frmCat = new FormsAuxiliares.frmFormAdminMini(oCatAdmin, oCatPermiso);
                    frmCat.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                    frmCat.ShowDialog();
                    //Console.WriteLine("Case 1");
                    break;
                case "frmSuministros":
                    Console.WriteLine("Case 2");
                    break;
                case "frmConceptosLecturas":
                    Console.WriteLine("Case 2");
                    break;
                case "frmModosLecturas":
                    Console.WriteLine("Case 2");
                    break;
                case "frmClientes":
                    Console.WriteLine("Case 2");
                    break;

            }
        }
        #endregion

        private void trvMenu_NodeMouseDoubleClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            AbrirFormulario();
        }
    }
}
