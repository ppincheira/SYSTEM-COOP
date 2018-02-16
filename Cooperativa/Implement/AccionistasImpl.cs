using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
	public class AccionistasImpl
    {
        #region Accionistas methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long AccionistasAdd(Accionistas oAcc)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('ACC_NUMERO')) into IDTEMP from dual; " +
                    " INSERT INTO ACCIONISTAS(ACC_NUMERO,ACC_FECHA_ALTA,DIS_NUMERO, " +
                    " ACC_FECHA_BAJA, EST_CODIGO, EMP_NUMERO) " +
                    " VALUES(IDTEMP,'" + oAcc.AccFechaAlta.Value.ToString("dd/MM/yyyy") + "'," +
                    " " + oAcc.DisNumero + ", ";
                if (oAcc.AccFechaBaja == null)
                    query = query + "null,";
                else
                    query = query + ",'" + oAcc.AccFechaBaja.Value.ToString("dd/MM/yyyy") + "' , ";
                query = query +"'" +oAcc.EstCodigo + "', " + oAcc.EmpNumero + ") RETURNING IDTEMP INTO :id;" +
                    " END;";

                cmd = new OracleCommand(query, cn);
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
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool AccionistasUpdate(Accionistas oAcc)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Accionistas " +
                    "SET ACC_FECHA_ALTA='" + oAcc.AccFechaAlta.Value.ToString("dd/MM/yyyy") + "'," +
                    "DIS_NUMERO = " + oAcc.DisNumero + ", " +
                    "ACC_FECHA_BAJA = '" + oAcc.AccFechaBaja.Value.ToString("dd/MM/yyyy") + "', " +
                    "EST_CODIGO = '" + oAcc.EstCodigo + "', " +
                    "EMP_NUMERO = " + oAcc.EmpNumero + 
                    "WHERE ACC_NUMERO=" + oAcc.AccNumero , cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
				return response > 0;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool AccionistasDelete(long Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Accionistas " +
                        "WHERE ACC_NUMERO=" + Id.ToString(), cn);
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

        public Accionistas AccionistasGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM ACCIONISTAS " +
                    "WHERE EMP_NUMERO=" +Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Accionistas NewEnt = new Accionistas();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarAccionistas(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}



        public Accionistas AccionistasGetByEmpNumero(long EmpNumero)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Accionistas " +
                    "WHERE EMP_NUMERO=" + EmpNumero;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Accionistas NewEnt = new Accionistas();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarAccionistas(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Accionistas> AccionistasGetAll()
		{
            List<Accionistas> lstAccionistas = new List<Accionistas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Accionistas ";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt = new DataTable() ;
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                  for (int i = 0; dt.Rows.Count > i; i++)
                  {
                            DataRow dr = dt.Rows[i];
                            Accionistas NewEnt = new Accionistas();
                            NewEnt = CargarAccionistas(dr);
                            lstAccionistas.Add(NewEnt);
                  }
                }
                return lstAccionistas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private Accionistas CargarAccionistas(DataRow dr)
		{
			try
			{
                Accionistas oObjeto = new Accionistas();
                oObjeto.AccNumero = long.Parse(dr["ACC_NUMERO"].ToString());
                if (dr["ACC_FECHA_ALTA"].ToString() != "")
                    oObjeto.AccFechaAlta = DateTime.Parse(dr["ACC_FECHA_ALTA"].ToString());
                oObjeto.DisNumero = long.Parse(dr["DIS_NUMERO"].ToString());
                if (dr["ACC_FECHA_BAJA"].ToString() != "")
                    oObjeto.AccFechaBaja = DateTime.Parse(dr["ACC_FECHA_BAJA"].ToString());
                oObjeto.EstCodigo = dr["EST_CODIGO"].ToString();
                oObjeto.EmpNumero = long.Parse(dr["EMP_NUMERO"].ToString());
				return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
      
        //public DataTable AccionistasGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "AccionistasGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
