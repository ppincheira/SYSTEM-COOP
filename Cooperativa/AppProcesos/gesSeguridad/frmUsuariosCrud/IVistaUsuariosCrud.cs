using Controles.datos;
using System;

namespace AppProcesos.gesSeguridad.frmUsuariosCrud
{
    public interface IVistaUsuariosCrud
    {
        int intUsrNumero { get; set; }
        long logPrsNumero { get; set; }
        string strPrsDescripcion { get; set; }
        string strUsrNombre { get; set; }
        string strUsrClave { get; set; }
        cmbLista cmbUsrPerfil { get; set; }        
        DateTime? datUsrAlta { get; set; }
        DateTime? datUsrBaja { get; set; }
        Boolean booUsrBloqueado { get; set; }
        Boolean booUsrEstado { get; set; }
    }
}
