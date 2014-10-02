using System.Collections.Generic;
using System.Data.Entity;
using NinjaApp.DomainClasses;

namespace NinjaApp.DataLayer
{
  public class NinjaContext : DbContext
  {
    public DbSet<Ninja> Ninjas { get; set; }
    public DbSet<NinjaFamily> NinjaFamilies { get; set; }
    public DbSet<Clan> Clans { get; set; }
  }

  public class NinjaInitializer : DropCreateDatabaseAlways<NinjaContext>
  {
    protected override void Seed(NinjaContext context)
    {
      var ninja = new Ninja {Name = "JuliaSan", Clan = new Clan {ClanName = "Vermont Warriors"}};
      var family = new NinjaFamily {Name = "Tribe of Sampson", Ninjas = new List<Ninja>{ninja}};
      context.NinjaFamilies.Add(family);

      base.Seed(context);
    }
  }
}