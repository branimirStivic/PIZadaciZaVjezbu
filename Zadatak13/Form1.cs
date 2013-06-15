using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            timer1.Start();
           // timer1.Interval = 100;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double utakmica =20*60*60+45*60;
            double sada=DateTime.Now.Hour*60*60+DateTime.Now.Minute*60+DateTime.Now.Second;
            double preostalo=utakmica-sada;
            label1.Text = preostalo.ToString();
        }
    }
}
