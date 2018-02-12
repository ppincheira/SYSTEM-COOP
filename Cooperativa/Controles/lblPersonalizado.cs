using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Drawing;

namespace Controles
{
    public class lblPersonalizado : System.Windows.Forms.Label
    {
   
        //Constructor
        public lblPersonalizado()
        {//Iniciamos los valores por defecto
            ForeColor = System.Drawing.Color.Green;
            AutoSize = false;
            Text = "completar";
            
            Size tam = new Size();
            tam.Height = 10;
            tam.Width = 50;
            Width = 100;


        }
       
        //Sobreescrivimos los metodos del textbox
        
    }
}
