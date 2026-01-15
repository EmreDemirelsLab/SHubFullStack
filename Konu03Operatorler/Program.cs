namespace Konu03Operatorler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konu 03 Operatörler!");
        Console.WriteLine("1 - Aritmetik Operatörler");
        double sayi1 = 3;
        double sayi2 = 4;
        double sayi3 = 5;
        Console.WriteLine();
        Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");// string tırnağının önüne $ işareti koyarak string interpolasyonu yapıyoruz.
        Console.WriteLine("1234" + sayi3); // concatenation (birleştirme) işlemi. stirng ile int türündeki değişkeni birleştirir.
        Console.WriteLine();

        Console.WriteLine("Hesaplama İşlemleri:");
        Console.WriteLine("sayi1 + sayi2 : " + (sayi1 + sayi2));
        Console.WriteLine("sayi1 - sayi2 : " + (sayi1 - sayi2));
        Console.WriteLine("sayi1 * sayi2 : " + (sayi1 * sayi2));
        Console.WriteLine("sayi1 / sayi2 : " + (sayi1 / sayi2));
        Console.WriteLine("sayi1 % sayi2 : " + (sayi1 % sayi2));

        Console.WriteLine();

        Console.WriteLine("2 - Attırım ve Azaltım Operatörleri");
        sayi2++; // sayi2 = sayi2 + 1
        Console.WriteLine("sayi2: " + sayi2);
        sayi2--; // sayi2 = sayi2 - 1
        Console.WriteLine("sayi2: " + sayi2);

        Console.WriteLine();

        Console.WriteLine("3 - Atama Operatörleri");
        Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
        Console.WriteLine("sayi1 += sayi2 : " + (sayi1 += sayi2)); // sayi1 = sayi1 + sayi2 yani sayi1 in değerini değiştirioruz.
        Console.WriteLine("sayi1 -= sayi2 : " + (sayi1 -= sayi2));
        Console.WriteLine("sayi1 *= sayi2 : " + (sayi1 *= sayi2));
        Console.WriteLine("sayi1 /= sayi2 : " + (sayi1 /= sayi2));
        Console.WriteLine("sayi1 %= sayi2 : " + (sayi1 %= sayi2));

        Console.WriteLine();

        Console.WriteLine("4 - ilişkisel (Karşılaştırmalı) Operatörler"); // birden fazla değeri karşılaştırmak için kullanılır.
        Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
        Console.WriteLine("sayi1 == sayi2 : " + (sayi1 == sayi2)); // eşit mi diye bakar, true veya false döner.
        Console.WriteLine("sayi1 != sayi2 : " + (sayi1 != sayi2)); // eşit değil mi diye bakar, true veya false döner.
        Console.WriteLine("sayi1 > sayi2 : " + (sayi1 > sayi2)); // büyük mü diye bakar, true veya false döner.
        Console.WriteLine("sayi1 < sayi2 : " + (sayi1 < sayi2)); // küçük mü diye bakar, true veya false döner.
        Console.WriteLine("sayi1 >= sayi2 : " + (sayi1 >= sayi2)); // büyük eşit mi diye bakar, true veya false döner.
        Console.WriteLine("sayi1 <= sayi2 : " + (sayi1 <= sayi2)); // küçük eşit mi diye bakar, true veya false döner.   

        Console.WriteLine();

        Console.WriteLine("5 - Ternary Operatörler"); // eğer karşılaştırma için 2 değer kullanacaksak karşılaştırmanın kısayolu olarak kullanılır.
        Console.WriteLine("Ternary: "); // ? ile kullanılır.
        Console.WriteLine((sayi1==sayi2) ? "sayi1 sayi2 ye eşittir." : "sayi1 sayi2 ye eşit değildir."); // eğer sayi1 sayi2 ye eşitse birinci değeri değilse ikinci değeri yazdırır.


        Console.WriteLine();

        Console.WriteLine("6 - Mantıksal Operatörler"); // birden fazla karşılaştırma işlemi yaparken kullanılır.

        // And Operatörü &&  &
        Console.WriteLine("And & operatörü:");
        Console.WriteLine("& Operatoru her iki koşulunda true olması durumunda true döner.");
        Console.WriteLine((sayi1 < sayi2) && (sayi1 == sayi2) ? "sayi1 sayi2 ye eşittir." : "sayi1 sayi2 ye eşit değildir.");

        string email = "admin@site.com", sifre = "12345";
        Console.WriteLine("Email Giriniz:");
        var girilenEmail = Console.ReadLine();
        Console.WriteLine("Şifre Giriniz:");
        var girilenSifre = Console.ReadLine();
        Console.WriteLine(girilenEmail == email && girilenSifre == sifre ? "Giriş Başarılı" : "Giriş Başarısız"); // çift && olursa ilk koşul false ise ikinci koşula bakmaz. tek & olursa her iki koşula da bakar.ilki yanlış olsada ikincisine de bakar.

        // Or Operatörü ||  |
        Console.WriteLine();
        Console.WriteLine("Or | operatörü:");
        Console.WriteLine("| Operatoru koşullardan en az birinin true olması durumunda true döner.");
        Console.WriteLine(girilenEmail == email | girilenSifre == sifre ? "Giriş Başarılı" : "Giriş Başarısız"); 

        

    }
}
