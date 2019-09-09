using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NursingHomeApplication
{
    public partial class LoginForm : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        public void InitializeDatabase()
        {
            server = "SERVER=localhost;";
            database = "DATABASE=project1_v1;";
            uid = "UID=root;";
            password = "PASSWORD=hwktyetdjh9;";
            connectionString = server + database + uid + password;
            connection = new MySqlConnection(connectionString);
        }

        public LoginForm()
        {
            InitializeComponent();
            label3.Text = "";
            InitializeDatabase();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select korisnik from login where korisnik = '" + textBox1.Text + "' and lozinka = '" + textBox2.Text + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);
            int i = Convert.ToInt32(dt.Rows.Count);
            
            if (i != 0)
            {
                label3.Text = "Uspješna prijava!!";
                ShowMainForm();
                connection.Close();
            }
            else
            {
                label3.Text = "Pogrešno korisničko ime ili lozinka!";
                
            }

            connection.Close();
        }

        private void ShowMainForm()
        {
            Form form = new MainForm(connection, this);
            form.Show();
            this.Hide();
        }

        public void ShowMe()
        {
            this.Show();
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.Focus();
        }
    }
}
