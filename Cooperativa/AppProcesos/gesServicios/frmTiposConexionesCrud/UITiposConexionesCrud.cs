using Business;
using Model;
using Service;

namespace AppProcesos.gesServicios.frmTiposConexionesCrud
{
    public class UITiposConexionesCrud
    {
        private IVistaTiposConexionesCrud _vista;
        Utility oUtil;

        public UITiposConexionesCrud(IVistaTiposConexionesCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            ServiciosBus oServiciosBus = new ServiciosBus();
       
            oUtil.CargarCombo(_vista.srvCodigo, oServiciosBus.ServiciosGetAllDT(), "SRV_CODIGO", "SRV_DESCRIPCION", "SELECCIONE..");

            if (!string.IsNullOrEmpty(_vista.tcsCodigo) || _vista.tcsCodigo!="")
            {
                TipoConexionServicios oSConexion = new TipoConexionServicios();
                TipoConexionServiciosBus oSConexionBus = new TipoConexionServiciosBus();

                oSConexion = oSConexionBus.TipoConexionServiciosGetById(_vista.tcsCodigo);
                _vista.tcsCodigo = oSConexion.TcsCodigo;
                _vista.srvCodigo.SelectedValue = oSConexion.SrvCodigo;
                _vista.tcsDescripcion = oSConexion.TcsDescripcion;
                _vista.tcsDescripcionCorta = oSConexion.TcsDescripcionCorta;
                _vista.estCodigo = oSConexion.EstCodigo;
                _vista.nuevo = false;
            }
            else
                _vista.nuevo = true;
        }

        public void Guardar()
        {
            long rtdo;
            TipoConexionServicios oSConexion = new TipoConexionServicios();
            TipoConexionServiciosBus oSMeBus = new TipoConexionServiciosBus();

            oSConexion.TcsDescripcion = _vista.tcsDescripcion;
            oSConexion.TcsDescripcionCorta = _vista.tcsDescripcionCorta;
            oSConexion.SrvCodigo = _vista.srvCodigo.SelectedValue.ToString();
            oSConexion.TcsCodigo = _vista.tcsCodigo;
            oSConexion.EstCodigo = _vista.estCodigo;

            if (_vista.nuevo)
                rtdo = oSMeBus.TipoConexionServiciosAdd(oSConexion);
            else
                 oSMeBus.TipoConexionServiciosUpdate(oSConexion);
        }

        public bool EliminarConexion(string idConexion)
        {
            TipoConexionServiciosBus oTCSBus = new TipoConexionServiciosBus();
            TipoConexionServicios oTCS = oTCSBus.TipoConexionServiciosGetById(idConexion);
            oTCS.EstCodigo = "B";
            return oTCSBus.TipoConexionServiciosUpdate(oTCS);
        }


    }
}
