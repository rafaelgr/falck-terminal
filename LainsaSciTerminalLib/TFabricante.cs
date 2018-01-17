using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;

namespace LainsaTerminalLib
{
    public class TFabricante
    {
        private int fabricanteId;
        public int FabricanteId
        {
            get { return fabricanteId; }
            set { fabricanteId = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private byte abm;
        public byte Abm
        {
            get { return abm; }
            set { abm = value; }
        }
    }
    public static partial class CntSciTerminal
    {
        public static TFabricante GetTFabricante(int id, SqlCeConnection conn)
        {
            TFabricante ta = null;
            string sql = String.Format("SELECT * FROM Fabricante WHERE fabricante_id={0}", id);
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ta = new TFabricante();
                    ta.FabricanteId = dr.GetInt32(0);
                    ta.Nombre = dr.GetString(2);
                    ta.Abm = dr.GetByte(3);
                }
                if (!dr.IsClosed) dr.Close();
            }
            return ta;
        }
        public static TFabricante GetTFabricante(SqlCeConnection conn)
        {
            TFabricante ta = null;
            string sql = "SELECT * FROM Fabricante";
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ta = new TFabricante();
                    ta.FabricanteId = dr.GetInt32(0);
                    ta.Nombre = dr.GetString(2);
                    ta.Abm = dr.GetByte(3);
                    break;
                }
                if (!dr.IsClosed) dr.Close();
            }
            return ta;
        }
        public static TFabricante GetTFabricante(string nombre, SqlCeConnection conn)
        {
            TFabricante ta = null;
            string sql = String.Format("SELECT * FROM Fabricante WHERE nombre='{0}'", nombre);
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ta = new TFabricante();
                    ta.FabricanteId = dr.GetInt32(0);
                    ta.Nombre = dr.GetString(2);
                    ta.Abm = dr.GetByte(3);
                }
                if (!dr.IsClosed) dr.Close();
            }
            return ta;
        }

        public static IList<TFabricante> GetTFabricantes(SqlCeConnection conn)
        {
            IList<TFabricante> lttpa = new List<TFabricante>();
            string sql = "SELECT * FROM Fabricante";
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TFabricante ta = GetTFabricante(dr.GetInt32(0), conn);
                    lttpa.Add(ta);
                }
            }
            return lttpa;
        }
    }
}
