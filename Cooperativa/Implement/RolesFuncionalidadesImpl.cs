
///////////////////////////////////////////////////////////////////////////
//
// Creado por: Pincheira Pablo
//
///////////////////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
        public class RolesFuncionalidadesImpl
        {
            #region RolesFuncionalidades methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int RolesFuncionalidadesAdd(RolesFuncionalidades oRol)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();

                    ds = new DataSet();
                    cmd = new OracleCommand("insert into RolesFuncionalidades(ROL_CODIGO, FUN_CODIGO) " +
                        "values('" + oRol.RolCodigo + "', '" + oRol.FunCodigo +"')", cn);
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

            public bool RolesFuncionalidadesUpdate(RolesFuncionalidades oRol)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update RolesFuncionalidades " +
                        "SET FUN_CODIGO='" + oRol.FunCodigo + "' "+
                        "WHERE ROL_CODIGO='" + oRol.RolCodigo + "' ", cn);
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

            public bool RolesFuncionalidadesDelete(string Id)
            {


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE RolesFuncionalidades " +
                          "WHERE ROL_CODIGO='" + Id + "' ", cn);
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

            public RolesFuncionalidades RolesFuncionalidadesGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from RolesFuncionalidades " +
                        "where ROL_CODIGO='" + Id + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    RolesFuncionalidades NewEnt = new RolesFuncionalidades();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarRolesFuncionalidades(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<RolesFuncionalidades> RolesFuncionalidadesGetAll()
            {
                List<RolesFuncionalidades> lstRolesFuncionalidades = new List<RolesFuncionalidades>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from RolesFuncionalidades ";
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
                            RolesFuncionalidades NewEnt = new RolesFuncionalidades();
                            NewEnt = CargarRolesFuncionalidades(dr);
                            lstRolesFuncionalidades.Add(NewEnt);
                        }
                    }
                    return lstRolesFuncionalidades;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private RolesFuncionalidades CargarRolesFuncionalidades(DataRow dr)
            {
                try
                {
                    RolesFuncionalidades oObjeto = new RolesFuncionalidades();
                    oObjeto.RolCodigo = dr["ROL_CODIGO"].ToString();
                    oObjeto.FunCodigo = dr["FUN_CODIGO"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable RolesFuncionalidadesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "RolesFuncionalidadesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

