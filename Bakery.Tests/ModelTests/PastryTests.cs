using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
  [TestMethod]
    public void CalcCost_BuyOneForTwoDollars_True()
    {
      Pastry buyOne = new Pastry(1);
      buyOne.CalcCost();
      Assert.AreEqual(2, buyOne.TotalCost);
    }
  }
}