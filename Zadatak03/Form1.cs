using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak03
{
   
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUhvati_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUhvati_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            int xPozicija, yPozicija;
            xPozicija = rand.Next(200);
            yPozicija = rand.Next(200);
            //MessageBox.Show(xPozicija.ToString());
           
            this.btnUhvati.Location = new Point(xPozicija, yPozicija);
        }
    }
}
