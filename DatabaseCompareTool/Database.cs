using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlConnector; 

namespace DatabaseCompareTool
{
    public class Database
    {
        public String Name { get; }
        public List<String> Tables { get; private set; }
    
        public Database(String name)
        {
            Name = name;
            Tables = new List<String>();
        }   
        public void RetrieveTables()
        {
            Tables = new List<String>();

            SQLConnector conn = new SQLConnector("");
            conn.InitializeConnection();
            conn.Open();
            string sql = $"USE [{Name}] SELECT Name FROM sys.tables WHERE is_ms_shipped = 0 order by Name";
            Console.WriteLine($"Getting Tables Using: {sql}");
            var reader = conn.ReadResults(conn.CreateCommand(sql));
            while (reader.Read())
            {
                Tables.Add(reader[0].ToString());
            }
            conn.Close();
        }
        public static List<String> GetDatabaseList()
        {
            SQLConnector conn = new SQLConnector("");
            conn.InitializeConnection();
            conn.Open();

            var temp = new List<String>();
            var reader = conn.ReadResults(conn.CreateCommand("SELECT name FROM master.sys.databases where name NOT IN ('master','model','msdb','tempdb')"));

            while (reader.Read())
            {
                temp.Add(reader[0].ToString());
            }
            conn.Close();
            return temp;
        }
    }
}
