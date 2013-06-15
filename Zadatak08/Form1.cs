using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak08
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

        private void btnGO_Click(object sender, EventArgs e)
        {
            string URL = txtURL.Text;
            webBrowser1.Navigate(URL);
                        
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // MessageBox.Show("uspjelo");
            this.txtURL.BackColor = Color.Lime;
        }
    }
}
