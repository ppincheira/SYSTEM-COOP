using Business;
using Controles.datos;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProcesos.gesServicios.frmLecturasModosCrud
{
    public class UILecturasModosCrud
    {
        private IVistaLecturasModosCrud _vista;
        Utility oUtil;
        DataTable _dt;
        public UILecturasModosCrud(IVistaLecturasModosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
           
        }

        private DataTable InicializarDataTable()
        {
            _dt = new DataTable();
            _dt.Columns.Add("Id") ;
            _dt.Columns.Add("Abreviatura");
            _dt.Columns.Add("Descripcion");
            DataColumn[] myKey = new DataColumn[1];
            myKey[0] = _dt.Columns["Id"];
            _dt.PrimaryKey = myKey;

            return _dt;
        }

        

        private void AgregarFila(long intId, string strAbreviatura, string strDescripcion)
        {
            DataRow row = _dt.NewRow();
            row["Id"] = intId;
            row["Abreviatura"] = strAbreviatura;
            row["Descripcion"] = strDescripcion;
            _dt.Rows.Add(row);
            LimpiarFila();

        }

        private void LimpiarFila()
        {
            _dt.Rows.Find(0)["Abreviatura"]="";
            _dt.Rows.Find(0)["Descripcion"] = "";
        }
        public void Inicializar()
        {

            InicializarGrillaConceptos();
            ServiciosBus oServiciosBus = new ServiciosBus();
            oUtil.CargarCombo(_vista.srvCodigo, oServiciosBus.ServiciosGetAllDT(), "SRV_CODIGO", "SRV_DESCRIPCION", "Selecione un servicio..");
            if (_vista.lemCodigo != 0)
            {
                LecturasModos oSLecturas = new LecturasModos();
                LecturasModosBus oSMeBus = new LecturasModosBus();
                oSLecturas = oSMeBus.LecturasModosGetById(_vista.lemCodigo);
                _vista.lemCodigo = oSLecturas.lemCodigo;
                _vista.srvCodigo.SelectedValue = oSLecturas.srvCodigo;
                _vista.lemDescripcion = oSLecturas.lemDescripcion;
                _vista.estCodigo = oSLecturas.estCodigo;
                _vista.lemFechaCarga = oSLecturas.lemFechaCarga;
                _vista.usrCodigo = oSLecturas.usrCodigo;
                LecturasConceptosBus oSlcBus = new LecturasConceptosBus();
                if (oSLecturas.conceptos.Count > 0)
                {
                    for(int i = 0; i < oSLecturas.conceptos.Count; i++)
                    {
                        CargarGrilla(oSLecturas.conceptos[i],i);
                    }
                }
      
            }
        }

        private void InicializarGrillaConceptos()
        {

            InicializarDataTable();
            AgregarFila(0, "", "");
            oUtil.CargarGrillaOrderDesc(_vista.grdiLecturasConceptos, _dt);
            _vista.grdiLecturasConceptos.Columns[0].Visible = false;
            _vista.grdiLecturasConceptos.Columns[1].Width = 200;
            _vista.grdiLecturasConceptos.Columns[2].Width = 450;

        }

        public void CargarGrilla(LecturasConceptos olc, int rows)
        { 
            AgregarFila(olc.LecCodigo, olc.LecDescripcionCorta, olc.LecDescripcion);
            oUtil.CargarGrillaOrderDesc(_vista.grdiLecturasConceptos, _dt);    
        }


        private void reorganizarGrilla()
        {
            foreach (DataGridViewRow a in _vista.grdiLecturasConceptos.Rows)
            {
                if (a.Cells[0].Value == null || a.Cells[0].Value.ToString() == "")
                {
                    _vista.grdiLecturasConceptos.Rows.Remove(a);
                }
            }
            _vista.grdiLecturasConceptos.Rows.Add();
        }

        public void Guardar()
        {
            long rtdo;
            LecturasModos oSLecturas = new LecturasModos();
            LecturasModosBus oSMeBus = new LecturasModosBus();
            oSLecturas.usrCodigo = _vista.usrCodigo;
            oSLecturas.lemDescripcion = _vista.lemDescripcion;
            oSLecturas.lemFechaCarga = _vista.lemFechaCarga;
            oSLecturas.srvCodigo = _vista.srvCodigo.SelectedValue.ToString();
            oSLecturas.lemCodigo = _vista.lemCodigo;
            oSLecturas.estCodigo = _vista.estCodigo;
            oSLecturas.conceptos = cargarConceptos(_vista.grdiLecturasConceptos);
            if (_vista.lemCodigo == 0)
                rtdo = oSMeBus.LecturasModosAdd(oSLecturas);
            else
                oSMeBus.LecturasModosUpdate(oSLecturas);
        }

        private List<LecturasConceptos> cargarConceptos(grdGrillaEdit conceptos)
        {
            LecturasConceptosBus oSMeBus = new LecturasConceptosBus();


            List<LecturasConceptos> salida = new List<LecturasConceptos>();
            foreach (DataGridViewRow a in conceptos.Rows)
            {
                if ((a.Cells[0].Value != null) && (a.Cells[0].Value.ToString() != "0"))
                    salida.Add(oSMeBus.LecturasConceptosGetById(long.Parse(a.Cells[0].Value.ToString())));
            }
            return salida;
        }

        public bool EliminarModoLectura(long idLectura)
        {
            LecturasModosBus oSMeBus = new LecturasModosBus();
            LecturasModos oSMe = oSMeBus.LecturasModosGetById(idLectura);
            oSMe.estCodigo = "B";
            return oSMeBus.LecturasModosUpdate(oSMe);
        }

        public string CargarGrillaConceptos(string strValorCelda, int intColumna)
        {
            string strSalida = "0";
            DataTable dtDatos=null;
            if ((strValorCelda != "") && (strValorCelda != null))
            {
                dtDatos =new  LecturasConceptosBus().RecuperarLecturasConceptosDT(strValorCelda, intColumna);
                //En caso de no concordar, si es descripcion corta o descripcion 
                //se carga el formulario para agregarlo
                if (dtDatos.Rows.Count == 1)
                {
                   // oUtil.CargarGrilla(_vista.grdiLecturasConceptos, dtDatos);
                    AgregarFila(int.Parse(dtDatos.Rows[0]["LEC_CODIGO"].ToString()), dtDatos.Rows[0]["LEC_DESCRIPCION_CORTA"].ToString(), dtDatos.Rows[0]["LEC_DESCRIPCION"].ToString());
                     oUtil.CargarGrillaOrderDesc(_vista.grdiLecturasConceptos, _dt);
                    strSalida = "1";
                }
                if (dtDatos.Rows.Count > 1)
                    strSalida = "2";
                if (dtDatos.Rows.Count == 0)
                    strSalida = "3";
             }
            return strSalida;
        }
    }
}
