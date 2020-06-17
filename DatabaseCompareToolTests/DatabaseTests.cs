using System;
using SqlConnector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseCompareTool;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseCompareToolTests
{
    [TestClass]
    public class DatabaseTests
    {
        private void CreateTestDatabase()
        {
            SQLConnector conn;
            conn = new SQLConnector("");
            conn.InitializeConnection();
            string sql;

            try // Attempt to create the desired database.
            {
                sql = File.ReadAllText(@"..\..\DBScripts\CreateTestDatabase.sql");
                conn.Open();
                conn.ReadResults(conn.CreateCommand(sql)).Close();

                sql = File.ReadAllText(@"..\..\DBScripts\AddTable.sql");
                conn.ReadResults(conn.CreateCommand(sql)).Close();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private void DeleteTestDatabase()
        {
            SQLConnector conn;
            conn = new SQLConnector("");
            conn.InitializeConnection();
            string sql;
            try // Delete previously created database.
            {
                sql = File.ReadAllText(@"..\..\DBScripts\DropTestDatabase.sql");
                conn.Open();
                conn.ReadResults(conn.CreateCommand(sql));
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        [TestMethod]
        public void RetrieveTables_DatabaseMoreThanZeroTables_TablesIsGreaterThanZero()
        {
            // Arrange
            CreateTestDatabase();

            var db = new Database("CustomerDatabase");

            // Act
            db.RetrieveTables();

            // Assert
            Console.WriteLine($"Number of Tables in {db.Name}: {db.Tables.Count}");
            Assert.IsTrue(db.Tables.Count > 0);

            // Clean up
            DeleteTestDatabase();
        }
    
        [TestMethod]
        public void RetrieveTables_DatabaseTablesAreNotOrdered_TablesIsOrdered()
        {
            // Arrange
            CreateTestDatabase();
            var database = new Database("CustomerDatabase");
            List<string> unsortedTables = new List<string>();
            SQLConnector conn = new SQLConnector("");
            string sql = $"USE [{database.Name}] SELECT Name FROM sys.tables WHERE is_ms_shipped = 0";

            // Act
            database.RetrieveTables(); 

            conn.InitializeConnection();
            conn.Open();

            var reader = conn.ReadResults(conn.CreateCommand(sql));
            while (reader.Read())
            {
                unsortedTables.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();

            unsortedTables.Sort();

            // Assert
            Console.WriteLine($"Unsorted List Contains: {unsortedTables.Count} Items");
            Console.WriteLine("Items:");
            for(int i = 0; i < unsortedTables.Count; i++)
            {
                Console.WriteLine($"Item # {i}: {unsortedTables[i]}");
            }

            Console.WriteLine($"Sorted List Contains: {database.Tables.Count} Items");
            for (int i = 0; i < database.Tables.Count; i++)
            {
                Console.WriteLine($"Item # {i}: {database.Tables[i]}");
            }

            Assert.IsTrue(database.Tables.SequenceEqual(unsortedTables));

            // Cleanup
            DeleteTestDatabase();
        }
    }
}
