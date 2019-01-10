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
    public partial class Form2 : Form
    {
        private MySqlConnection connection;
        public Form2(MySqlConnection sqlConnection)
        {
            InitializeComponent();
            this.connection = sqlConnection;
        }

        public void NapuniListView()
        {
            

        }

        private void Form2_FormClosed(Object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown)
            {
                Form1.ActiveForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from soba;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            dataGridView1.DataSource = dt;

            int i = Convert.ToInt32(dt.Rows.Count.ToString());

            

            connection.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.GradientActiveCaption;
        }
    }
}
