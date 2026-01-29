namespace Konu11Enumlar;

class Program
{
    // Enum(numaratör) nesneleri numaralandırmak için kullanılır.

    /*
    -Enum tipler üzerindeki kısıtlamalar
    1 - Enum bloğunda metot tanımlanamaz 
    2 - Arayüz (Interface) kullanamazlar.
    3 - Enum bloğunda property kullanılamaz.
    */

    enum Aylar : byte
    {
        Ocak = 1, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
    }
    enum SiparisDurumu
    {
        Hazırlanıyor, Hazırlandı, KargoBekleniyor, Kargolandı, İadeEdildi
    }

    enum Meyveler : int
    {
        Elma = 3, Armut = 7, Çilek = 1
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Konu11Enumlar");

        byte a = (byte)Meyveler.Armut;
        byte b = (byte)Meyveler.Elma;
        byte c = (byte)Meyveler.Çilek;
        Console.WriteLine($"{Meyveler.Armut} = {a}, {Meyveler.Elma} = {b}, {Meyveler.Çilek} = {c}");
        
        Ornek(SiparisDurum: 1);
        Ornek(2);
    }

    static void Ornek(int SiparisDurum)
    {
        if (SiparisDurum == (int)SiparisDurumu.Hazırlanıyor)
        {
            Console.WriteLine("Sipraşiniz Hazırlanıyor");
        }
        if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
        {
            Console.WriteLine("Siparişiniz Hazırlandı");
        }
        if (SiparisDurum == (int)SiparisDurumu.KargoBekleniyor)
        {
            Console.WriteLine("Siparişiniz Hazırlandı, Kargo Bekleniyor");
        }
        if (SiparisDurum == (int)SiparisDurumu.Kargolandı)
        {
            Console.WriteLine("Siparişiniz Kargoya Verildi");
        }
        if (SiparisDurum == (int)SiparisDurumu.İadeEdildi)
        {
            Console.WriteLine("Sipariş İade Edildi");
        }
    }
}
