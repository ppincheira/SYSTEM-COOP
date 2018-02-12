using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.buttons
{
    public partial class btnCancelar:gesButton
    {
        public btnCancelar() {
            //Text = "[ESC] CANCELAR";
            Image = Resources.Iconos.cancel;
            Size = new System.Drawing.Size(80, 60);
        }
    }
}
