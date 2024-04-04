
namespace LampDataBase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            Заміна = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button4 = new Button();
            listBox2 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            label9 = new Label();
            Дата_Покупки = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 0;
            label1.Text = "Населений пункт";
            label1.UseCompatibleTextRendering = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 39);
            comboBox1.Margin = new Padding(6, 5, 6, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(371, 37);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(17, 76);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 29);
            label2.TabIndex = 2;
            label2.Text = "Назва вулиці";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 110);
            comboBox2.Margin = new Padding(6, 5, 6, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(371, 37);
            comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(15, 152);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(275, 29);
            label3.TabIndex = 4;
            label3.Text = "Введіть номер опори";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(15, 186);
            textBox1.Margin = new Padding(6, 5, 6, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 34);
            textBox1.TabIndex = 5;
            // 
            // Заміна
            // 
            Заміна.BackColor = Color.LightCoral;
            Заміна.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Заміна.Location = new Point(15, 471);
            Заміна.Margin = new Padding(6, 5, 6, 5);
            Заміна.Name = "Заміна";
            Заміна.Size = new Size(115, 42);
            Заміна.TabIndex = 6;
            Заміна.Text = "Заміна";
            Заміна.UseVisualStyleBackColor = false;
            Заміна.Click += Заміна_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(15, 225);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(438, 44);
            label5.TabIndex = 9;
            label5.Text = "Введіть термін гарантії (цифрою)";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.Location = new Point(15, 252);
            textBox3.Margin = new Padding(6, 5, 6, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 34);
            textBox3.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ImeMode = ImeMode.NoControl;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(643, 298);
            listBox1.Margin = new Padding(6, 5, 6, 5);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(992, 404);
            listBox1.TabIndex = 19;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.MediumTurquoise;
            button2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(1605, 3);
            button2.Name = "button2";
            button2.Size = new Size(53, 43);
            button2.TabIndex = 20;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += button2_MouseClick;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(15, 291);
            label6.Name = "label6";
            label6.Size = new Size(132, 29);
            label6.TabIndex = 21;
            label6.Text = "Виробник";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox4.Location = new Point(15, 323);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 34);
            textBox4.TabIndex = 22;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.Location = new Point(498, 660);
            button3.Name = "button3";
            button3.Size = new Size(124, 42);
            button3.TabIndex = 23;
            button3.Text = "Друк";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 47);
            label4.Name = "label4";
            label4.Size = new Size(99, 29);
            label4.TabIndex = 24;
            label4.Text = "Звіт за";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(753, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 34);
            textBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "0" });
            comboBox3.Location = new Point(871, 40);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 37);
            comboBox3.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(783, 9);
            label7.Name = "label7";
            label7.Size = new Size(50, 29);
            label7.TabIndex = 27;
            label7.Text = "Рік";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(884, 8);
            label8.Name = "label8";
            label8.Size = new Size(95, 29);
            label8.TabIndex = 28;
            label8.Text = "Місяць";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.Location = new Point(1336, 33);
            button4.Name = "button4";
            button4.Size = new Size(103, 47);
            button4.TabIndex = 29;
            button4.Text = "Друк";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 29;
            listBox2.Location = new Point(643, 110);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(992, 149);
            listBox2.TabIndex = 30;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 255);
            button5.Location = new Point(1011, 37);
            button5.Name = "button5";
            button5.Size = new Size(148, 41);
            button5.TabIndex = 31;
            button5.Text = "Виконати";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Location = new Point(1174, 38);
            button6.Name = "button6";
            button6.Size = new Size(141, 40);
            button6.TabIndex = 32;
            button6.Text = "Очистити";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 370);
            label9.Name = "label9";
            label9.Size = new Size(287, 29);
            label9.TabIndex = 33;
            label9.Text = "Виберіть дату покупки";
            // 
            // Дата_Покупки
            // 
            Дата_Покупки.Location = new Point(15, 420);
            Дата_Покупки.Name = "Дата_Покупки";
            Дата_Покупки.Size = new Size(315, 34);
            Дата_Покупки.TabIndex = 34;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1555, 3);
            button1.Name = "button1";
            button1.Size = new Size(53, 43);
            button1.TabIndex = 35;
            button1.Text = "_";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += button1_MouseClick;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1660, 749);
            Controls.Add(button1);
            Controls.Add(Дата_Покупки);
            Controls.Add(label9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(Заміна);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MinimumSize = new Size(1112, 486);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox1;
        private Button Заміна;
        private Label label5;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button button2;
        private Label label6;
        private TextBox textBox4;
        private Button button3;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Label label7;
        private Label label8;
        private Button button4;
        private ListBox listBox2;
        private Button button5;
        private Button button6;
        private Label label9;
        private DateTimePicker Дата_Покупки;
        private Button button1;
    }
}

