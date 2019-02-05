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
        private string combobox_first_item = "";
        private starceki Form2;
        private bool uredi = false;

        public StarcekAU(starceki forma2)
        {
            InitializeComponent();
            this.connection = forma2.connection;
            this.line_number = forma2.line_number + 1;
            Form2 = forma2;
            this.napuni_combobox();
        }

        public StarcekAU(int row_index, starceki forma2, DataGridView data)
        {
            InitializeComponent();
            this.connection = forma2.connection;
            this.Form2 = forma2;
            this.line_number = Int32.Parse(data.Rows[row_index].Cells[6].Value.ToString());
            this.gumb_dodaj.Text = "Uredi";
            uredi = true;

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stara_osoba where ID = " + this.line_number + ";";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            textIme.Text = dt.Rows[0]["ime"].ToString();
            textPrezime.Text = dt.Rows[0]["prezime"].ToString();
            dat_rodjenja.Text = dt.Rows[0]["god_rodjenja"].ToString();
            textSpol.Text = dt.Rows[0]["spol"].ToString();
            checkDijabeticar.Checked =  dt.Rows[0]["diabeticar"].ToString().ToLower() == "true" ? true : false;
            dat_useljenja.Text = dt.Rows[0]["datum_useljenja"].ToString();
            kontak_osoba.Text = dt.Rows[0]["kontakt_osoba"].ToString();
            kontakt_tel.Text = dt.Rows[0]["broj_mob_kontakt"].ToString();

            string br_sobe;
            br_sobe = dt.Rows[0]["soba_id"].ToString();
            dt.Clear();

            cmd.CommandText = "select odjel.naziv as Naziv from odjel, soba where soba.broj_sobe = " + br_sobe + " and soba.odjel_id = odjel.ID;";
            MySqlDataAdapter mySqlData = new MySqlDataAdapter(cmd);
            mySqlData.Fill(dt);

            br_sobe = $"{br_sobe,-4}";
            combobox_first_item = br_sobe + " |   " + dt.Rows[0]["Naziv"].ToString();

            connection.Close();
            napuni_combobox();
        }

        //DODAJ
        private void button1_Click(object sender, EventArgs e)
        {
            string id = "";
            string ime = "";
            string prezime = "";
            string datum_rodjenja = "";
            string datum_useljenja = "";
            string spol = "";
            string dijabeticar = "";
            string broj_sobe = "";
            string kontakt_osoba = "";
            string kontakt_broj = "";
            bool dobar_unos = true;

            try
            {
                id = line_number.ToString() + ", ";
                ime = "'" + textIme.Text + "', ";
                prezime = "'" + textPrezime.Text + "', ";
                datum_rodjenja = "'" + DateTime.Parse(dat_useljenja.Text).ToString("yyyy-MM-dd") + "', ";
                datum_useljenja = "'" + DateTime.Parse(dat_useljenja.Text).ToString("yyyy-MM-dd") + "'";
                spol = "'" + textSpol.Text.Substring(0, 1) + "', ";
                dijabeticar = checkDijabeticar.Checked ? "1, " : "0, ";
                broj_sobe = Convert.ToInt32(comboSoba.Text.Substring(0, comboSoba.Text.IndexOf("|"))).ToString() + ", ";
                kontakt_osoba = "'" + kontak_osoba.Text + "', ";
                kontakt_broj = "'" + kontakt_tel.Text + "', ";
            }
            catch
            {
                var Result = MessageBox.Show("Nisu popunjena sva polja!");
                dobar_unos = false;
            }
            finally
            {
                if (dobar_unos)
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    if (uredi == false)
                    { 
                        cmd.CommandText = "insert into stara_osoba(ID, ime, prezime, god_rodjenja, spol, diabeticar, soba_id, kontakt_osoba, broj_mob_kontakt, datum_useljenja)" +
                                          " values(" + id + ime + prezime + datum_rodjenja + spol + dijabeticar + broj_sobe + kontakt_osoba + kontakt_broj + datum_useljenja + ");";
                    }
                    else
                    {
                        id = line_number.ToString();
                        cmd.CommandText = "update stara_osoba set ime = " + ime + "prezime = " + prezime + "god_rodjenja = " + datum_rodjenja +
                                          " spol = " + spol + "diabeticar = " + dijabeticar + " soba_id = " + broj_sobe + " kontakt_osoba = " + kontakt_osoba +
                                          " broj_mob_kontakt = " + kontakt_broj + " datum_useljenja = " + datum_useljenja + 
                                          " where ID = " + id + ";";
                    }
                    cmd.ExecuteNonQuery();

                    connection.Close();

                    Form2.napuni();
                    Form2.ima_promjena = true;
                    this.Close();
                }
                else
                {
                    dobar_unos = true;
                }
            }
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
            bool uredi = combobox_first_item != "";

            HashSet<String> podaci = new HashSet<string>();

            if (uredi)
            {
                podaci.Add(combobox_first_item);
            }

            for (i = 0; i < max; i++)
            {
                br_sobe = dt.Rows[i]["Broj sobe"].ToString();
                br_sobe = $"{br_sobe,-4}";

                podaci.Add(br_sobe +  " |   " + dt.Rows[i]["Odjel"].ToString());
            }
            comboSoba.DataSource = podaci.ToList();

            connection.Close();
        }
        

        private void textBox3_SpolChanged(object sender, EventArgs e)
        {
            textSpol.Text = textSpol.Text.ToUpper();

            if (textSpol.Text == "Z")
            {
                textSpol.Text = "Ž";
            }

            if (textSpol.Text != "Ž" && textSpol.Text != "M")
            {
                textSpol.Text = "";
            }
            else
            {
                textSpol.SelectionStart = textSpol.Text.Length;
            }
        }

        private void gumb_odbaci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
