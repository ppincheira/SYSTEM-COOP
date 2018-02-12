using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class BarriosLocalidades {
        public BarriosLocalidades()
        {

        }
        public virtual long BarNumero { get; set; }
        public virtual int LocNumero { get; set; }
        public virtual string BarDescripcion { get; set; }
        public virtual string TblCodigo { get; set; }
    }
}
