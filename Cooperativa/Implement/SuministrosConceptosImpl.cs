
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class SuministrosConceptosImpl
    {
        #region SuministrosConceptos methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long SuministrosConceptosAdd(SuministrosConceptos oSCo)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia Smc_NUMERO
                ds = new DataSet();
                string query =

                    " DECLARE IDTEMP NUMBER(22,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('SMC_NUMERO')) into IDTEMP from dual; " +
                    " insert into Suministros_Conceptos " +
                    "(SMC_CODIGO, SMC_FECHA_ALTA, SMC_FECHA_BAJA, " +
                    "EST_CODIGO, CPT_NUMERO, SUM_NUMERO) " +
                    "values(IDTEMP,";
                if (oSCo.SmcFechaAlta == null)
                    query += "null, '";
                else
                    query += "'" + oSCo.SmcFechaAlta.Value.ToString("dd/MM/yyyy") + "','";
                if (oSCo.SmcFechaBaja == null)
                    query += "null, '";
                else
                    query += "'" + oSCo.SmcFechaBaja.Value.ToString("dd/MM/yyyy") + "','";
                query += oSCo.EstCodigo + "'," + oSCo.CptNumero + "," + oSCo.SumNumero + ") RETURNING IDTEMP INTO :id;" +
                        " END;";
                //oSCo.SmcFechaBaja == null ? "null, '" : "'" + oSCo.SmcFechaBaja.Value.ToString("dd/MM/yyyy") + "','" +
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

        public bool SuministrosConceptosUpdate(SuministrosConceptos oSCo)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Suministros_Conceptos " +
                    "SET Smc_FECHA_ALTA='" + oSCo.SmcFechaAlta == null ? "null, " : "'" + oSCo.SmcFechaAlta.Value.ToString("dd/MM/yyyy") +
                    "', Smc_FECHA_BAJA='" + oSCo.SmcFechaBaja == null ? "null, " : "'" + oSCo.SmcFechaBaja.Value.ToString("dd/MM/yyyy") +
                    "', EST_CODIGO='" + oSCo.EstCodigo +
                    "', CPT_NUMERO=" + oSCo.CptNumero +
                    ", SUM_NUMERO=" + oSCo.SumNumero +
                    " WHERE SMC_CODIGO=" + oSCo.SmcCodigo.ToString(), cn);
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
        public bool SuministrosConceptosDelete(long Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Suministros_Conceptos " +
                    "WHERE SMC_CODIGO=" + Id.ToString(), cn);
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

        public SuministrosConceptos SuministrosConceptosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Suministros_Conceptos " +
                     "WHERE SMC_CODIGO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                SuministrosConceptos NewEnt = new SuministrosConceptos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarSuministrosConceptos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SuministrosConceptosGetBySuministroDT(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Suministros_Conceptos " +
                     "WHERE SUM_NUMERO=" + Id.ToString();
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

        public List<SuministrosConceptos> SuministrosConceptosGetAll()
        {
            List<SuministrosConceptos> lstSuministrosConceptos = new List<SuministrosConceptos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Suministros_Conceptos ";
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
                        SuministrosConceptos NewEnt = new SuministrosConceptos();
                        NewEnt = CargarSuministrosConceptos(dr);
                        lstSuministrosConceptos.Add(NewEnt);
                    }
                }
                return lstSuministrosConceptos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SuministrosConceptos CargarSuministrosConceptos(DataRow dr)
        {
            try
            {
                SuministrosConceptos oObjeto = new SuministrosConceptos();
                oObjeto.SmcCodigo = long.Parse(dr["SMC_CODIGO"].ToString());
                if (dr["Smc_FECHA_ALTA"].ToString() != "")
                    oObjeto.SmcFechaAlta = DateTime.Parse(dr["Smc_FECHA_ALTA"].ToString());
                if (dr["Smc_FECHA_BAJA"].ToString() != "")
                    oObjeto.SmcFechaBaja = DateTime.Parse(dr["Smc_FECHA_BAJA"].ToString());
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                oObjeto.CptNumero = long.Parse(dr["CPT_NUMERO"].ToString());
                oObjeto.SumNumero = long.Parse(dr["SUM_NUMERO"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public DataTable SuministrosConceptosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "SuministrosConceptosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

