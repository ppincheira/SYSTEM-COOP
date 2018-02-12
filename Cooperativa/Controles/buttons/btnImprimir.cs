using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.buttons
{
    public partial class btnImprimir: gesButton
    {
        public btnImprimir()
        {
            //Image = Resources.Iconos.nuevo;
            Size = new System.Drawing.Size(40, 40);
            BackgroundImage = Resources.Iconos.imprimir;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            objects.tttEtiqueta ttt = new objects.tttEtiqueta();
            ttt.SetToolTip(this, "Imprimir registros");
            //Text = "N";
            //Size = this.BackgroundImage.Size;
        }
    }
}
