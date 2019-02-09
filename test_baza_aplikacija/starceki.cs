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
    public partial class starceki : UserControl
    {
        private enum odjeli
        {
            pokretni,
            nepokretni,
            oboje
        };

        public MySqlConnection connection;
        private odjeli izbor;
        public int line_number;
        private glavna_forma parent_form;

        public starceki()
        {
            InitializeComponent();
        }

        public void load_starceki(MySqlConnection sqlConnection, glavna_forma form1)
        {
            this.connection = sqlConnection;
            parent_form = form1;
            this.Show();
            izbor = odjeli.oboje;
            napuni();
        }

        public void clear_datagrid()
        {
            this.dataGridView.Rows.Clear();
            this.dataGridView.Refresh();
        }

        private void dataGridView1_DoubleCellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StarcekAU starcek = new StarcekAU(e.RowIndex, this, this.dataGridView);
            starcek.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            izbrisi.Enabled = true;
            izbrisi.Show();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nepokretni.Checked)
            {
                pokretni.Checked = false;
                izbor = odjeli.nepokretni;
            }
            else if (pokretni.Checked)
            {
                nepokretni.Checked = false;
                izbor = odjeli.pokretni;
            }
            else
            {
                izbor = odjeli.oboje;
            }

            napuni();
        }

        public void set_line_number()
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from stara_osoba order by id desc limit 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            try
            {
                Int32.TryParse(dt.Rows[0]["id"].ToString(), out line_number);
            }
            catch
            {
                line_number = 0;
            }
            finally
            {
                connection.Close();
            }
            
        }

        public void napuni(string sql = "")
        {
            string naziv_odjela = "";

            if (izbor == odjeli.pokretni)
            {
                naziv_odjela = " and o.naziv = 'Pokretni' ";
            }
            else if (izbor == odjeli.nepokretni)
            {
                naziv_odjela = " and o.naziv = 'Polupokretni/Nepokretni'";
            }

            dataGridView.Rows.Clear();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.ID as ID, s.ime as Ime, s.prezime as Prezime, s.kontakt_osoba as 'Kontakt osoba', s.datum_useljenja as 'Datum useljenja', s.soba_id as 'Broj sobe', o.naziv as Odjel " +
                              "from stara_osoba s, odjel o " +
                              "left join soba on o.ID = soba.odjel_id " +
                              "where s.soba_id = soba.broj_sobe " + naziv_odjela + sql +
                              "order by s.ime;";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            line_number = dt.Rows.Count;
            int i;
            string vrijeme = "";

            for (i = 0; i < line_number; i++)
            {
                vrijeme = dt.Rows[i]["Datum useljenja"].ToString();
                vrijeme = vrijeme.Substring(0, 9);

                dataGridView.Rows.Add(dt.Rows[i]["Ime"], dt.Rows[i]["Prezime"], dt.Rows[i]["Kontakt osoba"], vrijeme, dt.Rows[i]["Broj sobe"], dt.Rows[i]["Odjel"], dt.Rows[i]["ID"]);
            }

            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            set_line_number();
            StarcekAU starcek = new StarcekAU(this);
            starcek.Show();
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                var pitanje = MessageBox.Show("Želite li izbrisati odabrane ćelije?", "Brisanje ćelija", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (pitanje == DialogResult.Yes)
                {

                    int cell_count = dataGridView.SelectedCells.Count;
                    int row_index;

                    connection.Open();

                    for (int i = 0; i < cell_count; i++)
                    {
                        row_index = dataGridView.SelectedCells[i].RowIndex;
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from stara_osoba where id = " + dataGridView.Rows[row_index].Cells[6].Value.ToString() + ";";

                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                    napuni();
                }
            }
        }

        private void data_filter(object sender, EventArgs e)
        {
            int broj;
            bool je_broj = Int32.TryParse(filter.Text, out broj);
            string sql = "";

            if (je_broj)
            {
                sql = " and s.soba_id = " + broj.ToString() + " ";
            }
            else
            {
                if (filter.Text != "")
                {
                    sql = " and (s.ime like '%" + filter.Text + "%' or s.prezime like '%" + filter.Text + "%' or CONCAT(s.ime, ' ', s.prezime) like '%";
                    sql += filter.Text + "%' or CONCAT(s.prezime, ' ', s.ime) like '%" + filter.Text + "%' or s.kontakt_osoba like '%" + filter.Text + "%') ";
                }
            }
            napuni(sql);
        }

    }
}
