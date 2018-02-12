
///////////////////////////////////////////////////////////////////////////
//
// Creado por: Pincheira Pablo
//
///////////////////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class FuncionalidadesUsuariosImpl
        {
            #region FuncionalidadesUsuarios methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int FuncionalidadesUsuariosAdd(FuncionalidadesUsuarios oFun)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();

                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Funcionalidades_Usuarios(FUN_CODIGO, USR_NUMERO, ROL_CODIGO) " +
                        "values('" + oFun.FunCodigo + "', " + oFun.UsrNumero + ", '" + oFun.RolCodigo +"')", cn);
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

            public bool FuncionalidadesUsuariosUpdate(FuncionalidadesUsuarios oFunActual, FuncionalidadesUsuarios oFunNuevo)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Funcionalidades_Usuarios " +
                        "SET FUN_CODIGO='" + oFunNuevo.FunCodigo + "'," +
                        "USR_NUMERO='" + oFunNuevo.UsrNumero +"', "+
                        "ROL_CODIGO='" + oFunNuevo.RolCodigo +"' "+
                        "WHERE FUN_CODIGO='" + oFunActual.FunCodigo + "' and USR_NUMERO=" + oFunActual.UsrNumero + " and ROL_CODIGO='" + oFunActual.RolCodigo + "'", cn);
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

            public bool FuncionalidadesUsuariosDelete(string Codigo, int Usuario, string Rol)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Funcionalidades_Usuarios " +
                        "WHERE FUN_CODIGO='" + Codigo + "' and USR_NUMERO=" + Usuario + " and ROL_CODIGO='" + Rol + "'", cn);
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

/*            public FuncionalidadesUsuarios FuncionalidadesUsuariosGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from FuncionalidadesUsuarios " +
                        "where FUN_CODIGO='" + Id + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    FuncionalidadesUsuarios NewEnt = new FuncionalidadesUsuarios();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarFuncionalidadesUsuarios(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
*/
            public List<FuncionalidadesUsuarios> FuncionalidadesUsuariosGetAll()
            {
                List<FuncionalidadesUsuarios> lstFuncionalidadesUsuarios = new List<FuncionalidadesUsuarios>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Funcionalidades_Usuarios ";
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
                            FuncionalidadesUsuarios NewEnt = new FuncionalidadesUsuarios();
                            NewEnt = CargarFuncionalidadesUsuarios(dr);
                            lstFuncionalidadesUsuarios.Add(NewEnt);
                        }
                    }
                    return lstFuncionalidadesUsuarios;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private FuncionalidadesUsuarios CargarFuncionalidadesUsuarios(DataRow dr)
            {
                try
                {
                    FuncionalidadesUsuarios oObjeto = new FuncionalidadesUsuarios();
                    oObjeto.FunCodigo = dr["FUN_CODIGO"].ToString();
                    oObjeto.UsrNumero =int.Parse(dr["USR_NUMERO"].ToString());
                    oObjeto.RolCodigo = dr["ROL_CODIGO"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable FuncionalidadesUsuariosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "FuncionalidadesUsuariosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

