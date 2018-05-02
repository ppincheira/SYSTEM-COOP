using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
    public class ConceptosImpuestosItemsImpl
    {
        #region ConceptosImpuestosItems methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        private string sql;

        public int ConceptosImpuestosItemsAdd(ConceptosImpuestosItems oConceptosImpuestosItems)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                sql = "insert into Conceptos_Impuestos_Items(CII_NUMERO, " +
                                                          "CPT_NUMERO, " +
                                                          "GII_NUMERO, " +                                                          
                                                          "CII_VIGENCIA_DESDE)" +
                                "values(pkg_secuencias.fnc_prox_secuencia('CII_NUMERO'), '"
                                            + oConceptosImpuestosItems.cptNumero + "', '"
                                            + oConceptosImpuestosItems.giiNumero + "', "                                            
                                            + "TO_DATE('" + oConceptosImpuestosItems.ciiVigenciaDesde + "', 'DD/MM/YYYY HH24:MI:SS'))";
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

        public bool ConceptosImpuestosItemsUpdate(ConceptosImpuestosItems oConceptosImpuestosItems)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                sql = "update Conceptos_Impuestos_Items SET " +
                            "CPT_NUMERO='" + oConceptosImpuestosItems.cptNumero + "'," +
                            "GII_NUMERO='" + oConceptosImpuestosItems.giiNumero + "'," +                            
                            "CII_VIGENCIA_DESDE=TO_DATE('" + oConceptosImpuestosItems.ciiVigenciaDesde + "', 'DD/MM/YYYY HH24:MI:SS') " +                            
                        "WHERE CII_NUMERO='" + oConceptosImpuestosItems.ciiNumero + "' ";
                cmd = new OracleCommand(sql, cn);
                Console.WriteLine("sql");
                Console.WriteLine("sql  " + sql);
                Console.WriteLine("sql");
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Transacciones ConceptosImpuestosItemsAddTrans(ConceptosImpuestosItems oConceptosImpuestosItems)
        {
            try
            {
                Transacciones oTrans = new Transacciones();
                oTrans.traQuery = "insert into Conceptos_Impuestos_Items(CII_NUMERO, " +
                                                                        "CPT_NUMERO, " +
                                                                        "GII_NUMERO, " +
                                                                        "CII_VIGENCIA_DESDE)" +
                                            "values(pkg_secuencias.fnc_prox_secuencia('CII_NUMERO'), '"
                                                        + oConceptosImpuestosItems.cptNumero + "', '"
                                                        + oConceptosImpuestosItems.giiNumero + "', "
                                                        + "TO_DATE('" + oConceptosImpuestosItems.ciiVigenciaDesde + "', 'DD/MM/YYYY HH24:MI:SS'))";
                Console.WriteLine("sql");
                Console.WriteLine("sql  " + sql);
                
                return oTrans;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Transacciones ConceptosImpuestosItemsUpdateTrans(ConceptosImpuestosItems oConceptosImpuestosItems)
        {
            try
            {
                Transacciones oTrans = new Transacciones();
                oTrans.traQuery =   "update Conceptos_Impuestos_Items SET " +
                                            "CPT_NUMERO='" + oConceptosImpuestosItems.cptNumero + "'," +
                                            "GII_NUMERO='" + oConceptosImpuestosItems.giiNumero + "'," +
                                            "CII_VIGENCIA_DESDE=TO_DATE('" + oConceptosImpuestosItems.ciiVigenciaDesde + "', 'DD/MM/YYYY HH24:MI:SS') " +
                                "WHERE CII_NUMERO='" + oConceptosImpuestosItems.ciiNumero + "' ";
                
                return oTrans;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ConceptosImpuestosItemsDelete(String Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand(" DELETE Conceptos_Impuestos_Items " +
                                        " WHERE CII_NUMERO='" + Id + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public ConceptosImpuestosItems ConceptosImpuestosItemsGetById(int Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " select * from Conceptos_Impuestos_Items " +
                                   " where CII_NUMERO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ConceptosImpuestosItems NewEnt = new ConceptosImpuestosItems();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarConceptosImpuestosItems(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ConceptosImpuestosItems ConceptosImpuestosItemsGetByCptNumero(long CptNumero)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " select * from Conceptos_Impuestos_Items " +
                                   " where    CPT_NUMERO='" + CptNumero + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ConceptosImpuestosItems NewEnt = new ConceptosImpuestosItems();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarConceptosImpuestosItems(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ConceptosImpuestosItems> ConceptosImpuestosItemsGetAll()
        {
            List<ConceptosImpuestosItems> lstConceptosImpuestosItems = new List<ConceptosImpuestosItems>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Conceptos_Impuestos_Items ";
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
                        ConceptosImpuestosItems NewEnt = new ConceptosImpuestosItems();
                        NewEnt = CargarConceptosImpuestosItems(dr);
                        lstConceptosImpuestosItems.Add(NewEnt);
                    }
                }
                return lstConceptosImpuestosItems;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ConceptosImpuestosItems CargarConceptosImpuestosItems(DataRow dr)
        {
            try
            {
                ConceptosImpuestosItems oObjeto = new ConceptosImpuestosItems();
                oObjeto.ciiNumero = long.Parse(dr["CII_NUMERO"].ToString());
                oObjeto.cptNumero = long.Parse(dr["CPT_NUMERO"].ToString());
                oObjeto.giiNumero = int.Parse(dr["GII_NUMERO"].ToString());                
                oObjeto.ciiVigenciaDesde = DateTime.Parse(dr["CII_VIGENCIA_DESDE"].ToString());                      

                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
