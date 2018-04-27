
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class SuministrosImpl
    {
        #region Suministros methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long SuministrosAdd(Suministros oSum)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia SUM_NUMERO
                ds = new DataSet();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('SUM_NUMERO')) into IDTEMP from dual; " +
                    " insert into Suministros " +
                    "(SUM_NUMERO, SRV_CODIGO, TCS_CODIGO, " +
                    "SCA_NUMERO, SUM_ORDEN_RUTA, EMP_NUMERO, SUM_FECHA_ALTA, EST_CODIGO," +
                    "SUM_CONSUMO_ESTIMADO, SUM_VOLTAJE, SUM_CONEXION, SUM_POTENCIA_L1, " +
                    "SUM_POTENCIA_L2, SUM_POTENCIA_L3, SUM_REGISTRADOR, SUM_PERMITE_CORTE, " +
                    "SUM_MEDIDO, SRU_NUMERO, SZO_NUMERO, SUM_PERMITE_FACTURACION, SUM_FECHA_CARGA) " +
                    "values(IDTEMP,'" + oSum.SrvCodigo + "', '" + oSum.TcsCodigo + "'," + oSum.ScaNumero + "," +
                    oSum.SumOrdenRuta + "," + oSum.EmpNumero + ",'" + oSum.SumFechaAlta.ToString("dd/MM/yyyy") + "','" +
                    oSum.EstCodigo + "'," + oSum.SumConsumoEstimado + "," + oSum.SumVoltaje + ",'" +
                    oSum.SumConexion + "'," + oSum.SumPotenciaL1 + "," + oSum.SumPotenciaL2 + "," +
                    oSum.SumPotenciaL3 + "," + oSum.SumRegistrador + ",'"  + oSum.SumPermiteCorte + "', '" +
                    oSum.SumMedido + "'," + oSum.SruNumero + "," + oSum.SzoNumero + ", '"+
                    oSum.SumPermiteFactura+"', '"+DateTime.Now.ToString("dd/MM/yyyy") +"') RETURNING IDTEMP INTO :id;" +
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

        public bool SuministrosAddCompleto(Suministros oSum, DomiciliosEntidades oDomSum, SuministrosMedidores oMedSum)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia SUM_NUMERO
                ds = new DataSet();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('SUM_NUMERO')) into IDTEMP from dual; " +
                    " insert into Suministros " +
                    "(SUM_NUMERO, SRV_CODIGO, TCS_CODIGO, " +
                    "SCA_NUMERO, SUM_ORDEN_RUTA, EMP_NUMERO, SUM_FECHA_ALTA, EST_CODIGO," +
                    "SUM_CONSUMO_ESTIMADO, SUM_VOLTAJE, SUM_CONEXION, SUM_POTENCIA_L1, " +
                    "SUM_POTENCIA_L2, SUM_POTENCIA_L3, SUM_REGISTRADOR, SUM_PERMITE_CORTE, " +
                    "SUM_MEDIDO, SRU_NUMERO, SZO_NUMERO, SUM_PERMITE_FACTURACION, SUM_FECHA_CARGA) " +
                    "values(IDTEMP,'" + oSum.SrvCodigo + "', '" + oSum.TcsCodigo + "'," + oSum.ScaNumero + "," +
                    oSum.SumOrdenRuta + "," + oSum.EmpNumero + ",'" + oSum.SumFechaAlta.ToString("dd/MM/yyyy") + "','" +
                    oSum.EstCodigo + "'," + oSum.SumConsumoEstimado + "," + oSum.SumVoltaje + ",'" +
                    oSum.SumConexion + "'," + oSum.SumPotenciaL1 + "," + oSum.SumPotenciaL2 + "," +
                    oSum.SumPotenciaL3 + "," + oSum.SumRegistrador + ",'"  + oSum.SumPermiteCorte + "', '" +
                    oSum.SumMedido + "'," + oSum.SruNumero + "," + oSum.SzoNumero + ", '"+
                    oSum.SumPermiteFactura+"', '"+DateTime.Now.ToString("dd/MM/yyyy") +"') RETURNING IDTEMP INTO :id;" +
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
                oSum.SumNumero = long.Parse(cmd.Parameters[":id"].Value.ToString());

                //Agrega registro a Domicilios entidades
                oDomSum.DenCodigoRegistro = oSum.SumNumero;
                query =
                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('DEN_NUMERO')) into IDTEMP from dual; " +
                    "INSERT INTO DOMICILIOS_ENTIDADES(DEN_NUMERO,TDO_CODIGO,DEN_CODIGO_REGISTRO, TAB_CODIGO, " +
                    "DOM_CODIGO, DEN_DEFECTO)  VALUES(IDTEMP,'" +
                    oDomSum.TdoCodigo + "'," + oDomSum.DenCodigoRegistro + ", '" + oDomSum.TabCodigo + "'," +
                    oDomSum.DomCodigo + ", '" + oDomSum.DenDefecto + "') RETURNING IDTEMP INTO :id;" +
                    " END;";

                cmd = new OracleCommand(query, cn);
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });

                cmd.ExecuteNonQuery();
                oDomSum.DenNumero = long.Parse(cmd.Parameters[":id"].Value.ToString());

                if (oMedSum.MedNumero != 0)
                {
                    oMedSum.SumNumero = oSum.SumNumero;
                    //Agrego registro Suministro Medidores
                    query =
                        " DECLARE IDTEMP NUMBER(15,0); " +
                        " BEGIN " +
                        " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('SME_NUMERO')) into IDTEMP from dual; " +
                        " insert into Suministros_Medidores " +
                        "(SME_NUMERO, SME_FECHA_ALTA, SME_FECHA_BAJA, " +
                        "EST_CODIGO, MED_NUMERO, SUM_NUMERO) " +
                        "values(IDTEMP,'" + oMedSum.SmeFechaAlta.ToString("dd/MM/yyyy") + "',";
                    if (oMedSum.SmeFechaBaja == null)
                        query += "null, '";
                    else
                        query += "'" + oMedSum.SmeFechaBaja.Value.ToString("dd/MM/yyyy") + "','";
                    query += oMedSum.EstCodigo + "'," + oMedSum.MedNumero + "," + oMedSum.SumNumero + ") RETURNING IDTEMP INTO :id;" +
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
                    oMedSum.SmeNumero = long.Parse(cmd.Parameters[":id"].Value.ToString());
                }
                // Agregar el medidor del suministro si es necesario (numero de medidor != 0)
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
       }

        public bool SuministrosUpdate(Suministros oSum)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Suministros " +
                    "SET SRV_CODIGO='" + oSum.SrvCodigo + "', " +
                    "TCS_CODIGO='" + oSum.TcsCodigo + "', " +
                    "SCA_NUMERO=" + oSum.ScaNumero + ", " +
                    "SUM_ORDEN_RUTA=" + oSum.SumOrdenRuta + ", " +
                    "EMP_NUMERO=" + oSum.EmpNumero + ", '" +
                    "SUM_FECHA_ALTA='" + oSum.SumFechaAlta.ToString("dd/MM/yyyy") + "', " +
                    "EST_CODIGO='" + oSum.EstCodigo + "', " +
                    "SUM_CONSUMO_ESTIMADO=" + oSum.SumConsumoEstimado + ", " +
                    "SUM_VOLTAJE=" + oSum.SumVoltaje + ", " +
                    "SUM_CONEXION='" + oSum.SumConexion + "', " +
                    "SUM_POTENCIA_L1=" + oSum.SumPotenciaL1 + " " +
                    "SUM_POTENCIA_L2=" + oSum.SumPotenciaL2 + ", " +
                    "SUM_POTENCIA_L3=" + oSum.SumPotenciaL3 + ", " +
                    "SUM_REGISTRADOR=" + oSum.SumRegistrador + ", " +
                    "SUM_PERMITE_CORTE='" + oSum.SumPermiteCorte + "', " +
                    "SUM_MEDIDO='" + oSum.SumMedido + "', " +
                    "SRU_NUMERO=" + oSum.SruNumero + ", " +
                    "SZO_NUMERO=" + oSum.SzoNumero + ", " +
                    "SUM_FECHA_CARGA='" + oSum.SumFechaCarga.ToString("dd/MM/yyyy") + "', " +
                    "SUM_PERMITE_FACTURACION='" + oSum.SumPermiteFactura + "' " +
                    "WHERE SUM_NUMERO='" + oSum.SumNumero + "'", cn);
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

        public bool SuministrosDelete(long Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Suministros " +
                      "WHERE SUM_NUMERO='" + Id + "'", cn);
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

        public Suministros SuministrosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Suministros " +
                    "WHERE SUM_NUMERO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Suministros NewEnt = new Suministros();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarSuministros(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Suministros> SuministrosGetAll()
        {
            List<Suministros> lstSuministros = new List<Suministros>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Suministros ";
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
                        Suministros NewEnt = new Suministros();
                        NewEnt = CargarSuministros(dr);
                        lstSuministros.Add(NewEnt);
                    }
                }
                return lstSuministros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Suministros CargarSuministros(DataRow dr)
        {
            try
            {
                Suministros oObjeto = new Suministros();
                oObjeto.SumNumero =long.Parse(dr["SUM_NUMERO"].ToString());
                oObjeto.SrvCodigo = dr["SRV_CODIGO"].ToString();
                oObjeto.TcsCodigo = dr["TCS_CODIGO"].ToString();
                oObjeto.ScaNumero = long.Parse(dr["SCA_NUMERO"].ToString());
                if (dr["SUM_ORDEN_RUTA"].ToString() != "")
                    oObjeto.SumOrdenRuta = long.Parse(dr["SUM_ORDEN_RUTA"].ToString());
                if (dr["EMP_NUMERO"].ToString() != "")
                    oObjeto.EmpNumero = long.Parse(dr["EMP_NUMERO"].ToString());
                if (dr["SUM_FECHA_ALTA"].ToString() != "")
                    oObjeto.SumFechaAlta =DateTime.Parse(dr["SUM_FECHA_ALTA"].ToString());
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                if (dr["SUM_CONSUMO_ESTIMADO"].ToString() != "")
                    oObjeto.SumConsumoEstimado = float.Parse(dr["SUM_CONSUMO_ESTIMADO"].ToString());
                if (dr["SUM_VOLTAJE"].ToString() != "")
                    oObjeto.SumVoltaje = long.Parse(dr["SUM_VOLTAJE"].ToString());
                oObjeto.SumConexion = dr["SUM_CONEXION"].ToString();
                if (dr["SUM_POTENCIA_L1"].ToString() != "")
                    oObjeto.SumPotenciaL1 = double.Parse(dr["SUM_POTENCIA_L1"].ToString());
                if (dr["SUM_POTENCIA_L2"].ToString() != "")
                    oObjeto.SumPotenciaL2 =double.Parse(dr["SUM_POTENCIA_L2"].ToString());
                if (dr["SUM_POTENCIA_L3"].ToString() != "")
                    oObjeto.SumPotenciaL3 = double.Parse(dr["SUM_POTENCIA_L3"].ToString());
                if (dr["SUM_REGISTRADOR"].ToString() != "")
                    oObjeto.SumRegistrador = long.Parse(dr["SUM_REGISTRADOR"].ToString());
                oObjeto.SumPermiteCorte = dr["SUM_PERMITE_CORTE"].ToString();
                oObjeto.SumMedido = dr["SUM_MEDIDO"].ToString();
                oObjeto.SruNumero = long.Parse(dr["SRU_NUMERO"].ToString());
                oObjeto.SzoNumero = long.Parse(dr["SZO_NUMERO"].ToString());
                if (dr["SUM_FECHA_CARGA"].ToString() != "")
                    oObjeto.SumFechaCarga =DateTime.Parse(dr["SUM_FECHA_CARGA"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable SuministrosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "SuministrosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
