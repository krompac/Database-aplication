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
        private int line_number;
        private Form2 Form2;

        public StarcekAU(Form2 forma2)
        {
            InitializeComponent();
            this.connection = forma2.connection;
            this.line_number = ++forma2.line_number;
            Form2 = forma2;
            this.napuni_combobox();
        }

        //DODAJ
        private void button1_Click(object sender, EventArgs e)
        {
            string id = line_number.ToString() + ", ";
            string ime = "'" + textIme.Text + "', ";
            string prezime = "'" + textPrezime.Text + "', ";
            string god_rodjenja = "'" + textGodRodjenja.Text + "', ";
            string datum_useljenja = "'" + DateTime.Parse(dat_useljenja.Text).ToString("yyyy-MM-dd") + "'";
            string spol = "'" + textSpol.Text.Substring(0,1) + "', ";
            string dijabeticar = checkDijabeticar.Checked ? "1, " : "0, ";
            string broj_sobe = Convert.ToInt32(comboSoba.Text.Substring(0, comboSoba.Text.IndexOf("|"))).ToString() + ", ";

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into stara_osoba(ID, ime, prezime, god_rodjenja, spol, diabeticar, soba_id, datum_useljenja)" +
                              " values(" + id + ime + prezime + god_rodjenja + spol + dijabeticar + broj_sobe + datum_useljenja + ");";
            cmd.ExecuteNonQuery();
            
            connection.Close();
            Form2.napuni();
            this.Close();
        }

        private void napuni_combobox()
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select soba.broj_sobe as 'Broj sobe', odjel.naziv as Odjel from soba, odjel " +
                              "where broj_praznih_kreveta(soba.broj_sobe) < soba.broj_kreveta and soba.odjel_id = odjel.ID;";
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

            comboSoba.DataSource = podaci;

            connection.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(textGodRodjenja.Text);
            }
            catch 
            {
                textGodRodjenja.Text = "";
            }
        }
    }
}
