using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmDomicilios
{
    public class UIDomiciliosCrud
    {

        private IVistaDomiciliosCrud _vista;
        Utility oUtil;


        public UIDomiciliosCrud(IVistaDomiciliosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            LocalidadesBus oLocalidadesBus = new LocalidadesBus();
            CallesLocalidadesBus oCallesLocBus = new CallesLocalidadesBus();
            DominiosBus oDominioBus = new DominiosBus();
            oUtil.CargarCombo(_vista.cmbiLocalidad,oLocalidadesBus.LocalidadesGetByProvincia("NQ"),"LOC_NUMERO","LOC_DESCRIPCION","SELECCIONE..");
            oUtil.CargarCombo(_vista.cmbiTipo, oDominioBus.DominiosGetByFilter("TIPO_DOMICILIO"), "DMN_VALOR", "DMN_DESCRIPCION", "SELECCIONE TIPO DE DOMICILIO");
            if (_vista.domCodigo != 0)
            {
                Domicilios oDomicilio = new Domicilios();
                DomiciliosBus oDomicilioBus = new DomiciliosBus();
                CodigosPostalesLocalidadesBus oCodPosLocBus = new CodigosPostalesLocalidadesBus();
                BarriosLocalidadesBus oBarrioLocBus = new BarriosLocalidadesBus();
                oDomicilio = oDomicilioBus.DomiciliosGetById(_vista.domCodigo);
                _vista.bloque = oDomicilio.DomBloque;
                _vista.cmbiLocalidad.SelectedValue = oDomicilio.LocNumero;
                oUtil.CargarCombo(_vista.cmbiBarrio, oBarrioLocBus.BarriosLocalidadesGetByLocalidadDT(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "BAR_NUMERO", "BAR_DESCRIPCION", "SELECCIONE BARRIO..");
                oUtil.CargarCombo(_vista.cmbiCalle, oCallesLocBus.CallesLocalidadesGetByLocalidad(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "CAL_NUMERO", "CAL_DESCRIPCION", "SELECCIONE CALLE..");
                oUtil.CargarCombo(_vista.cmbiCalleDesde, oCallesLocBus.CallesLocalidadesGetByLocalidad(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "CAL_NUMERO", "CAL_DESCRIPCION", "SELECCIONE CALLE..");
                oUtil.CargarCombo(_vista.cmbiCalleHasta, oCallesLocBus.CallesLocalidadesGetByLocalidad(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "CAL_NUMERO", "CAL_DESCRIPCION", "SELECCIONE CALLE..");
                oUtil.CargarCombo(_vista.cmbiCodigoPostal, oCodPosLocBus.CodigosPostalesLocalidadesGetByLocalidad(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "CPL_NUMERO", "CPL_DESCRIPCION", "SELECCIONE LOCALIDAD..");
                _vista.cmbiBarrio.SelectedValue = oDomicilio.BarNumero;
                _vista.cmbiCalle.SelectedValue = oDomicilio.CalNumero;
                _vista.cmbiCalleDesde.SelectedValue = oDomicilio.CalNumeroDesde;
                _vista.cmbiCalleHasta.SelectedValue = oDomicilio.CalNumeroHasta;
                _vista.cmbiCodigoPostal.SelectedValue = oDomicilio.CplNumero;
                _vista.departamento = oDomicilio.DomDepartamento;
                _vista.gisX = oDomicilio.DomGisX;
                _vista.gisY = oDomicilio.DomGisY;
                _vista.numero = oDomicilio.DomNumero;
                _vista.parcela = oDomicilio.DomParcela;
                _vista.piso = oDomicilio.DomPiso;
                _vista.lote = oDomicilio.DomLote;
            }

        }

        public void CargarCallesCodigoPostal()
        {
            if (_vista.cmbiLocalidad.SelectedIndex > 0) { 
                CallesLocalidadesBus oCalleBus = new CallesLocalidadesBus();
                CodigosPostalesLocalidadesBus oCodPosLocBus = new CodigosPostalesLocalidadesBus();
                BarriosLocalidadesBus oBarrioLocBus = new BarriosLocalidadesBus();
                oUtil.CargarCombo(_vista.cmbiCalle,oCalleBus.CallesLocalidadesGetByLocalidad(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "CAL_NUMERO", "CAL_DESCRIPCION", "SELECCIONE CALLE..");
                oUtil.CargarCombo(_vista.cmbiCalleDesde, oCalleBus.CallesLocalidadesGetByLocalidad(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "CAL_NUMERO", "CAL_DESCRIPCION", "SELECCIONE CALLE..");
                oUtil.CargarCombo(_vista.cmbiCalleHasta, oCalleBus.CallesLocalidadesGetByLocalidad(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "CAL_NUMERO", "CAL_DESCRIPCION", "SELECCIONE CALLE..");
                oUtil.CargarCombo(_vista.cmbiCodigoPostal, oCodPosLocBus.CodigosPostalesLocalidadesGetByLocalidad(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())),"CPL_NUMERO", "CPL_DESCRIPCION", "SELECCIONE LOCALIDAD..");
                oUtil.CargarCombo(_vista.cmbiBarrio, oBarrioLocBus.BarriosLocalidadesGetByLocalidadDT(int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString())), "BAR_NUMERO", "BAR_DESCRIPCION", "SELECCIONE BARRIO..");
            }
        }

        public void Guardar(Admin oAdmin)
        {
            long rtdo;
            Domicilios oDomicilio = new Domicilios();
            DomiciliosBus oDomicilioBus = new DomiciliosBus();
            oDomicilio.DomCodigo = _vista.domCodigo;
            oDomicilio.CalNumero =long.Parse( _vista.cmbiCalle.SelectedValue.ToString());
            oDomicilio.CalNumeroDesde = long.Parse(_vista.cmbiCalleDesde.SelectedValue.ToString());
            oDomicilio.CalNumeroHasta = long.Parse(_vista.cmbiCalleHasta.SelectedValue.ToString());
            oDomicilio.CplNumero = long.Parse(_vista.cmbiCodigoPostal.SelectedValue.ToString());
            oDomicilio.BarNumero = long.Parse(_vista.cmbiBarrio.SelectedValue.ToString());
            oDomicilio.DomBloque = _vista.bloque;
            oDomicilio.DomDepartamento = _vista.departamento;
            oDomicilio.DomGisX = _vista.gisX;
            oDomicilio.DomGisY = _vista.gisY;
            oDomicilio.DomLote = _vista.lote;
            oDomicilio.DomNumero = _vista.numero;
            oDomicilio.DomParcela = _vista.parcela;
            oDomicilio.DomPiso = _vista.piso;
            oDomicilio.LocNumero = int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString());
            DomiciliosEntidadesBus oDomEntidadesBus = new DomiciliosEntidadesBus();
            DomiciliosEntidades oDomEntidades = new DomiciliosEntidades();

            if (_vista.domCodigo == 0) {
                rtdo = oDomicilioBus.DomiciliosAdd(oDomicilio);
                oDomEntidades.TdoCodigo = _vista.cmbiTipo.SelectedValue.ToString();
                oDomEntidades.DomCodigo = rtdo;
                if (_vista.denDefecto)
                    oDomEntidades.DenDefecto = "S";
                else
                    oDomEntidades.DenDefecto = "N";
                oDomEntidades.DenCodigoRegistro = long.Parse(oAdmin.CodigoRegistro);
                oDomEntidades.TabCodigo = oAdmin.TabCodigoRegistro;
                oDomEntidadesBus.DomiciliosEntidadesAdd(oDomEntidades);
            }
            else {
                oDomEntidades = oDomEntidadesBus.DomiciliosEntidadesGetByCodigo(oDomicilio.DomCodigo);
                oDomEntidades.TdoCodigo = _vista.cmbiTipo.SelectedValue.ToString();
                if (_vista.denDefecto)
                    oDomEntidades.DenDefecto = "S";
                else
                    oDomEntidades.DenDefecto = "N";
                oDomEntidades.DenCodigoRegistro = long.Parse(oAdmin.CodigoRegistro);
                oDomEntidades.TabCodigo = oAdmin.TabCodigoRegistro;
                oDomEntidadesBus.DomiciliosEntidadesUpdate(oDomEntidades);
                rtdo = (oDomicilioBus.DomiciliosUpdate(oDomicilio)) ? oDomicilio.DomCodigo : 0;
            }
        }

    }

}
