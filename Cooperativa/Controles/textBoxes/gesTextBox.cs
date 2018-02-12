using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Text.RegularExpressions;
using static Controles.util.Enumerados;

namespace Controles.textBoxes
{
    public class gesTextBox : System.Windows.Forms.TextBox
    {

        private IContainer components;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private int DelimitNumber = 0;
        private int digitPos = 0;
        public string REQUERIDO = "NO";

       

        //Nuevas propiedades
        private string textoVacio;
        [Category("Texto Vacio")]//le agregamos un a categoria 
        public string TextoVacio//Contendra el texto que se mostrara cuando el textbox este vacio
        {
            get { return textoVacio; }
            set { textoVacio = value; }
        }
        private Color colorTextoVacio;
        [Category("Texto Vacio")]//para que aparesca en la misma categoria
        public Color ColorTextoVacio
        {
            get { return colorTextoVacio; }
            set { colorTextoVacio = value; }
        }

        private enumTipos tipos = enumTipos.Ninguna;
        public enumTipos TipoControl
        {
            get { return tipos; }
            set { tipos = value; this.Text = ""; }
        }



        private enumRequerido requerido = enumRequerido.NO;
        public enumRequerido Requerido
        {
            get { return requerido; }
            set
            {
                requerido = value;
                if (value == enumRequerido.SI)
                {
                    errorProvider2.SetError(this, "Campo Requerido");
                    errorProvider2.SetIconPadding(this, 5);
                }
            }
           
        }

        public gesTextBox()
        {//Iniciamos los valores por defecto
            InitializeComponent();
            colorTextoVacio = Color.Gray;
            textoVacio = "<Descripcion>";

        }
        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaskedTextBox));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();

            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
           
            //this.BackColor = System.Drawing.Color.White;
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.GesTextBox_Layout);
            //this.Leave += new System.EventHandler(this.Validarting); 
            this.Validating += new CancelEventHandler(this.Validarting);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.Enter += new System.EventHandler(this.GesTextBox_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.VisibleChanged += new EventHandler(this.Validarting);
            this.ResumeLayout(false);

        }
        #endregion

    
        private void GesTextBox_Layout(object sender, LayoutEventArgs e)
        {
            if (this.Text.Length>0)
            errorProvider2.Clear();

        }
        private void GesTextBox_Enter(object sender, EventArgs e)
        {
            //cambio el color de fondo al txt para que el usuario distinga cual se esta editando    
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.Beige;
        }


        //Variables privadas
        bool bndTextoVacio = false;//Bandera que nos indica si esta activo el TextoVacio
                                   //Constructor
  
        //Creamos un metodo que nos ayudara a verificar si se inserta el texto vacio o no
        private void VerificaTextoVacio()
        {

            if (this.Text.Length > 0)
                errorProvider2.Clear();
            // en caso contrario activamos la bandera

        
            this.Refresh();//Refrescamos el textbox
            //if (this.Text.Length > 0)
            //    bndTextoVacio = false; // como el textbox tiene contenido desactivamos el textoVacio
            //else
            //    bndTextoVacio = true; // en caso contrario activamos la bandera

            //this.SetStyle(ControlStyles.UserPaint, bndTextoVacio);//Esto nos permitira poder acceder al evento Paint del TextBox segun la bandera
            //this.Refresh();//Refrescamos el textbox
        }

        //Sobreescrivimos los metodos del textbox
        protected override void OnCreateControl()//Cuando se crea el control en el Form
        {
            base.OnCreateControl();
            //VerificaTextoVacio();//Verificamos si debe activarse el TextoVacio
            //errorProvider2.Clear();
            //errorProvider1.Clear();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary>
        /// ocurre cuando el control deja de ser el control activo del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void Validarting(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            //vuelvo a setear el color
            //cambio el color de fondo al txt para que el usuario distinga cual se esta editando    
            //this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BackColor = System.Drawing.Color.White;
            //vuelvo a setear el color
            bool error = false;
            gesTextBox sd = (gesTextBox)sender;
            Regex regStr;
            switch (tipos)
            {
                case enumTipos.Fecha:
                    regStr = new Regex(@"\d{2}/\d{2}/\d{4}");
                    if (!regStr.IsMatch(sd.Text))
                    {
                        errorProvider1.SetError(this, "La fecha no es válida; dd/mm/yyyy");
                        error = true;
                    }
                    break;
                case enumTipos.TelefonoConArea:
                    regStr = new Regex(@"\d{3}-\d{3}-\d{4}");
                    if (!regStr.IsMatch(sd.Text))

                    {
                        errorProvider1.SetError(this, "El telefono no es válido; xxx-xxx-xxxx");
                        error = true;
                    }
                    break;
                case enumTipos.Email:
                    {
                        regStr = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                        if (!regStr.IsMatch(sd.Text))
                        { 
                            errorProvider1.SetError(this, "El Email no es válido; xxxxxx@xxxx");
                            error = true;
                        }
                    }
                    break;

                case enumTipos.Decimal:
                    {
                        regStr = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
                        if (!regStr.IsMatch(sd.Text))
                        {
                            errorProvider1.SetError(this, "El valor debe ser numerico");
                            error = true;
                        }
                    }
                    break;
                case enumTipos.Numero:
                    {
                        regStr = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
                        if (!regStr.IsMatch(sd.Text))
                        {
                            errorProvider1.SetError(this, "El valor debe ser numerico");
                            error = true;
                        }
                    }
                    break;
            }

            if (error)
            {
                this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.BackColor = System.Drawing.Color.Red;
                sd.SelectNextControl(sd, true, true, true, true);

            }

        }

        protected void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider2.Clear();
            gesTextBox sd = (gesTextBox)sender;
            switch (tipos)
            {
                case enumTipos.Numero:
                    sd.Numero(e);
                    break;
                case enumTipos.Decimal:
                    sd.Decimal(e);
                    break;
                case enumTipos.Fecha:
                    sd.Date(e);
                    break;
                case enumTipos.TelefonoConArea:
                    sd.Telefono(e, 3, 3);
                    break;
                case enumTipos.Email:
                    //regStr = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                    //if (!regStr.IsMatch(sd.Text))
                    //    errorProvider1.SetError(this, "El Email no es válido; xxxxxx@xxxx");
                    break;
            }

        }

        private void Numero(KeyPressEventArgs e)
        {
            //enable to using Keyboard Ctrl+C and Keyboard Ctrl+V
            if (e.KeyChar == (char)3 || e.KeyChar == (char)22 || e.KeyChar == (char)24 || e.KeyChar == (char)26)
            {
                e.Handled = false;
                return;
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                errorProvider1.SetError(this, "");
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(this, "Ingrese solo valores numéricos ");
            }
        }


        private void Decimal(KeyPressEventArgs e)
        {
            //enable to using Keyboard Ctrl+C and Keyboard Ctrl+V
            if (e.KeyChar == (char)3 || e.KeyChar == (char)22 || e.KeyChar == (char)24 || e.KeyChar == (char)26)
            {
                e.Handled = false;
                return;
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8 || e.KeyChar == '-')
            {
                // if select all reset vars
                if (this.SelectionLength == this.Text.Length)
                {
                    if (e.KeyChar != (char)22)
                        this.Text = null;
                }
                else
                {
                    if (ReplaceSelectionOrInsert(e, this.Text.Length))
                        return;
                }
                e.Handled = false;
                errorProvider1.SetError(this, "");
                string str = this.Text;
                if (e.KeyChar == '.')
                {
                    int indx = str.IndexOf('.', 0);
                    if (indx > 0)
                    {
                        errorProvider1.SetError(this, "No puede ingresar mas de un punto decimal");
                    }
                }
                if (e.KeyChar == '-' && str.Length > 0)
                {
                    e.Handled = true;
                    errorProvider1.SetError(this, "'-' Solo puede estar en posición de inicio");
                }
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(this, "Solo válido para digitos y punto decimal");
            }
        }

        private bool ReplaceSelectionOrInsert(KeyPressEventArgs e, int len)
        {
            int selectStart = this.SelectionStart;
            int selectLen = this.SelectionLength;
            if (selectLen > 0)
            {
                string str;
                str = this.Text.Remove(selectStart, selectLen);
                this.Text = str.Insert(selectStart, e.KeyChar.ToString());
                e.Handled = true;
                this.SelectionStart = selectStart + 1;
                return true;
            }
            else if (selectLen == 0 && SelectionStart > 0 && SelectionStart < len)
            {
                string str = this.Text;
                if (e.KeyChar == 8)
                {
                    this.Text = str.Remove(selectStart - 1, 1);
                    this.SelectionStart = selectStart - 1;
                }
                else
                {
                    this.Text = str.Insert(selectStart, e.KeyChar.ToString());
                    this.SelectionStart = selectStart + 1;
                }
                e.Handled = true;
                return true;
            }
            return false;
        }


        private void Date(KeyPressEventArgs e)
        {
            int len = this.Text.Length;
            int indx = this.Text.LastIndexOf("/");

            //enable to using Keyboard Ctrl+C and Keyboard Ctrl+V
            if (e.KeyChar == (char)3 || e.KeyChar == (char)22 || e.KeyChar == (char)24 || e.KeyChar == (char)26)
            {
                e.Handled = false;
                return;
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '/' || e.KeyChar == 8)
            {
                // if select all reset vars
                if (this.SelectionLength == len)
                {
                    indx = -1;
                    digitPos = 0;
                    DelimitNumber = 0;
                    this.Text = null;
                }
                else
                {
                    if (ReplaceSelectionOrInsert(e, len))
                        return;
                }

                string tmp = this.Text;
                if (e.KeyChar != 8)
                {
                    if (e.KeyChar != '/')
                    {
                        if (indx > 0)
                            digitPos = len - indx;
                        else
                            digitPos++;

                        if (digitPos == 3 && DelimitNumber < 2)
                        {
                            if (e.KeyChar != '/')
                            {
                                DelimitNumber++;
                                this.AppendText("/");
                            }
                        }

                        errorProvider1.SetError(this, "");
                        if ((digitPos == 2 || (Int32.Parse(e.KeyChar.ToString()) > 1 && DelimitNumber == 0)))
                        {
                            string tmp2;
                            if (indx == -1)
                                tmp2 = e.KeyChar.ToString();
                            else
                                tmp2 = this.Text.Substring(indx + 1) + e.KeyChar.ToString();

                            if (DelimitNumber < 2)
                            {
                                if (digitPos == 1) this.AppendText("0");
                                this.AppendText(e.KeyChar.ToString());
                                if (indx < 0)
                                {
                                    if (Int32.Parse(this.Text) > 12) // check validation
                                    {
                                        string str;
                                        str = this.Text.Insert(0, "0");
                                        if (Int32.Parse(this.Text) > 13)
                                        {
                                            this.Text = str.Insert(2, "/0");
                                            DelimitNumber++;
                                            this.AppendText("/");
                                        }
                                        else
                                        {
                                            this.Text = str.Insert(2, "/");
                                            this.AppendText("");
                                        }
                                        DelimitNumber++;
                                    }
                                    else
                                    {
                                        this.AppendText("/");
                                        DelimitNumber++;
                                    }
                                    e.Handled = true;
                                }
                                else
                                {
                                    if (DelimitNumber == 1)
                                    {
                                        int m = Int32.Parse(this.Text.Substring(0, indx));
                                        if (!CheckDayOfMonth(m, Int32.Parse(tmp2)))
                                        {
                                            errorProvider1.SetError(this, "Asegúrese de que este mes tiene el día");
                                            e.Handled = true;
                                            return;
                                        }
                                        else
                                        {
                                            this.AppendText("/");
                                            DelimitNumber++;
                                            e.Handled = true;
                                        }
                                    }
                                }
                            }
                        }
                        else if (digitPos == 1 && Int32.Parse(e.KeyChar.ToString()) > 3 && DelimitNumber < 2)
                        {
                            if (digitPos == 1) this.AppendText("0");
                            this.AppendText(e.KeyChar.ToString());
                            this.AppendText("/");
                            DelimitNumber++;
                            e.Handled = true;
                        }
                        else
                        {
                            if (digitPos == 1 && DelimitNumber == 2 && e.KeyChar > '2')
                                errorProvider1.SetError(this, "El año debe comenzar con 1 ó 2");
                        }
                        if (digitPos > 4)
                            e.Handled = true;
                    }
                    else
                    {
                        if ((this.Text.Length == 3) || (this.Text.Length == 6) || DelimitNumber > 1)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            DelimitNumber++;
                            string tmp3;
                            if (indx == -1)
                                tmp3 = this.Text.Substring(indx + 1);
                            else
                                tmp3 = this.Text;
                            if (digitPos == 1)
                            {
                                this.Text = tmp3.Insert(indx + 1, "0"); ;
                                this.AppendText("/");
                                e.Handled = true;
                            }
                        }
                    }
                }
                else
                {
                    e.Handled = false;
                    if ((len - indx) == 1)
                    {
                        DelimitNumber--;
                        if (indx > -1)
                            digitPos = 2;
                        else
                            digitPos--;
                    }
                    else
                    {
                        if (indx > -1)
                            digitPos = len - indx - 1;
                        else
                            digitPos = len - 1;
                    }
                }
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(this, "Sólo válido para dígitos y /");
            }
        }

        private bool CheckDayOfMonth(int mon, int day)
        {
            bool ret = true;
            if (day == 0) ret = false;
            switch (mon)
            {
                case 1:
                    if (day > 31)
                        ret = false;
                    break;
                case 2:
                    System.DateTime moment = DateTime.Now;
                    int year = moment.Year;
                    int d = ((year % 4 == 0) && ((!(year % 100 == 0)) || (year % 400 == 0))) ? 29 : 28;
                    if (day > d)
                        ret = false;
                    break;
                case 3:
                    if (day > 31)
                        ret = false;
                    break;
                case 4:
                    if (day > 30)
                        ret = false;
                    break;
                case 5:
                    if (day > 31)
                        ret = false;
                    break;
                case 6:
                    if (day > 30)
                        ret = false;
                    break;
                case 7:
                    if (day > 31)
                        ret = false;
                    break;
                case 8:
                    if (day > 31)
                        ret = false;
                    break;
                case 9:
                    if (day > 30)
                        ret = false;
                    break;
                case 10:
                    if (day > 31)
                        ret = false;
                    break;
                case 11:
                    if (day > 30)
                        ret = false;
                    break;
                case 12:
                    if (day > 31)
                        ret = false;
                    break;
                default:
                    ret = false;
                    break;
            }
            return ret;
        }

        private void Telefono(KeyPressEventArgs e, int pos, int pos2)
        {
            int len = this.Text.Length;
            int indx = this.Text.LastIndexOf("-");
            //enable to using Keyboard Ctrl+C and Keyboard Ctrl+V
            if (e.KeyChar == (char)3 || e.KeyChar == (char)22 || e.KeyChar == (char)24 || e.KeyChar == (char)26)
            {
                e.Handled = false;
                return;
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == 8)
            { // only digit, Backspace and - are accepted
              // if select all reset vars
                if (this.SelectionLength == len)
                {
                    indx = -1;
                    digitPos = 0;
                    DelimitNumber = 0;
                    this.Text = null;
                }
                else
                {
                    if (ReplaceSelectionOrInsert(e, len))
                        return;
                }
                string tmp = this.Text;
                if (e.KeyChar != 8)
                {
                    errorProvider1.SetError(this, "");
                    if (e.KeyChar != '-')
                    {
                        if (indx > 0)
                            digitPos = len - indx;
                        else
                            digitPos++;
                    }
                    if (indx > -1 && digitPos == pos2 && DelimitNumber == 1)
                    {
                        if (e.KeyChar != '-')
                        {
                            this.AppendText(e.KeyChar.ToString());
                            this.AppendText("-");
                            e.Handled = true;
                            DelimitNumber++;
                        }
                    }
                    if (digitPos == pos && DelimitNumber == 0)
                    {
                        if (e.KeyChar != '-')
                        {
                            this.AppendText(e.KeyChar.ToString());
                            this.AppendText("-");
                            e.Handled = true;
                            DelimitNumber++;
                        }
                    }
                    if (digitPos > 4)
                        e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                    if ((len - indx) == 1)
                    {
                        DelimitNumber--;
                        if ((indx) > -1)
                            digitPos = len - indx;
                        else
                            digitPos--;
                    }
                    else
                    {
                        if (indx > -1)
                            digitPos = len - indx - 1;
                        else
                            digitPos = len - 1;
                    }
                }
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(this, "Sólo válido para dígitos y --");
            }
        }
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            //VerificaTextoVacio();//cada vez que cambie el texto del TextBox verificamos si se debe activar el TextoVacio
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ////Aqui mostramos en el textBox el contenido del TextoVacio, o el Contenido del TextBox segun sea el caso
            //if (bndTextoVacio) //si esta activo el textoVacio
            //    e.Graphics.DrawString(textoVacio, new Font(this.Font, FontStyle.Italic), new SolidBrush(colorTextoVacio), new Point(0, 0));
            //else
            //    e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
            //base.OnPaint(e);
        }
    }

}
