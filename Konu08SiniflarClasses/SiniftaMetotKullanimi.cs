using System;

namespace Konu08SiniflarClasses;

public class SiniftaMetotKullanimi
{
    string kurucuMetot;
    public SiniftaMetotKullanimi() // ctor yazıp tab a kurucu method-constructer oluşturuyoruz.
    {
        Console.WriteLine();
        kurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturduğunda otomatik olarak ve içerdiği kodları çalıştırır.";
        Console.WriteLine(kurucuMetot);
    }
    public bool LoginKontrol(string kullaniciAdi, string sifre)
    {
        if (kullaniciAdi == "admin" && sifre == "123")
        {
            return true;
        }
        return false;
    }
    public int ToplamaYap(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }


}
