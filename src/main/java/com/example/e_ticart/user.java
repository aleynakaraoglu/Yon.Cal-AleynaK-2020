package com.example.e_ticart;

public class user {

    public String isim;
    public String soyisim;
    public String kullaniciAdi;
    public String sifre;
    public String eposta;
    public String adres;


    public user(){

    }
    public user(String Isim, String Soyisim, String KullaniciAdi ,String Sifre ,String Eposta ,String Adres){
        this.isim = Isim;
        this.soyisim = Soyisim;
        this.kullaniciAdi = KullaniciAdi;
        this.sifre = Sifre;
        this.eposta = Eposta;
        this.adres = Adres;

    }


}
