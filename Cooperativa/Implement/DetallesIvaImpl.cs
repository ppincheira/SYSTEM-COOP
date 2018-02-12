
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class DetallesIvaImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int DetallesIvaAdd(DetallesIva oDIv)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave TIV_CODIGO y DIV_VIGENCIA_DESDE
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Detalles_Iva" +
                        "(TIV_CODIGO, DIV_PORCENTAJE, DIV_VIGENCIA_DESDE, DIV_VIGENCIA_HASTA) " +
                        "values('" + oDIv.TivCodigo + "',"+ oDIv.DivPorcentaje + ","+ 
                        oDIv.DivVigenciaDesde + "," +  oDIv.DivVigenciaHasta + ")", cn);
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

            public bool DetallesIvaUpdate(DetallesIva oDIv)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Detalles_Iva " +
                        "SET DIV_PORCENTAJE=" + oDIv.DivPorcentaje +
                        ", DIV_VIGENCIA_HASTA=" + oDIv.DivVigenciaHasta +
                        " WHERE TIV_CODIGO='" + oDIv.TivCodigo.ToString()+
                        "' and DIV_VIGENCIA_DESDE=" + oDIv.DivVigenciaDesde.ToString() , cn);
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

            public bool DetallesIvaDelete(string Tiv, DateTime Vig)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Detalles_Iva " +
                        "WHERE TIV_CODIGO='" + Tiv +
                        "' and DIV_VIGENCIA_DESDE=" + Vig.ToString(), cn);
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

            public DetallesIva DetallesIvaGetById(string Tiv, DateTime Vig)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Detalles_Iva " +
                         "WHERE TIV_CODIGO='" + Tiv +
                        "' and DIV_VIGENCIA_DESDE=" + Vig.ToString();
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    DetallesIva NewEnt = new DetallesIva();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarDetallesIva(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<DetallesIva> DetallesIvaGetAll()
            {
                List<DetallesIva> lstDetallesIva = new List<DetallesIva>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Detalles_Iva ";
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
                            DetallesIva NewEnt = new DetallesIva();
                            NewEnt = CargarDetallesIva(dr);
                            lstDetallesIva.Add(NewEnt);
                        }
                    }
                    return lstDetallesIva;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private DetallesIva CargarDetallesIva(DataRow dr)
            {
                try
                {
                    DetallesIva oObjeto = new DetallesIva();
                    oObjeto.TivCodigo = dr["TIV_CODIGO"].ToString();
                    oObjeto.DivPorcentaje = float.Parse(dr["DIV_PORCENTAJE"].ToString());
                    if (dr["DIV_VIGENCIA_DESDE"].ToString() != "")
                        oObjeto.DivVigenciaDesde = DateTime.Parse(dr["DIV_VIGENCIA_DESDE"].ToString());
                    if (dr["DIV_VIGENCIA_HASTA"].ToString() != "")
                        oObjeto.DivVigenciaHasta = DateTime.Parse(dr["DIV_VIGENCIA_HASTA"].ToString());
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable DetallesIvaGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "DetallesIvaGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

