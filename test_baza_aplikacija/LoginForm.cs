using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NursingHomeApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            label3.Text = "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string loginQuery = "select korisnik from login where korisnik = '" + textBox1.Text + "' and lozinka = '" + textBox2.Text + "';";
            DataTable dt = DB.Instance.GetData(loginQuery);
            
            int i = Convert.ToInt32(dt.Rows.Count);
            
            if (i != 0)
            {
                label3.Text = "Uspješna prijava!!";
                ShowMainForm();
            }
            else
            {
                label3.Text = "Pogrešno korisničko ime ili lozinka!";
                
            }
        }

        private void ShowMainForm()
        {
            Form form = new MainForm(this);
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
