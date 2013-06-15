using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime sada = DateTime.Now;
            int brojDana = 0;

            do
            {
                sada=sada.AddDays(1);
                brojDana++;

            } while (sada.DayOfWeek != DayOfWeek.Friday);

                label1.Text = (brojDana.ToString());
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
