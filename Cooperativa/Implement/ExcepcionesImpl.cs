
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
    public class ExcepcionesImpl
    {
        #region Excepciones methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        private string sql;

        public int ExcepcionesAdd(Excepciones oExcepciones)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();

                ds = new DataSet();

                sql = "INSERT INTO excepciones(exc_numero, " +
                                              "exc_fecha, " +
                                              "exc_nombre_excepcion, " +
                                              "exc_nombre_evento, " +
                                              "exc_nombre_control, " +
                                              "exc_nombre_formulario, " +
                                              "usr_numero, " +
                                              "sbs_codigo, " +
                                              "ter_numero, " +
                                              "exc_descripcion) " +
                                      "VALUES( pkg_secuencias.fnc_prox_secuencia('EXC_NUMERO'), " +
                                              "TO_DATE('" + oExcepciones.ExcFecha + "', 'DD/MM/YYYY HH24:MI:SS'), " +
                                              "'" + oExcepciones.ExcNombreExcepcion + "', " +
                                              "'" + oExcepciones.ExcNombreEvento + "', " +
                                              "'" + oExcepciones.ExcNombreControl + "', " +
                                              "'" + oExcepciones.ExcNombreFormulario + "', " +
                                              "'" + oExcepciones.UsrNumero + "', " +
                                              "'" + oExcepciones.SbsCodigo + "', " +
                                              "'" + oExcepciones.TerNumero + "', " +
                                              "'" + oExcepciones.ExcDescripcion + "')";
                Console.WriteLine("sql");
                Console.WriteLine("sql  " + sql);
                Console.WriteLine("sql");
                cmd = new OracleCommand(sql, cn);

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

        public bool ExcepcionesUpdate(Excepciones oExcepciones)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("UPDATE  excepciones SET " +
                                                "exc_fecha= TO_DATE('" + oExcepciones.ExcFecha + "', 'DD/MM/YYYY HH24:MI:SS'), " +
                                                "exp_nombre_excepcion='" + oExcepciones.ExcNombreExcepcion + "'," +
                                                "exp_nombre_evento='" + oExcepciones.ExcNombreEvento + "'," +
                                                "exp_nombre_control='" + oExcepciones.ExcNombreControl + "'," +
                                                "exp_nombre_formulario='" + oExcepciones.ExcNombreFormulario + "'," +
                                                "usr_numero='" + oExcepciones.UsrNumero + "'," +
                                                "sbs_codigo='" + oExcepciones.SbsCodigo + "'," +
                                                "ter_numero='" + oExcepciones.TerNumero + "', " +
                                                "exc_descripcion='" + oExcepciones.ExcDescripcion + "' " +
                                        "WHERE   exc_numero='" + oExcepciones.ExcNumero + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExcepcionesDelete(String Id)
        {


            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE FROM excepciones " +
                                        "WHERE  exc_numero='" + Id + "'", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public Excepciones ExcepcionesGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT * " +
                                   " FROM   excepciones " +
                                   " WHERE  exc_numero= '" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Excepciones NewEnt = new Excepciones();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarExcepciones(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Excepciones> ExcepcionesGetAll()
        {
            List<Excepciones> lstExcepciones = new List<Excepciones>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * " +
                                   "FROM   excepciones ";
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
                        Excepciones NewEnt = new Excepciones();
                        NewEnt = CargarExcepciones(dr);
                        lstExcepciones.Add(NewEnt);
                    }
                }
                return lstExcepciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Excepciones CargarExcepciones(DataRow dr)
        {
            try
            {
                Excepciones oObjeto = new Excepciones();
                oObjeto.ExcNumero = int.Parse(dr["exc_numero"].ToString());
                if (dr["exc_fecha"].ToString() != "")
                    oObjeto.ExcFecha = DateTime.Parse(dr["exc_fecha"].ToString());
                oObjeto.ExcNombreExcepcion = dr["exp_nombre_excepcion"].ToString();
                oObjeto.ExcNombreEvento = dr["exp_nombre_evento"].ToString();
                oObjeto.ExcNombreControl = dr["exp_nombre_control"].ToString();
                oObjeto.ExcNombreFormulario = dr["exp_nombre_formulario"].ToString();
                oObjeto.UsrNumero = int.Parse(dr["usr_numero"].ToString());
                oObjeto.SbsCodigo = dr["sbs_codigo"].ToString();
                oObjeto.TerNumero = int.Parse(dr["ter_numero"].ToString());
                oObjeto.ExcDescripcion = dr["exc_descripcion"].ToString();

                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


    }
}
