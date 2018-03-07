﻿
using System;
using System.Data;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using Model;

namespace Implement
{
    public class LecturasSuministrosImpl
    {

        #region LecturasSuministros methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private long response;


        public long LecturasSuministrosAdd(LecturasSuministros oLecSum)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string query =

                    " DECLARE IDTEMP NUMBER(15,0); " +
                    " BEGIN " +
                    " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('LES_CODIGO')) into IDTEMP from dual; " +
                    " INSERT INTO LECTURAS_SUMINISTROS(LES_CODIGO,LES_FECHA_ALTA,LES_FECHA_ANTERIOR,"+
                    " LES_PERIODO, SUM_NUMERO, MED_NUMERO,SRU_NUMERO,LEM_CODIGO, " +
                    " EST_CODIGO,CBP_NUMERO)" +
                    " VALUES(IDTEMP,'" + oLecSum.lesFechaAlta+ "','" + oLecSum.lesFechaAnterior + "', '" + oLecSum.lesPeriodo+ "', " + oLecSum.sumNumero +", " +
                    oLecSum.medNumero + ", " + oLecSum.sruNumero + ", " + oLecSum.lemCodigo + ", '" +
                    oLecSum.estCodigo + "', " + oLecSum.cbpNumero + ") RETURNING IDTEMP INTO :id;" +
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

        public bool LecturasSuministrosUpdate(LecturasSuministros oLecSum)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand(" UPDATE LECTURAS_SUMINISTROS " +
                    " SET LES_CODIGO=" + oLecSum.lesCodigo+ ", " +
                    " LES_FECHA_ALTA='" + oLecSum.lesFechaAlta.ToString("dd/MM/yyyy") + "', " +
                    " LES_FECHA_ANTERIOR='" + oLecSum.lesFechaAnterior.ToString("dd/MM/yyyy") + "', " +
                    " LES_PERIODO='" + oLecSum.lesPeriodo + "', " +
                    " SUM_NUMERO=" + oLecSum.sumNumero + ", " +
                    " MED_NUMERO=" + oLecSum.medNumero + ", " +
                    " SRU_NUMERO=" + oLecSum.sruNumero + ", " +
                    " LEM_CODIGO=" + oLecSum.lemCodigo + ", " +
                    " EST_CODIGO='" + oLecSum.estCodigo + "', " +
                    " CBP_NUMERO=" + oLecSum.cbpNumero + " " +
                    " WHERE LES_CODIGO=" + oLecSum.lesCodigo, cn);
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

        public bool LecturasSuministrosDelete(long Id)
        {

            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE LECTURAS_SUMINISTROS " +
                     "WHERE LES_CODIGO=" + Id.ToString(), cn);
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

        public LecturasSuministros LecturasSuministrosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM LECTURAS_SUMINISTROS " +
                    "WHERE LES_CODIGO=" + Id.ToString();
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                LecturasSuministros NewEnt = new LecturasSuministros();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarLecturasSuministros(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
         }


        public List<LecturasSuministros> LecturasSuministrosGetAll()
        {
            List<LecturasSuministros> lstLecSum = new List<LecturasSuministros>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM LECTURAS_SUMINISTROS ";
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
                        LecturasSuministros NewEnt = new LecturasSuministros();
                        NewEnt =CargarLecturasSuministros(dr);
                        lstLecSum.Add(NewEnt);
                    }
                }
                return lstLecSum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private LecturasSuministros CargarLecturasSuministros(DataRow dr)
        {
            try
            {
                LecturasSuministros oLecSum = new LecturasSuministros();
                oLecSum.lesCodigo = long.Parse(dr["LES_CODIGO"].ToString());
                oLecSum.lesFechaAlta = DateTime.Parse(dr["LES_FECHA_ALTA"].ToString());
                oLecSum.lesFechaAnterior = DateTime.Parse(dr["LES_FECHA_ANTERIOR"].ToString());
                oLecSum.lesPeriodo = dr["LES_PERIODO"].ToString();
                oLecSum.sumNumero = long.Parse(dr["SUM_NUMERO"].ToString());
                oLecSum.medNumero = int.Parse(dr["MED_NUMERO"].ToString());
                oLecSum.sruNumero = int.Parse(dr["SRU_NUMERO"].ToString());
                oLecSum.lemCodigo = long.Parse(dr["LEM_CODIGO"].ToString());
                oLecSum.estCodigo =dr["EST_CODIGO"].ToString();
                oLecSum.cbpNumero = long.Parse( dr["EST_CODIGO"].ToString());
                return oLecSum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}