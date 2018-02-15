
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
    public class DetallesColumnasTablasImpl
    {
        #region DetallesColumnasTablas methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int DetallesColumnasTablasAdd(DetallesColumnasTablas oDetalle)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into DetallesColumnasTablas(TAB_CODIGO, DCT_NRO_ORDEN," +
                    "DCT_COLUMNA,DCT_HABILITADO,DCT_REQUERIDO,DCT_DESCRIPCION,DCT_ETIQUETA, DCT_TIPO_CONTROL,DCT_LISTA_VALORES," +
                    "DCT_FILTRO_BUSQUEDA) " +
                    "values('" + oDetalle.TabCodigo + "', " + oDetalle.DctNroOrden + 
                    ",'"+oDetalle.DctColumna+"','"+ oDetalle.DctHabilitado+"','"+oDetalle.DctRequerido+"','"+oDetalle.DctDescripcion+"','" + oDetalle.DctEtiqueta +"'"+
                    ",'"+oDetalle.DctTipoControl+"','"+oDetalle.DctListaValores+"','"+oDetalle.DctFiltroBusqueda+"')", cn);
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

        public bool DetallesColumnasTablasUpdate(DetallesColumnasTablas oDetalle)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                //cmd = new OracleCommand("update DetallesColumnasTablas " +
                //    "SET DEP_NUMERO=" + oDetalle.DepNumero + "," +
                //    "DEP_DESCRIPCION='" + oDetalle.DepDescripcion + "'," +
                //    "ARE_CODIGO='" + oDetalle.AreCodigo + "' " +
                //    "WHERE DEP_NUMERO=" + oDetalle.DepNumero, cn);
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

        public bool DetallesColumnasTablasDelete(string Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE DetallesColumnasTablas " +
                      "WHERE TAB_CODIGO='" + Id, cn);
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

        public DetallesColumnasTablas DetallesColumnasTablasGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from DetallesColumnasTablas " +
                    "where DEP_NUMERO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                DetallesColumnasTablas NewEnt = new DetallesColumnasTablas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarDetallesColumnasTablas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<DetallesColumnasTablas> DetallesColumnasTablasGetAll()
        {
            List<DetallesColumnasTablas> lstDetallesColumnasTablas = new List<DetallesColumnasTablas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from DetallesColumnasTablas ";
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
                        DetallesColumnasTablas NewEnt = new DetallesColumnasTablas();
                        NewEnt = CargarDetallesColumnasTablas(dr);
                        lstDetallesColumnasTablas.Add(NewEnt);
                    }
                }
                return lstDetallesColumnasTablas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DetallesColumnasTablas> DetallesColumnasTablasGetByName(String name)
        {
            List<DetallesColumnasTablas> lstDetallesColumnasTablas = new List<DetallesColumnasTablas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT DCT.* FROM  DETALLES_COLUMNAS_TABLAS DCT " +
                " INNER JOIN TABLAS t on t.TAB_CODIGO = dct.TAB_CODIGO "+
                " WHERE T.TAB_NOMBRE = '" + name+"' ORDER BY DCT.DCT_NRO_ORDEN";
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
                        DetallesColumnasTablas NewEnt = new DetallesColumnasTablas();
                        NewEnt = CargarDetallesColumnasTablas(dr);
                        lstDetallesColumnasTablas.Add(NewEnt);
                    }
                }
                return lstDetallesColumnasTablas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DetallesColumnasTablas> DetallesColumnasTablasGetByCodigo(String codigo)
        {
            List<DetallesColumnasTablas> lstDetallesColumnasTablas = new List<DetallesColumnasTablas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT DCT.* FROM  DETALLES_COLUMNAS_TABLAS DCT " +
                " INNER JOIN TABLAS t on t.TAB_CODIGO = dct.TAB_CODIGO " +
                " WHERE T.TAB_CODIGO = '" + codigo + "'ORDER BY DCT.DCT_NRO_ORDEN"; 
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
                        DetallesColumnasTablas NewEnt = new DetallesColumnasTablas();
                        NewEnt = CargarDetallesColumnasTablas(dr);
                        lstDetallesColumnasTablas.Add(NewEnt);
                    }
                }
                return lstDetallesColumnasTablas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DetallesColumnasTablas CargarDetallesColumnasTablas(DataRow dr)
        {
            try
            {
                DetallesColumnasTablas oObjeto = new DetallesColumnasTablas();
                oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                oObjeto.DctNroOrden = short.Parse(dr["DCT_NRO_ORDEN"].ToString());
                oObjeto.DctColumna = dr["DCT_COLUMNA"].ToString();
                oObjeto.DctHabilitado= dr["DCT_HABILITADO"].ToString();
                oObjeto.DctRequerido = dr["DCT_REQUERIDO"].ToString();
                oObjeto.DctDescripcion = dr["DCT_DESCRIPCION"].ToString();
                oObjeto.DctEtiqueta = dr["DCT_ETIQUETA"].ToString();
                oObjeto.DctTipoControl= dr["DCT_TIPO_CONTROL"].ToString();
                oObjeto.DctListaValores = dr["DCT_LISTA_VALORES"].ToString();
                oObjeto.DctFiltroBusqueda= dr["DCT_FILTRO_BUSQUEDA"].ToString();

                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public DataTable DetallesColumnasTablasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "DetallesColumnasTablasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

