namespace Konu06Diziler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konyu 06 Diziler!");
        // Dizi Oluşturma
        int[] sayi ;
        int[] ogrenciler = new int[6]; // 6 elemanlı bir dizi oluşturuldu. ogrenciler ismindeki dizi int türünde 6 eleman alabilir.
        ogrenciler[0] = 101;
        ogrenciler[1] = 102;
        ogrenciler[2] = 103;
        ogrenciler[3] = 104;
        ogrenciler[4] = 105;
        ogrenciler[5] = 105; //dizi değerleri aynı olabilir.
        // dizideki değere ulaşma
        Console.WriteLine("1. Öğrenci Numarası: " + ogrenciler[0]);
        ogrenciler[5] = 110; // dizideki değeri değiştirme
        Console.WriteLine("6. Öğrenci Numarası: " + ogrenciler[5]);

        Console.WriteLine();

        string[] isimler = new string[5];
        isimler[0] = "Alp";
        isimler[1] = "Ali";
        isimler[2] = "Murat";
        isimler[3] = "Yılmaz";

        Console.WriteLine("isimler[2]: " + isimler[2]);

        Console.WriteLine();

        int[] ogrenciler2 = { 100, 200, 300, 400, 500 };

        Console.WriteLine("ogrenciler2[3]: " + ogrenciler2[3]);
        ogrenciler2[3] = 550;

        Console.WriteLine("ogrenciler2[3]: " + ogrenciler2[3]);

        Console.WriteLine();

        string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Beyaz Eşya", "Kitap" };

        Console.WriteLine("kategoriler 1: " + kategoriler[1]);
        kategoriler[1] = "Mutfak Eşyaları";

        Console.WriteLine("kategoriler 1: " + kategoriler[1]);

        Console.WriteLine();
        string[] urunler = { "Ürün 1", "Ürün 2", "Ürün 3" };
        Console.WriteLine("Ürün 1: " + urunler[0]);

        Console.Read();

        

        

    }
}
