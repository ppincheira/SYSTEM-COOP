using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Admin
    {
        public enum enumTipoForm { Selector, Filtro, Ninguna, FiltroAndAlta, FiltroAndEditar };

        public Admin()
        {
        }

        /// <summary>
        /// Campo para asociar la tabla Padre
        /// </summary>
        public virtual string CodigoRegistro { get; set; }
        /// <summary>
        /// Campo para aociar Clase origen Ejmplo Clientes
        /// </summary>
        public virtual string TabCodigoRegistro { get; set; }
        /// <summary>
        /// Campo Para abrir en Edición
        /// </summary>
        public virtual string CodigoEditar { get; set; }
        /// <summary>
        /// Campo para frmFormAdmin y Mini
        /// </summary>
        public virtual string TabCodigo { get; set; }
        private enumTipoForm tipos = enumTipoForm.Ninguna;
        /// <summary>
        /// Campo en el que asocio el comportamiento del Fomulario  frmFormAdmin y Mini
        /// </summary>
        public virtual enumTipoForm Tipo
        {
            get { return tipos; }
            set { tipos = value;  }
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
