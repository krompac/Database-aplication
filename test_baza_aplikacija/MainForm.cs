using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NursingHomeApplication
{
    public partial class MainForm : Form
    {
        public MySqlConnection connection;
        public int line_number;
        private LoginForm loginForm;
        private bool userClosing;

        public MainForm(MySqlConnection sqlConnection, LoginForm form)
        {
            InitializeComponent();
            this.connection = sqlConnection;
            loginForm = form;
            
            this.starceki1.Hide();
            this.sobe_uc1.Hide();
            this.djelatnik1.Hide();

            userClosing = true;
        }

        //starčeki
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.sobe_uc1.Visible)
            {
                this.sobe_uc1.Visible = false;
                this.sobe_uc1.ClearViews();
            }
            else if (this.djelatnik1.Visible)
            {
                this.djelatnik1.Visible = false;
                this.djelatnik1.ClearView();
            }

            this.starceki1.LoadPatients(connection, this);
        }

        private void sobe_Click(object sender, EventArgs e)
        {
            if (this.starceki1.Visible)
            {
                this.starceki1.Visible = false;
                this.starceki1.ClearView();
            }
            else if (this.djelatnik1.Visible)
            {
                this.djelatnik1.Visible = false;
                this.djelatnik1.ClearView();
            }

            this.sobe_uc1.LoadRooms(this);
        }

        private void djelatnici_Click(object sender, EventArgs e)
        {
            if (this.starceki1.Visible)
            {
                this.starceki1.Visible = false;
                this.starceki1.ClearView();
            }
            else if (this.sobe_uc1.Visible)
            {
                this.sobe_uc1.Visible = false;
                this.sobe_uc1.ClearViews();
            }

            this.djelatnik1.LoadEmployees(this);
        }

        private void natrag_Click(object sender, EventArgs e)
        {
            loginForm.ShowMe();
            userClosing = false;
            this.Close();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && userClosing)
            {
                loginForm.Close();
            }
        }
    }
}
