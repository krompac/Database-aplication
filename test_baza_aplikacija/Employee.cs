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

namespace NursingHomeApplication
{
    public partial class Employee : UserControl
    {
        MySqlConnection connection;
        private string fillComboBoxQuery = "";
        private string filterQuery = "";

        public Employee()
        {
            InitializeComponent();
        }

        public void LoadEmployees(MainForm forma)
        {
            this.Show();
            this.connection = forma.connection;
            this.FillEmployeeView();
            this.FillCombobox();
        }

        public void ClearView()
        {
            this.dataGridDjelatnici.Rows.Clear();
            this.dataGridDjelatnici.Refresh();
        }

        private void FillEmployeeView()
        {
            dataGridDjelatnici.Rows.Clear();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select d.ID, d.ime, d.prezime, r.naziv as 'Radna jedinica', d.broj_mobitela, d.email, d.datum_zaposlenja, s.naziv as smjena, " +
                              "d.mjesto_stanovanja from djelatnik d " +
                              "left join radna_jedinica r on d.radna_jedinica_id = r.ID " +
                              "left join smjena s on d.smjena_id = s.ID where d.ID " + filterQuery + fillComboBoxQuery +
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

        private void FillCombobox()
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
            List<string> comboBoxValues = new List<string>() {""};

            for (i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxValues.Add(dt.Rows[i]["naziv"].ToString());
            }

            comboBox1.DataSource = comboBoxValues;
        }

        private void combobox_changed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                fillComboBoxQuery = " and r.naziv = '" + comboBox1.SelectedValue.ToString() + "' ";
            }
            else
            {
                fillComboBoxQuery = "";
            }

            FillEmployeeView();
        }

        private void text_changed(object sender, EventArgs e)
        {
            Int32.TryParse(textBox1.Text, out int number);

            filterQuery = textBox1.Text != "" ? " and (d.ime like '%" + textBox1.Text + "%' or d.prezime like '%" + textBox1.Text 
                                                + "%' or CONCAT(d.ime, ' ', d.prezime) like '%"
                                                + textBox1.Text + "%' or CONCAT(d.prezime, ' ', d.ime) like '%" + textBox1.Text + "%') " 
                                                : "";
            FillEmployeeView();
        }
    }
}
