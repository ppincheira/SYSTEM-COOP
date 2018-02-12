
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class ProvinciasImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int ProvinciasAdd(Provincias oPro)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    //Clave PRV_CODIGO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Provincias(PAI_CODIGO, PRV_CODIGO, " +
                        "PRV_DESCRIPCION) " +
                        "values('" + oPro.PaiCodigo + "','"+ oPro.PrvCodigo + "','"+ oPro.PrvDescripcion +"')", cn);
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

            public bool ProvinciasUpdate(Provincias oPro)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Provincias " +
                        "SET PAI_CODIGO='" + oPro.PaiCodigo + "', " +
                        "PRV_DESCRIPCION='" + oPro.PrvDescripcion + "' " +
                        "WHERE PRV_CODIGO='" + oPro.PrvCodigo + "'", cn);
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

            public bool ProvinciasDelete(string Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Provincias " +
                        "WHERE PRV_CODIGO='" + Id + "'", cn);
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

            public Provincias ProvinciasGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Provincias " +
                        "WHERE PRV_CODIGO='" + Id + "'";
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Provincias NewEnt = new Provincias();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarProvincias(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Provincias> ProvinciasGetAll()
            {
                List<Provincias> lstProvincias = new List<Provincias>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Provincias ";
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
                            Provincias NewEnt = new Provincias();
                            NewEnt = CargarProvincias(dr);
                            lstProvincias.Add(NewEnt);
                        }
                    }
                    return lstProvincias;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private Provincias CargarProvincias(DataRow dr)
            {
                try
                {
                    Provincias oObjeto = new Provincias();
                    oObjeto.PaiCodigo = dr["PAI_CODIGO"].ToString();
                    oObjeto.PrvCodigo = dr["PRV_CODIGO"].ToString();
                    oObjeto.PrvDescripcion = dr["PRV_DESCRIPCION"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable ProvinciasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "ProvinciasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

