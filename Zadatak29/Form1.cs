using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<int> brojevi = new List<int>();
            int random = 0;
            for (int i = 0; i <8; i++)
            {
                do
                {
                    random = r.Next(1, 39);
                }
                while (brojevi.Contains(random)); 
                brojevi.Add(random);
            }

            label1.Text = brojevi[0].ToString();
            label2.Text = brojevi[1].ToString();
            label3.Text = brojevi[2].ToString();
            label4.Text = brojevi[3].ToString();
            label5.Text = brojevi[4].ToString();
            label6.Text = brojevi[5].ToString();
            label7.Text = brojevi[6].ToString();

        }
    }
}
