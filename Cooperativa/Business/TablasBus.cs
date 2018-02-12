using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Implement;
using Model;

namespace Business
{
    public class TablasBus
    {
        public int TablasAdd(Tablas oTablas)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasAdd(oTablas);
        }

        public bool TablasUpdate(Tablas oTablas)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasUpdate(oTablas);
        }

        public bool TablasDelete(String Id)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasDelete(Id);
        }

        public Tablas TablasGetById(string Id)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasGetById(Id);
        }

        public List<Tablas> TablasGetAll()
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasGetAll();
        }

        public DataTable TablasBusquedaGetAllFilter(string Codigo, string Campos ,string filterCampos, string filterValores) {

            Tablas oTabla = new Tablas();
            oTabla = TablasGetById(Codigo);
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablasBusquedaGetAllFilter(oTabla.TabQueryJoin, Campos, filterCampos, filterValores, oTabla.TabQueryFilter);

        }
        public bool TablaActualizaGrid(string tabla, string[] columnas, string[] valores, string criterio, string operacion)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.TablaActualizaGrid(tabla, columnas, valores, criterio, operacion);
        }

        public void MostrarEstructura(string tabla)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            oTablasImpl.MostrarEstructura(tabla);
        }

        public DataTable Estructura(string tabla)
        {
            TablasImpl oTablasImpl = new TablasImpl();
            return oTablasImpl.Estructura(tabla);
        }
    }
}
