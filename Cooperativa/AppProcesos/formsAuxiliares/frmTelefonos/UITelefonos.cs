using Business;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmTelefonos
{
    public class UITelefonos
    {
        private IVistaTelefonos _vista;
        Utility oUtil;

        public UITelefonos(IVistaTelefonos vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }

        public void Inicializar()
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {            
            TelefonosBus oTelBus = new TelefonosBus();
            _vista.cantidad = "Nro de Telefonos:" + oUtil.CargarGrilla(_vista.grilla, oTelBus.TelefonosGetByFilter(_vista.tabCodigo, _vista.telCodigoRegistro)).ToString();
            _vista.grilla.Columns["tel_codigo_registro"].Visible = false;
            _vista.grilla.Columns["tab_codigo"].Visible = false;
            _vista.grilla.Columns["tel_codigo"].HeaderText = "Código";
            _vista.grilla.Columns["tel_numero"].HeaderText = "Nro.Telefono";
            _vista.grilla.Columns["tel_cargo"].HeaderText = "Cargo";
            _vista.grilla.Columns["tel_tipo"].HeaderText = "Tipo";
            _vista.grilla.Columns["tel_defecto"].HeaderText = "Por Defecto";
            _vista.grilla.Columns["tel_email"].HeaderText = "Email";
            _vista.grilla.Columns["tel_nombre_contacto"].HeaderText = "Nombre Contacto";
        }

        public void EliminarTelefono(long id)
        {            
            Boolean rtdo;           
            TelefonosBus oTelBus = new TelefonosBus();                       
            rtdo = (oTelBus.TelefonosDelete(id)) ;            
        }
    }
}
