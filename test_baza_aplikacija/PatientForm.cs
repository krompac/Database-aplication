using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NursingHomeApplication
{
    public partial class PatientForm : Form
    {
        private int lineNumber;
        private string comboBoxFirstItem = "";
        private Patients Form2;
        private bool edit = false;

        public PatientForm(Patients forma2)
        {
            InitializeComponent();
            this.lineNumber = forma2.LineNumber + 1;
            Form2 = forma2;
            this.napuni_combobox();
        }

        public PatientForm(int rowIndex, Patients forma2, DataGridView data)
        {
            InitializeComponent();
            this.Form2 = forma2;
            this.lineNumber = Int32.Parse(data.Rows[rowIndex].Cells[6].Value.ToString());
            this.gumb_dodaj.Text = "Uredi";
            edit = true;

            
            string query = "select * from stara_osoba where ID = " + this.lineNumber + ";";
            DataTable dt = DB.Instance.GetData(query);
            
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

            query = "select odjel.naziv as Naziv from odjel, soba where soba.broj_sobe = " + br_sobe + " and soba.odjel_id = odjel.ID;";
            dt = DB.Instance.GetData(query);
            
            br_sobe = $"{br_sobe,-4}";
            comboBoxFirstItem = br_sobe + " |   " + dt.Rows[0]["Naziv"].ToString();
            
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
            bool goodInput = true;

            try
            {
                id = lineNumber.ToString() + ", ";
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
                goodInput = false;
            }
            finally
            {
                if (goodInput)
                {
                    string query;
                    
                    if (edit == false)
                    { 
                        query = "insert into stara_osoba(ID, ime, prezime, god_rodjenja, spol, diabeticar, soba_id, kontakt_osoba, broj_mob_kontakt, datum_useljenja)" +
                                          " values(" + id + ime + prezime + datum_rodjenja + spol + dijabeticar + broj_sobe + kontakt_osoba + kontakt_broj + datum_useljenja + ");";
                    }
                    else
                    {
                        id = lineNumber.ToString();
                        query = "update stara_osoba set ime = " + ime + "prezime = " + prezime + "god_rodjenja = " + datum_rodjenja +
                                          " spol = " + spol + "diabeticar = " + dijabeticar + " soba_id = " + broj_sobe + " kontakt_osoba = " + kontakt_osoba +
                                          " broj_mob_kontakt = " + kontakt_broj + " datum_useljenja = " + datum_useljenja + 
                                          " where ID = " + id + ";";
                    }
                    DB.Instance.UpdateOrDelete(query);

                    Form2.FillView();
                    this.Close();
                }
                else
                {
                    goodInput = true;
                }
            }
        }

        private void napuni_combobox()
        {
            string query = "select soba.broj_sobe as 'Broj sobe', odjel.naziv as Odjel from soba, odjel " +
                           "where broj_praznih_kreveta(soba.broj_sobe) < soba.broj_kreveta and soba.odjel_id = odjel.ID;";
            DataTable dt = DB.Instance.GetData(query);

            int max = dt.Rows.Count;
            string roomNumber = "";
            bool edit = comboBoxFirstItem != "";

            HashSet<String> data = new HashSet<string>();

            if (edit)
            {
                data.Add(comboBoxFirstItem);
            }

            for (int i = 0; i < max; i++)
            {
                roomNumber = dt.Rows[i]["Broj sobe"].ToString();
                roomNumber = $"{roomNumber,-4}";

                data.Add(roomNumber +  " |   " + dt.Rows[i]["Odjel"].ToString());
            }
            comboSoba.DataSource = data.ToList();
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
