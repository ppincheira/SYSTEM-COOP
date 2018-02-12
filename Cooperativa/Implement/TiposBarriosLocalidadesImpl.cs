
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class TiposBarriosLocalidadesImpl
        {
        #region TiposBarriosLocalidades methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int TiposBarriosLocalidadesAdd(TiposBarriosLocalidades oTBL)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                //Clave TBL_CODIGO
                ds = new DataSet();
                    cmd = new OracleCommand("insert into Tipos_Barrios_Localidades(TBL_CODIGO, " +
                        "TBL_DESCRIPCION) " +
                        "values('" + oTBL.TblCodigo + "','"+ oTBL.TblDescripcion +"')", cn);
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

            public bool TiposBarriosLocalidadesUpdate(TiposBarriosLocalidades oTBL)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Tipos_Barrios_Localidades " +
                        "SET TBL_DESCRIPCION='" + oTBL.TblDescripcion + "' " +
                        "WHERE TBL_CODIGO='" + oTBL.TblCodigo + "'", cn);
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

            public bool TiposBarriosLocalidadesDelete(string Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Tipos_Barrios_Localidades " +
                        "WHERE TBL_CODIGO='" + Id + "'", cn);
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

            public TiposBarriosLocalidades TiposBarriosLocalidadesGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Barrios_Localidades " +
                        "WHERE TBL_CODIGO='" + Id + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    TiposBarriosLocalidades NewEnt = new TiposBarriosLocalidades();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarTiposBarriosLocalidades(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<TiposBarriosLocalidades> TiposBarriosLocalidadesGetAll()
            {
                List<TiposBarriosLocalidades> lstTiposBarriosLocalidades = new List<TiposBarriosLocalidades>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Barrios_Localidades ";
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
                            TiposBarriosLocalidades NewEnt = new TiposBarriosLocalidades();
                            NewEnt = CargarTiposBarriosLocalidades(dr);
                            lstTiposBarriosLocalidades.Add(NewEnt);
                        }
                    }
                    return lstTiposBarriosLocalidades;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private TiposBarriosLocalidades CargarTiposBarriosLocalidades(DataRow dr)
            {
                try
                {
                    TiposBarriosLocalidades oObjeto = new TiposBarriosLocalidades();
                    oObjeto.TblCodigo = dr["TBL_CODIGO"].ToString();
                    oObjeto.TblDescripcion = dr["TBL_DESCRIPCION"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable TiposBarriosLocalidadesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TiposBarriosLocalidadesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

