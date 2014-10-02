using System.Collections.Generic;

namespace NinjaApp.DomainClasses
{
  public class NinjaFamily
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Ninja> Ninjas { get; set; }
  }
}