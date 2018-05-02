using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class CdtConceptosCategoriasImpl
    {
        #region CdtConceptosCategorias methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        private string sql;

        public long CdtConceptosCategoriasAdd(CdtConceptosCategorias oCCa)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia CCA_CODIGO
                ds = new DataSet();
                string query =
                    " DECLARE IDTEMP NUMBER; " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('CCA_CODIGO')) into IDTEMP from dual; " +
                    " insert into Cdt_Conceptos_Categorias(  CCA_CODIGO, SCA_NUMERO," +
                                    " CPT_NUMERO, CCA_IMPORTE, CCA_TASA," +
                                    " CCA_SCRIPT_IMPORTE, CCA_SCRIPT_TASA, " +
                                    " CCA_ORDEN_CALCULO, CCA_ORDEN_IMPRESION, " +
                                    " CCA_TIPO_TARIFA, CCA_TIPO_CALCULO, " +
                                    " CCA_VALOR_LIMITE, MON_CODIGO ) " +
                                "values (IDTEMP, " + oCCa.ScaNumero + ", " 
                                    + oCCa.CptNumero + ", " + oCCa.CcaImporte + ", " + oCCa.CcaTasa + ", '" 
                                    + oCCa.CcaScriptImporte + "', '" + oCCa.CcaScriptTasa + "', "
                                    + oCCa.CcaOrdenCalculo + "', " + oCCa.CcaOrdenImpresion + ", '"
                                    + oCCa.CcaTipoTarifa + "', '" + oCCa.CcaTipoCalculo + "', "
                                    + oCCa.CcaValorLimite + ", " + oCCa.MonCodigo + "') " +
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

        public bool CdtConceptosCategoriasUpdate(CdtConceptosCategorias oCCa)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                sql = "update Cdt_Conceptos_Categorias SET " +
                                "SCA_NUMERO=" + oCCa.ScaNumero + "," +
                                "CPT_NUMERO=" + oCCa.CptNumero + "," +
                                "CCA_IMPORTE=" + oCCa.CcaImporte + "," +
                                "CCA_TASA=" + oCCa.CcaTasa + "," +
                                "CCA_SCRIPT_IMPORTE='" + oCCa.CcaScriptImporte + "'," +
                                "CCA_SCRIPT_TASA='" + oCCa.CcaScriptTasa + "', " +
                                "CCA_ORDEN_CALCULO=" + oCCa.CcaOrdenCalculo + ", " +
                                "CCA_ORDEN_IMPRESION=" + oCCa.CcaOrdenImpresion + ",  " +
                                "CCA_TIPO_TARIFA='" + oCCa.CcaTipoTarifa + "', " +
                                "CCA_TIPO_CALCULO='" + oCCa.CcaTipoCalculo + "'," +
                                "CCA_VALOR_LIMITE=" + oCCa.CcaValorLimite + "," +
                                "MON_CODIGO=" + oCCa.MonCodigo  +
                        "WHERE CCA_CODIGO=" + oCCa.CcaCodigo ;
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

        public bool CdtConceptosCategoriasDelete(long Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Cdt_Conceptos_Categorias " +
                                        "WHERE CCA_CODIGO=" + Id.ToString(), cn);
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

        public CdtConceptosCategorias CdtConceptosCategoriasGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM Cdt_Conceptos_Categorias " +
                                   "WHERE    CCA_CODIGO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                CdtConceptosCategorias NewEnt = new CdtConceptosCategorias();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarCdtConceptosCategorias(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CdtConceptosCategorias> CdtConceptosCategoriasGetAll()
        {
            List<CdtConceptosCategorias> lstCdtConceptosCategorias = new List<CdtConceptosCategorias>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Cdt_Conceptos_Categorias order by CCA_CODIGO";
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
                        CdtConceptosCategorias NewEnt = new CdtConceptosCategorias();
                        NewEnt = CargarCdtConceptosCategorias(dr);
                        lstCdtConceptosCategorias.Add(NewEnt);
                    }
                }
                return lstCdtConceptosCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private CdtConceptosCategorias CargarCdtConceptosCategorias(DataRow dr)
        {
            try
            {
                CdtConceptosCategorias oCCa = new CdtConceptosCategorias();
                oCCa.CcaCodigo = long.Parse(dr["CCA_NUMERO"].ToString());
                oCCa.ScaNumero = long.Parse(dr["SCA_NUMERO"].ToString());
                if (dr["CPT_NUMERO"].ToString() != "")
                    oCCa.CptNumero = long.Parse(dr["CPT_NUMERO"].ToString());
                if (dr["CCA_IMPORTE"].ToString() != "")
                    oCCa.CcaImporte = float.Parse(dr["CCA_IMPORTE"].ToString());
                if (dr["CCA_TASA"].ToString() != "")
                    oCCa.CcaTasa = float.Parse(dr["CCA_TASA"].ToString());
                oCCa.CcaScriptImporte = dr["CCA_SCRIPT_IMPORTE"].ToString();
                oCCa.CcaScriptTasa = dr["CCA_SCRIPT_TASA"].ToString();
                if (dr["CCA_ORDEN_CALCULO"].ToString() != "")
                    oCCa.CcaOrdenCalculo = short.Parse(dr["CCA_ORDEN_CALCULO"].ToString());
                if (dr["CCA_ORDEN_IMPRESION"].ToString() != "")
                    oCCa.CcaOrdenImpresion = short.Parse(dr["CCA_ORDEN_IMPRESION"].ToString());
                oCCa.CcaTipoTarifa = dr["CCA_TIPO_TARIFA"].ToString();
                oCCa.CcaTipoCalculo = dr["CCA_TIPO_CALCULO"].ToString();
                if (dr["CCA_VALOR_LIMITE"].ToString() != "")
                    oCCa.CcaValorLimite = double.Parse(dr["CCA_VALOR_LIMITE"].ToString());                
                if (dr["MON_CODIGO"].ToString() != "")
                    oCCa.MonCodigo = short.Parse(dr["MON_CODIGO"].ToString());
                return oCCa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       
        
        #endregion
    }
}
