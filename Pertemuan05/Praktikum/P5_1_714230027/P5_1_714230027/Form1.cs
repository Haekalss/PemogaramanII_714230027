﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_714230027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Outputlabel.Text = ("Hello world");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void el1_Click_Click(object sender, EventArgs e)
        {
            Outputlabel.Text = ("Hello world");
        }
    }
}
