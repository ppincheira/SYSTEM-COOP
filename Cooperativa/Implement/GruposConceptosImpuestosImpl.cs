
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class GruposConceptosImpuestosImpl
    {
        #region GruposConceptosImpuestos methods

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
        public GruposConceptosImpuestos GruposConceptosImpuestosGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM Grupos_Conceptos_Impuestos " +
                                   "WHERE gci_codigo= '" + Id + "' ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                GruposConceptosImpuestos NewEnt = new GruposConceptosImpuestos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarGruposConceptosImpuestos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private GruposConceptosImpuestos CargarGruposConceptosImpuestos(DataRow dr)
        {
            try
            {
                GruposConceptosImpuestos oObjeto = new GruposConceptosImpuestos();
                oObjeto.GciCodigo = dr["GCI_CODIGO"].ToString();
                oObjeto.GciDescripcion = dr["GCI_DESCRIPCION"].ToString();
                oObjeto.TgcCodigo = dr["TGC_CODIGO"].ToString();

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
