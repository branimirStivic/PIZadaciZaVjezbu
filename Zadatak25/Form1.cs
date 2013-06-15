using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak25
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] niz1 = textBox1.Text.Split(',');
            string[] niz2 = textBox2.Text.Split(',');
            string niz3="";
            foreach (string element in niz1)
            {
                if (niz2.Contains(element))
                {
                    niz3+=element+", ";
                }

            }
            textBox3.Text = niz3;
        }
    }
}
