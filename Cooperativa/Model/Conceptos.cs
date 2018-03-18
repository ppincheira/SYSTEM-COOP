using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Conceptos
    {
        public virtual long cptNumero { get; set; } 
        public virtual string cptCodigo { get; set; } 
        public virtual string cptDescripcion { get; set; }
        public virtual string cptDescripcionCorta { get; set; }
        public virtual string cptControlaStock { get; set; } 
        public virtual string cptFraccionado { get; set; } 
        public virtual int? cumCodigo { get; set; } 
        public virtual long? cptCodigoBarra { get; set; }
        public virtual string cptCodigoQr { get; set; }
        public virtual long? cptCodigoPadre { get; set; }        
        public virtual int? cptFraccionadoPor { get; set; } 
        public virtual string cptMedible { get; set; } 
        public virtual string cptFabricado { get; set; } 
        public virtual decimal? cptPeso { get; set; }
        public virtual decimal? cptAncho { get; set; }
        public virtual decimal? cptLargo { get; set; }
        public virtual decimal? cptProfundidad { get; set; }
        public virtual decimal? cptStockMinimo { get; set; }
        public virtual decimal? cptStockMaximo { get; set; }
        public virtual decimal? cptStockReposicion { get; set; }
        public virtual string ticCodigo { get; set; }
        public virtual string EstCodigo { get; set; }
    }
}
