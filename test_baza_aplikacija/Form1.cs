using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace test_baza_aplikacija
{
    
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        private void Initialize()
        {
            server = "SERVER=localhost;";
            database = "DATABASE=project1_v1;";
            uid = "UID=root;";
            password = "PASSWORD=hwktyetdjh9;";
            connectionString = server + database + uid + password;
        }


        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
            Initialize();
            connection = new MySqlConnection(connectionString);
        }

        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select korisnik from login where korisnik = '" + textBox1.Text + "' and lozinka = '" + textBox2.Text + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i != 0)
            {
                label3.Text = "Uspješna prijava!!";

            }
            else
            {
                label3.Text = "Pogrešno korisničko ime ili lozinka!";
            }
            
            connection.Close();
        }
    }
}
