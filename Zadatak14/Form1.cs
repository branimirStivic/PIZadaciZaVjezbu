using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datum = new DateTime();
            string text=textBox1.Text;
            int brojPetaka=0;
            string datumString="";
            for (int i = 1; i < 13; i++)
            {
                datumString=text+"/"+i.ToString()+"/13";
                datum = Convert.ToDateTime(datumString);
                if (datum.DayOfWeek  ==DayOfWeek.Friday)
                {
                    brojPetaka++;
                }
             
            }

            MessageBox.Show(brojPetaka.ToString());
        }
    }
}
