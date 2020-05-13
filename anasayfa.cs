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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        //public void VeriGetir()
        //{
        //        SqlConnection con;
        //        SqlCommand cmd;
        //        SqlDataReader dr;
        //        con = new SqlConnection(@"Data Source=LAPTOP-D2QGEVCK\SQLEXPRESS;Initial Catalog=E-Ticaret;Integrated Security=True;User ID=aleyna;Password=123123");
        //        cmd = new SqlCommand();
        //        con.Open();
        //        cmd.Connection = con;
        //        cmd.CommandText ="select * from tbl_urun  ";
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            urun_adi.text = dr[0];
        //        }
        //        con.Close();
        //}
        private void anasayfa_Load(object sender, EventArgs e)
        {
           // VeriGetir();
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            kategoriler kategoriler = new kategoriler();
            kategoriler.Show();
            this.Hide();
        }

        private void btnmesaj_Click(object sender, EventArgs e)
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

