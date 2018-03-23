
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class SuministrosMedidoresImpl
        {
        #region SuministrosMedidores methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private long response;
            public long SuministrosMedidoresAdd(SuministrosMedidores oSMe)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave Secuencia Sme_NUMERO
                    ds = new DataSet();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('SME_NUMERO')) into IDTEMP from dual; " +
                    " insert into Suministros_Medidores " +
                    "(SME_NUMERO, SME_FECHA_ALTA, SME_FECHA_BAJA, " +
                    "EST_CODIGO, MED_NUMERO, SUM_NUMERO) " +
                    "values(IDTEMP,'" + oSMe.SmeFechaAlta.ToString("dd/MM/yyyy") + "',";
                if (oSMe.SmeFechaBaja == null)
                    query += "null, '";
                else
                    query += "'" + oSMe.SmeFechaBaja.Value.ToString("dd/MM/yyyy") + "','";
                query+=oSMe.EstCodigo + "'," + oSMe.MedNumero + "," + oSMe.SumNumero + ") RETURNING IDTEMP INTO :id;" +
                        " END;";
                //oSMe.SmeFechaBaja == null ? "null, '" : "'" + oSMe.SmeFechaBaja.Value.ToString("dd/MM/yyyy") + "','" +
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

            public bool SuministrosMedidoresUpdate(SuministrosMedidores oSMe)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Suministros_Medidores " +
                        "SET Sme_FECHA_ALTA='" + oSMe.SmeFechaAlta.ToString("dd/MM/yyyy") +
                        "', Sme_FECHA_BAJA='" + oSMe.SmeFechaBaja == null ? "null, " : "'" + oSMe.SmeFechaBaja.Value.ToString("dd/MM/yyyy") +
                        "', EST_CODIGO='" + oSMe.EstCodigo +
                        "', MED_NUMERO=" + oSMe.MedNumero +
                        ", SUM_NUMERO=" + oSMe.SumNumero +
                        " WHERE Sme_NUMERO=" + oSMe.SmeNumero.ToString(), cn);
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
            public bool SuministrosMedidoresDelete(long Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Suministros_Medidores " +
                        "WHERE Sme_NUMERO=" + Id.ToString(), cn);
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

            public SuministrosMedidores SuministrosMedidoresGetById(long Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Suministros_Medidores " +
                         "WHERE Sme_NUMERO=" + Id.ToString();
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    SuministrosMedidores NewEnt = new SuministrosMedidores();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarSuministrosMedidores(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<SuministrosMedidores> SuministrosMedidoresGetAll()
            {
                List<SuministrosMedidores> lstSuministrosMedidores = new List<SuministrosMedidores>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Suministros_Medidores ";
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
                            SuministrosMedidores NewEnt = new SuministrosMedidores();
                            NewEnt = CargarSuministrosMedidores(dr);
                            lstSuministrosMedidores.Add(NewEnt);
                        }
                    }
                    return lstSuministrosMedidores;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        private SuministrosMedidores CargarSuministrosMedidores(DataRow dr)
        {
            try
            {
                SuministrosMedidores oObjeto = new SuministrosMedidores();
                oObjeto.SmeNumero = long.Parse(dr["Sme_NUMERO"].ToString());
                if (dr["Sme_FECHA_ALTA"].ToString() != "")
                    oObjeto.SmeFechaAlta = DateTime.Parse(dr["Sme_FECHA_ALTA"].ToString());
                if (dr["Sme_FECHA_BAJA"].ToString() != "")
                    oObjeto.SmeFechaBaja = DateTime.Parse(dr["Sme_FECHA_BAJA"].ToString());
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                oObjeto.MedNumero = long.Parse(dr["MED_NUMERO"].ToString());
                oObjeto.SumNumero = long.Parse(dr["SUM_NUMERO"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public DataTable SuministrosMedidoresGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "SuministrosMedidoresGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

