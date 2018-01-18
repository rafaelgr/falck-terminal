using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using LainsaTerminalLib;

namespace LainsaSciTerminal
{
    public partial class DispositivoNew : Form
    {
        private TUsuario usuario;
        private SqlCeConnection conn;
        private TDispositivo dispositivo;
       
        public DispositivoNew(TUsuario usuario)
        {
            this.usuario = usuario;
            this.conn = CntSciTerminal.TSqlConnection();
            InitializeComponent();
            CargarInstalaciones();
            CargarTipos();
            CargarModelos();
            CargarFabricantes();
            CargarAgentesExtintores();
            CargarFunciones();
            dtFechaFabricacion.Format = DateTimePickerFormat.Custom;
            dtFechaFabricacion.CustomFormat = "dd/MM/yyyy";
            dtFechaFabricacion.Value = DateTime.Now;
            Cursor.Current = Cursors.Default;
        }
        private void CargarInstalaciones()
        {
            cmbInst.Items.Clear();
            cmbInst.DisplayMember = "Name";
            cmbInst.ValueMember = "ID";
            // cargamos el desplegable.
            CntSciTerminal.TOpen(this.conn);
            foreach (TInstalacion ttpa in CntSciTerminal.GetTInstalaciones(conn))
            {
                cmbInst.Items.Add(new ListItem(ttpa.InstalacionId, ttpa.Nombre));
            }
            CntSciTerminal.TClose(this.conn);
        }
        private void CargarTipos()
        {
            cmbTipo.Items.Clear();
            cmbTipo.DisplayMember = "Name";
            cmbTipo.ValueMember = "ID";
            // cargamos el desplegable.
            CntSciTerminal.TOpen(this.conn);
            foreach (TTipoDispositivo ttpa in CntSciTerminal.GetTTipoDispositivos(conn))
            {
                cmbTipo.Items.Add(new ListItem(ttpa.TipoDispositivoId, ttpa.Nombre));
            }
            CntSciTerminal.TClose(this.conn);
        }
        private void CargarModelos()
        {
            cmbModelo.Items.Clear();
            cmbModelo.Items.Add(new ListItem(-1, ""));
            cmbTipo.DisplayMember = "Name";
            cmbTipo.ValueMember = "ID";
            // cargamos el desplegable.
            CntSciTerminal.TOpen(this.conn);
            foreach (TModeloDispositivo ttpa in CntSciTerminal.GetTModeloDispositivos(conn))
            {
                cmbModelo.Items.Add(new ListItem(ttpa.ModeloDispositivoId, ttpa.Nombre));
            }
            CntSciTerminal.TClose(this.conn);
        }

        private void CargarFabricantes()
        {
            cmbFabricante.Items.Clear();
            cmbFabricante.Items.Add(new ListItem(-1, ""));
            cmbTipo.DisplayMember = "Name";
            cmbTipo.ValueMember = "ID";
            // cargamos el desplegable.
            CntSciTerminal.TOpen(this.conn);
            foreach (TFabricante ttpa in CntSciTerminal.GetTFabricantes(conn))
            {
                cmbFabricante.Items.Add(new ListItem(ttpa.FabricanteId, ttpa.Nombre));
            }
            CntSciTerminal.TClose(this.conn);
        }

        private void CargarAgentesExtintores()
        {
            cmbAgenteExtintor.Items.Clear();
            cmbAgenteExtintor.Items.Add(new ListItem(-1, ""));
            cmbTipo.DisplayMember = "Name";
            cmbTipo.ValueMember = "ID";
            // cargamos el desplegable.
            CntSciTerminal.TOpen(this.conn);
            foreach (TAgenteExtintor ttpa in CntSciTerminal.GetTAgenteExtintors(conn))
            {
                cmbAgenteExtintor.Items.Add(new ListItem(ttpa.AgenteExtintorId, ttpa.Descripcion));
            }
            CntSciTerminal.TClose(this.conn);
        }
        private void CargarFunciones()
        {
            cmbFuncion.Items.Clear();
            cmbFuncion.Items.Add(new ListItem(-1, ""));
            cmbTipo.DisplayMember = "Name";
            cmbTipo.ValueMember = "ID";
            // cargamos el desplegable.
            cmbFuncion.Items.Add(new ListItem(0, "Original"));
            cmbFuncion.Items.Add(new ListItem(1, "Repuesto"));
        }

        private void mnuAceptar_Click(object sender, EventArgs e)
        {
            if (!DatosOk()) return;
            Cursor.Current = Cursors.WaitCursor;
            // miramos si hay algún dispositivo que coincida
            CntSciTerminal.TOpen(this.conn);
            if (CntSciTerminal.GetTDispositivo(txtCaptura.Text, conn) != null)
            {
                MessageBox.Show("Ya existe un dispositivo dado de alta con ese código", "AVISO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                Cursor.Current = Cursors.Default;
                return;
            }
            else
            {
                dispositivo = new TDispositivo();
                DescargarPantalla();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Dispositivo guardado", "AVISO");
                Cursor.Current = Cursors.WaitCursor;
                DispForm dform = new DispForm(usuario, dispositivo);
                dform.Show();
                this.Close();
            }
            CntSciTerminal.TClose(this.conn);
        }
        private bool DatosOk()
        {
            if (txtCaptura.Text == "")
            {
                MessageBox.Show("Debe leer o introducir un código de dispositivo", "AVISO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Se necesita un nombre", "AVISO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Se necesita un tipo", "AVISO");
                return false;
            }
            if (cmbInst.SelectedItem == null)
            {
                MessageBox.Show("Se necesita una instalación", "AVISO");
                return false;
            }
            return true;
        }
        private void DescargarPantalla()
        {
            dispositivo.CodBarras = txtCaptura.Text;
            dispositivo.Nombre = txtNombre.Text;
            dispositivo.Instalacion = CntSciTerminal.GetTInstalacion(((ListItem)cmbInst.SelectedItem).ID, conn);
            dispositivo.Tipo = CntSciTerminal.GetTTipoDispositivo(((ListItem)cmbTipo.SelectedItem).ID, conn);
            if (cmbModelo.SelectedItem != null && ((ListItem)cmbModelo.SelectedItem).ID >= 0)
                dispositivo.Modelo = CntSciTerminal.GetTModeloDispositivo(((ListItem)cmbModelo.SelectedItem).ID, conn);
            dispositivo.Operativo = true;
            dispositivo.Empresa = CntSciTerminal.GetTEmpresa(conn).Nombre;
            if (cmbFuncion.SelectedItem != null && ((ListItem)cmbFuncion.SelectedItem).ID > 0)
                dispositivo.Funcion = ((ListItem)cmbFuncion.SelectedItem).Name.Substring(1,1);
            if (txtCargaKg.Text != "") dispositivo.CargaKg = Convert.ToDouble(txtCargaKg.Text);
            if (cmbFabricante.SelectedItem != null && ((ListItem)cmbFabricante.SelectedItem).ID >= 0)
                dispositivo.Fabricante = CntSciTerminal.GetTFabricante(((ListItem)cmbFabricante.SelectedItem).ID, conn);
            if (cmbAgenteExtintor.SelectedItem != null && ((ListItem)cmbAgenteExtintor.SelectedItem).ID >= 0)
                dispositivo.AgenteExtintor = CntSciTerminal.GetTAgenteExtintor(((ListItem)cmbModelo.SelectedItem).ID, conn);
            if (dtFechaFabricacion.Value != null)
                dispositivo.FechaFabricacion = dtFechaFabricacion.Value;
            CntSciTerminal.TSave(dispositivo, conn);
        }
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            MenuForm frmMenu = new MenuForm(usuario);
            frmMenu.Show();
            this.Close();
        }

        private void DispositivoNew_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                mnuAceptar_Click(null, null);
            }

        }

        private void txtCaptura_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    public class ListItem
    {
        private int id;
        private string name;
        public ListItem(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;
        }
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}