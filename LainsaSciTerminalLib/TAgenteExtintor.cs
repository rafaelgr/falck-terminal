using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;

namespace LainsaTerminalLib
{
    public class TAgenteExtintor
    {
        private int agenteExtintorId;
        public int AgenteExtintorId
        {
            get { return agenteExtintorId; }
            set { agenteExtintorId = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
        public static TAgenteExtintor GetTAgenteExtintor(int id, SqlCeConnection conn)
        {
            TAgenteExtintor ta = null;
            string sql = String.Format("SELECT * FROM AgenteExtintor WHERE agente_extintor_id={0}", id);
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ta = new TAgenteExtintor();
                    ta.AgenteExtintorId = dr.GetInt32(0);
                    ta.Descripcion = dr.GetString(2);
                    ta.Abm = dr.GetByte(3);
                }
                if (!dr.IsClosed) dr.Close();
            }
            return ta;
        }
        public static TAgenteExtintor GetTAgenteExtintor(SqlCeConnection conn)
        {
            TAgenteExtintor ta = null;
            string sql = "SELECT * FROM AgenteExtintor";
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ta = new TAgenteExtintor();
                    ta.AgenteExtintorId = dr.GetInt32(0);
                    ta.Descripcion = dr.GetString(2);
                    ta.Abm = dr.GetByte(3);
                    break;
                }
                if (!dr.IsClosed) dr.Close();
            }
            return ta;
        }
        public static TAgenteExtintor GetTAgenteExtintor(string descripcion, SqlCeConnection conn)
        {
            TAgenteExtintor ta = null;
            string sql = String.Format("SELECT * FROM AgenteExtintor WHERE descripcion='{0}'", descripcion);
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ta = new TAgenteExtintor();
                    ta.AgenteExtintorId = dr.GetInt32(0);
                    ta.Descripcion = dr.GetString(2);
                    ta.Abm = dr.GetByte(3);
                }
                if (!dr.IsClosed) dr.Close();
            }
            return ta;
        }

        public static IList<TAgenteExtintor> GetTAgenteExtintors(SqlCeConnection conn)
        {
            IList<TAgenteExtintor> lttpa = new List<TAgenteExtintor>();
            string sql = "SELECT * FROM AgenteExtintor";
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TAgenteExtintor ta = GetTAgenteExtintor(dr.GetInt32(0), conn);
                    lttpa.Add(ta);
                }
            }
            return lttpa;
        }
    }
}
