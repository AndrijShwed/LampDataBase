using MySqlConnector;
using System.Drawing.Printing;

namespace LampDataBase
{

    public partial class Form1 : Form
    {
        private List<VillageStreet> villagesStreets = new List<VillageStreet>();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            comboBox1.Text = "Виберіть населений пункт";

            bool mess = false;
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

        private void AddDataGrid(VillageStreet row)
        {
            comboBox1.Items.Add(row.village);
        }

        private void AddDataGrid_1(VillageStreet row)
        {
            comboBox2.Items.Add(row.village);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string village = comboBox1.Text;
            comboBox2.Text = "Виберіть вулицю";


            bool mess = false;
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
       

        class CountLamp
        {
            public string Status;
            public DateTime DateCount;

        }
        List<Lamp> lamps = new List<Lamp>();

        List<CountLamp> countLamps = new List<CountLamp>();
        int pNum = 1;

        ConnectionClass _manager = new ConnectionClass();

        private void Заміна_Click(object sender, EventArgs e)
        {

            string newSupportNumb = textBox1.Text;
            string newVillage = comboBox1.Text;
            string newStreet = comboBox2.Text;
            string newProducer = textBox4.Text;
            DateTime newDateOfPurchase = Дата_Покупки.Value;
            string Status = "First";
            int newWarranty;
            if (Int32.TryParse((textBox3.Text), out int j))
            {
                newWarranty = j;
            }
            else
            {
                return;
            }
            DateTime DateCh = DateTime.Now;
            string newDate = DateCh.ToShortDateString();

            if ((textBox1.TextLength == 0) || (textBox3.TextLength == 0) || (textBox4.TextLength == 0) ||
                (comboBox1.SelectedItem == null) || (comboBox2.SelectedItem == null) || (Дата_Покупки.Text == null))
            {
                return;
            }

            else
            {
                string search = "SELECT * FROM lamp WHERE village = '" + newVillage + "' AND" +
                               " street = '" + newStreet + "' AND supportNumb = '" + newSupportNumb + "'";

                MySqlDataReader reader;

                _manager.openConnection();
                MySqlCommand _command = new MySqlCommand(search, _manager.getConnection());

                reader = _command.ExecuteReader();

                bool a = reader.HasRows;
                reader.Read();

                if (!a)
                {
                    Status = "First";

                    listBox1.Items.Add((pNum) + ") с." + comboBox1.Text + ", вул." + comboBox2.Text +
                        ", опора N " + textBox1.Text + "  дата заміни - " + DateCh.ToShortDateString());
                    listBox1.Items.Add("     Виробник - " + newProducer);
                    listBox1.Items.Add("     Гарантія - " + newWarranty + " р.");
                    listBox1.Items.Add("     Лампа замінена вперше. Дата покупки - " + newDateOfPurchase.ToShortDateString() + " р.");
                    listBox1.Items.Add(new string('-', 70));
                    pNum++;
                    reader.Close();
                    _manager.closeConnection();

                }
                else
                {
                    int id = reader.GetInt32(0);

                    string oldVillage = reader.GetString(1);
                    string oldStreet = reader.GetString(2);
                    string oldSupportNumb = reader.GetString(3);
                    string oldProducer = reader.GetString(4);
                    int oldWarranty = reader.GetInt32(5);
                    DateTime dateBuyold = reader.GetDateTime(6);
                    DateTime dateChOld = reader.GetDateTime(7);
                    reader.Close();
                    _manager.closeConnection();
                    string oldDate = dateChOld.ToShortDateString();


                    DateTime dateOldWarranty = dateBuyold.AddYears(oldWarranty);
                    TimeSpan diff = dateOldWarranty - DateCh;

                    int days = Convert.ToInt32(diff.TotalDays);

                    if ((oldVillage == newVillage) && (oldStreet == newStreet) && (oldSupportNumb == newSupportNumb))
                    {
                        if (oldDate == newDate)
                        {
                            MessageBox.Show("На цій опорі сьогодні вже замінено лампу !!!");
                            return;
                        }
                        else if (days > 0)
                        {
                            Status = "Warranty";

                            listBox1.Items.Add((pNum) + ") с." + comboBox1.Text + ", вул." +
                                   comboBox2.Text + ", опора N " + textBox1.Text + " дата заміни - " +
                                   DateCh.ToShortDateString());
                            listBox1.Items.Add("     Виробник - " + oldProducer);
                            listBox1.Items.Add("     Гарантія - " + newWarranty + " р.");
                            listBox1.Items.Add("     Лампа, яку замінили, на гарантії, залишилось - " + days +
                                " днів, встановлена - " + dateChOld.ToShortDateString() + " р.");
                            listBox1.Items.Add("Дата покупки - " + dateBuyold.ToShortDateString() + " р.");
                            listBox1.Items.Add(new string('-', 70));
                            pNum++;


                        }
                        else if (days < 0)
                        {
                            Status = "WarrantyEnd";

                            listBox1.Items.Add((pNum) + ") с." + comboBox1.Text + ", вул." +
                                   comboBox2.Text + ", опора N " + textBox1.Text + ", дата заміни - " +
                                   DateCh.ToShortDateString());
                            listBox1.Items.Add("     Виробник - " + oldProducer);
                            listBox1.Items.Add("     Гарантія - " + newWarranty + " р.");
                            listBox1.Items.Add("     Гарантія у заміненої лампи закінчилась. Дата покупки - " + dateBuyold.ToShortDateString() + " р.");
                            listBox1.Items.Add(new string('-', 70));
                            pNum++;
                        }


                        string del = "DELETE FROM `lamp` WHERE idLamp = " + id;
                        _manager.openConnection();
                        MySqlCommand dele = new MySqlCommand(del, _manager.getConnection());
                        dele.ExecuteNonQuery();
                        _manager.closeConnection();

                    }

                }

            }

            string s1 = newDateOfPurchase.ToShortDateString().Substring(0, 2);
            string s2 = newDateOfPurchase.ToShortDateString().Substring(3, 2);
            string s3 = newDateOfPurchase.ToShortDateString().Substring(6, 4);
            string buyDate = s3 + "-" + s2 + "-" + s1;

            string s4 = DateCh.ToShortDateString().Substring(0, 2);
            string s5 = DateCh.ToShortDateString().Substring(3, 2);
            string s6 = DateCh.ToShortDateString().Substring(6, 4);
            string changeDate = s6 + "-" + s5 + "-" + s4;


            string addLamp = "INSERT INTO `lamp`(`village`,`street`,`supportNumb`,`produce`,`warranty`,`buyDate`,`changeDate`,`status`)" +
                      " VALUES('" + newVillage + "','" + newStreet + "','" + newSupportNumb + "','" + newProducer + "','" + newWarranty + "','"
            + buyDate + "','" + changeDate + "','" + Status + "')";

            _manager.openConnection();
            MySqlCommand _com = new MySqlCommand(addLamp, _manager.getConnection());

            if (_com.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Дані добавлено !!!");
            }
            else
            {
                MessageBox.Show("Помилка роботи з базою даних !!!");
            }
            _manager.closeConnection();

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumTurquoise;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        Point LastPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        //Print
        private int Lines = 0;
        private string[] result;
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == null)
            {
                return;
            }
            int countLines = listBox1.Items.Count + 15;
            result = new string[countLines];

            // задаємо текст для друку
            result[Lines] = "               Протокол проведення заміни ламп вуличного освітлення ";
            Lines++;
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "Бережницький старостинський округ";
            Lines++;
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "Дата проведення " + DateTime.Now.ToShortDateString() + " р.";
            Lines++;
            result[Lines] = "  ";
            Lines++;
           
             foreach (var item in listBox1.Items)
             {
                 result[Lines] = item.ToString();
                 Lines++;
                   
             }
            
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "    Електрик _________________      підпис _____________";
            Lines++;
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "  ";
            Lines++;
            result[Lines] = "    Староста _________________      підпис _____________";
            Lines++;

            //об'єкт для друку
            PrintDocument printDocument = new PrintDocument();

            //обробник друку
            printDocument.PrintPage += PrintPageHandler;

            // діалог налаштування друку
            PrintDialog printDialog = new PrintDialog();

            // встановлення об'єкта друку для його налаштувань
            printDialog.Document = printDocument;

            // якщо в діалозі була натиснута клавіша ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // друкуємо


        }

        int counter = 0;//лічильник строк друку
        int curPage = 1;// поточна сторінка
        // обробник події друку
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            float leftMargin = e.MarginBounds.Left; // відступ зліва у документі
            float topMargin = e.MarginBounds.Top; // відступ зверху в документі
            float yPos = 0; // поточна позиція Y для виведення рядка

            int i = 0;// лічильник рядків на сторінці

            Font myFont = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Font myFont1 = new Font("Arial Italic", 20, FontStyle.Regular, GraphicsUnit.Pixel);

            int nLines = (int)((e.MarginBounds.Height - myFont1.GetHeight(e.Graphics)) / myFont.GetHeight(e.Graphics));
            int nPages = ((Lines - 1) / nLines) + 1;
            if (counter == 0)
            {
                yPos = topMargin;
                e.Graphics.DrawString(result[0], myFont1, Brushes.Black, leftMargin, yPos, new StringFormat());
                counter++;
            }

            while ((i < nLines) && (counter < Lines))
            {
                yPos = topMargin + myFont1.GetHeight(e.Graphics) + i * myFont.GetHeight(e.Graphics);
                // друк рядка result
                e.Graphics.DrawString(result[counter], myFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                i++;
                counter++;
            }
            // визначення чи потрібна ще одна сторінка
            e.HasMorePages = false;

            if (curPage < nPages)
            {
                // надання ще однієї сторінки
                e.HasMorePages = true;
                curPage++;

            }
        }

        int f;
        int w;
        int we;
        private void button5_Click(object sender, EventArgs e)
        {
            f = w = we = 0;

            listBox2.Items.Clear();

            if ((textBox2.TextLength == 0) || (comboBox3.SelectedItem == null))
            {
                return;
            }
            int Year = Convert.ToInt32(textBox2.Text);
            int Month = Convert.ToInt32(comboBox3.Text);

            if ((Year > DateTime.Now.Year) || (Year < 2020))
            {
                listBox2.Items.Add("Некоректно введено рік ");
                return;
            }
            if ((Year == DateTime.Now.Year) && (Month > DateTime.Now.Month))
            {
                listBox2.Items.Add("Некоректно введена дата ");
                return;
            }

            string searchStatistic = " str";

            if (Convert.ToInt32(comboBox3.Text) == 0)
            {
                string d1 = Year.ToString();

                searchStatistic = "SELECT * FROM lamp WHERE Year(changeDate) = '" + d1 + "'";
            }
            else
            {

                string d1 = Year.ToString();
                string d2 = Month.ToString();

                searchStatistic = "SELECT * FROM lamp WHERE Year(changeDate) = '" + d1 + "' AND Month(changeDate) = '" + d2 + "'";

            }
            _manager.openConnection();
            MySqlCommand read = new MySqlCommand(searchStatistic, _manager.getConnection());
            MySqlDataReader reader;
            reader = read.ExecuteReader();

            bool a = reader.HasRows;
            if (a)
            {

                reader.Read();

                do
                {
                    CountStatistic(reader.GetString(8));
                }
                while (reader.Read());

                reader.Close();
                _manager.closeConnection();
            }
            else
            {
                MessageBox.Show("Записів не знайдено ");
                reader.Close();
                _manager.closeConnection();

            }


            int all = we + f + w;

            if (Convert.ToInt32(comboBox3.Text) == 0)
            {
                listBox2.Items.Add("Всього за " + Year + " рік замінено " + all + " ламп вуличного освітлення.");
                listBox2.Items.Add(new string('-', 85));
                listBox2.Items.Add("В тому числі : 1) по гарантії - " + w + " шт.");
                listBox2.Items.Add("                       2) гарантія закінчилась у - " + we + " шт.");
                listBox2.Items.Add("                       3) замінено вперше - " + f + " шт.");
                listBox2.Items.Add(" ");
                listBox2.Items.Add(" ");
            }
            else
            {
                listBox2.Items.Add("Всього за " + Month + "-й місяць " + Year +
                                        " року замінено " + all + " ламп.");
                listBox2.Items.Add(new string('-', 85));
                listBox2.Items.Add("В тому числі : 1) по гарантії - " + w + " шт.");
                listBox2.Items.Add("                       2) гарантія закінчилась у - " + we + " шт.");
                listBox2.Items.Add("                       3) замінено вперше - " + f + " шт.");
                listBox2.Items.Add(" ");
                listBox2.Items.Add(" ");
            }

        }
        private void CountStatistic(string k)
        {
            switch (k)
            {
                case "First":
                    f++;
                    break;
                case "Warranty":
                    w++;
                    break;
                case "WarrantyEnd":
                    we++;
                    break;
                default:
                    break;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        //Print
        private int Lines1 = 0;
        private string[] result1;
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.Text == null)
            {
                return;
            }
            string Year = textBox2.Text;
            string Month = comboBox3.Text;
            if (Convert.ToInt32(comboBox3.Text) == 0)
            {
                Month = " весь ";
            }
            int countLines1 = listBox2.Items.Count + 19;
            result1 = new string[countLines1];
            // задаємо текст для друку
            result1[Lines1] = "            Витяг з бази даних по заміні ламп вуличного освітлення ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = Year + " рік.";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "Бережницький старостинський округ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "Дата " + DateTime.Now.ToShortDateString() + " р.";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            foreach (var item in listBox2.Items)
            {
                result1[Lines1] = item.ToString();
                Lines1++;
            }
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "    Електрик _________________      підпис _____________";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "  ";
            Lines1++;
            result1[Lines1] = "    Староста _________________      підпис _____________";
            Lines1++;

            //объект для печати
            PrintDocument printDocument = new PrintDocument();

            //обработчик события печати
            printDocument.PrintPage += PrintPageHandler1;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем


        }

        int counter1 = 0;//лічильник строк друку
        int curPage1 = 1;// поточна сторінка
        // обробник події друку
        void PrintPageHandler1(object sender, PrintPageEventArgs e)
        {
            float leftMargin = e.MarginBounds.Left; // відступ зліва у документі
            float topMargin = e.MarginBounds.Top; // відступ зверху в документі
            float yPos = 0; // поточна позиція Y для виведення рядка

            int i = 0;// лічильник рядків на сторінці

            Font myFont = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Font myFont1 = new Font("Arial Italic", 20, FontStyle.Regular, GraphicsUnit.Pixel);

            int nLines = (int)((e.MarginBounds.Height - myFont1.GetHeight(e.Graphics)) / myFont.GetHeight(e.Graphics));
            int nPages = ((Lines1 - 1) / nLines) + 1;

            if (counter1 == 0)
            {
                yPos = topMargin;
                e.Graphics.DrawString(result1[0], myFont1, Brushes.Black, leftMargin, yPos, new StringFormat());
                counter1++;
            }

            while ((i < nLines) && (counter1 < Lines1))
            {

                yPos = topMargin + myFont1.GetHeight(e.Graphics) + i * myFont.GetHeight(e.Graphics);
                // друк рядка result
                e.Graphics.DrawString(result1[counter1], myFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                i++;
                counter1++;

            }
            // визначення чи потрібна ще одна сторінка
            e.HasMorePages = false;

            if (curPage1 < nPages)
            {
                // надання ще однієї сторінки
                e.HasMorePages = true;
                curPage1++;

            }
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumTurquoise;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
