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
        private enum odjeli
        {
            pokretni,
            nepokretni,
            oboje
        };

        public MySqlConnection connection;
        private odjeli izbor;
        public int line_number;
        private Form1 parent_form;
        private bool user_closing;

        public Form2(MySqlConnection sqlConnection, Form1 form1)
        {
            InitializeComponent();
            this.connection = sqlConnection;
            parent_form = form1;

            dodaj_starca.Enabled = false;
            dodaj_starca.Hide();
            pokretni.Enabled = false;
            pokretni.Hide();
            nepokretni.Enabled = false;
            nepokretni.Hide();
            dataGridView.Enabled = false;
            dataGridView.Hide();

            user_closing = true;
            izbrisi.Enabled = false;
            izbrisi.Hide();
        }

        public void napuni()
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
            cmd.CommandText = "select s.ID as ID, s.ime as Ime, s.prezime as Prezime, s.god_rodjenja as 'Godina rođenja', s.datum_useljenja as 'Datum useljenja', s.soba_id as 'Broj sobe', o.naziv as Odjel " +
                              "from stara_osoba s, odjel o " +
                              "left join soba on o.ID = soba.odjel_id " +
                              "where s.soba_id = soba.broj_sobe " + naziv_odjela +
                              "order by s.ime;";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);

            line_number = dt.Rows.Count;
            int i;
            string vrijeme = "";
            string god_vrijeme = "";

            for (i = 0; i < line_number; i++)
            {
                vrijeme = dt.Rows[i]["Datum useljenja"].ToString();
                vrijeme = vrijeme.Substring(0, 9);
                god_vrijeme = dt.Rows[i]["Godina rođenja"].ToString();
                god_vrijeme = god_vrijeme.Substring(0, 9);

                dataGridView.Rows.Add(dt.Rows[i]["Ime"], dt.Rows[i]["Prezime"], god_vrijeme, vrijeme, dt.Rows[i]["Broj sobe"], dt.Rows[i]["Odjel"], dt.Rows[i]["ID"]);
            }

            connection.Close();
        }

        //starčeki
        private void button1_Click(object sender, EventArgs e)
        {
            izbor = odjeli.oboje;

            dodaj_starca.Enabled = true;
            dodaj_starca.Show();
            pokretni.Enabled = true;
            pokretni.Show();
            nepokretni.Enabled = true;
            nepokretni.Show();
            dataGridView.Enabled = true;
            dataGridView.Show();
            izbrisi.Enabled = true;
            izbrisi.Show();

            napuni();
        }

        //dodaj
        private void button5_Click(object sender, EventArgs e)
        {
            StarcekAU starcek = new StarcekAU(this);
            starcek.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (pokretni.Checked)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (nepokretni.Checked)
            {
                pokretni.Checked = false;
                izbor = odjeli.nepokretni;
            }
            else
            {
                izbor = odjeli.oboje;
            }

            napuni();
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

        private void natrag_Click(object sender, EventArgs e)
        {
            parent_form.prikazi_ovu_formu();
            user_closing = false;
            this.Close();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && user_closing)
            {
                parent_form.Close();
            }
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

        private void sobe_Click(object sender, EventArgs e)
        {
            Sobe sobe = new Sobe(this);
        }
    }
}
