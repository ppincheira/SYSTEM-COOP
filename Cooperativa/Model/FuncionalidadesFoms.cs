using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FuncionalidadesFoms
    {


        public FuncionalidadesFoms(string PNew, string PEdit, string PDel, string PExp, string PImp, string PVer)
        {
            this.New = PNew;
            this.Edit = PEdit;
            this.Del = PDel;
            this.Exp = PExp;
            this.Imp = PImp;
            this.Ver = PVer;
        }
        public virtual string New { get; set; }
        public virtual string Edit { get; set; }
        public virtual string Del { get; set; }
        public virtual string Exp { get; set; }
        public virtual string Imp { get; set; }
        public virtual string Ver { get; set; }
    }


}
