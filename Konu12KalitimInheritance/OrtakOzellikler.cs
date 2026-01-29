using System;

namespace Konu12KalitimInheritance;

public class OrtakOzellikler
{
    public int Id {get; set; }
    public string Name {get; set;}
    public string? Description {get; set;} // "?" Nulllable olabilir demek!
    public DateTime CreateData {get ; set; }

}
