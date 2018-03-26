using Controles.datos;
using Controles.contenedores;
using System;
using Controles.labels;

namespace AppProcesos.formsAuxiliares.frmCrudGrilla
{
    public interface IVistaDobleGrillaCrud
    {       
        grdGrillaEdit grillaPrimaria { get; set; }
        grdGrillaEdit grillaSecundaria { get; set; }
    
        
        string filtro1 { get; set; }
        string filtro2 { get; set; }
        lblEtiqueta lblEtiqueta1 { get; set; }
        lblEtiqueta lblEtiqueta2 { get; set; }


        string cantidadPrimaria { set; }
        string cantidadSecundaria { set; }

        cmbLista busquedaPrimaria { get; set; }
        cmbLista busquedaSecundaria { get; set; }

        void Close();
    }
}
