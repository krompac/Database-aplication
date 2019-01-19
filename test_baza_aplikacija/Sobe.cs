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
        private Form2 Forma2;

        private enum krevetnost_sobe
        {
            Jednokrevetna = 1,
            Dvokrevetna = 2,
            Trokrevetna = 3
        };

        public Sobe(Form2 form)
        {
            InitializeComponent();
            this.connection = form.connection;
            this.Show();
            Forma2 = form;
            napuni(dataGridView1, 1);
            napuni(dataGridView2, 2);
        }

        public void napuni(DataGridView dataGridView, int broj_odjela)
        {
            dataGridView.Rows.Clear();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.Broj_sobe as 'Broj sobe', s.broj_kreveta as 'Broj kreveta',  s.broj_kreveta - broj_praznih_kreveta(s.Broj_sobe) as 'Slobodni kreveti', " +
                              "djelatnik.ime, djelatnik.prezime from soba s " +
                              "left join djelatnik on s.sobarica_id = djelatnik.ID where s.odjel_id = " + broj_odjela.ToString() +
                              " order by s.Broj_sobe;";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            
            int i;
            string full_ime;
            krevetnost_sobe krevetnost;

            for (i = 0; i < dt.Rows.Count; i++)
            {
                krevetnost = (krevetnost_sobe)dt.Rows[i]["Broj kreveta"];

                full_ime = dt.Rows[i]["ime"] + " " + dt.Rows[i]["Prezime"];

                dataGridView.Rows.Add(dt.Rows[i]["Broj sobe"], krevetnost.ToString(), dt.Rows[i]["Slobodni kreveti"], full_ime);
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


    }
}
