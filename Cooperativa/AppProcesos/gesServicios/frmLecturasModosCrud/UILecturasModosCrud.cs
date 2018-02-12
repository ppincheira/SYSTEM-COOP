using Business;
using Controles.datos;
using Model;
using Service;
using System;
using System.Collections.Generic;
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

        public UILecturasModosCrud(IVistaLecturasModosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }


        public void Inicializar()
        {
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
        //        oSMeBus.
                if (oSLecturas.conceptos.Count > 0)
                {
                 /*   foreach (LecturasConceptos oLcAux in oSLecturas.conceptos)
                    {
                        _vista.cargarGrilla(oLcAux);
                        _vista.conceptos.DataSource = oSlcBus.LecturasConceptosGetAllDT().Rows;
                    }*/

                    for(int i = 0; i < oSLecturas.conceptos.Count; i++)
                    {
                        _vista.cargarGrilla(oSLecturas.conceptos[i],i);
                    }
                }
      
            }
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
            oSLecturas.conceptos = cargarConceptos(_vista.conceptos);
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
                if (a.Cells[0].Value != null)
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
    }
}
