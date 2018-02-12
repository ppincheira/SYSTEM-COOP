using System;


namespace Model
{

    public class Empresas {
        public Empresas() {
               //Accionistas = new List<Accionista>();
               // Comprobantes = new List<Comprobante>();
               // Medidores = new List<Medidore>();
               // ConceptosEmpresas = new List<ConceptosEmpresa>();
               // Empresas = new List<Empresa>();
               // Fabricantes = new List<Fabricante>();
            }
        public virtual long EmpNumero { get; set; }
        public virtual string EmpRazonSocial { get; set; }
        public virtual string EmpDenominacionComercial { get; set; }
        public virtual string EmpCuit { get; set; }
        public virtual string TivCodigo { get; set; }
        public virtual DateTime EmpFechaAltaPro { get; set; }
        public virtual DateTime? EmpFechaBajaPro { get; set; }
        public virtual string EmpObservacion { get; set; }
        public virtual string EmpTitularCheques { get; set; }
        public virtual string EmpPropia { get; set; }
        public virtual string EmpProveedor { get; set; }
        public virtual string EmpCliente { get; set; }
        public virtual DateTime? EmpFechaAltaCli { get; set; }
        public virtual DateTime? EmpFechaBajaCli { get; set; }
        public virtual string EmpCategoriaMonotributo { get; set; }
        public virtual string TidCodigo { get; set; }
        public virtual string EmpDocumentoNumero { get; set; }
        public virtual DateTime? EmpFechaAlta { get; set; }
        public virtual int UsrNumeroCarga { get; set; }
        public virtual string EmpApellidos { get; set; }
        public virtual string EmpNombres { get; set; }
        public virtual string EstCodigoPro { get; set; }
        public virtual string EstCodigoCli { get; set; }
        public virtual double? EmpLimiteCredito { get; set; }
        public virtual string EstCodigoCredito { get; set; }
        public virtual int? EmpNumeroTransporte { get; set; }
        public virtual int? PrsNumero { get; set; }
       /* public virtual IList<Accionista> Accionistas { get; set; }
        public virtual IList<Comprobante> Comprobantes { get; set; }
        public virtual IList<Medidore> Medidores { get; set; }
        public virtual IList<ConceptosEmpresa> ConceptosEmpresas { get; set; }
        public virtual IList<Empresa> Empresas { get; set; }
        public virtual IList<Fabricante> Fabricantes { get; set; }
 
     */
    }
}
