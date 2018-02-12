using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Controles.textBoxes
{
    public partial class txtEmail : System.Windows.Forms.TextBox
    {
        public txtEmail()
        {
            this.MaxLength = 50;
            this.Width = 150;
            this.Height = 40;
        }
        public bool emailValido()
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (this.Text == "")
            {                
                return true;
            }

            if (Regex.IsMatch(this.Text, expresion))
            {
                if (Regex.Replace(this.Text, expresion, String.Empty).Length == 0)
                {
                    //formato valido
                    this.BackColor = System.Drawing.Color.Green;
                    return true;
                }
                else
                {                   
                    this.BackColor = System.Drawing.Color.Red;
                    this.Focus();
                    return false;
                }                                    
            }
            else
            {                
                this.BackColor = System.Drawing.Color.Red;
                this.Focus();
                return false;
            }                            
        }
    }
}