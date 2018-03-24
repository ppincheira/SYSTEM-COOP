﻿using Business;
using Model;
using Service;
using System;

namespace AppProcesos.gesServicios.frmSuministrosCrud
{
    public class UISuministrosCrud
    {
        private IVistaSuministrosCrud _vista;
        Utility oUtil;

        public UISuministrosCrud(IVistaSuministrosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
            //Obtengo los tipos de contadores
            ServiciosBus oServicios = new ServiciosBus();
            oUtil.CargarCombo(_vista.Servicio, oServicios.ServiciosGetAllDT(), "SRV_CODIGO", "SRV_DESCRIPCION", "SELECCIONE..");

            //// Obtengo las Zonas
            GruposBus oZonas = new GruposBus();
            oUtil.CargarCombo(_vista.Zona, oZonas.GruposGetByFilter("2"), "GRP_CODIGO", "GRP_DESCRIPCION", "SELECCIONE..");

            //// Obtengo los estados de suministros
            EstadosBus oEstados = new EstadosBus();
            oUtil.CargarCombo(_vista.EstCodigo, oEstados.EstadosGetByFilterDT("SUMINISTROS", "EST_CODIGO"), "EST_CODIGO", "EST_DESCRIPCION", "SELECCIONE..");

            if (_vista.Numero != 0)
            {
                Suministros oSuministros = new Suministros();
                SuministrosBus oSuministrosBus = new SuministrosBus();
                //Obtengo datos de la entidad principal que trabajo
                oSuministros = oSuministrosBus.SuministrosGetById(_vista.Numero);
                _vista.Servicio.SelectedValue = oSuministros.SrvCodigo;
                _vista.TipoConexion.SelectedValue = oSuministros.TcsCodigo;
                _vista.Categoria.SelectedValue = oSuministros.ScaNumero;
                _vista.OrdenRuta = oSuministros.SumOrdenRuta;
                _vista.EmpNumero = oSuministros.EmpNumero;
                _vista.FechaAlta = oSuministros.SumFechaAlta;
                _vista.EstCodigo.SelectedValue = oSuministros.EstCodigo;
                _vista.ConsumoEstimado = oSuministros.SumConsumoEstimado;
                _vista.Voltaje = oSuministros.SumVoltaje;
                _vista.Conexion = oSuministros.SumConexion;
                _vista.PotenciaL1 = oSuministros.SumPotenciaL1;
                _vista.PotenciaL2 = oSuministros.SumPotenciaL2;
                _vista.PotenciaL3 = oSuministros.SumPotenciaL3;
                _vista.PermiteCorte = oSuministros.SumPermiteCorte;
                _vista.Medido = oSuministros.SumMedido;
                _vista.Ruta.SelectedValue = oSuministros.SruNumero;
                _vista.Zona.SelectedValue = oSuministros.SzoNumero;
                _vista.PermiteFactura = oSuministros.SumPermiteFactura;
                _vista.FechaCarga = oSuministros.SumFechaCarga;
                _vista.Registrador = oSuministros.SumRegistrador;
            }
        }



        public void Guardar()
        {
            long rtdo;
            Suministros oSum = new Suministros();
            SuministrosBus oSumBus = new SuministrosBus();
            //Cargar los datos ingresados al objeto

            oSum.SumNumero = _vista.Numero;
            oSum.SrvCodigo = _vista.Servicio.SelectedValue.ToString();
            oSum.TcsCodigo = _vista.TipoConexion.SelectedValue.ToString();
            oSum.ScaNumero = long.Parse(_vista.Categoria.SelectedValue.ToString());
            oSum.SumOrdenRuta = _vista.OrdenRuta;
            oSum.EmpNumero = _vista.EmpNumero;
            oSum.SumFechaAlta = _vista.FechaAlta;
            oSum.EstCodigo = _vista.EstCodigo.SelectedValue.ToString();
            oSum.SumConsumoEstimado = _vista.ConsumoEstimado;
            oSum.SumVoltaje = _vista.Voltaje;
            oSum.SumConexion = _vista.Conexion;
            oSum.SumPotenciaL1 = _vista.PotenciaL1;
            oSum.SumPotenciaL2 = _vista.PotenciaL2;
            oSum.SumPotenciaL3 = _vista.PotenciaL3;
            oSum.SumPermiteCorte = _vista.PermiteCorte;
            oSum.SumMedido = _vista.Medido;
            oSum.SruNumero = int.Parse(_vista.Ruta.SelectedValue.ToString());
            oSum.SzoNumero = int.Parse(_vista.Zona.SelectedValue.ToString());
            oSum.SumPermiteFactura = _vista.PermiteFactura;
            oSum.SumFechaCarga = _vista.FechaCarga;
            oSum.SumRegistrador = _vista.Registrador;

            SuministrosMedidores oSMe = new SuministrosMedidores();
            SuministrosMedidoresBus oSMeBus = new SuministrosMedidoresBus();

            if (_vista.Numero == 0){
                oSum.SumNumero =  oSumBus.SuministrosAdd(oSum);
                DomiciliosEntidades oDEn = new DomiciliosEntidades();
                DomiciliosEntidadesBus oDEnBus = new DomiciliosEntidadesBus();
                oDEn.TdoCodigo = "C";
                oDEn.DenCodigoRegistro = oSum.SumNumero;
                oDEn.TabCodigo = "SUM";
                oDEn.DomCodigo = _vista.numDomicilio;
                oDEnBus.DomiciliosEntidadesAdd(oDEn);
                oSMe.SmeFechaAlta = oSum.SumFechaAlta;
                oSMe.EstCodigo = oSum.EstCodigo;
                oSMe.MedNumero = _vista.numMedidor;
                oSMe.SumNumero = oSum.SumNumero;
                oSMe.SmeNumero = oSMeBus.SuministrosMedidoresAdd(oSMe);
                Medidores oMed = new Medidores();
                MedidoresBus oMedBus = new MedidoresBus();
                oMed = oMedBus.MedidoresGetById(oSMe.MedNumero);
                oMed.EstCodigo = "I";
                oMedBus.MedidoresUpdate(oMed);

            }
            else
                rtdo = (oSumBus.SuministrosUpdate(oSum)) ? oSum.SumNumero : 0;
        }

        public bool EliminarSuministro(long idMedidor)
        {
            SuministrosBus oSumBus = new SuministrosBus();
            Suministros oSum = oSumBus.SuministrosGetById(idMedidor);
            oSum.EstCodigo = "B";
            return oSumBus.SuministrosUpdate(oSum);
       }

        public void CargarCliente(long id)
        {
            Empresas oEmpresa = new Empresas();
            EmpresasBus oEmpresasBus = new EmpresasBus();
            oEmpresa = oEmpresasBus.EmpresasGetById(id);
            _vista.EmpNumero = oEmpresa.EmpNumero;
            _vista.strRazonSocial = oEmpresa.EmpRazonSocial;
            _vista.strEmpDocumentoNumero = oEmpresa.EmpDocumentoNumero;
            CargarSocio(oEmpresa.EmpNumero);
            _vista.strRespIva = oEmpresa.TivCodigo;
                //CargarTipoIva(oEmpresa.TivCodigo);
            _vista.strTipoDoc = oEmpresa.TidCodigo;
            //CargarTipoDni(oEmpresa.TidCodigo);
            CargarDomicilio(oEmpresa.EmpNumero);

        }
        private void CargarTipoIva(string id)
        {
            TiposIva oTipoIva = new TiposIva();
            TiposIvaBus oTipoIvaBus = new TiposIvaBus();
            oTipoIva= oTipoIvaBus.TiposIvaGetById(id);
            _vista.strRespIva= oTipoIva.TivDescripcion;
        }
        private void CargarTipoDni(string id)
        {
            TiposIdentificadores oTipoDoc = new TiposIdentificadores();
            TiposIdentificadoresBus oTiposDocsBus = new TiposIdentificadoresBus();
            oTipoDoc = oTiposDocsBus.TiposIdentificadoresGetById(id);
            _vista.strTipoDoc = oTipoDoc.TidDescripcion;
        }
        private void CargarSocio(long id)
        {
            Accionistas oSocio = new Accionistas();
            AccionistasBus oSocioBus = new AccionistasBus();
            oSocio = oSocioBus.AccionistasGetById(id);
            _vista.numSocio = oSocio.AccNumero;
        }
        public void CargarDomicilio(long idEntidad)
        {
            Domicilios oDomicilio = new Domicilios();
            DomiciliosBus oDomicilioBus = new DomiciliosBus();
            //oDomicilio = oDomicilioBus.DomiciliosGetById(id);
            oDomicilio = oDomicilioBus.DomiciliosGetByCodigoRegistroDefecto(idEntidad, "CLIE");
            if (oDomicilio.DomCodigo != 0)
            {
                CallesLocalidadesBus oCalleBus = new CallesLocalidadesBus();
                _vista.strDomicilioEmpresa = oCalleBus.CallesLocalidadesGetById(oDomicilio.CalNumero).CalDescripcion + " Nro.: " + oDomicilio.DomNumero + " "
                    + " Dpto:" + oDomicilio.DomDepartamento;
            }

        }
        public Domicilios CargarDomicilioSum(long idEntidad)
        {
            Domicilios oDomicilio = new Domicilios();
            DomiciliosBus oDomicilioBus = new DomiciliosBus();
            oDomicilio = oDomicilioBus.DomiciliosGetById(idEntidad);
            _vista.numDomicilio = oDomicilio.DomCodigo;
            return oDomicilio;
            //oDomicilioBus.DomiciliosGetByCodigoRegistroDefecto(idEntidad, tabCodigo);
        }
        public void CargarCategorias()
        {
            ServiciosCategoriasBus oCategoriasBus = new ServiciosCategoriasBus();
            oUtil.CargarCombo(_vista.Categoria, oCategoriasBus.ServiciosCategoriasGetbySrv(_vista.Servicio.SelectedValue.ToString()), "SCA_NUMERO", "SCA_DESCRIPCION", "SELECCIONE..");
        }
        public void CargarRutas()
        {
            //Rutas pertenecientes a zona seleccionada es el grupo (GRP_CODIGO) cuyo tipo de grupo de zonas (TGR_CODIGO)"2"
            // Las Rutas estan relacionads con las zonas en Gupos_detalles (GRD_CODIGO_REGISTRO=SRU_NUMERO)

            // Obtengo de grupos_detalles las rutas guardadas en codigo_registro y para cada registro busco la ruta y armo la lista
            // o sea juntar las rutas de una determinada zona
            Grupos oZona = new Grupos();
            GruposBus oZonaBus = new GruposBus();
            oZona = oZonaBus.GruposGetById(long.Parse(_vista.Zona.SelectedValue.ToString()));

            ServiciosRutasBus oRutasBus = new ServiciosRutasBus();
            oUtil.CargarCombo(_vista.Ruta, oRutasBus.ServiciosRutasGetByGrupo(oZona.GrpCodigo,"2"), "SRU_NUMERO", "SRU_DESCRIPCION", "SELECCIONE..");

        }
        public void CargarTiposConexiones()
        {
            // Obtengo los grupos del Tipo de conexiones
            TipoConexionServiciosBus oTiposConexiones = new TipoConexionServiciosBus();
            oUtil.CargarCombo(_vista.TipoConexion, oTiposConexiones.TipoConexionServiciosGetByServicioDT(_vista.Servicio.SelectedValue.ToString()), "TCS_CODIGO", "TCS_DESCRIPCION", "SELECCIONE..");
        }

        public void CargarMedidor(long Id)
        {
            short ModMedidor=0;
            Medidores oMedidor = new Medidores();
            MedidoresBus oMedidoresBus = new MedidoresBus();
            oMedidor = oMedidoresBus.MedidoresGetById(Id);
            _vista.numMedidor = Id;
            _vista.numSerieMedidor = oMedidor.MedNumeroserie;
            MedidoresModelos oMedidorModelo = new MedidoresModelos();
            MedidoresModelosBus oMedModeloBus = new MedidoresModelosBus();
            if (oMedidor.MmoCodigo.ToString() != "")
               ModMedidor = short.Parse(oMedidor.MmoCodigo.ToString());
            oMedidorModelo = oMedModeloBus.MedidoresModelosGetById(ModMedidor);
            _vista.strModeloMedidor = oMedidorModelo.MMoDescripcion;
            TiposMedidoresBus oTipoMedBus = new TiposMedidoresBus();
            _vista.strTipoMedidor = oTipoMedBus.TiposMedidoresGetById(oMedidorModelo.TmeCodigo.ToString()).TmeDescripcion;
            FabricantesBus oFabricantesBus = new FabricantesBus();
            _vista.strFabricante = oFabricantesBus.FabricantesGetById(oMedidorModelo.FabNumero).FabDescripcion;
            LecturasModosBus oLecturasModosBus = new LecturasModosBus();
            _vista.strLecturaModo = oLecturasModosBus.LecturasModosGetById(oMedidor.LemCodigo).lemDescripcion;

        }

    }
}
