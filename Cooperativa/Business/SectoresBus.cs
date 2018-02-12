using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implement;
using Model;

namespace Business
{
    public class SectoresBus
    {
        public int SectoresAdd(Sectores oSectores)
        {
            SectoresImpl oSectoresImpl = new SectoresImpl();
            return oSectoresImpl.SectoresAdd(oSectores);
        }

        public bool SectoresUpdate(Sectores oSectores)
        {
            SectoresImpl oSectoresImpl = new SectoresImpl();
            return oSectoresImpl.SectoresUpdate(oSectores);
        }

        public bool SectoresDelete(String Id)
        {
            SectoresImpl oSectoresImpl = new SectoresImpl();
            return oSectoresImpl.SectoresDelete(Id);
        }

        public Sectores SectoresGetById(string Id)
        {
            SectoresImpl oSectoresImpl = new SectoresImpl();
            return oSectoresImpl.SectoresGetById(Id);
        }

        public List<Sectores> SectoresGetAll()
        {
            SectoresImpl oSectoresImpl = new SectoresImpl();
            return oSectoresImpl.SectoresGetAll();
        }
    }
}
