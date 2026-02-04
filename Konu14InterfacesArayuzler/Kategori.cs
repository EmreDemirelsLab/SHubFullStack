using System;

namespace Konu14InterfacesArayuzler;

public class Kategori : ISinifGereksinimleri
{
    public int Id {get; set;} // nesnenin benzersiz kimlik değeri
    public DateTime CreateData {get; set;} // nesnenin oluşma zamanını tutacak özellik
    public DateTime UpdateDate {get; set;} // nesnesin son güncelleme zamanını tutacak özellik
    public bool IsActive {get; set;} // nesnesin aktiflik durumunu tutacak olan özellik.
    public string Name {get; set;}
    public string? Description {get; set;}
    public string? Image {get; set;}

}
