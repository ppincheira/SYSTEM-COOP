
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class TiposIvaImpl
        {
        #region TiposIva methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int TiposIvaAdd(TiposIva oTIv)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                //Clave TIV_CODIGO
                ds = new DataSet();
                    cmd = new OracleCommand("insert into Tipos_Iva(TIV_CODIGO, TIV_DESCRIPCION, " +
                        "TIV_DISCRIMINA, TIV_EXENTO, TIV_GENERA_IVA, TIV_CODIGO_AFIP) " +
                        "values('" + oTIv.TivCodigo + "','" + oTIv.TivDescripcion + "','" + oTIv.TivDiscrimina + "','" + 
                        oTIv.TivExento + "','" + oTIv.TivGeneraIva + "','" + oTIv.TivCodigoAfip + "')", cn);
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

            public bool TiposIvaUpdate(TiposIva oTIv)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Tipos_Iva " +
                        "SET TIV_DESCRIPCION='" + oTIv.TivDescripcion + "', " +
                        "TIV_DISCRIMINA='" + oTIv.TivDiscrimina + "', " +
                        "TIV_EXENTO='" + oTIv.TivExento + "', " +
                        "TIV_GENERA_IVA='" + oTIv.TivGeneraIva + "', " +
                        "TIV_CODIGO_AFIP='" + oTIv.TivCodigoAfip + "' " +
                        "WHERE TIV_CODIGO='" + oTIv.TivCodigo + "'", cn);
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

        public bool TiposIvaDelete(string Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Tipos_Iva " +
                        "WHERE TIV_CODIGO='" + Id + "'", cn);
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

            public TiposIva TiposIvaGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Iva " +
                        "WHERE TIV_CODIGO='" + Id + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    TiposIva NewEnt = new TiposIva();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarTiposIva(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<TiposIva> TiposIvaGetAll()
            {
                List<TiposIva> lstTiposIva = new List<TiposIva>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Iva ";
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
                            TiposIva NewEnt = new TiposIva();
                            NewEnt = CargarTiposIva(dr);
                            lstTiposIva.Add(NewEnt);
                        }
                    }
                    return lstTiposIva;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private TiposIva CargarTiposIva(DataRow dr)
            {
                try
                {
                    TiposIva oObjeto = new TiposIva();
                    oObjeto.TivCodigo = dr["TIV_CODIGO"].ToString();
                    oObjeto.TivDescripcion = dr["TIV_DESCRIPCION"].ToString();
                    oObjeto.TivDiscrimina = dr["TIV_DISCRIMINA"].ToString();
                    oObjeto.TivExento = dr["TIV_EXENTO"].ToString();
                    oObjeto.TivGeneraIva = dr["TIV_GENERA_IVA"].ToString();
                    oObjeto.TivCodigoAfip = dr["TIV_CODIGO_AFIP"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        public DataTable TiposIvaGetAllDT()
        {
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Iva ";
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
        //public DataTable TiposIvaGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TiposIvaGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

