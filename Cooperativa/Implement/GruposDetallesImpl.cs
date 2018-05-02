
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class GruposDetallesImpl
    {
        #region GruposDetalles methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;

        public long GruposDetallesAdd(GruposDetalles oGrD)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia GRD_CODIGO
                ds = new DataSet();
                string query =

                    " DECLARE IDTEMP NUMBER(10,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('GRD_CODIGO')) into IDTEMP from dual; " +
                    " insert into Grupos_Detalles " +
                    "(GRD_CODIGO, GRD_CODIGO_REGISTRO, GRP_CODIGO) " +
                    "values(IDTEMP,'" + oGrD.GrdCodigoRegistro + "', '" + oGrD.GrpCodigo + 
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

        public Transacciones GruposDetallesAddTrans(GruposDetalles oGrD)
        {
            try
            {
                Transacciones oTrans = new Transacciones();
                oTrans.traQuery =   " DECLARE IDTEMP NUMBER(10,0); " +
                                    " BEGIN " +
                                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('GRD_CODIGO')) into IDTEMP from dual; " +
                                    " insert into Grupos_Detalles " +
                                    "(GRD_CODIGO, GRD_CODIGO_REGISTRO, GRP_CODIGO) " +
                                    "values(IDTEMP,'" + oGrD.GrdCodigoRegistro + "', '" + oGrD.GrpCodigo +
                                    "') RETURNING IDTEMP INTO :id;" +
                                    " END;";

                oTrans.traParametroOutLog = ":id";

                return oTrans;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GruposDetallesUpdate(GruposDetalles oGrD)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Grupos_Detalles " +
                    "SET GRD_CODIGO_REGISTRO='" + oGrD.GrdCodigoRegistro + "', " +
                    "GRP_CODIGO='" + oGrD.GrpCodigo + "' " +
                    "WHERE GRD_CODIGO=" + oGrD.GrdCodigo , cn);
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

        public bool GruposDetallesDelete(long Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Grupos_Detalles " +
                      "WHERE GRD_CODIGO=" + Id, cn);
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

        public bool GruposDetallesTipoDelete(string CodReg, string CodTipo)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string query = " DELETE grupos_detalles " +
                               " WHERE  grd_codigo = (select gd.grd_codigo " +
                                                   " from   grupos_detalles gd, grupos g " +
                                                   " where  g.grp_codigo = gd.grp_codigo " +
                                                   " and    gd.grd_codigo_registro='" + CodReg + "' " +
                                                   " and    g.tgr_codigo ='" + CodTipo + "') ";
                //Console.WriteLine("DELETE "+ query);
                cmd = new OracleCommand(query, cn);

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

        public Transacciones GruposDetallesTipoDeleteTrans(string CodReg, string CodTipo)
        {
            try
            {
                Transacciones oTrans = new Transacciones();
                oTrans.traQuery = " DELETE grupos_detalles " +
                                  " WHERE  grd_codigo = (select gd.grd_codigo " +
                                                   " from   grupos_detalles gd, grupos g " +
                                                   " where  g.grp_codigo = gd.grp_codigo " +
                                                   " and    gd.grd_codigo_registro='" + CodReg + "' " +
                                                   " and    g.tgr_codigo ='" + CodTipo + "') ";
                return oTrans;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GruposDetalles GruposDetallesGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " select * from Grupos_Detalles " +
                                   " WHERE grd_codigo=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                GruposDetalles NewEnt = new GruposDetalles();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarGruposDetalles(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GruposDetalles GruposDetallesGetByCodReg(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " select * " +
                                   " from Grupos_Detalles " +
                                   " where grd_codigo_registro='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                GruposDetalles NewEnt = new GruposDetalles();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarGruposDetalles(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GruposDetalles GruposDetallesGetByTipo(string CodReg,string CodTipo)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " select gd.* " +
                                   " from   grupos_detalles gd, grupos g " +
                                   " where  g.grp_codigo = gd.grp_codigo " +
                                   " and    gd.grd_codigo_registro='" + CodReg + "' " +
                                   " and    g.tgr_codigo ='" + CodTipo + "' ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                GruposDetalles NewEnt = new GruposDetalles();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarGruposDetalles(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GruposDetalles> GruposDetallesGetAll()
        {
            List<GruposDetalles> lstGruposDetalles = new List<GruposDetalles>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Grupos_Detalles ";
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
                        GruposDetalles NewEnt = new GruposDetalles();
                        NewEnt = CargarGruposDetalles(dr);
                        lstGruposDetalles.Add(NewEnt);
                    }
                }
                return lstGruposDetalles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<GruposDetalles> GruposDetallesGetbyGrupo(long Grupo)
        {
            List<GruposDetalles> lstGruposDetalles = new List<GruposDetalles>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Grupos_Detalles where GRP_CODIGO=" + Grupo;
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
                        GruposDetalles NewEnt = new GruposDetalles();
                        NewEnt = CargarGruposDetalles(dr);
                        lstGruposDetalles.Add(NewEnt);
                    }
                }
                return lstGruposDetalles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private GruposDetalles CargarGruposDetalles(DataRow dr)
        {
            try
            {
                GruposDetalles oObjeto = new GruposDetalles();
                oObjeto.GrdCodigo = long.Parse(dr["GRD_CODIGO"].ToString());
                oObjeto.GrdCodigoRegistro = dr["GRD_CODIGO_REGISTRO"].ToString();
                oObjeto.GrpCodigo = long.Parse(dr["GRP_CODIGO"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable GruposDetallesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "GruposDetallesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
