
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class MedidoresSuministrosImpl
        {
        #region MedidoresSuministros methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int MedidoresSuministrosAdd(MedidoresSuministros oMSu)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave Secuencia MSU_NUMERO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Medidores_Suministros" +
                        "() " +
                        "values(" + oMSu.MsuFechaAlta + ","+ oMSu.MsuFechaBaja + ",'"+ 
                        oMSu.EstCodigo + "'," +  oMSu.MedNumero + "," + oMSu.SumNumero + ")", cn);
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

            public bool MedidoresSuministrosUpdate(MedidoresSuministros oMSu)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Medidores_Suministros " +
                        "SET MSU_FECHA_ALTA=" + oMSu.MsuFechaAlta +
                        ", MSU_FECHA_BAJA=" + oMSu.MsuFechaBaja +
                        ", EST_CODIGO='" + oMSu.EstCodigo +
                        "', MED_NUMERO=" + oMSu.MedNumero +
                        ", SUM_NUMERO=" + oMSu.SumNumero +
                        " WHERE MSU_NUMERO=" + oMSu.MsuNumero.ToString(), cn);
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
            public bool MedidoresSuministrosDelete(long Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Medidores_Suministros " +
                        "WHERE MSU_NUMERO=" + Id.ToString(), cn);
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

            public MedidoresSuministros MedidoresSuministrosGetById(long Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores_Suministros " +
                         "WHERE MSU_NUMERO=" + Id.ToString();
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    MedidoresSuministros NewEnt = new MedidoresSuministros();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarMedidoresSuministros(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<MedidoresSuministros> MedidoresSuministrosGetAll()
            {
                List<MedidoresSuministros> lstMedidoresSuministros = new List<MedidoresSuministros>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Medidores_Suministros ";
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
                            MedidoresSuministros NewEnt = new MedidoresSuministros();
                            NewEnt = CargarMedidoresSuministros(dr);
                            lstMedidoresSuministros.Add(NewEnt);
                        }
                    }
                    return lstMedidoresSuministros;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        private MedidoresSuministros CargarMedidoresSuministros(DataRow dr)
        {
            try
            {
                MedidoresSuministros oObjeto = new MedidoresSuministros();
                oObjeto.MsuNumero = long.Parse(dr["MSU_NUMERO"].ToString());
                if (dr["MSU_FECHA_ALTA"].ToString() != "")
                    oObjeto.MsuFechaAlta = DateTime.Parse(dr["MSU_FECHA_ALTA"].ToString());
                if (dr["MSU_FECHA_BAJA"].ToString() != "")
                    oObjeto.MsuFechaBaja = DateTime.Parse(dr["MSU_FECHA_BAJA"].ToString());
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
        //public DataTable MedidoresSuministrosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "MedidoresSuministrosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

