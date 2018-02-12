
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
        public class MenuItemsUsuariosImpl
        {
            #region MenuItemsUsuarios methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int MenuItemsUsuariosAdd(MenuItemsUsuarios oMen)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();

                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Menu_Items_Usuarios(MNI_CODIGO, USR_NUMERO, ROL_CODIGO, MIU_SOLO_LECTURA) " +
                        "values('" + oMen.MniCodigo + "'," + oMen.UsrNumero + ", '" + oMen.RolCodigo + "','"+ oMen.MiuSoloLectura +"')", cn);
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

            public bool MenuItemsUsuariosUpdate(MenuItemsUsuarios oMenActual, MenuItemsUsuarios oMenNuevo)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Menu_Items_Usuarios " +
                        "SET MNI_CODIGO='" + oMenNuevo.MniCodigo + "'," +
                        "USR_NUMERO=" + oMenNuevo.UsrNumero +", "+
                        "ROL_CODIGO='" + oMenNuevo.RolCodigo +"', "+
                        "MIU_SOLO_LECTURA='" + oMenNuevo.MiuSoloLectura +"' "+
                        "WHERE MNI_CODIGO='" + oMenActual.MniCodigo + "' and USR_NUMERO=" + oMenActual.UsrNumero + " and ROL_CODIGO='" + oMenActual.RolCodigo + "' and MIU_SOLO_LECTURA='" + oMenActual.MiuSoloLectura + "' ", cn);
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

            public bool MenuItemsUsuariosDelete(MenuItemsUsuarios oMen)
            {


                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Menu_Items_Usuarios " +
                        "WHERE MNI_CODIGO='" + oMen.MniCodigo + "' and USR_NUMERO=" + oMen.UsrNumero + " and ROL_CODIGO='" + oMen.RolCodigo + "' and MIU_SOLO_LECTURA='" + oMen.MiuSoloLectura + "' ", cn);
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

/*            public MenuItemsUsuarios MenuItemsUsuariosGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from MenuItemsUsuarios " +
                        "where Men_CODIGO='" + Id + "' ";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    MenuItemsUsuarios NewEnt = new MenuItemsUsuarios();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarMenuItemsUsuarios(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
*/
            public List<MenuItemsUsuarios> MenuItemsUsuariosGetAll()
            {
                List<MenuItemsUsuarios> lstMenuItemsUsuarios = new List<MenuItemsUsuarios>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Menu_Items_Usuarios ";
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
                            MenuItemsUsuarios NewEnt = new MenuItemsUsuarios();
                            NewEnt = CargarMenuItemsUsuarios(dr);
                            lstMenuItemsUsuarios.Add(NewEnt);
                        }
                    }
                    return lstMenuItemsUsuarios;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private MenuItemsUsuarios CargarMenuItemsUsuarios(DataRow dr)
            {
                try
                {
                    MenuItemsUsuarios oObjeto = new MenuItemsUsuarios();
                    oObjeto.MniCodigo = dr["MNI_CODIGO"].ToString();
                    oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                    oObjeto.RolCodigo = dr["ROL_CODIGO"].ToString();
                    oObjeto.MiuSoloLectura = dr["MIU_SOLO_LECTURA"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable MenuItemsUsuariosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "MenuItemsUsuariosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

