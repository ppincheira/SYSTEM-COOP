using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Model;
using Service;
using System.IO;

namespace Service
{
    public class ManejarError
    {
        public void CargarError(Exception sException,
                                string sNombreEvento,
                                string sNombreControl,
                                string sNombreFormulario
                                )
        {
            try
            {
                ////genera el registros para la base de datos                        
                Excepciones oExcepciones = new Excepciones();
                oExcepciones.ExcFecha = DateTime.Now;
                oExcepciones.ExcNombreExcepcion = sException.TargetSite.Name;
                oExcepciones.ExcNombreEvento = sNombreEvento;
                oExcepciones.ExcNombreControl = sNombreControl;
                oExcepciones.ExcNombreFormulario = sNombreFormulario;
                oExcepciones.UsrNumero = 1;//falta definir variable global
                oExcepciones.SbsCodigo = "ALL";//falta definir variable global
                oExcepciones.TerNumero = 1;//falta definir variable global
                oExcepciones.ExcDescripcion = sException.Message.Replace("'", " ");
                ExcepcionesBus oExcepcionesBus = new ExcepcionesBus();
                oExcepcionesBus.ExcepcionesAdd(oExcepciones);
                ////sale el mensaje de error hacia el formulario
                MessageBox.Show("Error: " + sException.Message, "Cooperativa", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                //se genera un archivo plano en caso de alguna excepcion con la base.
                StreamWriter log;
                if (!File.Exists("logfilecooperativa.txt"))
                    log = new StreamWriter("logfilecooperativa.txt");
                else
                    log = File.AppendText("logfilecooperativa.txt");

                log.WriteLine("Fecha: " + DateTime.Now);
                log.WriteLine("Error: " + ex.Message);
                log.WriteLine("Usuario: " + 1);//falta definir variable global
                log.WriteLine("Subsistema: " + "ALL");//falta definir variable global
                log.WriteLine("Terminal: " + 1);//falta definir variable global               
                log.Close();
                ////sale el mensaje de error hacia el formulario
                MessageBox.Show("Error: " + ex.Message, "Cooperativa", MessageBoxButtons.OK);
            }
        }
    }
}