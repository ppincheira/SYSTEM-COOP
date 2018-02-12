
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class ServiciosRutasImpl
    {
        #region ServiciosRutas methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long ServiciosRutasAdd(ServiciosRutas oSRu)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia SRU_NUMERO
                ds = new DataSet();
                string query =

                    " DECLARE IDTEMP NUMBER(10,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('SRU_NUMERO')) into IDTEMP from dual; " +
                    " insert into Servicios_Rutas " +
                    "(SRU_NUMERO, SRU_DESCRIPCION, SRU_DESCRIPCION_CORTA, SRV_CODIGO, EST_CODIGO) " +
                    "values(IDTEMP,'" + oSRu.SruDescripcion + "', '" + oSRu.SruDescripcionCorta + "', '" +
                    oSRu.SrvCodigo + "', '" + oSRu.EstCodigo + "') RETURNING IDTEMP INTO :id;" +
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

        public bool ServiciosRutasUpdate(ServiciosRutas oSRu)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Servicios_Rutas " +
                    "SET SRU_DESCRIPCION='" + oSRu.SruDescripcion + "', " +
                    "SRU_DESCRIPCION_CORTA='" + oSRu.SruDescripcionCorta + "', " +
                    "SRV_CODIGO='" + oSRu.SrvCodigo + "', " +
                    "EST_CODIGO='" + oSRu.EstCodigo + "' " +
                    "WHERE SRU_NUMERO=" + oSRu.SruNumero , cn);
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

        public bool ServiciosRutasDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Servicios_Rutas " +
                      "WHERE SRU_NUMERO=" + Id, cn);
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

        public ServiciosRutas ServiciosRutasGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios_Rutas " +
                    "WHERE SRU_NUMERO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ServiciosRutas NewEnt = new ServiciosRutas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarServiciosRutas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ServiciosRutas> ServiciosRutasGetAll()
        {
            List<ServiciosRutas> lstServiciosRutas = new List<ServiciosRutas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Servicios_Rutas ";
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
                        ServiciosRutas NewEnt = new ServiciosRutas();
                        NewEnt = CargarServiciosRutas(dr);
                        lstServiciosRutas.Add(NewEnt);
                    }
                }
                return lstServiciosRutas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ServiciosRutas CargarServiciosRutas(DataRow dr)
        {
            try
            {
                ServiciosRutas oObjeto = new ServiciosRutas();
                oObjeto.SruNumero = long.Parse(dr["SRU_NUMERO"].ToString());
                oObjeto.SruDescripcion = dr["SRU_DESCRIPCION"].ToString();
                oObjeto.SruDescripcionCorta = dr["SRU_DESCRIPCION_CORTA"].ToString();
                oObjeto.SrvCodigo =dr["SRV_CODIGO"].ToString();
                oObjeto.EstCodigo =dr["EST_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable ServiciosRutasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "ServiciosRutasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
