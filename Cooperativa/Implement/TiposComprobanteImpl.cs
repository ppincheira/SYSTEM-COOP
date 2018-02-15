using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Implement
{
    public class TiposComprobanteImpl
    {
        private OracleDataAdapter adapter;
        private OracleCommand cmd;
        private DataSet ds;
        private int response;


        public string TiposComprobanteAdd(TiposComprobante oTc)
        {
            try
            {
                
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();

                string query = "insert into TIPOS_COMPROBANTES(TCO_CODIGO, TCO_DESCRIPCION, " +
                        "TCO_LETRA, TCO_ORIGEN_NUMERADOR, TCO_EXTERNO,TCO_CANTIDAD_COPIAS, PCB_CODIGO,TCO_CODIGO_AFIP, TCO_LIBRO_IVA_COMPRAS," +
                        " TCO_LIBRO_IVA_VENTAS , TCO_CODIGO_SICORE, TCM_CANT_MIN_IMPRESION, TCO_PREIMPRESO, TCO_CODIGO_RECE, EST_CODIGO) " +
                        "values('"+ oTc.tcoCodigo +"','" + oTc.tcoDescripcion + "','" + oTc.tcoLetra + "','" +
                        oTc.tcoOrigenNumerado + "','" + oTc.tcoExterno + "','" + oTc.tcoCantidadCopias + "','" + oTc.pcbCodigo + "' ,'" +
                        oTc.tcoCodigoAfip + "', '" + oTc.tcoLibroIvaCompras + "' , '" + oTc.tcoLibroIvaVentas + "' , '" + oTc.tcoCodigoSicore +
                        "' ,'" + oTc.tcmCantMinImpresion + "' ,'" + oTc.tcoPreimpreso + "' ,'" + oTc.tcoCodigoRece + "' ,'" + oTc.estCodigo +
                        "')";
                cmd = new OracleCommand(query, cn);
                adapter = new OracleDataAdapter(cmd);
          /*      cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int64,
                    Direction = ParameterDirection.Output
                });*/
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();                
                cn.Close();
                return oTc.tcoCodigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TiposComprobanteUpdate(TiposComprobante oTc)
        {
            try
            {
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                ds = new DataSet();
                string query = "update TIPOS_COMPROBANTES " +
                    "SET TCO_DESCRIPCION='" + oTc.tcoDescripcion + "', " +
                    "TCO_LETRA='" + oTc.tcoLetra + "', " +
                    "TCO_ORIGEN_NUMERADOR='" + oTc.tcoOrigenNumerado + "', " +
                    "TCO_EXTERNO='" + oTc.tcoExterno + "', " +
                    "TCO_CANTIDAD_COPIAS= '" + oTc.tcoCantidadCopias + "', " +
                    "PCB_CODIGO='" + oTc.pcbCodigo + "', " +
                    "TCO_CODIGO_AFIP= '" + oTc.tcoCodigoAfip + "', " +
                    "TCO_LIBRO_IVA_COMPRAS= '" + oTc.tcoLibroIvaCompras + "', " +
                    "TCO_LIBRO_IVA_VENTAS= '" + oTc.tcoLibroIvaVentas + "', " +
                    "TCO_CODIGO_SICORE= '" + oTc.tcoCodigoSicore + "', " +
                    "TCM_CANT_MIN_IMPRESION= '" + oTc.tcmCantMinImpresion + "', " +
                    "TCO_PREIMPRESO= '" + oTc.tcoPreimpreso + "', " +
                    "TCO_CODIGO_RECE= '" + oTc.tcoCodigoRece + "', " +
                    "EST_CODIGO= '" + oTc.estCodigo + "' " +
                    "WHERE TCO_CODIGO='" + oTc.tcoCodigo+"'";
                cmd = new OracleCommand(query, cn);
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

        public TiposComprobante TiposComprobanteGetById(string Id)
        {
            try
            {
                DataSet ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from TIPOS_COMPROBANTES " +
                    "WHERE TCO_CODIGO='" + Id + "'";
                cmd = new OracleCommand(sqlSelect, cn);
                adapter = new OracleDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                TiposComprobante NewEnt = new TiposComprobante();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    NewEnt = CargarTiposComprobante(dr);
                }
                return NewEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private TiposComprobante CargarTiposComprobante(DataRow dr)
        {
            try
            {
                TiposComprobante oObjeto = new TiposComprobante();
                oObjeto.tcoCodigo = dr["TCO_CODIGO"].ToString();
                oObjeto.tcoDescripcion = dr["TCO_DESCRIPCION"].ToString();
                oObjeto.tcoLetra = dr["TCO_LETRA"].ToString();                
                oObjeto.tcoOrigenNumerado = dr["TCO_ORIGEN_NUMERADOR"].ToString();
                oObjeto.tcoExterno = dr["TCO_EXTERNO"].ToString();
                oObjeto.tcoCantidadCopias = int.Parse(dr["TCO_CANTIDAD_COPIAS"].ToString());
                oObjeto.pcbCodigo = dr["PCB_CODIGO"].ToString();
                oObjeto.tcoCodigoAfip= dr["TCO_CODIGO_AFIP"].ToString();
                oObjeto.tcoLibroIvaCompras = dr["TCO_LIBRO_IVA_COMPRAS"].ToString();
                oObjeto.tcoLibroIvaVentas = dr["TCO_LIBRO_IVA_VENTAS"].ToString();
                oObjeto.tcoCodigoSicore = dr["TCO_CODIGO_SICORE"].ToString();
                oObjeto.tcmCantMinImpresion = int.Parse(dr["TCM_CANT_MIN_IMPRESION"].ToString());
                oObjeto.tcoPreimpreso = dr["TCO_PREIMPRESO"].ToString();
                oObjeto.tcoCodigoRece = dr["TCO_CODIGO_RECE"].ToString();
                oObjeto.estCodigo = dr["EST_CODIGO"].ToString();
                return oObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable TiposComprobanteGetAllDT()
        {
            List<TiposComprobante> lstTiposMedidores = new List<TiposComprobante>();
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from TIPOS_COMPROBANTES ";
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

        public List<TiposComprobante> TiposMedidoresGetAll()
        {
            List<TiposComprobante> lstTiposMedidores = new List<TiposComprobante>();
            try
            {
                ds = new DataSet();
                Conexion oConexion = new Conexion();
                OracleConnection cn = oConexion.getConexion();
                cn.Open();
                string sqlSelect = "select * from TIPOS_COMPROBANTES ";
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
                        TiposComprobante NewEnt = new TiposComprobante();
                        NewEnt = CargarTiposComprobante(dr);
                        lstTiposMedidores.Add(NewEnt);
                    }
                }
                return lstTiposMedidores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
