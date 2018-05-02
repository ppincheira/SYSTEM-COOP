using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class TransaccionesImpl
    {
        #region Transacciones methods

        private OracleCommand cmd;
        private OracleTransaction trans;
        private OracleConnection cn;
        private string strResultado;

        public void IniciarTransaccion()
        {
            try
            {
                Conexion oConexion = new Conexion();
                cn = oConexion.getConexion();
                cn.Open();
                cmd = cn.CreateCommand();
                trans = cn.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = trans;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string EjecutarTransaccion(Transacciones oTrans)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = oTrans.traQuery;

                if (!string.IsNullOrEmpty(oTrans.traParametroInBlob))
                {
                    cmd.Parameters.Add(new OracleParameter
                    {
                        ParameterName = oTrans.traParametroInBlob,
                        OracleDbType = OracleDbType.Blob,
                        Direction = ParameterDirection.Input,                        
                        Value = oTrans.traParametroBlob
                    });
                }

                if (!string.IsNullOrEmpty(oTrans.traParametroOutLog))
                {                    
                    cmd.Parameters.Add(new OracleParameter
                    {
                        ParameterName = oTrans.traParametroOutLog,
                        OracleDbType = OracleDbType.Int64,
                        Direction = ParameterDirection.Output
                    });                    
                }             
                cmd.ExecuteNonQuery();                
                if (!string.IsNullOrEmpty(oTrans.traParametroOutLog))
                {
                    strResultado = cmd.Parameters[oTrans.traParametroOutLog].Value.ToString();
                }                
                return strResultado;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
        }
       
        public void FinalizarTransaccion()
        {
            try
            {
                trans.Commit();
                cn.Close();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
        }

        #endregion
    }
}
