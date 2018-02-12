using System;


namespace Model
{

    public class Servicios {
        public Servicios() {
/*			TipoConexionServicios = new List<TipoConexionServicio>();
			TiposMedidores = new List<TiposMedidore>();
*/
        }
        public virtual string SrvCodigo { get; set; }
        public virtual string SrvDescripcion { get; set; }
        public virtual string SrvDescripcionCorta { get; set; }
        public virtual DateTime SrvFechaCarga { get; set; }
        public virtual int UsrNumero { get; set; }
        public virtual string SrvRequiereMedidor { get; set; }
/*        public virtual IList<TipoConexionServicio> TipoConexionServicios { get; set; }
        public virtual IList<TiposMedidore> TiposMedidores { get; set; }
*/
    }
}
