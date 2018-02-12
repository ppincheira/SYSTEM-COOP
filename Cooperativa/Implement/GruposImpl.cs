
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class GruposImpl
    {
        #region Grupos methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long GruposAdd(Grupos oGru)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia GRP_CODIGO
                ds = new DataSet();
                string query =

                    " DECLARE IDTEMP NUMBER(10,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('GRP_CODIGO')) into IDTEMP from dual; " +
                    " insert into Grupos " +
                    "(GRP_CODIGO, GRP_DESCRIPCION, TGR_CODIGO) " +
                    "values(IDTEMP,'" + oGru.GrpDescripcion + "', '" + oGru.GrpCodigo + 
                    "') RETURNING IDTEMP INTO :id;" +
                    " END;";
                cmd = new OracleCommand(query, cn);
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                response = long.Parse(cmd.Parameters[":id"].Value.ToString());
                cn.Close();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GruposUpdate(Grupos oGru)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Grupos " +
                    "SET GRP_DESCRIPCION='" + oGru.GrpDescripcion + "', " +
                    "TGR_CODIGO='" + oGru.TgrCodigo + "' " +
                    "WHERE GRP_CODIGO=" + oGru.GrpCodigo , cn);
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

        public bool GruposDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Grupos " +
                      "WHERE GRP_CODIGO=" + Id, cn);
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

        public Grupos GruposGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Grupos " +
                    "WHERE GRP_CODIGO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Grupos NewEnt = new Grupos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarGrupos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Grupos> GruposGetAll()
        {
            List<Grupos> lstGrupos = new List<Grupos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Grupos ";
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
                        Grupos NewEnt = new Grupos();
                        NewEnt = CargarGrupos(dr);
                        lstGrupos.Add(NewEnt);
                    }
                }
                return lstGrupos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Grupos> GruposGetbyTipoGrupo(string TipoGrupo)
        {
            List<Grupos> lstGrupos = new List<Grupos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Grupos where TGR_CODIGO='" + TipoGrupo + "'";
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
                        Grupos NewEnt = new Grupos();
                        NewEnt = CargarGrupos(dr);
                        lstGrupos.Add(NewEnt);
                    }
                }
                return lstGrupos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Grupos CargarGrupos(DataRow dr)
        {
            try
            {
                Grupos oObjeto = new Grupos();
                oObjeto.GrpCodigo = long.Parse(dr["GRP_CODIGO"].ToString());
                oObjeto.GrpDescripcion = dr["GRP_DESCRIPCION"].ToString();
                oObjeto.TgrCodigo = dr["TGR_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GruposGetByFilter(string TipoGrupo)
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT grp_codigo,grp_descripcion " +
                                   " FROM   grupos  " +
                                   " WHERE  tgr_codigo ='" + TipoGrupo + "'";

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
            //public DataTable GruposGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "GruposGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
