using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak11a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> brojevi=new List<int>();
            string[] tekst = textBox1.Text.Split(',');
            int broj;
            for (int i = 0; i < tekst.Length; i++)
            {
                int.TryParse(tekst[i], out broj);
                brojevi.Add(broj);
                
            }
            brojevi.Sort();
            string ispis="";
            foreach (int broj2 in brojevi)
            {
                ispis += broj2.ToString()+",";

            }
            this.textBox1.Text = ispis;
        }
    }
}
