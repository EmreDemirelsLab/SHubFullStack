# 🎓 C# Eğitimi - Sıfırdan Zirveye!
## Konu 1'den Konu 16'ya Kadar Tam Özet

---

## 📦 KONU 1: Değişkenler (Variables)

> **Gerçek Hayat Benzetmesi:** Düşün ki evinde çeşitli kutular var. Bir kutuya "yumurta" yazıp içine yumurta koyuyorsun, başka kutuya "kitap" yazıp kitap koyuyorsun. İşte **değişkenler** de bilgisayarın hafızasındaki bu kutular gibidir!

```csharp
// 🥡 Kutu (Değişken) oluşturma
string isim = "Ali";      // Metin kutusu
int yas = 25;             // Sayı kutusu  
bool ehliyet = true;      // Evet/Hayır kutusu
double kilo = 75.5;       // Ondalıklı sayı kutusu
```

**Önemli Veri Tipleri:**

| Tip | Anlamı | Örnek | Gerçek Hayat |
|-----|--------|-------|--------------|
| `byte` | Küçük sayı | 0-255 | Plaka kodu (34) |
| `int` | Tam sayı | 123456 | Yaş, telefon numarası |
| `string` | Metin | "Merhaba" | İsim, adres |
| `bool` | Doğru/Yanlış | true/false | Işık açık mı? |
| `double` | Ondalıklı | 3.14 | Boy, kilo, fiyat |
| `decimal` | Hassas para | 99.99 TL | Ürün fiyatları |

**`var` kullanımı:** C#'a "Kutunun tipini sen anla kardeşim!" demek:
```csharp
var urunAdi = "Telefon";  // C# otomatik string anlar
var fiyat = 9999;         // C# otomatik int anlar
```

**`const` (Sabit):** Bir kez yaz, bir daha değişmesin! KDV oranı gibi:
```csharp
const int KDV = 18;  // Sabit, değiştirilemez!
```

---

## 🔄 KONU 2: Tip Dönüşümleri (Type Casting)

> **Gerçek Hayat Benzetmesi:** Elma suyu yaparken elmaları (katı) suya (sıvı) dönüştürürsün ya, işte tip dönüşümü de böyledir!

### 1️⃣ Otomatik Dönüşüm (Implicit)
Küçük kutu → Büyük kutu (Sorun yok!)
```csharp
int yas = 25;
double kesirliYas = yas;  // 25 → 25.0 (Otomatik!)
```

### 2️⃣ Manuel Dönüşüm (Explicit)
Büyük kutu → Küçük kutu (Dikkatli ol!)
```csharp
double fiyat = 99.99;
int tamFiyat = (int)fiyat;  // 99.99 → 99 (Küsürat gider!)
```

### 3️⃣ Parse ile Dönüşüm
Metni sayıya çevirme (Kullanıcı girişleri için):
```csharp
string giris = "25";
int yas = int.Parse(giris);  // "25" → 25
```

### 4️⃣ Convert Sınıfı
Her türlü dönüşüm için:
```csharp
Convert.ToString(25);     // 25 → "25"
Convert.ToInt32("25");    // "25" → 25
Convert.ToDouble("3.14"); // "3.14" → 3.14
```

---

## ➕ KONU 3: Operatörler (Operators)

> **Gerçek Hayat Benzetmesi:** Hesap makinesi gibi düşün! Toplama, çıkarma, karşılaştırma...

### Aritmetik Operatörler (Matematik)
```csharp
int a = 10, b = 3;

a + b  // 13  (Toplama)
a - b  // 7   (Çıkarma)
a * b  // 30  (Çarpma)
a / b  // 3   (Bölme)
a % b  // 1   (Kalan - Modül)
```

### Artırım/Azaltım
```csharp
int sayi = 5;
sayi++;  // 6 olur (Bir arttır)
sayi--;  // 5 olur (Bir azalt)
```

### Karşılaştırma Operatörleri
```csharp
a == b  // Eşit mi?      (10 == 3 → false)
a != b  // Eşit değil mi? (10 != 3 → true)
a > b   // Büyük mü?     (10 > 3 → true)
a < b   // Küçük mü?     (10 < 3 → false)
a >= b  // Büyük eşit mi?
a <= b  // Küçük eşit mi?
```

### Mantıksal Operatörler
> **Gerçek Hayat:** Giriş yaparken hem kullanıcı adı hem şifre doğru mu?

```csharp
// && (VE) - Her ikisi de doğru olmalı
(kullaniciAdi == "admin" && sifre == "12345")

// || (VEYA) - Biri doğru olsa yeter
(kullaniciAdi == "admin" || sifre == "12345")
```

### Ternary Operatörü (Kısa If)
```csharp
// Eğer yaş 18'den büyükse "Yetişkin", değilse "Çocuk"
string durum = (yas > 18) ? "Yetişkin" : "Çocuk";
```

---

## 🚦 KONU 4: Karar Yapıları (If-Else, Switch)

> **Gerçek Hayat Benzetmesi:** Trafik ışığı gibi! Yeşilse geç, kırmızıysa dur...

### If-Else Yapısı
```csharp
int saat = 14;

if (saat < 12)
{
    Console.WriteLine("Günaydın!");  // Saat 12'den önce
}
else if (saat < 18)
{
    Console.WriteLine("İyi günler!"); // Saat 12-18 arası
}
else
{
    Console.WriteLine("İyi akşamlar!"); // Saat 18'den sonra
}
```

### Switch-Case (Çoklu Seçim)
> **Gerçek Hayat:** Asansörde kat seçimi gibi!

```csharp
int ay = 2;  // Şubat

switch (ay)
{
    case 12: case 1: case 2:
        Console.WriteLine("Kış");
        break;
    case 3: case 4: case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6: case 7: case 8:
        Console.WriteLine("Yaz");
        break;
    default:
        Console.WriteLine("Bilinmeyen ay");
        break;
}
```

---

## 🔧 KONU 5: Metodlar (Methods)

> **Gerçek Hayat Benzetmesi:** Bir makinenin düğmesi gibi! Basınca bir iş yapar.

### Void Metod (Geriye Değer Döndürmez)
```csharp
static void SelamVer()  // Geriye bir şey vermez, sadece yapar
{
    Console.WriteLine("Merhaba!");
}

// Kullanım:
SelamVer();  // Çıktı: Merhaba!
```

### Parametreli Metod
```csharp
static void Topla(int sayi1, int sayi2)
{
    Console.WriteLine(sayi1 + sayi2);
}

// Kullanım:
Topla(5, 3);  // Çıktı: 8
```

### Değer Döndüren Metod
```csharp
static int ToplaVeDondur(int a, int b)
{
    return a + b;  // Sonucu geri verir
}

// Kullanım:
int sonuc = ToplaVeDondur(5, 3);  // sonuc = 8
```

---

## 📚 KONU 6: Diziler (Arrays)

> **Gerçek Hayat Benzetmesi:** Okuldaki sıralar! Her öğrencinin bir numarası (indis) var.

```csharp
// 5 öğrencilik sıra oluştur
string[] ogrenciler = new string[5];

// Sıralara öğrenci yerleştir
ogrenciler[0] = "Ali";      // 1. sıra
ogrenciler[1] = "Ayşe";     // 2. sıra
ogrenciler[2] = "Mehmet";   // 3. sıra

// Öğrenci oku
Console.WriteLine(ogrenciler[0]);  // Çıktı: Ali

// Direkt değer atama
int[] notlar = { 85, 90, 75, 100, 60 };
Console.WriteLine(notlar[3]);  // Çıktı: 100
```

⚠️ **Önemli:** Dizi indisleri **0'dan başlar!**

---

## 🔄 KONU 7: Döngüler (Loops)

> **Gerçek Hayat Benzetmesi:** Ferris tekeri (Dönme dolap) gibi! Belirli sayıda döner.

### For Döngüsü (Belirli sayıda)
```csharp
// 0'dan 4'e kadar döner (5 kez)
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Tur: " + i);
}
// Çıktı: Tur: 0, Tur: 1, Tur: 2, Tur: 3, Tur: 4
```

### While Döngüsü (Şart sağlandıkça)
```csharp
int j = 0;
while (j < 5)  // j 5'ten küçük olduğu sürece
{
    Console.WriteLine(j);
    j++;  // Unutursan sonsuz döngü olur!
}
```

### Do-While (Önce yap, sonra kontrol et)
```csharp
int sayi = 5;
do
{
    Console.WriteLine(sayi);
    sayi++;
} while (sayi < 5);  // Şart yanlış bile olsa 1 kez çalışır!
```

### Foreach (Her eleman için)
```csharp
string[] meyveler = { "Elma", "Armut", "Çilek" };

foreach (var meyve in meyveler)
{
    Console.WriteLine(meyve);
}
// Çıktı: Elma, Armut, Çilek
```

---

## 🏠 KONU 8: Sınıflar (Classes)

> **Gerçek Hayat Benzetmesi:** **Kalıp (Şablon)** gibi! Ev kalıbından (class) birçok ev (nesne) yaparsın.

```csharp
// KALIP (Şablon) oluşturma
class Araba
{
    // Özellikler (Properties)
    public string Marka;
    public string Model;
    public int Yil;
    
    // Davranışlar (Metodlar)
    public void Calistir()
    {
        Console.WriteLine("Araba çalıştı!");
    }
}

// Kullanım:
Araba benimArabam = new Araba();
benimArabam.Marka = "Toyota";
benimArabam.Model = "Corolla";
benimArabam.Yil = 2024;

benimArabam.Calistir();
```

**Object Initializer** (Kısa yazım):
```csharp
Araba araba = new Araba()
{
    Marka = "BMW",
    Model = "X5",
    Yil = 2023
};
```

### Erişim Belirteçleri
| Belirteç | Anlamı | Örnek |
|----------|--------|-------|
| `public` | Herkes görebilir | Evin kapısı |
| `private` | Sadece kendi sınıfı | Evin kasası |
| `protected` | Aile üyeleri | Anahtarlık |
| `internal` | Aynı proje | Apartman sakinleri |

---

## 🧱 KONU 9: Struct Yapılar

> **Gerçek Hayat Benzetmesi:** **Hafif class** gibi! Basit veriler için kullanılır.

```csharp
public struct Nokta
{
    public int X;
    public int Y;
}

// Kullanım:
Nokta nokta = new Nokta();
nokta.X = 10;
nokta.Y = 20;
```

**Class vs Struct Farkı:**
- `class` → Referans tipi (Heap'te saklanır, büyük veriler)
- `struct` → Değer tipi (Stack'te saklanır, küçük veriler)

---

## 📝 KONU 10: String Sınıfı

> **Gerçek Hayat Benzetmesi:** Metinler üzerinde sihirli işlemler!

```csharp
string metin = "Merhaba Dünya";

// Önemli Metodlar:
metin.Length;           // 13 (Karakter sayısı)
metin.ToUpper();        // "MERHABA DÜNYA"
metin.ToLower();        // "merhaba dünya"
metin.Contains("Dünya"); // true (İçeriyor mu?)
metin.Replace("Dünya", "Türkiye"); // "Merhaba Türkiye"
metin.Substring(0, 7);  // "Merhaba" (0'dan başla, 7 karakter al)
metin.Split(' ');       // ["Merhaba", "Dünya"] (Parçala)
metin.Trim();           // Baş ve sondaki boşlukları sil
metin.StartsWith("Mer"); // true (Bununla başlıyor mu?)
metin.EndsWith("ya");    // true (Bununla bitiyor mu?)
```

---

## 🎯 KONU 11: Enumlar (Numaralandırma)

> **Gerçek Hayat Benzetmesi:** Menü seçenekleri gibi! Seçenekler bellidir.

```csharp
enum Mevsimler
{
    Ilkbahar,  // 0
    Yaz,       // 1
    Sonbahar,  // 2
    Kış        // 3
}

// Özel değerler:
enum SiparisDurumu
{
    Hazirlaniyor = 1,
    Kargolandı = 2,
    TeslimEdildi = 3
}

// Kullanım:
Mevsimler mevsim = Mevsimler.Yaz;
Console.WriteLine((int)mevsim);  // 1
```

---

## 👨‍👩‍👧 KONU 12: Kalıtım (Inheritance)

> **Gerçek Hayat Benzetmesi:** Aile soy ağacı gibi! Çocuk anne-babanın özelliklerini alır.

```csharp
// ANNE-BABA (Base Class)
class Arac
{
    public string Marka;
    public void KornaCal()
    {
        Console.WriteLine("Düt düt!");
    }
}

// ÇOCUK (Derived Class) - : ile miras alır
class Otomobil : Arac
{
    public string KasaTipi;
}

// Kullanım:
Otomobil araba = new Otomobil();
araba.Marka = "Toyota";     // Baba'dan geldi!
araba.KasaTipi = "Sedan";   // Kendine ait
araba.KornaCal();           // Baba'dan geldi!
```

### Polimorfizm (Çok Biçimlilik)
```csharp
class Hayvan
{
    public virtual void SesCikar()  // virtual = ezilebilir
    {
        Console.WriteLine("Ses...");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()  // override = ezdim
    {
        Console.WriteLine("Miyav!");
    }
}

class Kopek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Hav hav!");
    }
}
```

---

## 🔒 KONU 13: Kapsülleme (Encapsulation)

> **Gerçek Hayat Benzetmesi:** ATM makinesi gibi! İçerdekini göremezsin, sadece izin verilen butonlara basarsın.

```csharp
class BankaHesabi
{
    private double bakiye;  // Dışarıdan erişilemez!
    
    // Property (Özellik) - Getter ve Setter
    public double Bakiye
    {
        get { return bakiye; }  // Okuma
        set                     // Yazma
        { 
            if (value >= 0)
                bakiye = value; 
        }
    }
}

// Kısa yazım:
class Urun
{
    public string Adi { get; set; }
    public decimal Fiyat { get; set; }
}
```

---

## 📋 KONU 14: Arayüzler (Interfaces)

> **Gerçek Hayat Benzetmesi:** **Sözleşme** gibi! "Bu işi yapacaksın" der ama nasıl yapacağını söylemez.

```csharp
// SÖZLEŞME (Ne yapılacağı)
interface ILoglayici
{
    void LogYaz(string mesaj);  // Sadece imza, gövde yok!
}

// SÖZLEŞMEYİ UYGULAYAN (Nasıl yapılacağı)
class DosyaLoglayici : ILoglayici
{
    public void LogYaz(string mesaj)
    {
        // Dosyaya yaz
        File.WriteAllText("log.txt", mesaj);
    }
}

class DatabaseLoglayici : ILoglayici
{
    public void LogYaz(string mesaj)
    {
        // Veritabanına yaz
        // ...
    }
}
```

**Interface vs Abstract:**
- `interface` → Sadece ne yapılacağı (100% sözleşme)
- `abstract` → Kısmen yapılmış, kısmen sözleşme

---

## 🎨 KONU 15: Soyut Sınıflar (Abstract Classes)

> **Gerçek Hayat Benzetmesi:** **Yarım bina** gibi! Temeli atılmış ama üstü tamamlanmamış.

```csharp
abstract class Database
{
    // Tamamlanmış metod
    public void Baglan()
    {
        Console.WriteLine("Bağlanıyor...");
    }
    
    // Soyut metod (Alt sınıf yapacak)
    public abstract void SorguCalistir();
}

class SqlServer : Database
{
    public override void SorguCalistir()
    {
        Console.WriteLine("SQL sorgusu çalıştırıldı");
    }
}

class MySql : Database
{
    public override void SorguCalistir()
    {
        Console.WriteLine("MySQL sorgusu çalıştırıldı");
    }
}

// Kullanım:
Database db = new SqlServer();
db.Baglan();           // Ana classtan
db.SorguCalistir();    // Alt classtan
```

---

## 📦 KONU 16: Koleksiyonlar (Collections)

> **Gerçek Hayat Benzetmesi:** **Esnek liste** gibi! Boyutu değişebilir.

```csharp
using System.Collections;

// ArrayList - Her tipte veri alır
ArrayList liste = new ArrayList();
liste.Add("Ali");      // string
liste.Add(25);         // int
liste.Add(3.14);       // double

// Erişim
Console.WriteLine(liste[0]);  // "Ali"

// Sıralama
liste.Sort();    // A-Z sırala
liste.Reverse(); // Ters çevir

// StringCollection - Sadece string
StringCollection isimler = new StringCollection();
isimler.Add("Ayşe");
isimler.Add("Mehmet");

// Temizleme
liste.Clear();   // Hepsini sil
liste.RemoveAt(0);  // İndeksteki elemanı sil
```

**Dizi vs ArrayList:**
- `int[]` → Sabit boyutlu, hızlı
- `ArrayList` → Esnek boyutlu, yavaş

---

## 🎯 ÖZET - Önemli Kavramlar

| Konu | Anahtar Kelime | Ne İşe Yarar? |
|------|----------------|---------------|
| Değişken | `int`, `string`, `bool` | Veri saklama |
| Tip Dönüşüm | `(int)`, `Parse`, `Convert` | Veri tipi değiştirme |
| Operatör | `+`, `-`, `>`, `&&` | Hesaplama, karşılaştırma |
| Karar | `if`, `switch` | Şartlı çalışma |
| Metod | `void`, `return` | Kod tekrarını önleme |
| Dizi | `[]` | Çoklu veri saklama |
| Döngü | `for`, `while`, `foreach` | Tekrarlı işlem |
| Sınıf | `class` | Nesne oluşturma şablonu |
| Kalıtım | `:` | Özellik miras alma |
| Kapsülleme | `private`, `public` | Erişim kontrolü |
| Interface | `interface` | Sözleşme tanımlama |
| Abstract | `abstract` | Yarım sınıf |
| Collection | `ArrayList` | Esnek veri yapısı |

---

**🚀 Tebrikler! Artık C#'ın temellerini öğrendiniz!**