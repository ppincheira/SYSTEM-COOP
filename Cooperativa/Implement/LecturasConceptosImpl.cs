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
    public class LecturasConceptosImpl
    {
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;

        public long LecturasConceptosAdd(LecturasConceptos oLC)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();

                string query = " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('LEC_CODIGO')) into IDTEMP from dual; " +
                    "insert into LECTURAS_CONCEPTOS(LEC_CODIGO, LEC_DESCRIPCION, " +
                            "LEC_DESCRIPCION_CORTA, LEC_FECHA_ALTA,EST_CODIGO, USR_CODIGO) " +
                            "values(IDTEMP,'" + oLC.LecDescripcion + "','" + oLC.LecDescripcionCorta + "','" +
                            oLC.LecFechaAlta.ToShortDateString() + "','" + oLC.EstCodigo + "'," + oLC.UsrCodigo + ")" + "RETURNING IDTEMP INTO :id;END;";

                cmd = new OracleCommand(query, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });
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

        public bool LecturasConceptosUpdate(LecturasConceptos oLC)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string query = "update LECTURAS_CONCEPTOS " +
                    "SET LEC_DESCRIPCION='" + oLC.LecDescripcion + "', " +
                    "LEC_DESCRIPCION_CORTA='" + oLC.LecDescripcionCorta + "', " +
                    "LEC_FECHA_ALTA='" + oLC.LecFechaAlta.ToShortDateString() + "', " +
                    "USR_CODIGo=" + oLC.UsrCodigo + ", " +
                    "EST_CODIGO='" + oLC.EstCodigo + "' " +
                    "WHERE LEC_CODIGO=" + oLC.LecCodigo;

                cmd = new OracleCommand(query, cn);
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

        /*
               * Este metodo fue creado para poder implementar Modos Lecturas, 
               * en el cual en la variable string se pasa el texto que se tiene que buscar 
               * y  en la variable int se controla si se tiene que buscar por:
               * caso 0: Numero
               * caso 1: Descripcion corta
               * caso 2: descripcion
               * Retorna una Lista ya que puede llegar a traer mas de un resultado 
              */
        public List<LecturasConceptos> RecuperarLecturasConceptos(string texto, int posicion)
        {
            List<LecturasConceptos> lstLecturasConceptos = new List<LecturasConceptos>();
            try
            {
                string variable = "";
                switch (posicion)
                {
                    case 0: variable = "LEC_CODIGO";
                        break;
                    case 1: variable = "LEC_DESCRIPCION_CORTA";
                        break;
                    case 2: variable = "LEC_DESCRIPCION";
                        break;
                }

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from LECTURAS_CONCEPTOS WHERE "+variable+" = '"+texto.ToUpper()+ "'";
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
                        LecturasConceptos NewEnt = new LecturasConceptos();
                        NewEnt = CargarLecturasConceptos(dr);
                        lstLecturasConceptos.Add(NewEnt);
                    }
                }
                return lstLecturasConceptos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool LecturasConceptosDelete(string Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE LECTURAS_CONCEPTOS " +
                    "WHERE LEC_CODIGO='" + Id + "'", cn);
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

        public LecturasConceptos LecturasConceptosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from LECTURAS_CONCEPTOS " +
                    "WHERE LEC_CODIGO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                LecturasConceptos NewEnt = new LecturasConceptos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarLecturasConceptos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        public DataTable LecturasConceptosGetAllDT()
        {
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from LECTURAS_CONCEPTOS ";
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

        public List<LecturasConceptos> LecturasConceptosGetAll()
        {
            List<LecturasConceptos> lstLecturasConceptos = new List<LecturasConceptos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from LECTURAS_CONCEPTOS ";
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
                        LecturasConceptos NewEnt = new LecturasConceptos();
                        NewEnt = CargarLecturasConceptos(dr);
                        lstLecturasConceptos.Add(NewEnt);
                    }
                }
                return lstLecturasConceptos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private LecturasConceptos CargarLecturasConceptos(DataRow dr)
        {
            try
            {
                LecturasConceptos oObjeto = new LecturasConceptos();
                oObjeto.LecCodigo = long.Parse(dr["LEC_CODIGO"].ToString());
                oObjeto.LecDescripcion = dr["LEC_DESCRIPCION"].ToString();
                oObjeto.LecDescripcionCorta = dr["LEC_DESCRIPCION_CORTA"].ToString();
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                if (dr["LEC_FECHA_ALTA"].ToString() != "")
                    oObjeto.LecFechaAlta = DateTime.Parse(dr["LEC_FECHA_ALTA"].ToString());

                oObjeto.UsrCodigo = int.Parse(dr["USR_CODIGO"].ToString());
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

}
