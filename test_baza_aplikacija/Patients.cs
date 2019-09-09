using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NursingHomeApplication
{
    public partial class Patients : UserControl
    {
        private enum Departments
        {
            mobile,
            immobile,
            both
        };

        public MySqlConnection connection;
        private Departments department;
        public int lineNumber;
        private MainForm mainForm;

        public Patients()
        {
            InitializeComponent();
        }

        public void LoadPatients(MySqlConnection sqlConnection, MainForm form)
        {
            this.connection = sqlConnection;
            mainForm = form;
            this.Show();
            department = Departments.both;
            FillView();
        }

        public void ClearView()
        {
            this.dataGridView.Rows.Clear();
            this.dataGridView.Refresh();
        }

        private void dataGridView1_DoubleCellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PatientForm starcek = new PatientForm(e.RowIndex, this, this.dataGridView);
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
                department = Departments.immobile;
            }
            else if (pokretni.Checked)
            {
                nepokretni.Checked = false;
                department = Departments.mobile;
            }
            else
            {
                department = Departments.both;
            }

            FillView();
        }

        public void SetLineNumber()
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
                Int32.TryParse(dt.Rows[0]["id"].ToString(), out lineNumber);
            }
            catch
            {
                lineNumber = 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public void FillView(string sql = "")
        {
            string naziv_odjela = "";

            if (department == Departments.mobile)
            {
                naziv_odjela = " and o.naziv = 'Pokretni' ";
            }
            else if (department == Departments.immobile)
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

            lineNumber = dt.Rows.Count;
            int i;
            string vrijeme = "";

            for (i = 0; i < lineNumber; i++)
            {
                vrijeme = dt.Rows[i]["Datum useljenja"].ToString();
                vrijeme = vrijeme.Substring(0, 9);

                dataGridView.Rows.Add(dt.Rows[i]["Ime"], dt.Rows[i]["Prezime"], dt.Rows[i]["Kontakt osoba"], vrijeme, dt.Rows[i]["Broj sobe"], dt.Rows[i]["Odjel"], dt.Rows[i]["ID"]);
            }

            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetLineNumber();
            PatientForm starcek = new PatientForm(this);
            starcek.Show();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                var question = MessageBox.Show("Želite li izbrisati odabrane ćelije?", "Brisanje ćelija", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (question == DialogResult.Yes)
                {
                    int cellCount = dataGridView.SelectedCells.Count;
                    int rowIndex;

                    connection.Open();

                    for (int i = 0; i < cellCount; i++)
                    {
                        rowIndex = dataGridView.SelectedCells[i].RowIndex;
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from stara_osoba where id = " + dataGridView.Rows[rowIndex].Cells[6].Value.ToString() + ";";

                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                    FillView();
                }
            }
        }

        private void DataFilter(object sender, EventArgs e)
        {
            bool isNumber = Int32.TryParse(filter.Text, out int number);
            string sql = "";

            if (isNumber)
            {
                sql = " and s.soba_id = " + number.ToString() + " ";
            }
            else
            {
                if (filter.Text != "")
                {
                    sql = " and (s.ime like '%" + filter.Text + "%' or s.prezime like '%" + filter.Text + "%' or CONCAT(s.ime, ' ', s.prezime) like '%";
                    sql += filter.Text + "%' or CONCAT(s.prezime, ' ', s.ime) like '%" + filter.Text + "%' or s.kontakt_osoba like '%" + filter.Text + "%') ";
                }
            }
            FillView(sql);
        }
    }
}
