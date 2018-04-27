
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
	public class EmpresasImpl
    {
        #region Empresas methods
     
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        private string strsql ;


        public int EmpresasGetID()
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT PKG_SECUENCIAS.FNC_PROX_SECUENCIA('EMP_NUMERO')  ID from dual";
         
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                return int.Parse(dt.Rows[0].ItemArray[0].ToString());

                //Conexion oConexion = new Conexion();
                //OracleConnection cn = oConexion.getConexion();
                //cn.Open();
                //// Clave Secuencia EMP_NUMERO
                //ds = new DataSet();
                //string query =
                //" DECLARE IDTEMP NUMBER(10,0); "+
                //" BEGIN "+
                //" SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('EMP_NUMERO')) into IDTEMP from dual " +
                //" RETURNING IDTEMP INTO :id;" +
                //" END;";
                //cmd = new OracleCommand(query, cn);
                //cmd.Parameters.Add(new OracleParameter
                //{
                //    ParameterName = ":id",
                //    OracleDbType = OracleDbType.Int32,
                //    Direction = ParameterDirection.Output
                //});
                //cmd.ExecuteNonQuery();
                //response = int.Parse(cmd.Parameters[":id"].Value.ToString());
                //cn.Close();
                //return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public long EmpresasAdd(Empresas oEmp)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                // Clave Secuencia EMP_NUMERO
                ds = new DataSet();
                string query =
                    "insert into Empresas(EMP_NUMERO, EMP_RAZON_SOCIAL, EMP_DENOMINACION_COMERCIAL, " +
                    "EMP_CUIT, TIV_CODIGO, EMP_FECHA_ALTA_PRO, EMP_FECHA_BAJA_PRO, EMP_OBSERVACION, " +
                    "EMP_TITULAR_CHEQUES, EMP_PROPIA, EMP_PROVEEDOR, EMP_CLIENTE, EMP_FECHA_ALTA_CLI, " +
                    "EMP_FECHA_BAJA_CLI, EMP_CATEGORIA_MONOTRIBUTO, TID_CODIGO, EMP_DOCUMENTO_NUMERO, " +
                    "EMP_FECHA_ALTA, USR_NUMERO_CARGA, EMP_APELLIDOS, EMP_NOMBRES, EST_CODIGO_PRO, EST_CODIGO_CLI, " +
                    "EMP_LIMITE_CREDITO, EST_CODIGO_CREDITO, EMP_NUMERO_TRANSPORTE, PRS_NUMERO) " +
                    "values(" + oEmp.EmpNumero + ", '" + oEmp.EmpRazonSocial + "', '" +
                    oEmp.EmpDenominacionComercial + "', '" + oEmp.EmpCuit + "', '" + oEmp.TivCodigo + "', '" +
                    oEmp.EmpFechaAltaPro.ToString("dd/MM/yyyy") + "', ";
                    if (oEmp.EmpFechaBajaPro == null)
                        query = query + "null";
                    else
                        query = query + "'" + oEmp.EmpFechaBajaPro.Value.ToString("dd/MM/yyyy") +"'";

                    query = query + ", '" + oEmp.EmpObservacion + "', '" +
                    oEmp.EmpTitularCheques + "', '" + oEmp.EmpPropia + "', '" + oEmp.EmpProveedor + "', '" +
                    oEmp.EmpCliente + "', '" + oEmp.EmpFechaAltaCli.Value.ToString("dd/MM/yyyy") + "', ";
                    if (oEmp.EmpFechaBajaCli == null)
                        query = query + "null";
                    else
                        query = query +"'"+oEmp.EmpFechaBajaCli.Value.ToString("dd/MM/yyyy") +"'";

                    query = query + ", '" + 
                    oEmp.EmpCategoriaMonotributo + "', '" + oEmp.TidCodigo + "', '" + oEmp.EmpDocumentoNumero + "','" + 
                    oEmp.EmpFechaAlta.Value.ToString("dd/MM/yyyy") + "', " + oEmp.UsrNumeroCarga + ", '" + oEmp.EmpApellidos + "', '" + 
                    oEmp.EmpNombres + "', '" + oEmp.EstCodigoPro + "', '" + oEmp.EstCodigoCli + "', " + 
                    oEmp.EmpLimiteCredito +", '" +oEmp.EstCodigoCredito + "', " + oEmp.EmpNumeroTransporte + ", " + 
                    oEmp.PrsNumero + ")";
                cmd = new OracleCommand(query, cn);
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

        public bool EmpresasUpdate(Empresas oEmp)
		{
			try
			{
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                strsql = "update Empresas " +
                    "SET EMP_RAZON_SOCIAL='" + oEmp.EmpRazonSocial + "'," +
                    "EMP_DENOMINACION_COMERCIAL='" + oEmp.EmpDenominacionComercial + "'," +
                    "EMP_CUIT='" + oEmp.EmpCuit + "'," +
                    "TIV_CODIGO='" + oEmp.TivCodigo + "'," +
                    "EMP_FECHA_ALTA_PRO='" + oEmp.EmpFechaAltaPro.ToString("dd/MM/yyyy") + "'," +
                    "EMP_FECHA_BAJA_PRO='" + oEmp.EmpFechaBajaPro.Value.ToString("dd/MM/yyyy") + "'," +
                    "EMP_OBSERVACION='" + oEmp.EmpObservacion + "'," +
                    "EMP_TITULAR_CHEQUES='" + oEmp.EmpTitularCheques + "'," +
                    "EMP_PROPIA='" + oEmp.EmpPropia + "'," +
                    "EMP_PROVEEDOR='" + oEmp.EmpProveedor + "'," +
                    "EMP_CLIENTE='" + oEmp.EmpCliente + "'," +
                    "EMP_FECHA_ALTA_CLI='" + oEmp.EmpFechaAltaCli.Value.ToString("dd/MM/yyyy") + "'," +
                    "EMP_FECHA_BAJA_CLI='" + oEmp.EmpFechaBajaCli.Value.ToString("dd/MM/yyyy") + "'," +
                    "EMP_CATEGORIA_MONOTRIBUTO='" + oEmp.EmpCategoriaMonotributo + "'," +
                    "TID_CODIGO='" + oEmp.TidCodigo + "'," +
                    "EMP_DOCUMENTO_NUMERO='" + oEmp.EmpDocumentoNumero + "'," +
                    "EMP_FECHA_ALTA='" + oEmp.EmpFechaAlta.Value.ToString("dd/MM/yyyy") + "'," +
                    "USR_NUMERO_CARGA=" + oEmp.UsrNumeroCarga + "," +
                    "EMP_APELLIDOS='" + oEmp.EmpApellidos + "'," +
                    "EMP_NOMBRES='" + oEmp.EmpNombres + "'," +
                    "EST_CODIGO_PRO='" + oEmp.EstCodigoPro + "'," +
                    "EST_CODIGO_CLI='" + oEmp.EstCodigoCli + "'," +
                    "EMP_LIMITE_CREDITO=" + oEmp.EmpLimiteCredito + "," +
                    "EST_CODIGO_CREDITO='" + oEmp.EstCodigoCredito + "'," +
                    "EMP_NUMERO_TRANSPORTE=" + oEmp.EmpNumeroTransporte + "," +
                    "PRS_NUMERO=" + oEmp.PrsNumero +
                    " WHERE EMP_NUMERO=" + oEmp.EmpNumero;
                cmd = new OracleCommand(strsql, cn);
                //cmd = new OracleCommand("update Empresas " +
                //    "SET EMP_RAZON_SOCIAL='" + oEmp.EmpRazonSocial + "'," +
                //    "EMP_DENOMINACION_COMERCIAL='" + oEmp.EmpDenominacionComercial + "'," +
                //    "EMP_CUIT='" + oEmp.EmpCuit + "'," +
                //    "TIV_CODIGO='" + oEmp.TivCodigo + "'," +
                //    "EMP_FECHA_ALTA_PRO='" + oEmp.EmpFechaAltaPro.ToString("dd/MM/yyyy") + "'," +
                //    "EMP_FECHA_BAJA_PRO='" + oEmp.EmpFechaBajaPro.Value.ToString("dd/MM/yyyy") + "'," +
                //    "EMP_OBSERVACION='" + oEmp.EmpObservacion + "'," +
                //    "EMP_TITULAR_CHEQUES='" + oEmp.EmpTitularCheques + "'," +
                //    "EMP_PROPIA='" + oEmp.EmpPropia + "'," +
                //    "EMP_PROVEEDOR='" + oEmp.EmpProveedor + "'," +
                //    "EMP_CLIENTE='" + oEmp.EmpCliente + "'," +
                //    "EMP_FECHA_ALTA_CLI='" + oEmp.EmpFechaAltaCli.Value.ToString("dd/MM/yyyy") + "'," +
                //    "EMP_FECHA_BAJA_CLI='" + oEmp.EmpFechaBajaCli.Value.ToString("dd/MM/yyyy") + "'," +
                //    "EMP_CATEGORIA_MONOTRIBUTO='" + oEmp.EmpCategoriaMonotributo + "'," +
                //    "TID_CODIGO='" + oEmp.TidCodigo + "'," +
                //    "EMP_DOCUMENTO_NUMERO='" + oEmp.EmpDocumentoNumero + "'," +
                //    "EMP_FECHA_ALTA='" + oEmp.EmpFechaAlta.Value.ToString("dd/MM/yyyy") + "'," +
                //    "USR_NUMERO_CARGA=" + oEmp.UsrNumeroCarga + "," +
                //    "EMP_APELLIDOS='" + oEmp.EmpApellidos + "'," +
                //    "EMP_NOMBRES='" + oEmp.EmpNombres + "'," +
                //    "EST_CODIGO_PRO='" + oEmp.EstCodigoPro + "'," +
                //    "EST_CODIGO_CLI='" + oEmp.EstCodigoCli + "'," +
                //    "EMP_LIMITE_CREDITO=" + oEmp.EmpLimiteCredito + "," +
                //    "EST_CODIGO_CREDITO='" + oEmp.EstCodigoCredito + "'," +
                //    "EMP_NUMERO_TRANSPORTE=" + oEmp.EmpNumeroTransporte + "," +
                //    "PRS_NUMERO=" + oEmp.PrsNumero + 
                //    " WHERE EMP_NUMERO=" + oEmp.EmpNumero, cn);
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

        public bool EmpresasDelete(long Id)
		{

                try
                {
                    Conexion oConexion = new Conexion();
                    OracleConnection cn = oConexion.getConexion();
                    cn.Open();
                    ds = new DataSet();
                    cmd = new OracleCommand("DELETE Empresas " +
                         "WHERE EMP_NUMERO=" + Id.ToString(),cn);
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

        public Empresas EmpresasGetById(long Id)
		{
			try
			{
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Empresas " +
                    "WHERE EMP_NUMERO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Empresas NewEnt = new Empresas();
				if(dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
                    NewEnt = CargarEmpresas(dr);
				}
				return NewEnt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<Empresas> EmpresasGetAll()
		{
            List<Empresas> lstEmpresas = new List<Empresas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Empresas ";
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
                            Empresas NewEnt = new Empresas();
                            NewEnt = CargarEmpresas(dr);
                            lstEmpresas.Add(NewEnt);
                  }
                }
                return lstEmpresas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}
        public DataTable EmpresasGetAllDT()
		{
            List<Empresas> lstEmpresas = new List<Empresas>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from Empresas ";
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

        private Empresas CargarEmpresas(DataRow dr)
		{
			try
			{
                Empresas oObjeto = new Empresas();
                oObjeto.EmpNumero = long.Parse(dr["EMP_NUMERO"].ToString());
                oObjeto.EmpRazonSocial = dr["EMP_RAZON_SOCIAL"].ToString();
                oObjeto.EmpDenominacionComercial = dr["EMP_DENOMINACION_COMERCIAL"].ToString();
                oObjeto.EmpCuit = dr["EMP_CUIT"].ToString();
                oObjeto.TivCodigo = dr["TIV_CODIGO"].ToString();
                if (dr["EMP_FECHA_ALTA_PRO"].ToString() != "")
                    oObjeto.EmpFechaAltaPro = DateTime.Parse(dr["EMP_FECHA_ALTA_PRO"].ToString());
                if (dr["EMP_FECHA_BAJA_PRO"].ToString() != "")
                    oObjeto.EmpFechaBajaPro = DateTime.Parse(dr["EMP_FECHA_BAJA_PRO"].ToString());
                oObjeto.EmpObservacion = dr["EMP_OBSERVACION"].ToString();
                oObjeto.EmpTitularCheques = dr["EMP_TITULAR_CHEQUES"].ToString();
                oObjeto.EmpPropia = dr["EMP_PROPIA"].ToString();
                oObjeto.EmpProveedor = dr["EMP_PROVEEDOR"].ToString();
                oObjeto.EmpCliente = dr["EMP_CLIENTE"].ToString();
                if (dr["EMP_FECHA_ALTA_CLI"].ToString() != "")
                    oObjeto.EmpFechaAltaCli = DateTime.Parse(dr["EMP_FECHA_ALTA_CLI"].ToString());
                if (dr["EMP_FECHA_BAJA_CLI"].ToString() != "")
                    oObjeto.EmpFechaBajaCli = DateTime.Parse(dr["EMP_FECHA_BAJA_CLI"].ToString());
                oObjeto.EmpCategoriaMonotributo = dr["EMP_CATEGORIA_MONOTRIBUTO"].ToString();
                oObjeto.TidCodigo = dr["TID_CODIGO"].ToString();
                oObjeto.EmpDocumentoNumero = dr["EMP_DOCUMENTO_numero"].ToString();
                if (dr["EMP_FECHA_ALTA"].ToString() != "")
                    oObjeto.EmpFechaAlta = DateTime.Parse(dr["EMP_FECHA_ALTA"].ToString());
                oObjeto.UsrNumeroCarga = int.Parse(dr["USR_NUMERO_CARGA"].ToString());
                oObjeto.EmpApellidos = dr["EMP_APELLIDOS"].ToString();
                oObjeto.EmpNombres = dr["EMP_NOMBRES"].ToString();
                oObjeto.EstCodigoPro = dr["EST_CODIGO_PRO"].ToString();
                oObjeto.EstCodigoCli = dr["EST_CODIGO_CLI"].ToString();
                if (dr["EMP_LIMITE_CREDITO"].ToString() != "")
                    oObjeto.EmpLimiteCredito = double.Parse(dr["EMP_LIMITE_CREDITO"].ToString());
                oObjeto.EstCodigoCredito = dr["EST_CODIGO_CREDITO"].ToString();
                if (dr["EMP_NUMERO_TRANSPORTE"].ToString() != "")
                    oObjeto.EmpNumeroTransporte = int.Parse(dr["EMP_NUMERO_TRANSPORTE"].ToString());
                if (dr["PRS_NUMERO"].ToString() != "")
                    oObjeto.PrsNumero = int.Parse(dr["PRS_NUMERO"].ToString());
                return oObjeto;
 			}

            catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion

	}
}
