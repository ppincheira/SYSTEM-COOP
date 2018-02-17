
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
        public class FuncionalidadesImpl
        {
            #region Funcionalidades methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int FuncionalidadesAdd(Funcionalidades oFun)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();

                    ds = new DataSet();
                    cmd = new OracleCommand("insert into FUNCIONALIDADES(FUN_CODIGO, FUN_DESCRIPCION, FUN_FUNCIONALIDAD, SBS_CODIGO, FFO_CODIGO) " +
                        "values('" + oFun.FunCodigo + "', '" + oFun.FunDescripcion + "', '" + oFun.FunFuncionalidad + "','"+ oFun.SbsCodigo +"',"+oFun.ffoCodigo+")", cn);
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

            public bool FuncionalidadesUpdate(Funcionalidades oFun)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Funcionalidades " +
                        "SET FUN_DESCRIPCION='" + oFun.FunDescripcion + "'," +
                        "FUN_FUNCIONALIDAD='" + oFun.FunFuncionalidad +"', "+
                        "SBS_CODIGO='" + oFun.SbsCodigo +"', "+
                        "FFO_CODIGO="+oFun.ffoCodigo +" "+
                        "WHERE FUN_CODIGO='" + oFun.FunCodigo + "' ", cn);
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

            public bool FuncionalidadesDelete(string Id)
            {


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Funcionalidades " +
                          "WHERE FUN_CODIGO='" + Id + "' ", cn);
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

            public Funcionalidades FuncionalidadesGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Funcionalidades " +
                        "where FUN_CODIGO='" + Id + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Funcionalidades NewEnt = new Funcionalidades();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarFuncionalidades(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Funcionalidades> FuncionalidadesGetAll()
            {
                List<Funcionalidades> lstFuncionalidades = new List<Funcionalidades>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Funcionalidades ";
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
                            Funcionalidades NewEnt = new Funcionalidades();
                            NewEnt = CargarFuncionalidades(dr);
                            lstFuncionalidades.Add(NewEnt);
                        }
                    }
                    return lstFuncionalidades;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private Funcionalidades CargarFuncionalidades(DataRow dr)
            {
                try
                {
                    Funcionalidades oObjeto = new Funcionalidades();
                    oObjeto.FunCodigo = dr["FUN_CODIGO"].ToString();
                    oObjeto.FunDescripcion = dr["FUN_DESCRIPCION"].ToString();
                    oObjeto.FunDescripcion = dr["FUN_FUNCIONALIDAD"].ToString();
                    oObjeto.SbsCodigo = dr["SBS_CODIGO"].ToString();
                    if (dr["FFO_CODIGO"].ToString()!="") 
                        oObjeto.ffoCodigo = int.Parse(dr["FFO_CODIGO"].ToString()) ;
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public DataTable FuncionalidadesPermisos(string formulario, int usrNumero, string sbscodigo )
            {
                try
                {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT F.* FROM OWNER.FUNCIONALIDADES F " +
                " INNER JOIN OWNER.FUNCIONALIDADES_FORMULARIOS FF ON F.FFO_CODIGO = FF.FFO_CODIGO " +
                " INNER JOIN OWNER.FUNCIONALIDADES_USUARIOS FU ON FU.FUN_CODIGO = F.FUN_CODIGO " +
                " WHERE SBS_CODIGO='"+sbscodigo+"' AND " +
                " FF.FFO_NOMBRE='"+ formulario + "' AND "+
                " FU.USR_NUMERO="+ usrNumero.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                return  dt = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        #endregion

    }
}

