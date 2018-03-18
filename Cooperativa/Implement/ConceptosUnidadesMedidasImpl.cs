using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class ConceptosUnidadesMedidasImpl
    {
        #region ConceptosUnidadesMedidas methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;

        public long ConceptosUnidadesMedidasAdd(ConceptosUnidadesMedidas oCum)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia CUM_CODIGO
                ds = new DataSet();
                string query =

                    " DECLARE IDTEMP NUMBER(10,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('CUM_CODIGO')) into IDTEMP from dual; " +
                    " insert into Conceptos_Unidades_Medidas " +
                    "(CUM_CODIGO, CUM_DESCRIPCION) " +
                    "values(IDTEMP,'" + oCum.cumDescripcion + "') RETURNING IDTEMP INTO :id;" +
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

        public bool ConceptosUnidadesMedidasUpdate(ConceptosUnidadesMedidas oCum)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Conceptos_Unidades_Medidas " +
                    "SET CUM_DESCRIPCION='" + oCum.cumDescripcion + "' " +                   
                    "WHERE CUM_CODIGO=" + oCum.cumCodigo, cn);
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

        public bool ConceptosUnidadesMedidasDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Conceptos_Unidades_Medidas " +
                      "WHERE CUM_CODIGO=" + Id, cn);
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

        public ConceptosUnidadesMedidas ConceptosUnidadesMedidasGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Conceptos_Unidades_Medidas " +
                    "WHERE CUM_CODIGO=" + Id;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                ConceptosUnidadesMedidas NewEnt = new ConceptosUnidadesMedidas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarConceptosUnidadesMedidas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ConceptosUnidadesMedidas> ConceptosUnidadesMedidasGetAll()
        {
            List<ConceptosUnidadesMedidas> lstConceptosUnidadesMedidas = new List<ConceptosUnidadesMedidas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Conceptos_Unidades_Medidas ";
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
                        ConceptosUnidadesMedidas NewEnt = new ConceptosUnidadesMedidas();
                        NewEnt = CargarConceptosUnidadesMedidas(dr);
                        lstConceptosUnidadesMedidas.Add(NewEnt);
                    }
                }
                return lstConceptosUnidadesMedidas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ConceptosUnidadesMedidas CargarConceptosUnidadesMedidas(DataRow dr)
        {
            try
            {
                ConceptosUnidadesMedidas oObjeto = new ConceptosUnidadesMedidas();
                oObjeto.cumCodigo = int.Parse(dr["CUM_CODIGO"].ToString());
                oObjeto.cumDescripcion = dr["CUM_DESCRIPCION"].ToString();                
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ConceptosUnidadesMedidasGetByFilter()
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT cum_codigo,cum_descripcion " +
                                   " FROM   Conceptos_Unidades_Medidas  " ;

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
