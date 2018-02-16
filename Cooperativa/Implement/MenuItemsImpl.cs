using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Data;
using Model;
namespace Implement
{
    public class MenuItemsImpl
    {

        #region MenuItems methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;

        public int MenuItemsAdd(MenuItems oMen)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into MenuItems(MNI_CODIGO, MNI_CODIGO_PADRE, " +
                    "MNI_DESCRIPCION, FRM_NOMBRE, MNI_PARAMETROS, SBS_CODIGO, FUN_CODIGO) " +
                    "values('" + oMen.MniCodigo + "','" + oMen.MniCodigoPadre + "', '" + oMen.MniDescripcion + "','" + 
                    oMen.FrmNombre + "'," + oMen.MniParametros + ",'" + oMen.SbsCodigo + "','" + oMen.FunCodigo + "')", cn);
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

        public bool MenuItemsUpdate(MenuItems oMen)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update MenuItems " +
                    "SET MNI_CODIGO_PADRE='" + oMen.MniCodigoPadre + "'," +
                    "MNI_DESCRIPCION=" + oMen.MniDescripcion + ", " +
                    "FRM_NOMBRE='" + oMen.FrmNombre + "', " +
                    "MNI_PARAMETROS='" + oMen.MniParametros + "', " +
                    "SBS_CODIGO='" + oMen.SbsCodigo + "', " +
                    "FUN_CODIGO='" + oMen.FunCodigo +"' "+
                    "WHERE MNI_CODIGO='" + oMen.MniCodigo + "' ", cn);
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

        public bool MenuItemsDelete(string Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE MenuItems " +
                    "WHERE MNI_CODIGO='" + Id + "' ", cn);
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

        public MenuItems MenuItemsGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from MENU_ITEMS " +
                    "where MNI_CODIGO='" + Id + "' ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                MenuItems NewEnt = new MenuItems();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarMenuItems(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<MenuItems> MenuItemsGetBySbsCodigo(string SbsCodigo)
        {
        List<MenuItems> lstMenuItems = new List<MenuItems>();
        try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from MENU_ITEMS " +
                    "where SBS_CODIGO='" + SbsCodigo + "'";
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
                        MenuItems NewEnt = new MenuItems();
                        NewEnt = CargarMenuItems(dr);
                        lstMenuItems.Add(NewEnt);
                    }
                }
                return lstMenuItems;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MenuItems> MenuItemsGetAll()
        {
            List<MenuItems> lstMenuItems = new List<MenuItems>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from MENU_ITEMS ";
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
                        MenuItems NewEnt = new MenuItems();
                        NewEnt = CargarMenuItems(dr);
                        lstMenuItems.Add(NewEnt);
                    }
                }
                return lstMenuItems;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private MenuItems CargarMenuItems(DataRow dr)
        {
            try
            {
                MenuItems oObjeto = new MenuItems();
                oObjeto.MniCodigo = dr["MNI_CODIGO"].ToString();
                oObjeto.MniCodigoPadre = dr["MNI_CODIGO_PADRE"].ToString();
                oObjeto.MniDescripcion = dr["MNI_DESCRIPCION"].ToString();
                oObjeto.FrmNombre = dr["FRM_NOMBRE"].ToString();
                if (dr["MNI_PARAMETROS"].ToString() != "")
                    oObjeto.MniParametros = short.Parse(dr["MNI_PARAMETROS"].ToString());
                oObjeto.SbsCodigo = dr["SBS_CODIGO"].ToString();
                oObjeto.FunCodigo = dr["FUN_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable MenuItemsGetByIdCodigo(string codigo)
        {
            try
            {
                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from MENU_ITEMS " +
                    " where SBS_CODIGO = '" + codigo + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt = new DataTable();
                   return dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
