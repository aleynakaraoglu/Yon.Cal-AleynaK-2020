using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class siparisler : Form
    {
        
        public siparisler()
        {
            InitializeComponent();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            urunekle uruneklefrm = new urunekle();
            uruneklefrm.Show(); 
            this.Hide();
        }

        private void btnsmesaj_Click(object sender, EventArgs e)
        {
            mesajlarS mesajlarS = new mesajlarS();
            mesajlarS.Show();
            this.Hide();
        }

        private void btnsprofil_Click(object sender, EventArgs e)
        {
            profilS profilS = new profilS();
            profilS.Show();
            this.Hide();
        }
    }
}
