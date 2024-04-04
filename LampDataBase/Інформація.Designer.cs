namespace LampDataBase
{
    partial class Інформація
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
            menuStrip1 = new MenuStrip();
            головнаToolStripMenuItem = new ToolStripMenuItem();
            інформаціяToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            Очистити_поля_пошуку = new RJButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Виберіть_місяць = new ComboBox();
            Пошук = new Button();
            Виберіть_рік = new ComboBox();
            Вулиця = new ComboBox();
            Населений_пункт = new ComboBox();
            dataGridViewВікноПошуку = new DataGridView();
            label1 = new Label();
            Count = new TextBox();
            Очистити_таблицю = new RJButton();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewВікноПошуку).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { головнаToolStripMenuItem, інформаціяToolStripMenuItem, вихідToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1473, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // головнаToolStripMenuItem
            // 
            головнаToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            головнаToolStripMenuItem.Name = "головнаToolStripMenuItem";
            головнаToolStripMenuItem.Size = new Size(116, 32);
            головнаToolStripMenuItem.Text = "Головна /";
            головнаToolStripMenuItem.Click += головнаToolStripMenuItem_Click;
            // 
            // інформаціяToolStripMenuItem
            // 
            інформаціяToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            інформаціяToolStripMenuItem.Size = new Size(150, 32);
            інформаціяToolStripMenuItem.Text = "Інформація /";
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            вихідToolStripMenuItem.ForeColor = Color.Red;
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(77, 32);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Очистити_поля_пошуку);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Виберіть_місяць);
            groupBox1.Controls.Add(Пошук);
            groupBox1.Controls.Add(Виберіть_рік);
            groupBox1.Controls.Add(Вулиця);
            groupBox1.Controls.Add(Населений_пункт);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(18, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1396, 122);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пораметри пошуку";
            // 
            // Очистити_поля_пошуку
            // 
            Очистити_поля_пошуку.BackColor = Color.OrangeRed;
            Очистити_поля_пошуку.FlatAppearance.BorderSize = 0;
            Очистити_поля_пошуку.FlatStyle = FlatStyle.Flat;
            Очистити_поля_пошуку.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Очистити_поля_пошуку.ForeColor = Color.White;
            Очистити_поля_пошуку.Location = new Point(1132, 60);
            Очистити_поля_пошуку.Name = "Очистити_поля_пошуку";
            Очистити_поля_пошуку.Size = new Size(258, 40);
            Очистити_поля_пошуку.TabIndex = 11;
            Очистити_поля_пошуку.Text = "Очистити поля пошуку";
            Очистити_поля_пошуку.UseVisualStyleBackColor = false;
            Очистити_поля_пошуку.Click += Очистити_поля_пошуку_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(808, 33);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 10;
            label5.Text = "Виберіть місяць";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(646, 33);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 9;
            label4.Text = "Виберіть рік";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(386, 34);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 8;
            label3.Text = "Виберіть вулицю";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 34);
            label2.Name = "label2";
            label2.Size = new Size(262, 28);
            label2.TabIndex = 7;
            label2.Text = "Виберіть населений пункт";
            // 
            // Виберіть_місяць
            // 
            Виберіть_місяць.DropDownStyle = ComboBoxStyle.DropDownList;
            Виберіть_місяць.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Виберіть_місяць.FormattingEnabled = true;
            Виберіть_місяць.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            Виберіть_місяць.Location = new Point(808, 64);
            Виберіть_місяць.Name = "Виберіть_місяць";
            Виберіть_місяць.Size = new Size(179, 36);
            Виберіть_місяць.TabIndex = 6;
            // 
            // Пошук
            // 
            Пошук.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Пошук.ForeColor = Color.Black;
            Пошук.Location = new Point(993, 64);
            Пошук.Name = "Пошук";
            Пошук.Size = new Size(133, 36);
            Пошук.TabIndex = 4;
            Пошук.Text = "Пошук";
            Пошук.UseVisualStyleBackColor = true;
            Пошук.MouseClick += Пошук_MouseClick;
            Пошук.MouseLeave += Пошук_MouseLeave;
            Пошук.MouseHover += Пошук_MouseHover;
            // 
            // Виберіть_рік
            // 
            Виберіть_рік.DropDownStyle = ComboBoxStyle.DropDownList;
            Виберіть_рік.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Виберіть_рік.FormattingEnabled = true;
            Виберіть_рік.Items.AddRange(new object[] { "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            Виберіть_рік.Location = new Point(623, 64);
            Виберіть_рік.Name = "Виберіть_рік";
            Виберіть_рік.Size = new Size(179, 36);
            Виберіть_рік.TabIndex = 5;
            // 
            // Вулиця
            // 
            Вулиця.DropDownStyle = ComboBoxStyle.DropDownList;
            Вулиця.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Вулиця.FormattingEnabled = true;
            Вулиця.Location = new Point(337, 64);
            Вулиця.Name = "Вулиця";
            Вулиця.Size = new Size(280, 36);
            Вулиця.TabIndex = 1;
            // 
            // Населений_пункт
            // 
            Населений_пункт.DropDownStyle = ComboBoxStyle.DropDownList;
            Населений_пункт.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Населений_пункт.FormattingEnabled = true;
            Населений_пункт.Location = new Point(6, 65);
            Населений_пункт.Name = "Населений_пункт";
            Населений_пункт.Size = new Size(325, 36);
            Населений_пункт.TabIndex = 0;
            Населений_пункт.SelectedIndexChanged += Населений_пункт_SelectedIndexChanged_1;
            // 
            // dataGridViewВікноПошуку
            // 
            dataGridViewВікноПошуку.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewВікноПошуку.Location = new Point(12, 232);
            dataGridViewВікноПошуку.Name = "dataGridViewВікноПошуку";
            dataGridViewВікноПошуку.RowHeadersWidth = 51;
            dataGridViewВікноПошуку.RowTemplate.Height = 29;
            dataGridViewВікноПошуку.Size = new Size(1449, 429);
            dataGridViewВікноПошуку.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 192);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 3;
            label1.Text = "Всього записів : ";
            // 
            // Count
            // 
            Count.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Count.Location = new Point(189, 192);
            Count.Name = "Count";
            Count.Size = new Size(88, 34);
            Count.TabIndex = 4;
            Count.TextAlign = HorizontalAlignment.Center;
            // 
            // Очистити_таблицю
            // 
            Очистити_таблицю.BackColor = Color.Crimson;
            Очистити_таблицю.FlatAppearance.BorderSize = 0;
            Очистити_таблицю.FlatStyle = FlatStyle.Flat;
            Очистити_таблицю.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Очистити_таблицю.ForeColor = Color.White;
            Очистити_таблицю.Location = new Point(577, 178);
            Очистити_таблицю.Name = "Очистити_таблицю";
            Очистити_таблицю.Size = new Size(321, 50);
            Очистити_таблицю.TabIndex = 5;
            Очистити_таблицю.Text = "Очиистити таблицю";
            Очистити_таблицю.UseVisualStyleBackColor = false;
            Очистити_таблицю.Click += Очистити_таблицю_Click;
            // 
            // Інформація
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1473, 673);
            Controls.Add(Очистити_таблицю);
            Controls.Add(Count);
            Controls.Add(label1);
            Controls.Add(dataGridViewВікноПошуку);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Інформація";
            Text = "Інформація";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewВікноПошуку).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem головнаToolStripMenuItem;
        private ToolStripMenuItem інформаціяToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox Вулиця;
        private ComboBox Населений_пункт;
        private Button Пошук;
        private DataGridView dataGridViewВікноПошуку;
        private Label label1;
        private TextBox Count;
        private ComboBox Виберіть_рік;
        private ComboBox Виберіть_місяць;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RJButton Очистити_поля_пошуку;
        private RJButton Очистити_таблицю;
    }
}