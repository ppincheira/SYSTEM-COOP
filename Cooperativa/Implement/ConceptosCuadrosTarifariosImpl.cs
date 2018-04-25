using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class ConceptosCuadrosTarifariosImpl
    {
        #region ConceptosCuadrosTarifarios methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        private string sql;

        public long ConceptosCuadrosTarifariosAdd(ConceptosCuadrosTarifarios oCCT)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia CCT_CODIGO
                ds = new DataSet();
                string query =
                    " DECLARE IDTEMP NUMBER; " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('CCT_CODIGO')) into IDTEMP from dual; " +
                    " insert into Conceptos_Cuadros_Tarifarios(  CCT_CODIGO, CPT_NUMERO," +
                                    " CDT_CODIGO, CDT_TIPO_TARIFA, CDT_TIPO_CALCULO, " +
                                    " CDT_IMPORTE, CDT_TASA," +
                                    " CDT_SCRIPT_IMPORTE, CDT_SCRIPT_TASA, " +
                                    " CDT_ORDEN_CALCULO, CDT_ORDEN_IMPRESION, " +
                                    " CDT_VALOR_LIMITE, MON_CODIGO ) " +
                                "values (IDTEMP, " + oCCT.CptNumero + ", " 
                                    + oCCT.CdtCodigo + ", '" + oCCT.CdtTipoTarifa + "', '" + oCCT.CdtTipoCalculo + "', " 
                                    + oCCT.CdtImporte + ", " + oCCT.CdtTasa + ", '" 
                                    + oCCT.CdtScriptImporte + "', '" + oCCT.CdtScriptTasa + "', "
                                    + oCCT.CdtOrdenCalculo + ", " + oCCT.CdtOrdenImpresion + ", "
                                    + oCCT.CdtValorLimite + ", " + oCCT.MonCodigo + "') " +
                    " RETURNING IDTEMP INTO :id;" +
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

        public bool ConceptosCuadrosTarifariosUpdate(ConceptosCuadrosTarifarios oCCT)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                sql = "update Conceptos_Cuadros_Tarifarios SET " +
                                "CPT_NUMERO=" + oCCT.CptNumero + "," +
                                "CDT_CODIGO=" + oCCT.CdtCodigo + "," +
                                "CDT_TIPO_TARIFA='" + oCCT.CdtTipoTarifa + "', " +
                                "CDT_TIPO_CALCULO='" + oCCT.CdtTipoCalculo + "'," +
                                "CDT_IMPORTE=" + oCCT.CdtImporte + "," +
                                "CDT_TASA=" + oCCT.CdtTasa + "," +
                                "CDT_SCRIPT_IMPORTE='" + oCCT.CdtScriptImporte + "'," +
                                "CDT_SCRIPT_TASA='" + oCCT.CdtScriptTasa + "', " +
                                "CDT_ORDEN_CALCULO=" + oCCT.CdtOrdenCalculo + ", " +
                                "CDT_ORDEN_IMPRESION=" + oCCT.CdtOrdenImpresion + ",  " +
                                "CDT_VALOR_LIMITE=" + oCCT.CdtValorLimite + "," +
                                "MON_CODIGO=" + oCCT.MonCodigo  +
                        "WHERE CCT_CODIGO=" + oCCT.CdtCodigo ;
                cmd = new OracleCommand(sql, cn);
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

        public bool ConceptosCuadrosTarifariosDelete(long Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Conceptos_Cuadros_Tarifarios " +
                                        "WHERE CCT_CODIGO=" + Id.ToString(), cn);
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

        public ConceptosCuadrosTarifarios ConceptosCuadrosTarifariosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM Conceptos_Cuadros_Tarifarios " +
                                   "WHERE    CCT_CODIGO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ConceptosCuadrosTarifarios NewEnt = new ConceptosCuadrosTarifarios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarConceptosCuadrosTarifarios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ConceptosCuadrosTarifarios> ConceptosCuadrosTarifariosGetAll()
        {
            List<ConceptosCuadrosTarifarios> lstConceptosCuadrosTarifarios = new List<ConceptosCuadrosTarifarios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Conceptos_Cuadros_Tarifarios order by CCT_CODIGO";
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
                        ConceptosCuadrosTarifarios NewEnt = new ConceptosCuadrosTarifarios();
                        NewEnt = CargarConceptosCuadrosTarifarios(dr);
                        lstConceptosCuadrosTarifarios.Add(NewEnt);
                    }
                }
                return lstConceptosCuadrosTarifarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ConceptosCuadrosTarifarios CargarConceptosCuadrosTarifarios(DataRow dr)
        {
            try
            {
                ConceptosCuadrosTarifarios oCCT = new ConceptosCuadrosTarifarios();
                oCCT.CctCodigo = long.Parse(dr["CCT_CODIGO"].ToString());
                if (dr["CPT_NUMERO"].ToString() != "")
                    oCCT.CptNumero = long.Parse(dr["CPT_NUMERO"].ToString());
                if (dr["CDT_CODIGO"].ToString() != "")
                    oCCT.CptNumero = long.Parse(dr["CDT_CODIGO"].ToString());
                if (dr["CDT_IMPORTE"].ToString() != "")
                    oCCT.CdtImporte = float.Parse(dr["CDT_IMPORTE"].ToString());
                if (dr["CDT_TASA"].ToString() != "")
                    oCCT.CdtTasa = float.Parse(dr["CDT_TASA"].ToString());
                oCCT.CdtScriptImporte = dr["CDT_SCRIPT_IMPORTE"].ToString();
                oCCT.CdtScriptTasa = dr["CDT_SCRIPT_TASA"].ToString();
                if (dr["CDT_ORDEN_CALCULO"].ToString() != "")
                    oCCT.CdtOrdenCalculo = short.Parse(dr["CDT_ORDEN_CALCULO"].ToString());
                if (dr["CDT_ORDEN_IMPRESION"].ToString() != "")
                    oCCT.CdtOrdenImpresion = short.Parse(dr["CDT_ORDEN_IMPRESION"].ToString());
                oCCT.CdtTipoTarifa = dr["CDT_TIPO_TARIFA"].ToString();
                oCCT.CdtTipoCalculo = dr["CDT_TIPO_CALCULO"].ToString();
                if (dr["CDT_VALOR_LIMITE"].ToString() != "")
                    oCCT.CdtValorLimite = double.Parse(dr["CDT_VALOR_LIMITE"].ToString());                
                if (dr["MON_CODIGO"].ToString() != "")
                    oCCT.MonCodigo = short.Parse(dr["MON_CODIGO"].ToString());
                return oCCT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       
        
        #endregion
    }
}
