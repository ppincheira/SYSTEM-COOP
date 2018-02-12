using Business;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProcesos.formsAuxiliares.frmObservaciones
{
    public class UIObservaciones
    {


        private IVistaObservaciones _vista;
        Utility oUtil;

    

        public UIObservaciones(IVistaObservaciones vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            ObservacionesBus oObsBus = new ObservacionesBus();
            _vista.fechaDesde = DateTime.Now.AddYears(-1);
            _vista.fechaHasta = DateTime.Now.AddDays(1);
            _vista.cantidad = "Nro de Observaciones:" + oUtil.CargarGrilla(_vista.grilla, oObsBus.ObservacionesGetByFilter(_vista.oAdminObs, _vista.fechaDesde, _vista.fechaHasta)).ToString();
            _vista.grilla.Columns["OBS_CODIGO"].Visible = false;
            _vista.grilla.Columns["OBS_CODIGO_REGISTRO"].Visible = false;
            _vista.grilla.Columns["TOB_CODIGO"].Visible = false;
        }



        public void CargarGrilla() {
            ObservacionesBus oObsBus = new ObservacionesBus();
            _vista.cantidad = "Nro de Observaciones:"+oUtil.CargarGrilla(_vista.grilla, oObsBus.ObservacionesGetByFilter(_vista.oAdminObs, _vista.fechaDesde, _vista.fechaHasta)).ToString();
        }

   

        public void CargarDetalle(DataGridViewRow row) {

            _vista.detalle = row.Cells[3].Value.ToString();
            _vista.striRdoCodigo = row.Cells[0].Value.ToString();
        }
    }
}
