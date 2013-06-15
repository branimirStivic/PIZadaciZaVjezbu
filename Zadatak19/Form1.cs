using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float brojJedan = 0;
            float brojDva = 0;
            if (float.TryParse(textBox1.Text, out brojJedan) && float.TryParse(textBox2.Text, out brojDva) && brojDva>0)
            {
                double produkt=brojJedan/brojDva;
                textBox3.Text=produkt.ToString();  
               
            }
            else
            {
                MessageBox.Show("Unesite brojeve molim lijepo! *ako nije problem");
            }
            

        }
    }
}
