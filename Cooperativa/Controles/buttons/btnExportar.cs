using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.buttons
{
    public partial class btnExportar: gesButton
    {
        public btnExportar()
        {
            //Image = Resources.Iconos.nuevo;
            Size = new System.Drawing.Size(40, 40);
            BackgroundImage = Resources.Iconos.excel;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            objects.tttEtiqueta ttt = new objects.tttEtiqueta();
            ttt.SetToolTip(this, "Exportar regitros");
            //Text = "N";
            //Size = this.BackgroundImage.Size;
        }
    }
}
