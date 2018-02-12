
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class RolesImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int RolesAdd(Roles oRol)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    //Clave ROL_CODIGO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Roles" +
                        "(ROL_CODIGO, SBS_CODIGO, ROL_DESCRIPCION, ROL_TIPO) " +
                        "values('" + oRol.RolCodigo + "','"+ oRol.SbsCodigo + "','"+ 
                        oRol.RolDescripcion + "','"+ oRol.RolTipo +"')", cn);
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

            public bool RolesUpdate(Roles oRol)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Roles " +
                        "SET SBS_CODIGO='" + oRol.SbsCodigo + "', " +
                        "ROL_DESCRIPCION='" + oRol.RolDescripcion + "' " +
                        "ROL_TIPO='" + oRol.RolTipo + "' " +
                        "WHERE ROL_CODIGO='" + oRol.RolCodigo + "'", cn);
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

            public bool RolesDelete(string Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Roles " +
                        "WHERE ROL_CODIGO='" + Id + "'", cn);
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

            public Roles RolesGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Roles " +
                        "WHERE ROL_CODIGO='" + Id + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Roles NewEnt = new Roles();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarRoles(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Roles> RolesGetAll()
            {
                List<Roles> lstRoles = new List<Roles>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Roles ";
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
                            Roles NewEnt = new Roles();
                            NewEnt = CargarRoles(dr);
                            lstRoles.Add(NewEnt);
                        }
                    }
                    return lstRoles;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private Roles CargarRoles(DataRow dr)
            {
                try
                {
                    Roles oObjeto = new Roles();
                    oObjeto.RolCodigo = dr["ROL_CODIGO"].ToString();
                    oObjeto.SbsCodigo = dr["SBS_CODIGO"].ToString();
                    oObjeto.RolDescripcion = dr["ROL_DESCRIPCION"].ToString();
                    oObjeto.RolTipo = dr["ROL_TIPO"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable RolesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "RolesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

