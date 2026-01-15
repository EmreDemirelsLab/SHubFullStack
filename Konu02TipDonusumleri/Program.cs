namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konu 02 Tip Donusumleri!");
        // Implicit Casting - Otomatik Dönüşüm
        // Explicit Casting - Manuel dönüşüm
        Console.WriteLine("Implicit Casting - Otomatik Dönüşüm");
        Console. WriteLine("Implicit Casting de daha küçük boyutlu bir türü daha büyük boyutlu bir türe otomatik olarak dönüştürülmesidir.");
        int sayi =18;
        double kesirliSayi = sayi; // int türündeki değeri double taşıyabilir.
        Console.WriteLine("int türündeki sayi değişkeninin değeri:");
        Console.WriteLine(sayi);   
        Console.WriteLine("kesirliSayi değeri:");
        Console.WriteLine(kesirliSayi);

        Console.WriteLine();
        Console.WriteLine("Explicit Casting - Manuel Dönüşüm");
        double kesirliSayi2 = 18;
        int tamsayi = (int)kesirliSayi2;
        Console.WriteLine("kesirliSayi2:");
        Console.WriteLine(kesirliSayi2);
        Console.WriteLine("tamsayi:");
        Console.WriteLine(tamsayi);
        Console.WriteLine();


        Console.WriteLine("Diğer Tür Dönüştürme Yöntemleri");
        int tamsayi2 = 10;
        double kesirliSayi3 = 5.25;
        bool islemSonucu = true;    

        Console.WriteLine("Lütfen bir sayı giriniz:");
        var girilenDeger = Console.ReadLine();
        Console.WriteLine("Girilen Değerin Veri Tipi:");
        Console.WriteLine(girilenDeger.GetType());


        //PARSE
        var parsayi = int.Parse(girilenDeger); // string türündeki değeri tırnakları kaldırarak int türüne dönüştürür.

        Console.WriteLine(parsayi + tamsayi);
        Console.WriteLine(double.Parse(girilenDeger) + kesirliSayi3); // string türündeki değeri tırnakları kaldırarak double türüne dönüştürür.
        Console.WriteLine(decimal.Parse(girilenDeger) + tamsayi2); // string türündeki değeri tırnakları kaldırarak decimal türüne dönüştürür.
        Console.WriteLine();

        //CONVERT
        Console.WriteLine("Convert Sınıfı ile Dönüştürme");
        Console.WriteLine(tamsayi2.GetType());
        Console.WriteLine(Convert.ToString(tamsayi2).GetType()); // int türündeki değeri string türüne dönüştürür.
        Console.WriteLine(Convert.ToDouble(tamsayi2).GetType()); // int türündeki değeri double türüne dönüştürür.
        Console.WriteLine(Convert.ToInt32(kesirliSayi3).GetType()); // double türündeki değeri int türüne dönüştürür.
        Console.WriteLine(Convert.ToString(islemSonucu).GetType()); // bool türündeki değeri string türüne dönüştürür.


        Console.WriteLine();
        
        object nesne = "123456";
        Console.WriteLine("Nesne nin veri tipi: " + nesne.GetType() );
        nesne = Convert.ToDecimal(nesne); // object türündeki değeri decimal türüne dönüştürür.
        Console.WriteLine("Nesne nin veri tipi: " + nesne.GetType() );
        Console.WriteLine("nesne nin değeri: " + nesne );

    }
}
