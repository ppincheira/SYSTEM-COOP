
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
	public class CodigosPostalesLocalidadesImpl
    {
        #region CodigosPostalesLocalidades methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long CodigosPostalesLocalidadesAdd(CodigosPostalesLocalidades oCodigoPostal)
		{

           
            try
			{
             


                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('CPL_NUMERO')) into IDTEMP from dual; " +
                    "insert into Codigos_Postales_Localidades(CPL_NUMERO,CPL_DESCRIPCION, " +
                    "CPL_CODIGO_POSTAL, LOC_NUMERO)" +
                    " VALUES(IDTEMP,'" + oCodigoPostal.CplDescripcion + "','" + oCodigoPostal.CplCodigoPostal +"',"+
                    oCodigoPostal.LocNumero + ") RETURNING IDTEMP INTO :id;" +
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
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool CodigosPostalesLocalidadesUpdate(CodigosPostalesLocalidades oCPL)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Codigos_Postales_Localidades " +
                    "SET CPL_DESCRIPCION='" + oCPL.CplDescripcion + 
                    "', CPL_CODIGO_POSTAL='" + oCPL.CplCodigoPostal + "' " + 
                    ", LOC_NUMERO=" + oCPL.LocNumero + 
                    " WHERE CPL_NUMERO=" + oCPL.CplNumero.ToString(), cn);
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

        public bool CodigosPostalesLocalidadesDelete(int Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Codigos_Postales_Localidades " +
                        "WHERE CPL_NUMERO=" + Id.ToString(), cn);
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

        public CodigosPostalesLocalidades CodigosPostalesLocalidadesGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Codigos_Postales_Localidades " +
                    "WHERE CPL_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                CodigosPostalesLocalidades NewEnt = new CodigosPostalesLocalidades();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarCodigosPostalesLocalidades(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<CodigosPostalesLocalidades> CodigosPostalesLocalidadesGetAll()
		{
            List<CodigosPostalesLocalidades> lstCodigosPostalesLocalidades = new List<CodigosPostalesLocalidades>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Codigos_Postales_Localidades ";
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
                            CodigosPostalesLocalidades NewEnt = new CodigosPostalesLocalidades();
                            NewEnt = CargarCodigosPostalesLocalidades(dr);
                            lstCodigosPostalesLocalidades.Add(NewEnt);
                  }
                }
                return lstCodigosPostalesLocalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private CodigosPostalesLocalidades CargarCodigosPostalesLocalidades(DataRow dr)
		{
			try
			{
                CodigosPostalesLocalidades oObjeto = new CodigosPostalesLocalidades();
                oObjeto.CplNumero = long.Parse(dr["CPL_NUMERO"].ToString());
                oObjeto.CplDescripcion = dr["CPL_DESCRIPCION"].ToString();
                oObjeto.CplCodigoPostal = dr["CPL_CODIGO_POSTAL"].ToString();
                oObjeto.LocNumero = int.Parse(dr["LOC_NUMERO"].ToString());
                return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}



        public DataTable CodigosPostalesLocalidadesGetByLocalidad(int IdLocalidad)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Codigos_Postales_Localidades " +
                    "WHERE LOC_NUMERO=" + IdLocalidad.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                return dt = ds.Tables[0];
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
