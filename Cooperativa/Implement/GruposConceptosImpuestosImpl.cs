
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class GruposConceptosImpuestosImpl
    {
        #region GruposImpuestosItems methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;

        public DataTable GruposConceptosImpuestosGetAllDT()
        {
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Grupos_Conceptos_Impuestos ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable();
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
