
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class TiposGruposImpl
    {
        #region TiposGrupos methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long TiposGruposAdd(TiposGrupos oTGr)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia GRP_CODIGO
                ds = new DataSet();
                string query =" insert into Tipos_Grupos " +
                    "(TGR_CODIGO, TGR_DESCRIPCION, TAB_CODIGO) " +
                    "values ('" + oTGr.TgrCodigo +"', '" + oTGr.TgrDescripcion + "', '" +
                    oTGr.TabCodigo + "')";
                cmd = new OracleCommand(query, cn);
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

        public bool TiposGruposUpdate(TiposGrupos oTGr)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Tipos_Grupos " +
                    "SET TGR_DESCRIPCION='" + oTGr.TgrDescripcion + "', " +
                    "TAB_CODIGO='" + oTGr.TabCodigo + "' " +
                    "WHERE TGR_CODIGO='" + oTGr.TgrCodigo +"'", cn);
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

        public bool TiposGruposDelete(string Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Tipos_Grupos " +
                      "WHERE TGR_CODIGO='" + Id+"'", cn);
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

        public TiposGrupos TiposGruposGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Grupos " +
                    "WHERE TGR_CODIGO='" + Id+"'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                TiposGrupos NewEnt = new TiposGrupos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTiposGrupos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TiposGrupos> TiposGruposGetAll()
        {
            List<TiposGrupos> lstTiposGrupos = new List<TiposGrupos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Grupos ";
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
                        TiposGrupos NewEnt = new TiposGrupos();
                        NewEnt = CargarTiposGrupos(dr);
                        lstTiposGrupos.Add(NewEnt);
                    }
                }
                return lstTiposGrupos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TiposGrupos> TiposGruposGetbyTabla(string TipoTGrpo)
        {
            List<TiposGrupos> lstTiposGrupos = new List<TiposGrupos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Grupos where TAB_CODIGO='" + TipoTGrpo + "'";
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
                        TiposGrupos NewEnt = new TiposGrupos();
                        NewEnt = CargarTiposGrupos(dr);
                        lstTiposGrupos.Add(NewEnt);
                    }
                }
                return lstTiposGrupos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TiposGrupos CargarTiposGrupos(DataRow dr)
        {
            try
            {
                TiposGrupos oObjeto = new TiposGrupos();
                oObjeto.TgrCodigo = dr["TGR_CODIGO"].ToString();
                oObjeto.TgrDescripcion = dr["GRP_DESCRIPCION"].ToString();
                oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable TiposGruposGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "TiposGruposGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
