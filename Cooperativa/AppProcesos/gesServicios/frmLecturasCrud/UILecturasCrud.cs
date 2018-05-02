using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Business;
using System.Data;
using Controles.datos;
using System.Windows.Forms;

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

        public void Inicializar()
        {
            _vista.dtFechaDesde = DateTime.Now.AddMonths(-1);
            _vista.dtFechaHasta = DateTime.Now;
         

        }

        public void CargarLecturaSuministro(long sumNumero)
        {

            //_vista.strSuministro = oLecSuministro.lesCodigo.ToString();

            Suministros oSuministro = new Suministros();
            SuministrosBus oSuministrosBus = new SuministrosBus();
            oSuministro = oSuministrosBus.SuministrosGetById(sumNumero);
            _vista.sumNumero = oSuministro.SumNumero;
            _vista.strSuministro = oSuministro.SumNumero.ToString();
            EstadosBus oEstadoBus = new EstadosBus();
            Estados oEstado = new Estados();
            oEstado = oEstadoBus.EstadosGetById(oSuministro.EstCodigo, "SUMINISTROS");
            _vista.strEstado = oEstado.EstDescripcion;
            ServiciosZonas oServicioZona = new ServiciosZonas();
            ServiciosZonasBus oServicioZonaBus = new ServiciosZonasBus();
            oServicioZona = oServicioZonaBus.ServiciosZonasGetById(oSuministro.SzoNumero);
            _vista.strZona = oServicioZona.SzoDescripcion;
            Empresas oEmpresa = new Empresas();
            EmpresasBus oEmpresaBus = new EmpresasBus();
            oEmpresa = oEmpresaBus.EmpresasGetById(oSuministro.EmpNumero);
            _vista.strCUIT = oEmpresa.EmpCuit;
            _vista.strTitular = oEmpresa.EmpRazonSocial == "" ? oEmpresa.EmpApellidos + " " + oEmpresa.EmpNombres : oEmpresa.EmpRazonSocial;
            /****Medidor ***/





            _vista.strRuta = oSuministro.SumOrdenRuta.ToString();
            _vista.strFechaAlta = oSuministro.SumFechaAlta.ToString("dd/MM/yyyy");
            _vista.strRegistrador = oSuministro.SumRegistrador.ToString();
           




        }
        public void FormatearGrilla() {
            _vista.grdiLecturas.Columns[0].Visible = false;
            _vista.grdiLecturas.Columns[1].Width = 200;
            _vista.grdiLecturas.Columns[2].Width = 70;
            _vista.grdiLecturas.Columns[3].Width = 70;
            _vista.grdiLecturas.Columns[4].Width = 80;
            _vista.grdiLecturas.Columns[5].Width = 80;
            _vista.grdiLecturas.Columns[6].Width = 70;
        }
        public void CargarLecturaAsociada()
        {
            LecturasSuministrosBus oLecSuministroBus = new LecturasSuministrosBus();
            LecturasSuministros oLecSuministro = new LecturasSuministros();

            DataTable dtLecturas = oLecSuministroBus.LecturasSuministrosGetByIdSuministro(long.Parse(_vista.strSuministro), _vista.strPeriodo, ObtenerEstados());
            oUtil.CargarGrilla(_vista.grdiLecturas, dtLecturas);
            FormatearGrilla();
        }

        private string ObtenerEstados()
        {
            string strEstados = "";
            if (_vista.chkiTodos.Checked == true)
                strEstados = "P&F&I&C";
            else {
                if (_vista.chkiPendiente.Checked == true)
                    strEstados = strEstados + "P&";
                if (_vista.chkiCorregido.Checked == true)
                    strEstados = strEstados + "C&";
                if (_vista.chkiFacturado.Checked == true)
                    strEstados = strEstados + "F&";
                if (_vista.chkiInstalado.Checked == true)
                    strEstados = strEstados + "I&";
            }
            return strEstados;
        }

        public void SetChkAll(){
            if (_vista.chkiTodos.Checked)
            {
                _vista.chkiTodos.Checked = true;
                _vista.chkiCorregido.Checked = true;
                _vista.chkiFacturado.Checked = true;
                _vista.chkiInstalado.Checked = true;
                _vista.chkiPendiente.Checked = true;
            }
            CargarLecturaAsociada();
        }

        public void setChkFacturado() {
            if (!_vista.chkiFacturado.Checked)
                _vista.chkiTodos.Checked = false;
            CargarLecturaAsociada();
        }
        public void setChkCorregido() {
            if (!_vista.chkiCorregido.Checked)
                _vista.chkiTodos.Checked = false;
            CargarLecturaAsociada();
        }

        public void setChkInstalado() {
            if (!_vista.chkiInstalado.Checked)
                _vista.chkiTodos.Checked = false;
            CargarLecturaAsociada();
        }

        public void setChkPendiente() {
            if (!_vista.chkiPendiente.Checked)
                _vista.chkiTodos.Checked = false;
            CargarLecturaAsociada();
        }


    

    public void Guardar()
    {
            long rtdo;
            LecturasSuministros oLecturaSuministro = new LecturasSuministros();
            
            oLecturaSuministro.Items = CargarLecturasItem(_vista.grdiLecturas);
            oLecturaSuministro.estCodigo = "";
            oLecturaSuministro.lemCodigo = 0;
            oLecturaSuministro.lesCodigo = 0;
            oLecturaSuministro.lesFechaAnterior = DateTime.Now;
            oLecturaSuministro.lesFechaAlta = DateTime.Now;
            oLecturaSuministro.lesPeriodo = "";
            oLecturaSuministro.medNumero =0;
            oLecturaSuministro.sruNumero = 0;
            oLecturaSuministro.sumNumero = 0;
            //if (_vista. == 0)
            //    rtdo = oSMeBus.LecturasModosAdd(oSLecturas);
            //else
            //oSMeBus.LecturasModosUpdate(oSLecturas);
    }

    private List<LecturasSuministrosItems> CargarLecturasItem(grdGrillaEdit grdSuministrosItem)
    {
    
        LecturasSuminitrosItemsBus oLecSumItemBus = new LecturasSuminitrosItemsBus();
        List<LecturasSuministrosItems>oListSumItem = new List<LecturasSuministrosItems>();
        foreach (DataGridViewRow dgrvRow in grdSuministrosItem.Rows)
        {
        if ((dgrvRow.Cells[0].Value != null) && (dgrvRow.Cells[0].Value.ToString() != "0")) { 
            LecturasSuministrosItems oLecSumItem = new LecturasSuministrosItems();
            oLecSumItem.lecCodigo = 0;
            oLecSumItem.lesCodigo = 0;
            oLecSumItem.lsiCantidadUnidades = 0;
            oLecSumItem.lsiDescripcion = "";
            oLecSumItem.lsiLecturaActual = 0;
            oLecSumItem.lsiLecturaAnterior = 0;
            oListSumItem.Add(oLecSumItem);
        }
    }
        return oListSumItem;
    }


}
}
