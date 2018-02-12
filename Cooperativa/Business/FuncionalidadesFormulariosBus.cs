using System;
using System.Collections.Generic;
using Implement;
using Model;

namespace Business
{
    public class FuncionalidadesFormulariosBus
    {

        public int FuncionalidadesFormulariosAdd(FuncionalidadesFormularios oFuncionalidades)
        {
            FuncionalidadesFormulariosImpl oFuncionalidadesImpl = new FuncionalidadesFormulariosImpl();
            return oFuncionalidadesImpl.FuncionalidadesFormulariosAdd(oFuncionalidades);
        }

        public bool FuncionalidadesFormulariosUpdate(FuncionalidadesFormularios oFuncionalidades)
        {
            FuncionalidadesFormulariosImpl oFuncionalidadesImpl = new FuncionalidadesFormulariosImpl();
            return oFuncionalidadesImpl.FuncionalidadesFormulariosUpdate(oFuncionalidades);
        }

        public bool FuncionalidadesFormulariosDelete(int Id)
        {
            FuncionalidadesFormulariosImpl oFuncionalidadesImpl = new FuncionalidadesFormulariosImpl();
            return oFuncionalidadesImpl.FuncionalidadesFormulariosDelete(Id);
        }

        public FuncionalidadesFormularios FuncionalidadesFormulariosGetById(int Id)
        {
            FuncionalidadesFormulariosImpl oFuncionalidadesImpl = new FuncionalidadesFormulariosImpl();
            return oFuncionalidadesImpl.FuncionalidadesFormulariosGetById(Id);
        }

        public List<FuncionalidadesFormularios> FuncionalidadesFormulariosGetAll()
        {
            FuncionalidadesFormulariosImpl oFuncionalidadesImpl = new FuncionalidadesFormulariosImpl();
            return oFuncionalidadesImpl.FuncionalidadesFormulariosGetAll();
        }
    }
}
