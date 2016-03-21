﻿using System;
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
    public partial class DispForm : Form
    {
        
        private TUsuario usuario;
        private SqlCeConnection conn;
        private TDispositivo vDispositivo;
        
        public DispForm(TUsuario usuario, TDispositivo disp)
        {
            this.usuario = usuario;
            vDispositivo = disp;
            this.conn = CntSciTerminal.TSqlConnection();
            InitializeComponent();
            CargarInfo();
            CargarGrid();
            Cursor.Current = Cursors.Default;
        }

        public void CargarGrid()
        {
            //IList<TRevision> ltr = CntSciTerminal.GetTRevisiones(false, vDispositivo, conn);
            //grdRevisiones.DataSource = ltr.ToArray<TRevision>();
            //IList<TIncidencia> lti = CntSciTerminal.GetTIncidencias(vDispositivo, conn);
            //grdIncidencias.DataSource = lti.ToArray<TIncidencia>();
            //IList<TSustitucion> lts = CntSciTerminal.GetTSustituciones(vDispositivo, conn);
            //grdSustituciones.DataSource = lts.ToArray<TSustitucion>();
            CntSciTerminal.TOpen(this.conn);
            IList<TTipoAnomalia> lta = CntSciTerminal.GetTTipoAnomalias(vDispositivo, conn);
            CntSciTerminal.TClose(this.conn);
            grdTipoA.DataSource = lta.ToArray<TTipoAnomalia>();
            //CrearEstiloColumnasRev();
            //CrearEstiloColumnasInc();
            //CrearEstiloColumnasSust();
            CrearEstiloColumnasTipoA();
        }
        //public void CrearEstiloColumnasRev()
        //{
        //    DataGridTableStyle prgEstilo = new DataGridTableStyle();
        //    prgEstilo.MappingName = "TRevision[]";
        //    //DataGridTextBoxColumn colId = new DataGridTextBoxColumn();
        //    //colId.HeaderText = "ID";
        //    //colId.MappingName = "RevisionId";
        //    //colId.Width = 40;
        //    DataGridTextBoxColumn colFecha = new DataGridTextBoxColumn();
        //    colFecha.HeaderText = "Fecha Pl.";
        //    colFecha.MappingName = "FechaPlanificada";
        //    colFecha.Format = "dd/MM/yyyy";
        //    colFecha.Width = 60;
        //    DataGridTextBoxColumn colInstalacion = new DataGridTextBoxColumn();
        //    colInstalacion.HeaderText = "Instalación";
        //    colInstalacion.MappingName = "NInstalacion";
        //    colInstalacion.Width = 120;
        //    DataGridTextBoxColumn colEstado = new DataGridTextBoxColumn();
        //    colEstado.HeaderText = "Estado";
        //    colEstado.MappingName = "Estado";
        //    colEstado.Width = 100;
                       
        //    //prgEstilo.GridColumnStyles.Add(colId);
        //    prgEstilo.GridColumnStyles.Add(colFecha);
        //    prgEstilo.GridColumnStyles.Add(colEstado);
        //    prgEstilo.GridColumnStyles.Add(colInstalacion);
        //    grdRevisiones.TableStyles.Clear();
        //    grdRevisiones.TableStyles.Add(prgEstilo);
        //}
        //public void CrearEstiloColumnasInc()
        //{
        //    DataGridTableStyle prgEstilo = new DataGridTableStyle();
        //    prgEstilo.MappingName = "TIncidencia[]";
        //    DataGridTextBoxColumn colFecha = new DataGridTextBoxColumn();
        //    colFecha.HeaderText = "Fecha";
        //    colFecha.MappingName = "Fecha";
        //    colFecha.Format = "dd/MM/yyyy";
        //    colFecha.Width = 60;
        //    DataGridTextBoxColumn colUsuario = new DataGridTextBoxColumn();
        //    colUsuario.HeaderText = "Usuario";
        //    colUsuario.MappingName = "NUsuario";
        //    colUsuario.Width = 100;
        //    DataGridTextBoxColumn colOperativo = new DataGridTextBoxColumn();
        //    colOperativo.HeaderText = "Operativo";
        //    colOperativo.MappingName = "Operativo";
        //    colOperativo.Width = 60;

        //    prgEstilo.GridColumnStyles.Add(colFecha);
        //    prgEstilo.GridColumnStyles.Add(colUsuario);
        //    prgEstilo.GridColumnStyles.Add(colOperativo);
        //    grdIncidencias.TableStyles.Clear();
        //    grdIncidencias.TableStyles.Add(prgEstilo);
        //}
        //public void CrearEstiloColumnasSust()
        //{
        //    DataGridTableStyle prgEstilo = new DataGridTableStyle();
        //    prgEstilo.MappingName = "TSustitucion[]";
        //    //DataGridTextBoxColumn colId = new DataGridTextBoxColumn();
        //    //colId.HeaderText = "ID";
        //    //colId.MappingName = "SustitucionId";
        //    //colId.Width = 40;
        //    DataGridTextBoxColumn colFecha = new DataGridTextBoxColumn();
        //    colFecha.HeaderText = "Fecha";
        //    colFecha.MappingName = "Fecha";
        //    colFecha.Format = "dd/MM/yyyy";
        //    colFecha.Width = 80;
        //    DataGridTextBoxColumn colDispositivoS = new DataGridTextBoxColumn();
        //    colDispositivoS.HeaderText = "Sustituto";
        //    colDispositivoS.MappingName = "NDispositivoS";
        //    colDispositivoS.Width = 160;

        //    //prgEstilo.GridColumnStyles.Add(colId);
        //    prgEstilo.GridColumnStyles.Add(colFecha);
        //    prgEstilo.GridColumnStyles.Add(colDispositivoS);
        //    grdSustituciones.TableStyles.Clear();
        //    grdSustituciones.TableStyles.Add(prgEstilo);
        //}
        public void CrearEstiloColumnasTipoA()
        {
            DataGridTableStyle prgEstilo = new DataGridTableStyle();
            prgEstilo.MappingName = "TTipoAnomalia[]";
            DataGridTextBoxColumn colId = new DataGridTextBoxColumn();
            colId.HeaderText = "ID";
            colId.MappingName = "TipoAnomaliaId";
            colId.Width = 40;
            DataGridTextBoxColumn colTipoN= new DataGridTextBoxColumn();
            colTipoN.HeaderText = "Anomalías";
            colTipoN.MappingName = "Nombre";
            colTipoN.Width = 240;

            //prgEstilo.GridColumnStyles.Add(colId);
            prgEstilo.GridColumnStyles.Add(colTipoN);
            grdTipoA.TableStyles.Clear();
            grdTipoA.TableStyles.Add(prgEstilo);
        }
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            MenuForm frmMenu = new MenuForm(usuario);
            frmMenu.Show();
            this.Close();
        }

        public void CargarInfo()
        {
             string operativo = "OPERATIVO";
             if (vDispositivo != null)
             {
                 if (vDispositivo.Operativo == false)
                 {
                     operativo = "INOPERATIVO";
                     label3.BackColor = Color.Red;
                 }
                 lblInst.Text = String.Format("{0}",
                         vDispositivo.Instalacion.Nombre);
                 string modelo = "";
                 if (vDispositivo.Modelo != null)
                     modelo = vDispositivo.Modelo.Nombre;
                 lblTipoOp.Text = String.Format("{0} [{1}]",
                         vDispositivo.Tipo.Nombre, modelo);
                 label1.Text = vDispositivo.Posicion;
                 label3.Text = operativo;
                 this.Text = String.Format("FALCK-SCI {0}", vDispositivo.Nombre);
                    
             }
        }

        //private void grdRevisiones_DoubleClick(object sender, EventArgs e)
        //{
        //    Cursor.Current = Cursors.WaitCursor;
        //    int i = grdRevisiones.CurrentRowIndex;
        //    if (i >= 0)
        //    {
        //        TRevision[] atr = (TRevision[])grdRevisiones.DataSource;
        //        TRevision tr = atr[i];
        //        tr = CntSciTerminal.GetTRevision(tr.RevisionId, conn);
        //        if (tr.DatosRevision.Count > 0)
        //        {
        //            DistribuidorForm frmDist = new DistribuidorForm(tr, 0, "dispositivo", usuario);
        //            frmDist.Show();
        //            this.Close();
        //        }
        //    }
        //    Cursor.Current = Cursors.Default;
        //}

        //private void grdSustituciones_DoubleClick(object sender, EventArgs e)
        //{
        //    Cursor.Current = Cursors.WaitCursor;
        //    int i = grdSustituciones.CurrentRowIndex;
        //    if (i >= 0)
        //    {
        //        TSustitucion[] atp = (TSustitucion[])grdSustituciones.DataSource;

        //        TSustitucion tp = atp[i];
        //        SustitucionForm sustform = new SustitucionForm(tp, "dispositivoGrid", usuario);
        //        sustform.Show();
        //        this.Close();
        //    }
        //    Cursor.Current = Cursors.Default;
        //}

        //private void grdIncidencias_DoubleClick(object sender, EventArgs e)
        //{
        //    Cursor.Current = Cursors.WaitCursor;
        //    int i = grdIncidencias.CurrentRowIndex;
        //    if (i >= 0)
        //    {
        //        TIncidencia[] atp = (TIncidencia[])grdIncidencias.DataSource;
        //        TIncidencia tp = atp[i];
        //        IncidenciasForm inform = new IncidenciasForm(tp, "dispositivoGrid", usuario);
        //        inform.Show();
        //        this.Close();
        //    }
        //    Cursor.Current = Cursors.Default;
        //}

        //private void nueva_incidencia_Click(object sender, EventArgs e)
        //{
        //    Cursor.Current = Cursors.WaitCursor;
        //    IncidenciasForm inform = new IncidenciasForm("dispositivoGrid", vDispositivo, usuario);
        //    inform.Show();
        //    this.Close();
        //}

        //private void nueva_sustitucion_Click(object sender, EventArgs e)
        //{
        //    Cursor.Current = Cursors.WaitCursor;
        //    SustitucionForm sustform = new SustitucionForm("dispositivoGrid", vDispositivo, usuario);
        //    sustform.Show();
        //    this.Close();
        //}

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            RevisionesGrid Grid = new RevisionesGrid("dispositivoGrid", vDispositivo, usuario);
            Grid.Show();
            this.Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SustitucionesGrid sustGrid = new SustitucionesGrid("dispositivo", vDispositivo, usuario);
            sustGrid.Show();
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IncidenciasGrid incGrid = new IncidenciasGrid("dispositivo", vDispositivo, usuario);
            incGrid.Show();
            this.Close();
        }
    }
}