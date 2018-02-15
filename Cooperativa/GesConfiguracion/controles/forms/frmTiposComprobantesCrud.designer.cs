namespace GesConfiguracion
{
    partial class frmTiposComprobantesCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposComprobantesCrud));
            this.gbDatos = new Controles.contenedores.gesGroup();
            this.txtTCOletra = new Controles.textBoxes.gesTextBox();
            this.txtTCOcodigo = new Controles.textBoxes.gesTextBox();
            this.chkPreimpreso = new Controles.datos.chkBox();
            this.chkLibroIvaVenta = new Controles.datos.chkBox();
            this.chkLibroIvaCompra = new Controles.datos.chkBox();
            this.chkTCOExterno = new Controles.datos.chkBox();
            this.lblTitulo4 = new Controles.labels.lblTitulo();
            this.lblLibroIC = new Controles.labels.lblTitulo();
            this.lblExterno = new Controles.labels.lblTitulo();
            this.lblEtiqueta1 = new Controles.labels.lblEtiqueta();
            this.txtCodigoRece = new Controles.textBoxes.txtDescripcionCorta();
            this.txtCantMinImpreciones = new Controles.textBoxes.txtDescripcionCorta();
            this.txtCodigoSicore = new Controles.textBoxes.txtDescripcionCorta();
            this.lblPreimpreso = new Controles.labels.lblTitulo();
            this.txtCodigoAfip = new Controles.textBoxes.txtDescripcionCorta();
            this.lblTitulo5 = new Controles.labels.lblTitulo();
            this.lblTitulo3 = new Controles.labels.lblTitulo();
            this.lblCodigoSicore = new Controles.labels.lblTitulo();
            this.txtPCBCodigo = new Controles.textBoxes.txtDescripcionCorta();
            this.lblCodigoAfip = new Controles.labels.lblTitulo();
            this.txtTCOCantidadCopias = new Controles.textBoxes.txtDescripcionCorta();
            this.lblTitulo2 = new Controles.labels.lblTitulo();
            this.txtTCoorigenNumerado = new Controles.textBoxes.txtDescripcionCorta();
            this.lblCantidadCopias = new Controles.labels.lblTitulo();
            this.chkEstado = new Controles.datos.chkBox();
            this.lblTitulo1 = new Controles.labels.lblTitulo();
            this.txtDescripcion = new Controles.textBoxes.txtDescripcionCorta();
            this.lblCodigo = new Controles.labels.lblTitulo();
            this.lblDescripcionCorta = new Controles.labels.lblTitulo();
            this.lblLetra = new Controles.labels.lblEtiqueta();
            this.gesGroup2 = new Controles.contenedores.gesGroup();
            this.btnCancelar = new Controles.buttons.btnCancelar();
            this.btnAceptar = new Controles.buttons.btnAceptar();
            this.gbDatos.SuspendLayout();
            this.gesGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtTCOletra);
            this.gbDatos.Controls.Add(this.txtTCOcodigo);
            this.gbDatos.Controls.Add(this.chkPreimpreso);
            this.gbDatos.Controls.Add(this.chkLibroIvaVenta);
            this.gbDatos.Controls.Add(this.chkLibroIvaCompra);
            this.gbDatos.Controls.Add(this.chkTCOExterno);
            this.gbDatos.Controls.Add(this.lblTitulo4);
            this.gbDatos.Controls.Add(this.lblLibroIC);
            this.gbDatos.Controls.Add(this.lblExterno);
            this.gbDatos.Controls.Add(this.lblEtiqueta1);
            this.gbDatos.Controls.Add(this.txtCodigoRece);
            this.gbDatos.Controls.Add(this.txtCantMinImpreciones);
            this.gbDatos.Controls.Add(this.txtCodigoSicore);
            this.gbDatos.Controls.Add(this.lblPreimpreso);
            this.gbDatos.Controls.Add(this.txtCodigoAfip);
            this.gbDatos.Controls.Add(this.lblTitulo5);
            this.gbDatos.Controls.Add(this.lblTitulo3);
            this.gbDatos.Controls.Add(this.lblCodigoSicore);
            this.gbDatos.Controls.Add(this.txtPCBCodigo);
            this.gbDatos.Controls.Add(this.lblCodigoAfip);
            this.gbDatos.Controls.Add(this.txtTCOCantidadCopias);
            this.gbDatos.Controls.Add(this.lblTitulo2);
            this.gbDatos.Controls.Add(this.txtTCoorigenNumerado);
            this.gbDatos.Controls.Add(this.lblCantidadCopias);
            this.gbDatos.Controls.Add(this.chkEstado);
            this.gbDatos.Controls.Add(this.lblTitulo1);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.lblDescripcionCorta);
            this.gbDatos.Controls.Add(this.lblLetra);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(440, 385);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtTCOletra
            // 
            this.txtTCOletra.BackColor = System.Drawing.Color.White;
            this.txtTCOletra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTCOletra.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtTCOletra.Location = new System.Drawing.Point(346, 61);
            this.txtTCOletra.MaxLength = 1;
            this.txtTCOletra.Name = "txtTCOletra";
            this.txtTCOletra.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtTCOletra.Size = new System.Drawing.Size(60, 20);
            this.txtTCOletra.TabIndex = 3;
            this.txtTCOletra.TextoVacio = "<Descripcion>";
            this.txtTCOletra.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // txtTCOcodigo
            // 
            this.txtTCOcodigo.BackColor = System.Drawing.Color.White;
            this.txtTCOcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTCOcodigo.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtTCOcodigo.Location = new System.Drawing.Point(346, 9);
            this.txtTCOcodigo.MaxLength = 3;
            this.txtTCOcodigo.Name = "txtTCOcodigo";
            this.txtTCOcodigo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtTCOcodigo.Size = new System.Drawing.Size(60, 20);
            this.txtTCOcodigo.TabIndex = 1;
            this.txtTCOcodigo.TextoVacio = "<Descripcion>";
            this.txtTCOcodigo.TipoControl = Controles.util.Enumerados.enumTipos.Ninguna;
            // 
            // chkPreimpreso
            // 
            this.chkPreimpreso.AutoSize = true;
            this.chkPreimpreso.Location = new System.Drawing.Point(391, 314);
            this.chkPreimpreso.Name = "chkPreimpreso";
            this.chkPreimpreso.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.chkPreimpreso.Size = new System.Drawing.Size(15, 14);
            this.chkPreimpreso.TabIndex = 13;
            this.chkPreimpreso.UseVisualStyleBackColor = true;
            // 
            // chkLibroIvaVenta
            // 
            this.chkLibroIvaVenta.AutoSize = true;
            this.chkLibroIvaVenta.Location = new System.Drawing.Point(391, 235);
            this.chkLibroIvaVenta.Name = "chkLibroIvaVenta";
            this.chkLibroIvaVenta.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkLibroIvaVenta.Size = new System.Drawing.Size(15, 14);
            this.chkLibroIvaVenta.TabIndex = 10;
            this.chkLibroIvaVenta.UseVisualStyleBackColor = true;
            // 
            // chkLibroIvaCompra
            // 
            this.chkLibroIvaCompra.AutoSize = true;
            this.chkLibroIvaCompra.Location = new System.Drawing.Point(391, 215);
            this.chkLibroIvaCompra.Name = "chkLibroIvaCompra";
            this.chkLibroIvaCompra.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.chkLibroIvaCompra.Size = new System.Drawing.Size(15, 14);
            this.chkLibroIvaCompra.TabIndex = 9;
            this.chkLibroIvaCompra.UseVisualStyleBackColor = true;
            // 
            // chkTCOExterno
            // 
            this.chkTCOExterno.AutoSize = true;
            this.chkTCOExterno.Location = new System.Drawing.Point(391, 114);
            this.chkTCOExterno.Name = "chkTCOExterno";
            this.chkTCOExterno.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.chkTCOExterno.Size = new System.Drawing.Size(15, 14);
            this.chkTCOExterno.TabIndex = 5;
            this.chkTCOExterno.UseVisualStyleBackColor = true;
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.AutoSize = true;
            this.lblTitulo4.Location = new System.Drawing.Point(4, 242);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(89, 13);
            this.lblTitulo4.TabIndex = 42;
            this.lblTitulo4.Text = "Libro IVA Ventas:";
            // 
            // lblLibroIC
            // 
            this.lblLibroIC.AutoSize = true;
            this.lblLibroIC.Location = new System.Drawing.Point(4, 219);
            this.lblLibroIC.Name = "lblLibroIC";
            this.lblLibroIC.Size = new System.Drawing.Size(97, 13);
            this.lblLibroIC.TabIndex = 42;
            this.lblLibroIC.Text = "Libro IVA Compras:";
            // 
            // lblExterno
            // 
            this.lblExterno.AutoSize = true;
            this.lblExterno.Location = new System.Drawing.Point(6, 118);
            this.lblExterno.Name = "lblExterno";
            this.lblExterno.Size = new System.Drawing.Size(80, 13);
            this.lblExterno.TabIndex = 42;
            this.lblExterno.Text = "Origen Externo:";
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Location = new System.Drawing.Point(0, 363);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(43, 13);
            this.lblEtiqueta1.TabIndex = 40;
            this.lblEtiqueta1.Text = "Estado:";
            // 
            // txtCodigoRece
            // 
            this.txtCodigoRece.BackColor = System.Drawing.Color.White;
            this.txtCodigoRece.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoRece.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtCodigoRece.Location = new System.Drawing.Point(346, 333);
            this.txtCodigoRece.MaxLength = 2;
            this.txtCodigoRece.Name = "txtCodigoRece";
            this.txtCodigoRece.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtCodigoRece.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoRece.TabIndex = 14;
            this.txtCodigoRece.TextoVacio = "<Descripcion>";
            this.txtCodigoRece.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // txtCantMinImpreciones
            // 
            this.txtCantMinImpreciones.BackColor = System.Drawing.Color.Red;
            this.txtCantMinImpreciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantMinImpreciones.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtCantMinImpreciones.Location = new System.Drawing.Point(346, 287);
            this.txtCantMinImpreciones.MaxLength = 5555;
            this.txtCantMinImpreciones.Name = "txtCantMinImpreciones";
            this.txtCantMinImpreciones.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtCantMinImpreciones.Size = new System.Drawing.Size(60, 20);
            this.txtCantMinImpreciones.TabIndex = 12;
            this.txtCantMinImpreciones.TextoVacio = "<Descripcion>";
            this.txtCantMinImpreciones.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // txtCodigoSicore
            // 
            this.txtCodigoSicore.BackColor = System.Drawing.Color.White;
            this.txtCodigoSicore.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSicore.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtCodigoSicore.Location = new System.Drawing.Point(346, 265);
            this.txtCodigoSicore.MaxLength = 2;
            this.txtCodigoSicore.Name = "txtCodigoSicore";
            this.txtCodigoSicore.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtCodigoSicore.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoSicore.TabIndex = 11;
            this.txtCodigoSicore.TextoVacio = "<Descripcion>";
            this.txtCodigoSicore.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // lblPreimpreso
            // 
            this.lblPreimpreso.AutoSize = true;
            this.lblPreimpreso.Location = new System.Drawing.Point(4, 314);
            this.lblPreimpreso.Name = "lblPreimpreso";
            this.lblPreimpreso.Size = new System.Drawing.Size(62, 13);
            this.lblPreimpreso.TabIndex = 31;
            this.lblPreimpreso.Text = "Preimpreso:";
            // 
            // txtCodigoAfip
            // 
            this.txtCodigoAfip.BackColor = System.Drawing.Color.White;
            this.txtCodigoAfip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoAfip.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtCodigoAfip.Location = new System.Drawing.Point(346, 189);
            this.txtCodigoAfip.MaxLength = 2;
            this.txtCodigoAfip.Name = "txtCodigoAfip";
            this.txtCodigoAfip.Requerido = Controles.util.Enumerados.enumRequerido.NO;
            this.txtCodigoAfip.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoAfip.TabIndex = 8;
            this.txtCodigoAfip.TextoVacio = "<Descripcion>";
            this.txtCodigoAfip.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // lblTitulo5
            // 
            this.lblTitulo5.AutoSize = true;
            this.lblTitulo5.Location = new System.Drawing.Point(4, 340);
            this.lblTitulo5.Name = "lblTitulo5";
            this.lblTitulo5.Size = new System.Drawing.Size(75, 13);
            this.lblTitulo5.TabIndex = 31;
            this.lblTitulo5.Text = "Codigo RECE:";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Location = new System.Drawing.Point(4, 294);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(162, 13);
            this.lblTitulo3.TabIndex = 31;
            this.lblTitulo3.Text = "Cantidad Minima de impreciones:";
            // 
            // lblCodigoSicore
            // 
            this.lblCodigoSicore.AutoSize = true;
            this.lblCodigoSicore.Location = new System.Drawing.Point(4, 268);
            this.lblCodigoSicore.Name = "lblCodigoSicore";
            this.lblCodigoSicore.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoSicore.TabIndex = 31;
            this.lblCodigoSicore.Text = "Codigo SICORE:";
            // 
            // txtPCBCodigo
            // 
            this.txtPCBCodigo.BackColor = System.Drawing.Color.White;
            this.txtPCBCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPCBCodigo.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPCBCodigo.Location = new System.Drawing.Point(346, 163);
            this.txtPCBCodigo.MaxLength = 3;
            this.txtPCBCodigo.Name = "txtPCBCodigo";
            this.txtPCBCodigo.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtPCBCodigo.Size = new System.Drawing.Size(60, 20);
            this.txtPCBCodigo.TabIndex = 7;
            this.txtPCBCodigo.TextoVacio = "<Descripcion>";
            this.txtPCBCodigo.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // lblCodigoAfip
            // 
            this.lblCodigoAfip.AutoSize = true;
            this.lblCodigoAfip.Location = new System.Drawing.Point(6, 196);
            this.lblCodigoAfip.Name = "lblCodigoAfip";
            this.lblCodigoAfip.Size = new System.Drawing.Size(69, 13);
            this.lblCodigoAfip.TabIndex = 31;
            this.lblCodigoAfip.Text = "Codigo AFIP:";
            // 
            // txtTCOCantidadCopias
            // 
            this.txtTCOCantidadCopias.BackColor = System.Drawing.Color.Red;
            this.txtTCOCantidadCopias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTCOCantidadCopias.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtTCOCantidadCopias.Location = new System.Drawing.Point(346, 137);
            this.txtTCOCantidadCopias.MaxLength = 1;
            this.txtTCOCantidadCopias.Name = "txtTCOCantidadCopias";
            this.txtTCOCantidadCopias.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtTCOCantidadCopias.Size = new System.Drawing.Size(60, 20);
            this.txtTCOCantidadCopias.TabIndex = 6;
            this.txtTCOCantidadCopias.TextoVacio = "<Descripcion>";
            this.txtTCOCantidadCopias.TipoControl = Controles.util.Enumerados.enumTipos.Numero;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Location = new System.Drawing.Point(6, 170);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(67, 13);
            this.lblTitulo2.TabIndex = 31;
            this.lblTitulo2.Text = "PCB Codigo:";
            // 
            // txtTCoorigenNumerado
            // 
            this.txtTCoorigenNumerado.BackColor = System.Drawing.Color.White;
            this.txtTCoorigenNumerado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTCoorigenNumerado.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtTCoorigenNumerado.Location = new System.Drawing.Point(346, 88);
            this.txtTCoorigenNumerado.MaxLength = 1;
            this.txtTCoorigenNumerado.Name = "txtTCoorigenNumerado";
            this.txtTCoorigenNumerado.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtTCoorigenNumerado.Size = new System.Drawing.Size(60, 20);
            this.txtTCoorigenNumerado.TabIndex = 4;
            this.txtTCoorigenNumerado.TextoVacio = "<Descripcion>";
            this.txtTCoorigenNumerado.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // lblCantidadCopias
            // 
            this.lblCantidadCopias.AutoSize = true;
            this.lblCantidadCopias.Location = new System.Drawing.Point(6, 144);
            this.lblCantidadCopias.Name = "lblCantidadCopias";
            this.lblCantidadCopias.Size = new System.Drawing.Size(101, 13);
            this.lblCantidadCopias.TabIndex = 31;
            this.lblCantidadCopias.Text = "Cantidad de copias:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(391, 359);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 15;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Location = new System.Drawing.Point(4, 95);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(96, 13);
            this.lblTitulo1.TabIndex = 31;
            this.lblTitulo1.Text = "Origen Numerador:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(115, 35);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Requerido = Controles.util.Enumerados.enumRequerido.SI;
            this.txtDescripcion.Size = new System.Drawing.Size(291, 20);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextoVacio = "<Descripcion>";
            this.txtDescripcion.TipoControl = Controles.util.Enumerados.enumTipos.Letra;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 31;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(4, 42);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionCorta.TabIndex = 31;
            this.lblDescripcionCorta.Text = "Descripcion:";
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Location = new System.Drawing.Point(4, 69);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(34, 13);
            this.lblLetra.TabIndex = 27;
            this.lblLetra.Text = "Letra:";
            // 
            // gesGroup2
            // 
            this.gesGroup2.Controls.Add(this.btnCancelar);
            this.gesGroup2.Controls.Add(this.btnAceptar);
            this.gesGroup2.Location = new System.Drawing.Point(266, 403);
            this.gesGroup2.Name = "gesGroup2";
            this.gesGroup2.Size = new System.Drawing.Size(178, 89);
            this.gesGroup2.TabIndex = 6;
            this.gesGroup2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(6, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(92, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 60);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmTiposComprobantesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 495);
            this.Controls.Add(this.gesGroup2);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmTiposComprobantesCrud";
            this.Text = "frmTiposComprobantesCrud";
            this.Load += new System.EventHandler(this.frmTiposComprobantesCrud_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gesGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Controles.contenedores.gesGroup gbDatos;
        private Controles.labels.lblEtiqueta lblEtiqueta1;
        private Controles.datos.chkBox chkEstado;
        private Controles.textBoxes.txtDescripcionCorta txtDescripcion;
        private Controles.labels.lblTitulo lblDescripcionCorta;
        private Controles.labels.lblEtiqueta lblLetra;
        private Controles.contenedores.gesGroup gesGroup2;
        private Controles.buttons.btnCancelar btnCancelar;
        private Controles.buttons.btnAceptar btnAceptar;
        private Controles.datos.chkBox chkTCOExterno;
        private Controles.labels.lblTitulo lblExterno;
        private Controles.textBoxes.txtDescripcionCorta txtTCoorigenNumerado;
        private Controles.labels.lblTitulo lblTitulo1;
        private Controles.labels.lblTitulo lblCodigo;
        private Controles.textBoxes.txtDescripcionCorta txtCodigoAfip;
        private Controles.textBoxes.txtDescripcionCorta txtPCBCodigo;
        private Controles.labels.lblTitulo lblCodigoAfip;
        private Controles.textBoxes.txtDescripcionCorta txtTCOCantidadCopias;
        private Controles.labels.lblTitulo lblTitulo2;
        private Controles.labels.lblTitulo lblCantidadCopias;
        private Controles.datos.chkBox chkLibroIvaVenta;
        private Controles.datos.chkBox chkLibroIvaCompra;
        private Controles.labels.lblTitulo lblTitulo4;
        private Controles.labels.lblTitulo lblLibroIC;
        private Controles.textBoxes.txtDescripcionCorta txtCodigoSicore;
        private Controles.labels.lblTitulo lblCodigoSicore;
        private Controles.datos.chkBox chkPreimpreso;
        private Controles.textBoxes.txtDescripcionCorta txtCodigoRece;
        private Controles.textBoxes.txtDescripcionCorta txtCantMinImpreciones;
        private Controles.labels.lblTitulo lblPreimpreso;
        private Controles.labels.lblTitulo lblTitulo5;
        private Controles.labels.lblTitulo lblTitulo3;
        private Controles.textBoxes.gesTextBox txtTCOletra;
        private Controles.textBoxes.gesTextBox txtTCOcodigo;
    }
}