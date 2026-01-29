using System.ComponentModel;

namespace Konu13KapsullemeEncapsulation;

internal class Bolum
{
    private string BolumAdi; // dışardan erişime kapalı değişkenimiz.
    public string GetBolumAdi() // dışarıya string veri gönderen metot.
    {
        return BolumAdi; // GetBolumAdi çağrılınca BolumAdi değişken değerini yolla
    }
    public void SetBolumAdi(string istenenEgitim)
    {
        if (istenenEgitim == "Yazılım Eğitimi")
        {
            BolumAdi = istenenEgitim; // Mutator (setter) seçilen eğitime izin verildi. 
        }
        else
        {
            Console.WriteLine("Kurumumuzda bu eğitim verilmemektedir!");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konu13 Kapsulleme Encapsulation");
        Console.WriteLine("Metot ile Kapsülleme");
        Console.WriteLine("Hangi alanda eğitim almak istersiniz?");
        Bolum bolum = new Bolum(); // Bolum clasından bolum adında bir nesne üret
        var bolumAdi = Console.ReadLine(); // ekrandan girilecek değeri oku
        bolum.SetBolumAdi(bolumAdi); // girilen değeri bolum nesnesindeki set metoduna gönder.
        System.Console.WriteLine("Bölüm: " + bolum.GetBolumAdi()); // bolum nesnesindeki metotla private değişkenin değerini oku.

        Console.WriteLine();

        // property ile kapsülleme
        Console.WriteLine("Property ile Kapsülleme");
        Fakulte fakulteNesnesi = new Fakulte(); // burada nesneyi oluşturuyoruz.
        fakulteNesnesi.Bolum = bolumAdi; // veri atama: set bloğunu çalıştırır.
        Console.WriteLine("Fakülte Bölüm: " + fakulteNesnesi.Bolum); // veri okuma: get bloğunu çalıştırır.Yazılım
    }
}

public class Fakulte
{
    private string bolum;
    public string Bolum
    {
        get {return bolum;}
        set
        {
            if (value == "Yazılım Eğitimi") // eğer gönderilen değer yazılım eğitimi ise
            {
                bolum = value; // property e değer atamasına izin ver
            }
            else
            {
                Console.WriteLine("Kurumumuzda bu eğtim verilmemektedir");
            }
        }
    }
    
    
}
