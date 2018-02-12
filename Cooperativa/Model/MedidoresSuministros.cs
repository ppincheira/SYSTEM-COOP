using System;


namespace Model
{

    public class MedidoresSuministros {
        public MedidoresSuministros()
        {
        }
        public virtual long MsuNumero { get; set; }
        public virtual DateTime MsuFechaAlta { get; set; }
        public virtual DateTime? MsuFechaBaja { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual long MedNumero { get; set; }
        public virtual long SumNumero { get; set; }
    }
}
