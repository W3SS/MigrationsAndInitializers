using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaApp.DataLayer;

namespace AutomatedTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void CanUseDropCreateAlwaysWithInitializer()
    {
     Database.SetInitializer(new NinjaInitializer());
      using (var context = new NinjaContext())
      {
        context.Ninjas.ToList();
      }
      Assert.Inconclusive("nothing to see here");
    }
  }
}