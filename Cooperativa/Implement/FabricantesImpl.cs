
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class FabricantesImpl
        {
        #region Fabricantes methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private long response;
            public long FabricantesAdd(Fabricantes oFab)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave Secuencia FAB_NUMERO
                    ds = new DataSet();

                string query = " DECLARE IDTEMP NUMBER(10,0); " +
                " BEGIN " +
                " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('FAB_NUMERO')) into IDTEMP from dual; " +
                "insert into Fabricantes (FAB_NUMERO,FAB_DESCRIPCION, " +
                    "EST_CODIGO, USR_NUMERO, FAB_FECHA_CARGA) " +
                    "values(IDTEMP,'" + oFab.FabDescripcion + "','" + oFab.FabHabilitado +
                     "'," + oFab.UsrNumero + ",'" + oFab.FabFechaCarga.ToShortDateString() + "')RETURNING IDTEMP INTO :id;END;";

                /*
                ACA ESTARIA LA IMPLEMENTACION PARA CUANDO SE ULTILICE EL NUMERO DE LA EMPRESA

                string query = " DECLARE IDTEMP NUMBER(10,0); " +
                " BEGIN " +
                " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('FAB_NUMERO')) into IDTEMP from dual; " +
                "insert into Fabricantes (FAB_NUMERO,FAB_DESCRIPCION, " +
                    "EST_CODIGO, EMP_NUMERO, USR_NUMERO, FAB_FECHA_CARGA) " +
                    "values(IDTEMP,'" + oFab.FabDescripcion + "','" + oFab.FabHabilitado + "'," +
                    oFab.EmpNumero + "," + oFab.UsrNumero + ",'" + oFab.FabFechaCarga.ToShortDateString() + "')RETURNING IDTEMP INTO :id;END;";
                 */


                cmd = new OracleCommand(query,cn);
                adapter = new OracleDataAdapter(cmd);


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

            public bool FabricantesUpdate(Fabricantes oFab)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand(
                        "update Fabricantes " +
                        "SET FAB_DESCRIPCION='" + oFab.FabDescripcion +
                        "', EST_CODIGO='" + oFab.FabHabilitado +
                        //"', EMP_NUMERO='" + oFab.EmpNumero +
                        "', USR_NUMERO='" + oFab.UsrNumero +
                        "', FAB_FECHA_CARGA='" + oFab.FabFechaCarga.ToShortDateString() +
                        "' WHERE FAB_NUMERO=" + oFab.FabNumero  , cn);
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

            public bool FabricantesDelete(int Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Fabricantes " +
                        "WHERE FAB_NUMERO=" + Id, cn);
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

            public Fabricantes FabricantesGetById(long Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Fabricantes " +
                         "WHERE FAB_NUMERO=" + Id;
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Fabricantes NewEnt = new Fabricantes();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarFabricantes(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Fabricantes> FabricantesGetAll()
            {
                List<Fabricantes> lstFabricantes = new List<Fabricantes>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Fabricantes ";
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
                            Fabricantes NewEnt = new Fabricantes();
                            NewEnt = CargarFabricantes(dr);
                            lstFabricantes.Add(NewEnt);
                        }
                    }
                    return lstFabricantes;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public DataTable FabricantesGetAllDT()
            {
                List<Fabricantes> lstFabricantes = new List<Fabricantes>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Fabricantes ";
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

            private Fabricantes CargarFabricantes(DataRow dr)
            {
                try
                {
                    Fabricantes oObjeto = new Fabricantes();
                    oObjeto.FabNumero = int.Parse(dr["FAB_NUMERO"].ToString());
                    oObjeto.FabDescripcion = dr["FAB_DESCRIPCION"].ToString();
                    oObjeto.FabHabilitado = dr["EST_CODIGO"].ToString();
                    if(dr["EMP_NUMERO"].ToString() != "")
                    oObjeto.EmpNumero = long.Parse(dr["EMP_NUMERO"].ToString());

                    oObjeto.UsrNumero = int.Parse(dr["USR_NUMERO"].ToString());
                    oObjeto.FabFechaCarga = DateTime.Parse(dr["FAB_FECHA_CARGA"].ToString());
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        //public DataTable FabricantesGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "FabricantesGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

