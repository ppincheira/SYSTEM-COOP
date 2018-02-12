using Business;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmMiniListado
{
    public class UIMiniListado
    {

        private IVistaMiniListado _vista;
        Utility oUtil;



        public UIMiniListado(IVistaMiniListado vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            TelefonosBus oTelefonosBus = new TelefonosBus();
            DataTable dt= oTelefonosBus.TelefonosGetByFilter("PERB", "1");
            
            oUtil.CargarGrilla(_vista.gviListado,dt);
            _vista.gviListado.Columns[0].Visible = false;
            _vista.gviListado.Columns[1].Width = 300;
            _vista.gviListado.Columns[1].HeaderText = "TELEFONOS";
            _vista.gviListado.Columns[2].Visible = false;
            _vista.gviListado.Columns[3].HeaderText = "TIPO";
            _vista.gviListado.Columns[4].Visible = false;
            _vista.gviListado.Columns[5].Visible = false;
            _vista.gviListado.Columns[6].Visible = false;
            _vista.gviListado.Columns[7].Visible = false;
            _vista.gviListado.Columns[8].Visible = false;


        }




    }
}
