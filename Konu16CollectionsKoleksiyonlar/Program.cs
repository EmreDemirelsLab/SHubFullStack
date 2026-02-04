using System.Collections; // Koleksiyonları kullanabilmek için gerekli kütüphane
using System.Collections.Generic;
using System.Collections.Specialized;
using Konu16CollectionsKoleksiyonlar;

internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Konu16CollectionsKolleksiyonlar");
        Ornek1();
        System.Console.WriteLine();
        Ornek2();
        System.Console.WriteLine();
        Ornek3();
        System.Console.WriteLine();
        Ornek4();
        System.Console.WriteLine();
        Ornek5();
        System.Console.WriteLine();
        ListKullanimi();
    }
    static void Ornek1()
    {
        ArrayList arrayList = new();
        arrayList.Add(1);
        arrayList.Add("İki");
        arrayList.Add(3.0);
        arrayList.Add(true);
        foreach (var item in arrayList)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("ArrayList ilk eleman :" + arrayList[0]); // listede indexini verdiğimiz elemana ulaşma
    }

    static void Ornek2()
    {
        ArrayList arrayList = new();
        arrayList.Add("İstanbul");
        arrayList.Add("Ankara");
        arrayList.Add("İzmir");
        arrayList.Add("Sivas");
        arrayList.Add("Çankırı");
        arrayList.Add("Zonguldak");
        foreach ( var item in arrayList)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("ArrayList de sıralama yapabiliriz ");

        arrayList.Sort(); // a-z sıralama
        foreach (var item in arrayList)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine();

        arrayList.Reverse(); // tersten sırala
        foreach ( var item in arrayList)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine();

    }

    static void Ornek3()
    {
        var strings = new StringCollection(); // sadece string veriler varsa bunu kullan daha hızlı olur.
        strings.Add("İstanbul");
        strings.Add("Ankara");
        strings.Add("Bursa");
        //strings.Add(34); StringCollection a sadece string veriler eklenebilir.
        System.Console.WriteLine("StringCollection");
        foreach(var item in strings)
        {
            System.Console.WriteLine(item);
        }
    }

    static void Ornek4()
    {
        var dictionary = new StringDictionary(); // key value şeklinde veri saklayabilir.
        dictionary.Add("18", "Çankırı");
        dictionary.Add("06", "Angara");
        dictionary.Add("34", "İstanbul");
        dictionary.Add("01", "Adana");
        dictionary.Add("58", "Sivas");
        System.Console.WriteLine();
        foreach (var item in dictionary)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine();

        System.Console.WriteLine("dictionary.Keys:");
        foreach (var item in dictionary.Keys)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine();

        System.Console.WriteLine("dictionary.Values:");
        foreach (var item in dictionary.Values)
        {
            System.Console.WriteLine(item);
        }

        
    }

    static void Ornek5()
    {
        Dictionary<string, string> dictionary = new(); // hangi veri tipinden oluşacağını bizim belirleyeceğimiz liste sistemi
        dictionary.Add("book", "kitap");
        dictionary.Add("18", "Çankırı");
        dictionary.Add("34", "İstanbul");
        System.Console.WriteLine(dictionary["book"]); // key ini verince valuesunu verir. 

        System.Console.WriteLine();

        Dictionary<int, string> dictionary2 = new();
        dictionary2.Add(1, "Adana");
        dictionary2.Add(18, "Çankırı");
        dictionary2.Add(34, "İstanbul");

        System.Console.WriteLine("dictionary2 Values");

        foreach ( var item in dictionary2)
        {
            System.Console.WriteLine(item.Value);
        }

        System.Console.WriteLine("dictionary2 Keys");

        foreach ( var item in dictionary2)
        {
            System.Console.WriteLine(item.Key);
        }
    }

    static void ListKullanimi()
    {
        System.Console.WriteLine("Liste Kullanımı");
        List<string> sehirler = new();// string veri tipi alabilen bir liste
        sehirler.Add("Ankara");
        sehirler.Add("İstanbul");
        sehirler.Add("Kocaeli");
        sehirler.Add("Sivas 58");
        sehirler.Add("Muğla");
        System.Console.WriteLine("Şehirler");

        foreach (var item in sehirler) // sehirler isimli listede dön
        {
            System.Console.WriteLine(item); // listede ki her nesneyi ekrana yaz
        }

        System.Console.WriteLine();

        List<User> users =new();
        users.Add(new User
        {
            Id = 1,
            Name = "Emre",
            Email = "emre",
            Password = "123"

        });
        users.Add(new User
        {
            Id = 2,
            Name = "Alp",
            Email = "alp",
            Password = "123"

        });

        System.Console.WriteLine("Kullanıcılar");
        foreach ( var item in users)
        {
            System.Console.WriteLine(item.Name + " " + item.Password);

        }

        System.Console.WriteLine();

        List<User> kullanicilar = new()
        {
            new User
            {
                Id = 3,
                Name = "Merve",
                Email = "mrv",
                Password = "123"
            },
            new User
            {
                Id = 4,
                Name = "Sevgi",
                Email = "svg",
                Password = "123"
            }
        };

        System.Console.WriteLine("Kullanıcılar 2");
        foreach (var item in kullanicilar)
        {
            System.Console.WriteLine(item.Name + " " + item.Password);
        }
        System.Console.WriteLine();

        var yeniKullanici = new User
        {
            Id = 5,
            Name = "Aslan",
            Password = "789"
        };

        System.Console.WriteLine("Kullanıcılar Listesinde Yeni Kullanıcı Var mı ?");
        var varmi = kullanicilar.Contains(yeniKullanici); // Contains metodu ile bir listede arama yapabiliriz.
        System.Console.WriteLine("Var Mı ? " + varmi);
        kullanicilar.Add(yeniKullanici);
        System.Console.WriteLine("Şimdi Var mı ? " + kullanicilar.Contains(yeniKullanici));
        System.Console.WriteLine();
        System.Console.WriteLine("Kulanıcılar 3");
        foreach (var item in kullanicilar)
        {
            System.Console.WriteLine(item.Name + " " + item.Password);
        }
        System.Console.WriteLine();

        kullanicilar.AddRange(users); // AddRange metodu listeye çoklu kayıt eklememizi sağlar.
        kullanicilar.Insert(0, yeniKullanici); // Insert metodu listeye verdiğimiz indexe ekleme yapmamızı sağlar.

        System.Console.WriteLine();

        System.Console.WriteLine("Kulanıcılar 4");
        foreach (var item in kullanicilar)
        {
            System.Console.WriteLine(item.Name + " " + item.Password);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Listedeki kayıt sayısı: " + kullanicilar.Count); // Count listedeki eleman sayısını getirir.


    }
}




        



