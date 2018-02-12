using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.textBoxes
{
    public partial class txtPassword:gesTextBox
    {
        public txtPassword()
        {
            this.PasswordChar = '*';
            this.MaxLength = 10;
            this.Width = 150;
            this.Height = 40;
        }
    }
}
