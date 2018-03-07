
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class LecturasSuministrosItemsImpl
    {

        #region LecturasSuministrosItems methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;


        public long LecturasSuministrosItemsAdd(LecturasSuministrosItems oLecSumItem)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('LES_CODIGO')) into IDTEMP from dual; " +
                    " INSERT INTO LECTURAS_SUMINISTROS_ITEMS(LES_CODIGO,LEC_CODIGO,LSI_DESCRIPCION," +
                    " LSI_LECTURA_ANTERIOR, LSI_LECTURA_ACTUAL, LSI_CANTIDAD_UNIDADES)" +
                    " VALUES(IDTEMP," + oLecSumItem.lecCodigo + ",'" + oLecSumItem.lsiDescripcion + "', " + oLecSumItem.lsiLecturaAnterior + ", " +
                    oLecSumItem.lsiLecturaActual + ", " + oLecSumItem.lsiCantidadUnidades + ") RETURNING IDTEMP INTO :id;" +
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


        }

        public bool LecturasSuministrosItemsUpdate(LecturasSuministrosItems oLecSumItem)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand(" UPDATE LECTURAS_SUMINISTROS_ITEMS " +
                    " SET LES_CODIGO=" + oLecSumItem.lesCodigo + ", " +
                    " LEC_CODIGO=" + oLecSumItem.lecCodigo + ", " +
                    " LSI_DESCRIPCION='" + oLecSumItem.lsiDescripcion + "', " +
                    " LSI_LECTURA_ANTERIOR='" + oLecSumItem.lsiLecturaAnterior + "', " +
                    " LSI_LECTURA_ACTUAL=" + oLecSumItem.lsiLecturaActual + ", " +
                    " LSI_CANTIDAD_UNIDADES=" + oLecSumItem.lsiCantidadUnidades + ", " +
                    " WHERE LES_CODIGO=" + oLecSumItem.lesCodigo, cn);
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

        public bool LecturasSuministrosItemsDelete(long Id)
        {

            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE LECTURAS_SUMINISTROS_ITEMS " +
                     "WHERE LES_CODIGO=" + Id.ToString(), cn);
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

        public LecturasSuministrosItems LecturasSuministrosItemsGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM LECTURAS_SUMINISTROS_ITEMS " +
                    "WHERE LES_CODIGO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                LecturasSuministrosItems NewEnt = new LecturasSuministrosItems();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarLecturasSuministrosItems(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<LecturasSuministrosItems> LecturasSuministrosItemsGetAll()
        {
            List<LecturasSuministrosItems> lstLecSum = new List<LecturasSuministrosItems>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM LECTURAS_SUMINISTROS_ITEMS ";
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
                        LecturasSuministrosItems NewEnt = new LecturasSuministrosItems();
                        NewEnt = CargarLecturasSuministrosItems(dr);
                        lstLecSum.Add(NewEnt);
                    }
                }
                return lstLecSum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private LecturasSuministrosItems CargarLecturasSuministrosItems(DataRow dr)
        {
            try
            {
                LecturasSuministrosItems oLecSum = new LecturasSuministrosItems();
                oLecSum.lesCodigo = long.Parse(dr["LES_CODIGO"].ToString());
                oLecSum.lecCodigo = long.Parse(dr["LEC_CODIGO"].ToString());
                oLecSum.lsiDescripcion = dr["LSI_DESCRIPCION"].ToString();
                oLecSum.lsiLecturaActual = long.Parse(dr["LSI_LECTURA_ACTUAL"].ToString());
                oLecSum.lsiLecturaAnterior = long.Parse(dr["LSI_LECTURA_ANTERIOR"].ToString());
                oLecSum.lsiCantidadUnidades = long.Parse(dr["LSI_CANTIDAD_UNIDADES"].ToString());
                return oLecSum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
