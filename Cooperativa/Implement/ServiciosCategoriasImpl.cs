using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class ServiciosCategoriasImpl
    {
        #region ServiciosCategorias methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        private string sql;

        public long ServiciosCategoriasAdd(ServiciosCategorias oSCa)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia 
                ds = new DataSet();
                string query = " DECLARE " +
                               " idtemp NUMBER(10,0); " +
                               " BEGIN " +
                               " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('SCA_NUMERO')) " +
                               " INTO idtemp " +
                               " FROM dual; " +
                               " INSERT INTO servicios_categorias (sca_numero, " +
                                                                  "sca_descripcion, " +
                                                                  "sca_descripcion_corta, " +
                                                                  "srv_codigo, " +
                                                                  "est_codigo) " +
                                                          "VALUES(idtemp, " +
                                                                " '" + oSCa.ScaDescripcion + "', " +
                                                                " '" + oSCa.ScaDescripcionCorta + "', " +
                                                                " '" + oSCa.SrvCodigo + "', " +
                                                                " '" + oSCa.EstCodigo + "')" +
                                " RETURNING IDTEMP INTO :id;" +
                                " END;";
                cmd = new OracleCommand(query, cn);
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });
                adapter = new OracleDataAdapter(cmd);
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

        public bool ServiciosCategoriasUpdate(ServiciosCategorias oSCa)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                sql = "UPDATE servicios_categorias SET sca_descripcion = '" + oSCa.ScaDescripcion + "', " +
                                                      "sca_descripcion_corta = '" + oSCa.ScaDescripcionCorta + "', " +
                                                      "srv_codigo = '" + oSCa.SrvCodigo + "', " +
                                                      "est_codigo = '" + oSCa.EstCodigo + "' " +
                                               "WHERE  sca_numero = '" + oSCa.ScaNumero + "' ";
                Console.WriteLine("sql");
                Console.WriteLine("sql  " + sql);
                Console.WriteLine("sql");

                cmd = new OracleCommand(sql, cn);
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

        public bool ServiciosCategoriasDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE servicios_categorias " +
                                        "WHERE sca_numero=" + Id, cn);
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

        public ServiciosCategorias ServiciosCategoriasGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM servicios_categorias " +
                                   "WHERE sca_numero=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ServiciosCategorias NewEnt = new ServiciosCategorias();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarServiciosCategorias(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ServiciosCategorias> ServiciosCategoriasGetAll()
        {
            List<ServiciosCategorias> lstServiciosCategorias = new List<ServiciosCategorias>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM servicios_categorias ";
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
                        ServiciosCategorias NewEnt = new ServiciosCategorias();
                        NewEnt = CargarServiciosCategorias(dr);
                        lstServiciosCategorias.Add(NewEnt);
                    }
                }
                return lstServiciosCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ServiciosCategoriasGetbySrv(string srvCodigo)
        {
            List<ServiciosCategorias> lstServiciosCategorias = new List<ServiciosCategorias>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM servicios_categorias where srv_codigo='" + srvCodigo + "'";
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
        private ServiciosCategorias CargarServiciosCategorias(DataRow dr)
        {
            try
            {
                ServiciosCategorias oObjeto = new ServiciosCategorias();
                oObjeto.ScaNumero = long.Parse(dr["SCA_NUMERO"].ToString());
                oObjeto.ScaDescripcion = dr["SCA_DESCRIPCION"].ToString();
                oObjeto.ScaDescripcionCorta = dr["SCA_DESCRIPCION_CORTA"].ToString();
                oObjeto.SrvCodigo = dr["SRV_CODIGO"].ToString();
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable ServiciosCategoriasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "ServiciosCategoriasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

