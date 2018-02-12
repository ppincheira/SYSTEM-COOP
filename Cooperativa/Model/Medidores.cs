using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Medidores {
        public Medidores()
        {
        }
        public virtual long MedNumero { get; set; }
        public virtual long MedNumeroserie { get; set; }
        public virtual long EmpNumeroProveedor { get; set; }
        public virtual int MedDigitos { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual double MedFactorCalib { get; set; }
        public virtual decimal? GisX { get; set; }
        public virtual decimal? GisY { get; set; }
        public virtual int UsrNumero { get; set; }
        public virtual DateTime MedFechaCarga { get; set; }
        public virtual short? MmoCodigo { get; set; }
    }
}
