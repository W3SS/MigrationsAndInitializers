using System.Collections.Generic;

namespace NinjaApp.DomainClasses
{
  public class Ninja
  {
    public Ninja(string name, MilitaryRole militaryRole)
    {
      Name = name;
      MilitaryRole = militaryRole;
    }

    public Ninja()
    {
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public NinjaType NinjaType { get; set; }
    public bool ServedInOniwaban { get; set; }
    public MilitaryRole MilitaryRole { get; set; }
    public Clan Clan { get; set; }
    public int? ClanId { get; set; }
    public List<Equipment> EquipmentOwned { get; set; }
  }
}
