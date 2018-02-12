using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Controles.util.Enumerados;

namespace Controles.datos
{
    public class gesCheckbox : System.Windows.Forms.CheckBox
    {
        public string REQUERIDO = "NO";
        private IContainer components;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private enumRequerido requerido = enumRequerido.NO;
        public enumRequerido Requerido
        {
            get { return requerido; }
            set
            {
                requerido = value;
                if (value == enumRequerido.SI)
                {
                    errorProvider2.SetError(this, "Campo Requerido");
                    errorProvider2.SetIconPadding(this, 5);
                }
            }

        }

        public gesCheckbox()
        {//Iniciamos los valores por defecto
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gesCheckbox));
       
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();

            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 

            ////this.BackColor = System.Drawing.Color.White;
            //this.Layout += new System.Windows.Forms.LayoutEventHandler(this.GesTextBox_Layout);
            //// this.Leave += new System.EventHandler(this.Validarting); 
            //this.Validating += new CancelEventHandler(this.Validarting);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            //this.Enter += new System.EventHandler(this.GesTextBox_Enter);
            //((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            //this.VisibleChanged += new EventHandler(this.Validarting);
            this.ResumeLayout(false);

        }
    }
}
