
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class ParametrosGeneralesImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int ParametrosGeneralesAdd(ParametrosGenerales OPaG)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    //Clave PAG_CODIGO, PAG_TIPO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Parametros_Generales(PAG_CODIGO, " +
                        "PAG_DESCRIPCION, PAG_VALOR, PAG_TIPO, PAG_VISIBLE, PAG_MODIFICABLE_USR) " +
                        "values('" + OPaG.PagCodigo + "','" + OPaG.PagDescripcion + "','" + 
                        OPaG.PagValor + "','"+ OPaG.PagTipo + "','" + OPaG.PagVisible + "','" + 
                        OPaG.PagModificableUsr + "')", cn);
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

            public bool ParametrosGeneralesUpdate(ParametrosGenerales OPaG)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Parametros_Generales " +
                        "SET PAG_DESCRIPCION='" + OPaG.PagDescripcion + "', '"+
                        "PAG_VALOR='" + OPaG.PagValor + "', '"+
                        "PAG_VISIBLE='" + OPaG.PagVisible + "', '"+
                        "PAG_MODIFICABLE_USR='" + OPaG.PagModificableUsr + "' "+
                        "WHERE PAG_CODIGO='" + OPaG.PagCodigo + "' and PAG_TIPO='" + OPaG.PagTipo +"'", cn);
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

            public bool ParametrosGeneralesDelete(string Codigo, string Tipo)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Parametros_Generales " +
                        "WHERE PAG_CODIGO='" + Codigo + "' and PAG_TIPO='" + Tipo + "'", cn);
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

            public ParametrosGenerales ParametrosGeneralesGetById(string Codigo, string Tipo)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Parametros_Generales " +
                        "WHERE PAG_CODIGO='" + Codigo + "' and PAG_TIPO='" + Tipo + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    ParametrosGenerales NewEnt = new ParametrosGenerales();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarParametrosGenerales(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<ParametrosGenerales> ParametrosGeneralesGetAll()
            {
                List<ParametrosGenerales> lstParametrosGenerales = new List<ParametrosGenerales>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Parametros_Generales ";
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
                            ParametrosGenerales NewEnt = new ParametrosGenerales();
                            NewEnt = CargarParametrosGenerales(dr);
                            lstParametrosGenerales.Add(NewEnt);
                        }
                    }
                    return lstParametrosGenerales;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private ParametrosGenerales CargarParametrosGenerales(DataRow dr)
            {
                try
                {
                    ParametrosGenerales oObjeto = new ParametrosGenerales();
                    oObjeto.PagCodigo = dr["PAG_CODIGO"].ToString();
                    oObjeto.PagDescripcion = dr["PAG_DESCRIPCION"].ToString();
                    oObjeto.PagValor = dr["PAG_VALOR"].ToString();
                    oObjeto.PagTipo = dr["PAG_TIPO"].ToString();
                    oObjeto.PagVisible = dr["PAG_VISIBLE"].ToString();
                    oObjeto.PagModificableUsr = dr["PAG_MODIFICABLE_USR"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable ParametrosGeneralesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "ParametrosGeneralesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

