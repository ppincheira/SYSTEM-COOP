using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class TiposConceptosImpl
    {
        #region TiposConceptos methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;

        public int TiposConceptosAdd(TiposConceptos oTic)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();                
                ds = new DataSet();
                cmd = new OracleCommand("insert into Tipos_Conceptos(TIC_CODIGO, TIC_DESCRIPCION ) " +
                                        "values('" + oTic.ticCodigo + "','" + oTic.ticDescripcion + "')", cn);
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

        public bool TiposConceptosUpdate(TiposConceptos oTic)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Tipos_Conceptos " +
                                        "SET    TIC_DESCRIPCION='" + oTic.ticDescripcion + "' " +
                                        "WHERE  TIC_CODIGO=" + oTic.ticCodigo, cn);
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

        public bool TiposConceptosDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Tipos_Conceptos " +
                                        "WHERE TIC_CODIGO=" + Id, cn);
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

        public TiposConceptos TiposConceptosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Conceptos " +
                                   "where TIC_CODIGO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                TiposConceptos NewEnt = new TiposConceptos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTiposConceptos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TiposConceptos> TiposConceptosGetAll()
        {
            List<TiposConceptos> lstTiposConceptos = new List<TiposConceptos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Conceptos ";
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
                        TiposConceptos NewEnt = new TiposConceptos();
                        NewEnt = CargarTiposConceptos(dr);
                        lstTiposConceptos.Add(NewEnt);
                    }
                }
                return lstTiposConceptos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TiposConceptos CargarTiposConceptos(DataRow dr)
        {
            try
            {
                TiposConceptos oObjeto = new TiposConceptos();
                oObjeto.ticCodigo = dr["TIC_CODIGO"].ToString();
                oObjeto.ticDescripcion = dr["TIC_DESCRIPCION"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TiposConceptosGetByFilter()
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT tic_codigo,tic_descripcion " +
                                   " FROM   Tipos_Conceptos  ";
                Console.WriteLine("sqlSelect-" + sqlSelect);
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);

                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
