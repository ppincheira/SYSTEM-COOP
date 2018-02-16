using Controles.datos;
using Controles.Fecha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.frmClientes
{
    public interface IVistaClientesCrud
    {
        long empNumero { get; set; }
        string strRazonSocial { get; set; }
        string strDenominacionComercial { get; set; }
        string strCuit { get; set; }
        cmbLista cmbiTipoIva { get; set; }
        string strObservacion { get; set; }
        string strTitularCheques { get; set; }
        string strPropia { get; set; }
        string strCliente { get; set; }
        string strProveedor { get; set; }
        string strCategoriaMonotributo { get; set; }
        cmbLista cmbiTipoDocumento { get; set; }
        string strNroDocumento { get; set; }
        string strApellido { get; set; }
        string strNombre { get; set; }
        double? dblLimiteCredito { get; set; }
        cmbLista  cmbiEstadoCredito { get; set; }
        int? intNumeroTransporte { get; set; }
        string strTelefono { get; set; }
        string strEmail { get; set; }
        string strDomicilio { get; set; }
        dtpFecha dtpiFechaAlta { get; set; }
        dtpFecha dtpiFechaAltaCli { get; set; }
        dtpFecha dtpiFechaBajaCli { get; set; }
        dtpFecha dtpiFechaAltaPro { get; set; }
        dtpFecha dtpiFechaBajaPro { get; set; }
        long lgCodigoDomicilio { get; set; }
        long lgCodigoTelefono { get; set; }
        long lgCodigoEmail { get; set; }
        long lgCodigoObservacion { get; set; }
        string strEsSocio { get; set; }
        long lgAccNumero { get; set; }
        cmbLista cmbiDistrito { get; set; }
        dtpFecha dtpiFechaAltaAccionista { get; set; }
        dtpFecha dtpiFechaBajaAccionista { get; set; }
        string strClienteBaja { get; set; }
        string strProveedorBaja { get; set; }
        string strAccionistaBaja { get; set; }

    }
}
