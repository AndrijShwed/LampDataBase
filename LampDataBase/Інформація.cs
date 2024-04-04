using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LampDataBase
{
    public partial class Інформація : Form
    {
        private List<VillageStreet> villagesStreets = new List<VillageStreet>();
        private List<Lamp> lamps = new List<Lamp>();
        bool mess = false;

        public Інформація()
        {

            InitializeComponent();
            HeaderOfTheTable();

            StartPosition = FormStartPosition.CenterScreen;

            Населений_пункт.Text = "Виберіть населений пункт";


            villagesStreets.Clear();

            ConnectionClass _manager = new ConnectionClass();
            MySqlDataReader _reader;
            _manager.openConnection();

            string reader = "SELECT DISTINCT village FROM villagestreet";
            MySqlCommand _search = new MySqlCommand(reader, _manager.getConnection());
            _reader = _search.ExecuteReader();

            while (_reader.Read())
            {
                VillageStreet row = new VillageStreet(_reader["village"]);
                villagesStreets.Add(row);

            }
            _reader.Close();

            for (int i = 0; i < villagesStreets.Count; i++)
            {
                AddDataGrid(villagesStreets[i]);
                mess = true;
            }
            if (mess == false)
            {
                MessageBox.Show("Таблиця населених пунктів і вулиць пуста, спочатку заповніть дані !");
            }
            _manager.closeConnection();

        }

        private void HeaderOfTheTable()
        {
            this.dataGridViewВікноПошуку.DefaultCellStyle.Font = new System.Drawing.Font("TimeNewRoman", 10);
            this.dataGridViewВікноПошуку.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewВікноПошуку.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            this.dataGridViewВікноПошуку.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewВікноПошуку.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            this.dataGridViewВікноПошуку.EnableHeadersVisualStyles = false;


            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер п/п";
            column1.Width = 100;
            //column1.Name = "people_id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Населений пункт";
            column2.Width = 180;
            //column2.Name = "lastname";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Вулиця";
            column3.Width = 180;
            //column3.Name = "name";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Номер опори";
            column4.Width = 115;
            //column4.Name = "surname";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Виробник";
            column5.Width = 140;
            column5.Name = "sex";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Гарантія";
            column6.Width = 110;
            column6.Name = "date_of_birth";
            column6.Frozen = true;

            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Дата покупки";
            column7.Width = 150;
            column7.Name = "village";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Дата заміни";
            column8.Width = 150;
            column8.Name = "street";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Статус";
            column9.Width = 250;
            column9.Name = "numb_of_house";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();


            dataGridViewВікноПошуку.Columns.Add(column1);
            dataGridViewВікноПошуку.Columns.Add(column2);
            dataGridViewВікноПошуку.Columns.Add(column3);
            dataGridViewВікноПошуку.Columns.Add(column4);
            dataGridViewВікноПошуку.Columns.Add(column5);
            dataGridViewВікноПошуку.Columns.Add(column6);
            dataGridViewВікноПошуку.Columns.Add(column7);
            dataGridViewВікноПошуку.Columns.Add(column8);
            dataGridViewВікноПошуку.Columns.Add(column9);

            dataGridViewВікноПошуку.AllowUserToAddRows = false;
            dataGridViewВікноПошуку.ReadOnly = true;
        }

        private void AddDataGrid(VillageStreet row)
        {
            Населений_пункт.Items.Add(row.village);
        }

        private void AddDataGrid_1(VillageStreet row)
        {
            Вулиця.Items.Add(row.village);
        }


        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form головна = new Form();
            this.Hide();
            головна.Show();
        }

        private void Пошук_MouseHover(object sender, EventArgs e)
        {
            Пошук.BackColor = Color.Red;
        }

        private void Пошук_MouseLeave(object sender, EventArgs e)
        {
            Пошук.BackColor = Color.White;
        }
        private void AddDataGrid(Lamp row)
        {
            dataGridViewВікноПошуку.Rows.Add(row.numb, row.village, row.street, row.supportNumb, row.produce, row.warranty,
                row.date, row.dateOfPurchase, row.status);
        }


        private void Пошук_MouseClick(object sender, MouseEventArgs e)
        {

            dataGridViewВікноПошуку.DataSource = null;
            dataGridViewВікноПошуку.Rows.Clear();
            lamps.Clear();

            string village = Населений_пункт.Text;
            string street = Вулиця.Text;

            int year = 0;
            int month = 0;

            if (Виберіть_рік.Text != "")
            {
                if (Convert.ToInt32(Виберіть_рік.Text) > DateTime.Now.Year)
                {
                    MessageBox.Show("Некоректно вибрано рік !");
                    return;
                }
                else
                {
                    year = Convert.ToInt32(Виберіть_рік.Text);
                }
            }

            if (Виберіть_місяць.Text != "" && Виберіть_рік.Text == "")
            {
                MessageBox.Show("Вкажіть рік !");
                return;
            }


            if (Виберіть_місяць.Text != "" && Виберіть_рік.Text != "")
            {
                if (Convert.ToInt32(Виберіть_рік.Text) == DateTime.Now.Year && Convert.ToInt32(Виберіть_місяць.Text) >= DateTime.Now.Month)
                {
                    MessageBox.Show("Некоректно введено місяць !");
                    return;
                }
                else
                {
                    month = Convert.ToInt32(Виберіть_місяць.Text);
                }

            }

            bool first = false;
            string strSearch = "SELECT * FROM lamp ";
            if (village != "")
            {
                if (first == false)
                {
                    strSearch += "WHERE `village` = '" + village + "'";
                    first = true;
                }
                else
                {
                    strSearch += "AND `village` = '" + village + "'";
                }
            }
            if (street != "")
            {
                if (first == false)
                {
                    strSearch += "WHERE `street` = '" + street + "'";
                    first = true;
                }
                else
                {
                    strSearch += "AND `street` = '" + street + "'";
                }
            }
            if (year != 0)
            {
                if (first == false)
                {
                    strSearch += "WHERE Year(changeDate) = '" + year + "'";
                    first = true;
                }
                else
                {
                    strSearch += "AND Year(changeDate) = '" + year + "'";
                }
            }
            if (year != 0 && month != 0)
            {
                if (first == false)
                {
                    strSearch += "WHERE Year(changeDate) = '" + year + "' AND Month(changeDate) = '" + month + "'";
                    first = true;
                }
                else
                {
                    strSearch += "AND Year(changeDate) = '" + year + "' AND Month(changeDate) = '" + month + "'";
                }
            }
            ConnectionClass _manager = new ConnectionClass();
            MySqlDataReader _reader;
            _manager.openConnection();


            MySqlCommand _search = new MySqlCommand(strSearch, _manager.getConnection());
            _reader = _search.ExecuteReader();

            while (_reader.Read())
            {
                Lamp row = new Lamp(_reader["idLamp"], _reader["village"], _reader["street"], _reader["supportNumb"], _reader["produce"],
                     _reader["warranty"], _reader["buyDate"], _reader["changeDate"], _reader["status"]);
                lamps.Add(row);

            }
            _reader.Close();



            for (int i = 0; i < lamps.Count; i++)
            {
                lamps[i].numb = i + 1;
                lamps[i].date = lamps[i].date.ToString().Substring(0, 10);
                lamps[i].dateOfPurchase = lamps[i].dateOfPurchase.ToString().Substring(0, 10);
                switch (lamps[i].status.ToString())
                {
                    case "First":
                        lamps[i].status = "Замінено вперше";
                        break;
                    case "Warranty":
                        lamps[i].status = "Замінено по гарантії";
                        break;
                    case "WarrantyEnd":
                        lamps[i].status = "Гарантія закінчилась";
                        break;
                    default: break;

                }

                AddDataGrid(lamps[i]);

                dataGridViewВікноПошуку.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            Count.Text = lamps.Count.ToString();
            if (lamps.Count == 0)
            {
                MessageBox.Show("Записів не знайдено ! ");
            }




        }

        private void Населений_пункт_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Вулиця.Items.Clear();
            string village = Населений_пункт.Text;
            Вулиця.Text = "Виберіть вулицю";



            villagesStreets.Clear();

            ConnectionClass _manager = new ConnectionClass();
            MySqlDataReader _reader;
            _manager.openConnection();

            string reader = "SELECT street FROM villagestreet WHERE `village` = '" + village + "'";
            MySqlCommand _search = new MySqlCommand(reader, _manager.getConnection());
            _reader = _search.ExecuteReader();

            while (_reader.Read())
            {
                VillageStreet row = new VillageStreet(_reader["street"]);
                villagesStreets.Add(row);

            }
            _reader.Close();

            for (int i = 0; i < villagesStreets.Count; i++)
            {
                AddDataGrid_1(villagesStreets[i]);
                mess = true;
            }
            if (mess == false)
            {
                MessageBox.Show("Таблиця населених пунктів і вулиць пуста, спочатку заповніть дані !");
            }
            _manager.closeConnection();
        }

        private void Очистити_поля_пошуку_Click(object sender, EventArgs e)
        {
            Населений_пункт.SelectedIndex = -1;
            Вулиця.SelectedIndex = -1;
            Виберіть_рік.SelectedIndex = -1;
            Виберіть_місяць.SelectedIndex = -1;
            mess = true;
        }

        private void Очистити_таблицю_Click(object sender, EventArgs e)
        {
            dataGridViewВікноПошуку.Rows.Clear();
        }
    }
}
