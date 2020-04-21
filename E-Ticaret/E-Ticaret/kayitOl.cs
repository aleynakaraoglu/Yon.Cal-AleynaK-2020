using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class kayitOl : Form
    {

        giris girisfrm = new giris();
        public kayitOl()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void giris_Click(object sender, EventArgs e)
        {
            girisfrm.Show();
            this.Hide();

        }

       

        private void kayitOl_Load(object sender, EventArgs e)
        {
           //con = new SqlConnection("Initial Catalog=Proje;User ID=aleyna;Password=123123");
           //da = new SqlDataAdapter("Select *From tbl_kullanici", con);
           //ds = new DataSet();
           //con.Open();

        }
        private void kaydol_Click(object sender, EventArgs e)
        {
            Database.KullaniciKayitDB kayitDB = new Database.KullaniciKayitDB();
            Tables.KullaniciKayit kullanici = new Tables.KullaniciKayit();


            try
            {
                kullanici.Adi = tbisim.Text;
                kullanici.Soyadi = tbsoyisim.Text;
                kullanici.KullaniciAdi = tbkadi.Text;
                kullanici.Sifre = tbsifre.Text;
                kullanici.EPosta = tbeposta.Text;
                kullanici.Adres = tbadres.Text;
                kullanici.KayıtTarihi = dateTimePicker1.Value;

                if (satici.Checked)
                {
                    kullanici.UrunEklemeYetkisi = '1';
                }
                else
                {
                    kullanici.UrunEklemeYetkisi = '0';

                }

                kayitDB.Ekle(kullanici);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
