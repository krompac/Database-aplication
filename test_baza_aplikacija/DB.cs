using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace NursingHomeApplication
{
    public sealed class DB
    {
        private static DB instance = null;
        private static readonly object padlock = new object();
        private MySqlConnection connection;

        public static DB Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DB();
                    }

                    return instance;
                }
            }
        }

        DB()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string server = "SERVER=localhost;";
            string database = "DATABASE=project1_v1;";
            string uid = "UID=root;";
            string password = "PASSWORD=hwktyetdjh9;";
            string connectionString = server + database + uid + password;
            connection = new MySqlConnection(connectionString);
        }

        public DataTable GetData(string query)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);
            connection.Close();

            return dt;
        }

        public void UpdateOrDelete(string query)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
