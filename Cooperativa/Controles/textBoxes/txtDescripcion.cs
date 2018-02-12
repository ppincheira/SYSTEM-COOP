using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.textBoxes
{
    public partial class txtDescripcion : gesTextBox
    {
        public txtDescripcion()
        {
            this.MaxLength = 50;
            this.Width = 150;
            this.Height = 40;
        }
    }
}