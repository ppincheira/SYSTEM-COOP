using Implement;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class LecturasModosBus
    {
        public long LecturasModosAdd(LecturasModos oLC)
        {
            LecturasModosImpl auxImple = new LecturasModosImpl();
            return auxImple.LecturasModosAdd(oLC);
        }

        public bool LecturasModosUpdate(LecturasModos oLC)
        {
            LecturasModosImpl auxImple = new LecturasModosImpl();
            return auxImple.LecturasModosUpdate(oLC);
        }

        public bool LecturasModosDelete(long oLC)
        {
            LecturasModosImpl auxImple = new LecturasModosImpl();
            return auxImple.LecturasModosDelete(oLC);
        }

        public LecturasModos LecturasModosGetById(long oLC)
        {
            LecturasModosImpl auxImple = new LecturasModosImpl();
            return auxImple.LecturasModosGetById(oLC);
        }

        public DataTable LecturasModosGetAllDT()
        {
            LecturasModosImpl auxImple = new LecturasModosImpl();
            return auxImple.LecturasModosGetAllDT();
        }

        public List<LecturasModos> LecturasModosGetAll()
        {
            LecturasModosImpl auxImple = new LecturasModosImpl();
            return auxImple.LecturasModosGetAll();
        }
    /*    public List<LecturasConceptos> LecturasConceptosDeModoById(long id)
        {
            LecturasModosImpl auxImple = new LecturasModosImpl();
            return auxImple.LecturasConceptosDeModoById(id);
        }*/
    }
}
