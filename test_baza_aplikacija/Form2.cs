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

        //starčeki
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ime as Ime, prezime as Prezime, god_rodjenja as 'Godina rođenja', " +
                              "datum_useljenja as 'Datum useljenja', soba_id as 'Broj sobe', spol as Spol, diabeticar as Diabeticar from stara_osoba;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            int max = dt.Rows.Count;
            int i;
            string vrijeme;

            for (i = 0; i < max; i++)
            {
                vrijeme = dt.Rows[i]["Datum useljenja"].ToString();
                vrijeme = vrijeme.Substring(0, 9);

                dataGridView1.Rows.Add(dt.Rows[i]["Ime"], dt.Rows[i]["Prezime"], dt.Rows[i]["Godina rođenja"], vrijeme, dt.Rows[i]["Broj sobe"], dt.Rows[i]["Spol"], dt.Rows[i]["Diabeticar"]);
            }


            i = Convert.ToInt32(dt.Rows.Count.ToString());



            connection.Close();
        }

        //dodaj
        private void button5_Click(object sender, EventArgs e)
        {
            StarcekAU starcek = new StarcekAU(connection);
        }

    }
}
