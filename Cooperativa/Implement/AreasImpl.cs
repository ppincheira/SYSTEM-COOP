
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
	public class AreasImpl
    {
        #region Areas methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int AreasAdd(Areas oArea)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into Areas(ARE_CODIGO, ARE_DESCRIPCION) " +
                    "values('"+oArea.AreCodigo+"', '"+oArea.AreDescripcion+"')",cn);
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

        public bool AreasUpdate(Areas oArea)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Areas " +
                    "SET ARE_CODIGO='" + oArea.AreCodigo + "',"+
                    "ARE_DESCRIPCION='"+ oArea.AreDescripcion + "'," +
                    "WHERE ARE_CODIGO='" + oArea.AreCodigo + "'", cn);
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

        public bool AreasDelete(String Id)
		{


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Areas " +
                          "WHERE ARE_CODIGO='" + Id + "'",cn);
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

        public Areas AreasGetById(string Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Areas " +
                    "where TAB_CODIGO='"+ Id+"'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Areas NewEnt = new Areas();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarAreas(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<Areas> AreasGetAll()
		{
            List<Areas> lstAreas = new List<Areas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Areas ";
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
                            Areas NewEnt = new Areas();
                            NewEnt = CargarAreas(dr);
                            lstAreas.Add(NewEnt);
                  }
                }
                return lstAreas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private Areas CargarAreas(DataRow dr)
		{
			try
			{
                Areas oObjeto = new Areas();
                oObjeto.AreCodigo = dr["ARE_CODIGO"].ToString();
                oObjeto.AreDescripcion = dr["ARE_DESCRIPCION"].ToString();
				return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

      
        //public DataTable AreasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "AreasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
        //        DTPartes = DSPartes.Tables[0];
        //        DSPartes.Tables.RemoveAt(0);
        //        return DTPartes;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
		#endregion

	}
}
