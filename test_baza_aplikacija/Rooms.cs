using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NursingHomeApplication
{
    public partial class Rooms : UserControl
    {
        private bool secondLoad = false;

        private List<string> cb = new List<string>()
        {
            "",
            " and s.broj_kreveta - broj_praznih_kreveta(s.Broj_sobe) = 0 ",
            " and s.broj_kreveta - broj_praznih_kreveta(s.Broj_sobe) != 0 ",
            " and broj_praznih_kreveta(s.Broj_sobe) = 0 "
        };

        public Rooms()
        {
            InitializeComponent();
        }

        private enum RoomType
        {
            OneBed = 1,
            TwoBed = 2,
            ThreeBed = 3
        };

        public void LoadRooms(MainForm form)
        {
            this.Show();

            combonepok.SelectedIndex = 0;
            combopok.SelectedIndex = 0;

            if (!secondLoad)
            {
                secondLoad = true;
            }
            else
            {
                FillDataGridView(dataGridView1, 1, combopok);
                FillDataGridView(dataGridView2, 2, combonepok);
            }
        }

        public void ClearViews()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            this.dataGridView2.Rows.Clear();
            this.dataGridView2.Refresh();
        }

        private void FillDataGridView(DataGridView dataGridView, int departmentNumber, ComboBox comboBox, int roomNumber = 0, 
                                      string cleaningLady = "")
        {
            dataGridView.Rows.Clear();
            string query = "select s.Broj_sobe as 'Broj sobe', s.broj_kreveta as 'Broj kreveta',"+
                              "s.broj_kreveta - broj_praznih_kreveta(s.Broj_sobe) as 'Slobodni kreveti', " +
                              "djelatnik.ime, djelatnik.prezime from soba s " +
                              "left join djelatnik on s.sobarica_id = djelatnik.ID where s.odjel_id = " + 
                              departmentNumber.ToString() + cleaningLady + cb[comboBox.SelectedIndex] +
                              " order by s.Broj_sobe;";

            DataTable dt = DB.Instance.GetData(query);

            int i;
            string fullName;
            RoomType roomType;

            if (roomNumber > 0)
            {
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    roomType = (RoomType)dt.Rows[i]["Broj kreveta"];
                    fullName = dt.Rows[i]["ime"] + " " + dt.Rows[i]["Prezime"];

                    if (dt.Rows[i]["Broj sobe"].ToString().Contains(roomNumber.ToString()))
                    {
                        dataGridView.Rows.Add(dt.Rows[i]["Broj sobe"], roomType.ToString(), dt.Rows[i]["Slobodni kreveti"], fullName);
                    }
                }
            }
            else
            {
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    roomType = (RoomType)dt.Rows[i]["Broj kreveta"];
                    fullName = dt.Rows[i]["ime"] + " " + dt.Rows[i]["Prezime"];

                    dataGridView.Rows.Add(dt.Rows[i]["Broj sobe"], roomType.ToString(), dt.Rows[i]["Slobodni kreveti"], fullName);
                }
            }

            if (departmentNumber == 1)
            {
                broj_soba_pok.Text = dt.Rows.Count.ToString();
            }
            else
            {
                broj_soba_nepok.Text = dt.Rows.Count.ToString();
            }
        }

        private string QueryForCleaningLady(string text)
        {
            return " and (djelatnik.ime like '%" + text + "%' or djelatnik.prezime like '%" + text + "%' or CONCAT(djelatnik.ime, ' ', djelatnik.prezime) like '%" 
                         + text + "%') ";
        }

        private void Filter(DataGridView gridView, TextBox filter, int departmentId, ComboBox comboBox)
        {
            bool isNumber = Int32.TryParse(filter.Text, out int number);

            if (isNumber)
            {
                FillDataGridView(gridView, departmentId, comboBox, number);
            }
            else if (filter.Text != "")
            {
                FillDataGridView(gridView, departmentId, comboBox, -1, QueryForCleaningLady(filter.Text));
            }
            else
            {
                FillDataGridView(gridView, departmentId, comboBox);
            }
        }

        private void ChangeData(object sender, EventArgs e)
        {
            if (sender == trazi_pok || sender == combopok)
            {
                Filter(dataGridView1, trazi_pok, 1, combopok);
            }
            else if (sender == trazi_nepok || sender == combonepok)
            {
                Filter(dataGridView2, trazi_nepok, 2, combonepok);
            }
        }
    }
}
