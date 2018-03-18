using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class ConceptosTiposComprobantesImpl
    {
        #region ConceptosTiposComprobantes methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;

        public long ConceptosTiposComprobantesAdd(ConceptosTiposComprobantes oCtc)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                //Clave Secuencia 
                ds = new DataSet();
                cmd = new OracleCommand("insert into Conceptos_Tipos_Comprobantes(CPT_NUMERO, TCO_CODIGO) " +
                                        "values('" + oCtc.cptNumero + "','" + oCtc.tcoCodigo + "')", cn);
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

        public bool ConceptosTiposComprobantesDelete(ConceptosTiposComprobantes oCtc)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("  DELETE Conceptos_Tipos_Comprobantes " +
                                        "  WHERE CPT_NUMERO='" + oCtc.cptNumero +
                                        "' AND TCO_CODIGO='" + oCtc.tcoCodigo + "'" , cn);
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

        public ConceptosTiposComprobantes ConceptosTiposComprobantesGetById(int numero)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Conceptos_Tipos_Comprobantes " +
                                   "where CPT_NUMERO=" + numero;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ConceptosTiposComprobantes NewEnt = new ConceptosTiposComprobantes();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarConceptosTiposComprobantes(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ConceptosTiposComprobantes> ConceptosTiposComprobantesGetAll()
        {
            List<ConceptosTiposComprobantes> lstConceptosTiposComprobantes = new List<ConceptosTiposComprobantes>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Conceptos_Tipos_Comprobantes ";
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
                        ConceptosTiposComprobantes NewEnt = new ConceptosTiposComprobantes();
                        NewEnt = CargarConceptosTiposComprobantes(dr);
                        lstConceptosTiposComprobantes.Add(NewEnt);
                    }
                }
                return lstConceptosTiposComprobantes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        private ConceptosTiposComprobantes CargarConceptosTiposComprobantes(DataRow dr)
        {
            try
            {
                ConceptosTiposComprobantes oObjeto = new ConceptosTiposComprobantes();
                oObjeto.cptNumero = int.Parse(dr["CPT_NUMERO"].ToString());
                oObjeto.tcoCodigo = dr["TCO_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ConceptosTiposComprobantesGetByFilter(long numero)
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT c.cpt_numero cpt_numero, " +
                                   "        t.tco_codigo codigo," +
                                   "        t.tco_descripcion descripcion " +
                                   " FROM   conceptos_tipos_comprobantes c," +
                                   "        tipos_comprobantes t " +
                                   " WHERE  t.tco_codigo = c.tco_codigo " +
                                   " AND    cpt_numero =  '" + numero + "' ";

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

        #endregion
    }
}
