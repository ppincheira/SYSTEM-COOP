
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class TipoConexionServiciosImpl
    {
        #region TipoConexionServicios methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int TipoConexionServiciosAdd(TipoConexionServicios oTCS)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave TCS_CODIGO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Tipos_Conexiones_Servicios " +
                    "(TCS_CODIGO, TCS_DESCRIPCION, TCS_DESCRIPCION_CORTA, SRV_CODIGO, EST_CODIGO) " +
                    "values('" + oTCS.TcsCodigo + "', '" +oTCS.TcsDescripcion + "', '" +
                    oTCS.TcsDescripcionCorta + "','" + oTCS.SrvCodigo +  "', '" +oTCS.EstCodigo + "')", cn);
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

        public bool TipoConexionServiciosUpdate(TipoConexionServicios oTCS)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Tipos_Conexiones_Servicios " +
                    "SET TCS_DESCRIPCION='" + oTCS.TcsDescripcion + "', " +
                    "TCS_DESCRIPCION_CORTA='" + oTCS.TcsDescripcionCorta + "', " +
                    "SRV_CODIGO='" + oTCS.SrvCodigo + "', " +
                    "EST_CODIGO='" + oTCS.EstCodigo + "' " +
                    "WHERE TCS_CODIGO='" + oTCS.TcsCodigo + "'", cn);
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

        public bool TipoConexionServiciosDelete(string Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Tipos_Conexiones_Servicios " +
                      "WHERE TCS_CODIGO='" + Id + "'", cn);
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

        public TipoConexionServicios TipoConexionServiciosGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Conexiones_Servicios " +
                    "WHERE TCS_CODIGO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                TipoConexionServicios NewEnt = new TipoConexionServicios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTipoConexionServicios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TipoConexionServicios> TipoConexionServiciosGetAll()
        {
            List<TipoConexionServicios> lstTipoConexionServicios = new List<TipoConexionServicios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Conexiones_Servicios ";
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
                        TipoConexionServicios NewEnt = new TipoConexionServicios();
                        NewEnt = CargarTipoConexionServicios(dr);
                        lstTipoConexionServicios.Add(NewEnt);
                    }
                }
                return lstTipoConexionServicios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         public DataTable TipoConexionServiciosGetAllDT()
        {
            List<TipoConexionServicios> lstTipoConexionServicios = new List<TipoConexionServicios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Conexiones_Servicios ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       private TipoConexionServicios CargarTipoConexionServicios(DataRow dr)
        {
            try
            {
                TipoConexionServicios oObjeto = new TipoConexionServicios();
                oObjeto.TcsCodigo =dr["TCS_CODIGO"].ToString();
                oObjeto.TcsDescripcion = dr["TCS_DESCRIPCION"].ToString();
                oObjeto.TcsDescripcionCorta = dr["TCS_DESCRIPCION_CORTA"].ToString();
                oObjeto.SrvCodigo = dr["SRV_CODIGO"].ToString();
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable TipoConexionServiciosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TipoConexionServiciosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
