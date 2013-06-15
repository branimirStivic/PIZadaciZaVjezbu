using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak33
{
    public partial class Form1 : Form
    {
        int r = 0, g = 0, b = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            r = trackBar1.Value;
            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
           g = trackBar2.Value;
            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            b = trackBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
