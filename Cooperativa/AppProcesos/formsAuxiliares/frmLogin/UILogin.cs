using Business;
using Model;
using System;
using Service;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProcesos.formsAuxiliares.formLogin
{
    public partial  class UILogin
    {
        private string _Usuario;
        private string _Password;
        Utility oUtil;
        private IVistaLogin _vista;
        
        public UILogin(IVistaLogin vista)
        {
            _vista = vista;
            oUtil = new Utility();

        }

        public long validar()

        {
            UsuariosBus oUsuarioBus = new UsuariosBus();
            Usuarios oUsuario = new Usuarios();
            oUsuario = oUsuarioBus.UsuariosLogin(_vista.usuario, _vista.password);
            return (oUsuario.PrsNumero);
          

        }

        public string nombreUsuario(long idPersona)
        {
            PersonasBus oPersonaBus = new PersonasBus();
            Personas oPersona = new Personas();
            oPersona = oPersonaBus.PersonasGetById(idPersona);
            return oPersona.PrsNombre + ", " + oPersona.PrsApellido;

        }
            /*        public void Inicializar(string tabla)
                    {
                        _filtroCampos = "";
                        _filtroValores = "";
                        _dtCombo = new DataTable();
                        _dtCombo.Columns.Add("DctColumna", typeof(string));
                        _dtCombo.Columns.Add("DctDescripcion", typeof(string));
                        DetallesColumnasTablasBus oDetalleBus = new DetallesColumnasTablasBus();
                        List<DetallesColumnasTablas> ListDetalle = oDetalleBus.DetallesColumnasTablasGetByCodigo(tabla);
                        foreach (DetallesColumnasTablas oDetalle in ListDetalle)
                        {

                            _Campo = _Campo + ' ' + oDetalle.DctColumna + ' ' + oDetalle.DctDescripcion + ',';
                            if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl != "FECHA") && oDetalle.DctTipoControl != "ESTADO")
                            {
                                _dtCombo.Rows.Add(oDetalle.DctColumna, oDetalle.DctDescripcion);
                            }

                            if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "FECHA"))
                            {
                                _vista.grupoFecha = true;
                                _vista.fechaDesde = DateTime.Now.Date.AddMonths(-1);
                                _vista.fechaHasta = DateTime.Now.Date;
                                _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                                _Fecha = oDetalle.DctColumna + "&";
                                _filtroValores = _filtroValores + _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy")+ "&";
                            }
                            if ((oDetalle.DctFiltroBusqueda == "S") && (oDetalle.DctTipoControl == "ESTADO"))
                            {
                                _vista.grupoEstado = true;
                                _filtroCampos = _filtroCampos + oDetalle.DctColumna + "&";
                                _filtroValores = _filtroValores +_vista.comboEstado.Text + "&";
                            }
                        }

                        oUtil.CargarCombo( _vista.comboBuscar, _dtCombo, "DctColumna", "DctDescripcion");
                        if (_Campo.Length > 0)
                            _Campo = _Campo.Substring(0, _Campo.Length - 1);
                        TablasBus oTablasBus = new TablasBus();
                        DataTable dt = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
                        _vista.cantidad= "Se encontraron " +oUtil.CargarGrilla(_vista.grilla, dt) + " registros";

                    }


                     public void CargarGrilla(string tabla) {
                        _filtroCampos = "";
                        _filtroValores = "";

                        if (_vista.grupoFecha) { 
                            _filtroValores = _vista.fechaDesde.ToString("dd/MM/yyyy") + "%" + _vista.fechaHasta.ToString("dd/MM/yyyy") + "&";
                            _filtroCampos = _Fecha ;
                        }
                        if (_vista.grupoEstado)
                            _filtroValores = _vista.comboEstado.Text + "&";

                        _filtroCampos = _filtroCampos+_vista.comboBuscar.SelectedValue.ToString() + "&";
                        _filtroValores = _filtroValores+_vista.filtro + "&";

                        TablasBus oTablasBus = new TablasBus();
                        _vista.grilla.DataSource = oTablasBus.TablasBusquedaGetAllFilter(tabla, _Campo, _filtroCampos, _filtroValores);
                        _vista.cantidad= "Se encontraron "+ _vista.grilla.VisibleRowCount.ToString()+ " registros";

                    }

                */
        }
}
