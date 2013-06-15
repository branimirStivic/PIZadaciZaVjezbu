using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;

            if (tekst.Contains("a"))
            {
                textBox1.Text = textBox1.Text.Replace("a", "b");
            }

            textBox1.Select(textBox1.Text.Length, 0);
        }
    }
}
