using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace test_baza_aplikacija
{
    public static class database_class
    { 
        public static void InitializeDatabase(ref MySqlConnection connection)
        {
            string server = "SERVER=localhost;";
            string database = "DATABASE=project1_v1;";
            string uid = "UID=root;";
            string password = "PASSWORD=hwktyetdjh9;";
            string connectionString = server + database + uid + password;
            connection = new MySqlConnection(connectionString);
        }
    }
}
