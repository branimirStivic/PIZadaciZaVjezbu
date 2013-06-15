using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            string textA = txtA.Text;

            string textB = txtB.Text;
            string textC = txtC.Text;
            

            if (textC.Contains(textA))
            {
                txtC.Text = txtC.Text.Replace(textA, textB);
            }
            txtC.Select(txtC.Text.Length, 0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
