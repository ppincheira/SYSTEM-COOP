
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;
namespace Implement
{
    public class TelefonosImpl
    {
        #region Telefonos methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;

        public int TelefonosAdd(Telefonos oTel)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string sqlSelect = "INSERT INTO telefonos (tel_codigo, " +
                                                          "tel_numero, " +
                                                          "tel_cargo, " +
                                                          "tel_tipo, " +
                                                          "tel_defecto," +
                                                          "tel_email," +
                                                          "tab_codigo," +
                                                          "tel_codigo_registro," +
                                                          "tel_nombre_contacto) " +
                                                  "VALUES (pkg_secuencias.fnc_prox_secuencia('TEL_CODIGO'),'" +
                                                           oTel.TelNumero + "','" +
                                                           oTel.TelCargo + "','" +
                                                           oTel.TelTipo + "','" +
                                                           oTel.TelDefecto + "','" +
                                                           oTel.TelEmail + "','" +
                                                           oTel.TabCodigo + "','" +
                                                           oTel.TelCodigoRegistro + "','" +
                                                           oTel.TelNombreContacto + "')";

                Console.WriteLine("sql");
                Console.WriteLine("--" + sqlSelect);
                Console.WriteLine("sql");

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);               
                response = cmd.ExecuteNonQuery();
                cn.Close();
                cmd.Dispose();
                cn.Dispose();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool TelefonosUpdate(Telefonos oTel)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string sqlSelect = "UPDATE telefonos SET " +
                                          "tel_numero='" + oTel.TelNumero + "', " +
                                          "tel_cargo='" + oTel.TelCargo + "', " +
                                          "tel_tipo='" + oTel.TelTipo + "', " +
                                          "tel_defecto='" + oTel.TelDefecto + "', " +
                                          "tel_email='" + oTel.TelEmail + "', " +
                                          "tab_codigo='" + oTel.TabCodigo + "', " +
                                          "tel_codigo_registro='" + oTel.TelCodigoRegistro + "', " +
                                          "tel_nombre_contacto='" + oTel.TelNombreContacto + "' " +
                                    "WHERE tel_codigo='" + oTel.TelCodigo + "'";

                Console.WriteLine("sql");
                Console.WriteLine("--" + sqlSelect);
                Console.WriteLine("sql");

                cmd = new OracleCommand(sqlSelect, cn);
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

        public bool TelefonosDelete(long Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string sqlSelect = "DELETE FROM  telefonos " +
                                          "WHERE tel_codigo='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
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

        public Telefonos TelefonosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * " +
                                   "FROM   telefonos " +
                                   "WHERE  tel_codigo ='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Telefonos NewEnt = new Telefonos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTelefonos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Telefonos TelefonosGetByCodigoRegistroDefecto(long CodigoRegistro, string TabCodigo, Enumeration.TelefonosTipos Tipo)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT * " +
                                   " FROM   telefonos " +
                                   " WHERE  TAB_CODIGO ='" + TabCodigo + "' " +
                                   " AND TEL_CODIGO_REGISTRO=" + CodigoRegistro + " " +
                                   " AND TEL_DEFECTO='S'";
               if (Tipo == Enumeration.TelefonosTipos.Telefono)
                                   sqlSelect = sqlSelect + " AND  TEL_EMAIL IS NULL " +
                                   " AND TEL_NUMERO IS NOT NULL ";
               else
                    sqlSelect = sqlSelect + " AND  TEL_EMAIL IS NOT NULL " +
                                   " AND TEL_NUMERO IS NULL ";

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Telefonos NewEnt = new Telefonos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTelefonos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TelefonosGetByCodigoRegistroDT(long CodigoRegistro, string TabCodigo, Enumeration.TelefonosTipos Tipo)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT * " +
                                   " FROM   telefonos " +
                                   " WHERE  TAB_CODIGO ='" + TabCodigo + "' " +
                                   " AND TEL_CODIGO_REGISTRO=" + CodigoRegistro + " ";
                if (Tipo == Enumeration.TelefonosTipos.Telefono)
                    sqlSelect = sqlSelect + " AND  TEL_EMAIL IS NULL " +
                    " AND TEL_NUMERO IS NOT NULL ";
                else
                    sqlSelect = sqlSelect + " AND  TEL_EMAIL IS NOT NULL " +
                                   " AND TEL_NUMERO IS NULL ";

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Telefonos> TelefonosGetAll()
        {
            List<Telefonos> lstTelefonos = new List<Telefonos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * " +
                                   "FROM   telefonos ";
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
                        Telefonos NewEnt = new Telefonos();
                        NewEnt = CargarTelefonos(dr);
                        lstTelefonos.Add(NewEnt);
                    }
                }
                return lstTelefonos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Telefonos CargarTelefonos(DataRow dr)
        {
            try
            {
                Telefonos oObjeto = new Telefonos();
                oObjeto.TelCodigo = long.Parse(dr["tel_codigo"].ToString());
                oObjeto.TelNumero = dr["tel_numero"].ToString();                           
                oObjeto.TelCargo = dr["tel_cargo"].ToString();
                oObjeto.TelTipo = dr["tel_tipo"].ToString();
                oObjeto.TelDefecto = dr["tel_defecto"].ToString();
                oObjeto.TelEmail = dr["tel_email"].ToString();
                oObjeto.TabCodigo = dr["tab_codigo"].ToString();
                oObjeto.TelCodigoRegistro = dr["tel_codigo_registro"].ToString();
                oObjeto.TelNombreContacto = dr["tel_nombre_contacto"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TelefonosGetByFilter(string tabCodigo, string telCodigoRegistro)
        {

            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "  SELECT tel_codigo," +
                                   "         tel_numero," +
                                   "         pkg_general.fnc_obtener_dsp_dominio('CARGO_CONTACTO_TEL',tel_cargo) tel_cargo," +
                                   "         pkg_general.fnc_obtener_dsp_dominio('TIPO_TELEFONO',tel_tipo) tel_tipo," +
                                   "         tel_defecto," +
                                   "         tel_email," +
                                   "         tel_nombre_contacto," +                                 
                                   "         tel_codigo_registro," +
                                   "         tab_codigo" +
                                   "  FROM   telefonos  " +                                         
                                   "  WHERE  tab_codigo ='" + tabCodigo + "' " +                                   
                                   "  AND    tel_codigo_registro='" + telCodigoRegistro + "'";

                
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);


                DataTable dt;
                return dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
