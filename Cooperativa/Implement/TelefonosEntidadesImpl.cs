using Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement
{
    public class TelefonosEntidadesImpl
    {

        #region TelefonosEntidades methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;

        public int TelefonosEntidadesAdd(TelefonosEntidades oTelEntidad)
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
                                                  "VALUES (pkg_secuencias.fnc_prox_secuencia('TEL_CODIGO'),'";

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

        public bool TelefonosEntidadesUpdate(TelefonosEntidades oTelEntidad)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string sqlSelect = "UPDATE TELEFONOS_ENTIDADES SET " +
                                          "TEE_NUMERO='" + oTelEntidad.TeeNumero + "', " +
                                          "TTE_NUMERO='" + oTelEntidad.TteNumero + "', " +
                                          "TEL_CODIGO_REGISTRO='" + oTelEntidad.TelCodigoRegistro + "', " +
                                          "TEL_CODIGO='" + oTelEntidad.TelCodigo + "', " +
                                          "TAB_CODIGO='" + oTelEntidad.TabCodigo + "', " +
                                    "WHERE tel_codigo='" + oTelEntidad.TeeNumero + "'";

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

        public bool TelefonosEntidadesDelete(long Id)
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

        public TelefonosEntidades TelefonosEntidadesGetById(long Id)
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
                TelefonosEntidades NewEnt = new TelefonosEntidades();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTelefonosEntidades(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TelefonosEntidades> TelefonosEntidadesGetAll()
        {
            List<TelefonosEntidades> lstTelEntidades = new List<TelefonosEntidades>();
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
                        TelefonosEntidades NewEnt = new TelefonosEntidades();
                        NewEnt = CargarTelefonosEntidades(dr);
                        lstTelEntidades.Add(NewEnt);
                    }
                }
                return lstTelEntidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TelefonosEntidades CargarTelefonosEntidades(DataRow dr)
        {
            try
            {
                TelefonosEntidades oObjeto = new TelefonosEntidades();
                oObjeto.TeeNumero = long.Parse(dr["TEE_NUMERO"].ToString());
                oObjeto.TteNumero = dr["TTE_NUMERO"].ToString();
                oObjeto.TelCodigoRegistro = dr["TEL_CODIGO_REGISTRO"].ToString();
                oObjeto.TelCodigo = long.Parse(dr["TEL_CODIGO"].ToString());
                oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TelefonosEntidadesGetByFilter(string tabCodigo, string telCodigoRegistro)
        {

            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT tel_codigo," +
                                   "        tel_numero," +
                                   "        pkg_general.fnc_obtener_dsp_dominio('CARGO_CONTACTO_TEL',tel_cargo) tel_cargo," +
                                   "        pkg_general.fnc_obtener_dsp_dominio('TIPO_TELEFONO',tel_tipo) tel_tipo," +
                                   "        tel_defecto," +
                                   "        tel_email," +
                                   "        tel_nombre_contacto," +
                                   "        tel_codigo_registro," +
                                   "        tab_codigo" +
                                   " FROM   telefonos  " +
                                   " WHERE  tab_codigo ='" + tabCodigo + "' " +
                                   " AND    tel_codigo_registro='" + telCodigoRegistro + "'";

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
