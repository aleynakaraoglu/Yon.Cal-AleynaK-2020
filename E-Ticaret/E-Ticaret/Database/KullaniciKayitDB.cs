using E_Ticaret.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Database
{
    class KullaniciKayitDB : Veritabani
    {
        public override void Ekle(IArayuz arayuz)
        {
            KullaniciKayit kk = (KullaniciKayit)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_KullaniciEKLE", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Adi", kk.Adi);
            komut.Parameters.AddWithValue("@Soyadi", kk.Soyadi);
            komut.Parameters.AddWithValue("@KullaniciAdi", kk.KullaniciAdi);
            komut.Parameters.AddWithValue("@Sifre", kk.Sifre);
            komut.Parameters.AddWithValue("@Eposta", kk.Eposta);
            komut.Parameters.AddWithValue("@Adres", kk.Adres);
            komut.Parameters.AddWithValue("@UrunEklemeYetkisi", kk.UrunEklemeYetkisi);
            komut.Parameters.AddWithValue("@KayıtTarihi", kk.KayıtTarihi);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
