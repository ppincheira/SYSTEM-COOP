
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class DistritosImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int DistritosAdd(Distritos oDis)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave Secuencia DIS_NUMERO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Distritos" +
                        "(DIS_DESCRIPCION, EST_CODIGO) " +
                        "values('" + oDis.DisDescripcion + "','"+ oDis.EstCodigo + "')", cn);
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

            public bool DistritosUpdate(Distritos oDis)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Distritos " +
                        "SET DIS_DESCRIPCION='" + oDis.DisDescripcion +
                        "', EST_CODIGO='" + oDis.EstCodigo +
                        "' WHERE DIS_NUMERO=" + oDis.DisNumero.ToString() , cn);
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

            public bool DistritosDelete(long Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Distritos " +
                        "WHERE DIS_NUMERO=" + Id.ToString(), cn);
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

            public Distritos DistritosGetById(long Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Distritos " +
                         "WHERE DIS_NUMERO=" + Id.ToString();
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Distritos NewEnt = new Distritos();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarDistritos(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Distritos> DistritosGetAll()
            {
                List<Distritos> lstDistritos = new List<Distritos>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Distritos ";
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
                            Distritos NewEnt = new Distritos();
                            NewEnt = CargarDistritos(dr);
                            lstDistritos.Add(NewEnt);
                        }
                    }
                    return lstDistritos;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private Distritos CargarDistritos(DataRow dr)
            {
                try
                {
                    Distritos oObjeto = new Distritos();
                    oObjeto.DisNumero = long.Parse(dr["DIS_NUMERO"].ToString());
                    oObjeto.DisDescripcion = dr["DIV_VIGENCIA_DESDE"].ToString();
                    oObjeto.EstCodigo = dr["DIV_VIGENCIA_HASTA"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable DistritosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "DistritosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

