
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class MedidoresImpl
        {
        #region Medidores methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long MedidoresAdd(Medidores oMed)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia MED_NUMERO
                ds = new DataSet();
                string query =
                    " DECLARE IDTEMP NUMBER(10,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('MED_NUMERO')) into IDTEMP from dual; " +
                    "insert into Medidores" +
                    "(MED_NUMERO, MED_NUMEROSERIE, EMP_NUMERO_PROVEEDOR, MED_DIGITOS, EST_CODIGO, " +
                    "MED_FACTOR_CALIB, GIS_X, GIS_Y, USR_NUMERO, MED_FECHA_CARGA, MMO_CODIGO) " +
                    "values(IDTEMP," + oMed.MedNumeroserie + "," + oMed.EmpNumeroProveedor + "," +
                    oMed.MedDigitos + ",'" + oMed.EstCodigo + "'," + oMed.MedFactorCalib + "," +
                    (oMed.GisX == null ? "null" : oMed.GisX.ToString()) + "," + 
                    (oMed.GisY == null ? "null" : oMed.GisY.ToString()) + "," + oMed.UsrNumero + ",'" + 
                    oMed.MedFechaCarga.ToString("dd/MM/yyyy") + "'," + oMed.MmoCodigo +
                    ") RETURNING IDTEMP INTO :id;" +
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

        public bool MedidoresUpdate(Medidores oMed)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Medidores " +
                    "SET MED_NUMEROSERIE=" + oMed.MedNumeroserie +
                    ", EMP_NUMERO_PROVEEDOR=" + oMed.EmpNumeroProveedor +
                    ", MED_DIGITOS=" + oMed.MedDigitos +
                    ", EST_CODIGO='" + oMed.EstCodigo +
                    "', MED_FACTOR_CALIB=" + oMed.MedFactorCalib +
                    ", GIS_X=" + (oMed.GisX == null ? "null" : oMed.GisX.ToString()) +
                    ", GIS_Y=" + (oMed.GisY == null ? "null" : oMed.GisY.ToString()) +
                    ", USR_NUMERO=" + oMed.UsrNumero +
                    ", MED_FECHA_CARGA='" + oMed.MedFechaCarga.ToString("dd/MM/yyyy") +
                    "', MMO_CODIGO=" + oMed.MmoCodigo +
                    " WHERE MED_NUMERO=" + oMed.MedNumero, cn);
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
        public bool MedidoresDelete(long Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Medidores " +
                    "WHERE MED_NUMERO=" + Id.ToString(), cn);
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

        public Medidores MedidoresGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Medidores " +
                        "WHERE MED_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Medidores NewEnt = new Medidores();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarMedidores(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Medidores> MedidoresGetAll()
        {
            List<Medidores> lstMedidores = new List<Medidores>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Medidores ";
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
                        Medidores NewEnt = new Medidores();
                        NewEnt = CargarMedidores(dr);
                        lstMedidores.Add(NewEnt);
                    }
                }
                return lstMedidores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable MedidoresGetAllDT()
        {
            List<Medidores> lstMedidores = new List<Medidores>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Medidores ";
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

        private Medidores CargarMedidores(DataRow dr)
        {
            try
            {
                Medidores oObjeto = new Medidores();
                oObjeto.MedNumero = long.Parse(dr["MED_NUMERO"].ToString());
                oObjeto.MedNumeroserie = long.Parse(dr["MED_NUMEROSERIE"].ToString());
                oObjeto.EmpNumeroProveedor = long.Parse(dr["EMP_NUMERO_PROVEEDOR"].ToString());
                oObjeto.MedDigitos = int.Parse(dr["MED_DIGITOS"].ToString());
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                oObjeto.MedFactorCalib = double.Parse(dr["MED_FACTOR_CALIB"].ToString());
                if (dr["GIS_X"].ToString() != "")
                    oObjeto.GisX = decimal.Parse(dr["GIS_X"].ToString());
                if (dr["GIS_Y"].ToString() != "")
                    oObjeto.GisY = decimal.Parse(dr["GIS_Y"].ToString());
                oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                if (dr["MED_FECHA_CARGA"].ToString() != "")
                    oObjeto.MedFechaCarga = DateTime.Parse(dr["MED_FECHA_CARGA"].ToString());
                if (dr["MMO_CODIGO"].ToString() != "")
                    oObjeto.MmoCodigo = short.Parse(dr["MMO_CODIGO"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            //public DataTable MedidoresGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "MedidoresGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

