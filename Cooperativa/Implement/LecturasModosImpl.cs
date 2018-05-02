using Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace Implement
{
    public class LecturasModosImpl
    {
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;


        public long LecturasModosAdd(LecturasModos oLC)
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
                   "insert into LECTURAS_MODOS(LEM_CODIGO, LEM_DESCRIPCION, " +
                           "SRV_CODIGO, LEM_FECHA_ALTA,EST_CODIGO, USR_CODIGO) " +
                           "values(IDTEMP,'" + oLC.lemDescripcion + "','" + oLC.srvCodigo + "','" +
                           oLC.lemFechaCarga.ToShortDateString() + "','" + oLC.estCodigo + "'," + oLC.usrCodigo + ")" + "RETURNING IDTEMP INTO :id;END;";



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
          //      grdGrillaEdit
                foreach (LecturasConceptos oLcAux in oLC.conceptos)
                {
                    CargarLecturasModosConceptos(response, oLcAux.LecCodigo);
                }
                cn.Close();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    /*    public List<LecturasConceptos> LecturasConceptosDeModoById(long id)
        {
            List<LecturasConceptos> lstLecturasConceptos = new List<LecturasConceptos>();
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                //SE RECUPERA LA REFERENCIA DE LAS LECTURAS MODOS Y LECTUAS CONCEPTOS
                string sqlSelect = "select * from LECTURAS_MODOS_CONCEPTOS WHERE LEM_CODIGO = '"+id+"'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                //ACA YA SE EJECUTO LA QUERY Y SE TIENEN LOS RESULTADOS
                adapter.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    LecturasConceptosImpl oLcb = new LecturasConceptosImpl();
                    for (int i = 0; dt.Rows.Count > i; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        LecturasConceptos NewEnt = new LecturasConceptos();
                        NewEnt = oLcb.LecturasConceptosGetById(long.Parse(dr["LEC_CODIGO"].ToString()));
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
        */
        public bool LecturasModosUpdate(LecturasModos oLC)
        {
            try
            {
                borrarReferencias(oLC.lemCodigo);
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string query = "update LECTURAS_MODOS " +
                    "SET LEM_DESCRIPCION='" + oLC.lemDescripcion + "', " +
                    "LEM_FECHA_ALTA='" + oLC.lemFechaCarga.ToShortDateString() + "', " +                 
                    "USR_CODIGO=" + oLC.usrCodigo + ", " +
                    "SRV_CODIGO=" + oLC.srvCodigo + ", " +
                    "EST_CODIGO='" + oLC.estCodigo + "' " +
                    "WHERE LEM_CODIGO=" + oLC.lemCodigo;
                cmd = new OracleCommand(query, cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();

                foreach (LecturasConceptos oLcAux in oLC.conceptos)
                {
                    CargarLecturasModosConceptos(oLC.lemCodigo, oLcAux.LecCodigo);
                }
                cn.Close();
                return response > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool LecturasModosDelete(long Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE LECTURAS_MODOS " +
                    "WHERE LEM_CODIGO='" + Id + "'", cn);
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

        public LecturasModos LecturasModosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from LECTURAS_MODOS " +
                    "WHERE LEM_CODIGO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                LecturasModos NewEnt = new LecturasModos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarLecturasModos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LecturasModosGetAllDT()
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from LECTURAS_MODOS";
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

        public List<LecturasModos> LecturasModosGetAll()
        {
            List<LecturasModos> lstLecturasConceptos = new List<LecturasModos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from LECTURAS_MODOS";
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
                        LecturasModos NewEnt = new LecturasModos();
                        NewEnt = CargarLecturasModos(dr);
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

        private LecturasModos CargarLecturasModos(DataRow dr)
        {
            try
            {
                LecturasModos oObjeto = new LecturasModos();
                oObjeto.lemCodigo = long.Parse(dr["LEM_CODIGO"].ToString());
                oObjeto.lemDescripcion = dr["LEM_DESCRIPCION"].ToString();
                oObjeto.srvCodigo = dr["SRV_CODIGO"].ToString();
                if (dr["LEM_FECHA_ALTA"].ToString() != "")
                    oObjeto.lemFechaCarga = DateTime.Parse(dr["LEM_FECHA_ALTA"].ToString());
                oObjeto.estCodigo = dr["EST_CODIGO"].ToString();
                oObjeto.usrCodigo = int.Parse(dr["USR_CODIGO"].ToString());
                CargarConceptos(oObjeto);
                if(oObjeto.conceptos == null)
                {
                    oObjeto.conceptos = new List<LecturasConceptos>();
                }
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarConceptos(LecturasModos objeto)
        {
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from LECTURAS_MODOS_CONCEPTOS WHERE LEM_CODIGO = "+objeto.lemCodigo;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    //Esto se utiliza para poder recuperar las Lecturas conceptos que estan asociadas a estas lecturas modos
                    LecturasConceptosImpl oLCBus = new LecturasConceptosImpl() ;
                    if (objeto.conceptos == null)
                    {
                        objeto.conceptos = new List<LecturasConceptos>();
                    }

                    for (int i = 0; dt.Rows.Count > i; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        LecturasConceptos NewEnt = new LecturasConceptos();
                        long aux = long.Parse(dr["LEC_CODIGO"].ToString());
                        objeto.conceptos.Add(oLCBus.LecturasConceptosGetById(aux));          
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        private long CargarLecturasModosConceptos(long lemCodigo, long lecCodigo)
        {
            try
            {               
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string query = "insert into LECTURAS_MODOS_CONCEPTOS(LEM_CODIGO, LEC_CODIGO) " +
                           "values('" + lemCodigo + "','" + lecCodigo + "')";

                cmd = new OracleCommand(query, cn);
                adapter = new OracleDataAdapter(cmd);
  
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void borrarReferencias(long lemCodigo)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();

                string query = "DELETE LECTURAS_MODOS_CONCEPTOS WHERE LEM_CODIGO='" + lemCodigo + "'";
                cmd = new OracleCommand(query , cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
