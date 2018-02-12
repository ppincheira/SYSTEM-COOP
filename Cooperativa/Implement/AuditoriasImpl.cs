
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;

namespace Implement
{
	public class AuditoriasImpl
    {
        #region Auditorias methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int AuditoriasAdd(Auditorias oAuditoria)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia AUD_NUMERO
                ds = new DataSet();
                cmd = new OracleCommand("insert into Auditorias(USR_CODIGO, AUD_FECHA, " +
                    "AUD_TERMINAL, TAB_NOMBRE, AUD_TIPO, COT_CLAVE_BUSQUEDA) " +
                    "values('"+oAuditoria.UsrCodigo + "', "+oAuditoria.AudFecha + ", '" + 
                    oAuditoria.AudTerminal + "', '" + oAuditoria.TabNombre + "', '" + 
                    oAuditoria.AudTipo + "', '" + oAuditoria.CotClaveBusqueda + "')", cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                return response;
            }
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool AuditoriasUpdate(Auditorias oAuditoria)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Auditorias " +
                    "SET USR_CODIGO='" + oAuditoria.UsrCodigo + "'," + 
                    "AUD_FECHA='" + oAuditoria.AudFecha + "'," +
                    "AUD_TERMINAL='" + oAuditoria.AudTerminal + "'," + 
                    "TAB_NOMBRE='" + oAuditoria.TabNombre + "'," +
                    "AUD_TIPO='" + oAuditoria.AudTipo + "'," + 
                    "COT_CLAVE_BUSQUEDA='" + oAuditoria.CotClaveBusqueda + 
                    "WHERE AUD_NUMERO=" + oAuditoria.AudNumero, cn);
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

        public bool AuditoriasDelete(long Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Auditorias " +
                         "WHERE AUD_NUMERO=" + Id.ToString(),cn);
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

        public Auditorias AuditoriasGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Auditorias " +
                    "WHERE AUD_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Auditorias NewEnt = new Auditorias();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarAuditorias(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<Auditorias> AuditoriasGetAll()
		{
            List<Auditorias> lstAuditorias = new List<Auditorias>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Auditorias ";
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
                            Auditorias NewEnt = new Auditorias();
                            NewEnt = CargarAuditorias(dr);
                            lstAuditorias.Add(NewEnt);
                  }
                }
                return lstAuditorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private Auditorias CargarAuditorias(DataRow dr)
		{
			try
			{
                Auditorias oObjeto = new Auditorias();
                oObjeto.AudNumero = long.Parse(dr["AUD_NUMERO"].ToString());
                oObjeto.UsrCodigo = dr["USR_CODIGO"].ToString();
                if (dr["AUD_FECHA"].ToString() != "")
                    oObjeto.AudFecha = DateTime.Parse(dr["AUD_FECHA"].ToString());
                oObjeto.AudTerminal = dr["AUD_TERMINAL"].ToString();
                oObjeto.TabNombre = dr["TAB_NOMBRE"].ToString();
                oObjeto.AudTipo = dr["AUD_TIPO"].ToString();
                oObjeto.CotClaveBusqueda = dr["COT_CLAVE_BUSQUEDA"].ToString();
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
