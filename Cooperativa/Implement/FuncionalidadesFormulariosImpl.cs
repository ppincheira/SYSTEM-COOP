
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
    public class FuncionalidadesFormulariosImpl
    {
        #region FuncionalidadesFormularios methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int FuncionalidadesFormulariosAdd(FuncionalidadesFormularios oFun)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into FUNCIONALIDADES_FORMULARIOS(FFO_CODIGO, FFO_NOMBRE, FFO_TITULO) " +
                    "values('" + oFun.FfoNombre + "', '" + oFun.FfoTitulo + "')", cn);
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

        public bool FuncionalidadesFormulariosUpdate(FuncionalidadesFormularios oFun)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update FUNCIONALIDADES_FORMULARIOS " +
                    "SET FFO_NOMBRE='" + oFun.FfoNombre + "'," +
                    "FFO_TITULO='" + oFun.FfoTitulo + "' " +
                    "WHERE FFO_CODIGO=" + oFun.FfoCodigo + " ", cn);
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

        public bool FuncionalidadesFormulariosDelete(int Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE FUNCIONALIDADES_FORMULARIOS " +
                      "WHERE FFO_CODIGO='" + Id + "' ", cn);
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

        public FuncionalidadesFormularios FuncionalidadesFormulariosGetById(int Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from FUNCIONALIDADES_FORMULARIOS " +
                    "where FFO_CODIGO=" + Id + " ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                FuncionalidadesFormularios NewEnt = new FuncionalidadesFormularios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarFuncionalidadesFormularios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FuncionalidadesFormularios> FuncionalidadesFormulariosGetAll()
        {
            List<FuncionalidadesFormularios> lstFuncionalidades = new List<FuncionalidadesFormularios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from FUNCIONALIDADES_FORMULARIOS ";
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
                        FuncionalidadesFormularios NewEnt = new FuncionalidadesFormularios();
                        NewEnt = CargarFuncionalidadesFormularios(dr);
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

        private FuncionalidadesFormularios CargarFuncionalidadesFormularios(DataRow dr)
        {
            try
            {

               
                FuncionalidadesFormularios oObjeto = new FuncionalidadesFormularios();
                oObjeto.FfoCodigo = int.Parse(dr["FFO_CODIGO"].ToString());
                oObjeto.FfoNombre = dr["FFO_NOMBRE"].ToString();
                oObjeto.FfoTitulo = dr["FFO_TITULO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
