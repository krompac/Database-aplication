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

namespace test_baza_aplikacija
{
    public partial class glavna_forma : Form
    {
        public MySqlConnection connection;
        public int line_number;
        private Login parent_form;
        private bool user_closing;

        public glavna_forma(MySqlConnection sqlConnection, Login form1)
        {
            InitializeComponent();
            this.connection = sqlConnection;
            parent_form = form1;
            
            this.starceki1.Hide();
            this.sobe_uc1.Hide();
            this.djelatnik1.Hide();

            user_closing = true;
        }

        //starčeki
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.sobe_uc1.Visible)
            {
                this.sobe_uc1.Visible = false;
                this.sobe_uc1.clear_datagrid_views();
            }
            else if (this.djelatnik1.Visible)
            {
                this.djelatnik1.Visible = false;
                this.djelatnik1.clear_datagridview();
            }

            this.starceki1.load_starceki(connection, this);
        }

        private void sobe_Click(object sender, EventArgs e)
        {
            if (this.starceki1.Visible)
            {
                this.starceki1.Visible = false;
                this.starceki1.clear_datagrid();
            }
            else if (this.djelatnik1.Visible)
            {
                this.djelatnik1.Visible = false;
                this.djelatnik1.clear_datagridview();
            }

            this.sobe_uc1.load_sobe(this);
        }

        private void djelatnici_Click(object sender, EventArgs e)
        {
            if (this.starceki1.Visible)
            {
                this.starceki1.Visible = false;
                this.starceki1.clear_datagrid();
            }
            else if (this.sobe_uc1.Visible)
            {
                this.sobe_uc1.Visible = false;
                this.sobe_uc1.clear_datagrid_views();
            }

            this.djelatnik1.load_djelatnici(this);
        }

        private void natrag_Click(object sender, EventArgs e)
        {
            parent_form.prikazi_ovu_formu();
            user_closing = false;
            this.Close();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && user_closing)
            {
                parent_form.Close();
            }
        }
    }
}
