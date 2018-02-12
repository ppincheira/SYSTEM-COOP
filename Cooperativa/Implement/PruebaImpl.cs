using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using Oracle.DataAccess.Client;

namespace Implement
{
    public class PruebaImpl
    {

        //using (OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
        //{
        //    OracleDataAdapter da = new OracleDataAdapter();
        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = cn;
        //    cmd.InitialLONGFetchSize = 1000;
        //    cmd.CommandText = DatabaseHelper.GetDBOwner() + "PKG_COLLECTION.CSP_COLLECTION_HDR_SELECT";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("PUNIT", OracleDbType.Char).Value = unit;
        //    cmd.Parameters.Add("POFFICE", OracleDbType.Char).Value = office;
        //    cmd.Parameters.Add("PRECEIPT_NBR", OracleDbType.Int32).Value = receiptno;
        //    cmd.Parameters.Add("T_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

        //    da.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;


        public DataTable PruebaGetAllDT()
        {
            //Conexion oConexion = new Conexion();
            //OracleConnection cn = oConexion.getConexion();
            //cn.Open();
            //OracleCommand cmd = cn.CreateCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "select * from TestTable ";
            //cmd.ExecuteNonQuery();
            DataTable dt= new DataTable();
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = connString;
                string sqlSelect = "select * from tablatest ";
                // connection string
                OracleDataAdapter adapter = new OracleDataAdapter(sqlSelect, connString);
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "TEMP");                
                dt = dataset.Tables["TEMP"];
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        //public DataTable GetAllDepartments()
        //{
        //    using (OracleConnection conn = new OracleConnection(oradb)) // C#
        //    {
        //        conn.Open();

        //        OracleCommand cmd = new OracleCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandText = "select dname from dept where deptno = 10";
        //        cmd.CommandType = CommandType.Text;
        //        OracleDataAdapter adapter = new OracleDataAdapter(sqlSelect, connString);
        //        //OracleDataReader dr = cmd.ExecuteReader();
        //        //dr.Read();

        //        DataSet dataset = new DataSet();
        //        adapter.Fill(dataset, "TEMP");


        //        dt = dataset.Tables["TEMP"];

        //        return dt;


        //    }
        //}

    }
}
