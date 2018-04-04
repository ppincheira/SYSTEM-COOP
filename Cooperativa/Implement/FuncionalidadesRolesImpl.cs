
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
    public class FuncionalidadesRolesImpl
    {
        #region FuncionalidadesRoles methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int FuncionalidadesRolesAdd(FuncionalidadesRoles oRol)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into FUNCIONALIDADES_ROLES(ROL_CODIGO, FUN_CODIGO) " +
                    "values('" + oRol.RolCodigo + "', '" + oRol.FunCodigo + "')", cn);
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

        public bool FuncionalidadesRolesUpdate(FuncionalidadesRoles oRol)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update FUNCIONALIDADES_ROLES " +
                    "SET FUN_CODIGO='" + oRol.FunCodigo + "' " +
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

        public bool FuncionalidadesRolesDelete(string Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE FUNCIONALIDADES_ROLES " +
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

        public List<FuncionalidadesRoles> FuncionalidadesRolesGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from FUNCIONALIDADES_ROLES " +
                    "where ROL_CODIGO='" + Id + "' ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                List<FuncionalidadesRoles> NewEnt = new List<FuncionalidadesRoles>();
                if (dt.Rows.Count > 0)
                {
                    DataRowCollection dr = dt.Rows;
                    NewEnt = CargarFuncionalidadesRoles(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FuncionalidadesRoles> FuncionalidadesRolesGetAll()
        {
            List<FuncionalidadesRoles> lstFuncionalidadesRoles = new List<FuncionalidadesRoles>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from FUNCIONALIDADES_ROLES ";
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
                        FuncionalidadesRoles NewEnt = new FuncionalidadesRoles();
                        NewEnt = CargarFuncionalidadesRoles(dr);
                        lstFuncionalidadesRoles.Add(NewEnt);
                    }
                }
                return lstFuncionalidadesRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private FuncionalidadesRoles CargarFuncionalidadesRoles(DataRow dr)
        {
            try
            {
                FuncionalidadesRoles oObjeto = new FuncionalidadesRoles();
                oObjeto.RolCodigo = dr["ROL_CODIGO"].ToString();
                oObjeto.FunCodigo = dr["FUN_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<FuncionalidadesRoles> CargarFuncionalidadesRoles(DataRowCollection dr)
        {
            try
            {
                List<FuncionalidadesRoles> salida = new List<FuncionalidadesRoles>();
                FuncionalidadesRoles oObjeto = new FuncionalidadesRoles();
                foreach (DataRow a in dr)
                {
                    oObjeto = new FuncionalidadesRoles();
                    oObjeto.RolCodigo = a["ROL_CODIGO"].ToString();
                    oObjeto.FunCodigo = a["FUN_CODIGO"].ToString();
                    salida.Add(oObjeto);
                }

                return salida;
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

