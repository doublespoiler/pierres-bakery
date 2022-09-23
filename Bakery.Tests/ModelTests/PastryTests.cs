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

    [TestMethod]
      public void CalcCost_BuyTwoForFourDollars_True()
      {
        Pastry buyTwo = new Pastry(2);
        buyTwo.CalcCost();
        Assert.AreEqual(4, buyTwo.TotalCost);
      }
  }
}