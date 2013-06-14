using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak02
{
    public partial class Form1 : Form
    {
        private static int xKlikova = 0, brojKlikova = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrojKlikova_Click(object sender, EventArgs e)
        {
            int.TryParse(this.txtBrojKlikova.Text, out xKlikova);
            brojKlikova++;

            if (brojKlikova >= xKlikova)
            {
                brojKlikova = 0;
                xKlikova = 0;
                this.txtBrojKlikova.Text = xKlikova.ToString();
            }

            this.btnBrojKlikova.Text = brojKlikova.ToString();
        }
    }
}
