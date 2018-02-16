using System;
using System.Text;
using System.Collections.Generic;


namespace Model
{

    public class Personas
    {
        public Personas()
        {
            /*			Usuarios = new List<Usuario>();
                        PrsSecs = new List<PrsSec>();
                        Telefonos = new List<Telefono>();
                        Domicilios = new List<Domicilio>();
            */
        }
        public virtual long PrsNumero { get; set; }
        public virtual string PrsApellido { get; set; }
        public virtual string PrsNombre { get; set; }
        public virtual string PrsEstadoCivil { get; set; }
        public virtual string TidCodigo { get; set; }
        public virtual string PrsDocumentoNumero { get; set; }
        public virtual string PrsSexo { get; set; }
        public virtual DateTime PrsFechaNacimiento { get; set; }
        public virtual int LocNumeroNacimiento { get; set; }
        public virtual DateTime PrsFechaIngreso { get; set; }
        public virtual DateTime PrsFechaBaja { get; set; }
        public virtual string EstCodigo { get; set; }
        public virtual string PrsMotivoBaja { get; set; }
        public virtual string PrsLegajo { get; set; }
        public virtual string PrsCuil { get; set; }
        public virtual string PrsCargo { get; set; }
        /*        public virtual IList<Usuario> Usuarios { get; set; }
                public virtual IList<PrsSec> PrsSecs { get; set; }
                public virtual IList<Telefono> Telefonos { get; set; }
                public virtual IList<Domicilio> Domicilios { get; set; }
        */
    }
}
