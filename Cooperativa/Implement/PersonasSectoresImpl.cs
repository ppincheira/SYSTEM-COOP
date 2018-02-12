using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class PersonasSectoresImpl
    {
        #region PersonasSectores methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int PersonasSectoresAdd(PersonasSectores oPSe)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave PRS_NUMERO y 
                ds = new DataSet();
                cmd = new OracleCommand("insert into Personas_Sectores(PSE_FECHA_ALTA, PSE_FECHA_BAJA, " +
                    "PRS_NUMERO, SEC_CODIGO, DEP_NUMERO, ARE_CODIGO) " +
                    "values(" + oPSe.PseFechaAlta + ", "+oPSe.PseFechaBaja + ", " + 
                    oPSe.PrsNumero + ", '" + oPSe.SecCodigo + "', " + oPSe.DepNumero + ", '" + 
                    oPSe.AreCodigo + "')", cn);
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

        public bool PersonasSectoresUpdate(PersonasSectores oPSe)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("update Personas_Sectores " +
                    "SET PSE_FECHA_ALTA='" + oPSe.PseFechaAlta + "'," +
                    "PSE_FECHA_BAJA='" + oPSe.PseFechaBaja + "'," +
                    "PRS_NUMERO='" + oPSe.PrsNumero + "'," +
                    "SEC_CODIGO='" + oPSe.SecCodigo + "'," +
                    "DEP_NUMERO='" + oPSe.DepNumero + "'," +
                    "ARE_CODIGO='" + oPSe.AreCodigo + "' " + 
                    "WHERE PRS_NUMERO=" + oPSe.PrsNumero, cn);
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

        public bool PersonasSectoresDelete(int Id)
		{
                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Personas_Sectores " +
                         "WHERE PRS_NUMERO=" + Id.ToString(),cn);
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

        public PersonasSectores PersonasSectoresGetById(int Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Personas_Sectores " +
                    "WHERE PRS_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                PersonasSectores NewEnt = new PersonasSectores();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarPersonasSectores(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<PersonasSectores> PersonasSectoresGetAll()
		{
            List<PersonasSectores> lstPersonasSectores = new List<PersonasSectores>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Personas_Sectores ";
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
                            PersonasSectores NewEnt = new PersonasSectores();
                            NewEnt = CargarPersonasSectores(dr);
                            lstPersonasSectores.Add(NewEnt);
                  }
                }
                return lstPersonasSectores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        private PersonasSectores CargarPersonasSectores(DataRow dr)
		{
			try
			{
                PersonasSectores oObjeto = new PersonasSectores();
                if (dr["PSE_FECHA_ALTA"].ToString() != "")
                    oObjeto.PseFechaAlta = DateTime.Parse(dr["PSE_FECHA_ALTA"].ToString());
                if (dr["PSE_FECHA_BAJA"].ToString() != "")
                    oObjeto.PseFechaBaja = DateTime.Parse(dr["PSE_FECHA_BAJA"].ToString());
                oObjeto.PrsNumero = int.Parse(dr["PRS_NUMERO"].ToString());
                oObjeto.SecCodigo = dr["SEC_CODIGO"].ToString();
                oObjeto.DepNumero = int.Parse(dr["DEP_NUMERO"].ToString());
                oObjeto.AreCodigo = dr["ARE_CODIGO"].ToString();
                return oObjeto;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

      
        //public DataTable PersonasSectoresGetAllFilter(DateTime Periodo, string Empresa, int IdPresentacion, string Tipo)
        //{
        //    try
        //    {
        //        DataTable DTPartes;
        //        DataSet DSPartes = SqlHelper.ExecuteDataset(SqlImplHelper.getConnectionString(), "PersonasSectoresGetAllByFilter", Periodo, Empresa, IdPresentacion,Tipo);
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
