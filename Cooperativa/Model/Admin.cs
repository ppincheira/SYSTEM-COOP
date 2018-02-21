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
        /// Campo para asociar Clase origen Ejmplo Clientes
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
        /// El Operador de la consulta
        /// ("1", "IGUAL");
        /// ("2", "DISTINTO");
        /// ("3", "MENOR");
        /// ("4", "MENOR O IGUAL ");
        /// ("5", "MAYOR");
        /// ("6", "MAYOR O IGUAL ");
        /// ("7", "CONTENIDO");
        /// ("8", "EMPIEZA CON");
        /// ("9", "TERMINA CON");
        /// ("10", "ENTRE DOS VALORES");
        /// ("11", "EN LISTA");
        /// ("12", "NO EN LISTA");
        /// </summary>
        public virtual string FiltroOperador { get; set; }
        /// <summary>
        /// Valos del Filtro Anterior
        /// </summary>
        public virtual string FiltroValores { get; set; }

    }
}
