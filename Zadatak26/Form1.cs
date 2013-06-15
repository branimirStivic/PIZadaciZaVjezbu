using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            int r=0,g=0,b=0;
            if(int.TryParse(textBox1.Text, out r) && 
               int.TryParse(textBox2.Text, out g) && 
               int.TryParse(textBox3.Text, out b) &&
               r>=0 && r<=255 && g>=0 && g<=255 && b>=0 && b<=255)
            {
                this.BackColor = Color.FromArgb(r,g,b);

            }
            else
            {
                MessageBox.Show("Niste unijeli dobre vrijednosti");
            }

        }
    }
}
