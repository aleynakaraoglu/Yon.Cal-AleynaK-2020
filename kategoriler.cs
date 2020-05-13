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
    public partial class kategoriler : Form
    {
        public kategoriler()
        {
            InitializeComponent();
        }



        private void btnanasayfa_Click_1(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnmesaj_Click_1(object sender, EventArgs e)
        {
            mesajlar mesajlar = new mesajlar();
            mesajlar.Show();
            this.Hide();
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.Show();
            this.Hide();
        }
    }

}
