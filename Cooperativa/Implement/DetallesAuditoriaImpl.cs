
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class DetallesAuditoriaImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int DetallesAuditoriaAdd(DetallesAuditoria oDAu)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave Secuencia AUD_NUMERO y DAU_NUMERO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Detalles_Auditoria" +
                        "(DAU_NUMERO, TAB_NOMBRE, COT_NOMBRE, COT_VALOR_ANT, COT_VALOR_POST) " +
                        "values(" + oDAu.DauNumero + ",'"+ oDAu.TabNombre + ",'"+ 
                        oDAu.CotNombre + "','" +  oDAu.CotValorAnt + "','" + oDAu.CotValorPost + "')", cn);
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

            public bool DetallesAuditoriaUpdate(DetallesAuditoria oDAu)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Detalles_Auditoria " +
                        "SET TAB_NOMBRE='" + oDAu.TabNombre + "', " +
                        "COT_NOMBRE='" + oDAu.CotNombre + "', " +
                        "COT_VALOR_ANT='" + oDAu.CotValorAnt + "', " +
                        "COT_VALOR_POST='" + oDAu.CotValorPost + "' " +
                        "WHERE AUD_NUMERO=" + oDAu.AudNumero.ToString()+
                        " and DAU_NUMERO="+oDAu.DauNumero.ToString() , cn);
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

            public bool DetallesAuditoriaDelete(long Aud, short Dau)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Detalles_Auditoria " +
                        "WHERE AUD_NUMERO=" + Aud.ToString() +
                        " and DAU_NUMERO=" + Dau.ToString(), cn);
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

            public DetallesAuditoria DetallesAuditoriaGetById(long Aud, short Dau)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Detalles_Auditoria " +
                        "WHERE AUD_NUMERO=" + Aud.ToString() +
                        " and DAU_NUMERO=" + Dau.ToString();
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    DetallesAuditoria NewEnt = new DetallesAuditoria();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarDetallesAuditoria(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<DetallesAuditoria> DetallesAuditoriaGetAll()
            {
                List<DetallesAuditoria> lstDetallesAuditoria = new List<DetallesAuditoria>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Detalles_Auditoria ";
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
                            DetallesAuditoria NewEnt = new DetallesAuditoria();
                            NewEnt = CargarDetallesAuditoria(dr);
                            lstDetallesAuditoria.Add(NewEnt);
                        }
                    }
                    return lstDetallesAuditoria;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private DetallesAuditoria CargarDetallesAuditoria(DataRow dr)
            {
                try
                {
                    DetallesAuditoria oObjeto = new DetallesAuditoria();
                    oObjeto.AudNumero = long.Parse(dr["AUD_NUMERO"].ToString());
                    oObjeto.DauNumero = short.Parse(dr["DAU_NUMERO"].ToString());
                    oObjeto.TabNombre = dr["TAB_NOMBRE"].ToString();
                    oObjeto.CotNombre = dr["COT_NOMBRE"].ToString();
                    oObjeto.CotValorAnt = dr["COT_VALOR_ANT"].ToString();
                    oObjeto.CotValorPost = dr["COT_VALOR_POST"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable DetallesAuditoriaGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "DetallesAuditoriaGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

