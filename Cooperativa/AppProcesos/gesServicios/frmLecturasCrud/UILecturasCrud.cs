using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmLecturasCrud
{
    public class UILecturasCrud
    {

        private IVistaLecturasCrud _vista;
        Utility oUtil;


        public UILecturasCrud(IVistaLecturasCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }
    }
}
