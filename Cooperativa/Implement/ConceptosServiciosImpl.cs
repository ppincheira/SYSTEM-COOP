using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class ConceptosServiciosImpl
    {
        #region ConceptosServicios methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;

        public DataTable ConceptosServiciosGetByFilter(long CodigoConcepto)
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT c.cos_codigo pk, " +//0 oculto
                                   "        c.cpt_numero fk, " +//1 oculto
                                   "        c.srv_codigo codigo, " +  //2                                 
                                   "        s.srv_descripcion descripcion, " +//3
                                   "        to_char(c.cos_fecha_carga,'DD/MM/YYYY') fecha " +//4
                                   " FROM   servicios s," +
                                   "        conceptos_servicios c " +
                                   " WHERE  s.srv_codigo = c.srv_codigo " +
                                   " AND    c.cpt_numero =  '" + CodigoConcepto + "' ";
              
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

        public long ConceptosServiciosAdd(ConceptosServicios oCos)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                //Clave Secuencia 
                ds = new DataSet();
                string sql =    "insert into Conceptos_Servicios(COS_CODIGO, " +
                                                                "CPT_NUMERO, " +
                                                                "SRV_CODIGO, " +
                                                                "COS_FECHA_CARGA) " +
                            "values(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('COS_CODIGO'), " +                                    
                                    " '" + oCos.cptNumero + "', " +
                                    " '" + oCos.srvCodigo + "', " +
                                    " TO_DATE('" + oCos.cosFechaCarga.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY HH24:MI:SS') " +
                                    ")";
                Console.WriteLine("inserta "+ sql);
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

        public bool ConceptosServiciosDelete(ConceptosServicios oCos)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("  DELETE Conceptos_Servicios " +
                                        "  WHERE  cos_codigo='" + oCos.cosCodigo + "' ", cn);
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

        public Transacciones ConceptosServiciosAddTrans(ConceptosServicios oCos)
        {
            try
            {
                Transacciones oTrans = new Transacciones();
                oTrans.traQuery =    "insert into Conceptos_Servicios(COS_CODIGO, " +
                                                                "CPT_NUMERO, " +
                                                                "SRV_CODIGO, " +
                                                                "COS_FECHA_CARGA) " +
                                    "values(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('COS_CODIGO'), " +
                                            " '" + oCos.cptNumero + "', " +
                                            " '" + oCos.srvCodigo + "', " +
                                            " TO_DATE('" + oCos.cosFechaCarga.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY HH24:MI:SS') " +
                                            ")";
                return oTrans;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Transacciones ConceptosServiciosDeleteTrans(ConceptosServicios oCos)
        {
            try
            {
                Transacciones oTrans = new Transacciones();
                oTrans.traQuery = "  DELETE Conceptos_Servicios " +
                                  "  WHERE  cos_codigo='" + oCos.cosCodigo + "' ";
                return oTrans;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
