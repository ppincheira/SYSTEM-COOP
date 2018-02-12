using Business;
using Model;
using Service;
using System.Collections.Generic;

namespace AppProcesos.gesServicios.frmRutasCrud
{
    public class UIRutasCrud
    {
        private IVistaRutasCrud _vista;
        Utility oUtil;

        public UIRutasCrud(IVistaRutasCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            ServiciosBus oServiciosBus = new ServiciosBus();

            oUtil.CargarCombo(_vista.srvCodigo, oServiciosBus.ServiciosGetAllDT(), "SRV_CODIGO", "SRV_DESCRIPCION", "SELECCIONE..");

            // Obtengo los grupos del Tipo_grupo "2" que es Zonas
            GruposBus oGrupos = new GruposBus();
            oUtil.CargarCombo(_vista.grupo, oGrupos.GruposGetByFilter("2"), "GRP_CODIGO", "GRP_DESCRIPCION", "SELECCIONE..");

            if (_vista.sruNumero != 0)
            {
                ServiciosRutas oSRutas = new ServiciosRutas();
                ServiciosRutasBus oSRutasBus = new ServiciosRutasBus();

                oSRutas = oSRutasBus.ServiciosRutasGetById(_vista.sruNumero);
                _vista.srvCodigo.SelectedValue = oSRutas.SrvCodigo;
                _vista.Descripcion = oSRutas.SruDescripcion;
                _vista.DescripcionCorta = oSRutas.SruDescripcionCorta;
                _vista.estCodigo = oSRutas.EstCodigo;

                // Obtengo el Objeto Gupo_detalle cuyo codigo:registro=sruNumero
                GruposDetalles oGrD = new GruposDetalles();
                GruposDetallesBus oGrDBus = new GruposDetallesBus();
                oGrD = oGrDBus.GruposDetallesGetByCodReg(_vista.sruNumero.ToString());
                _vista.grdCodigo = oGrD.GrdCodigo;
                _vista.grdCodigoRegistro = oGrD.GrdCodigoRegistro;
                _vista.grupo.SelectedValue = oGrD.GrpCodigo;
            }
        }



        public void Guardar()
        {
            long rtdo;
            ServiciosRutas oSRu = new ServiciosRutas();
            ServiciosRutasBus oSRuBus = new ServiciosRutasBus();

            oSRu.SruNumero = _vista.sruNumero;
            oSRu.SruDescripcion = _vista.Descripcion;
            oSRu.SruDescripcionCorta = _vista.DescripcionCorta;
            oSRu.EstCodigo = _vista.estCodigo;
            oSRu.SrvCodigo = _vista.srvCodigo.SelectedValue.ToString();

            GruposDetalles oGDe = new GruposDetalles();
            GruposDetallesBus oGDeBus = new GruposDetallesBus();
            oGDe.GrpCodigo =long.Parse(_vista.grupo.SelectedValue.ToString());
            oGDe.GrdCodigo = _vista.grdCodigo;
            if (_vista.sruNumero == 0)
            {
                rtdo = oSRuBus.ServiciosRutasAdd(oSRu);
                oSRu.SruNumero = rtdo;
                //Creo un registro en Grupos_detalles con el grp_codigo seleccionado y el servicio de ruta en grd_codigo_registro
                oGDe.GrdCodigoRegistro = oSRu.SruNumero.ToString();
                rtdo = oGDeBus.GruposDetallesAdd(oGDe);
            }
            else
            {
                rtdo = (oSRuBus.ServiciosRutasUpdate(oSRu)) ? oSRu.SruNumero : 0;
                oGDe.GrdCodigoRegistro = _vista.grdCodigoRegistro;
                // Actualizo en Grupos_detalles para el grd_codigo actual el grp_codigo nuevo
                rtdo = (oGDeBus.GruposDetallesUpdate(oGDe)) ? oGDe.GrdCodigo : 0;
            }
        }

        public bool EliminarRuta(long idRuta)
        {
            ServiciosRutasBus oSRuBus = new ServiciosRutasBus();
            ServiciosRutas oSRu = oSRuBus.ServiciosRutasGetById(idRuta);
            oSRu.EstCodigo = "B";
            return oSRuBus.ServiciosRutasUpdate(oSRu);
       }


    }
}
