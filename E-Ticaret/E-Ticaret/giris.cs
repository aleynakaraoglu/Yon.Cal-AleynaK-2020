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
    public partial class giris : Form
    { 
        private void giris_Load(object sender, EventArgs e)
        {

        }
        public giris()
        {
            InitializeComponent();
        }

        private void tbgiris_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;

            string user = tbkadi.Text;
            string pass = tbsifre.Text;
            con = new SqlConnection(@"Data Source=LAPTOP-D2QGEVCK\SQLEXPRESS;Initial Catalog=E-Ticaret;Integrated Security=True;User ID=aleyna;Password=123123");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_kullanici where KullaniciAdi='" + tbkadi.Text + "' AND Sifre='" + tbsifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
            }
            else
            {
                MessageBox.Show("Giriş hatalı");
            }
            con.Close();


        }
    }
}
