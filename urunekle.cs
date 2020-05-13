using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class urunekle : Form
    {

        public urunekle()
        {
            InitializeComponent();

            cbkategori.Items.Add("Yiyecek");
            cbkategori.Items.Add("Aksesuar");
            cbkategori.Items.Add("Orgü");
            cbkategori.Items.Add("Davet");
            cbkategori.Items.Add("Diğer");
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void fotoekle_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = file.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            foreach (string s in file.FileNames)
                            {
                                fotoekle.ImageLocation = s;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Dosya okunamadı!" + ex.Message);
                }
            }
            file.ShowDialog();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Database.UrunEklemeDB urunDB = new Database.UrunEklemeDB();
            Tables.UrunEkleme urun = new Tables.UrunEkleme();

            try
            {
                urun.Urunadi = tburunadi.Text;
                urun.Kategoriadi = cbkategori.Text;
                urun.Açıklama = tbdetaybilgi.Text;
                urun.Fiyat = Convert.ToInt16(tbfiyat.Text);
                
                urunDB.Ekle(urun);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
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