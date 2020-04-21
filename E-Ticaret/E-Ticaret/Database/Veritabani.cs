using E_Ticaret.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Database
{
    abstract class Veritabani
    {

        private string yol;
        public SqlConnection baglanti; // Bağlantı
        public DataTable tablo; // Tablo 
        public SqlDataAdapter adaptor; // 
        public SqlDataReader okuyucu;
        public SqlCommand komut;
        //  static string conString;
        DataTable tbl = new DataTable();
        public void Baglan()
        {
            baglanti = new SqlConnection(@"Data Source=LAPTOP-D2QGEVCK\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True;User ID=aleyna;Password=123123");

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        public abstract void Ekle(IArayuz arayuz);





    }
}
