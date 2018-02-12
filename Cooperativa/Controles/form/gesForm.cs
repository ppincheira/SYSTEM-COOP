using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.form
{
    public class gesForm : System.Windows.Forms.Form
    {

        public Boolean VALIDARFORM = true;
        public gesForm() {
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // gesForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "gesForm";
            this.Load += new System.EventHandler(this.gesForm_Load);
            this.ResumeLayout(false);

        }

        private void gesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
