﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak24
{
    public partial class Form1 : Form
    {
        private int brojKlikova=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brojKlikova++;
            if (brojKlikova % 10 != 0)
            {
                this.BackColor = Color.OrangeRed;
            }
            else
            {
                this.BackColor = Color.LimeGreen;
            }

        }
    }
}
