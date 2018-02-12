using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.textBoxes
{
    public partial class txtDescripcionCorta:gesTextBox
    {
        public txtDescripcionCorta()
        {
            this.MaxLength = 20;
            this.Width = 150;
            this.Height= 40;
        }
    }
}
