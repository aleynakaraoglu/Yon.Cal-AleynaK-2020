﻿using System;
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
    public partial class profilS : Form
    {
        public profilS()
        {
            InitializeComponent();
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
            this.Hide();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            urunekle urunekle = new urunekle();
            urunekle.Show();
            this.Hide();
        }

        private void btnsmesaj_Click(object sender, EventArgs e)
        {
            mesajlarS mesajlarS = new mesajlarS();
            mesajlarS.Show();
            this.Hide();
        }
    }
}
