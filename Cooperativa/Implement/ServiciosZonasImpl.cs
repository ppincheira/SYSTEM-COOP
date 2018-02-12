
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class ServiciosZonasImpl
    {
        #region ServiciosZonas methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int ServiciosZonasAdd(ServiciosZonas oSZo)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia SZO_NUMERO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Servicios_Zonas " +
                    "(SZO_DESCRIPCION, SZO_DESCRIPCION_CORTA, SRV_CODIGO, EST_CODIGO) " +
                    "values('" + oSZo.SzoDescripcion + "', '" +oSZo.SzoDescripcionCorta + "', '" +
                    oSZo.SrvCodigo + "', '" + oSZo.EstCodigo + "')", cn);
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

        public bool ServiciosZonasUpdate(ServiciosZonas oSZo)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Servicios_Zonas " +
                    "SET SZO_DESCRIPCION='" + oSZo.SzoDescripcion + "', " +
                    "SZO_DESCRIPCION_CORTA='" + oSZo.SzoDescripcionCorta + "', " +
                    "SRV_CODIGO='" + oSZo.SrvCodigo + "', '" +
                    "EST_CODIGO='" + oSZo.EstCodigo + "' " +
                    "WHERE SZO_NUMERO=" + oSZo.SrvCodigo, cn);
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

        public bool ServiciosZonasDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Servicios_Zonas " +
                      "WHERE SZO_NUMERO=" + Id, cn);
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

        public ServiciosZonas ServiciosZonasGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios_Zonas " +
                    "WHERE SZO_NUMERO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ServiciosZonas NewEnt = new ServiciosZonas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarServiciosZonas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ServiciosZonas> ServiciosZonasGetAll()
        {
            List<ServiciosZonas> lstServiciosZonas = new List<ServiciosZonas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios_Zonas ";
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
                        ServiciosZonas NewEnt = new ServiciosZonas();
                        NewEnt = CargarServiciosZonas(dr);
                        lstServiciosZonas.Add(NewEnt);
                    }
                }
                return lstServiciosZonas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ServiciosZonas CargarServiciosZonas(DataRow dr)
        {
            try
            {
                ServiciosZonas oObjeto = new ServiciosZonas();
                oObjeto.SzoNumero = long.Parse(dr["SZO_NUMERO"].ToString());
                oObjeto.SzoDescripcion = dr["SZO_DESCRIPCION"].ToString();
                oObjeto.SzoDescripcionCorta = dr["SZO_DESCRIPCION_CORTA"].ToString();
                oObjeto.SrvCodigo =dr["SRV_CODIGO"].ToString();
                oObjeto.EstCodigo =dr["EST_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable ServiciosZonasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "ServiciosZonasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
