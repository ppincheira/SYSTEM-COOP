
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class TiposObservacionesTablasImpl
        {
            #region TiposObservacionesTablas methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int TiposObservacionesTablasAdd(TiposObservacionesTablas oTOT)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave TAB_CODIGO, TOB_CODIGO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Tipos_Observaciones_Tablas(" +
                        "TAB_CODIGO, TOB_CODIGO, TOB_DESCRIPCION) " +
                        "values('" + oTOT.TabCodigo + "','"+ oTOT.TobCodigo + "','" +oTOT.TobDescripcion + "')", cn);
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

            public bool TiposObservacionesTablasUpdate(TiposObservacionesTablas oTOT)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Tipos_Observaciones_Tablas " +
                        "SET TOB_DESCRIPCION='" + oTOT.TobDescripcion + "' " +
                        "WHERE TAB_CODIGO='" + oTOT.TabCodigo+"' and TOB_CODIGO='" + oTOT.TobCodigo +"' ", cn);
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

            public bool TiposObservacionesTablasDelete(string Tab, string Tob)
            {


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Tipos_Observaciones_Tablas " +
                          "WHERE TAB_CODIGO='" + Tab + "' and TOB_CODIGO='" + Tob + "' ", cn);
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

            public TiposObservacionesTablas TiposObservacionesTablasGetById(string Tab, string Tob)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Observaciones_Tablas " +
                        "WHERE TAB_CODIGO='" + Tab + "' and TOB_CODIGO='" + Tob + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    TiposObservacionesTablas NewEnt = new TiposObservacionesTablas();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarTiposObservacionesTablas(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<TiposObservacionesTablas> TiposObservacionesTablasGetAll()
            {
                List<TiposObservacionesTablas> lstTiposObservacionesTablas = new List<TiposObservacionesTablas>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Observaciones_Tablas ";
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
                            TiposObservacionesTablas NewEnt = new TiposObservacionesTablas();
                            NewEnt = CargarTiposObservacionesTablas(dr);
                            lstTiposObservacionesTablas.Add(NewEnt);
                        }
                    }
                    return lstTiposObservacionesTablas;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private TiposObservacionesTablas CargarTiposObservacionesTablas(DataRow dr)
            {
                try
                {
                    TiposObservacionesTablas oObjeto = new TiposObservacionesTablas();
                    oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                    oObjeto.TobCodigo = dr["TOB_CODIGO"].ToString();
                    oObjeto.TobDescripcion = dr["TOB_DESCRIPCION"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            //public DataTable TiposObservacionesTablasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TiposObservacionesTablasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

