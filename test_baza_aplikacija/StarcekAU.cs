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
    public partial class StarcekAU : Form
    {
        private MySqlConnection connection;

        public StarcekAU(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.napuni_combobox();
        }

        //DODAJ
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
            
            connection.Close();
        }

        private void napuni_combobox()
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select soba.broj_sobe as 'Broj sobe', odjel.naziv as Odjel from soba, odjel " +
                              "where broj_praznih_kreveta(soba.broj_sobe) > 0 and soba.odjel_id = odjel.ID;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            int max = dt.Rows.Count;
            int i;
            string br_sobe;

            //yyyy-MM-dd

            List<String> podaci = new List<string>();

            for (i = 0; i < max; i++)
            {
                br_sobe = dt.Rows[i]["Broj sobe"].ToString();
                br_sobe = $"{br_sobe,-4}";

                podaci.Add(br_sobe +  " |   " + dt.Rows[i]["Odjel"].ToString());
            }

            comboBox1.DataSource = podaci;

            connection.Close();
        }
    }
}
