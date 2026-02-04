namespace Konu15AbstractClasses;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konu15AbstractClasses");
        System.Console.WriteLine();
        // Database database = new Database(); // abstract class bu şekilde new lenemez!!!
        Database sql = new SqlServer(); // Database sınıfından bir örnek oluşturmak için alt sınıflar new lenir
        sql.Add();
        sql.Get();
        sql.Update();
        sql.Delete();

        System.Console.WriteLine();

        Database mysql = new MySql();
        mysql.Add();
        mysql.Get();
        mysql.Update();
        mysql.Delete();

    }
}

abstract class Database // class ın önüne abstract yazarak yapıyı oluşturuyoruz. 
{
    internal void Add() // kayıt ekleme metodu
    {
        System.Console.WriteLine("Ekleme Metodu çalıştı.");
    }
    internal abstract void Delete(); // silme metot imzası
    internal abstract void Update(); // güncelleme metot imzası 
    internal abstract void Get(); // veri getirme metot imzası 
    
}

class SqlServer : Database
{
    internal override void Delete() // silme metot imzası
    {
        System.Console.WriteLine("SqlServer Delete metodu çalıştı");
    }
    internal override void Update() // güncelleme metot imzası 
    {
        System.Console.WriteLine("SqlServer Update metodu çalıştı");
    }
    internal override void Get() // veri getirme metot imzası 
    {
        System.Console.WriteLine("SqlServer Get metodu çalıştı");
    }
}

class Oracle : Database
{
    internal override void Delete() // silme metot imzası
    {
        System.Console.WriteLine("Oracle Delete metodu çalıştı");
    }
    internal override void Update() // güncelleme metot imzası 
    {
        System.Console.WriteLine("Oracle Update metodu çalıştı");
    }
    internal override void Get() // veri getirme metot imzası 
    {
        System.Console.WriteLine("Oracle Update metodu çalıştı");
    }
}

class MySql : Database
{
    internal override void Delete() // silme metot imzası
    {
        System.Console.WriteLine("MySql Delete metodu çalıştı");
    }
    internal override void Update() // güncelleme metot imzası 
    {
        System.Console.WriteLine("MySql Update metodu çalıştı");
    }
    internal override void Get() // veri getirme metot imzası 
    {
        System.Console.WriteLine("MySql Update metodu çalıştı");
    }
}
