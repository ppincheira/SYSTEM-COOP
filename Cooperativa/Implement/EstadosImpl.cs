
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class EstadosImpl
        {
        #region Estados methods

        private OracleDataAdapter adapter;
            private OracleCommand cmd;
            private DataSet ds;
            private int response;
            public int EstadosAdd(Estados oEst)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    // Clave ESTADO_DESCRIPCION 
                    ds = new DataSet();
                    cmd = new OracleCommand("insert into Estados (EST_CODIGO, " +
                        "EST_DESCRIPCION, EST_DESCRIPCION_CORTA, EST_ENTIDAD, EST_TIPO_DATO) " +
                        "values('" + oEst.EstCodigo + "','" + oEst.EstDescripcion + "','" +
                        oEst.EstDescripcionCorta + "','"+ oEst.EstEntidad  + "','"+ oEst.EstTipoDato+ "')", cn);
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

            public bool EstadosUpdate(Estados oEst)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("update Estados " +
                        "SET EST_CODIGO='" + oEst.EstCodigo +
                        "', EST_DESCRIPCION_CORTA='" + oEst.EstDescripcionCorta +
                        "', EST_ENTIDAD='" + oEst.EstEntidad +
                        "', EST_TIPO_DATO='" + oEst.EstTipoDato +
                        "' WHERE EST_DESCRIPCION=" + oEst.EstDescripcion , cn);
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

            public bool EstadosDelete(string Id)
            {
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Estados " +
                        "WHERE EST_DESCRIPCION=" + Id, cn);
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

            public Estados EstadosGetById(string Id)
            {
                try
                {
                    DataSet ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Estados " +
                         "WHERE EST_DESCRIPCION=" + Id;
                    cmd = new OracleCommand(sqlSelect, cn);
                    adapter = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    DataTable dt;
                    dt = ds.Tables[0];
                    Estados NewEnt = new Estados();
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        NewEnt = CargarEstados(dr);
                    }
                    return NewEnt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Estados> EstadosGetAll()
            {
                List<Estados> lstEstados = new List<Estados>();
                try
                {

                    ds = new DataSet();
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    string sqlSelect = "select * from Estados ";
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
                            Estados NewEnt = new Estados();
                            NewEnt = CargarEstados(dr);
                            lstEstados.Add(NewEnt);
                        }
                    }
                    return lstEstados;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private Estados CargarEstados(DataRow dr)
            {
                try
                {
                    Estados oObjeto = new Estados();
                    oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                    oObjeto.EstDescripcion = dr["EST_DESCRIPCION"].ToString();
                    oObjeto.EstDescripcionCorta = dr["EST_DESCRIPCION_CORTA"].ToString();
                    oObjeto.EstEntidad = dr["EST_ENTIDAD"].ToString();
                    oObjeto.EstTipoDato = dr["EST_TIPO_DATO"].ToString();
                    return oObjeto;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        public DataTable EstadosGetByFilterDT(string tabNombre, string estColumnaTabla)
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM ESTADOS " +
                " where  TAB_NOMBRE='" + tabNombre+"'"+
                " AND EST_COLUMNA_TABLA='"+ estColumnaTabla+"'";

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable EstadosGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "EstadosGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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

