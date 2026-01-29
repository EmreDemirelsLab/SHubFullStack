namespace Konu14InterfacesArayuzler;

public interface OrnekArayuz // class yerine interface kelimesini kullanarak tanımlıyoruz.
{
    public int Id {get; set; }
}
interface IDemo
{
    void Goster(); // metot imzası
}

interface icerebilecekleri : IDemo // interface ler başka interfacelerden miras alabilirler.
{
    // bu interface i kullanacak olan classlar aşağıdaki varlıkları kullanmak zorundadır.
    public int sayi {get; set;}
    public static int sayi2 {get; set;}
    // interfacelerde metotlar değil imzaları yer alır.
    void Topla(); // geri değer döndürmeyen metot imzası.
    int ToplamaYap(); // geri int değer döndürmesi gereken metot imzası
}
class ArayuzKullanimi : icerebilecekleri // bu şekilde miras aldığımızda interface ler içerisindeki varlıklar class ta kullanmak zorundadır.
{
    public int sayi {get; set;} 

    public int Id {get; set; } // class içerisinde interface de olmayan ama class ta olması gereken property veya metotlar bulunabilir.

    public void Goster() // interfacede imzası bulunan metot class içinde kullanılmak zorundadır.
    {
        Console.WriteLine("void Goster metodu");
    }

    public void Topla()
    {
        Console.WriteLine("void Topla metodu");
    }

    public int ToplamaYap()
    {
        return sayi + 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konu14InterfacesArayuzler");
        ArayuzKullanimi arayuz = new ArayuzKullanimi();
        arayuz.sayi = 1;
        arayuz.Topla();
        arayuz.Goster();
        Console.WriteLine("Toplama sonucu: " + arayuz.ToplamaYap());
    }
}
