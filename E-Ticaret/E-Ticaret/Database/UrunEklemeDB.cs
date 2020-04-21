using E_Ticaret.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Database
{
    class UrunEklemeDB : Veritabani
    {
        public override void Ekle(IArayuz arayuz)
        {
            UrunEkleme ue = (UrunEkleme)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_UrunEKLE", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@UrunAdi", ue.Urunadi);
            komut.Parameters.AddWithValue("@KategoriAdi", ue.Kategoriadi);
            komut.Parameters.AddWithValue("@Aciklama", ue.Açıklama);
            komut.Parameters.AddWithValue("@Fiyat", ue.Fiyat);
            

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

      
    }
}
