using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class MonedasImpl
    {
        #region Monedas methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int MonedasAdd(Monedas oMon)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                string query =
                    " DECLARE IDTEMP NUMBER; " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('MON_CODIGO')) into IDTEMP from dual; " +
                    "insert into Monedas(MON_CODIGO, MON_DESCRIPCION, " +
                        "MON_CODIGO_ISO, MON_NUMERO_ISO " +
                        "values(IDTEMP, '" +oMon.MonDescripcion + "','" + 
                        oMon.MonCodigoIso + "',"+oMon.MonNumeroIso+")";
                cmd = new OracleCommand(query, cn);
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                response = int.Parse(cmd.Parameters[":id"].Value.ToString());
                cn.Close();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MonedasUpdate(Monedas oMon)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Monedas " +
                    "SET MON_DESCRIPCION='" + oMon.MonDescripcion + "'," +
                    "MON_CODIGO_ISO=" + oMon.MonCodigoIso + ", " +
                    "MON_NUMERO_ISO='" + oMon.MonNumeroIso + "' " +
                    "WHERE MON_CODIGO=" + oMon.MonCodigo, cn);
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

        public bool MonedasDelete(short Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Monedas " +
                      "WHERE MON_CODIGO=" + Id.ToString(), cn);
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

        public Monedas MonedasGetById(short Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Monedas " +
                    "where MON_CODIGO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Monedas NewEnt = new Monedas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarMonedas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Monedas> MonedasGetAll()
        {
            List<Monedas> lstMonedas = new List<Monedas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Monedas ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; dt.Rows.Count > i; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        Monedas NewEnt = new Monedas();
                        NewEnt = CargarMonedas(dr);
                        lstMonedas.Add(NewEnt);
                    }
                }
                return lstMonedas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Monedas CargarMonedas(DataRow dr)
        {
            try
            {
                Monedas oObjeto = new Monedas();
                oObjeto.MonCodigo =short.Parse(dr["MON_CODIGO"].ToString());
                oObjeto.MonDescripcion = dr["MON_DESCRIPCION"].ToString();
                oObjeto.MonCodigoIso = dr["MON_CODIGO_ISO"].ToString();
                oObjeto.MonNumeroIso = short.Parse(dr["MON_NUMERO_ISO"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public DataTable MonedasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "MonedasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
