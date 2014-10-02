using System.Collections.Generic;

namespace NinjaApp.DomainClasses
{
  public class Equipment
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public EquipmentType EquipmentType { get; set; }
    public List<Ninja> Ninjas { get; set; }
  }
}