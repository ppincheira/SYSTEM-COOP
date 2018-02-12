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
    public class LecturasConceptosBus
    {
        public long LecturasConceptosAdd(LecturasConceptos oLC)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosAdd(oLC);
        }

        public bool LecturasConceptosUpdate(LecturasConceptos oLC)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosUpdate(oLC);
        }

        public bool LecturasConceptosDelete(string oLC)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosDelete(oLC);
        }

        public LecturasConceptos LecturasConceptosGetById(long oLC)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosGetById(oLC);
        }

        public DataTable LecturasConceptosGetAllDT()
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosGetAllDT();
        }

        public List<LecturasConceptos> TiposMedidoresGetAll()
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.LecturasConceptosGetAll();
        }

        /*
         * Este metodo fue creado para poder implementar Modos Lecturas, 
         * en el cual en la variable string se pasa el texto que se tiene que buscar 
         * y  en la variable int se controla si se tiene que buscar por:
         * caso 0: Numero
         * caso 1: Descripcion corta
         * caso 2: descripcion
         * Retorna una Lista ya que puede llegar a traer mas de un resultado 
        */
        public static List<LecturasConceptos> RecuperarLecturasConceptos(string texto, int posicion)
        {
            LecturasConceptosImpl auxImple = new LecturasConceptosImpl();
            return auxImple.RecuperarLecturasConceptos(texto, posicion);            
        }
    }
}
