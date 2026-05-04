using System;
using System.Data.SqlClient;
using System.IO;

namespace GymManagementSystem.Data
{
    public class DatabaseHelper
    {
        private const string DbName = "GymManagementDB_App";
        private const string DataSource = @"(LocalDB)\MSSQLLocalDB";
        private static bool _attached = false;

        private static void EnsureAttached()
        {
            if (_attached) return;

            string mdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GymManagementDB.mdf");

            string masterConn = $"Data Source={DataSource};Initial Catalog=master;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(masterConn))
            {
                conn.Open();

                // Check if already attached under our consistent name
                SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM sys.databases WHERE name = @name", conn);
                check.Parameters.AddWithValue("@name", DbName);
                int exists = (int)check.ExecuteScalar();

                if (exists == 0)
                {
                    // Attach it with a fixed name so it never conflicts
                    SqlCommand attach = new SqlCommand(
                        $"CREATE DATABASE [{DbName}] ON (FILENAME = N'{mdfPath}') FOR ATTACH", conn);
                    attach.ExecuteNonQuery();
                }
            }

            _attached = true;
        }

        public static SqlConnection GetConnection()
        {
            EnsureAttached();
            string connStr = $"Data Source={DataSource};Initial Catalog={DbName};Integrated Security=True;Connect Timeout=30";
            return new SqlConnection(connStr);
        }
    }
}