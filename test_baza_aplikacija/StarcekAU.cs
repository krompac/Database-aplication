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

        public StarcekAU(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        //DODAJ
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ime as Ime, prezime as Prezime, god_rodjenja as 'Godina rođenja', " +
                              "datum_useljenja as 'Datum useljenja', soba_id as 'Broj sobe', spol as Spol, diabeticar as Diabeticar from stara_osoba;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(dt);
            
            connection.Close();
        }
    }
}
