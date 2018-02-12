
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class ServiciosImpl
    {
        #region Servicios methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int ServiciosAdd(Servicios oSer)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Srv_CODIGO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Servicios (SRV_CODIGO, SRV_DESCRIPCION, " +
                    "SRV_DESCRIPCION_CORTA, SRV_FECHA_CARGA, USR_NUMERO, SRV_REQUIERE_MEDIDOR) " +
                    "values('" + oSer.SrvCodigo + "', '" +oSer.SrvDescripcion + "', '" +
                    oSer.SrvDescripcionCorta + "','" + oSer.SrvFechaCarga.ToString("dd/MM/yyyy") + "'," + 
                    oSer.UsrNumero + ",'" + oSer.SrvRequiereMedidor+"')", cn);
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

        public bool ServiciosUpdate(Servicios oSer)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Servicios " +
                    "SET SRV_DESCRIPCION='" + oSer.SrvDescripcion + "', " +
                    "SRV_DESCRIPCION_CORTA='" + oSer.SrvDescripcionCorta + "', " +
                    "SRV_FECHA_CARGA='" + oSer.SrvFechaCarga.ToString("dd/MM/yyyy") + "', " +
                    "USR_NUMERO=" + oSer.UsrNumero + ", " +
                    "SRV_REQUIERE_MEDIDOR='" + oSer.SrvRequiereMedidor + "' " +
                    "WHERE SRV_CODIGO='" + oSer.SrvCodigo + "'", cn);
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

        public bool ServiciosDelete(string Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Servicios " +
                      "WHERE SRV_CODIGO='" + Id + "'", cn);
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

        public Servicios ServiciosGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios " +
                    "WHERE SRV_CODIGO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Servicios NewEnt = new Servicios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarServicios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Servicios> ServiciosGetAll()
        {
            List<Servicios> lstServicios = new List<Servicios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios ";
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
                        Servicios NewEnt = new Servicios();
                        NewEnt = CargarServicios(dr);
                        lstServicios.Add(NewEnt);
                    }
                }
                return lstServicios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiciosGetAllDT()
        {
            List<Servicios> lstServicios = new List<Servicios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios ";
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
        public List<Servicios> ServiciosMedidosGetAll()
        {
            List<Servicios> lstServicios = new List<Servicios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios where SRV_REQUIERE_MEDIDOR = 'S' ";
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
                        Servicios NewEnt = new Servicios();
                        NewEnt = CargarServicios(dr);
                        lstServicios.Add(NewEnt);
                    }
                }
                return lstServicios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Servicios CargarServicios(DataRow dr)
        {
            try
            {
                Servicios oObjeto = new Servicios();
                oObjeto.SrvCodigo =dr["SRV_CODIGO"].ToString();
                oObjeto.SrvDescripcion = dr["SRV_DESCRIPCION"].ToString();
                oObjeto.SrvDescripcionCorta = dr["SRV_DESCRIPCION_CORTA"].ToString();
                if (dr["SRV_FECHA_CARGA"].ToString() != "")
                    oObjeto.SrvFechaCarga = DateTime.Parse(dr["SRV_FECHA_CARGA"].ToString());
                oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                oObjeto.SrvRequiereMedidor = dr["SRV_REQUIERE_MEDIDOR"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiciosGetByFilter()
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT srv_codigo, " +
                                   "        srv_descripcion " +
                                   " FROM   servicios  ";

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
        //public DataTable ServiciosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "ServiciosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
