using System;
using System.Collections.Generic;
using System.Configuration;  // ADD THIS
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Data
{
    public class DatabaseHelper
    {
        private static readonly string connectionString = BuildConnectionString();

        private static string BuildConnectionString()
        {
            // Always target a single physical database file in the app output folder.
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string databaseFilePath = Path.Combine(baseDirectory, "GymManagementDB.mdf");

            string configured = ConfigurationManager
                .ConnectionStrings["GymManagementSystem.Properties.Settings.GymManagementDBConnectionString"]?
                .ConnectionString ?? string.Empty;

            var builder = new SqlConnectionStringBuilder(configured)
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                IntegratedSecurity = true,
                ConnectTimeout = 30,
                AttachDBFilename = databaseFilePath,
                InitialCatalog = string.Empty
            };

            return builder.ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}