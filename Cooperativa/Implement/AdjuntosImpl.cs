﻿using System.Data.SqlClient;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Configuration;
using Model;
using System.Data;
using System.IO;
using System;

namespace Implement
{
    public class AdjuntosImpl
    {
        #region Adjuntos methods

        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;
        public int AdjuntosAdd(Adjuntos oAdjunto)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(oAdjunto.AdjAdjunto, FileMode.Open, FileAccess.Read);
                byte[] blob = new byte[fs.Length];
                fs.Read(blob, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                cn.Open();
                string query =
                      " DECLARE IDTEMP NUMBER(15,0); " +
                      " BEGIN " +
                      " SELECT(PKG_SECUENCIAS.FNC_PROX_SECUENCIA('ADJ_NUMERO')) INTO IDTEMP FROM DUAL; " +
                      " INSERT INTO ADJUNTOS( ADJ_CODIGO,ADJ_CODIGO_REGISTRO,ADJ_NOMBRE, ADJ_EXTENCION, ADJ_FECHA, TAB_CODIGO, ADJ_ADJUNTO) " +
                      " values(IDTEMP,'" + oAdjunto.AdjCodigoRegistro + "'," +
                      "'" + oAdjunto.AdjNombre + "'," +
                      "'" + oAdjunto.AdjExtencion + "'," +
                      "'" + oAdjunto.AdjFecha.ToString("dd/MM/yyyy") + "'," +
                      "'" + oAdjunto.TabCodigo+"',"+
                      " :BlobParameter) RETURNING IDTEMP INTO :id;" +
                         " END;";
                OracleParameter blobParameter = new OracleParameter();
                blobParameter.OracleDbType = OracleDbType.Blob;
                blobParameter.ParameterName = "BlobParameter";
                blobParameter.Value = blob;
                cmd = new OracleCommand(query, cn);

                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });
                cmd.Parameters.Add(blobParameter);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AdjuntosUpdate(Adjuntos oAdjunto)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(oAdjunto.AdjAdjunto, FileMode.Open, FileAccess.Read);
                byte[] blob = new byte[fs.Length];
                fs.Read(blob, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                cn.Open();

                string query = " UPDATE ADJUNTOS " +
                    " SET ADJ_CODIGO=" + oAdjunto.AdjCodigo + "," +
                    " ADJ_CODIGO_REGISTRO='" + oAdjunto.AdjCodigoRegistro + "'," +
                    " ADJ_NOMBRE='" + oAdjunto.AdjNombre + "'," +
                    " ADJ_EXTENCION='" + oAdjunto.AdjExtencion + "'," +
                    " ADJ_FECHA='" + oAdjunto.AdjFecha.ToString("dd/MM/yyyy") + "'," +
                    " TAB_CODIGO='" + oAdjunto.TabCodigo + "'," +
                    " ADJ_ADJUNTO=:BlobParameter " +
                    " WHERE ADJ_CODIGO='" + oAdjunto.AdjCodigo + "'";

                OracleParameter blobParameter = new OracleParameter();
                blobParameter.OracleDbType = OracleDbType.Blob;
                blobParameter.ParameterName = "BlobParameter";
                blobParameter.Value = blob;
                cmd = new OracleCommand(query, cn);
                cmd.Parameters.Add(blobParameter);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AdjuntosDelete(long Id)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                cmd = new OracleCommand("DELETE ADJUNTOS " +
                      "WHERE ADJ_CODIGO=" + Id , cn);
                adapter = new OracleDataAdapter(cmd);
                response = cmd.ExecuteNonQuery();
                cn.Close();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public Boolean AdjuntoExisteByCodigoRegistro(long codigoRegistro) {
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT *  " +
                " FROM ADJUNTOS  " +
                " WHERE  " +
                " ADJ_CODIGO_REGISTRO=" + codigoRegistro;

                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);


                DataTable dt;

                return  (ds.Tables[0].Rows.Count>0);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable AdjuntoGetAdjuntoById(long Id)
        {

            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT ADJ_ADJUNTO " +
                " FROM ADJUNTOS  " +
                " WHERE  " +
                " ADJ_CODIGO=" + Id;

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

        public Adjuntos AdjuntosGetById(long Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM ADJUNTOS " +
                    "where ADJ_CODIGO=" + Id ;
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Adjuntos NewEnt = new Adjuntos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarAdjuntos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Adjuntos AdjuntosGetByCodigoRegistro(long Id, string TabCodigo)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM ADJUNTOS " +
                    "where ADJ_CODIGO_REGISTRO=" + Id + " and TAB_CODIGO='"+TabCodigo+"'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                Adjuntos NewEnt = new Adjuntos();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarAdjuntos(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Adjuntos> AdjuntosGetAll()
        {
            List<Adjuntos> lstAdjuntos = new List<Adjuntos>();
            try
            {

                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "SELECT * FROM ADJUNTOS ";
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
                        Adjuntos NewEnt = new Adjuntos();
                        NewEnt = CargarAdjuntos(dr);
                        lstAdjuntos.Add(NewEnt);
                    }
                }
                return lstAdjuntos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Adjuntos CargarAdjuntos(DataRow dr)
        {
            try
            {
                Adjuntos oObjeto = new Adjuntos();
                oObjeto.AdjCodigo = long.Parse(dr["ADJ_CODIGO"].ToString());
                oObjeto.AdjCodigoRegistro = dr["ADJ_CODIGO_REGISTRO"].ToString();
                oObjeto.AdjNombre = dr["ADJ_NOMBRE"].ToString();
                oObjeto.AdjExtencion = dr["ADJ_EXTENCION"].ToString();
                oObjeto.AdjAdjunto = dr["ADJ_ADJUNTO"].ToString();
                oObjeto.AdjFecha=DateTime.Parse( dr["ADJ_FECHA"].ToString());
                oObjeto.TabCodigo= dr["TAB_CODIGO"].ToString();
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
