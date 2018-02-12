using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LecturasModos
    {
        public virtual long lemCodigo { get; set; }                               //Y
        public virtual string lemDescripcion { get; set; }                        //N              
        public virtual DateTime lemFechaCarga { get; set; }                       //N
        public virtual string srvCodigo { get; set; }                           //N
        public virtual int usrCodigo { get; set; }                                //Y
        public virtual string estCodigo { get; set; }
        public virtual List<LecturasConceptos> conceptos { get; set; }
    }
}
