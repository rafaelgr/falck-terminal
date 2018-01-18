namespace LainsaSciTerminal
{
    partial class DispositivoNew
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
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuSalir = new System.Windows.Forms.MenuItem();
            this.mnuAceptar = new System.Windows.Forms.MenuItem();
            this.txtCaptura = new System.Windows.Forms.TextBox();
            this.lblCaptura = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbAgenteExtintor = new System.Windows.Forms.ComboBox();
            this.lblAgenteExtintor = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblFechaFabricacion = new System.Windows.Forms.Label();
            this.dtFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.txtCargaKg = new System.Windows.Forms.TextBox();
            this.lblCargaKg = new System.Windows.Forms.Label();
            this.cmbInst = new System.Windows.Forms.ComboBox();
            this.lblInstalacion = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuSalir);
            this.mnuMain.MenuItems.Add(this.mnuAceptar);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuAceptar
            // 
            this.mnuAceptar.Text = "Aceptar";
            this.mnuAceptar.Click += new System.EventHandler(this.mnuAceptar_Click);
            // 
            // txtCaptura
            // 
            this.txtCaptura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaptura.Location = new System.Drawing.Point(16, 48);
            this.txtCaptura.Name = "txtCaptura";
            this.txtCaptura.Size = new System.Drawing.Size(202, 21);
            this.txtCaptura.TabIndex = 1;
            this.txtCaptura.TextChanged += new System.EventHandler(this.txtCaptura_TextChanged);
            // 
            // lblCaptura
            // 
            this.lblCaptura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaptura.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblCaptura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCaptura.Location = new System.Drawing.Point(34, 11);
            this.lblCaptura.Name = "lblCaptura";
            this.lblCaptura.Size = new System.Drawing.Size(156, 34);
            this.lblCaptura.Text = "Lea o introduzca el código de barras";
            this.lblCaptura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.cmbAgenteExtintor);
            this.panel2.Controls.Add(this.lblAgenteExtintor);
            this.panel2.Controls.Add(this.cmbFabricante);
            this.panel2.Controls.Add(this.lblFabricante);
            this.panel2.Controls.Add(this.lblFechaFabricacion);
            this.panel2.Controls.Add(this.dtFechaFabricacion);
            this.panel2.Controls.Add(this.cmbFuncion);
            this.panel2.Controls.Add(this.lblFuncion);
            this.panel2.Controls.Add(this.txtCargaKg);
            this.panel2.Controls.Add(this.lblCargaKg);
            this.panel2.Controls.Add(this.cmbInst);
            this.panel2.Controls.Add(this.lblInstalacion);
            this.panel2.Controls.Add(this.cmbModelo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 375);
            // 
            // cmbAgenteExtintor
            // 
            this.cmbAgenteExtintor.Location = new System.Drawing.Point(68, 318);
            this.cmbAgenteExtintor.Name = "cmbAgenteExtintor";
            this.cmbAgenteExtintor.Size = new System.Drawing.Size(155, 22);
            this.cmbAgenteExtintor.TabIndex = 24;
            // 
            // lblAgenteExtintor
            // 
            this.lblAgenteExtintor.Location = new System.Drawing.Point(3, 312);
            this.lblAgenteExtintor.Name = "lblAgenteExtintor";
            this.lblAgenteExtintor.Size = new System.Drawing.Size(68, 34);
            this.lblAgenteExtintor.Text = "Agente extintor";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.Location = new System.Drawing.Point(68, 282);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(155, 22);
            this.cmbFabricante.TabIndex = 21;
            // 
            // lblFabricante
            // 
            this.lblFabricante.Location = new System.Drawing.Point(3, 282);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(140, 20);
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblFechaFabricacion
            // 
            this.lblFechaFabricacion.Location = new System.Drawing.Point(3, 235);
            this.lblFechaFabricacion.Name = "lblFechaFabricacion";
            this.lblFechaFabricacion.Size = new System.Drawing.Size(68, 44);
            this.lblFechaFabricacion.Text = "Fecha fabricación";
            // 
            // dtFechaFabricacion
            // 
            this.dtFechaFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaFabricacion.Location = new System.Drawing.Point(77, 240);
            this.dtFechaFabricacion.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtFechaFabricacion.Name = "dtFechaFabricacion";
            this.dtFechaFabricacion.Size = new System.Drawing.Size(146, 22);
            this.dtFechaFabricacion.TabIndex = 16;
            this.dtFechaFabricacion.Value = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.Location = new System.Drawing.Point(68, 205);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(155, 22);
            this.cmbFuncion.TabIndex = 13;
            // 
            // lblFuncion
            // 
            this.lblFuncion.Location = new System.Drawing.Point(3, 205);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(140, 20);
            this.lblFuncion.Text = "Funcion";
            // 
            // txtCargaKg
            // 
            this.txtCargaKg.Location = new System.Drawing.Point(68, 169);
            this.txtCargaKg.Name = "txtCargaKg";
            this.txtCargaKg.Size = new System.Drawing.Size(155, 21);
            this.txtCargaKg.TabIndex = 10;
            // 
            // lblCargaKg
            // 
            this.lblCargaKg.Location = new System.Drawing.Point(3, 169);
            this.lblCargaKg.Name = "lblCargaKg";
            this.lblCargaKg.Size = new System.Drawing.Size(76, 23);
            this.lblCargaKg.Text = "Carga Kg.";
            // 
            // cmbInst
            // 
            this.cmbInst.Location = new System.Drawing.Point(68, 51);
            this.cmbInst.Name = "cmbInst";
            this.cmbInst.Size = new System.Drawing.Size(155, 22);
            this.cmbInst.TabIndex = 3;
            // 
            // lblInstalacion
            // 
            this.lblInstalacion.Location = new System.Drawing.Point(3, 51);
            this.lblInstalacion.Name = "lblInstalacion";
            this.lblInstalacion.Size = new System.Drawing.Size(68, 20);
            this.lblInstalacion.Text = "Instalación";
            // 
            // cmbModelo
            // 
            this.cmbModelo.Location = new System.Drawing.Point(53, 134);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(170, 22);
            this.cmbModelo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.Text = "Modelo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Location = new System.Drawing.Point(34, 89);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(189, 22);
            this.cmbTipo.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(3, 89);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 20);
            this.lblTipo.Text = "Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 21);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(3, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 23);
            this.lblNombre.Text = "Nombre";
            // 
            // DispositivoNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCaptura);
            this.Controls.Add(this.lblCaptura);
            this.KeyPreview = true;
            this.Menu = this.mnuMain;
            this.Name = "DispositivoNew";
            this.Text = "FALCK-SCI Dispositivo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DispositivoNew_KeyDown);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuSalir;
        private System.Windows.Forms.MenuItem mnuAceptar;
        private System.Windows.Forms.TextBox txtCaptura;
        private System.Windows.Forms.Label lblCaptura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbInst;
        private System.Windows.Forms.Label lblInstalacion;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.TextBox txtCargaKg;
        private System.Windows.Forms.Label lblCargaKg;
        private System.Windows.Forms.Label lblFechaFabricacion;
        private System.Windows.Forms.DateTimePicker dtFechaFabricacion;
        private System.Windows.Forms.ComboBox cmbAgenteExtintor;
        private System.Windows.Forms.Label lblAgenteExtintor;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label lblFabricante;

    }
}