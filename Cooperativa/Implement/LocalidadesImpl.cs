
///////////////////////////////////////////////////////////////////////////
//
// Creado por: Pincheira Pablo
//
///////////////////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
        public class LocalidadesImpl
        {
            #region Departamento methods

            private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int LocalidadesAdd(Localidades oLoc)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    //Clave Secuencia LOC_NUMERO
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Localidades(PRV_CODIGO, " +
                        "LOC_DESCRIPCION, TLO_CODIGO) " +
                        "values('" + oLoc.PrvCodigo + "','"+ oLoc.LocDescripcion + "','"+ oLoc.TloCodigo +"')", cn);
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

            public bool LocalidadesUpdate(Localidades oLoc)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Localidades " +
                        "SET PRV_CODIGO='" + oLoc.PrvCodigo + "', " +
                        "LOC_DESCRIPCION='" + oLoc.LocDescripcion + "', " +
                        "TLO_CODIGO='" + oLoc.TloCodigo + "' " +
                        "WHERE LOC_NUMERO=" + oLoc.LocNumero.ToString(), cn);
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

            public bool LocalidadesDelete(int Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Localidades " +
                        "WHERE LOC_NUMERO=" + Id.ToString(), cn);
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

            public Localidades LocalidadesGetById(int Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select  LOC_NUMERO, LOC_DESCRIPCION, PRV_CODIGO, TLO_CODIGO  from Localidades " +
                        "WHERE LOC_NUMERO=" + Id.ToString();
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Localidades NewEnt = new Localidades();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarLocalidades(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Localidades> LocalidadesGetAll()
            {
                List<Localidades> lstLocalidades = new List<Localidades>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "SELECT LOC_NUMERO, LOC_DESCRIPCION, PRV_CODIGO, TLO_CODIGO FROM LOCALIDADES ";
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
                            Localidades NewEnt = new Localidades();
                            NewEnt = CargarLocalidades(dr);
                            lstLocalidades.Add(NewEnt);
                        }
                    }
                    return lstLocalidades;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        public DataTable LocalidadesGetByProvincia( string Codigo)
        {
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT LOC_NUMERO, LOC_DESCRIPCION, PRV_CODIGO, TLO_CODIGO  FROM LOCALIDADES" +
                    " WHERE  PRV_CODIGO='"+Codigo+"'" +
                    " ORDER BY LOC_DESCRIPCION ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable();
                return dt = ds.Tables[0];
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Localidades CargarLocalidades(DataRow dr)
            {
                try
                {
                    Localidades oObjeto = new Localidades();
                    oObjeto.PrvCodigo = dr["PRV_CODIGO"].ToString();
                    oObjeto.LocNumero = int.Parse(dr["LOC_NUMERO"].ToString());
                    oObjeto.LocDescripcion = dr["LOC_DESCRIPCION"].ToString();
                    oObjeto.TloCodigo = dr["TLO_CODIGO"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            //public DataTable LocalidadesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
            //{
            //    try
            //    {
            //        DataTable DTPartes;
            //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "LocalidadesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

