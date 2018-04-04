using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class ConceptosImpl
    {
        #region Conceptos methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        private string sql;

        public long ConceptosAdd(Conceptos oCpt)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia CPT_NUMERO
                ds = new DataSet();
                string query =
                    " DECLARE IDTEMP NUMBER; " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('CPT_NUMERO')) into IDTEMP from dual; " +
                    " insert into Conceptos(  CPT_NUMERO," +
                                            " CPT_CODIGO, " +
                                            " CPT_DESCRIPCION," +
                                            " CPT_DESCRIPCION_CORTA," +
                                            " CPT_CONTROLA_STOCK, " +
                                            " CPT_FRACCIONADO, " +
                                            " CUM_CODIGO, " +
                                            " CPT_CODIGO_BARRA, " + 
                                            " CPT_CODIGO_QR, " +
                                            " CPT_CODIGO_PADRE, " +
                                            " CPT_FRACCIONA_POR, " +
                                            " CPT_MEDIBLE, " +
                                            " CPT_FABRICADO, " +
                                            " CPT_PESO, " +
                                            " CPT_ANCHO, " +
                                            " CPT_LARGO, " +
                                            " CPT_PROFUNDIDAD, " +
                                            " CPT_STOCK_MINIMO," +
                                            " CPT_STOCK_MAXIMO," +
                                            " CPT_STOCK_REPOSICION," +
                                            " TIC_CODIGO, " +
                                            " EST_CODIGO, " +
                                            " CPT_MODIFICABLE_EN_CBTE_IMPORT, " +
                                            " CPT_MODIFICABLE_EN_CBTE_DESCRI, " +
                                            " CPT_CODIGO_RECARGO, " +
                                            " CPT_CODIGO_BONIFICACION, " +
                                            " CPT_CODIGO_ENVASE_REP " +
                                            " ) " +
                                "      values(IDTEMP,'"                                          
                                            + oCpt.cptCodigo + "', '"
                                            + oCpt.cptDescripcion + "', '"
                                            + oCpt.cptDescripcionCorta + "', '"
                                            + oCpt.cptControlaStock + "', '"
                                            + oCpt.cptFraccionado + "', '"                                        
                                            + oCpt.cumCodigo + "', '"
                                            + oCpt.cptCodigoBarra + "', '"
                                            + oCpt.cptCodigoQr + "', '"
                                            + oCpt.cptCodigoPadre + "', '"
                                            + oCpt.cptFraccionadoPor + "', '"
                                            + oCpt.cptMedible + "', '"
                                            + oCpt.cptFabricado + "', '"
                                            + oCpt.cptPeso + "', '"
                                            + oCpt.cptAncho + "', '"
                                            + oCpt.cptLargo + "', '"
                                            + oCpt.cptProfundidad + "', '"
                                            + oCpt.cptStockMinimo + "', '"
                                            + oCpt.cptStockMaximo + "', '"
                                            + oCpt.cptStockReposicion+ "', '"
                                            + oCpt.ticCodigo + "', '"
                                            + oCpt.EstCodigo + "', '"
                                            + oCpt.cptModificableImporte + "', '"
                                            + oCpt.cptModificableDescripcion + "', '"
                                            + oCpt.cptCodigoRecargo + "', '"
                                            + oCpt.cptCodigoBonificacion + "', '"
                                            + oCpt.cptCodigoEnvase +
                                            "') " +
                    " RETURNING IDTEMP INTO :id;" +
                    " END;";
                //Console.WriteLine("query " + query);
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

        public bool ConceptosUpdate(Conceptos oCpt)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                sql = "update Conceptos SET " +
                                "CPT_CODIGO='" + oCpt.cptCodigo + "'," +
                                "CPT_DESCRIPCION='" + oCpt.cptDescripcion + "'," +
                                "CPT_DESCRIPCION_CORTA='" + oCpt.cptDescripcionCorta + "'," +
                                "CPT_CONTROLA_STOCK='" + oCpt.cptControlaStock + "'," +
                                "CPT_FRACCIONADO='" + oCpt.cptFraccionado + "'," +
                                "CUM_CODIGO='" + oCpt.cumCodigo + "'," +
                                "CPT_CODIGO_BARRA='" + oCpt.cptCodigoBarra + "', " +
                                "CPT_CODIGO_QR='" + oCpt.cptCodigoQr + "', " +
                                "CPT_CODIGO_PADRE='" + oCpt.cptCodigoPadre + "',  " +
                                "CPT_FRACCIONA_POR='" + oCpt.cptFraccionadoPor + "', " +
                                "CPT_MEDIBLE='" + oCpt.cptMedible + "'," +
                                "CPT_FABRICADO='" + oCpt.cptFabricado + "'," +
                                "CPT_PESO='" + oCpt.cptPeso + "', " +
                                "CPT_ANCHO='" + oCpt.cptAncho + "'," +
                                "CPT_LARGO='" + oCpt.cptLargo + "', " +
                                "CPT_PROFUNDIDAD='" + oCpt.cptProfundidad + "'," +
                                "CPT_STOCK_MINIMO='" + oCpt.cptStockMinimo + "'," +
                                "CPT_STOCK_MAXIMO='" + oCpt.cptStockMaximo + "'," +
                                "CPT_STOCK_REPOSICION='" + oCpt.cptStockReposicion + "'," +
                                "TIC_CODIGO='" + oCpt.ticCodigo + "'," +
                                "EST_CODIGO='" + oCpt.EstCodigo + "', " +
                                "CPT_MODIFICABLE_EN_CBTE_IMPORT='" + oCpt.cptModificableImporte + "', " +
                                "CPT_MODIFICABLE_EN_CBTE_DESCRI='" + oCpt.cptModificableDescripcion + "', " +
                                "CPT_CODIGO_RECARGO='" + oCpt.cptCodigoRecargo + "', " +
                                "CPT_CODIGO_BONIFICACION='" + oCpt.cptCodigoBonificacion + "', " +
                                "CPT_CODIGO_ENVASE_REP='" + oCpt.cptCodigoEnvase + "' " +
                        "WHERE CPT_NUMERO='" + oCpt.cptNumero + "' ";
                //Console.WriteLine("sql");
                //Console.WriteLine("sql  " + sql);
                //Console.WriteLine("sql");
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

        public bool ConceptosDelete(int Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Conceptos " +
                                        "WHERE CPT_NUMERO=" + Id.ToString(), cn);
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

        public Conceptos ConceptosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM Conceptos " +
                                   "WHERE    CPT_NUMERO=" + Id.ToString();
                //Console.WriteLine("sql");
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Conceptos NewEnt = new Conceptos();
                //Console.WriteLine("sql-"+ sqlSelect);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarConceptos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Conceptos> ConceptosGetAll()
        {
            List<Conceptos> lstConceptos = new List<Conceptos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Conceptos ";
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
                        Conceptos NewEnt = new Conceptos();
                        NewEnt = CargarConceptos(dr);
                        lstConceptos.Add(NewEnt);
                    }
                }
                return lstConceptos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Conceptos CargarConceptos(DataRow dr)
        {
            try
            {
                Conceptos oCpt = new Conceptos();
                oCpt.cptNumero = long.Parse(dr["CPT_NUMERO"].ToString());
                oCpt.cptCodigo = dr["CPT_CODIGO"].ToString();
                oCpt.cptDescripcion = dr["CPT_DESCRIPCION"].ToString();
                oCpt.cptDescripcionCorta = dr["CPT_DESCRIPCION_CORTA"].ToString();
                oCpt.cptControlaStock = dr["CPT_CONTROLA_STOCK"].ToString();
                oCpt.cptFraccionado = dr["CPT_FRACCIONADO"].ToString();
                if (dr["CUM_CODIGO"].ToString() != "")
                    oCpt.cumCodigo = int.Parse(dr["CUM_CODIGO"].ToString());
                if (dr["CPT_CODIGO_BARRA"].ToString() != "")
                    oCpt.cptCodigoBarra = long.Parse(dr["CPT_CODIGO_BARRA"].ToString());
                if (dr["CPT_CODIGO_QR"].ToString() != "")
                    oCpt.cptCodigoQr = dr["CPT_CODIGO_QR"].ToString();
                if (dr["CPT_CODIGO_PADRE"].ToString() != "")
                    oCpt.cptCodigoPadre = long.Parse(dr["CPT_CODIGO_PADRE"].ToString());
                if (dr["CPT_FRACCIONA_POR"].ToString() != "")
                    oCpt.cptFraccionadoPor = int.Parse(dr["CPT_FRACCIONA_POR"].ToString());                
                if (dr["CPT_MEDIBLE"].ToString() != "")
                    oCpt.cptMedible = dr["CPT_MEDIBLE"].ToString();
                if (dr["CPT_FABRICADO"].ToString() != "")
                    oCpt.cptFabricado = dr["CPT_FABRICADO"].ToString();
                if (dr["CPT_PESO"].ToString() != "")
                    oCpt.cptPeso = decimal.Parse(dr["CPT_PESO"].ToString());
                if (dr["CPT_ANCHO"].ToString() != "")
                    oCpt.cptAncho = decimal.Parse(dr["CPT_ANCHO"].ToString());
                if (dr["CPT_LARGO"].ToString() != "")
                    oCpt.cptLargo = decimal.Parse(dr["CPT_LARGO"].ToString());
                if (dr["CPT_PROFUNDIDAD"].ToString() != "")
                    oCpt.cptProfundidad = decimal.Parse(dr["CPT_PROFUNDIDAD"].ToString());
                if (dr["CPT_STOCK_MINIMO"].ToString() != "")
                    oCpt.cptStockMinimo = decimal.Parse(dr["CPT_STOCK_MINIMO"].ToString());
                if (dr["CPT_STOCK_MAXIMO"].ToString() != "")
                    oCpt.cptStockMaximo = decimal.Parse(dr["CPT_STOCK_MAXIMO"].ToString());
                if (dr["CPT_STOCK_REPOSICION"].ToString() != "")
                    oCpt.cptStockReposicion = decimal.Parse(dr["CPT_STOCK_REPOSICION"].ToString());
                if (dr["TIC_CODIGO"].ToString() != "")
                    oCpt.ticCodigo = dr["TIC_CODIGO"].ToString();
                if (dr["EST_CODIGO"].ToString() != "")
                    oCpt.EstCodigo = dr["EST_CODIGO"].ToString();
                if (dr["CPT_MODIFICABLE_EN_CBTE_IMPORT"].ToString() != "")
                    oCpt.cptModificableImporte = dr["CPT_MODIFICABLE_EN_CBTE_IMPORT"].ToString();
                if (dr["CPT_MODIFICABLE_EN_CBTE_DESCRI"].ToString() != "")
                    oCpt.cptModificableDescripcion = dr["CPT_MODIFICABLE_EN_CBTE_DESCRI"].ToString();
                if (dr["CPT_CODIGO_RECARGO"].ToString() != "")
                    oCpt.cptCodigoRecargo = long.Parse(dr["CPT_CODIGO_RECARGO"].ToString());
                if (dr["CPT_CODIGO_BONIFICACION"].ToString() != "")
                    oCpt.cptCodigoBonificacion = long.Parse(dr["CPT_CODIGO_BONIFICACION"].ToString());
                if (dr["CPT_CODIGO_ENVASE_REP"].ToString() != "")
                    oCpt.cptCodigoEnvase = long.Parse(dr["CPT_CODIGO_ENVASE_REP"].ToString());

                return oCpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       
        
        #endregion
    }
}
