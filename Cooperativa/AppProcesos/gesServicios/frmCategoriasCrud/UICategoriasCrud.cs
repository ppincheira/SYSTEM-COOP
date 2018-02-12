using Business;
using Model;
using Service;
using System.Windows.Forms;

namespace AppProcesos.gesServicios.frmCategoriasCrud
{
    public class UICategoriasCrud
    {
        private IVistaCategoriasCrud _vista;
        Utility oUtil;

        public UICategoriasCrud(IVistaCategoriasCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            ServiciosBus oServiciosBus = new ServiciosBus();
            oUtil.CargarCombo(_vista.srvCodigo, oServiciosBus.ServiciosGetByFilter(), "srv_codigo", "srv_descripcion", "Seleccione un Servicio");

            GruposBus oGruposBus = new GruposBus();
            oUtil.CargarCombo(_vista.Grupo, oGruposBus.GruposGetByFilter("1"), "grp_codigo", "grp_descripcion", "Seleccione un Grupo");

           // _vista.srvCodigo.DropDownStyle = ComboBoxStyle.DropDownList;
           // _vista.Grupo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (_vista.scaNumero != 0)
            {
                ServiciosCategorias oSCategorias = new ServiciosCategorias();
                ServiciosCategoriasBus oSCategoriasBus = new ServiciosCategoriasBus();

                oSCategorias = oSCategoriasBus.ServiciosCategoriasGetById(_vista.scaNumero);
                _vista.srvCodigo.SelectedValue = oSCategorias.SrvCodigo;
                _vista.Descripcion = oSCategorias.ScaDescripcion;
                _vista.DescripcionCorta = oSCategorias.ScaDescripcionCorta;

                if (oSCategorias.EstCodigo == "H")
                    _vista.estCodigo = true;
                else
                    _vista.estCodigo = false;

                GruposDetalles oGrD = new GruposDetalles();
                GruposDetallesBus oGrDBus = new GruposDetallesBus();
                oGrD = oGrDBus.GruposDetallesGetByCodReg(_vista.scaNumero.ToString());
                _vista.grdCodigo = oGrD.GrdCodigo;
                _vista.grdCodigoRegistro = oGrD.GrdCodigoRegistro;
                _vista.Grupo.SelectedValue = oGrD.GrpCodigo;
            }
            else
                _vista.estCodigo = true; ;
        }

        public void Guardar()
        {
            long rtdo;
            ServiciosCategorias oSCa = new ServiciosCategorias();
            ServiciosCategoriasBus oSCaBus = new ServiciosCategoriasBus();

            oSCa.ScaNumero = _vista.scaNumero;
            oSCa.ScaDescripcion = _vista.Descripcion;
            oSCa.ScaDescripcionCorta = _vista.DescripcionCorta;
            oSCa.SrvCodigo = _vista.srvCodigo.SelectedValue.ToString();
            if (_vista.estCodigo)
                oSCa.EstCodigo = "H";
            else
                oSCa.EstCodigo = "I";

            GruposDetalles oGDe = new GruposDetalles();
            GruposDetallesBus oGDeBus = new GruposDetallesBus();
            oGDe.GrpCodigo = long.Parse(_vista.Grupo.SelectedValue.ToString());
            oGDe.GrdCodigo = _vista.grdCodigo;

            if (_vista.scaNumero == 0)
            {
                rtdo = oSCaBus.ServiciosCategoriasAdd(oSCa);
                oSCa.ScaNumero = rtdo;                
                oGDe.GrdCodigoRegistro = oSCa.ScaNumero.ToString();
                rtdo = oGDeBus.GruposDetallesAdd(oGDe);
            }
            else
            {
                rtdo = (oSCaBus.ServiciosCategoriasUpdate(oSCa)) ? oSCa.ScaNumero : 0;
                oGDe.GrdCodigoRegistro = _vista.grdCodigoRegistro;               
                rtdo = (oGDeBus.GruposDetallesUpdate(oGDe)) ? oGDe.GrdCodigo : 0;
            }
        }
        public bool EliminarCategoria(long idCategoria)
        {
            ServiciosCategoriasBus oSCaBus = new ServiciosCategoriasBus();
            ServiciosCategorias oSCa = oSCaBus.ServiciosCategoriasGetById(idCategoria);
            oSCa.EstCodigo = "B";
            return oSCaBus.ServiciosCategoriasUpdate(oSCa);
        }

    }
}
