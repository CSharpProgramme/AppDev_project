using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Data
{
    /*
    This class is responsible for managing the database connection.
    Instead of writing the connection string in every controller,
    we centralize it here so all controllers can reuse it easily.
    If the connection string ever changes, we only need to update it in one place.
     */
    public class DatabaseHelper
    {
        //tells the application where and how to connect to the database
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            "C:\\Users\\steve\\Desktop\\AppDev_project\\GymManagementSystem\\GymManagementSystem\\" +
            "GymManagementDB.mdf;Integrated Security=True;Connect Timeout=30";

        //this method creates and returns a new SqlConnection object using the connection string
        //controllers will call this method whenever they need to interact with the database
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
