using System.Text;

namespace Konu08SiniflarClasses // ";" yoksa {} ile yazalıyor. ve playe basınca çalışıyor.
{


    internal class Ev // Sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;
    }
        
        /*

            Erişim belirteçleri 4 ana sınıfa ayrılır:
            1. public: Her yerden erişilebilir. Erişim kısıtlaması yoktur.
            2. protected: Ait olduğu sınıftan ve türetilen sınıflardan erişilebilir.
            3. internal: Etkin projeye ait sınıflardan erişilebilir, onların dışında erişlemez.
            4. private: Sadece ait olduğu sınıf içinden erişilebilir.

        */
         

        public class deneme
        {
            public string UrunAdi = "public öğeye herkes ulaşabilir.";
            protected class test
            {
                string UrunAdi;
            }
        }    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08Sınıflar (Classes)!");
            #region Örnek1
            Ev ilkEv = new Ev(); //soyut bir yapı olan ev sınıfından somut bir nesne oluşturduk.
            ilkEv.sokakAdi = "Atatürk Caddesi";
            ilkEv.kapiNo = 10;

            Console.WriteLine("İlkEv Sokak Adı: " + ilkEv.sokakAdi);
            Console.WriteLine("İlkEv Kapı No: " + ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new(); //soyut bir yapı olan ev sınıfından somut bir nesne oluşturduk.
            yazlikEv.sokakAdi = "Deniz Sokak";
            yazlikEv.kapiNo = 18;

            Console.WriteLine("YazlıkEv Sokak Adı: " + yazlikEv.sokakAdi);
            Console.WriteLine("YazlıkEv Kapı No: " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new() // farklı bir yazım şekli, new den sonra ; yok, süslü parantez açıp kapatıyoruz.
            {
                kapiNo = 25,
                sokakAdi = "Köy Yolu"
            };

            Console.WriteLine("KöyEvi Sokak Adı: " + koyEvi.sokakAdi);
            Console.WriteLine("KöyEvi Kapı No: " + koyEvi.kapiNo);
            #endregion
            #region Örnek2
            Kullanici kullanici = new()
            {
                Adi = "Ahmet",
                Soyadi = "Yılmaz",
                KullaniciAdi = "ahmetyilmaz",
                Sifre = "12345",
                Id = 1
            };
            Console.WriteLine("Kullanıcı Adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            var sifre = Console.ReadLine();

            if (
                kullaniciAdi == kullanici.KullaniciAdi &&
                sifre == kullanici.Sifre
               )
            {
                Console.WriteLine("Giriş Başarılı! Hoşgeldiniz " + kullanici.Adi + " " + kullanici.Soyadi);
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı!");
            }
            
            #endregion

            #region Örnek3
            Araba araba = new()
            {
                Id = 1,
                Marka = "Toyota",
                KasaTipi = "Suv",
                Model = "Rav4",
                Renk = "Beyaz",
                ModelYili = 2025
            };

            Araba araba2 = new()
            {
                Id = 2,
                Marka = "Honda",
                KasaTipi = "Sedan",
                Model = "Civic",
                Renk = "Siyah",
                ModelYili = 2024
            };

            #endregion

            #region Örnek 4
            Kategori kategori = new()
            {
                Id = 3,
                KategoriAdi = "Elektronik"
            };
            Kategori kategori2 = new()
            {
                Id = 4,
                KategoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            {
                Id = 5,
                KategoriAdi = "Telefon"
            };
            Console.WriteLine($"Anasayfa Hakkımızda {kategori.KategoriAdi} {kategori2.KategoriAdi} {kategori3.KategoriAdi} İletişim");

            #endregion

            #region Örnek 5
            SiniftaMetotKullanimi metotKullanimi = new(); // SiniftaMetotKullanimi classından metotKullanimi adında bir nesne oluşturduk.
            var sonuc = metotKullanimi.LoginKontrol(kullaniciAdi, sifre); // metotKullanimi nesnesinin içindeki LoginKontrol metoduna istediği parametreleri vererek ordan dönecek bool değeri sonuc değişkenine atadık.
            if (sonuc == true) // eğer sonuc değişkenine gelen değer true ise;
            {
                Console.WriteLine("Giriş Başarılı");
                Console.WriteLine("Hoş Geldin Admin");
            }
            else // sonuc değişkenine gelen değer false ise;
            {
                Console.WriteLine("Giriş Başarısız");
            }

            var toplamasonucu = metotKullanimi.ToplamaYap(10, 8);
            Console.WriteLine("toplama sonucu: " + toplamasonucu);

            Console.WriteLine();

            Console.WriteLine("Statik Değişken: " + SiniftaMetotKullanimi.StatikDegisken); // StatikDegisken in değerine ulaşmak için direk sınıfadi.StatikDegisken adı şeklinde ulaşıyoruz.

            Console.WriteLine("Dinamik Değişken: " + metotKullanimi.DinamikDegisken);
            



            
            #endregion
        }

    }

    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string yakitTipi;
        internal string VitesTipi;
        internal string Renk;
        internal int ModelYili;
    }
}