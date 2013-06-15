using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int interval1 = int.Parse(textBox1.Text);
            int interval2 = int.Parse(textBox2.Text);
            int interval3 = int.Parse(textBox3.Text);
            int interval4 = int.Parse(textBox4.Text);

            List<int> niz1 = new List<int>();
            List<int> niz2 = new List<int>();

            for (int i =interval1; i <= interval2; i++)
            {
                niz1.Add(i);
            }
            for (int i = interval3; i <= interval4; i++)
            {
                niz2.Add(i);
            }

            IEnumerable<int> novi = niz1.Intersect(niz2);
            string rezultat="";

            foreach(int broj in novi)
            {
                rezultat+=broj.ToString()+", ";
            }
            MessageBox.Show(rezultat);
        }
    }
}
