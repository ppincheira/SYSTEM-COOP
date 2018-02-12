
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
    public class SectoresImpl
    {
        #region Sectores methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int SectoresAdd(Sectores oSector)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into Sectores(SEC_CODIGO, SEC_DESCRIPCION, DEP_NUMERO, ARE_CODIGO) " +
                    "values('" + oSector.SecCodigo + "', '" +oSector.SecDescripcion + "'," + oSector.DepNumero + ",'"+oSector.AreCodigo+"')", cn);
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

        public bool SectoresUpdate(Sectores oSector)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Sectores " +
                    "SET SEC_CODIGO=" + oSector.SecCodigo + "," +
                    "SEC_DESCRIPCION='" + oSector.SecDescripcion + "'," +
                    "DEP_NUMERO=" + oSector.DepNumero + " " +
                    "ARE_CODIGO='" + oSector.AreCodigo + "' " +
                    "WHERE SEC_CODIGO='" + oSector.SecCodigo +"'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SectoresDelete(string Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Sectores " +
                      "WHERE SEC_CODIGO='" + Id +"'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public Sectores SectoresGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Sectores " +
                    "where SEC_CODIGO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Sectores NewEnt = new Sectores();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarSectores(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Sectores> SectoresGetAll()
        {
            List<Sectores> lstSectores = new List<Sectores>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Sectores ";
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
                        Sectores NewEnt = new Sectores();
                        NewEnt = CargarSectores(dr);
                        lstSectores.Add(NewEnt);
                    }
                }
                return lstSectores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Sectores CargarSectores(DataRow dr)
        {
            try
            {
                Sectores oObjeto = new Sectores();
                oObjeto.SecCodigo =dr["SEC_CODIGO"].ToString();
                oObjeto.SecDescripcion = dr["SEC_DESCRIPCION"].ToString();
                oObjeto.DepNumero = short.Parse(dr["DEP_NUMERO"].ToString());
                oObjeto.AreCodigo = dr["ARE_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public DataTable SectoresGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "SectoresGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
