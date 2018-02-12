
using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.gesServicios.frmLecturasConceptosCrud
{
    public class UILecturasConceptosCrud
    {
        private IVistaLecturasConceptosCrud _vista;
        Utility oUtil;


        public UILecturasConceptosCrud(IVistaLecturasConceptosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            if (_vista.lecCodigo != 0)
            {
                LecturasConceptos oSLecturasCodigos = new LecturasConceptos();
                LecturasConceptosBus oSLecturasCodigosBus = new LecturasConceptosBus();

                oSLecturasCodigos = oSLecturasCodigosBus.LecturasConceptosGetById(_vista.lecCodigo);

                _vista.lecDescripcion = oSLecturasCodigos.LecDescripcion;
                _vista.lecDescripcionCorta = oSLecturasCodigos.LecDescripcionCorta;
                _vista.lecFechaAlta.Value = oSLecturasCodigos.LecFechaAlta;
                _vista.usrCodigo = oSLecturasCodigos.UsrCodigo;
                _vista.estCodigo = oSLecturasCodigos.EstCodigo;
            }
        }

        public long Guardar()
        {
            long rtdo= 0 ;
            LecturasConceptos oSLecturasCodigos = new LecturasConceptos();
            LecturasConceptosBus oSLecturasCodigosBus = new LecturasConceptosBus();

            oSLecturasCodigos.LecCodigo = _vista.lecCodigo;
            oSLecturasCodigos.LecDescripcion = _vista.lecDescripcion;
            oSLecturasCodigos.LecDescripcionCorta = _vista.lecDescripcionCorta;
            oSLecturasCodigos.LecFechaAlta = _vista.lecFechaAlta.Value;
            oSLecturasCodigos.UsrCodigo = _vista.usrCodigo;
            oSLecturasCodigos.EstCodigo = _vista.estCodigo;

            if (_vista.lecCodigo == 0)
                rtdo = oSLecturasCodigosBus.LecturasConceptosAdd(oSLecturasCodigos);
            else
                oSLecturasCodigosBus.LecturasConceptosUpdate(oSLecturasCodigos);

            return rtdo;
        }

        public bool EliminarLecturasConceptos(long id)
        {
            LecturasConceptosBus oSLecturasCodigosBus = new LecturasConceptosBus();
            LecturasConceptos oSLecturasCodigos = oSLecturasCodigosBus.LecturasConceptosGetById(id);
            oSLecturasCodigos.EstCodigo = "B";
            return oSLecturasCodigosBus.LecturasConceptosUpdate(oSLecturasCodigos);
        }
    }
}
