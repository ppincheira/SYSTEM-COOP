
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
        public class RolesMenuItemsImpl
        {
            #region RolesMenuItems methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int RolesMenuItemsAdd(RolesMenuItems oRol)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();

                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Roles_Menu_Items(ROL_CODIGO, " +
                        "MNI_CODIGO, RMI_SOLO_LECTURA) " +
                        "values('" + oRol.RolCodigo + "', '" + 
                        oRol.MniCodigo + "', '" + oRol.RmiSoloLectura + "')", cn);
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

            public bool RolesMenuItemsUpdate(RolesMenuItems oRolActual, RolesMenuItems oRolNuevo)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Roles_Menu_Items " +
                        "SET RMI_SOLO_LECTURA='" + oRolNuevo.RmiSoloLectura + "' "+
                        "WHERE ROL_CODIGO='" + oRolActual.RolCodigo + "' and MNI_CODIGO='" + oRolActual.MniCodigo + "'", cn);
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

            public bool RolesMenuItemsDelete(string IdRol, string IdMni)
            {


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Roles_Menu_Items " +
                          "WHERE ROL_CODIGO='" + IdRol + "' and MNI_CODIGO='" + IdMni + "' ", cn);
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

            public RolesMenuItems RolesMenuItemsGetById(string IdRol, string IdMni)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Roles_Menu_Items " +
                          "WHERE ROL_CODIGO='" + IdRol + "' and MNI_CODIGO='" + IdMni + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    RolesMenuItems NewEnt = new RolesMenuItems();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarRolesMenuItems(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<RolesMenuItems> RolesMenuItemsGetByRol(string Id)
            {
            List<RolesMenuItems> lstRolesMenuItems = new List<RolesMenuItems>();
            try
            {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Roles_Menu_Items " +
                        "where ROL_CODIGO='" + Id + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; dt.Rows.Count > i; i++)
                        {
                            DataRow dr = dt.Rows[i];
                            RolesMenuItems NewEnt = new RolesMenuItems();
                            NewEnt = CargarRolesMenuItems(dr);
                            lstRolesMenuItems.Add(NewEnt);
                        }
                    }
                    return lstRolesMenuItems;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public List<RolesMenuItems> RolesMenuItemsGetByMenu(string Id)
            {
                List<RolesMenuItems> lstRolesMenuItems = new List<RolesMenuItems>();
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Roles_Menu_Items " +
                        "where MNI_CODIGO='" + Id + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; dt.Rows.Count > i; i++)
                        {
                            DataRow dr = dt.Rows[i];
                            RolesMenuItems NewEnt = new RolesMenuItems();
                            NewEnt = CargarRolesMenuItems(dr);
                            lstRolesMenuItems.Add(NewEnt);
                        }
                    }
                    return lstRolesMenuItems;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public List<RolesMenuItems> RolesMenuItemsGetAll()
            {
                List<RolesMenuItems> lstRolesMenuItems = new List<RolesMenuItems>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Roles_Menu_Items ";
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
                            RolesMenuItems NewEnt = new RolesMenuItems();
                            NewEnt = CargarRolesMenuItems(dr);
                            lstRolesMenuItems.Add(NewEnt);
                        }
                    }
                    return lstRolesMenuItems;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private RolesMenuItems CargarRolesMenuItems(DataRow dr)
            {
                try
                {
                    RolesMenuItems oObjeto = new RolesMenuItems();
                    oObjeto.RolCodigo = dr["ROL_CODIGO"].ToString();
                    oObjeto.MniCodigo = dr["MNI_CODIGO"].ToString();
                    oObjeto.RmiSoloLectura = dr["RMI_SOLO_LECTURA"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable RolesMenuItemsGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "RolesMenuItemsGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

