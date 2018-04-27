using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GruposImpuestosItems
    {
        public virtual int giiNumero { get; set; } // 10 caracteres no null
        public virtual string tivCodigo { get; set; } // 10 caracteres no null
        public virtual DateTime giiVigenciaDesde { get; set; }//50 caracteres no null
        public virtual long cptNumero { get; set; }//50 caracteres no null
        public virtual string gciCodigo { get; set; } // 10 caracteres no null
        public virtual decimal? giiPorcentaje { get; set; } // 10 caracteres no null
        public virtual DateTime? giiVigenciaHasta { get; set; } // 10 caracteres no null
        public virtual decimal? giiImporteMinimo { get; set; } // 10 caracteres no null
        public virtual decimal? giiImporteFijo { get; set; } // 10 caracteres no null
        public virtual decimal? giiImporteBaseMinimo { get; set; } // 10 caracteres no null
        public virtual string paiCodigo { get; set; } // 10 caracteres no null
        public virtual string prvCodigo { get; set; } // 10 caracteres no null
        public virtual long? locNumero { get; set; } // 10 caracteres no null
    }
}
