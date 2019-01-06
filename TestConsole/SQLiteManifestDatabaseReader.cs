using Destiny2.Api.Model.Definitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class SQLiteManifestDatabaseReader
    {
        private FileInfo DbFile { get; set; }
        private string SelectAllTableNames = "SELECT name FROM sqlite_master WHERE type='table'";

        public SQLiteManifestDatabaseReader(FileInfo dbFile)
        {
            DbFile = dbFile;
        }

        public IEnumerable<string> GetTableNames()
        {
            var tableNames = new List<string>();

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={DbFile.FullName}"))
                using (var command = new SQLiteCommand(SelectAllTableNames, conn))
                {
                    conn.Open();
                    using (SQLiteDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tableNames.Add(dr.GetValue(0).ToString());
                        }
                    }
                }
            }
            catch { throw; }
            return tableNames;
        }

        public IEnumerable<object> ReadManifestTable(string tableName)
        {
            var definitions = new List<object>();
            var type = Utils.FindSubClassesOf<Definition>().FirstOrDefault(subt => subt.Name == tableName);

            if (type == null) throw new Exception("Type associated to "+tableName + " not found or doesn't inherit from Definition");

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={DbFile.FullName}"))
                using (var command = new SQLiteCommand($"SELECT * FROM {tableName}", conn))
                {
                    conn.Open();
                    using (SQLiteDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var byteArrayJson = dr.GetValue(1) as byte[];
                            var jsonString = Encoding.UTF8.GetString(byteArrayJson);
                            try
                            { 
                                var deserialized = JsonConvert.DeserializeObject(jsonString, type);
                                definitions.Add(deserialized);
                            }
                            catch
                            {
                                throw;
                            }
                        }
                    }
                }
            }
            catch { throw; }
            return definitions;
        }
    }
}
