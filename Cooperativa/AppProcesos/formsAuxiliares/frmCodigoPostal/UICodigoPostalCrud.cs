using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmCodigoPostal
{
    public class UICodigoPostalCrud
    {

        private IVistaCodigoPostalCrud _vista;
        Utility oUtil;


        public UICodigoPostalCrud(IVistaCodigoPostalCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }




        public void Inicializar()
        {

            LocalidadesBus oLocalidadesBus = new LocalidadesBus();

            oUtil.CargarCombo(_vista.cmbiLocalidad, oLocalidadesBus.LocalidadesGetByProvincia(_vista.codigoProvincia), "LOC_NUMERO", "LOC_DESCRIPCION");
            if (_vista.cplNumero != 0)
            {
                CodigosPostalesLocalidades oCodPostal = new CodigosPostalesLocalidades();
                CodigosPostalesLocalidadesBus oCodPostalBus = new CodigosPostalesLocalidadesBus();

                oCodPostal = oCodPostalBus.CodigosPostalesLocalidadesGetById(_vista.cplNumero);
                _vista.cmbiLocalidad.SelectedValue = oCodPostal.LocNumero;
                _vista.txtiDescripcion = oCodPostal.CplDescripcion;
                _vista.txtiCodigoPostal = oCodPostal.CplCodigoPostal;
            }

        }

        public void Guardar()
        {
            CodigosPostalesLocalidades oCodPost = new CodigosPostalesLocalidades();
            CodigosPostalesLocalidadesBus oCodPostBus = new CodigosPostalesLocalidadesBus();
            oCodPost.CplCodigoPostal = _vista.txtiCodigoPostal;
            oCodPost.CplDescripcion = _vista.txtiDescripcion;
          
            oCodPost.LocNumero = int.Parse(_vista.cmbiLocalidad.SelectedValue.ToString());


            if (_vista.cplNumero == 0)
                oCodPostBus.CodigosPostalesLocalidadesAdd(oCodPost);
            else
            {
                oCodPost.CplNumero = _vista.cplNumero;
                oCodPostBus.CodigosPostalesLocalidadesUpdate(oCodPost);
            }
        }

    }
}
