using System;
using System.Collections.Generic;
using Implement;
using Model;
using System.Data;

namespace Business
{
    public class EstadosBus
    {
        public int EstadosAdd(Estados oEstados)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosAdd(oEstados);
        }

        public bool EstadosUpdate(Estados oEstados)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosUpdate(oEstados);
        }

        public bool EstadosDelete(String Id)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosDelete(Id);
        }

        public Estados EstadosGetById(string Id)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosGetById(Id);
        }

        public List<Estados> EstadosGetAll()
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosGetAll();
        }
        public DataTable EstadosGetByFilterDT(string tabNombre, string estColumnaTabla)
        {
            EstadosImpl oEstadosImpl = new EstadosImpl();
            return oEstadosImpl.EstadosGetByFilterDT(tabNombre,estColumnaTabla);
        }

     }
}
