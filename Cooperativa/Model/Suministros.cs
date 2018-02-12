using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Suministros {
        public Suministros() {
//			MedidoresSuministros = new List<MedidoresSuministro>();
        }
        public virtual long SumNumero { get; set; }
        public virtual string SrvCodigo { get; set; }
        public virtual string TcsCodigo { get; set; }
        public virtual long ScaNumero { get; set; }
        public virtual long? SumOrdenRuta { get; set; }
        public virtual long EmpNumero { get; set; }
        public virtual DateTime? SumFechaAlta { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual float? SumConsumoEstimado { get; set; }
        public virtual long? SumVoltaje { get; set; }
        public virtual string SumConexion { get; set; }
        public virtual double? SumPotenciaL1 { get; set; }
        public virtual double? SumPotenciaL2 { get; set; }
        public virtual double? SumPotenciaL3 { get; set; }
        public virtual long? SumRegistrador { get; set; }
        public virtual string SumPermiteCorte { get; set; }
        public virtual string SumMedido { get; set; }
        public virtual long SruNumero { get; set; }
        public virtual long SzoNumero { get; set; }
        public virtual string SumPermiteFactura { get; set; }
        public virtual DateTime SumFechaCarga { get; set; }
//        public virtual IList<MedidoresSuministro> MedidoresSuministros { get; set; }
    }
}
