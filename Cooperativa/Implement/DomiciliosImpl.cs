
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
	public class DomiciliosImpl
    {
        #region Domicilios methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;


        public long DomiciliosAdd(Domicilios oDom)
		{
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('DOM_CODIGO')) into IDTEMP from dual; " +
                    "INSERT INTO DOMICILIOS(DOM_CODIGO,LOC_NUMERO,BAR_NUMERO, CAL_NUMERO, " +
                    "CAL_NUMERO_DESDE, CAL_NUMERO_HASTA, DOM_NUMERO, DOM_BLOQUE, DOM_PISO, " +
                    "DOM_DEPARTAMENTO, DOM_PARCELA, CPL_NUMERO, DOM_LOTE, DOM_GIS_X, DOM_GIS_Y)"+
                    " VALUES(IDTEMP,"+oDom.LocNumero +","  +oDom.BarNumero+ ", " + oDom.CalNumero + ", " + oDom.CalNumeroDesde + ", " +
                    oDom.CalNumeroHasta + ", " + oDom.DomNumero + ", '" + oDom.DomBloque + "', '" +
                    oDom.DomPiso + "', '" + oDom.DomDepartamento + "', '" + oDom.DomParcela + "', " +
                    oDom.CplNumero + ", '" + oDom.DomLote + "', " + (oDom.DomGisX == null ? "null" : oDom.DomGisX.ToString()) + ", " + (oDom.DomGisY == null ? "null" : oDom.DomGisY.ToString()) + 
                     ") RETURNING IDTEMP INTO :id;" +
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
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public bool DomiciliosUpdate(Domicilios oDom)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Domicilios " +
                    "SET LOC_NUMERO=" + oDom.LocNumero + ", " +
                    "BAR_NUMERO="+oDom.BarNumero+ ", "+
                    "CAL_NUMERO=" + oDom.CalNumero + ", " +
                    "CAL_NUMERO_DESDE=" + oDom.CalNumeroDesde + ", " +
                    "CAL_NUMERO_HASTA=" + oDom.CalNumeroHasta + ", " +
                    "DOM_NUMERO=" + oDom.DomNumero + ", " +
                    "DOM_BLOQUE='" + oDom.DomBloque + "', " +
                    "DOM_PISO='" + oDom.DomPiso + "', " +
                    "DOM_DEPARTAMENTO='" + oDom.DomDepartamento + "', " +
                    "DOM_PARCELA='" + oDom.DomParcela + "', " +
                    "CPL_NUMERO=" + oDom.CplNumero + ", " +
                    "DOM_LOTE='" + oDom.DomLote + "', " +
                    "DOM_GIS_X=" + (oDom.DomGisX==null?"null": oDom.DomGisX.ToString() )+ ", " +
                    "DOM_GIS_Y=" +( oDom.DomGisY==null?"null":oDom.DomGisY.ToString() )+
                    " WHERE DOM_CODIGO=" + oDom.DomCodigo, cn);
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

        public bool DomiciliosDelete(long Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Domicilios " +
                         "WHERE DOM_CODIGO=" + Id.ToString(),cn);
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

        public Domicilios DomiciliosGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Domicilios " +
                    "WHERE DOM_CODIGO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Domicilios NewEnt = new Domicilios();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarDomicilios(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        /// <summary>
        ///Este metodo trae el Domicilio por Defecto 
        /// </summary>
        /// <param name="CodigoRegistro"></param>
        /// <param name="TabCodigo"></param>
        /// <returns></returns>
        public Domicilios DomiciliosGetByCodigoRegistroDefecto(long CodigoRegistro, string TabCodigo)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT D.* FROM DOMICILIOS D " +
                " INNER JOIN DOMICILIOS_ENTIDADES DE ON DE.DOM_CODIGO = D.DOM_CODIGO " +
                " WHERE DE.DEN_CODIGO_REGISTRO =" + CodigoRegistro +
                " AND DE.TAB_CODIGO = '" + TabCodigo+"' AND DE.DEN_DEFECTO = 'S' ";     
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Domicilios NewEnt = new Domicilios();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarDomicilios(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        ///Este metodo trae el Domicilio por Defecto 
        /// </summary>
        /// <param name="CodigoRegistro"></param>
        /// <param name="TabCodigo"></param>
        /// <returns></returns>
        public DataTable DomiciliosGetByCodigoRegistroDT(long CodigoRegistro, string TabCodigo)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = " SELECT D.* FROM DOMICILIOS D " +
                " INNER JOIN DOMICILIOS_ENTIDADES DE ON DE.DOM_CODIGO = D.DOM_CODIGO " +
                " WHERE DE.DEN_CODIGO_REGISTRO =" + CodigoRegistro +
                " AND DE.TAB_CODIGO = '" + TabCodigo + "'";
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

        public List<Domicilios> DomiciliosGetAll()
		{
            List<Domicilios> lstDomicilios = new List<Domicilios>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Domicilios ";
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
                            Domicilios NewEnt = new Domicilios();
                            NewEnt = CargarDomicilios(dr);
                            lstDomicilios.Add(NewEnt);
                  }
                }
                return lstDomicilios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private Domicilios CargarDomicilios(DataRow dr)
		{
			try
			{
                Domicilios oObjeto = new Domicilios();
                oObjeto.DomCodigo = long.Parse(dr["DOM_CODIGO"].ToString());
                oObjeto.LocNumero = int.Parse(dr["LOC_NUMERO"].ToString());
                oObjeto.BarNumero=long.Parse(dr["BAR_NUMERO"].ToString());
                oObjeto.CalNumero = long.Parse(dr["CAL_NUMERO"].ToString());
                oObjeto.CalNumeroDesde = long.Parse(dr["CAL_NUMERO_DESDE"].ToString());
                oObjeto.CalNumeroHasta = long.Parse(dr["CAL_NUMERO_HASTA"].ToString());
                oObjeto.DomNumero = int.Parse(dr["DOM_NUMERO"].ToString());
                oObjeto.DomBloque = dr["DOM_BLOQUE"].ToString();
                oObjeto.DomPiso = dr["DOM_PISO"].ToString();
                oObjeto.DomDepartamento = dr["DOM_DEPARTAMENTO"].ToString();
                oObjeto.DomParcela = dr["DOM_PARCELA"].ToString();
                if (dr["CPL_NUMERO"].ToString() != "")
                    oObjeto.CplNumero = long.Parse(dr["CPL_NUMERO"].ToString());
                oObjeto.DomLote = dr["DOM_LOTE"].ToString();
                if (dr["DOM_GIS_X"].ToString() != "")
                    oObjeto.DomGisX = decimal.Parse(dr["DOM_GIS_X"].ToString());
                if (dr["DOM_GIS_Y"].ToString() != "")
                    oObjeto.DomGisY = decimal.Parse(dr["DOM_GIS_Y"].ToString());
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
