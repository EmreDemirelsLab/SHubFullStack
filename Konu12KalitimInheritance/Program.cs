using System.ComponentModel.DataAnnotations;

namespace Konu12KalitimInheritance;

class Arac
{
    public int Id { get; set; }
    public string AracTuru;
    public string Marka {get; set; }
    public string Model { get; set; }
    public void KornaCal()
    {
        Console.WriteLine("Kornaya Basıldı!");
    }
}

class Otomobil : Arac // iki nokta üst üste dediğimizde araç sınıfındaki içerikler otomobil sııfında kullanılabilir.
{
    public string KasaTipi {get; set; }
    public string YakıtTuru { get; set; }
}

class Test : Otomobil
{
    public int MyProperty{get; set; }
}

class Tren : Arac
{
    public int VagonSayisi {get; set; }
}

class Otobus : Arac
{
    public int KoltukSayisi { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konu12KalitimInheritance");
        Arac arac = new Arac();
        arac.AracTuru = "Otomobil";
        arac.KornaCal();

        Otomobil otomobil = new Otomobil();
        otomobil.Id = 1;
        otomobil.AracTuru = "Otomobil"; // bu değişken arac sınıfından geliyor.
        otomobil.KornaCal();
        otomobil.Marka = "Togg";
        otomobil.Model = "T10x";
        Console.WriteLine("otomobil.AracTuru: " + otomobil.AracTuru);

        Kategori kategori = new()
        {
            Id = 1,
            Name = "Elektronik",
            UstMenudeGoster = true,
        };
        if (kategori.UstMenudeGoster == true)
        {
            Console.WriteLine("Kategori Adı: " + kategori.Name);
        }

        Console.WriteLine();
        Urun urun = new()
        {
            Id = 1,
            Name = "Klavye",
            Fiyat = 999,
            Kdv = 20
        };

        Console.WriteLine("Ürün Bilgileri: ");
        Console.WriteLine("Ürün Adı : " + urun.Name);
        Console.WriteLine("Ürün Fiyatı : " + urun.Fiyat );
        Console.WriteLine("Kdv : %" + urun.Kdv);
        decimal kdvOrani = 0.20m;
        decimal kdvTutari = urun.Fiyat * kdvOrani;
        decimal toplamFiyat = urun.Fiyat + kdvTutari;
        Console.WriteLine("Kdv Tutarı: " + kdvTutari + " TL ");
        Console.WriteLine("Toplam Tutar : " + toplamFiyat + "TL");

        Console.WriteLine();

        Cizici[] birCizici = new Cizici[4];
        birCizici[0] = new DogruCiz();
        birCizici [1] = new DaireCiz();
        birCizici[2] = new KareCiz();
        birCizici[3] = new Cizici();

        foreach (var item in birCizici)
        {
            item.Ciz();
        }


    }
}

// Polimorfizm - Çok Biçimlilik

public class Cizici
{
    public virtual void Ciz() // Virtual ile metodu ezilebilir - override hale getiriyoruz.
    {
        Console.WriteLine("Cizici");
    }

}

public class DogruCiz : Cizici
{
    public override void Ciz()
    {
        Console.WriteLine("Düz Çizgi");
    }
}

public class DaireCiz : Cizici
{
    public override void Ciz()
    {
        Console.WriteLine("Daire Çizgi");
    }
}

public class KareCiz : Cizici
{
    public override void Ciz()
    {
        Console.WriteLine("Kare Çizgi");
    }
}