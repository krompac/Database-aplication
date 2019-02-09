using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test_baza_aplikacija
{
    public partial class djelatnik : UserControl
    {
        MySqlConnection connection;
        private string sql_combo = "";
        private string sql_filter = "";

        public djelatnik()
        {
            InitializeComponent();
        }

        public void load_djelatnici(glavna_forma forma)
        {
            this.Show();
            this.connection = forma.connection;
            this.napuni_djelatnike();
            this.napuni_combobox();
        }

        public void clear_datagridview()
        {
            this.dataGridDjelatnici.Rows.Clear();
            this.dataGridDjelatnici.Refresh();
        }

        private void napuni_djelatnike()
        {
            dataGridDjelatnici.Rows.Clear();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.ID, d.ime, d.prezime, r.naziv as 'Radna jedinica', d.broj_mobitela, d.email, d.datum_zaposlenja, s.naziv as smjena, d.mjesto_stanovanja from djelatnik d " +
                              "left join radna_jedinica r on d.radna_jedinica_id = r.ID " +
                              "left join smjena s on d.smjena_id = s.ID where d.ID " + sql_filter + sql_combo +
                              "order by d.ime";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);
            connection.Close();

            int i;
            string vrijeme;

            for (i = 0; i < dt.Rows.Count; i++)
            {
                vrijeme = dt.Rows[i]["datum_zaposlenja"].ToString();
                vrijeme = vrijeme.Substring(0, 9);
                dataGridDjelatnici.Rows.Add(dt.Rows[i]["ime"], dt.Rows[i]["prezime"], dt.Rows[i]["Radna jedinica"], dt.Rows[i]["broj_mobitela"],
                                         dt.Rows[i]["email"], vrijeme, dt.Rows[i]["smjena"], dt.Rows[i]["mjesto_stanovanja"], dt.Rows[i]["id"]);
            }
        }

        private void napuni_combobox()
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select naziv from radna_jedinica;";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);
            connection.Close();

            int i;
            List<string> combo_vrijednosti = new List<string>();
            combo_vrijednosti.Add("");

            for (i = 0; i < dt.Rows.Count; i++)
            {
                combo_vrijednosti.Add(dt.Rows[i]["naziv"].ToString());
            }

            comboBox1.DataSource = combo_vrijednosti;
        }

        private void combobox_changed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                sql_combo = " and r.naziv = '" + comboBox1.SelectedValue.ToString() + "' ";
            }
            else
            {
                sql_combo = "";
            }

            napuni_djelatnike();
        }

        private void text_changed(object sender, EventArgs e)
        {
            int broj;
            bool je_broj = Int32.TryParse(textBox1.Text, out broj);

            if (textBox1.Text != "")
            {
                sql_filter = " and (d.ime like '%" + textBox1.Text + "%' or d.prezime like '%" + textBox1.Text + "%' or CONCAT(d.ime, ' ', d.prezime) like '%" + textBox1.Text + "%' or CONCAT(d.prezime, ' ', d.ime) like '%" + textBox1.Text + "%') ";
            }
            else
            {
                sql_filter = "";
            }

            napuni_djelatnike();
        }

    }
}
