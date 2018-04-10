
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class MedidoresModelosImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private long response;
            public long MedidoresModelosAdd(MedidoresModelos oMMO)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave MMO_CODIGO
                    ds = new DataSet();
                    string query =
                        " DECLARE IDTEMP NUMBER(4,0); " +
                        " BEGIN " +
                        " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('MMO_CODIGO')) into IDTEMP from dual; " +
                        " insert into Medidores_Modelos" +
                        "(MMO_CODIGO, MMO_DESCRIPCION, MMO_DESCRIPCION_CORTA, MMO_DIGITOS, " +
                        "MMO_DECIMALES, MMO_CANT_HILOS, MMO_KW_VUELTAS, MMO_AMPERAJE, " +
                        "MMO_CLASE, MMO_TIPO_CONTADOR, TCS_CODIGO, " +
                        "FAB_NUMERO, TME_CODIGO, USR_NUMERO, MMO_FECHA_CARGA, EST_CODIGO) " +
                        "values(IDTEMP,'" + oMMO.MMoDescripcion + "','" +
                        oMMO.MMoDescripcionCorta + "'," + oMMO.MMoDigitos + "," +
                        oMMO.MMoDecimales + "," + oMMO.MMoCantHilos + "," + oMMO.MMoKwVueltas + ",'" +
                        oMMO.MMoAmperaje + "'," + oMMO.MMoClase + ",'" +
                        oMMO.MMoTipoContador + "','" + oMMO.TCSCodigo + "'," +
                        oMMO.FabNumero + "," + oMMO.TmeCodigo + "," + oMMO.UsrNumero + ",'" +
                        oMMO.MMoFechaCarga.ToString("dd/MM/yyyy") + "','" + oMMO.EstCodigo + "') RETURNING IDTEMP INTO :id;" +
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

            public bool MedidoresModelosUpdate(MedidoresModelos oMMO)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                cmd = new OracleCommand("update Medidores_Modelos " +
                    "SET MMO_DESCRIPCION='" + oMMO.MMoDescripcion +
                    "', MMO_DESCRIPCION_CORTA='" + oMMO.MMoDescripcionCorta +
                    "', MMO_DIGITOS=" + oMMO.MMoDigitos +
                    ", MMO_DECIMALES=" + oMMO.MMoDecimales +
                    ", MMO_CANT_HILOS=" + oMMO.MMoCantHilos +
                    ", MMO_KW_VUELTAS=" + oMMO.MMoKwVueltas +
                    ", MMO_AMPERAJE='" + oMMO.MMoAmperaje +
                    "', MMO_CLASE=" + oMMO.MMoClase +
                    ", MMO_TIPO_CONTADOR='" + oMMO.MMoTipoContador +
                    "', TCS_CODIGO='" + oMMO.TCSCodigo +
                    "', FAB_NUMERO=" + oMMO.FabNumero +
                    ", TME_CODIGO=" + oMMO.TmeCodigo +
                    ", USR_NUMERO=" + oMMO.UsrNumero +
                    ", MMO_FECHA_CARGA='" + oMMO.MMoFechaCarga.ToString("dd/MM/yyyy") +
                    "', EST_CODIGO='" + oMMO.EstCodigo + "' " +
                    " WHERE MMO_CODIGO=" + oMMO.MMoCodigo, cn);
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

            public bool MedidoresModelosDelete(long Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Medidores_Modelos " +
                        "WHERE MMO_CODIGO=" +Id, cn);
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

            public MedidoresModelos MedidoresModelosGetById(long Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores_Modelos " +
                         "WHERE MMO_CODIGO = " +Id;
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    MedidoresModelos NewEnt = new MedidoresModelos();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarMedidoresModelos(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<MedidoresModelos> MedidoresModelosGetAll()
            {
                List<MedidoresModelos> lstMedidoresModelos = new List<MedidoresModelos>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores_Modelos ";
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
                            MedidoresModelos NewEnt = new MedidoresModelos();
                            NewEnt = CargarMedidoresModelos(dr);
                            lstMedidoresModelos.Add(NewEnt);
                        }
                    }
                    return lstMedidoresModelos;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public DataTable MedidoresModelosGetAllDT()
            {
                List<MedidoresModelos> lstMedidoresModelos = new List<MedidoresModelos>();
                try
                {
                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores_Modelos ";
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

            public DataTable MedidoresModelosGetByDT(string campoFiltro, int valorFiltro)
            {
                List<MedidoresModelos> lstMedidoresModelos = new List<MedidoresModelos>();
                try
                {
                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores_Modelos where " + campoFiltro + "=" + valorFiltro;
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

            public DataTable MedidoresModelosGetByDT(string campoFiltro, string valorFiltro)
            {
                List<MedidoresModelos> lstMedidoresModelos = new List<MedidoresModelos>();
                try
                {
                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores_Modelos where " + campoFiltro + "=" + valorFiltro+"'";
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

            private MedidoresModelos CargarMedidoresModelos(DataRow dr)
            {
                try
                {
                    MedidoresModelos oObjeto = new MedidoresModelos();
                    oObjeto.MMoCodigo = short.Parse(dr["MMO_CODIGO"].ToString());
                    oObjeto.MMoDescripcion = dr["MMO_DESCRIPCION"].ToString();
                    oObjeto.MMoDescripcionCorta = dr["MMO_DESCRIPCION_CORTA"].ToString();
                    if (dr["MMO_DIGITOS"].ToString() != "")
                        oObjeto.MMoDigitos = int.Parse(dr["MMO_DIGITOS"].ToString());
                    if (dr["MMO_DECIMALES"].ToString() != "")
                        oObjeto.MMoDecimales = int.Parse(dr["MMO_DECIMALES"].ToString());
                    if (dr["MMO_CANT_HILOS"].ToString() != "")
                        oObjeto.MMoCantHilos = int.Parse(dr["MMO_CANT_HILOS"].ToString());
                    if (dr["MMO_KW_VUELTAS"].ToString() != "")
                        oObjeto.MMoKwVueltas = int.Parse(dr["MMO_KW_VUELTAS"].ToString());
                    oObjeto.MMoAmperaje = dr["MMO_AMPERAJE"].ToString();
                    if (dr["MMO_CLASE"].ToString() != "")
                        oObjeto.MMoClase = int.Parse(dr["MMO_CLASE"].ToString());
                    oObjeto.MMoTipoContador = dr["MMO_TIPO_CONTADOR"].ToString();
                    oObjeto.TCSCodigo = dr["TCS_CODIGO"].ToString();
                    oObjeto.FabNumero = int.Parse(dr["FAB_NUMERO"].ToString());
                    oObjeto.TmeCodigo = int.Parse(dr["TME_CODIGO"].ToString());
                    oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                    if (dr["MMO_FECHA_CARGA"].ToString() != "")
                        oObjeto.MMoFechaCarga = DateTime.Parse(dr["MMO_FECHA_CARGA"].ToString());
                    oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable MedidoresModelosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "MedidoresModelosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

