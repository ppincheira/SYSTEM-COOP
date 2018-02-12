using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdminObs
    {
        public enum enumTipoForm { Selector, Filtro, FiltroAndAlta, FiltroAndEditar, Ninguna };
        public AdminObs()
        {
        }
        
        public virtual string TabCodigo { get; set; }
        public virtual int TobCodigo { get; set; }
        public virtual string CodigoRegistro { get; set; }

        private enumTipoForm tipos = enumTipoForm.Ninguna;
        /// <summary>
        /// Campo para aociar Clase origen Ejmplo Clientes
        /// </summary>
        public virtual string TabCodigoRegistro { get; set; }
        public virtual enumTipoForm Tipo
        {
            get { return tipos; }
            set { tipos = value; }
        }

        /// <summary>
        /// Filtros de Campos
        /// </summary>
        public virtual string FiltroCampos { get; set; }
        /// <summary>
        /// Valos del Filtro Anterior
        /// </summary>
        public virtual string FiltroValores { get; set; }
    }
}
