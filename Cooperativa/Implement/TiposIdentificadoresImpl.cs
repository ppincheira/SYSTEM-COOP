using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class TiposIdentificadoresImpl
    {
        #region TiposIdentificadores methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int TiposIdentificadoresAdd(TiposIdentificadores oTid)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                //Clave 
                ds = new DataSet();
                cmd = new OracleCommand("INSERT INTO tipos_identificadores(tid_codigo, tid_descripcion, " +
                    "tid_descripcion_corta, tid_codigo_afip) " +
                    "VALUES('" + oTid.TidCodigo + "','" + oTid.TidDescripcion + "','" + oTid.TidDescripcionCorta + "','" +
                    oTid.TidCodigoAfip +  "')", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TiposIdentificadoresUpdate(TiposIdentificadores oTid)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("UPDATE tipos_identificadores " +
                    "SET tid_descripcion='" + oTid.TidDescripcion + "', " +
                    "tid_descripcion_corta='" + oTid.TidDescripcionCorta + "', " +                   
                    "tid_codigo_afip='" + oTid.TidCodigoAfip + "' " +
                    "WHERE tid_codigo='" + oTid.TidCodigo + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                return response > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TiposIdentificadoresDelete(string Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE tipos_identificadores " +
                    "WHERE tid_codigo='" + Id + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                return response > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TiposIdentificadores TiposIdentificadoresGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM tipos_identificadores " +
                    "WHERE tid_codigo='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                TiposIdentificadores NewEnt = new TiposIdentificadores();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTiposIdentificadores(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TiposIdentificadores> TiposIdentificadoresGetAll()
        {
            List<TiposIdentificadores> lstTiposIdentificadores = new List<TiposIdentificadores>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM tipos_identificadores ";
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
                        TiposIdentificadores NewEnt = new TiposIdentificadores();
                        NewEnt = CargarTiposIdentificadores(dr);
                        lstTiposIdentificadores.Add(NewEnt);
                    }
                }
                return lstTiposIdentificadores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TiposIdentificadores CargarTiposIdentificadores(DataRow dr)
        {
            try
            {
                TiposIdentificadores oObjeto = new TiposIdentificadores();
                oObjeto.TidCodigo = dr["TID_CODIGO"].ToString();
                oObjeto.TidDescripcion = dr["TID_DESCRIPCION"].ToString();
                oObjeto.TidDescripcionCorta = dr["TID_DESCRIPCION_CORTA"].ToString();               
                oObjeto.TidCodigoAfip = dr["TID_CODIGO_AFIP"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TiposIdentificadoresGetAllDT()
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT tid_codigo, " +
                                   "        tid_descripcion " +
                                   " FROM   tipos_identificadores  " +
                                   " ORDER BY tid_descripcion ";
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

        public DataTable TiposIdentificadoresGetByFilter()
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT tid_codigo, " +
                                   "        tid_descripcion " +
                                   " FROM   tipos_identificadores  " +
                                   " ORDER BY tid_descripcion ";

                Console.WriteLine("sql");
                Console.WriteLine("--" + sqlSelect);
                Console.WriteLine("sql");

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


