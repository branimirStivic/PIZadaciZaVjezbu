﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, EventArgs e)
        {
           

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int vrijednostX = MousePosition.X;
            int vrijednostY = MousePosition.Y;

            lblKoordinate.Text = ("x=" + vrijednostX + ",y=" + vrijednostY);
        }
    }
}
