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
            // falta implementar la parate de medidor



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


    

    public void Guardar(long lonLesCodigo)
    {
            long rtdo;
            Suministros oSuministro = new Suministros();
            SuministrosBus oSuministroBus = new SuministrosBus();
            oSuministro = oSuministroBus.SuministrosGetById(_vista.sumNumero);
            LecturasSuministros oLecturaSuministro = new LecturasSuministros();
            LecturasSuministrosBus oLecturaSuministrosBus = new LecturasSuministrosBus();
            oLecturaSuministro.lesCodigo = 0;
            oLecturaSuministro.Items = CargarLecturasItem(_vista.grdiLecturas);
            oLecturaSuministro.estCodigo = "I";//Paso Instalado ver si es necesario poner un combo
            oLecturaSuministro.lemCodigo = 0;// Ver de Poner un combo 
            oLecturaSuministro.lesFechaAnterior = DateTime.MinValue;//coloco minima fecha despues en implement hay que preguntar si es ultima fecha
            oLecturaSuministro.lesFechaAlta = DateTime.Parse(_vista.strFechaAlta);
            oLecturaSuministro.lesPeriodo = _vista.strPeriodo.Remove(4, 1);
            oLecturaSuministro.medNumero = 2;// esto esta harcode falta ver como asociar la carga;
            oLecturaSuministro.sruNumero = oSuministro.SruNumero;
            oLecturaSuministro.sumNumero = _vista.sumNumero;

            if (lonLesCodigo == 0)
                rtdo = oLecturaSuministrosBus.LecturasSuministrosAdd(oLecturaSuministro);
            else
                oLecturaSuministrosBus.LecturasSuministrosUpdate(oLecturaSuministro);
    }

    private List<LecturasSuministrosItems> CargarLecturasItem(grdGrillaEdit grdSuministrosItem)
    {
    
        LecturasSuminitrosItemsBus oLecSumItemBus = new LecturasSuminitrosItemsBus();
        List<LecturasSuministrosItems>oListSumItem = new List<LecturasSuministrosItems>();
        foreach (DataGridViewRow dgrvRow in grdSuministrosItem.Rows)
        {
        if ((dgrvRow.Cells[0].Value != null) && (dgrvRow.Cells[0].Value.ToString() != "0")) { 
            LecturasSuministrosItems oLecSumItem = new LecturasSuministrosItems();
            oLecSumItem.lesCodigo = 0;
            oLecSumItem.lecCodigo = long.Parse(dgrvRow.Cells[1].Value.ToString());
            oLecSumItem.lsiCantidadUnidades = long.Parse(dgrvRow.Cells[9].Value.ToString());
            oLecSumItem.lsiDescripcion = dgrvRow.Cells[2].Value.ToString();
            oLecSumItem.lsiLecturaActual = long.Parse(dgrvRow.Cells[6].Value.ToString());
            oLecSumItem.lsiLecturaAnterior = long.Parse(dgrvRow.Cells[8].Value.ToString());
            oListSumItem.Add(oLecSumItem);
        }
    }
        return oListSumItem;
    }


}
}
