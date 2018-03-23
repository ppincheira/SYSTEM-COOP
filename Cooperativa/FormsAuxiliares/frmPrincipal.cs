using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controles;
using AppProcesos.formsAuxiliares.principal;
using Controles.form;
using GesServicios.controles.forms;
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
            switch (_subSistema)
            {
                case "SRV":
                    AbrirFormulariosServicios();
                    break;

                case "CFG":
                    break;

            }
            
            //string strFormulario = _oPrincipal.FormularioActivo(this.trvMenu.SelectedNode);

            //switch (strFormulario)
            //{
            //    case "frmFabricantes":
            //        Console.WriteLine("Case 1");
            //        break;
            //    case "frmTiposMedidores":
            //        Console.WriteLine("Case 2");
            //        break;
            //    case "frmModelosMedidiores":
            //        Console.WriteLine("Case 1");
            //        break;
            //    case "frmTelefonos":
            //        Console.WriteLine("Case 2");
            //        break;
            //    case "frmCalles":
            //        Console.WriteLine("Case 1");
            //        break;
            //    case "frmDomicilios":
            //        FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("31", "32", "33", "35", "36", "34");
            //        Admin oAdmin = new Admin();
            //        oAdmin.TabCodigo = "DOMB";

            //        FormsAuxiliares.frmFormAdmin frm = new FormsAuxiliares.frmFormAdmin(oAdmin, oPermiso);
            //        frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //        frm.ShowDialog();

            //        break;
            //    case "frmObservaciones":
            //        Console.WriteLine("Case 1");
            //        break;
            //    case "frmRutas":
            //        Console.WriteLine("Case 2");
            //        break;
            //    case "frmCategorias":
            //        FuncionalidadesFoms oCatPermiso = new FuncionalidadesFoms("100011", "100012", "100013", "100016", "100014", "100015");
            //        Admin oCatAdmin = new Admin();
            //        oCatAdmin.TabCodigo = "SCAT";
            //        FormsAuxiliares.frmFormAdminMini frmCat = new FormsAuxiliares.frmFormAdminMini(oCatAdmin, oCatPermiso);
            //        frmCat.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //        frmCat.ShowDialog();
            //        //Console.WriteLine("Case 1");
            //        break;
            //    case "frmSuministros":
            //        Console.WriteLine("Case 2");
            //        break;
            //    case "frmConceptosLecturas":
            //        FuncionalidadesFoms oCLPermiso = new FuncionalidadesFoms("100031", "100032", "100033", "100035", "100036", "100034");
            //        Admin oCLAdmin = new Admin();
            //        oCLAdmin.TabCodigo = "LEC";
            //        FormsAuxiliares.frmFormAdminMini frmbus = new FormsAuxiliares.frmFormAdminMini(oCLAdmin, oCLPermiso);
            //        frmbus.Text = "Administrador Lecturas Conceptos";
            //        frmbus.ShowDialog();
            //        break;
            //    case "frmModosLecturas":
            //        FuncionalidadesFoms oMLPermiso = new FuncionalidadesFoms("100041", "100042", "100043", "100045", "100046", "100044");
            //        Admin oMLAdmin = new Admin();
            //        oMLAdmin.TabCodigo = "LEM";
            //        FormsAuxiliares.frmFormAdminMini frmML = new FormsAuxiliares.frmFormAdminMini(oMLAdmin, oMLPermiso);
            //        frmML.Text = "Administrador de Modos Lecturas";
            //        frmML.ShowDialog();
            //        break;
            //    case "frmClientes":
            //        Console.WriteLine("Case 2");
            //        break;

            //}
        }

        private void AbrirFormulariosServicios() {
            string strFormulario = _oPrincipal.FormularioActivo(this.trvMenu.SelectedNode);

            switch (strFormulario)
            {
                case "frmSuministros":
                    FuncionalidadesFoms oPermiso = new FuncionalidadesFoms("100101", "100102", "100103", "100105", "100106", "100104");
                    //Se instancia un objeto de la clase formulario admin al cual se le pasa por parametro el COD_TABLA
                    frmSuministrosAdmin frmbus = new frmSuministrosAdmin("SUM", oPermiso);
                    frmbus.ShowDialog();
                    break;
                case "frmFabricantes":
                    FuncionalidadesFoms oFabPermiso = new FuncionalidadesFoms("41", "42", "43", "45", "46", "44");
                    Admin oFabAdmin = new Admin();
                    oFabAdmin.TabCodigo = "FAB";
                    FormsAuxiliares.frmFormAdminMini frmFab = new FormsAuxiliares.frmFormAdminMini(oFabAdmin, oFabPermiso);
                    frmFab.Text = "Administrador Fabricantes";
                    frmFab.ShowDialog();
                    break;
                case "frmTiposMedidores":
                    FuncionalidadesFoms oTMPermiso = new FuncionalidadesFoms("100021", "100022", "100023", "100025", "100026", "10024");
                    Admin oAdmin = new Admin();
                    oAdmin.TabCodigo = "TME";
                    FormsAuxiliares.frmFormAdminMini frmTM = new FormsAuxiliares.frmFormAdminMini(oAdmin, oTMPermiso);
                    frmTM.Text = "Administrador Tipos de Medidores";
                    frmTM.ShowDialog();
                    break;
                case "frmModelosMedidiores":
                    FuncionalidadesFoms oMMPermiso = new FuncionalidadesFoms("10031", "10032", "10033", "10035", "10036", "10034");
                    Admin oMMAdmin = new Admin();
                    oMMAdmin.TabCodigo = "MEM";
                    FormsAuxiliares.frmFormAdmin frmMM = new FormsAuxiliares.frmFormAdmin(oMMAdmin, oMMPermiso);
                    frmMM.ShowDialog();
                    break;
                case "frmCalles":
                    FuncionalidadesFoms oCallPermiso = new FuncionalidadesFoms("21", "22", "23", "25", "26", "24");
                    Admin oCallAdmin = new Admin();
                    oCallAdmin.TabCodigo = "CALB";
                    oCallAdmin.Tipo = Admin.enumTipoForm.SelectorMultiSeleccion;
                    FormsAuxiliares.frmFormAdminMini frmCall = new FormsAuxiliares.frmFormAdminMini(oCallAdmin, oCallPermiso);
                    frmCall.ShowDialog();
                    break;
                case "frmBarrios":
                    FormsAuxiliares.frmCrudGrilla frmBar = new FormsAuxiliares.frmCrudGrilla("BAR", "NUMERO", true);
                    frmBar.ShowDialog();
                    break;
                case "frmLocalidades":
                    FormsAuxiliares.frmCrudGrilla frmLoc = new FormsAuxiliares.frmCrudGrilla("LOC", "NUMERO", true);
                    frmLoc.ShowDialog();
                    break;
                case "frmDomicilios":
                    FuncionalidadesFoms oDomPermiso = new FuncionalidadesFoms("31", "32", "33", "35", "36", "34");
                    Admin oDomAdmin = new Admin();
                    oDomAdmin.TabCodigo = "DOMB";
                    FormsAuxiliares.frmFormAdmin frm = new FormsAuxiliares.frmFormAdmin(oDomAdmin, oDomPermiso);
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
                    FuncionalidadesFoms oCatPermiso = new FuncionalidadesFoms("100011", "100012", "100013", "100016", "100014", "100015");
                    Admin oCatAdmin = new Admin();
                    oCatAdmin.TabCodigo = "SCAT";
                    FormsAuxiliares.frmFormAdminMini frmCat = new FormsAuxiliares.frmFormAdminMini(oCatAdmin, oCatPermiso);
                    frmCat.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                    frmCat.ShowDialog();
                    //Console.WriteLine("Case 1");
                    break;
                case "frmConceptosLecturas":
                    FuncionalidadesFoms oCLPermiso = new FuncionalidadesFoms("100031", "100032", "100033", "100035", "100036", "100034");
                    Admin oCLAdmin = new Admin();
                    oCLAdmin.TabCodigo = "LEC";
                    FormsAuxiliares.frmFormAdminMini frmCL = new FormsAuxiliares.frmFormAdminMini(oCLAdmin, oCLPermiso);
                    frmCL.Text = "Administrador Lecturas Conceptos";
                    frmCL.ShowDialog();
                    break;
                case "frmModosLecturas":
                    FuncionalidadesFoms oMLPermiso = new FuncionalidadesFoms("100041", "100042", "100043", "100045", "100046", "100044");
                    Admin oMLAdmin = new Admin();
                    oMLAdmin.TabCodigo = "LEM";
                    FormsAuxiliares.frmFormAdminMini frmML = new FormsAuxiliares.frmFormAdminMini(oMLAdmin, oMLPermiso);
                    frmML.Text = "Administrador de Modos Lecturas";
                    frmML.ShowDialog();
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
