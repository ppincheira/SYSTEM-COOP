
///////////////////////////////////////////////////////////////////////////
//
// Creado por: Pincheira Pablo
//
///////////////////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
	public class TablasImpl
    {
        #region Tablas methods
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int TablasAdd(Tablas oTablas)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into TABLAS(TAB_CODIGO, TAB_NOMBRE, TAB_DESCRIPCION, TAB_QUERY_JOIN) " +
                    "values('"+oTablas.TabCodigo+"', '"+oTablas.TabNombre+"', '"+oTablas.TabDescripcion+"','"+oTablas.TabQueryJoin+"','"+oTablas.TabQueryFilter + "')",cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                return response;
            }
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool TablasUpdate(Tablas oTablas)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update TABLAS " +
                    "SET TAB_CODIGO='" + oTablas.TabCodigo + "',"+
                    "TAB_NOMBRE='"+ oTablas.TabNombre + "'," +
                    "TAB_DESCRIPCION= '" + oTablas.TabDescripcion + "' " +

                    "WHERE TAB_CODIGO='" + oTablas.TabCodigo + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool TablasDelete(String Id)
		{


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE TABLAS" +
                        "WHERE TAB_CODIGO='" + Id + "'",cn);
                    adapter = new OracleDataAdapter(cmd);
                    response = cmd.ExecuteNonQuery();
                    cn.Close();
                    if (response > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
               
	
		}

        public Tablas TablasGetById(string Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                string sqlSelect = "select * from tablas " +
                    "where TAB_CODIGO='"+ Id+"'";

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
           
               
                DataTable dt;
                dt = ds.Tables[0];
            
                Tablas NewEnt = new Tablas();

				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarTablas(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<Tablas> TablasGetAll()
		{
            List<Tablas> lstTablas = new List<Tablas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tablas ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable() ;
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                  for (int i = 0; dt.Rows.Count > i; i++)
                  {
                            DataRow dr = dt.Rows[i];
                            Tablas NewEnt = new Tablas();
                            NewEnt = CargarTablas(dr);
                            lstTablas.Add(NewEnt);
                  }
                }
                return lstTablas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private Tablas CargarTablas(DataRow dr)
		{
			try
			{
                Tablas oObjeto = new Tablas();
                oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                oObjeto.TabNombre = dr["TAB_NOMBRE"].ToString();
                oObjeto.TabDescripcion = dr["TAB_DESCRIPCION"].ToString();
                oObjeto.TabQueryJoin = dr["TAB_QUERY_JOIN"].ToString();
                oObjeto.TabQueryFilter = dr["TAB_QUERY_FILTER"].ToString();
                return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataTable TablasBusquedaGetAllFilter(string Tabla, string Campos, string filterCampos, string filterValores, string filterTabla )
         {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                //CAMPOS DE LA TABLA DE LA BASE DE DATOS
                string[] filterCamp = System.Text.RegularExpressions.Regex.Split(filterCampos, "&");
                //VALORES CARGADOS EN EL FORMULARIO
                string[] filterV = System.Text.RegularExpressions.Regex.Split(filterValores, "&");
                
                cn.Open();
                string sqlSelect = "SELECT  "+Campos+" FROM " + Tabla;
                 
                    sqlSelect=sqlSelect+" where  1=1";
                    for (int i = 0; i < filterCamp.Length; i++)
                    {

                        if  (filterV[i].Contains("%") && filterV[i] != "")
                        {
                            string[] filterFecha = System.Text.RegularExpressions.Regex.Split(filterV[i], "%");

                            sqlSelect += " AND ("+filterCamp[i] + " >=to_date('" + filterFecha[0] + "','dd/mm/yyyy')";
                            sqlSelect += " AND ";
                            sqlSelect += filterCamp[i] + " <=to_date('" + filterFecha[1]+ "','dd/mm/yyyy'))";
                        }
                        else { 
                            if  (filterCamp[i]!="")
                               sqlSelect += " AND "+filterCamp[i] + " like '%" + filterV[i]+"%'";
                        }
                    }


                if ((filterTabla != null) && (filterTabla != ""))
                    sqlSelect = sqlSelect + " AND " + filterTabla;


                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable();
                return dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private static void DisplayData(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                }
                Console.WriteLine("============================");
            }
        }
        private static void VerDataTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row.ItemArray[1].ToString());
                foreach (DataColumn col in table.Columns)
                {
                    if (col.ToString() == "COLUMN_NAME")
                        Console.Write("Campo: " + row[col] + " ");
                    if (col.ToString() == "DATATYPE")
                        Console.Write("Tipo: " + row[col] + " ");
                }
                Console.WriteLine();
            }
        }

        public void MostrarEstructura(string tabla)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();


                cn.Open();
//               Muestra la estructura de la tabla PERSONAS
                String[] tableRestrictions = new String[2];
                tableRestrictions[1] = "PERSONAS";
                DataTable table = cn.GetSchema("Columns", tableRestrictions);
                DisplayData(table);
                VerDataTable(table);
                Console.WriteLine("Press any key to continue.");
 //             Muestra la columna ARE_CODIGO de la tabla AREAS
                tableRestrictions = new String[3];
                tableRestrictions[1] = "AREAS";
                tableRestrictions[2] = "ARE_CODIGO";
                table = cn.GetSchema("Columns", tableRestrictions);
                DisplayData(table);
                VerDataTable(table);
                Console.WriteLine("Press any key to continue.");
                //Console.ReadKey();
                //OracleCommand cmd = new OracleCommand(comando, cn);
                //cmd.ExecuteNonQuery();
                return ;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable Estructura(string tabla)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();


                cn.Open();
                //               Muestra la estructura de la tabla PERSONAS
                String[] tableRestrictions = new String[2];
                tableRestrictions[1] = tabla;
                return  cn.GetSchema("Columns", tableRestrictions);
  
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool TablaActualizaGrid(string tabla, string[] columnas, string[] valores, string criterio, string operacion)
        {
            string comando = "";
            switch (operacion)
            {
                case "U":
                    comando = "update " + tabla + " set ";
                    for (int pos = 0; pos < columnas.Length; pos++)
                    {
                        comando += columnas[pos] + " = '" + valores[pos] + "'";
                        if (columnas.Length > pos + 1)
                            comando += ", ";
                    };
                    comando += " where " + criterio;
                    break;

                case "D":
                    comando = "delete " + tabla + " where " + criterio;
                    break;

                case "I":
                    comando = "insert into " + tabla;
                    string listaCampos = "";
                    string listaValores = "";
                    for (int pos = 0; pos < columnas.Length; pos++)
                    {
                        listaCampos += columnas[pos];
                        listaValores += "'" + valores[pos] + "'";
                        if (columnas.Length > pos + 1)
                        {
                            listaCampos += ", ";
                            listaValores += ", ";

                        }
                    };
                    comando += " ( " + listaCampos + ") values(" + listaValores + ")";
                    break;
                default: return false;
            }
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();

                cn.Open();
                OracleCommand cmd = new OracleCommand(comando, cn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                
            }

        }

        #endregion

    }
}
