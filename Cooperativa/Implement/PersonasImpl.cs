
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class PersonasImpl
    {
        #region Personas methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        private string sql;

        public long PersonasAdd(Personas oPersona)
        {
            try
            {


                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia PRS_NUMERO
                ds = new DataSet();
                string query =
                    " DECLARE IDTEMP NUMBER(10,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('PRS_NUMERO')) into IDTEMP from dual; " +                    
                    " insert into Personas( PRS_NUMERO," +
                                        " PRS_APELLIDO, " +
                                        " PRS_NOMBRE," +
                                        " PRS_ESTADO_CIVIL," +
                                        " TID_CODIGO, " +
                                        " PRS_DOCUMENTO_NUMERO, " +
                                        " PRS_SEXO, " +
                                        " PRS_FECHA_NACIMIENTO, " +
                                        " LOC_NUMERO_NACIMIENTO, " +
                                        " PRS_FECHA_INGRESO, " +
                                        " PRS_FECHA_BAJA, " +
                                        " EST_CODIGO, " +
                                        " PRS_MOTIVO_BAJA, " +
                                        " PRS_LEGAJO, " +
                                        " PRS_CUIL, " +
                                        " PRS_CARGO) " +
                            "      values(IDTEMP,' "
                                        + oPersona.PrsApellido + "', '"
                                        + oPersona.PrsNombre + "', '"
                                        + oPersona.PrsEstadoCivil + "', '"
                                        + oPersona.PrsTipoDoc + "', '"
                                        + oPersona.PrsNumeroDoc + "', '"
                                        + oPersona.PrsSexo + "', "
                                        + "TO_DATE('" + oPersona.PrsFechaNacimiento + "', 'DD/MM/YYYY HH24:MI:SS'), '"
                                        + oPersona.LocNumeroNacimiento + "', "
                                        + "TO_DATE('" + oPersona.PrsFechaIngreso + "', 'DD/MM/YYYY HH24:MI:SS'), "
                                        + "TO_DATE('" + oPersona.PrsFechaBaja + "', 'DD/MM/YYYY HH24:MI:SS'), '"
                                        + oPersona.EstCodigo + "', '"
                                        + oPersona.PrsMotivoBaja + "', '"
                                        + oPersona.PrsLegajo + "', '"
                                        + oPersona.PrsCuil + "', '"
                                        + oPersona.PrsCargo + "') " +
                    " RETURNING IDTEMP INTO :id;" +
                    " END;";
                Console.WriteLine("query " + query);
                cmd = new OracleCommand(query, cn);
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


                //Conexion oConexion = new Conexion();
                //OracleConnection cn = oConexion.getConexion();
                //cn.Open();
                //// Clave Secuencia PRS_NUMERO
                //ds = new DataSet();
                //sql = "insert into Personas( PRS_NUMERO," +
                //                            " PRS_APELLIDO, " +
                //                            " PRS_NOMBRE," +
                //                            " PRS_ESTADO_CIVIL," +
                //                            " TID_CODIGO, " +
                //                            " PRS_DOCUMENTO_NUMERO, " +
                //                            " PRS_SEXO, " +
                //                            " PRS_FECHA_NACIMIENTO, " +
                //                            " LOC_NUMERO_NACIMIENTO, " +
                //                            " PRS_FECHA_INGRESO, " +
                //                            " PRS_FECHA_BAJA, " +
                //                            " EST_CODIGO, " +
                //                            " PRS_MOTIVO_BAJA, " +
                //                            " PRS_LEGAJO, " +
                //                            " PRS_CUIL, " +
                //                            " PRS_CARGO) " +
                //                "values(pkg_secuencias.fnc_prox_secuencia('PRS_NUMERO'),' " 
                //                            + oPersona.PrsApellido + "', '"
                //                            + oPersona.PrsNombre + "', '"
                //                            + oPersona.PrsEstadoCivil + "', '"
                //                            + oPersona.PrsTipoDoc + "', '"
                //                            + oPersona.PrsNumeroDoc + "', '"
                //                            + oPersona.PrsSexo + "', "
                //                            + "TO_DATE('" + oPersona.PrsFechaNacimiento + "', 'DD/MM/YYYY HH24:MI:SS'), '"
                //                            + oPersona.LocNumeroNacimiento + "', "
                //                            + "TO_DATE('" + oPersona.PrsFechaIngreso + "', 'DD/MM/YYYY HH24:MI:SS'), "
                //                            + "TO_DATE('" + oPersona.PrsFechaBaja + "', 'DD/MM/YYYY HH24:MI:SS'), '"
                //                            + oPersona.EstCodigo + "', '"
                //                            + oPersona.PrsMotivoBaja + "', '"
                //                            + oPersona.PrsLegajo + "', '"
                //                            + oPersona.PrsCuil + "', '"
                //                            + oPersona.PrsCargo + "')";
                //Console.WriteLine("sql");
                //Console.WriteLine("sql  " + sql);
                //Console.WriteLine("sql");
                //cmd = new OracleCommand(sql, cn);
                //adapter = new OracleDataAdapter(cmd);
                //response = cmd.ExecuteNonQuery();
                //cn.Close();
                //return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PersonasUpdate(Personas oPersona)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                sql = "update Personas SET " +
                                "PRS_APELLIDO='" + oPersona.PrsApellido + "'," +
                                "PRS_NOMBRE='" + oPersona.PrsNombre + "'," +
                                "PRS_ESTADO_CIVIL='" + oPersona.PrsEstadoCivil + "'," +
                                "TID_CODIGO='" + oPersona.PrsTipoDoc + "'," +
                                "PRS_DOCUMENTO_NUMERO='" + oPersona.PrsNumeroDoc + "'," +
                                "PRS_SEXO='" + oPersona.PrsSexo + "'," +
                                "PRS_FECHA_NACIMIENTO=TO_DATE('" + oPersona.PrsFechaNacimiento + "', 'DD/MM/YYYY HH24:MI:SS'), " +
                                "LOC_NUMERO_NACIMIENTO='" + oPersona.LocNumeroNacimiento + "', " +
                                "PRS_FECHA_INGRESO=TO_DATE('" + oPersona.PrsFechaIngreso + "', 'DD/MM/YYYY HH24:MI:SS'), " +
                                "PRS_FECHA_BAJA=TO_DATE('" + oPersona.PrsFechaBaja + "', 'DD/MM/YYYY HH24:MI:SS'), " +
                                "EST_CODIGO='" + oPersona.EstCodigo + "'," +
                                "PRS_MOTIVO_BAJA='" + oPersona.PrsMotivoBaja + "'," +
                                "PRS_LEGAJO='" + oPersona.PrsLegajo + "', " +
                                "PRS_CUIL='" + oPersona.PrsCuil + "'," +
                                "PRS_CARGO='" + oPersona.PrsCargo + "' " +
                        "WHERE PRS_NUMERO='" + oPersona.PrsNumero + "' ";
                Console.WriteLine("sql");
                Console.WriteLine("sql  " + sql);
                Console.WriteLine("sql");
                cmd = new OracleCommand(sql, cn);
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

        public bool PersonasDelete(int Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE Personas " +
                                        "WHERE PRS_NUMERO=" + Id.ToString(), cn);
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

        public Personas PersonasGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM personas " +
                                   "WHERE prs_numero=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Personas NewEnt = new Personas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarPersonas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Personas> PersonasGetAll()
        {
            List<Personas> lstPersonas = new List<Personas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Personas ";
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
                        Personas NewEnt = new Personas();
                        NewEnt = CargarPersonas(dr);
                        lstPersonas.Add(NewEnt);
                    }
                }
                return lstPersonas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Personas CargarPersonas(DataRow dr)
        {
            try
            {
                Personas oObjeto = new Personas();
                oObjeto.PrsNumero = int.Parse(dr["PRS_NUMERO"].ToString());
                oObjeto.PrsApellido = dr["PRS_APELLIDO"].ToString();
                oObjeto.PrsNombre = dr["PRS_NOMBRE"].ToString();
                oObjeto.PrsEstadoCivil = dr["PRS_ESTADO_CIVIL"].ToString();
                oObjeto.PrsTipoDoc = dr["TID_CODIGO"].ToString();
                oObjeto.PrsNumeroDoc = dr["PRS_DOCUMENTO_NUMERO"].ToString();                
                oObjeto.PrsSexo = dr["PRS_SEXO"].ToString();
                if (dr["PRS_FECHA_NACIMIENTO"].ToString() != "")
                    oObjeto.PrsFechaNacimiento = DateTime.Parse(dr["PRS_FECHA_NACIMIENTO"].ToString());
                if (dr["LOC_NUMERO_NACIMIENTO"].ToString() != "")
                    oObjeto.LocNumeroNacimiento = int.Parse(dr["LOC_NUMERO_NACIMIENTO"].ToString());
                if (dr["PRS_FECHA_INGRESO"].ToString() != "")
                    oObjeto.PrsFechaIngreso = DateTime.Parse(dr["PRS_FECHA_INGRESO"].ToString());
                if (dr["PRS_FECHA_BAJA"].ToString() != "")
                    oObjeto.PrsFechaBaja = DateTime.Parse(dr["PRS_FECHA_BAJA"].ToString());
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                if (dr["PRS_MOTIVO_BAJA"].ToString() != "")
                    oObjeto.PrsMotivoBaja = dr["PRS_MOTIVO_BAJA"].ToString();
                if (dr["PRS_LEGAJO"].ToString() != "")
                    oObjeto.PrsLegajo = dr["PRS_LEGAJO"].ToString();
                if (dr["PRS_CUIL"].ToString() != "")
                    oObjeto.PrsCuil = dr["PRS_CUIL"].ToString();
                if (dr["PRS_CARGO"].ToString() != "")
                    oObjeto.PrsCargo = dr["PRS_CARGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable PersonasGetByFilter()
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT prs_numero, " +
                                   "        prs_apellido||' '||prs_nombre prs_descripcion " +
                                   " FROM   personas  " +
                                   " ORDER BY prs_descripcion ";

                Console.WriteLine("sql");
                Console.WriteLine("--" + sqlSelect);
                Console.WriteLine("sql");

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

        //public DataTable PersonasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "PersonasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
