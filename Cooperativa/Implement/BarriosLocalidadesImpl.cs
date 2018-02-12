
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
	public class BarriosLocalidadesImpl
    {
        #region BarriosLocalidades methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int BarriosLocalidadesAdd(BarriosLocalidades oBarrio)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia BAR_NUMERO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Barrios_Localidades(LOC_NUMERO, " +
                    "BAR_DESCRIPCION, TBL_CODIGO) " +
                    "values("+oBarrio.LocNumero + ", '"+
                    oBarrio.BarDescripcion + "', '"+oBarrio.TblCodigo + "')", cn);
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

        public bool BarriosLocalidadesUpdate(BarriosLocalidades oBarrio)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Barrios_Localidades " +
                    "SET LOC_NUMERO=" + oBarrio.LocNumero + "," +
                    "BAR_DESCRIPCION='" + oBarrio.BarDescripcion + "'," +
                    "TBL_CODIGO='" + oBarrio.TblCodigo +
                    "' WHERE BAR_NUMERO=" + oBarrio.BarNumero, cn);
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

        public bool BarriosLocalidadesDelete(long Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Barrios_Localidades " +
                         "WHERE BAR_NUMERO=" + Id.ToString(),cn);
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

        public BarriosLocalidades BarriosLocalidadesGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Barrios_Localidades " +
                    "WHERE BAR_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                BarriosLocalidades NewEnt = new BarriosLocalidades();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarBarriosLocalidades(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<BarriosLocalidades> BarriosLocalidadesGetAll()
		{
            List<BarriosLocalidades> lstBarriosLocalidades = new List<BarriosLocalidades>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Barrios_Localidades ";
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
                            BarriosLocalidades NewEnt = new BarriosLocalidades();
                            NewEnt = CargarBarriosLocalidades(dr);
                            lstBarriosLocalidades.Add(NewEnt);
                  }
                }
                return lstBarriosLocalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private BarriosLocalidades CargarBarriosLocalidades(DataRow dr)
		{
			try
			{
                BarriosLocalidades oObjeto = new BarriosLocalidades();
                oObjeto.BarNumero = long.Parse(dr["BAR_NUMERO"].ToString());
                oObjeto.LocNumero = int.Parse(dr["LOC_NUMERO"].ToString());
                oObjeto.BarDescripcion = dr["BAR_DESCRIPCION"].ToString();
                oObjeto.TblCodigo = dr["PRV_CODIGO"].ToString();
                return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataTable BarriosLocalidadesGetByLocalidadDT(long locNumero) 
        {
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select BAR_NUMERO, BAR_DESCRIPCION, LOC_NUMERO, TBL_CODIGO from Barrios_Localidades ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
