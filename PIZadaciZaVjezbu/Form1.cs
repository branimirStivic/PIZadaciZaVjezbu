using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZadaciZaVjezbu
{
    public partial class frmGlavnaForma : Form
    {
        private static int brojKlikova=0;

        public frmGlavnaForma()
        {
             InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBrojFormi_Click(object sender, EventArgs e)
        {
            
            int.TryParse(btnBrojFormi.Text, out brojKlikova);
            brojKlikova++;
            btnBrojFormi.Text = brojKlikova.ToString();

            frmGlavnaForma novaForma = new frmGlavnaForma();
            novaForma.Show();

            foreach (frmGlavnaForma Forma in Application.OpenForms)
            {
                Forma.btnBrojFormi.Text = brojKlikova.ToString();
            }

        }
    }
}
