using Business;
using Model;
using Service;
using System.Windows.Forms;

namespace AppProcesos.gesSeguridad.frmUsuariosCrud
{
    public class UIUsuariosCrud
    {
        private IVistaUsuariosCrud _vista;
        Utility oUtil;

        public UIUsuariosCrud(IVistaUsuariosCrud vista)
        {
            _vista = vista;
            oUtil = new Utility();
        }
        public void Inicializar()
        {
            DominiosBus oDonBus = new DominiosBus();
            oUtil.CargarCombo(_vista.cmbUsrPerfil, oDonBus.DominiosGetByFilter("PERFIL_USR"), "dmn_valor", "dmn_descripcion", "Seleccione Perfil");
            PersonasBus oPerBus = new PersonasBus();
            oUtil.CargarCombo(_vista.cmbPrsNumero, oPerBus.PersonasGetByFilter(), "prs_numero", "prs_descripcion", "Seleccione una Persona");

            if (_vista.intUsrNumero != 0)
            {
                Usuarios oUsuarios = new Usuarios();
                UsuariosBus oUsuariosBus = new UsuariosBus();

                oUsuarios = oUsuariosBus.UsuariosGetById(_vista.intUsrNumero);
                _vista.cmbUsrPerfil.SelectedValue = oUsuarios.UsrPerfil;
                _vista.cmbPrsNumero.SelectedValue = oUsuarios.PrsNumero;
                _vista.strUsrNombre = oUsuarios.UsrNombre;
                _vista.strUsrClave = oUsuarios.UsrClave;
                _vista.datUsrAlta = oUsuarios.UsrFechaAlta;
                _vista.datUsrBaja = oUsuarios.UsrFechaBaja;                
                if (oUsuarios.UsrBloqueado == "S")
                    _vista.booUsrBloqueado = true;
                else
                    _vista.booUsrBloqueado = false;
            }
            else
            {
                _vista.booUsrBloqueado = false;
            }
                
        }

        public void Guardar()
        {
            long rtdo;
            Usuarios oUsuarios = new Usuarios();
            UsuariosBus oUsuariosBus = new UsuariosBus();

            oUsuarios.UsrPerfil = _vista.cmbUsrPerfil.SelectedValue.ToString();
            oUsuarios.PrsNumero = int.Parse(_vista.cmbPrsNumero.SelectedValue.ToString());
            oUsuarios.UsrNombre = _vista.strUsrNombre;
            oUsuarios.UsrClave = _vista.strUsrClave;
            oUsuarios.UsrFechaAlta = _vista.datUsrAlta;            
            if (_vista.booUsrBloqueado)
                oUsuarios.UsrBloqueado = "S";
            else
                oUsuarios.UsrBloqueado = "N";

            if (_vista.intUsrNumero == 0)
            {
                rtdo = oUsuariosBus.UsuariosAdd(oUsuarios);
            }
            else
            {
                rtdo = (oUsuariosBus.UsuariosUpdate(oUsuarios)) ? oUsuarios.UsrNumero : 0;
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {

            UsuariosBus oUsuariosBus = new UsuariosBus();
            Usuarios oUsuarios = oUsuariosBus.UsuariosGetById(idUsuario);
            oUsuarios.UsrBloqueado = "B";
            return oUsuariosBus.UsuariosUpdate(oUsuarios);
        }
    }
}
