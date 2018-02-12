
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class TiposMedidoresImpl
        {
        #region TiposMedidores methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
        public int TiposMedidoresAdd(TiposMedidores oTMe)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();

                    string query = " DECLARE IDTEMP NUMBER(10,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('TME_CODIGO')) into IDTEMP from dual; " +
                    "insert into Tipos_Medidores(TME_CODIGO, TME_DESCRIPCION, " +
                            "TME_DESCRIPCION_CORTA, TME_FECHA_CARGA, SRV_CODIGO,EST_CODIGO, USR_NUMERO) " +
                            "values(IDTEMP,'" + oTMe.TmeDescripcion + "','" + oTMe.TmeDescripcionCorta + "','" +
                            oTMe.TmeFechaCarga.ToShortDateString() + "','" + oTMe.SrvCodigo + "','" + oTMe.EstCodigo + "'," + oTMe.UsrNumero + ")"+ "RETURNING IDTEMP INTO :id;END;";



                /*
                                cmd = new OracleCommand("insert into Tipos_Medidores(TME_CODIGO, TME_DESCRIPCION, " +
                                        "TME_DESCRIPCION_CORTA, TME_FECHA_CARGA, SRV_CODIGO,EST_CODIGO, USR_NUMERO) " +
                                        "values('" + oTMe.TmeCodigo + "','" + oTMe.TmeDescripcion + "','" + oTMe.TmeDescripcionCorta + "','" + 
                                        oTMe.TmeFechaCarga.ToShortDateString() + "','" + oTMe.SrvCodigo + "','"+oTMe.EstCodigo +"',"+ oTMe.UsrNumero + ")", cn);*/
                cmd = new OracleCommand(query, cn);
                adapter = new OracleDataAdapter(cmd);
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

        public bool TiposMedidoresUpdate(TiposMedidores oTMe)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Tipos_Medidores " +
                        "SET TME_DESCRIPCION='" + oTMe.TmeDescripcion + "', " +
                        "TME_DESCRIPCION_CORTA='" + oTMe.TmeDescripcionCorta + "', " +
                        "TME_FECHA_CARGA='" + oTMe.TmeFechaCarga.ToShortDateString() + "', " +
                        "SRV_CODIGO='" + oTMe.SrvCodigo + "', " +
                        "USR_NUMERO=" + oTMe.UsrNumero + ", " +
                        "EST_CODIGO='" + oTMe.EstCodigo+ "' " +
                        "WHERE TME_CODIGO=" + oTMe.TmeCodigo , cn);
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

        public bool TiposMedidoresDelete(string Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Tipos_Medidores " +
                        "WHERE TME_CODIGO='" + Id + "'", cn);
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

        public TiposMedidores TiposMedidoresGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Medidores " +
                        "WHERE TME_CODIGO='" + Id + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    TiposMedidores NewEnt = new TiposMedidores();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarTiposMedidores(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        public List<TiposMedidores> TiposMedidoresGetAll()
            {
                List<TiposMedidores> lstTiposMedidores = new List<TiposMedidores>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Medidores ";
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
                            TiposMedidores NewEnt = new TiposMedidores();
                            NewEnt = CargarTiposMedidores(dr);
                            lstTiposMedidores.Add(NewEnt);
                        }
                    }
                    return lstTiposMedidores;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        public DataTable TiposMedidoresGetAllDT()
            {
                List<TiposMedidores> lstTiposMedidores = new List<TiposMedidores>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Medidores ";
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

        private TiposMedidores CargarTiposMedidores(DataRow dr)
        {
                try
                {
                    TiposMedidores oObjeto = new TiposMedidores();
                    oObjeto.TmeCodigo = long.Parse(dr["TME_CODIGO"].ToString());
                    oObjeto.TmeDescripcion = dr["TME_DESCRIPCION"].ToString();
                    oObjeto.TmeDescripcionCorta = dr["TME_DESCRIPCION_CORTA"].ToString();
                    if (dr["TME_FECHA_CARGA"].ToString() != "")
                        oObjeto.TmeFechaCarga = DateTime.Parse(dr["TME_FECHA_CARGA"].ToString());
                    oObjeto.SrvCodigo = dr["SRV_CODIGO"].ToString();
                    oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
 
            //public DataTable TiposMedidoresGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TiposMedidoresGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

