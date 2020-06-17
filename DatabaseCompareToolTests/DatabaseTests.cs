using System;
using SqlConnector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseCompareTool;
using System.IO;

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
        public void RetrieveTables_DatabaseHasOneTable_TablesIsGreaterThanZero()
        {
            // Arrange
            CreateTestDatabase();

            var db = new Database("CustomerDatabase");

            // Act
            db.RetrieveTables();

            // Assert
            Console.WriteLine($"Number of Tables in {db.Name}: {db.Tables.Count}");
            Assert.IsTrue(db.Tables.Count == 1);

            // Clean up
            DeleteTestDatabase();
        }
    }
}
