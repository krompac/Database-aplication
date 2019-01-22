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
    public partial class djelatnici : Form
    {
        MySqlConnection connection;


        public djelatnici(glavna_forma forma)
        {
            InitializeComponent();
            this.connection = forma.connection;
            this.napuni_djelatnike();
        }

        public void napuni_djelatnike(string uvjet = "")
        {
            dataGridDjelatnici.Rows.Clear();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.ID, d.ime, d.prezime, r.naziv as 'Radna jedinica', d.broj_mobitela, d.email, d.datum_zaposlenja, s.naziv as smjena, d.mjesto_stanovanja from djelatnik d " +
                              "left join radna_jedinica r on d.radna_jedinica_id = r.ID " +
                              "left join smjena s on d.smjena_id = s.ID " + uvjet +
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

        private void text_changed(object sender, EventArgs e)
        {
            int broj;
            bool je_broj = Int32.TryParse(textBox1.Text, out broj);
            string sql = "";

            if (textBox1.Text != "")
            {
                sql = " where d.ime like '%" + textBox1.Text + "%' or d.prezime like '%" + textBox1.Text + "%' or CONCAT(d.ime, ' ', d.prezime) like '%" + textBox1.Text + "%' or CONCAT(d.prezime, ' ', d.ime) like '%" + textBox1.Text + "%'";
            }
            napuni_djelatnike(sql);
        }
    }
}
