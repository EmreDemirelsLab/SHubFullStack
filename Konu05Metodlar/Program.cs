namespace Konu05Metodlar;

class Program
{
    static void ToplamaYap() // Void tek anlamına gelir, geriye değer döndürmez.
    {
        Console.WriteLine(10 + 8);
    }
    static void Main(string[] args)
    {
        ToplamaYap();
        Console.WriteLine("Konu 05 Metodlar!"); // Pyhtondaki def main() gibi düşünebiliriz.
        Console.WriteLine();
            
        Console.WriteLine();
        Console.WriteLine("Geriye Değer Döndüren Metot:");
        int sonuc = ToplamaYap(5, 7, 9); // Metot çağırma
        
        Console.WriteLine("Sayıların Toplamı: " + sonuc);
        Console.WriteLine();
        Console.WriteLine("Email Giriniz:");
        var email = Console.ReadLine();
        var mailGonderildimi = MailGonder(email);
        if (mailGonderildimi == true)
        {
            Console.WriteLine("Mail Gönderme Başarılı");
        }
        else
        {
            Console.WriteLine("Mail Gönderme Başarısız");
        }
    }

    static void ToplamaYap(int sayi1, int sayi2) // parametreli Metot tanımlama (
    {
        Console.WriteLine(sayi1 + sayi2);
    }
    static int ToplamaYap(int sayi1, int sayi2, int sayi3) // parametreli Metot tanımlama (int tek anlamına gelir.)
    {
        return sayi1 + sayi2 + sayi3;
    }

    static bool MailGonder(string mailAdresi)
    {
        if (!string.IsNullOrEmpty(mailAdresi))
        {
            // Mail gönderme işlemleri...
            return true; // Mail gönderme başarılı
        }
        return false; // Mail gönderme başarısız
        
    }
}
