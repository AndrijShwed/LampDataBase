﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LampDataBase
{
    public partial class Головна : Form
    {
        public Головна()
        {
            InitializeComponent();
        }

       
        private void Заміна_ламп_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.Show();
        }

        private void Інформація_пошук_Click(object sender, EventArgs e)
        {

            Інформація інформ = new Інформація();

            інформ.Show();
        }
    }
}
