using Business;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AppProcesos.formsAuxiliares.frmTelefonos
{
    public class UITelefonosCrud
    {
        private IVistaTelefonosCrud _vista;
        Utility oUtil;

        public UITelefonosCrud(IVistaTelefonosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {           
            //MessageBox.Show("paso 1 SelectedValue " + _vista.telCargo.SelectedValue , "Cooperativa");
            //MessageBox.Show("paso 1 TelCargo " + oTel.TelCargo, "Cooperativa");
            DominiosBus oDonBus = new DominiosBus();
            oUtil.CargarCombo(_vista.telCargo, oDonBus.DominiosGetByFilter("CARGO_CONTACTO_TEL"), "dmn_valor", "dmn_descripcion", "Seleccione Cargo");
            oUtil.CargarCombo(_vista.telTipo, oDonBus.DominiosGetByFilter("TIPO_TELEFONO"), "dmn_valor", "dmn_descripcion", "Seleccione Tipo");
           // _vista.telCargo.DropDownStyle = ComboBoxStyle.DropDownList;
           // _vista.telTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (_vista.telCodigo != 0)
            {                
                Telefonos oTel = new Telefonos();
                TelefonosBus oTelBus = new TelefonosBus();
                oTel = oTelBus.TelefonosGetById(_vista.telCodigo);
                _vista.telNumero = oTel.TelNumero;
                if (oTel.TelDefecto == "S")
                    _vista.telDefecto = true;
                else
                    _vista.telDefecto = false;
                _vista.telEmail = oTel.TelEmail;
                _vista.telNombreContacto = oTel.TelNombreContacto;
                _vista.telCargo.SelectedValue = oTel.TelCargo; ;
                _vista.telTipo.SelectedValue = oTel.TelTipo;
            }                  
        }
        public void Guardar()
        {           
            long rtdo;
            Telefonos oTel = new Telefonos();
            TelefonosBus oTelBus = new TelefonosBus();

            oTel.TelCodigo = _vista.telCodigo;
            oTel.TelNumero = _vista.telNumero;
            oTel.TelCargo = _vista.telCargo.SelectedValue.ToString();
            oTel.TelTipo = _vista.telTipo.SelectedValue.ToString();
            oTel.TelEmail = _vista.telEmail;
            oTel.TelNombreContacto = _vista.telNombreContacto;
            oTel.TabCodigo = _vista.tabCodigo;
            oTel.TelCodigoRegistro = _vista.telCodigoRegistro;
            if (_vista.telDefecto)
                oTel.TelDefecto = "S";
            else
                oTel.TelDefecto = "N";

            if (_vista.telCodigo == 0)            
                rtdo = oTelBus.TelefonosAdd(oTel);                          
            else            
            rtdo = (oTelBus.TelefonosUpdate(oTel)) ? oTel.TelCodigo : 0;            
        }
    }
}
