using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class MonedasTasasCambioImpl
    {
        #region MonedasTasasCambio methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int MonedasTasasCambioAdd(MonedasTasasCambio oMTC)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();
                cmd = new OracleCommand("insert into Monedas_Tasas_Cambio(MON_CODIGO, " +
                        "MTC_FECHA_VIGENCIA, MTC_IMPORTE )" +
                        "values(" + oMTC.MonCodigo.ToString() + ",'" +
                        oMTC.MtcFechaVigencia.ToString("dd/MM/yyyy") + "'," + oMTC.MtcImporte.ToString() + ")", cn);
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

        public bool MonedasTasasCambioUpdate(MonedasTasasCambio oMTC)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Monedas_Tasas_Cambio " +
                    "SET MTC_IMPORTE=" + oMTC.MtcImporte.ToString() + " " +
                    "WHERE MON_CODIGO=" + oMTC.MonCodigo.ToString()+
                    " and MTC_FECHA_VIGENCIA='"+oMTC.MtcFechaVigencia.ToString("dd/MM/yyyy")+"'", cn);
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

        public bool MonedasTasasCambioDelete(short Id, DateTime Vigencia)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Monedas_Tasas_Cambio " +
                      "WHERE MON_CODIGO=" + Id.ToString() +
                    " and MTC_FECHA_VIGENCIA='" + Vigencia.ToString("dd/MM/yyyy") + "'", cn);
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

        public MonedasTasasCambio MonedasTasasCambioGetById(short Id, DateTime Vigencia)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Monedas_Tasas_Cambio " +
                    "where MON_CODIGO=" + Id.ToString() +
                    " and MTC_FECHA_VIGENCIA='" + Vigencia.ToString("dd/MM/yyyy") + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                MonedasTasasCambio NewEnt = new MonedasTasasCambio();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarMonedasTasasCambio(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MonedasTasasCambio> MonedasTasasCambioGetAll()
        {
            List<MonedasTasasCambio> lstMonedasTasasCambio = new List<MonedasTasasCambio>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Monedas_Tasas_Cambio ";
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
                        MonedasTasasCambio NewEnt = new MonedasTasasCambio();
                        NewEnt = CargarMonedasTasasCambio(dr);
                        lstMonedasTasasCambio.Add(NewEnt);
                    }
                }
                return lstMonedasTasasCambio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private MonedasTasasCambio CargarMonedasTasasCambio(DataRow dr)
        {
            try
            {
                MonedasTasasCambio oObjeto = new MonedasTasasCambio();
                oObjeto.MonCodigo =short.Parse(dr["MON_CODIGO"].ToString());
                if (dr["MTC_FECHA_VIGENCIA"].ToString() != "")
                    oObjeto.MtcFechaVigencia = DateTime.Parse(dr["MTC_FECHA_VIGENCIA"].ToString());
                oObjeto.MtcImporte = double.Parse(dr["MTC_IMPORTE"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public DataTable MonedasTasasCambioGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "MonedasTasasCambioGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
