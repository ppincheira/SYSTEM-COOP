using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Configuration;
namespace Implement
{
    public class Conexion
    {
        private OracleConnection cn { get; set; }
        public OracleConnection getConexion() {

            if (cn == null) {
                string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                cn = new OracleConnection(conexion);

            }
            return cn;

        }

    }
}
