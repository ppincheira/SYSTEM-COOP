
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class PuntosVentasImpl
    {
        #region Departamento methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;

        public int PuntosVentasAdd(PuntosVentas oPv)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                //Clave ROL_CODIGO
                ds = new DataSet();
                cmd = new OracleCommand("insert into PUNTOS_VENTAS" +
                    "(PVT_NUMERO, PVT_DESCRIPCION, PVT_ACTIVIDAD, PVT_FISCAL) " +
                    "values('" + oPv.PvtNumero + "','" + oPv.PvtDescripcion + "','" +
                    oPv.PvtActividad + "','" + oPv.PvtFiscal + "')", cn);
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

        public bool PuntosVentasUpdate(PuntosVentas oPv)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update PUNTOS_VENTAS " +
                    "SET PVT_FISCAL='" + oPv.PvtFiscal + "', " +
                    "PVT_DESCRIPCION='" + oPv.PvtDescripcion + "' " +
                    "PVT_ACTIVIDAD='" + oPv.PvtActividad + "' " +
                    "WHERE PVT_NUMERO='" + oPv.PvtNumero + "'", cn);
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

        public bool PuntosVentasDelete(string Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE PUNTOS_VENTAS " +
                    "WHERE PVT_NUMERO='" + Id + "'", cn);
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

        public PuntosVentas PuntosVentasGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from PUNTOS_VENTAS " +
                    "WHERE PVT_NUMERO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                PuntosVentas NewEnt = new PuntosVentas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarPV(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PuntosVentas> PuntosVentasGetAll()
        {
            List<PuntosVentas> lstRoles = new List<PuntosVentas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from PUNTOS_VENTAS ";
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
                        PuntosVentas NewEnt = new PuntosVentas();
                        NewEnt = CargarPV(dr);
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

        private PuntosVentas CargarPV(DataRow dr)
        {
            try
            {
                PuntosVentas oObjeto = new PuntosVentas();
                oObjeto.PvtNumero = dr["PVT_NUMERO"].ToString();
                oObjeto.PvtDescripcion = dr["PVT_DESCRIPCION"].ToString();
                oObjeto.PvtActividad = dr["PVT_ACTIVIDAD"].ToString();
                oObjeto.PvtFiscal = dr["PVT_FISCAL"].ToString();
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

