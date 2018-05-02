using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class UsuariosBus
    {
        public int UsuariosAdd(Usuarios oUsuarios)
        {
            UsuariosImpl oUsuariosImpl = new UsuariosImpl();
            return oUsuariosImpl.UsuariosAdd(oUsuarios);
        }

        public bool UsuariosUpdate(Usuarios oUsuarios)
        {
            UsuariosImpl oUsuariosImpl = new UsuariosImpl();
            return oUsuariosImpl.UsuariosUpdate(oUsuarios);
        }

        public bool UsuariosDelete(String Id)
        {
            UsuariosImpl oUsuariosImpl = new UsuariosImpl();
            return oUsuariosImpl.UsuariosDelete(Id);
        }

        public Usuarios UsuariosGetById(int Id)
        {
            UsuariosImpl oUsuariosImpl = new UsuariosImpl();
            return oUsuariosImpl.UsuariosGetById(Id);
        }

        public List<Usuarios> UsuariosGetAll()
        {
            UsuariosImpl oUsuariosImpl = new UsuariosImpl();
            return oUsuariosImpl.UsuariosGetAll();
        }
        public Usuarios UsuariosLogin(String user, String password)
        {
            UsuariosImpl oUsuariosImpl = new UsuariosImpl();
            return oUsuariosImpl.UsuariosLogin(user, password);
        }
        public Usuarios PersonaUsuarios(string idPersona)
        {
            UsuariosImpl oUsuariosImpl = new UsuariosImpl();
            return oUsuariosImpl.PersonaUsuarios(idPersona);
        }
    }
}
