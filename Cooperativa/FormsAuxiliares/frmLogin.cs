using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Business;
using Model;
using System.Data;
using Controles;
using Microsoft.VisualBasic.PowerPacks;
using AppProcesos.formsAuxiliares.formLogin;
using Controles.form;

namespace FormsAuxiliares
{
    public partial class frmLogin: gesForm,IVistaLogin
    {
        #region << PROPIEDADES >>
        private string _Subsistema;
        private UILogin _oLogin;
        
       
        private Controles.textBoxes.txtDescripcionCorta txtUsuario;
        private Controles.textBoxes.txtPassword txtPassword;
        private Controles.labels.lblTitulo lblTitulo1;
        private ShapeContainer shapeContainer1;
        private RectangleShape rectangleShape2;
        private RectangleShape rectangleShape3;
        private Controles.contenedores.pnlPanelEstado pnlPanelEstado1;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private RectangleShape rectangleShape1;

        public string usuario {
            get { return this.txtUsuario.Text; }
            set { this.txtUsuario.Text = value; }
        }
        public string password
        {
            get
            { return this.txtPassword.Text; }
            set
            { this.txtPassword.Text = value; }
        }

  //      public string login { set => throw new NotImplementedException(); }
        #endregion
        #region <<METODOS>>
        public frmLogin(string subsistema)
        {
            this.Text = "LOGIN";
            _Subsistema = subsistema;
            InitializeComponent();
            _oLogin = new UILogin(this);
        }

        private void InitializeComponent()
        {
            this.txtPassword = new Controles.textBoxes.txtPassword();
            this.txtUsuario = new Controles.textBoxes.txtDescripcionCorta();
            this.lblTitulo1 = new Controles.labels.lblTitulo();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pnlPanelEstado1 = new Controles.contenedores.pnlPanelEstado();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.pnlPanelEstado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(63, 193);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.Location = new System.Drawing.Point(63, 107);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 24);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitulo1.Location = new System.Drawing.Point(102, 27);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(99, 31);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "LOGIN";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(309, 352);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(220)))));
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape3.CornerRadius = 4;
            this.rectangleShape3.Location = new System.Drawing.Point(18, 285);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(271, 54);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.White;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape2.Location = new System.Drawing.Point(19, 179);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(271, 57);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Location = new System.Drawing.Point(19, 91);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(271, 57);
            // 
            // pnlPanelEstado1
            // 
            this.pnlPanelEstado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(220)))));
            this.pnlPanelEstado1.Controls.Add(this.lblEtiqueta1);
            this.pnlPanelEstado1.Location = new System.Drawing.Point(19, 294);
            this.pnlPanelEstado1.Name = "pnlPanelEstado1";
            this.pnlPanelEstado1.Size = new System.Drawing.Size(264, 34);
            this.pnlPanelEstado1.TabIndex = 4;
            this.pnlPanelEstado1.Click += new System.EventHandler(this.pnlPanelEstado1_Click);
            this.pnlPanelEstado1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanelEstado1_Paint);
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta1.ForeColor = System.Drawing.Color.White;
            this.lblEtiqueta1.Location = new System.Drawing.Point(91, 3);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(65, 25);
            this.lblEtiqueta1.TabIndex = 0;
            this.lblEtiqueta1.Text = "Login";
            this.lblEtiqueta1.Click += new System.EventHandler(this.lblEtiqueta1_Click);
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(309, 352);
            this.Controls.Add(this.pnlPanelEstado1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlPanelEstado1.ResumeLayout(false);
            this.pnlPanelEstado1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  
       #endregion
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            txtUsuario.Text = "usuario";
            txtUsuario.ForeColor = System.Drawing.Color.Gray;
            txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = "password";
            txtPassword.ForeColor = System.Drawing.Color.Gray;
            txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = System.Drawing.Color.Black;
            if (txtUsuario.Text == "usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.ForeColor = System.Drawing.Color.Black;
            if (txtPassword.Text == "PASSWORD") {
                txtPassword.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") {
                txtUsuario.Text = "usuario";
                txtUsuario.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void pnlPanelEstado1_Click(object sender, EventArgs e)
        {
            long usuario = _oLogin.validar();
            if ( usuario!= 0)
            {
                //obtener la persona del login
                ;
                    frmPrincipal frm = new frmPrincipal(_Subsistema);
                frm.Text = _Subsistema;
                frm.toolStripStatusLabel1.Text = _Subsistema + _oLogin.nombreUsuario(usuario);
                frm.Show();
            }
        }

        private void lblEtiqueta1_Click(object sender, EventArgs e)
        {
            pnlPanelEstado1_Click(pnlPanelEstado1, new EventArgs());   
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = System.Drawing.Color.Black;
        }

        private void pnlPanelEstado1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
