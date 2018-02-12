using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Implement;
namespace Business
{
    public class PruebaBus
    {

        public DataTable GetAllDT()
        {

            PruebaImpl oPruebaImpl = new PruebaImpl();
            return oPruebaImpl.PruebaGetAllDT();
        }

    }
}
