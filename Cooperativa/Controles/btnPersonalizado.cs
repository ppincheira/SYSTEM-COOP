using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Drawing;

namespace Controles
{
    public class btnPersonalizado : System.Windows.Forms.Button
    {
   
        //Constructor
        public btnPersonalizado()
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
