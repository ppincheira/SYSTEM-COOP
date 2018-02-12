
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class TiposMedidoresFabricantesImpl
        {
        #region TiposMedidoresFabricantes methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int TiposMedidoresFabricantesAdd(TiposMedidoresFabricantes oTMF)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                //Clave TME_CODIGO y FAB_NUMERO
                ds = new DataSet();
                    cmd = new OracleCommand("insert into Tipos_Medidores_Fabricantes" +
                        "(TME_CODIGO, FAB_NUMERO) " +
                        "values('" + oTMF.TmeCodigo + "'," + oTMF.FabNumero + ")", cn);
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

            public bool TiposMedidoresFabricantesUpdate(TiposMedidoresFabricantes oTMF)
            {
/*                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Tipos_Medidores_Fabricantes " +
                        "SET  " +
                        "WHERE TME_CODIGO='" + oTMF.TMeCodigo + "'", cn);
                    adapter = new OracleDataAdapter(cmd);
                    response = cmd.ExecuteNonQuery();
                    cn.Close();
                    return response > 0;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
*/
                return true;
            }

        public bool TiposMedidoresFabricantesDelete(string Id, int Fab )
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Tipos_Medidores_Fabricantes " +
                        "WHERE TME_CODIGO='" + Id + "' and FAB_NUMERO="+Fab, cn);
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

            public TiposMedidoresFabricantes TiposMedidoresFabricantesGetById(string Id, int Fab)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Medidores_Fabricantes " +
                        "WHERE TME_CODIGO='" + Id + "' and FAB_NUMERO=" + Fab;
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    TiposMedidoresFabricantes NewEnt = new TiposMedidoresFabricantes();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarTiposMedidoresFabricantes(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<TiposMedidoresFabricantes> TiposMedidoresFabricantesGetAll()
            {
                List<TiposMedidoresFabricantes> lstTiposMedidoresFabricantes = new List<TiposMedidoresFabricantes>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Tipos_Medidores_Fabricantes ";
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
                            TiposMedidoresFabricantes NewEnt = new TiposMedidoresFabricantes();
                            NewEnt = CargarTiposMedidoresFabricantes(dr);
                            lstTiposMedidoresFabricantes.Add(NewEnt);
                        }
                    }
                    return lstTiposMedidoresFabricantes;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private TiposMedidoresFabricantes CargarTiposMedidoresFabricantes(DataRow dr)
            {
                try
                {
                    TiposMedidoresFabricantes oObjeto = new TiposMedidoresFabricantes();
                    oObjeto.TmeCodigo = dr["TME_CODIGO"].ToString();
                    oObjeto.FabNumero = int.Parse(dr["FAB_NUMERO"].ToString());
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
 
            //public DataTable TiposMedidoresFabricantesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TiposMedidoresFabricantesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

