using Business;
using Controles.datos;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmMedidoresCrud
{
    public class UITiposMedidoresCrud
    {
        private IVistaTiposMedidoresCrud _vista;
        Utility oUtil;

        public UITiposMedidoresCrud(IVistaTiposMedidoresCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            ServiciosBus oServiciosBus = new ServiciosBus();
       
            _vista.srvCodigo.DataSource = oServiciosBus.ServiciosGetAll();
            _vista.srvCodigo.DisplayMember = "SrvDescripcion";
            _vista.srvCodigo.ValueMember = "SrvCodigo";
    
            if (_vista.tmeCodigo != 0)
                {
                TiposMedidores oSMedidor = new TiposMedidores();
                TiposMedidoresBus oSMedidorBus = new TiposMedidoresBus();

                oSMedidor = oSMedidorBus.TiposMedidoresGetById(_vista.tmeCodigo.ToString());
                _vista.tmeCodigo = oSMedidor.TmeCodigo;
                _vista.srvCodigo.SelectedValue = oSMedidor.SrvCodigo;
                _vista.tmeDescripcion = oSMedidor.TmeDescripcion;
                _vista.tmeDescripcionCorta = oSMedidor.TmeDescripcionCorta;
                _vista.tmeFechaCarga = oSMedidor.TmeFechaCarga;
                _vista.usrNumero = oSMedidor.UsrNumero;
                _vista.estCodigo = oSMedidor.EstCodigo;
                
            }
        }

        public void Guardar()
        {
            long rtdo;
            TiposMedidores oSMedidor = new TiposMedidores();
            TiposMedidoresBus oSMeBus = new TiposMedidoresBus();

            oSMedidor.UsrNumero = _vista.usrNumero;
            oSMedidor.TmeDescripcion = _vista.tmeDescripcion;
            oSMedidor.TmeDescripcionCorta = _vista.tmeDescripcionCorta;
            oSMedidor.SrvCodigo = _vista.srvCodigo.SelectedValue.ToString();
            oSMedidor.TmeFechaCarga = _vista.tmeFechaCarga;
            oSMedidor.TmeCodigo = _vista.tmeCodigo;
            oSMedidor.EstCodigo = _vista.estCodigo;

            if (_vista.tmeCodigo == 0)
                rtdo = oSMeBus.TiposMedidoresAdd(oSMedidor);
            else
                 oSMeBus.TiposMedidoresUpdate(oSMedidor);
        }

        public bool EliminarMedidor(long idMedidor)
        {
            TiposMedidoresBus oSMeBus = new TiposMedidoresBus();            
            TiposMedidores oSMe = oSMeBus.TiposMedidoresGetById(idMedidor.ToString());
            oSMe.EstCodigo = "B";
            return oSMeBus.TiposMedidoresUpdate(oSMe);
        }


    }
}
