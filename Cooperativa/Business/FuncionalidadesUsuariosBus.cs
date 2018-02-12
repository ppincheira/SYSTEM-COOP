 using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class FuncionalidadesUsuariosBus
    {
        public int FuncionalidadesUsuariosAdd(FuncionalidadesUsuarios oFuncionalidadesUsuarios)
        {
            FuncionalidadesUsuariosImpl oFuncionalidadesUsuariosImpl = new FuncionalidadesUsuariosImpl();
            return oFuncionalidadesUsuariosImpl.FuncionalidadesUsuariosAdd(oFuncionalidadesUsuarios);
        }

        public bool FuncionalidadesUsuariosUpdate(FuncionalidadesUsuarios oFunActual, FuncionalidadesUsuarios oFunNuevo)
        {
            FuncionalidadesUsuariosImpl oFuncionalidadesUsuariosImpl = new FuncionalidadesUsuariosImpl();
            return oFuncionalidadesUsuariosImpl.FuncionalidadesUsuariosUpdate(oFunActual, oFunNuevo);
        }

        public bool FuncionalidadesUsuariosDelete(string Codigo, int Usuario, string Rol)
        {
            FuncionalidadesUsuariosImpl oFuncionalidadesUsuariosImpl = new FuncionalidadesUsuariosImpl();
            return oFuncionalidadesUsuariosImpl.FuncionalidadesUsuariosDelete(Codigo, Usuario, Rol);
        }


        public List<FuncionalidadesUsuarios> FuncionalidadesUsuariosGetAll()
        {
            FuncionalidadesUsuariosImpl oFuncionalidadesUsuariosImpl = new FuncionalidadesUsuariosImpl();
            return oFuncionalidadesUsuariosImpl.FuncionalidadesUsuariosGetAll();
        }
    }
}
