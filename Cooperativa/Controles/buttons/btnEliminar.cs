﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.buttons
{
    public partial class btnEliminar:gesButton
    {
        public btnEliminar()
        {
            //Image = Resources.Iconos.nuevo;
            Size = new System.Drawing.Size(40, 40);
            BackgroundImage = Resources.Iconos.eliminar;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            objects.tttEtiqueta ttt = new objects.tttEtiqueta();
            ttt.SetToolTip(this, "Eliminar registro");
            //Text = "N";
            //Size = this.BackgroundImage.Size;
        }
    }
}
