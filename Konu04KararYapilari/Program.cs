namespace Konu04KararYapilari;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konu 04 Karar Yapıları!");
        /*
        Console.WriteLine("Bir sayı giriniz:");
        var sayi = Convert.ToDecimal(Console.ReadLine());
        // if yapısı
        if (sayi > 0) // eğer sayı 0 dan büyükse
        {
            Console.WriteLine("Girdiğiniz sayı pozitiftir.");
        }
        else if (sayi < 0) // yukarda ki şart değilse ve sayı 0 dan küçükse 
        {
            Console.WriteLine("Girdiğiniz sayı negatiftir.");
        }
        else // hiç biri değilse
        {
            Console.WriteLine("Girdiğiniz sayı sıfıra eşittir.");
        }
        

        Console.WriteLine("Kullanıcı Adınız:");
        var kullanaciAdi = Console.ReadLine();
        Console.WriteLine("Parolanız:");
        var sifre = Console.ReadLine();

        if (kullanaciAdi == "admin" && sifre == "12345") // eğer kullanıcı adı admin ve parola 12345 ise
        {
            Console.WriteLine("Giriş Başarılı! Hoşgeldiniz " + kullanaciAdi);
        }
        else
        {
            Console.WriteLine("Kullanıcı Adı veya Parola Hatalı!");
        }
        */
        
        int saat = DateTime.Now.Hour; // şimdiki saati alır
        if (saat < 18)
        {
            Console.WriteLine("İyi Günler!, saat: " + saat);
        }
        else
        {
            Console.WriteLine("İyi Akşamlar, saat: " + saat);
        }

        Console.WriteLine("switch case yapısı ile akış kontrolü:");
        int ay = DateTime.Now.Month; // şimdiki ayı alır
        Console.WriteLine("Bulunduğumuz ay: " + ay);
        switch (ay)
        {
            case 12: 
            case 1:
            case 2:
                Console.WriteLine("Kış Mevsimindeyiz.");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar Mevsimindeyiz.");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz Mevsimindeyiz.");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar Mevsimindeyiz.");
                break;
            default:
                Console.WriteLine("Böyle bir ay yok.");
                break;  
            }
    }
}
