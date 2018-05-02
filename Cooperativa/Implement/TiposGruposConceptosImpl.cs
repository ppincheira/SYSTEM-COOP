
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class TiposGruposConceptosImpl
    {

        #region TiposBarriosLocalidades methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;

        public List<TiposGruposConceptos> TiposGruposConceptosGetAll()
        {
            List<TiposGruposConceptos> lstTiposGruposConceptos = new List<TiposGruposConceptos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Tipos_Grupos_Conceptos ";
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
                        TiposGruposConceptos NewEnt = new TiposGruposConceptos();
                        NewEnt = CargarTiposGruposConceptos(dr);
                        lstTiposGruposConceptos.Add(NewEnt);
                    }
                }
                return lstTiposGruposConceptos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TiposGruposConceptos CargarTiposGruposConceptos(DataRow dr)
        {
            try
            {
                TiposGruposConceptos oObjeto = new TiposGruposConceptos();
                oObjeto.tgcCodigo = dr["TGC_CODIGO"].ToString();
                oObjeto.tgcDescripcion = dr["TGC_DESCRIPCION"].ToString();
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
