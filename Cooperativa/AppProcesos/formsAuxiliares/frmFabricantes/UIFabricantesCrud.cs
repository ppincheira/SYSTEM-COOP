using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmFabricantesCrud
{
    public class UIFabricantesCrud
    {
        private IVistaFabricantesCrud _vista;
        Utility oUtil;

        public UIFabricantesCrud(IVistaFabricantesCrud vista)
        {
            this._vista = vista;
            oUtil = new Utility();
        }

        //Revisar
        public void Inicializar()
        {



            // ACA SE DEVERIA CARGAR LOS VALORES DEL COMBOBOX
            /* DataTable test = new DataTable(empresa.EmpresasGetAll());
             test.
             oUtil.CargarCombo(_vista.empNumero, );*/
            if (_vista.fabNumero != 0)
            {
                Fabricantes oFabricante = new Fabricantes();
                FabricantesBus oFabreicanteBus = new FabricantesBus();
                oFabricante = oFabreicanteBus.FabricantesGetById(_vista.fabNumero);


                _vista.fabDescripcion = oFabricante.FabDescripcion;  
                switch (oFabricante.FabHabilitado)
                {
                    case "H": _vista.fabHabilitado.Checked = true;
                        break;
                    case "I": _vista.fabHabilitado.Checked = false;
                        break;
                }
                _vista.fabFechaCarga = new Controles.Fecha.dtpFecha();
                _vista.fabFechaCarga.Value = oFabricante.FabFechaCarga;
                _vista.usrNumero = oFabricante.UsrNumero;
                _vista.fabNumero = oFabricante.FabNumero;

            }

        }
        //REVISAR
        public void Guardar()
        {
            Fabricantes oFabricante = new Fabricantes();
            FabricantesBus oFabreicanteBus = new FabricantesBus();

            oFabricante.FabDescripcion = _vista.fabDescripcion;
            oFabricante.FabFechaCarga = _vista.fabFechaCarga.Value;

            if (_vista.fabHabilitado.Checked == true)
            {
                oFabricante.FabHabilitado = "H";
            }
            else
                oFabricante.FabHabilitado = "I";

            //Se tendra que remplazar con el numero de usuario que este logeado
            oFabricante.UsrNumero = 1;


            //REVISAR!!!!!!! TENGO QUE RECUPERAR EL NUMERO DE LA EMPRESA SELECCIONADA!!
            oFabricante.EmpNumero = _vista.empNumero.SelectedIndex;

            if (_vista.fabNumero == 0)
            {
                oFabreicanteBus.FabricantesAdd(oFabricante);
            }
            else
            {
                oFabricante.FabNumero = _vista.fabNumero;
                oFabreicanteBus.FabricantesUpdate(oFabricante);
            }
                

        }

        public bool Eliminar(long idFabricante)
        {
            Fabricantes oFabricante = new Fabricantes();
            FabricantesBus oFabreicanteBus = new FabricantesBus();
            oFabricante = oFabreicanteBus.FabricantesGetById(idFabricante);
            oFabricante.FabHabilitado = "B";
            return oFabreicanteBus.FabricantesUpdate(oFabricante);
        }    
    


    }
}
