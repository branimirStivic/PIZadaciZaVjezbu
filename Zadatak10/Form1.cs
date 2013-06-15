using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak10
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

        private void button1_Click(object sender, EventArgs e)
        {
            string lozinka1 = textBox1.Text;
            string lozinka2 = textBox2.Text;

            int jednake = String.Compare(lozinka1, lozinka2);
            int duzina = lozinka1.Length;

            char []znakovi = { '#',  '$', '%' };
            int sadrziZnakova=0;
            int brojVelikihSlova = 0;
           
            for (int i = 0; i < lozinka1.Length; i++) 
            {
                
                if (char.IsUpper(lozinka1[i]))
                {
                    brojVelikihSlova++;
                }
                if (znakovi.Contains(lozinka1[i]))
                {
                    sadrziZnakova++;
                }
            }
           


            if (jednake == 0 && duzina>5 && brojVelikihSlova>2 && sadrziZnakova>0)  
            {
                this.BackColor = Color.LimeGreen;
            }
            else
            {
                this.BackColor = Color.OrangeRed;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
