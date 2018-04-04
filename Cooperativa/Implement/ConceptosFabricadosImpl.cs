using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class ConceptosFabricadosImpl
    {
        #region ConceptosFabricados methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;

        public DataTable ConceptosFabricadosGetByFilter(long CodigoFabricado)
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT f.cfb_codigo pk, " +//2
                                   "        f.cpt_codigo_parte fk, " +//3
                                   "        c.cpt_codigo codigo, " +  //4                                 
                                   "        c.cpt_descripcion descripcion, " +//5
                                   "        f.cfb_cantidad_parte cantidad " +//6
                                   " FROM   conceptos c," +
                                   "        conceptos_fabricados f " +
                                   " WHERE  c.cpt_numero = f.cpt_codigo_parte " +
                                   " AND    f.cpt_codigo_fabricado =  '" + CodigoFabricado + "' " +
                                   " UNION ALL " +
                                   " SELECT NULL pk, " +
                                   "        NULL fk, " +
                                   "        NULL codigo, " +
                                   "        NULL descripcion, " +
                                   "        NULL cantidad " +
                                   " FROM    dual ";

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
        public long ConceptosFabricadosAdd(ConceptosFabricados oCfb)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                //Clave Secuencia 
                ds = new DataSet();
                cmd = new OracleCommand("insert into Conceptos_Fabricados(CFB_CODIGO, " +
                                                                         "CPT_CODIGO_FABRICADO, " +
                                                                         "CPT_CODIGO_PARTE, " +
                                                                         "CFB_CANTIDAD_PARTE) " +
                                        "values(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('CFB_CODIGO'), " +
                                               " '" + oCfb.cptCodigoFabricado + "', " +
                                               " '" + oCfb.cptCodigoParte + "', " +
                                               " '" + oCfb.cfbCantidadParte + "' " +
                                               ")", cn);
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

        public bool ConceptosFabricadosDelete(ConceptosFabricados oCfb)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("  DELETE Conceptos_Fabricados " +
                                        "  WHERE  CFB_CODIGO='" + oCfb.cfbCodigo + "'", cn);
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

        public bool ConceptosFabricadosDeleteAll(ConceptosFabricados oCfb)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("  DELETE Conceptos_Fabricados " +
                                        "  WHERE  CPT_CODIGO_FABRICADO='" + oCfb.cptCodigoFabricado + "'", cn);
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

        public bool ConceptosFabricadosUpdate(ConceptosFabricados oConceptosFabricados)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string sql = "update Conceptos_Fabricados SET " +
                                    " CPT_CODIGO_FABRICADO='" + oConceptosFabricados.cptCodigoFabricado + "'," +
                                    " CPT_CODIGO_PARTE='" + oConceptosFabricados.cptCodigoParte + "'," +
                                    " CFB_CANTIDAD_PARTE='" + oConceptosFabricados.cfbCantidadParte + "' " +                                
                            "WHERE CFB_CODIGO='" + oConceptosFabricados.cfbCodigo + "' ";
                cmd = new OracleCommand(sql, cn);
                //Console.WriteLine("sql");
                //Console.WriteLine("sql  " + sql);
                //Console.WriteLine("sql");
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


        #endregion
    }
}
