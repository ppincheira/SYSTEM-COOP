
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
	public class CallesLocalidadesImpl
    {
        #region CallesLocalidades methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long  CallesLocalidadesAdd(CallesLocalidades oCalleLocalidad)
		{
            try
            {

                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('CAL_NUMERO')) into IDTEMP from dual; " +
                    "insert into Calles_Localidades(CAL_NUMERO, CAL_DESCRIPCION, LOC_NUMERO)" +
                    " VALUES(IDTEMP,'" + oCalleLocalidad.CalDescripcion+"',"+oCalleLocalidad.LocNumero+
                     ") RETURNING IDTEMP INTO :id;" +
                    " END;";

                cmd = new OracleCommand(query, cn);
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });




                cmd.ExecuteNonQuery();
                response = long.Parse(cmd.Parameters[":id"].Value.ToString());
                cn.Close();

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia CAL_NUMERO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Calles_Localidades(CAL_DESCRIPCION, LOC_NUMERO) " +
                    "values( '"+oCalleLocalidad.CalDescripcion + "', " + oCalleLocalidad.LocNumero + ")", cn);
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

        public bool CallesLocalidadesUpdate(CallesLocalidades oCalleLocalidad)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Calles_Localidades " +
                    "SET CAL_DESCRIPCION='" + oCalleLocalidad.CalDescripcion + 
                    "', LOC_NUMERO=" + oCalleLocalidad.LocNumero.ToString() +
                    " WHERE CAL_NUMERO=" + oCalleLocalidad.CalNumero.ToString() , cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
				return (response > 0);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool CallesLocalidadesDelete(long Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Calles_Localidades " +
                        "WHERE CAL_NUMERO=" + Id.ToString(), cn);
                    adapter = new OracleDataAdapter(cmd);
                    response = cmd.ExecuteNonQuery();
                    cn.Close();
                    return (response > 0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
		}

        public CallesLocalidades CallesLocalidadesGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Calles_Localidades " +
                    "WHERE CAL_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                CallesLocalidades NewEnt = new CallesLocalidades();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarCallesLocalidades(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<CallesLocalidades> CallesLocalidadesGetAll()
		{
            List<CallesLocalidades> lstCallesLocalidades = new List<CallesLocalidades>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Calles_Localidades ";
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
                            CallesLocalidades NewEnt = new CallesLocalidades();
                            NewEnt = CargarCallesLocalidades(dr);
                            lstCallesLocalidades.Add(NewEnt);
                  }
                }
                return lstCallesLocalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private CallesLocalidades CargarCallesLocalidades(DataRow dr)
		{
			try
			{
                CallesLocalidades oObjeto = new CallesLocalidades();
                oObjeto.CalNumero = long.Parse(dr["CAL_NUMERO"].ToString());
                oObjeto.CalDescripcion = dr["CAL_DESCRIPCION"].ToString();
                oObjeto.LocNumero = int.Parse(dr["LOC_NUMERO"].ToString());
                return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataTable CallesLocalidadesGetByLocalidad(int IdProvincia)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM CALLES_LOCALIDADES " +
                    "WHERE LOC_NUMERO=" + IdProvincia.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                return   dt = ds.Tables[0];

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
