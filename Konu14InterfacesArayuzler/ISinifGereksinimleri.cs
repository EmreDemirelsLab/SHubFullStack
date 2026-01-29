using System;

namespace Konu14InterfacesArayuzler;

public interface ISinifGereksinimleri // bu interface her class ta bulunması gereken zorunlu özellikleri içeriyor.
{
    public int Id {get; set;} // nesnenin benzersiz kimlik değeri
    public DateTime CreateData {get; set;} // nesnenin oluşma zamanını tutacak özellik
    public DateTime UpdateDate {get; set;} // nesnesin son güncelleme zamanını tutacak özellik
    public bool IsActive {get; set;} // nesnesin aktiflik durumunu tutacak olan özellik.

}
