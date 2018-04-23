using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class CuadrosTarifariosImpl
    {
        #region CuadrosTarifarios methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long CuadrosTarifariosAdd(CuadrosTarifarios oCdt)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('CDT_CODIGO')) into IDTEMP from dual; " +
                    " INSERT INTO CuadrosTarifarios(CDT_CODIGO,CDT_FECHA_VIGENCIA,CDT_FEHCA_ALTA, " +
                    " SRV_CODIGO) " +
                    " VALUES(IDTEMP,'" + oCdt.CdtFechaVigencia.Value.ToString("dd/MM/yyyy") + "','" +
                    " " + oCdt.CdtFechaAlta.Value.ToString("dd/MM/yyyy") + "', " + oCdt.SrvCodigo;

                cmd = new OracleCommand(query, cn);
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });

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

        public bool CuadrosTarifariosUpdate(CuadrosTarifarios oCdt)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update CUADROS_TARIFARIOS " +
                    "SET CDT_FECHA_VIGENCIA='" + oCdt.CdtFechaVigencia.Value.ToString("dd/MM/yyyy") + "'," +
                    "CDT_FEHCA_ALTA = '" + oCdt.CdtFechaAlta.Value.ToString("dd/MM/yyyy") + "', " +
                    "SRV_CODIGO = " + oCdt.SrvCodigo +
                    "WHERE CDT_CODIGO=" + oCdt.CdtCodigo, cn);
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

        public bool CuadrosTarifariosDelete(long Id)
        {

            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE CuadrosTarifarios " +
                    "WHERE CDT_CODIGO=" + Id.ToString(), cn);
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

        public CuadrosTarifarios CuadrosTarifariosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM CuadrosTarifarios " +
                    "WHERE CDT_CODIGO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                CuadrosTarifarios NewEnt = new CuadrosTarifarios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarCuadrosTarifarios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //public CuadrosTarifarios CuadrosTarifariosGetByEmpNumero(long EmpNumero)
        //{
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        Conexion oConexion = new Conexion();
        //        OracleConnection cn = oConexion.getConexion();
        //        cn.Open();
        //        string sqlSelect = "select * from CuadrosTarifarios " +
        //            "WHERE EMP_NUMERO=" + EmpNumero;
        //        cmd = new OracleCommand(sqlSelect, cn);
        //        adapter = new OracleDataAdapter(cmd);
        //        cmd.ExecuteNonQuery();
        //        adapter.Fill(ds);
        //        DataTable dt;
        //        dt = ds.Tables[0];
        //        CuadrosTarifarios NewEnt = new CuadrosTarifarios();
        //        if (dt.Rows.Count > 0)
        //        {
        //            DataRow dr = dt.Rows[0];
        //            NewEnt = CargarCuadrosTarifarios(dr);
        //        }
        //        return NewEnt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public List<CuadrosTarifarios> CuadrosTarifariosGetAll()
        {
            List<CuadrosTarifarios> lstCuadrosTarifarios = new List<CuadrosTarifarios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from CuadrosTarifarios ";
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
                        CuadrosTarifarios NewEnt = new CuadrosTarifarios();
                        NewEnt = CargarCuadrosTarifarios(dr);
                        lstCuadrosTarifarios.Add(NewEnt);
                    }
                }
                return lstCuadrosTarifarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable CuadrosTarifariosGetAllDT()
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select CDT_CODIGO CODIGO, CDT_FECHA_VIGENCIA VIGENCIA from CUADROS_TARIFARIOS ORDER BY CDT_FECHA_VIGENCIA"; 
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
        private CuadrosTarifarios CargarCuadrosTarifarios(DataRow dr)
        {
            try
            {
                CuadrosTarifarios oCdt = new CuadrosTarifarios();
                oCdt.CdtCodigo = long.Parse(dr["CDT_CODIGO"].ToString());
                if (dr["CDT_FECHA_VIGENCIA"].ToString() != "")
                    oCdt.CdtFechaVigencia = DateTime.Parse(dr["CDT_FECHA_VIGENCIA"].ToString());
                if (dr["CDT_FEHCA_ALTA"].ToString() != "")
                    oCdt.CdtFechaAlta = DateTime.Parse(dr["CDT_FEHCA_ALTA"].ToString());
                oCdt.SrvCodigo = dr["SRV_CODIGO"].ToString();
                return oCdt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable AccionistasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "AccionistasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
        //        DTPartes = DSPartes.Tables[0];
        //        DSPartes.Tables.RemoveAt(0);
        //        return DTPartes;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion

    }
}
