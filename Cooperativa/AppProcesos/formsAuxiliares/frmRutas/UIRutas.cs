using Business;
using Service;
using System;
using System.Windows.Forms;

namespace AppProcesos.formsAuxiliares.frmRutas
{
    public class UIRutas
    {


        private IVistaRutas _vista;
        Utility oUtil;

    

        public UIRutas(IVistaRutas vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            ServiciosRutasBus oSRuBus = new ServiciosRutasBus();
            //_vista.fechaDesde = DateTime.Now.AddYears(-1);
            //_vista.fechaHasta = DateTime.Now.AddDays(1);
            _vista.cantidad = "Nro de Rutas:" + oUtil.CargarGrilla(_vista.grilla, oSRuBus.ServiciosRutasGetAll(_vista.tabCodigo, _vista.tobCodigo, _vista.obsCodigoRegistro, _vista.fechaDesde, _vista.fechaHasta)).ToString();
            _vista.grilla.Columns["SRU_CODIGO"].Visible = false;
            _vista.grilla.Columns["SRU_DESCRIPCION"].Visible = false;
            _vista.grilla.Columns["SRU_NUMERO"].Visible = false;
       
        }



        public void CargarGrilla() {
            ServiciosRutasBus oSRuBus = new ServiciosRutasBus();
            _vista.cantidad = "Nro de Rutas:"+oUtil.CargarGrilla(_vista.grilla, oSRuBus.ServiciosRutasGetAll(_vista.tabCodigo, _vista.tobCodigo, _vista.obsCodigoRegistro, _vista.fechaDesde, _vista.fechaHasta)).ToString();
        }

   

        public void CargarDetalle(DataGridViewRow row) {

            _vista.detalle = row.Cells[3].Value.ToString();
        }
    }
}
