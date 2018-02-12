
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class TiposLocalidadesImpl
        {
        #region TiposLocalidades methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int TiposLocalidadesAdd(TiposLocalidades oTLo)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                //Clave TLO_CODIGO
                ds = new DataSet();
                    cmd = new OracleCommand("insert into Tipos_Localidades(TLO_CODIGO, " +
                        "TLO_DESCRIPCION) " +
                        "values('" + oTLo.TloCodigo + "','"+ oTLo.TloDescripcion +"')", cn);
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

            public bool TiposLocalidadesUpdate(TiposLocalidades oTLo)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Tipos_Localidades " +
                        "SET TLO_DESCRIPCION='" + oTLo.TloDescripcion + "' " +
                        "WHERE TLO_CODIGO='" + oTLo.TloCodigo + "'", cn);
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

            public bool TiposLocalidadesDelete(string Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Tipos_Localidades " +
                        "WHERE TLO_CODIGO='" + Id +"'", cn);
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

            public TiposLocalidades TiposLocalidadesGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Localidades " +
                        "WHERE TLO_CODIGO='" + Id + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    TiposLocalidades NewEnt = new TiposLocalidades();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarTiposLocalidades(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<TiposLocalidades> TiposLocalidadesGetAll()
            {
                List<TiposLocalidades> lstTiposLocalidades = new List<TiposLocalidades>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Localidades ";
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
                            TiposLocalidades NewEnt = new TiposLocalidades();
                            NewEnt = CargarTiposLocalidades(dr);
                            lstTiposLocalidades.Add(NewEnt);
                        }
                    }
                    return lstTiposLocalidades;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private TiposLocalidades CargarTiposLocalidades(DataRow dr)
            {
                try
                {
                    TiposLocalidades oObjeto = new TiposLocalidades();
                    oObjeto.TloCodigo = dr["TLO_CODIGO"].ToString();
                    oObjeto.TloDescripcion = dr["TLO_DESCRIPCION"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable TiposLocalidadesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TiposLocalidadesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

