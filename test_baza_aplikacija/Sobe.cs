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
    public partial class Sobe : Form
    {
        private MySqlConnection connection;
        private glavna_forma Forma2;

        private List<string> cb = new List<string>()
        {
            "",
            " and s.broj_kreveta - broj_praznih_kreveta(s.Broj_sobe) = 0 ",
            " and s.broj_kreveta - broj_praznih_kreveta(s.Broj_sobe) != 0 ",
            " and broj_praznih_kreveta(s.Broj_sobe) = 0 "
        };

        private enum krevetnost_sobe
        {
            Jednokrevetna = 1,
            Dvokrevetna = 2,
            Trokrevetna = 3
        };

        public Sobe(glavna_forma form)
        {
            InitializeComponent();
            this.connection = form.connection;
            
            Forma2 = form;
            combonepok.SelectedIndex = 0;
            combopok.SelectedIndex = 0;
        }
        
        public void napuni_oba_viewa()
        {
            napuni(dataGridView1, 1, combopok);
            napuni(dataGridView2, 2, combonepok);
        }

        private void napuni(DataGridView dataGridView, int broj_odjela, ComboBox pok, int br_sobe = 0, string sobarica_sql = "")
        {
            dataGridView.Rows.Clear();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.Broj_sobe as 'Broj sobe', s.broj_kreveta as 'Broj kreveta',  s.broj_kreveta - broj_praznih_kreveta(s.Broj_sobe) as 'Slobodni kreveti', " +
                              "djelatnik.ime, djelatnik.prezime from soba s " +
                              "left join djelatnik on s.sobarica_id = djelatnik.ID where s.odjel_id = " + broj_odjela.ToString() + sobarica_sql + cb[pok.SelectedIndex] + 
                              " order by s.Broj_sobe;";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            int i;
            string full_ime;
            krevetnost_sobe krevetnost;

            if (br_sobe > 0)
            {
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    krevetnost = (krevetnost_sobe)dt.Rows[i]["Broj kreveta"];
                    full_ime = dt.Rows[i]["ime"] + " " + dt.Rows[i]["Prezime"];

                    if (dt.Rows[i]["Broj sobe"].ToString().Contains(br_sobe.ToString()))
                    {
                        dataGridView.Rows.Add(dt.Rows[i]["Broj sobe"], krevetnost.ToString(), dt.Rows[i]["Slobodni kreveti"], full_ime);
                    }
                }
            }
            else
            {
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    krevetnost = (krevetnost_sobe)dt.Rows[i]["Broj kreveta"];
                    full_ime = dt.Rows[i]["ime"] + " " + dt.Rows[i]["Prezime"];

                    dataGridView.Rows.Add(dt.Rows[i]["Broj sobe"], krevetnost.ToString(), dt.Rows[i]["Slobodni kreveti"], full_ime);
                }
            }

            if (broj_odjela == 1)
            {
                broj_soba_pok.Text = dt.Rows.Count.ToString();
            }
            else
            {
                broj_soba_nepok.Text = dt.Rows.Count.ToString();
            }

            connection.Close();
        }

        private string sobarica_SQL(string text)
        {
            string SQL = " and (djelatnik.ime like '%" + text + "%' or djelatnik.prezime like '%" + text + "%' or CONCAT(djelatnik.ime, ' ', djelatnik.prezime) like '%" + text + "%') ";

            return SQL;
        }

        private void filter(DataGridView gridView, TextBox filter, int odj_id, ComboBox pok)
        {
            int broj;
            bool je_broj = Int32.TryParse(filter.Text, out broj);

            if (je_broj)
            {
                napuni(gridView, odj_id, pok, broj);
            }
            else if (filter.Text != "")
            {
                napuni(gridView, odj_id, pok, -1, sobarica_SQL(filter.Text));
            }
            else
            {
                napuni(gridView, odj_id, pok);
            }
        }

        private void textPok_changed(object sender, EventArgs e)
        {
            if (sender == trazi_pok || sender == combopok)
            {
                filter(dataGridView1, trazi_pok, 1, combopok);
            }
            else if (sender == trazi_nepok || sender == combonepok)
            {
                filter(dataGridView2, trazi_nepok, 2, combonepok);
            }
        }
    }
}
