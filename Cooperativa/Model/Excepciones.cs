using System;
using System.Text;
using System.Collections.Generic;

namespace Model
{
    public class Excepciones
    {
        public Excepciones()
        {
        }
        public virtual int ExcNumero { get; set; }
        public virtual DateTime? ExcFecha { get; set; }
        public virtual string ExcNombreExcepcion { get; set; }
        public virtual string ExcNombreEvento { get; set; }
        public virtual string ExcNombreControl { get; set; }
        public virtual string ExcNombreFormulario { get; set; }
        public virtual int UsrNumero { get; set; }
        public virtual string SbsCodigo { get; set; }
        public virtual int TerNumero { get; set; }
        public virtual string ExcDescripcion { get; set; }
    }
}
