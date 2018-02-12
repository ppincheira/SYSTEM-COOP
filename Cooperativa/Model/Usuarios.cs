using System;
using System.Text;
using System.Collections.Generic;


namespace Model
{

    public class Usuarios
    {
        public Usuarios()
        {
            /*			Empresas = new List<Empresa>();
                        Fabricantes = new List<Fabricante>();
                        RolesUsuarios = new List<RolesUsuario>();
                        Servicios = new List<Servicio>();
                        TiposMedidores = new List<TiposMedidore>();
                        DetallesModelosMedidores = new List<DetallesModelosMedidore>();
                        Medidores = new List<Medidore>();
            */
        }
        public virtual int UsrNumero { get; set; }
        public virtual long PrsNumero { get; set; }
        public virtual string UsrNombre { get; set; }
        public virtual string UsrBloqueado { get; set; }
        public virtual string UsrClave { get; set; }
        public virtual DateTime UsrFechaAlta { get; set; }
        public virtual DateTime UsrFechaBaja { get; set; }
        public virtual string UsrPerfil { get; set; }
        public virtual string EstCodigo { get; set; }
        /*        public virtual IList<Empresa> Empresas { get; set; }
                public virtual IList<Fabricante> Fabricantes { get; set; }
                public virtual IList<RolesUsuario> RolesUsuarios { get; set; }
                public virtual IList<Servicio> Servicios { get; set; }
                public virtual IList<TiposMedidore> TiposMedidores { get; set; }
                public virtual IList<DetallesModelosMedidore> DetallesModelosMedidores { get; set; }
                public virtual IList<Medidore> Medidores { get; set; }
        */
    }
}
