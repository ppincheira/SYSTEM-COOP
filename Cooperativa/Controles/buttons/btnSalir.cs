using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.buttons
{
    public partial class btnSalir : gesButton
    {
        public btnSalir() {
            Size = new System.Drawing.Size(40, 40);
            BackgroundImage = Resources.Iconos.salida;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            objects.tttEtiqueta ttt = new objects.tttEtiqueta();
            ttt.SetToolTip(this, "Salir");
            //Text = "";
        }
    }
}
