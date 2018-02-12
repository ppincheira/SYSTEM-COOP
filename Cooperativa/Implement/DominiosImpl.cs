
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class DominiosImpl
    {
        #region Dominios methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int DominiosAdd(Dominios oDom)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia DMN_CODIGO, DMN_VALOR
                ds = new DataSet();
                cmd = new OracleCommand("insert into Dominios" +
                    "(DMN_CODIGO, DMN_VALOR, DMN_DESCRIPCION, DMN_ACTIVO, DMN_DEFAULT) " +
                    "values('" + oDom.DmnCodigo + "','" + oDom.DmnValor + "','" +
                    oDom.DmnDescripcion + "','" + oDom.DmnActivo + "','" + oDom.DmnDefault + "')", cn);
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

        public bool DominiosUpdate(Dominios oDom)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Dominios " +
                    "SET DMN_DESCRIPCION='" + oDom.DmnDescripcion +
                    "', DMN_ACTIVO='" + oDom.DmnActivo +
                    "', DMN_DEFAULT='" + oDom.DmnDefault +
                    "' WHERE DMN_CODIGO='" + oDom.DmnCodigo + "' and DMN_VALOR='" +
                    oDom.DmnValor + "'", cn);
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

        public bool DominiosDelete(string Codigo, string Valor)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Dominios " +
                    "WHERE DMN_CODIGO='" + Codigo + "' and DMN_VALOR='" + Valor + "'", cn);
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

        public Dominios DominiosGetById(string Codigo, string Valor)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Dominios " +
                     "WHERE DMN_CODIGO='" + Codigo + "' and DMN_VALOR='" + Valor + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Dominios NewEnt = new Dominios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarDominios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Dominios> DominiosGetAll()
        {
            List<Dominios> lstDominios = new List<Dominios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Dominios ";
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
                        Dominios NewEnt = new Dominios();
                        NewEnt = CargarDominios(dr);
                        lstDominios.Add(NewEnt);
                    }
                }
                return lstDominios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Dominios CargarDominios(DataRow dr)
        {
            try
            {
                Dominios oObjeto = new Dominios();
                oObjeto.DmnCodigo = dr["DMN_CODIGO"].ToString();
                oObjeto.DmnValor = dr["DMN_VALOR"].ToString();
                oObjeto.DmnDescripcion = dr["DMN_DESCRIPCION"].ToString();
                oObjeto.DmnActivo = dr["DMN_ACTIVO"].ToString();
                oObjeto.DmnDefault = dr["DMN_DEFAULT"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DominiosGetByFilter(string dmnCodigo)
        {

            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT dmn_valor, " +
                                   "        dmn_descripcion " +
                                   " FROM   dominios  " +
                                   " WHERE  dmn_activo = 'S' " +
                                   " AND    dmn_codigo ='" + dmnCodigo + "' " +
                                   " ORDER BY dmn_descripcion ";

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
        public List<Dominios> DominiosGetListByFilter(string dmnCodigo)
        {
            List<Dominios> lstDominios = new List<Dominios>();
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT * FROM dominios  " +
                                   " WHERE  dmn_activo = 'S' " +
                                   " AND dmn_codigo ='" + dmnCodigo + "' ";

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);

                DataTable dt;
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; dt.Rows.Count > i; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        Dominios NewEnt = new Dominios();
                        NewEnt = CargarDominios(dr);
                        lstDominios.Add(NewEnt);
                    }
                }
                return lstDominios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable DominiosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "DominiosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

