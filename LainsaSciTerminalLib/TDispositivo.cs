﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;

namespace LainsaTerminalLib
{
    public class TDispositivo
    {
        private int dispositivoId;

        public int DispositivoId
        {
            get
            {
                return dispositivoId;
            }
            set
            {
                dispositivoId = value;
            }
        }
        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        private string empresa;

        public string Empresa
        {
            get
            {
                return empresa;
            }
            set
            {
                empresa = value;
            }
        }
        private TInstalacion instalacion;

        public TInstalacion Instalacion
        {
            get
            {
                return instalacion;
            }
            set
            {
                instalacion = value;
            }
        }

        private TTipoDispositivo tipo;

        public TTipoDispositivo Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        private TModeloDispositivo modelo;

        public TModeloDispositivo Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }
        private string funcion;

        public string Funcion
        {
            get
            {
                return funcion;
            }
            set
            {
                funcion = value;
            }
        }
        private string estado;

        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        private DateTime fechaCaducidad;

        public DateTime FechaCaducidad
        {
            get
            {
                return fechaCaducidad;
            }
            set
            {
                fechaCaducidad = value;
            }
        }
        private bool caducado;

        public bool Caducado
        {
            get
            {
                return caducado;
            }
            set
            {
                caducado = value;
            }
        }
        private bool operativo;

        public bool Operativo
        {
            get
            {
                return operativo;
            }
            set
            {
                operativo = value;
            }
        }
        private DateTime fechaBaja;

        public DateTime FechaBaja
        {
            get
            {
                return fechaBaja;
            }
            set
            {
                fechaBaja = value;
            }
        }

        private string codBarras;

        public string CodBarras
        {
            get { return codBarras; }
            set { codBarras = value; }
        }
        private string posicion;

        public string Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }
        private IList<TIncidencia> incidencias;

        public IList<TIncidencia> Incidencias
        {
            get { return incidencias; }
            set { this.incidencias = value; }
        }

        public TDispositivo()
        {
            incidencias = new List<TIncidencia>();
        }
        private byte abm;
        public byte Abm
        {
            get { return abm; }
            set { abm = value; }
        }

        // Nuevos campos v 2018.0.1.0

        private string nIndustria;
        public string NIndustria
        {
            get { return nIndustria; }
            set { nIndustria = value; }
        }

        private double cargaKg;
        public double CargaKg
        {
            get { return cargaKg; }
            set { cargaKg = value; }
        }

        private TFabricante fabricante;
        public TFabricante Fabricante
        {
            get
            {
                return fabricante;
            }
            set
            {
                fabricante = value;
            }
        }

        private DateTime fechaFabricacion;
        public DateTime FechaFabricacion
        {
            get
            {
                return fechaFabricacion;
            }
            set
            {
                fechaFabricacion = value;
            }
        }

        private TAgenteExtintor agenteExtintor;
        public TAgenteExtintor AgenteExtintor
        {
            get
            {
                return agenteExtintor;
            }
            set
            {
                agenteExtintor = value;
            }
        }
    }

    public static partial class CntSciTerminal
    {
        public static void SetTDispositivo(TDispositivo dispositivo, SqlCeDataReader dr, SqlCeConnection conn)
        {
            dispositivo.DispositivoId = dr.GetInt32(0);
            dispositivo.Nombre = dr.GetString(1);
            dispositivo.Empresa = dr.GetString(2);
            dispositivo.Instalacion = GetTInstalacion(dr.GetInt32(3), conn);
            dispositivo.Tipo = GetTTipoDispositivo(dr.GetInt32(4), conn);
            dispositivo.Funcion = dr.GetString(5);
            dispositivo.Estado = dr.GetString(6);
            dispositivo.CodBarras = dr.GetString(7);
            if (dr[14] != DBNull.Value)
                dispositivo.Posicion = dr.GetString(14);
            if (dr[8] != DBNull.Value)
                dispositivo.FechaCaducidad = dr.GetDateTime(8);
            dispositivo.Caducado = dr.GetBoolean(9);
            if(dr[12] != DBNull.Value)
               dispositivo.Operativo = dr.GetBoolean(12);
            //if (!CntSciTerminal.FechaNula(dispositivo.FechaBaja))
            //   dispositivo.FechaBaja = dr.GetDateTime(10);
            if (dr[10] != DBNull.Value)
                dispositivo.FechaBaja = dr.GetDateTime(10);
            if (dr[11] != DBNull.Value)
               dispositivo.Modelo = GetTModeloDispositivo(dr.GetInt32(11), conn);
            dispositivo.Abm = dr.GetByte(15);
            // nuevos campos vrs 2018.0.1.0
            if (dr[16] != DBNull.Value)
                dispositivo.NIndustria = dr.GetString(16);
            if (dr[17] != DBNull.Value)
                dispositivo.CargaKg = dr.GetDouble(17);
            if (dr[18] != DBNull.Value)
                dispositivo.Fabricante = GetTFabricante(dr.GetInt32(18), conn);
            if (dr[19] != DBNull.Value)
                dispositivo.FechaFabricacion = dr.GetDateTime(19);
            if (dr[20] != DBNull.Value)
                dispositivo.AgenteExtintor = GetTAgenteExtintor(dr.GetInt32(20), conn);
        }
        public static TDispositivo GetTDispositivo(int id, SqlCeConnection conn)
        {
            TDispositivo dispositivo = null;
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = String.Format("SELECT * FROM Dispositivo WHERE dispositivo_id = {0}", id);
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dispositivo = new TDispositivo();
                    SetTDispositivo(dispositivo, dr, conn);
                }
                if (!dr.IsClosed)
                    dr.Close();
            }
            return dispositivo;
        }
        public static TDispositivo GetTDispositivo(string codBarras, SqlCeConnection conn)
        {
            TDispositivo dispositivo = null;
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = String.Format("SELECT * FROM Dispositivo WHERE codbarras= '{0}'", codBarras);
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dispositivo = new TDispositivo();
                    SetTDispositivo(dispositivo, dr, conn);
                }
                if (!dr.IsClosed)
                    dr.Close();
            }
            return dispositivo;
        }
        public static void TSave(TDispositivo td, SqlCeConnection conn)
        {
            string sql = "";
            string fecha_caducidad = "NULL";
            string fecha_baja = "NULL";
            string fecha_fabricacion = "NULL";
            int caducado = 0;
            int operativo = 1;
            if (!td.Operativo) operativo = 0;
            if (!CntSciTerminal.FechaNula(td.FechaCaducidad)) 
                fecha_caducidad = String.Format("CONVERT(DATETIME,'{0:yyyy-MM-dd HH:mm:ss}',102)", td.FechaCaducidad);
            if (!CntSciTerminal.FechaNula(td.FechaBaja))
                fecha_baja = String.Format("CONVERT(DATETIME,'{0:yyyy-MM-dd HH:mm:ss}',102)", td.FechaBaja);
            if (td.Caducado) caducado = 1;
            string posicion = "";
            if (td.Posicion != null)
                posicion = td.Posicion;
            int modelo = 0;
            if (td.Modelo != null)
                modelo = td.Modelo.ModeloDispositivoId;
            //
            byte abm = td.Abm;
            if (abm != 1) abm = 3;
            // Nuevos campos VRS 2018.0.1.0
            // td.Funcion -> ya viene precargado    
            // td.CargaKg -> precargado
            if (!CntSciTerminal.FechaNula(td.FechaFabricacion))
                fecha_fabricacion = String.Format("CONVERT(DATETIME,'{0:yyyy-MM-dd HH:mm:ss}',102)", td.FechaFabricacion);
            int fabricante = 0;
            if (td.Fabricante != null)
                fabricante = td.Fabricante.FabricanteId;
            int agente = 0;
            if (td.AgenteExtintor != null)
                agente = td.AgenteExtintor.AgenteExtintorId;
            //
            TDispositivo tdsp = GetTDispositivo(td.DispositivoId, conn);
            if (tdsp == null)
            {
                sql = @"SELECT MAX(dispositivo_id) from dispositivo";
                using (SqlCeCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlCeDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[0] != DBNull.Value)
                            td.DispositivoId = dr.GetInt32(0) + 1;
                        else
                            td.DispositivoId = 1;
                        break;
                    }
                }

                sql = @"INSERT INTO Dispositivo(dispositivo_id, nombre, 
                            empresa, instalacion, 
                            tipo, funcion, estado,
                            fecha_caducidad, caducado, fecha_baja, codbarras, modelo, operativo, posicion, abm, carga_kg, fabricante_id, fecha_fabricacion, agente_extintor_id) VALUES({0},'{1}','{2}',{3},{4},'{5}','{6}',{7},{8},{9},'{10}',{11},'{12}','{13}',{14},{15},{16}, {17}, {18})";
            }
            else
            {
                sql = @"UPDATE Dispositivo SET nombre='{1}',empresa='{2}',instalacion={3},
                        tipo={4}, funcion='{5}', estado='{6}',
                        fecha_caducidad={7}, caducado='{8}', fecha_baja={9}, codbarras='{10}', modelo={11}, operativo='{12}', posicion='{13}', abm={14}, carga_kg = {15}, fabricante_id = {16}, fecha_fabricacion = {17}, agente_extintor_id = {18}
                        WHERE dispositivo_id={0}";
            }
            sql = String.Format(sql, td.DispositivoId, td.Nombre, td.Empresa, td.Instalacion.InstalacionId, td.Tipo.TipoDispositivoId, td.Funcion, td.Estado,fecha_caducidad,caducado,fecha_baja,td.CodBarras, modelo, operativo, posicion, abm, td.CargaKg, fabricante, fecha_fabricacion, agente );
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                int nrec = cmd.ExecuteNonQuery();
            }
        }
    }
}