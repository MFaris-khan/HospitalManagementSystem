using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace HMS_Solution
{
    internal static class DatabaseHelper
    {
        private static readonly string DbDir = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HMS");
        private static readonly string DbName = "HMS";

        private static readonly string ConnectionString_Master =
            "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True;";
        private static readonly string ConnectionString_HMS =
            $"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog={DbName};Integrated Security=True;";


        public static void InitializeDatabase()
        {
            try
            {
                // Ensure the application folder exists
                Directory.CreateDirectory(DbDir);

                // Create database if it does not exist
                using (var conn = new SqlConnection(ConnectionString_Master))
                {
                    conn.Open();
                    int count;
                    using (var checkCmd = new SqlCommand(
                        $"SELECT COUNT(*) FROM sys.databases WHERE name = '{DbName}'", conn))
                    {
                        count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    }

                    if (count == 0)
                    {
                        string mdfPath = Path.Combine(DbDir, $"{DbName}.mdf");
                        string ldfPath = Path.Combine(DbDir, $"{DbName}_log.ldf");

                        string createDb = $@"
CREATE DATABASE [{DbName}]
ON (NAME = N'{DbName}', FILENAME = '{mdfPath}')
LOG ON (NAME = N'{DbName}_log', FILENAME = '{ldfPath}');
";
                        using (var createCmd = new SqlCommand(createDb, conn))
                        {
                            createCmd.ExecuteNonQuery();
                        }

                        // wait for LocalDB to finish setup
                        Thread.Sleep(3000);
                    }
                }

                // Apply schema if tables do not exist
                using (var testConn = new SqlConnection(ConnectionString_HMS))
                {
                    testConn.Open();
                    

                    using (var cmd = new SqlCommand("SELECT COUNT(*) FROM sys.tables", testConn))
                    {
                        int tables = Convert.ToInt32(cmd.ExecuteScalar());
                        if (tables == 0)
                            ApplySchema();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Database initialization failed:\n\n" + ex.ToString(),
                    "HMS Setup Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }

        private static void ApplySchema()
        {
            string sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HMS.sql");

            if (!File.Exists(sqlFile))
                throw new FileNotFoundException("Missing schema file: HMS.sql (place it next to the EXE)");

            string script = File.ReadAllText(sqlFile);

            using (var conn = new SqlConnection(ConnectionString_HMS))
            {
                conn.Open();

                // Split script on GO statements
                var commands = script.Split(new[] { "\r\nGO\r\n", "\nGO\n", "\rGO\r", "GO\r\n", "GO\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var cmdText in commands)
                {
                    var trimmed = cmdText.Trim();
                    if (string.IsNullOrWhiteSpace(trimmed))
                        continue;

                    using (var cmd = new SqlCommand(trimmed, conn))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Provide the connection string for your DAL
        public static string GetConnectionString()
        {
            return ConnectionString_HMS;
        }
    }
}
