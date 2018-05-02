
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class GruposImpuestosItemsImpl
    {
        #region GruposImpuestosItems methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        private string sql;

        public long GruposImpuestosItemsAdd(GruposImpuestosItems oGruposImpuestosItems)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia 
                ds = new DataSet();
                sql = "insert into Grupos_Impuestos_Items( GII_NUMERO," +
                                                        " TIV_CODIGO, " +
                                                        " GII_PORCENTAJE," +
                                                        " GII_VIGENCIA_DESDE," +
                                                        " GII_VIGENCIA_HASTA, " +
                                                        " GII_IMPORTE_MINIMO, " +
                                                        " GII_IMPORTE_FIJO, " +
                                                        " GII_IMPORTE_BASE_MINIMO, " +                                            
                                                        " PAI_CODIGO, " +
                                                        " PRV_CODIGO, " +
                                                        " LOC_NUMERO, " +
                                                        " CPT_NUMERO, " +
                                                        " GCI_CODIGO) " +
                                            "values(pkg_secuencias.fnc_prox_secuencia('GII_NUMERO'),'"
                                                        + oGruposImpuestosItems.tivCodigo + "', '"
                                                        + oGruposImpuestosItems.giiPorcentaje + "', "
                                                        + "TO_DATE('" + oGruposImpuestosItems.giiVigenciaDesde + "', 'DD/MM/YYYY HH24:MI:SS'), "
                                                        + "TO_DATE('" + oGruposImpuestosItems.giiVigenciaHasta + "', 'DD/MM/YYYY HH24:MI:SS'), '"
                                                        + oGruposImpuestosItems.giiImporteMinimo + "', '"
                                                        + oGruposImpuestosItems.giiImporteFijo + "', '"
                                                        + oGruposImpuestosItems.giiImporteBaseMinimo + "', '"
                                                        + oGruposImpuestosItems.paiCodigo + "', '"                                            
                                                        + oGruposImpuestosItems.prvCodigo + "', '"                                            
                                                        + oGruposImpuestosItems.locNumero + "', '"
                                                        + oGruposImpuestosItems.cptNumero + "', '"
                                                        + oGruposImpuestosItems.gciCodigo +"')";
                Console.WriteLine("sql");
                Console.WriteLine("sql  " + sql);
                Console.WriteLine("sql");
                cmd = new OracleCommand(sql, cn);
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

        public bool GruposImpuestosItemsUpdate(GruposImpuestosItems oGruposImpuestosItems)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                sql = "update Grupos_Impuestos_Items SET " +
                                "TIV_CODIGO='" + oGruposImpuestosItems.tivCodigo + "'," +
                                "GII_PORCENTAJE='" + oGruposImpuestosItems.giiPorcentaje + "'," +
                                "GII_VIGENCIA_DESDE=TO_DATE('" + oGruposImpuestosItems.giiVigenciaDesde + "', 'DD/MM/YYYY HH24:MI:SS'), " +
                                "GII_VIGENCIA_HASTA=TO_DATE('" + oGruposImpuestosItems.giiVigenciaHasta + "', 'DD/MM/YYYY HH24:MI:SS'), " +
                                "GII_IMPORTE_MINIMO='" + oGruposImpuestosItems.giiImporteMinimo + "'," +
                                "GII_IMPORTE_FIJO='" + oGruposImpuestosItems.giiImporteFijo + "'," +
                                "GII_IMPORTE_BASE_MINIMO='" + oGruposImpuestosItems.giiImporteBaseMinimo + "'," +
                                "PAI_CODIGO='" + oGruposImpuestosItems.paiCodigo + "', " +
                                "PRV_CODIGO='" + oGruposImpuestosItems.prvCodigo + "'," +
                                "LOC_NUMERO='" + oGruposImpuestosItems.locNumero + "'," +
                                "CPT_NUMERO='" + oGruposImpuestosItems.cptNumero + "'," +
                                "GCI_CODIGO='" + oGruposImpuestosItems.gciCodigo + "' " +
                          "WHERE GII_NUMERO='" + oGruposImpuestosItems.giiNumero + "' ";
                Console.WriteLine("sql");
                Console.WriteLine("sql  " + sql);
                Console.WriteLine("sql");
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

        public bool GruposImpuestosItemsDelete(int Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Grupos_Impuestos_Items " +
                                        "WHERE GII_NUMERO=" + Id.ToString(), cn);
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

        public GruposImpuestosItems GruposImpuestosItemsGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM Grupos_Impuestos_Items " +
                                   "WHERE gii_numero=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                GruposImpuestosItems NewEnt = new GruposImpuestosItems();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarGruposImpuestosItems(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GruposImpuestosItems> GruposImpuestosItemsGetAll()
        {
            List<GruposImpuestosItems> lstGruposImpuestosItems = new List<GruposImpuestosItems>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Grupos_Impuestos_Items ";
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
                        GruposImpuestosItems NewEnt = new GruposImpuestosItems();
                        NewEnt = CargarGruposImpuestosItems(dr);
                        lstGruposImpuestosItems.Add(NewEnt);
                    }
                }
                return lstGruposImpuestosItems;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private GruposImpuestosItems CargarGruposImpuestosItems(DataRow dr)
        {
            try
            {
                GruposImpuestosItems oObjeto = new GruposImpuestosItems();
                oObjeto.giiNumero = int.Parse(dr["GII_NUMERO"].ToString());
                oObjeto.tivCodigo = dr["TIV_CODIGO"].ToString();
                if (dr["GII_PORCENTAJE"].ToString() != "")
                    oObjeto.giiPorcentaje = decimal.Parse(dr["GII_PORCENTAJE"].ToString());                
                oObjeto.giiVigenciaDesde = DateTime.Parse(dr["GII_VIGENCIA_DESDE"].ToString());
                if (dr["GII_VIGENCIA_HASTA"].ToString() != "")
                    oObjeto.giiVigenciaHasta = DateTime.Parse(dr["GII_VIGENCIA_HASTA"].ToString());
                if (dr["GII_IMPORTE_MINIMO"].ToString() != "")
                    oObjeto.giiImporteMinimo = decimal.Parse(dr["GII_IMPORTE_MINIMO"].ToString());
                if (dr["GII_IMPORTE_FIJO"].ToString() != "")
                    oObjeto.giiImporteFijo = decimal.Parse(dr["GII_IMPORTE_FIJO"].ToString());
                if (dr["GII_IMPORTE_BASE_MINIMO"].ToString() != "")
                    oObjeto.giiImporteBaseMinimo = decimal.Parse(dr["GII_IMPORTE_BASE_MINIMO"].ToString());                
                if (dr["PAI_CODIGO"].ToString() != "")
                    oObjeto.paiCodigo = dr["PAI_CODIGO"].ToString();
                if (dr["PRV_CODIGO"].ToString() != "")
                    oObjeto.prvCodigo = dr["PRV_CODIGO"].ToString();
                if (dr["LOC_NUMERO"].ToString() != "")
                    oObjeto.locNumero = int.Parse(dr["LOC_NUMERO"].ToString());
                oObjeto.cptNumero = long.Parse(dr["CPT_NUMERO"].ToString());
                oObjeto.gciCodigo = dr["GCI_CODIGO"].ToString();

                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GruposImpuestosItemsGetByFilter()
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT gii_numero, " +
                                   "        tiv_codigo||' '||gii_vigencia_desde descripcion " +
                                   " FROM   Grupos_Impuestos_Items  " +
                                   " ORDER BY gii_numero ";

                Console.WriteLine("sql");
                Console.WriteLine("--" + sqlSelect);
                Console.WriteLine("sql");

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);

                DataTable dt;
                return dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        #endregion
    }

}
