using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmCalles
{
    public class UICallesCrud
    {
        private IVistaCallesCrud _vista;
        Utility oUtil;


        public UICallesCrud(IVistaCallesCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }




        public void Inicializar()
        {

            LocalidadesBus oLocalidadesBus = new LocalidadesBus();

            oUtil.CargarCombo(_vista.cmbLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(_vista.codigoProvincia),"LOC_NUMERO","LOC_DESCRIPCION");
            if (_vista.codigo != 0)
            {
                CallesLocalidades oCalle = new CallesLocalidades();
                CallesLocalidadesBus oCallesBus = new CallesLocalidadesBus();

                oCalle = oCallesBus.CallesLocalidadesGetById(_vista.codigo);
                _vista.cmbLocalidad.SelectedValue = oCalle.LocNumero;
                _vista.txtDescripcion = oCalle.CalDescripcion;
            }

        }

        public void Guardar()
        {
            CallesLocalidades oCalle = new CallesLocalidades();
            CallesLocalidadesBus oCallesBus = new CallesLocalidadesBus();

            oCalle.CalDescripcion = _vista.txtDescripcion;
            oCalle.LocNumero = int.Parse(_vista.cmbLocalidad.SelectedValue.ToString());
            if (_vista.codigo == 0)
                oCallesBus.CallesLocalidadesAdd(oCalle);
            else {
                oCalle.CalNumero = long.Parse(_vista.codigo.ToString());
                oCallesBus.CallesLocalidadesUpdate(oCalle);
            }
        }


        }
}
