using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class DetallesIva {
        public DetallesIva()
        {
        }
        public virtual string TivCodigo { get; set; }
        public virtual float DivPorcentaje { get; set; }
        public virtual DateTime DivVigenciaDesde { get; set; }
        public virtual DateTime? DivVigenciaHasta { get; set; }
    }
}
