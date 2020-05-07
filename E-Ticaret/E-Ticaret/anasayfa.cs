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

        public void VeriGetir()
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
                cmd.CommandText = ;
                dr = cmd.ExecuteReader();

        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
    }
}

