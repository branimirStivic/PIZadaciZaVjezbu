using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak27
{
    public partial class Form1 : Form
    {
        public int sekundi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sekundi = int.Parse(textBox1.Text);
            timer1.Start();
            timer1.Interval = 1000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.sekundi != 0)
            {
                sekundi--;
                this.button1.Text = sekundi.ToString();

            }
            else
            {
                this.Close();
            }

        }
    }
}
