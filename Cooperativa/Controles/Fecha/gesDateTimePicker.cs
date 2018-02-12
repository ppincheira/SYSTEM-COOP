using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Controles.util.Enumerados;

namespace Controles.Fecha
{
   
    public class gesDateTimePicker : System.Windows.Forms.DateTimePicker
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

        public gesDateTimePicker()
        {//Iniciamos los valores por defecto
            InitializeComponent();

        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gesDateTimePicker));

            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();

            this.SuspendLayout();
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ResumeLayout(false);

        }
    }
}
