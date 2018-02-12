
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
	public class DomiciliosEntidadesImpl
    {
        #region DomiciliosEntidades methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;
        public long DomiciliosEntidadesAdd(DomiciliosEntidades oDEn)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('DEN_NUMERO')) into IDTEMP from dual; " +
                    "INSERT INTO DOMICILIOS_ENTIDADES(DEN_NUMERO,TDO_CODIGO,DEN_CODIGO_REGISTRO, TAB_CODIGO, " +
                    "DOM_CODIGO, DEN_DEFECTO) " +
                    " VALUES(IDTEMP,'" + oDEn.TdoCodigo + "'," +oDEn.DenCodigoRegistro+ ", '" + oDEn.TabCodigo+ "',"+
                    oDEn.DomCodigo + ", '" + oDEn.DenDefecto + "') RETURNING IDTEMP INTO :id;" +
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

        public bool DomiciliosEntidadesUpdate(DomiciliosEntidades oDEn)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Domicilios_Entidades " +
                    "SET TDO_CODIGO='" + oDEn.TdoCodigo + "'," +
                    "DEN_CODIGO_REGISTRO=" + oDEn.DenCodigoRegistro + "," +
                    "TAB_CODIGO='" + oDEn.TabCodigo + "'," +
                    "DOM_CODIGO="+oDEn.DomCodigo +" ,"+
                    "DEN_DEFECTO='"+oDEn.DenDefecto+"'"+
                    " WHERE DEN_NUMERO=" + oDEn.DenNumero, cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
				return (response > 0);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool DomiciliosEntidadesDelete(long Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Domicilios_Entidades " +
                         "WHERE DEN_NUMERO=" + Id.ToString(),cn);
                    adapter = new OracleDataAdapter(cmd);
                    response = cmd.ExecuteNonQuery();
                    cn.Close();
                    return (response > 0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
		}

        public DomiciliosEntidades DomiciliosEntidadesGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Domicilios_Entidades " +
                    "WHERE DEN_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                DomiciliosEntidades NewEnt = new DomiciliosEntidades();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarDomiciliosEntidades(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DomiciliosEntidades DomiciliosEntidadesGetByDomCodigo(long DomCodigo)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Domicilios_Entidades " +
                    "WHERE DOM_CODIGO=" + DomCodigo.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                DomiciliosEntidades NewEnt = new DomiciliosEntidades();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarDomiciliosEntidades(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DomiciliosEntidades> DomiciliosEntidadesGetAll()
		{
            List<DomiciliosEntidades> lstDomiciliosEntidades = new List<DomiciliosEntidades>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Domicilios_Entidades ";
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
                            DomiciliosEntidades NewEnt = new DomiciliosEntidades();
                            NewEnt = CargarDomiciliosEntidades(dr);
                            lstDomiciliosEntidades.Add(NewEnt);
                  }
                }
                return lstDomiciliosEntidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private DomiciliosEntidades CargarDomiciliosEntidades(DataRow dr)
		{
			try
			{
                DomiciliosEntidades oObjeto = new DomiciliosEntidades();
                oObjeto.DenNumero = long.Parse(dr["DEN_NUMERO"].ToString());
                oObjeto.TdoCodigo = dr["TDO_CODIGO"].ToString();
                oObjeto.DenCodigoRegistro = long.Parse(dr["DEN_CODIGO_REGISTRO"].ToString());
                oObjeto.TabCodigo = dr["TAB_CODIGO"].ToString();
                oObjeto.DomCodigo= long.Parse(dr["DOM_CODIGO"].ToString());
                oObjeto.DenDefecto = dr["DEN_DEFECTO"].ToString();
                return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		#endregion

	}
}
