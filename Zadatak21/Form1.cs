using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;
            int mjesec = datum.Month;
            int dan = datum.Day;
            string godisnjeDoba;

            if ((mjesec <= 3 && dan <= 21) || (mjesec ==12 && dan>=22))
            {
                godisnjeDoba = "Zima";
            }
            else if (mjesec <= 6 && dan <= 21)
            {
                godisnjeDoba = "Proljeće";
            }
            else if (mjesec <= 9 && dan <= 23)
            {
                godisnjeDoba = "Ljeto";
            }
            else
            {
                godisnjeDoba = "Jesen";
            }
            MessageBox.Show(godisnjeDoba);
        }
    }
}
