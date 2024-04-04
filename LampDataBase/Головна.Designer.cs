namespace LampDataBase
{
    partial class Головна
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Головна));
            Заміна_ламп = new RJButton();
            Інформація_пошук = new RJButton();
            SuspendLayout();
            // 
            // Заміна_ламп
            // 
            Заміна_ламп.BackColor = Color.LightCoral;
            Заміна_ламп.FlatAppearance.BorderSize = 0;
            Заміна_ламп.FlatStyle = FlatStyle.Flat;
            Заміна_ламп.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Заміна_ламп.ForeColor = Color.Black;
            Заміна_ламп.Location = new Point(69, 9);
            Заміна_ламп.Name = "Заміна_ламп";
            Заміна_ламп.Size = new Size(457, 69);
            Заміна_ламп.TabIndex = 2;
            Заміна_ламп.Text = "Перейти до заміни ламп";
            Заміна_ламп.UseVisualStyleBackColor = false;
            Заміна_ламп.Click += Заміна_ламп_Click;
            // 
            // Інформація_пошук
            // 
            Інформація_пошук.BackColor = Color.LightCoral;
            Інформація_пошук.FlatAppearance.BorderSize = 0;
            Інформація_пошук.FlatStyle = FlatStyle.Flat;
            Інформація_пошук.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Інформація_пошук.ForeColor = Color.Black;
            Інформація_пошук.Location = new Point(749, 7);
            Інформація_пошук.Name = "Інформація_пошук";
            Інформація_пошук.Size = new Size(385, 71);
            Інформація_пошук.TabIndex = 3;
            Інформація_пошук.Text = "Інформація, пошук";
            Інформація_пошук.UseVisualStyleBackColor = false;
            Інформація_пошук.Click += Інформація_пошук_Click;
            // 
            // Головна
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1222, 406);
            Controls.Add(Інформація_пошук);
            Controls.Add(Заміна_ламп);
            Name = "Головна";
            Text = "Головна";
            ResumeLayout(false);
        }

        #endregion
        private RJButton Заміна_ламп;
        private RJButton Інформація_пошук;
    }
}