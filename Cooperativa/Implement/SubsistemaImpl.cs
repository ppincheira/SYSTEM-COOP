
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class SubsistemaImpl
        {
            #region Subsistema methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int SubsistemaAdd(Subsistema oSub)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();

                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Subsistema(SBS_CODIGO, SBS_NOMBRE) " +
                        "values('" + oSub.SbsCodigo + "', '" + oSub.SbsNombre + "')", cn);
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

            public bool SubsistemaUpdate(Subsistema oSub)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Subsistema " +
                        "SET SBS_NOMBRE='" + oSub.SbsNombre + "' "+
                        "WHERE SBS_CODIGO='" + oSub.SbsCodigo + "'", cn);
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

            public bool SubsistemaDelete(string Id)
            {


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Subsistema " +
                          "WHERE SBS_CODIGO='" + Id + "' ", cn);
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

            public Subsistema SubsistemaGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Subsistema " +
                          "WHERE SBS_CODIGO='" + Id + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Subsistema NewEnt = new Subsistema();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarSubsistema(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Subsistema> SubsistemaGetAll()
            {
                List<Subsistema> lstSubsistema = new List<Subsistema>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Subsistema ";
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
                            Subsistema NewEnt = new Subsistema();
                            NewEnt = CargarSubsistema(dr);
                            lstSubsistema.Add(NewEnt);
                        }
                    }
                    return lstSubsistema;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private Subsistema CargarSubsistema(DataRow dr)
            {
                try
                {
                    Subsistema oObjeto = new Subsistema();
                    oObjeto.SbsCodigo = dr["SBS_CODIGO"].ToString();
                    oObjeto.SbsNombre = dr["SBS_NOMBRE"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable SubsistemaGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "SubsistemaGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

